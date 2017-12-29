using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using ff14bot.Helpers;
using Newtonsoft.Json;

namespace Mud.Settings
{
    public class MudSettings : JsonSettings
    {
        private static MudSettings _settings;

        private MudSettings(string filename) : base(Path.Combine(CharacterSettingsDirectory, filename + ".json"))
        {
        }

        public static MudSettings Instance => _settings ?? (_settings = new MudSettings("MudAssist"));

        #region Char Info

        private bool _hideName;

        [JsonProperty("HideName")]
        [DefaultValue(false)]
        public bool HideName
        {
            get => _hideName;
            set
            {
                _hideName = value;
                Save();
            }
        }

        private int _secondsBetweenUpdate;

        [JsonProperty("SecondsBetweenUpdate")]
        [DefaultValue(2)]
        public int SecondsBetweenUpdate
        {
            get => _secondsBetweenUpdate;
            set
            {
                _secondsBetweenUpdate = value;
                Save();
            }
        }

        #endregion Char Info

        #region Questing

        private bool _acceptQuests;

        [JsonProperty("AcceptQuests")]
        [DefaultValue(true)]
        public bool AcceptQuests
        {
            get => _acceptQuests;
            set
            {
                _acceptQuests = value;
                Save();
            }
        }

        private bool _completeQuests;

        [JsonProperty("CompleteQuests")]
        [DefaultValue(true)]
        public bool CompleteQuests
        {
            get => _completeQuests;
            set
            {
                _completeQuests = value;
                Save();
            }
        }

        private bool _skipCutscenes;

        [JsonProperty("SkipCutscenes")]
        [DefaultValue(true)]
        public bool SkipCutscenes
        {
            get => _skipCutscenes;
            set
            {
                _skipCutscenes = value;
                Save();
            }
        }

        private bool _talkToNpc;

        [JsonProperty("TalkToNpc")]
        [DefaultValue(true)]
        public bool TalkToNpc
        {
            get => _talkToNpc;
            set
            {
                _talkToNpc = value;
                Save();
            }
        }

        #endregion Questing

        #region Sprint

        private bool _sprintInCombat;

        [JsonProperty("SprintInCombat")]
        [DefaultValue(false)]
        public bool SprintInCombat
        {
            get => _sprintInCombat;
            set
            {
                _sprintInCombat = value;
                Save();
            }
        }

        private bool _sprintInInstance;

        [JsonProperty("SprintInInstance")]
        [DefaultValue(false)]
        public bool SprintInInstance
        {
            get => _sprintInInstance;
            set
            {
                _sprintInInstance = value;
                Save();
            }
        }

        private bool _sprintOutOfCombat;

        [JsonProperty("SprintOutOfCombat")]
        [DefaultValue(true)]
        public bool SprintOutOfCombat
        {
            get => _sprintOutOfCombat;
            set
            {
                _sprintOutOfCombat = value;
                Save();
            }
        }

        #endregion Sprint

        #region Routine

        private bool _combat;

        [JsonProperty("Combat")]
        [DefaultValue(true)]
        public bool Combat
        {
            get => _combat;
            set
            {
                _combat = value;
                Save();
            }
        }

        private bool _combatBuff;

        [JsonProperty("CombatBuff")]
        [DefaultValue(true)]
        public bool CombatBuff
        {
            get => _combatBuff;
            set
            {
                _combatBuff = value;
                Save();
            }
        }

        private bool _heal;

        [JsonProperty("Heal")]
        [DefaultValue(true)]
        public bool Heal
        {
            get => _heal;
            set
            {
                _heal = value;
                Save();
            }
        }

        private bool _healOutOfCombat;

        [JsonProperty("HealOutOfCombat")]
        [DefaultValue(true)]
        public bool HealOutOfCombat
        {
            get => _healOutOfCombat;
            set
            {
                _healOutOfCombat = value;
                Save();
            }
        }

        private bool _preCombatBuff;

        [JsonProperty("PreCombatBuff")]
        [DefaultValue(true)]
        public bool PreCombatBuff
        {
            get => _preCombatBuff;
            set
            {
                _preCombatBuff = value;
                Save();
            }
        }

        private bool _pull;

        [JsonProperty("Pull")]
        [DefaultValue(true)]
        public bool Pull
        {
            get => _pull;
            set
            {
                _pull = value;
                Save();
            }
        }

