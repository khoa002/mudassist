using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using Clio.Utilities;
using ff14bot;
using ff14bot.Helpers;
using ff14bot.Managers;
using ff14bot.Navigation;
using ff14bot.Objects;
using Mud.Settings;

namespace Mud.Helpers
{
    public class Waypoint
    {
        private static readonly DateTime LastHardpoint = DateTime.Now;
        private readonly bool _isHardPoint;
        private readonly string _name;
        internal Vector3 Location;

        public Waypoint(GameObject obj)
        {
            var hard = IsValid(obj.Location) && DateTime.Now.Subtract(LastHardpoint) > TimeSpan.FromSeconds(5);
            _name = obj.Name;
            Location = obj.Location;
            _isHardPoint = hard;
        }

        public Waypoint(GameObject obj, bool hardPoint)
        {
            _name = obj.Name;
            Location = obj.Location;
            _isHardPoint = hardPoint;
        }

        public float Distance(Waypoint other)
        {
            return Location.Distance3D(other.Location);
        }

        public Waypoint Ground()
        {
            Vector3 rayStart = new Vector3(Location.X, Location.Y + 0.25f, Location.Z),
                rayEnd = new Vector3(Location.X, Location.Y - 10f, Location.Z);
            WorldManager.Raycast(rayStart, rayEnd, out var hit, out var distances);
            if (IsValid(hit)) Location = hit;
            return this;
        }

        public static bool InLineOfSight(Waypoint other)
        {
            return InLineOfSight(other, 1) && InLineOfSight(other, 2) && InLineOfSight(other, 3);
        }

        public bool IsCloserThan(Waypoint other)
        {
            return Core.Player.Location.Distance3D(Location) < Core.Player.Location.Distance3D(other.Location);
        }

        public override string ToString()
        {
            return _name + " - " + Location + " Hardpoint: " + _isHardPoint;
        }

        private static bool IsValid(Vector3 loc)
        {
            return !(loc.X == 0 && loc.Y == 0 && loc.Z == 0);
        }

        private static bool InLineOfSight(Waypoint other, int offsetY)
        {
            Vector3 start = Core.Player.Location, end = other.Location, hit, distances;
            start.Y = start.Y + offsetY;
            end.Y = end.Y + offsetY;
            WorldManager.Raycast(start, end, out hit, out distances);
            return !IsValid(hit);
        }
    }

    public static class WaypointManager
    {
        private const int WaypointDistance = 2;
        private const bool IsNavigating = false;
        private static GameObject _moveTarget;
        private static readonly Queue<Waypoint> CurrentWaypoints = new Queue<Waypoint>();

        public static Waypoint Next
        {
            get
            {
                if (CurrentWaypoints.Count == 0) return null;
                var peek = CurrentWaypoints.Peek();

                // Don't Skip Hardpoints
                if (CurrentWaypoints.Count > 1)
                {
                    var peek2 = CurrentWaypoints.ToArray()[1];
                    if (peek2.IsCloserThan(peek) && Waypoint.InLineOfSight(new Waypoint(Core.Player)))
                    {
                        Logging.Write(Colors.SaddleBrown,
                            $@"[MudAssist] ==> Skipping Waypoint: {CurrentWaypoints.Dequeue()}");
                        return Next;
                    }
                }

                if (peek.Distance(new Waypoint(Core.Player)) > 0.25) return peek;
                Logging.Write(Colors.SaddleBrown, $@"[MudAssist] ==> Reached Waypoint: {CurrentWaypoints.Dequeue()}");
                return Next;
            }
        }

        internal static bool isNavigating => IsNavigating;

        public static void TrackMelee()
        {
            var moveTarget = GetMoveTargetMelee();
            if (moveTarget == null) return;
            if (CurrentWaypoints.Count > 0)
            {
                var lastWaypoint = CurrentWaypoints.Last();
                var nextWaypoint = new Waypoint(moveTarget);
                if (lastWaypoint.Distance(nextWaypoint) > WaypointDistance)
                    CurrentWaypoints.Enqueue(nextWaypoint.Ground());
            }
            else
            {
                var nextWaypoint = new Waypoint(moveTarget).Ground();
                CurrentWaypoints.Enqueue(nextWaypoint);
            }
        }

