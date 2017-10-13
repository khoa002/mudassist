using ff14bot.Helpers;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Configuration;
using System.IO;

namespace Mud.Settings
{
    public class MudSettings : JsonSettings
    {
        private MudSettings(string filename) : base(Path.Combine(CharacterSettingsDirectory, filename + ".json"))
        {
        }

        [JsonIgnore]
        public static MudSettings Instance { get; } = new MudSettings("MudSettings");

        #region Char Info

        [Setting, DefaultValue(false)]
        public bool HideName { get; set; }

        [Setting, DefaultValue(2)]
        public int SecondsBetweenUpdate { get; set; }

        #endregion Char Info

        #region Questing

        [Setting, DefaultValue(true)]
        public bool AcceptQuests { get; set; }

        [Setting, DefaultValue(true)]
        public bool CompleteQuests { get; set; }

        [Setting, DefaultValue(true)]
        public bool SkipCustscenes { get; set; }

        [Setting, DefaultValue(true)]
        public bool TalkToNPC { get; set; }

        #endregion Questing

        #region Sprint

        [Setting, DefaultValue(false)]
        public bool SprintInCombat { get; set; }

        [Setting, DefaultValue(false)]
        public bool SprintInInstance { get; set; }

        [Setting, DefaultValue(true)]
        public bool SprintOutOfCombat { get; set; }

        #endregion Sprint

        #region Routine

        [Setting, DefaultValue(true)]
        public bool Combat { get; set; }

        [Setting, DefaultValue(true)]
        public bool CombatBuff { get; set; }

        [Setting, DefaultValue(true)]
        public bool Heal { get; set; }

        [Setting, DefaultValue(true)]
        public bool HealOutOfCombat { get; set; }

        [Setting, DefaultValue(true)]
        public bool PreCombatBuff { get; set; }

        [Setting, DefaultValue(true)]
        public bool Pull { get; set; }

        [Setting, DefaultValue(true)]
        public bool PullBuff { get; set; }

        [Setting, DefaultValue(true)]
        public bool Rest { get; set; }

        #endregion Routine

        #region Hotkey

        [Setting, DefaultValue(false)]
        public bool EnableHotkeyMovementMode { get; set; }

        [Setting, DefaultValue(false)]
        public bool EnableHotkeyPause { get; set; }

        [Setting, DefaultValue(false)]
        public bool EnableHotkeyTargetMode { get; set; }

        [Setting, DefaultValue(false)]
        public bool EnableHotkeyToogleMovement { get; set; }

        [Setting, DefaultValue(2)]
        public int HotkeyModifierMovementMode { get; set; }

        [Setting, DefaultValue(0)]
        public int HotkeyModifierPause { get; set; }

        [Setting, DefaultValue(2)]
        public int HotkeyModifierTargetMode { get; set; }

        [Setting, DefaultValue(2)]
        public int HotkeyModifierToogleMovement { get; set; }

        [Setting, DefaultValue("F")]
        public string HotkeyMovementMode { get; set; }

        [Setting, DefaultValue("Z")]
        public string HotkeyPause { get; set; }

        [Setting, DefaultValue("X")]
        public string HotkeyTargetMode { get; set; }

        [Setting, DefaultValue("C")]
        public string HotkeyToogleMovement { get; set; }

        #endregion Hotkey

        #region Movement

        [Setting, DefaultValue(true)]
        public bool AutoFaceTarget { get; set; }

        [Setting, DefaultValue(false)]
        public bool AutoMove { get; set; }

        [Setting, DefaultValue(15)]
        public int FollowRangeMax { get; set; }

        [Setting, DefaultValue(8)]
        public int FollowRangeMin { get; set; }

        [Setting, DefaultValue(50)]
        public int MaxTargetDistance { get; set; }

        [Setting]
        public System.Collections.Specialized.StringCollection MobsToTarget { get; set; }

        [Setting, DefaultValue(0)]
        public int MovementMode { get; set; }

        [Setting, DefaultValue(0)]
        public int NavigationProvider { get; set; }

        [Setting, DefaultValue(15)]
        public int TargetDistance { get; set; }

        [Setting, DefaultValue(0)]
        public int TargetingMode { get; set; }

        [Setting, DefaultValue(2)]
        public int TargetRangeMelee { get; set; }

        [Setting, DefaultValue(20)]
        public int TargetRangeRanged { get; set; }

        #endregion Movement

        #region General

        [Setting, DefaultValue(false)]
        public bool AlwaysOnTop { get; set; }

        [Setting, DefaultValue(true)]
        public bool ExecuteWhileMoving { get; set; }

        [Setting, DefaultValue(false)]
        public bool Paused { get; set; }

        #endregion General

        #region Overlay

        [Setting, DefaultValue(false)]
        public bool EnableOverlay { get; set; }

        #endregion Overlay
    }
}