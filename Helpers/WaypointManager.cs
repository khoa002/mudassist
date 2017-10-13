using Clio.Utilities;
using ff14bot;
using ff14bot.Helpers;
using ff14bot.Managers;
using ff14bot.Navigation;
using ff14bot.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;

namespace Mud.Helpers
{
	public class Waypoint
	{
		public bool IsHardPoint;
		public Vector3 Location;
		public string Name;
		private static DateTime LastHardpoint = DateTime.Now;

		public Waypoint(GameObject obj)
		{
			bool hard = IsValid(obj.Location) && DateTime.Now.Subtract(LastHardpoint) > TimeSpan.FromSeconds(5);
			if (hard) LastHardpoint = DateTime.Now;
			Name = obj.Name;
			Location = obj.Location;
			IsHardPoint = hard;
		}

		public Waypoint(GameObject obj, bool hardPoint)
		{
			Name = obj.Name;
			Location = obj.Location;
			IsHardPoint = hardPoint;
		}

		public float Distance(Waypoint other) => (Location.Distance3D(other.Location));

		public Waypoint Ground()
		{
			Vector3 rayStart = new Vector3(Location.X, Location.Y + 0.25f, Location.Z), rayEnd = new Vector3(Location.X, Location.Y - 10f, Location.Z), hit, distances;
			WorldManager.Raycast(rayStart, rayEnd, out hit, out distances);
			if (IsValid(hit)) Location = hit;
			return this;
		}

		public bool InLineOfSight(Waypoint other) => InLineOfSight(other, 1) && InLineOfSight(other, 2) && InLineOfSight(other, 3);
		public bool IsCloserThan(Waypoint other) => (Core.Player.Location.Distance3D(Location) < Core.Player.Location.Distance3D(other.Location));
		public override string ToString() => Name + " - " + Location + " Hardpoint: " + IsHardPoint;
		private static bool IsValid(Vector3 loc) => !(loc.X == 0 && loc.Y == 0 && loc.Z == 0);

		private bool InLineOfSight(Waypoint other, int offsetY)
		{
			Vector3 start = Core.Player.Location, end = other.Location, hit, distances;
			start.Y = start.Y + offsetY;
			end.Y = end.Y + offsetY;
			WorldManager.Raycast(start, end, out hit, out distances);
			return !IsValid(hit);
		}
	}

	public class WaypointManager
	{
		public const int WAYPOINT_DISTANCE = 2;
		public static bool IsNavigating;
		private static GameObject _MoveTarget;
		private static Queue<Waypoint> CurrentWaypoints = new Queue<Waypoint>();

		public static Waypoint Next
		{
			get
			{
				if (CurrentWaypoints.Count == 0) return null;
				Waypoint peek = CurrentWaypoints.Peek();
				// Don't Skip Hardpoints
				if (CurrentWaypoints.Count > 1)
				{
					Waypoint peek2 = CurrentWaypoints.ToArray()[1];
					if (peek2.IsCloserThan(peek) && peek2.InLineOfSight(new Waypoint(Core.Player)))
					{
						Logging.Write(Colors.SaddleBrown, $@"[MudAssist] ==> Skipping Waypoint: {CurrentWaypoints.Dequeue()}");
						return Next;
					}
				}
				if (peek.Distance(new Waypoint(Core.Player)) > 0.25) return peek;
				Logging.Write(Colors.SaddleBrown, $@"[MudAssist] ==> Reached Waypoint: {CurrentWaypoints.Dequeue()}");
				return Next;
			}
		}

		public static void TrackMelee()
		{
			GameObject moveTarget = GetMoveTargetMelee();
			if (moveTarget != null)
			{
				if (CurrentWaypoints.Count > 0)
				{
					Waypoint lastWaypoint = CurrentWaypoints.Last();
					Waypoint nextWaypoint = new Waypoint(moveTarget);
					if (lastWaypoint.Distance(nextWaypoint) > WAYPOINT_DISTANCE) CurrentWaypoints.Enqueue(nextWaypoint.Ground());
				}
				else
				{
					Waypoint nextWaypoint = new Waypoint(moveTarget).Ground();
					CurrentWaypoints.Enqueue(nextWaypoint);
				}
			}
		}

