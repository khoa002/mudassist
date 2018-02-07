using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using ff14bot;
using ff14bot.AClasses;
using ff14bot.Behavior;
using ff14bot.Helpers;
using ff14bot.Managers;
using ff14bot.Navigation;
using ff14bot.Objects;
using ff14bot.Pathing.Service_Navigation;
using ff14bot.RemoteAgents;
using ff14bot.RemoteWindows;
using Mud.Helpers;
using Mud.Settings;
using TreeSharp;
using Action = TreeSharp.Action;

namespace Mud
{
    public class MudAssist : BotBase
    {
        internal const string Version = "2.1.6", Beta = "BETA", BetaVer = "1";
        internal const bool IsBeta = false;
        internal static bool IsStarted;

        #region Selectable Values

        internal static readonly string[] SecondsBetweenUpdates =
            {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"};

        internal static readonly string[] ModifierKeyStrings = {"None", "Shift", "Control", "Alt"};
        internal static readonly string[] TargetingModes = {"None", "Assist Tank", "Being Tanked", "Nearest Enemy"};
        internal static readonly string[] MovementModes = {"Combat", "Tank", "Follow"};
        internal static readonly string[] SupportedNavigationProviders = {"Null", "Service Navigation"};

        internal static readonly string[] SecondsBeforeAccept =
        {
            "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19",
            "20"
        };

        #endregion Selectable Values

        #region BotBase

        public static void UpdateNavigationProvider()
        {
            switch (SupportedNavigationProviders[MudSettings.Instance.NavigationProvider])
            {
                case "Null":
                    switch (Navigator.NavigationProvider)
                    {
                        case NullProvider _:
                            return;
                        case ServiceNavigationProvider g:
                            g.Dispose();
                            break;
                    }

                    Navigator.NavigationProvider = new NullProvider();
                    Logging.Write(Colors.Brown, @"[MudAssist] ==> Using Null Navigator");
                    break;
                case "Service Navigation":
                    if (Navigator.NavigationProvider is ServiceNavigationProvider) return;
                    Navigator.NavigationProvider = new ServiceNavigationProvider();
                    Logging.Write(Colors.Brown, @"[MudAssist] ==> Using Service Navigator");
                    break;
            }
        }

        private static bool TreeTick()
        {
            if (JobHelper.IsMeleeDps(Core.Player) || JobHelper.IsTank(Core.Player))
                WaypointManager.TrackMelee();
            else if (JobHelper.IsHealer(Core.Player) || JobHelper.IsRangedDps(Core.Player))
                WaypointManager.TrackRanged();

            SettingsForm.UpdateStatus();
            return true;
        }

        #endregion BotBase

        #region Overrides

        private Composite _root;
        private SettingsForm _settings;
        public override string Name => @"MudAssist";
        public override PulseFlags PulseFlags => PulseFlags.All;
        public override bool RequiresProfile => false;

        public override Composite Root => _root ?? (_root =
                                              new Decorator
                                              (
                                                  req => TreeTick()
                                                         && !MudSettings.Instance.Paused
                                                         && Core.Player.IsAlive
                                                         && !Core.Player.IsCasting
                                                         && (!MovementManager.IsMoving
                                                             || MudSettings.Instance.ExecuteWhileMoving),
                                                  new PrioritySelector
                                                  (
                                                      // Auto Skip Cutscenes
                                                      new Decorator
                                                      (
                                                          req => MudSettings.Instance.SkipCutscenes,
                                                          new Action(a =>
                                                          {
                                                              if (!QuestLogManager.InCutscene) return;
                                                              AgentCutScene.Instance.PromptSkip();
                                                              if (!AgentCutScene.Instance.CanSkip) return;
                                                              if (SelectString.IsOpen) SelectString.ClickSlot(0);
                                                          })
                                                      ),
                                                      // Auto Talk to NPCs and/or Auto Accept/Complete Quest
                                                      new Decorator
                                                      (
                                                          req => MudSettings.Instance.TalkToNpc
                                                                 || MudSettings.Instance.AcceptQuests
                                                                 || MudSettings.Instance.CompleteQuests,
                                                          new PrioritySelector
                                                          (
                                                              // Auto Talk to NPCs
                                                              new Decorator
                                                              (
                                                                  req => MudSettings.Instance.TalkToNpc,
                                                                  new Action(a =>
                                                                  {
                                                                      if (Talk.DialogOpen) Talk.Next();
                                                                  })
                                                              ),
                                                              // Auto Accept Quests
                                                              new Decorator
                                                              (
                                                                  req => MudSettings.Instance.AcceptQuests,
                                                                  new Action(a =>
                                                                  {
                                                                      if (JournalAccept.IsOpen) JournalAccept.Accept();
                                                                  })
                                                              ),
                                                              // Auto Complete Quest
                                                              new Decorator
                                                              (
                                                                  req => MudSettings.Instance.CompleteQuests,
                                                                  new Action(a =>
                                                                  {
                                                                      // Need to find a way (that work) to auto complete it...
                                                                      // if (JournalResult.IsOpen) JournalResult.Complete();
                                                                  })
                                                              )
                                                          )
                                                      ),
                                                      // Auto Sprint
                                                      new Decorator
                                                      (
                                                          req => ActionManager.IsSprintReady
                                                                 && MovementManager.IsMoving
                                                                 && !Core.Player.IsMounted
                                                                 && (MudSettings.Instance.SprintOutOfCombat
                                                                     || MudSettings.Instance.SprintInInstance
                                                                     || MudSettings.Instance.SprintInCombat),
                                                          new PrioritySelector
                                                          (
                                                              // Auto Sprint out of combat
                                                              new Decorator
                                                              (
                                                                  req => MudSettings.Instance.SprintOutOfCombat,
                                                                  new Action(a =>
                                                                  {
                                                                      if (!Core.Player.InCombat &&
                                                                          !DutyManager.InInstance)
                                                                          ActionManager.Sprint();
                                                                  })
                                                              ),
                                                              // Auto Sprint in instance
                                                              new Decorator
                                                              (
                                                                  req => MudSettings.Instance.SprintInInstance,
                                                                  new Action(a =>
                                                                  {
                                                                      if (!Core.Player.InCombat &&
                                                                          DutyManager.InInstance)
                                                                          ActionManager.Sprint();
                                                                  })
                                                              ),
                                                              // Auto Sprint in combat
                                                              new Decorator
                                                              (
                                                                  req => MudSettings.Instance.SprintInCombat,
                                                                  new Action(a =>
                                                                  {
                                                                      if (Core.Player.InCombat)
                                                                          ActionManager.Sprint();
                                                                  })
                                                              )
                                                          )
                                                      ),
                                                      // Resting
                                                      new Decorator
                                                      (
                                                          req => RoutineManager.Current.RestBehavior != null
                                                                 && !Core.Player.InCombat
                                                                 && MudSettings.Instance.Rest
                                                                 && !Core.Player.IsMounted
                                                                 && ActionManager.IsSprintReady,
                                                          RoutineManager.Current.RestBehavior),
                                                      // Out Of Combat Healing
                                                      new Decorator
                                                      (
                                                          req => RoutineManager.Current.HealBehavior != null
                                                                 && (Core.Player.InCombat ||
                                                                     MudSettings.Instance.HealOutOfCombat)
                                                                 && !Core.Player.IsMounted
                                                                 && MudSettings.Instance.Heal,
                                                          RoutineManager.Current.HealBehavior),
                                                      // Pre-Combat Buffs
                                                      new Decorator
                                                      (
                                                          req => RoutineManager.Current.PreCombatBuffBehavior != null
                                                                 && !Core.Player.InCombat
                                                                 && !Core.Player.IsMounted
                                                                 && MudSettings.Instance.PreCombatBuff,
                                                          RoutineManager.Current.PreCombatBuffBehavior),
                                                      // Stop Moving If Moving & In Range of Target
                                                      new Decorator
                                                      (
                                                          req => MudSettings.Instance.AutoMove,
                                                          new Action(a =>
                                                          {
                                                              if (WaypointManager.isNavigating &&
                                                                  WaypointManager.Next == null)
                                                                  WaypointManager.StopNavigating();
                                                          })
                                                      ),
                                                      // Move to Target If Not in Range & Not on the Move
                                                      new Decorator
                                                      (
                                                          req => MudSettings.Instance.AutoMove,
                                                          new Action(a =>
                                                          {
                                                              if (Core.Player.IsCasting || WaypointManager.Next == null)
                                                                  return;
                                                              if (JobHelper.IsRangedDps(Core.Player) ||
                                                                  JobHelper.IsHealer(Core.Player))
                                                                  WaypointManager.MoveToNextRanged();
                                                              else if (JobHelper.IsMeleeDps(Core.Player) ||
                                                                       JobHelper.IsTank(Core.Player))
                                                                  WaypointManager.MoveToNextMelee();
                                                          })
                                                      ),
                                                      // Find Suitable Target
                                                      new Decorator
                                                      (
                                                          req => !Core.Player.HasTarget
                                                                 || !Core.Player.CurrentTarget.CanAttack,
                                                          new PrioritySelector
                                                          (
                                                              // Find Suitable Target -- Lowest HP Tanked
                                                              new Decorator
                                                              (
                                                                  req => TargetingModes[
                                                                                 MudSettings.Instance.TargetingMode]
                                                                             .Equals("Being Tanked")
                                                                         && GetVisiblePartyMembers()
                                                                             .Any(JobHelper.IsTank),
                                                                  new Action(a =>
                                                                  {
                                                                      var objs = GameObjectManager.GameObjects
                                                                          .Where(o => IsValidEnemy(o)
                                                                                      && ((Character) o).InCombat
                                                                                      && ((Character) o)
                                                                                      .CurrentTargetId ==
                                                                                      GetPartyTank().ObjectId);
                                                                      if (objs.Any())
                                                                          objs.OrderBy(o => o.CurrentHealthPercent)
                                                                              .First()
                                                                              .Target();
                                                                  })
                                                              ),
                                                              // Find Suitable Target -- Assist Tank
                                                              new Decorator
                                                              (
                                                                  req => TargetingModes[
                                                                                 MudSettings.Instance.TargetingMode]
                                                                             .Equals("Assist Tank")
                                                                         && GetVisiblePartyMembers()
                                                                             .Any(JobHelper.IsTank),
                                                                  new Action(a => Assist(GetVisiblePartyMembers()
                                                                      .First(JobHelper.IsTank))
                                                                  )
                                                              ),
                                                              // Find Suitable Target -- Nearest Enemy
                                                              new Decorator
                                                              (
                                                                  req => TargetingModes[
                                                                          MudSettings.Instance.TargetingMode]
                                                                      .Equals("Nearest Enemy"),
                                                                  new Action(a =>
                                                                  {
                                                                      var target =
                                                                          GetClosestEnemyByName(MudSettings.Instance
                                                                              .MobsToTarget);
                                                                      if (target != null)
                                                                          target.Target();
                                                                  })
                                                              )
                                                          )
                                                      ),
                                                      // Executed Out of Combat
                                                      new Decorator
                                                      (
                                                          req => !Core.Player.InCombat
                                                                 && (!PartyManager.IsInParty ||
                                                                     JobHelper.IsTank(Core.Player)),
                                                          new PrioritySelector
                                                          (
                                                              // Pull Buff Behavior
                                                              new Decorator
                                                              (
                                                                  req => RoutineManager.Current.PullBuffBehavior != null
                                                                         && IsValidEnemy(Core.Player.CurrentTarget)
                                                                         && MudSettings.Instance.PullBuff,
                                                                  RoutineManager.Current.PullBuffBehavior
                                                              ),
                                                              // Pull Behavior
                                                              new Decorator
                                                              (
                                                                  req => IsValidEnemy(Core.Player.CurrentTarget)
                                                                         && MudSettings.Instance.Pull
                                                                         && Core.Player.CurrentTarget.Location
                                                                             .Distance3D(Core.Player.Location)
                                                                         <= RoutineManager.Current.PullRange
                                                                         + Core.Player.CurrentTarget.CombatReach
                                                                         + MudSettings.Instance
                                                                             .TargetRangeMelee,
                                                                  new PrioritySelector(
                                                                      RoutineManager.Current.PullBehavior,
                                                                      RoutineManager.Current.CombatBehavior)
                                                              )
                                                          )
                                                      ),
                                                      // Executed In Combat
                                                      new Decorator
                                                      (
                                                          req => !Core.Player.IsMounted
                                                                 && InCombat,
                                                          new PrioritySelector
                                                          (
                                                              // Combat Buffs
                                                              new Decorator
                                                              (
                                                                  req => RoutineManager.Current.CombatBuffBehavior !=
                                                                         null
                                                                         && MudSettings.Instance.CombatBuff,
                                                                  RoutineManager.Current.CombatBuffBehavior
                                                              ),
                                                              // Combat Routine
                                                              new Decorator
                                                              (
                                                                  req => RoutineManager.Current.CombatBehavior != null
                                                                         && MudSettings.Instance.Combat
                                                                         && IsValidEnemy(Core.Player.CurrentTarget)
                                                                         && Core.Player.CurrentTarget.Location
                                                                             .Distance3D(Core.Player.Location)
                                                                         <= RoutineManager.Current.PullRange
                                                                         + Core.Player.CurrentTarget.CombatReach
                                                                         + MudSettings.Instance
                                                                             .TargetRangeMelee,
                                                                  RoutineManager.Current.CombatBehavior
                                                              )
                                                          )
                                                      ),
                                                      // Auto Commence Duty
                                                      new Decorator
                                                      (
                                                          req => MudSettings.Instance.AutoCommenceDuty,
                                                          new Action(a =>
                                                          {
                                                              if (!ContentsFinderConfirm.IsOpen) return;
                                                              SndPlayer.Play();
                                                              Logging.Write(Colors.Brown, @"Dungeon is ready");
                                                              DutyJoiner.Reset();
                                                              if (MudSettings.Instance.AutoCommenceDuty)
                                                                  DutyJoiner.Commence();
                                                          })
                                                      )
                                                  )
                                              ));

        public override bool WantButton => true;

        public override void Initialize()
        {
            const string version = IsBeta ? @"[MudAssist] Loaded v" + Version + @" " + Beta + @"-" + BetaVer : @"[MudAssist] Loaded v" + Version + @" ";
            Logging.Write(Colors.Brown, version);
            UnregisterAllHotkeys();
        }

        public sealed override void OnButtonPress()
        {
            if (_settings == null || _settings.IsDisposed || _settings.Disposing) _settings = new SettingsForm();
            _settings.Show();
            _settings.Activate();
        }

        public override void Start()
        {
            UpdateNavigationProvider();
            Navigator.PlayerMover = new SlideMover();
            GameSettingsManager.FaceTargetOnAction = MudSettings.Instance.AutoFaceTarget;
            Logging.Write(Colors.Brown, @"[MudAssist] Started");
            ResetHotkeys();
            IsStarted = true;
        }

        public override void Stop()
        {
            _root = null;
            Navigator.PlayerMover = new NullMover();
            if (Navigator.NavigationProvider is ServiceNavigationProvider g)
                g.Dispose();
            Navigator.NavigationProvider = new NullProvider();
            Logging.Write(Colors.Brown, @"[MudAssist] Stopped");
            UnregisterAllHotkeys();
            IsStarted = false;
        }

        #endregion Overrides

        #region Hotkeys

        private static Hotkey _hotkeyPause, _hotkeyTargetMode, _hotkeyToggleMovement, _hotkeyToggleMovementMode;

        public static void ResetHotkeys()
        {
            UnregisterAllHotkeys();

            Keys key;
            var cinfo = Thread.CurrentThread.CurrentCulture;
            var text = cinfo.TextInfo;

            // Hotkey to Pause/Unpause
            if (MudSettings.Instance.EnableHotkeyPause)
            {
                try
                {
                    key = (Keys) new KeysConverter().ConvertFromString(
                        text.ToTitleCase(MudSettings.Instance.HotkeyPause));
                }
                catch (Exception ex)
                {
                    key = Keys.None;
                    Logging.Write(Colors.Red, $@"{ex}");
                }

                if (key != Keys.None)
                    _hotkeyPause = HotkeyManager.Register(
                        "HK_MUD_PAUSE",
                        key,
                        (ModifierKeys) Enum.Parse(typeof(ModifierKeys),
                            ModifierKeyStrings[MudSettings.Instance.HotkeyModifierPause]),
                        hkPause =>
                        {
                            MudSettings.Instance.Paused = !MudSettings.Instance.Paused;
                            if (MudSettings.Instance.Paused)
                            {
                                Logging.Write(Colors.Brown, @"[MudAssist] ==> Paused");
                                if (MudSettings.Instance.EnableOverlay)
                                    Core.OverlayManager.AddToast(() => "Paused", TimeSpan.FromMilliseconds(1000),
                                        Colors.Yellow, Colors.Black, new FontFamily("Lato"));
                            }
                            else
                            {
                                Logging.Write(Colors.Brown, @"[MudAssist] ==> Unpaused");
                                if (MudSettings.Instance.EnableOverlay)
                                    Core.OverlayManager.AddToast(() => "Unpaused", TimeSpan.FromMilliseconds(1000),
                                        Colors.Yellow, Colors.Black, new FontFamily("Lato"));
                            }
                        });
            }

            // Hotkey to Change Targeting Mode
            if (MudSettings.Instance.EnableHotkeyTargetMode)
            {
                try
                {
                    key = (Keys) new KeysConverter().ConvertFromString(
                        text.ToTitleCase(MudSettings.Instance.HotkeyTargetMode));
                }
                catch (Exception ex)
                {
                    key = Keys.None;
                    Logging.Write(Colors.Red, $@"{ex}");
                }

                if (key != Keys.None)
                    _hotkeyTargetMode = HotkeyManager.Register(
                        "HK_MUD_TARGET",
                        key,
                        (ModifierKeys) Enum.Parse(typeof(ModifierKeys),
                            ModifierKeyStrings[MudSettings.Instance.HotkeyModifierTargetMode]),
                        hkTargetMode =>
                        {
                            Logging.Write(Colors.Brown,
                                $@"[MudAssist] ==> Previous Targeting Mode {
                                        TargetingModes[MudSettings.Instance.TargetingMode]
                                    }");
                            if (MudSettings.Instance.TargetingMode + 1 == TargetingModes.Length)
                                MudSettings.Instance.TargetingMode = 0;
                            else MudSettings.Instance.TargetingMode = MudSettings.Instance.TargetingMode + 1;
                            SettingsForm.SelectTargetingMode(MudSettings.Instance.TargetingMode);
                            Logging.Write(Colors.Brown,
                                $@"[MudAssist] ==> Target Mode {TargetingModes[MudSettings.Instance.TargetingMode]}");
                            if (MudSettings.Instance.EnableOverlay)
                                Core.OverlayManager.AddToast(
                                    () => $"Target: {TargetingModes[MudSettings.Instance.TargetingMode]}",
                                    TimeSpan.FromMilliseconds(1000), Colors.Yellow, Colors.Black,
                                    new FontFamily("Lato"));
                        });
            }

            // Hotkey to Toggle Movement
            if (MudSettings.Instance.EnableHotkeyToogleMovement)
            {
                try
                {
                    key = (Keys) new KeysConverter().ConvertFromString(
                        text.ToTitleCase(MudSettings.Instance.HotkeyToogleMovement));
                }
                catch (Exception ex)
                {
                    key = Keys.None;
                    Logging.Write(Colors.Red, $@"{ex}");
                }

                if (key != Keys.None)
                    _hotkeyToggleMovement = HotkeyManager.Register(
                        "HK_MUD_TOGGLE_MOVEMENT",
                        key,
                        (ModifierKeys) Enum.Parse(typeof(ModifierKeys),
                            ModifierKeyStrings[MudSettings.Instance.HotkeyModifierToogleMovement]),
                        hkToggleMovement =>
                        {
                            MudSettings.Instance.AutoMove = !MudSettings.Instance.AutoMove;
                            WaypointManager.StopNavigating();
                            if (MudSettings.Instance.AutoMove)
                            {
                                Logging.Write(Colors.Brown, @"[MudAssist] ==> Movement ON");
                                if (MudSettings.Instance.EnableOverlay)
                                    Core.OverlayManager.AddToast(() => "Movement ON", TimeSpan.FromMilliseconds(1000),
                                        Colors.Yellow, Colors.Black, new FontFamily("Lato"));
                            }
                            else
                            {
                                Logging.Write(Colors.Brown, @"[MudAssist] ==> Movement OFF");
                                if (MudSettings.Instance.EnableOverlay)
                                    Core.OverlayManager.AddToast(() => "Movement OFF", TimeSpan.FromMilliseconds(1000),
                                        Colors.Yellow, Colors.Black, new FontFamily("Lato"));
                            }
                        });
            }

            // Hotkey to Toggle Movement Mode
            if (MudSettings.Instance.EnableHotkeyMovementMode)
            {
                try
                {
                    key = (Keys) new KeysConverter().ConvertFromString(
                        text.ToTitleCase(MudSettings.Instance.HotkeyMovementMode));
                }
                catch (Exception ex)
                {
                    key = Keys.None;
                    Logging.Write(Colors.Red, $@"{ex}");
                }

                if (key != Keys.None)
                    _hotkeyToggleMovementMode = HotkeyManager.Register(
                        "HK_MUD_TOGGLE_MOVEMENT_MODE",
                        key,
                        (ModifierKeys) Enum.Parse(typeof(ModifierKeys),
                            ModifierKeyStrings[MudSettings.Instance.HotkeyModifierMovementMode]),
                        hkToggleMovementMode =>
                        {
                            Logging.Write(Colors.Brown,
                                $@"[MudAssist] ==> Previous Movement Mode {
                                        TargetingModes[MudSettings.Instance.TargetingMode]
                                    }");
                            if (MudSettings.Instance.TargetingMode + 1 == MovementModes.Length)
                                MudSettings.Instance.TargetingMode = 0;
                            else MudSettings.Instance.TargetingMode = MudSettings.Instance.TargetingMode + 1;
                            SettingsForm.SelectMovementMode(MudSettings.Instance.TargetingMode);
                            Logging.Write(Colors.Brown,
                                $@"[MudAssist] ==> Move Mode {MovementModes[MudSettings.Instance.TargetingMode]}");
                            if (MudSettings.Instance.EnableOverlay)
                                Core.OverlayManager.AddToast(
                                    () => $"Move Mode: {MovementModes[MudSettings.Instance.TargetingMode]}",
                                    TimeSpan.FromMilliseconds(1000), Colors.Yellow, Colors.Black,
                                    new FontFamily("Lato"));
                        });
            }
        }

        private static void UnregisterAllHotkeys()
        {
            UnregisterHotkey(_hotkeyPause);
            UnregisterHotkey(_hotkeyTargetMode);
            UnregisterHotkey(_hotkeyToggleMovement);
            UnregisterHotkey(_hotkeyToggleMovementMode);
        }

        private static void UnregisterHotkey(Hotkey hk)
        {
            if (hk != null) HotkeyManager.Unregister(hk);
        }

        #endregion Hotkeys

        #region Helper Methods

        public static bool InCombat => GetVisiblePartyMembers().Where(p => p.IsAlive
                                                                           && p.HasTarget
                                                                           && p.InCombat
                                                                           && p.TargetCharacter != null
                                                                           && p.TargetCharacter.HasTarget
                                                                           && p.TargetCharacter.CurrentHealth <
                                                                           p.TargetCharacter.MaxHealth
                                       ) != null;

        private static void Assist(Character c)
        {
            var target = GameObjectManager.GetObjectByObjectId(c.CurrentTargetId);
            if (target == null || !target.IsTargetable || !target.IsValid || !target.CanAttack) return;
            Logging.Write(Colors.Brown, $@"[MudAssist] ==> Assisting {c.Name}");
            target.Target();
        }

        private static GameObject GetClosestEnemyByName(StringCollection names)
        {
            Logging.Write(Colors.Brown, @"[MudAssist] ==> Finding nearest enemy to attack...");
            return GameObjectManager.GameObjects.Where(u =>
                    IsValidEnemy(u)
                    && (decimal) Core.Player.Location.Distance3D(u.Location) <= MudSettings.Instance.MaxTargetDistance)
                .OrderBy(u => Core.Player.Location.Distance3D(u.Location)).FirstOrDefault();
        }

        private static Character GetPartyTank()
        {
            if (GetVisiblePartyMembers().Count <= 0) return null;
            try
            {
                return GetVisiblePartyMembers().First(JobHelper.IsTank);
            }
            catch (Exception ex)
            {
                Logging.Write(Colors.Red, $@"{ex}");
                return null;
            }
        }

        public static List<Character> GetVisiblePartyMembers()
        {
            var members = new List<Character>();
            if (!PartyManager.IsInParty)
                members.Add(Core.Player);
            else
                members.AddRange(from pm in PartyManager.AllMembers
                    where pm.IsInObjectManager
                    select (Character) GameObjectManager.GetObjectByObjectId(pm.ObjectId));

            return members;
        }

        public static bool IsValidEnemy(GameObject obj)
        {
            if (obj == null || !(obj is Character)) return false;
            var c = (Character) obj;
            return !c.IsMe && !c.IsDead && c.IsValid && c.IsTargetable && c.IsVisible && c.CanAttack;
        }

        #endregion Helper Methods
    }
}