        private bool _pullBuff;

        [JsonProperty("PullBuff")]
        [DefaultValue(true)]
        public bool PullBuff
        {
            get => _pullBuff;
            set
            {
                _pullBuff = value;
                Save();
            }
        }

        private bool _rest;

        [JsonProperty("Rest")]
        [DefaultValue(true)]
        public bool Rest
        {
            get => _rest;
            set
            {
                _rest = value;
                Save();
            }
        }

        #endregion Routine

        #region Hotkey

        private bool _enableHotkeyMovementMode;

        [JsonProperty("EnableHotkeyMovementMode")]
        [DefaultValue(false)]
        public bool EnableHotkeyMovementMode
        {
            get => _enableHotkeyMovementMode;
            set
            {
                _enableHotkeyMovementMode = value;
                Save();
            }
        }

        private bool _enableHotkeyPause;

        [JsonProperty("EnableHotkeyPause")]
        [DefaultValue(false)]
        public bool EnableHotkeyPause
        {
            get => _enableHotkeyPause;
            set
            {
                _enableHotkeyPause = value;
                Save();
            }
        }

        private bool _enableHotkeyTargetMode;

        [JsonProperty("EnableHotkeyTargetMode")]
        [DefaultValue(false)]
        public bool EnableHotkeyTargetMode
        {
            get => _enableHotkeyTargetMode;
            set
            {
                _enableHotkeyTargetMode = value;
                Save();
            }
        }

        private bool _enableHotkeyToogleMovement;

        [JsonProperty("EnableHotkeyToogleMovement")]
        [DefaultValue(false)]
        public bool EnableHotkeyToogleMovement
        {
            get => _enableHotkeyToogleMovement;
            set
            {
                _enableHotkeyToogleMovement = value;
                Save();
            }
        }

        private int _hotkeyModifierMovementMode;

        [JsonProperty("HotkeyModifierMovementMode")]
        [DefaultValue(2)]
        public int HotkeyModifierMovementMode
        {
            get => _hotkeyModifierMovementMode;
            set
            {
                _hotkeyModifierMovementMode = value;
                Save();
            }
        }

        private int _hotkeyModifierPause;

        [JsonProperty("HotkeyModifierPause")]
        [DefaultValue(0)]
        public int HotkeyModifierPause
        {
            get => _hotkeyModifierPause;
            set
            {
                _hotkeyModifierPause = value;
                Save();
            }
        }

        private int _hotkeyModifierTargetMode;

        [JsonProperty("HotkeyModifierTargetMode")]
        [DefaultValue(2)]
        public int HotkeyModifierTargetMode
        {
            get => _hotkeyModifierTargetMode;
            set
            {
                _hotkeyModifierTargetMode = value;
                Save();
            }
        }

        private int _hotkeyModifierToogleMovement;

        [JsonProperty("HotkeyModifierToogleMovement")]
        [DefaultValue(2)]
        public int HotkeyModifierToogleMovement
        {
            get => _hotkeyModifierToogleMovement;
            set
            {
                _hotkeyModifierToogleMovement = value;
                Save();
            }
        }

        private string _hotkeyMovementMode;

        [JsonProperty("HotkeyMovementMode")]
        [DefaultValue("F")]
        public string HotkeyMovementMode
        {
            get => _hotkeyMovementMode;
            set
            {
                _hotkeyMovementMode = value;
                Save();
            }
        }

        private string _hotkeyPause;

        [JsonProperty("HotkeyPause")]
        [DefaultValue("Z")]
        public string HotkeyPause
        {
            get => _hotkeyPause;
            set
            {
                _hotkeyPause = value;
                Save();
            }
        }

        private string _hotkeyTargetMode;

        [JsonProperty("HotkeyTargetMode")]
        [DefaultValue("X")]
        public string HotkeyTargetMode
        {
            get => _hotkeyTargetMode;
            set
            {
                _hotkeyTargetMode = value;
                Save();
            }
        }

        private string _hotkeyToogleMovement;

        [JsonProperty("HotkeyToogleMovement")]
        [DefaultValue("C")]
        public string HotkeyToogleMovement
        {
            get => _hotkeyToogleMovement;
            set
            {
                _hotkeyToogleMovement = value;
                Save();
            }
        }