        public static void TrackRanged()
        {
            var moveTarget = GetMoveTargetRanged();
            if (moveTarget == null) return;
            if (CurrentWaypoints.Count > 0)
            {
                var lastWaypoint = CurrentWaypoints.Last();
                var nextWaypoint = new Waypoint(moveTarget);
                if (lastWaypoint.Distance(nextWaypoint) > WaypointDistance)
                    CurrentWaypoints.Enqueue(nextWaypoint.Ground());
            }
            else
            {
                var nextWaypoint = new Waypoint(moveTarget).Ground();
                CurrentWaypoints.Enqueue(nextWaypoint);
            }
        }

        // Needs Work
        internal static bool IsStuck()
        {
            return isNavigating && (!MovementManager.IsMoving || MovementManager.IsMoving && MovementManager.Speed < 2);
        }

        internal static void MoveToNextMelee()
        {
            var moveTarget = GetMoveTargetMelee();
            if (GetMoveTargetMelee() != null
                // Start Navigating If > Max range
                && (!isNavigating
                    && Core.Player.Location.Distance3D(moveTarget.Location) > MudSettings.Instance.FollowRangeMax
                    // Keep Navigating If > Min Range
                    || isNavigating
                    && Core.Player.Location.Distance3D(moveTarget.Location) > MudSettings.Instance.FollowRangeMin
                    || Core.Player.Location.Distance3D(moveTarget.Location) >
                    MudSettings.Instance.TargetRangeMelee + moveTarget.CombatReach
                    && MudAssist.IsValidEnemy(Core.Player.CurrentTarget)
                    && MudAssist.InCombat))
            {
                new Waypoint(Core.Player);
                var next = Next;
                // Use Supported Navigators If Enabled & > Some Yards From Next Waypoint OR Not In LOS Of Next Waypoint
                {
                    Navigator.PlayerMover.MoveTowards(next.Location);
                }
            }
            // Otherwise Clear Waypoints
            else
            {
                CurrentWaypoints.Clear();
            }
        }

        internal static void MoveToNextRanged()
        {
            var moveTarget = GetMoveTargetRanged();
            if (GetMoveTargetRanged() != null
                // Start Navigating If > Max range
                && (!isNavigating
                    && Core.Player.Location.Distance3D(moveTarget.Location) > MudSettings.Instance.FollowRangeMax
                    // Keep Navigating If > Min Range
                    || isNavigating
                    && Core.Player.Location.Distance3D(moveTarget.Location) > MudSettings.Instance.FollowRangeMin
                    || Core.Player.Location.Distance3D(moveTarget.Location) >
                    MudSettings.Instance.TargetRangeRanged + moveTarget.CombatReach
                    && MudAssist.IsValidEnemy(Core.Player.CurrentTarget)
                    && MudAssist.InCombat))
            {
                new Waypoint(Core.Player);
                var next = Next;
                // Use Supported Navigators If Enabled & > Some Yards From Next Waypoint OR Not In LOS Of Next Waypoint
                {
                    Navigator.PlayerMover.MoveTowards(next.Location);
                }
            }
            // Otherwise Clear Waypoints
            else
            {
                CurrentWaypoints.Clear();
            }
        }

        internal static void StopNavigating()
        {
            Logging.Write(Colors.SaddleBrown, @"[MudAssist] ==> Stopping, no Waypoint");
            CurrentWaypoints.Clear();
            Navigator.PlayerMover.MoveStop();
        }