		public static void TrackRanged()
		{
			GameObject moveTarget = GetMoveTargetRanged();
			if (moveTarget != null)
			{
				if (CurrentWaypoints.Count > 0)
				{
					Waypoint lastWaypoint = CurrentWaypoints.Last();
					Waypoint nextWaypoint = new Waypoint(moveTarget);
					if (lastWaypoint.Distance(nextWaypoint) > WAYPOINT_DISTANCE) CurrentWaypoints.Enqueue(nextWaypoint.Ground());
				}
				else
				{
					Waypoint nextWaypoint = new Waypoint(moveTarget).Ground();
					CurrentWaypoints.Enqueue(nextWaypoint);
				}
			}
		}

		// Needs Work
		internal static bool IsStuck() => IsNavigating && (!MovementManager.IsMoving || MovementManager.IsMoving && MovementManager.Speed < 2);

		internal static void MoveToNextMelee()
		{
			GameObject moveTarget = GetMoveTargetMelee();
			if (GetMoveTargetMelee() != null
				// Start Navigating If > Max range
				&& ((!IsNavigating
				&& Core.Player.Location.Distance3D(moveTarget.Location) > (float)MudAssist.Settings.FollowRangeMax)
				// Keep Navigating If > Min Range
				|| (IsNavigating
				&& (Core.Player.Location.Distance3D(moveTarget.Location) > (float)MudAssist.Settings.FollowRangeMin))
				|| (Core.Player.Location.Distance3D(moveTarget.Location) > ((float)MudAssist.Settings.TargetRangeMelee + moveTarget.CombatReach)
				&& MudAssist.IsValidEnemy(Core.Player.CurrentTarget)
				&& MudAssist.InCombat)))
			{
				new Waypoint(Core.Player);
				Waypoint next = Next;
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
			GameObject moveTarget = GetMoveTargetRanged();
			if (GetMoveTargetRanged() != null
				// Start Navigating If > Max range
				&& ((!IsNavigating
				&& Core.Player.Location.Distance3D(moveTarget.Location) > (float)MudAssist.Settings.FollowRangeMax)
				// Keep Navigating If > Min Range
				|| (IsNavigating
				&& (Core.Player.Location.Distance3D(moveTarget.Location) > (float)MudAssist.Settings.FollowRangeMin))
				|| (Core.Player.Location.Distance3D(moveTarget.Location) > ((float)MudAssist.Settings.TargetRangeRanged + moveTarget.CombatReach)
				&& MudAssist.IsValidEnemy(Core.Player.CurrentTarget)
				&& MudAssist.InCombat)))
			{
				new Waypoint(Core.Player);
				Waypoint next = Next;
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
			Logging.Write(Colors.SaddleBrown, $"[MudAssist] ==> Stopping, no Waypoint");
			CurrentWaypoints.Clear();
			Navigator.PlayerMover.MoveStop();
		}

		private static GameObject GetMoveTargetMelee()
		{
			GameObject newTarget = null;
			IEnumerable<Character> targetTanks = MudAssist.GetVisiblePartyMembers().Where(p => JobHelper.IsTank(p)
				&& p.Location.Distance3D(Core.Player.Location) >= (float)MudAssist.Settings.FollowRangeMin
				&& Core.Player.Location.Distance3D(p.Location) <= (float)MudAssist.Settings.MaxTargetDistance);
			if (Core.Player.HasTarget
				&& Core.Player.CurrentTarget.Location.Distance3D(Core.Player.Location) >= ((float)MudAssist.Settings.TargetRangeMelee + Core.Player.CurrentTarget.CombatReach)
				&& Core.Player.Location.Distance3D(Core.Player.CurrentTarget.Location) <= (float)MudAssist.Settings.MaxTargetDistance
				&& ((MudAssist.IsValidEnemy(Core.Player.CurrentTarget)
				&& Core.Player.CurrentTarget.Location.Distance3D(Core.Player.Location) >= ((float)MudAssist.Settings.TargetRangeMelee + Core.Player.CurrentTarget.CombatReach)
				&& (MudAssist.MovementModes[MudAssist.Settings.TargetingMode].Equals("Combat")
				|| (MudAssist.MovementModes[MudAssist.Settings.TargetingMode].Equals("Tank") && MudAssist.InCombat)))
				|| (!MudAssist.IsValidEnemy(Core.Player.CurrentTarget)
				&& Core.Player.CurrentTarget.Location.Distance3D(Core.Player.Location) >= (float)MudAssist.Settings.FollowRangeMin
				&& MudAssist.MovementModes[MudAssist.Settings.TargetingMode].Equals("Follow"))))
			{
				newTarget = Core.Player.CurrentTarget;
			}
			else if (targetTanks.Count() > 0 && MudAssist.MovementModes[MudAssist.Settings.TargetingMode].Equals("Tank"))
			{
				newTarget = targetTanks.First();
			}

			if (_MoveTarget != newTarget)
			{
				GameObject oldTarget = _MoveTarget;
				_MoveTarget = newTarget;
				OnTargetChanged(oldTarget, newTarget);
			}
			return _MoveTarget;
		}

		private static GameObject GetMoveTargetRanged()
		{
			GameObject newTarget = null;
			IEnumerable<Character> targetTanks = MudAssist.GetVisiblePartyMembers().Where(p => JobHelper.IsTank(p)
				&& p.Location.Distance3D(Core.Player.Location) >= (float)MudAssist.Settings.FollowRangeMin
				&& Core.Player.Location.Distance3D(p.Location) <= (float)MudAssist.Settings.MaxTargetDistance);
			if (Core.Player.HasTarget
				&& Core.Player.CurrentTarget.Location.Distance3D(Core.Player.Location) >= ((float)MudAssist.Settings.TargetRangeRanged + Core.Player.CurrentTarget.CombatReach)
				&& Core.Player.Location.Distance3D(Core.Player.CurrentTarget.Location) <= (float)MudAssist.Settings.MaxTargetDistance
				&& ((MudAssist.IsValidEnemy(Core.Player.CurrentTarget)
				&& Core.Player.CurrentTarget.Location.Distance3D(Core.Player.Location) >= ((float)MudAssist.Settings.TargetRangeRanged + Core.Player.CurrentTarget.CombatReach)
				&& (MudAssist.MovementModes[MudAssist.Settings.TargetingMode].Equals("Combat")
				|| (MudAssist.MovementModes[MudAssist.Settings.TargetingMode].Equals("Tank") && MudAssist.InCombat)))
				|| (!MudAssist.IsValidEnemy(Core.Player.CurrentTarget)
				&& Core.Player.CurrentTarget.Location.Distance3D(Core.Player.Location) >= (float)MudAssist.Settings.FollowRangeMin
				&& MudAssist.MovementModes[MudAssist.Settings.TargetingMode].Equals("Follow"))))
			{
				newTarget = Core.Player.CurrentTarget;
			}
			else if (targetTanks.Count() > 0 && MudAssist.MovementModes[MudAssist.Settings.TargetingMode].Equals("Tank"))
			{
				newTarget = targetTanks.First();
			}

			if (_MoveTarget != newTarget)
			{
				GameObject oldTarget = _MoveTarget;
				_MoveTarget = newTarget;
				OnTargetChanged(oldTarget, newTarget);
			}
			return _MoveTarget;
		}

		private static void OnTargetChanged(GameObject oldTarget, GameObject newTarget)
		{
			CurrentWaypoints.Clear();
			if (JobHelper.IsMeleeDPS(Core.Player) || JobHelper.IsTank(Core.Player)) TrackMelee();
			else if (JobHelper.IsHealer(Core.Player) || JobHelper.IsRangedDPS(Core.Player)) TrackRanged();
		}
	}
}