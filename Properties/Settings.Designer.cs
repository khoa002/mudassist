﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MudBase.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IS_PAUSED {
            get {
                return ((bool)(this["IS_PAUSED"]));
            }
            set {
                this["IS_PAUSED"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ATTACK_OUT_OF_COMBAT {
            get {
                return ((bool)(this["ATTACK_OUT_OF_COMBAT"]));
            }
            set {
                this["ATTACK_OUT_OF_COMBAT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool HEAL_OUT_OF_COMBAT {
            get {
                return ((bool)(this["HEAL_OUT_OF_COMBAT"]));
            }
            set {
                this["HEAL_OUT_OF_COMBAT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool COMBAT_ROUTINE_PRECOMBATBUFF {
            get {
                return ((bool)(this["COMBAT_ROUTINE_PRECOMBATBUFF"]));
            }
            set {
                this["COMBAT_ROUTINE_PRECOMBATBUFF"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool COMBAT_ROUTINE_HEAL {
            get {
                return ((bool)(this["COMBAT_ROUTINE_HEAL"]));
            }
            set {
                this["COMBAT_ROUTINE_HEAL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool COMBAT_ROUTINE_COMBATBUFF {
            get {
                return ((bool)(this["COMBAT_ROUTINE_COMBATBUFF"]));
            }
            set {
                this["COMBAT_ROUTINE_COMBATBUFF"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool COMBAT_ROUTINE_COMBAT {
            get {
                return ((bool)(this["COMBAT_ROUTINE_COMBAT"]));
            }
            set {
                this["COMBAT_ROUTINE_COMBAT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TARGET_MOB_LIST {
            get {
                return ((string)(this["TARGET_MOB_LIST"]));
            }
            set {
                this["TARGET_MOB_LIST"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int TARGETING_MODE {
            get {
                return ((int)(this["TARGETING_MODE"]));
            }
            set {
                this["TARGETING_MODE"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int HOTKEY_PAUSE_MODIFIER {
            get {
                return ((int)(this["HOTKEY_PAUSE_MODIFIER"]));
            }
            set {
                this["HOTKEY_PAUSE_MODIFIER"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string HOTKEY_PAUSE {
            get {
                return ((string)(this["HOTKEY_PAUSE"]));
            }
            set {
                this["HOTKEY_PAUSE"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string HOTKEY_TARGET_MODE {
            get {
                return ((string)(this["HOTKEY_TARGET_MODE"]));
            }
            set {
                this["HOTKEY_TARGET_MODE"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int HOTKEY_TARGET_MODE_MODIFIER {
            get {
                return ((int)(this["HOTKEY_TARGET_MODE_MODIFIER"]));
            }
            set {
                this["HOTKEY_TARGET_MODE_MODIFIER"] = value;
            }
        }
    }
}