        private static GameObject GetMoveTargetMelee()
        {
            GameObject newTarget = null;
            var targetTanks = MudAssist.GetVisiblePartyMembers().Where(p => JobHelper.IsTank(p)
                                                                            && p.Location.Distance3D(Core.Player
                                                                                .Location) >=
                                                                            MudSettings.Instance.FollowRangeMin
                                                                            && Core.Player.Location.Distance3D(
                                                                                p.Location) <=
                                                                            MudSettings.Instance
                                                                                .MaxTargetDistance);
            if (Core.Player.HasTarget
                && Core.Player.CurrentTarget.Location.Distance3D(Core.Player.Location) >=
                MudSettings.Instance.TargetRangeMelee + Core.Player.CurrentTarget.CombatReach
                && Core.Player.Location.Distance3D(Core.Player.CurrentTarget.Location) <=
                MudSettings.Instance.MaxTargetDistance
                && (MudAssist.IsValidEnemy(Core.Player.CurrentTarget)
                    && Core.Player.CurrentTarget.Location.Distance3D(Core.Player.Location) >=
                    MudSettings.Instance.TargetRangeMelee + Core.Player.CurrentTarget.CombatReach
                    && (MudAssist.MovementModes[MudSettings.Instance.TargetingMode].Equals("Combat")
                        || MudAssist.MovementModes[MudSettings.Instance.TargetingMode].Equals("Tank") &&
                        MudAssist.InCombat)
                    || !MudAssist.IsValidEnemy(Core.Player.CurrentTarget)
                    && Core.Player.CurrentTarget.Location.Distance3D(Core.Player.Location) >=
                    MudSettings.Instance.FollowRangeMin
                    && MudAssist.MovementModes[MudSettings.Instance.TargetingMode].Equals("Follow")))
                newTarget = Core.Player.CurrentTarget;
            else if (targetTanks.Any() &&
                     MudAssist.MovementModes[MudSettings.Instance.TargetingMode].Equals("Tank"))
                newTarget = targetTanks.First();

            if (_moveTarget == newTarget) return _moveTarget;
            var oldTarget = _moveTarget;
            _moveTarget = newTarget;
            OnTargetChanged(oldTarget, newTarget);

            return _moveTarget;
        }

        private static GameObject GetMoveTargetRanged()
        {
            GameObject newTarget = null;
            var targetTanks = MudAssist.GetVisiblePartyMembers().Where(p => JobHelper.IsTank(p)
                                                                            && p.Location.Distance3D(Core.Player
                                                                                .Location) >=
                                                                            MudSettings.Instance.FollowRangeMin
                                                                            && Core.Player.Location.Distance3D(
                                                                                p.Location) <=
                                                                            MudSettings.Instance
                                                                                .MaxTargetDistance);
            if (Core.Player.HasTarget
                && Core.Player.CurrentTarget.Location.Distance3D(Core.Player.Location) >=
                MudSettings.Instance.TargetRangeRanged + Core.Player.CurrentTarget.CombatReach
                && Core.Player.Location.Distance3D(Core.Player.CurrentTarget.Location) <=
                MudSettings.Instance.MaxTargetDistance
                && (MudAssist.IsValidEnemy(Core.Player.CurrentTarget)
                    && Core.Player.CurrentTarget.Location.Distance3D(Core.Player.Location) >=
                    MudSettings.Instance.TargetRangeRanged + Core.Player.CurrentTarget.CombatReach
                    && (MudAssist.MovementModes[MudSettings.Instance.TargetingMode].Equals("Combat")
                        || MudAssist.MovementModes[MudSettings.Instance.TargetingMode].Equals("Tank") &&
                        MudAssist.InCombat)
                    || !MudAssist.IsValidEnemy(Core.Player.CurrentTarget)
                    && Core.Player.CurrentTarget.Location.Distance3D(Core.Player.Location) >=
                    MudSettings.Instance.FollowRangeMin
                    && MudAssist.MovementModes[MudSettings.Instance.TargetingMode].Equals("Follow")))
                newTarget = Core.Player.CurrentTarget;
            else if (targetTanks.Any() &&
                     MudAssist.MovementModes[MudSettings.Instance.TargetingMode].Equals("Tank"))
                newTarget = targetTanks.First();

            if (_moveTarget == newTarget) return _moveTarget;
            var oldTarget = _moveTarget;
            _moveTarget = newTarget;
            OnTargetChanged(oldTarget, newTarget);

            return _moveTarget;
        }

        private static void OnTargetChanged(GameObject oldTarget, GameObject newTarget)
        {
            CurrentWaypoints.Clear();
            if (JobHelper.IsMeleeDps(Core.Player) || JobHelper.IsTank(Core.Player)) TrackMelee();
            else if (JobHelper.IsHealer(Core.Player) || JobHelper.IsRangedDps(Core.Player))
                TrackRanged();
        }
    }
}