        #endregion Hotkey

        #region Movement

        private bool _autoFaceTarget;

        [JsonProperty("AutoFaceTarget")]
        [DefaultValue(true)]
        public bool AutoFaceTarget
        {
            get => _autoFaceTarget;
            set
            {
                _autoFaceTarget = value;
                Save();
            }
        }

        private bool _autoMove;

        [JsonProperty("AutoMove")]
        [DefaultValue(false)]
        public bool AutoMove
        {
            get => _autoMove;
            set
            {
                _autoMove = value;
                Save();
            }
        }

        private int _followRangeMax;

        [JsonProperty("FollowRangeMax")]
        [DefaultValue(15)]
        public int FollowRangeMax
        {
            get => _followRangeMax;
            set
            {
                _followRangeMax = value;
                Save();
            }
        }

        private int _followRangeMin;

        [JsonProperty("FollowRangeMin")]
        [DefaultValue(8)]
        public int FollowRangeMin
        {
            get => _followRangeMin;
            set
            {
                _followRangeMin = value;
                Save();
            }
        }

        private int _maxTargetDistance;

        [JsonProperty("MaxTargetDistance")]
        [DefaultValue(50)]
        public int MaxTargetDistance
        {
            get => _maxTargetDistance;
            set
            {
                _maxTargetDistance = value;
                Save();
            }
        }

        private StringCollection _mobsToTarget;

        [JsonProperty("MobsToTarget")]
        public StringCollection MobsToTarget
        {
            get => _mobsToTarget;
            set
            {
                _mobsToTarget = value;
                Save();
            }
        }

        private int _movementMode;

        [JsonProperty("MovementMode")]
        [DefaultValue(0)]
        public int MovementMode
        {
            get => _movementMode;
            set
            {
                _movementMode = value;
                Save();
            }
        }

        private int _navigationProvider;

        [JsonProperty("NavigationProvider")]
        [DefaultValue(0)]
        public int NavigationProvider
        {
            get => _navigationProvider;
            set
            {
                _navigationProvider = value;
                Save();
            }
        }

        private int _targetDistance;

        [JsonProperty("TargetDistance")]
        [DefaultValue(15)]
        public int TargetDistance
        {
            get => _targetDistance;
            set
            {
                _targetDistance = value;
                Save();
            }
        }

        private int _targetingMode;

        [JsonProperty("TargetingMode")]
        [DefaultValue(0)]
        public int TargetingMode
        {
            get => _targetingMode;
            set
            {
                _targetingMode = value;
                Save();
            }
        }

        private int _targetRangeMelee;

        [JsonProperty("TargetRangeMelee")]
        [DefaultValue(2)]
        public int TargetRangeMelee
        {
            get => _targetRangeMelee;
            set
            {
                _targetRangeMelee = value;
                Save();
            }
        }

        private int _targetRangeRanged;

        [JsonProperty("TargetRangeRanged")]
        [DefaultValue(20)]
        public int TargetRangeRanged
        {
            get => _targetRangeRanged;
            set
            {
                _targetRangeRanged = value;
                Save();
            }
        }

        #endregion Movement

        #region General

        private bool _alwaysOnTop;

        [JsonProperty("AlwaysOnTop")]
        [DefaultValue(false)]
        public bool AlwaysOnTop
        {
            get => _alwaysOnTop;
            set
            {
                _alwaysOnTop = value;
                Save();
            }
        }

        private bool _executeWhileMoving;

        [JsonProperty("ExecuteWhileMoving")]
        [DefaultValue(true)]
        public bool ExecuteWhileMoving
        {
            get => _executeWhileMoving;
            set
            {
                _executeWhileMoving = value;
                Save();
            }
        }

        private bool _paused;

        [JsonProperty("Paused")]
        [DefaultValue(false)]
        public bool Paused
        {
            get => _paused;
            set
            {
                _paused = value;
                Save();
            }
        }

        #endregion General

        #region Overlay

        private bool _enableOverlay;

        [JsonProperty("EnableOverlay")]
        [DefaultValue(false)]
        public bool EnableOverlay
        {
            get => _enableOverlay;
            set
            {
                _enableOverlay = value;
                Save();
            }
        }

        #endregion Overlay
    }
}