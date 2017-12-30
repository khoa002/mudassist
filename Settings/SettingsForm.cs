using System;
using System.Windows.Forms;
using System.Windows.Media;
using ff14bot;
using ff14bot.Behavior;
using ff14bot.Enums;
using ff14bot.Helpers;
using ff14bot.Managers;
using Mud.Helpers;
using Mud.Properties;
using Color = System.Drawing.Color;

namespace Mud.Settings.Forms
{
    public partial class SettingsForm : Form
    {
        private const int Seconds = 0;
        private static SettingsForm _instance;
        private Timer _t;

        public SettingsForm()
        {
            InitializeComponent();
            ReloadSettings();
            InitializeDataBindings();
            _instance = this;
        }

        private void MudSettingsForm_Load(object sender, EventArgs e)
        {
            _t = new Timer {Interval = 1000};
            _t.Tick += OnTickTimer;
            try
            {
                if (!CommonBehaviors.IsLoading)
                {
                    if (!_t.Enabled) _t.Enabled = true;
                    _t.Start();
                }
            }
            catch (Exception ex)
            {
                Logging.Write(Colors.Brown, $@"{ex}");
            }

            TopMost = MudSettings.Instance.AlwaysOnTop;

            if (MudAssist.IsBeta)
                Text = $@"Mud Assist v{MudAssist.Version} {MudAssist.Beta}-{MudAssist.BetaVer} - Settings";
            Text = $@"Mud Assist v{MudAssist.Version} - Settings";

            if (!CommonBehaviors.IsLoading) LoadCharInfo();
            UpdateCheckBoxes(null);
            UpdateStatus();
        }

        #region Misc Events

        private void OnTickTimer(object sender, EventArgs e)
        {
            if (!MudAssist.IsStarted || CommonBehaviors.IsLoading) return;
            if (Seconds >= 1 && Seconds <= 10)
            {
                _t.Interval = Seconds * 1000;
                LoadCharInfo();
            }

            _t.Interval = 1000;
        }

        #endregion Misc Events

        #region Custom Methods

        public static void SelectMovementMode(int p)
        {
            if (_instance != null) _instance.cmbMovementMode.SelectedIndex = p;
        }

        public static void SelectTargetingMode(int p)
        {
            if (_instance != null) _instance.cmbTargetingMode.SelectedIndex = p;
        }

        private void InitializeDataBindings()
        {
            // Char Info
            cbxCharHideName.DataBindings.Add("Checked", MudSettings.Instance, "HideName",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cmbSecondsBetweenUpdate.DataSource = MudAssist.SecondsBetweenUpdates;
            cmbSecondsBetweenUpdate.DataBindings.Add("SelectedIndex", MudSettings.Instance, "SecondsBetweenUpdate",
                false, DataSourceUpdateMode.OnPropertyChanged);

            // Routine
            cbxOutOfCombatRest.DataBindings.Add("Checked", MudSettings.Instance, "Rest",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cbxOutOfCombatHeal.DataBindings.Add("Checked", MudSettings.Instance, "HealOutOfCombat",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cbxOutOfCombatBuff.DataBindings.Add("Checked", MudSettings.Instance, "PreCombatBuff",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cbxOutOfCombatPullBuff.DataBindings.Add("Checked", MudSettings.Instance, "PullBuff",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cbxCombatActionsPull.DataBindings.Add("Checked", MudSettings.Instance, "Pull",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cbxCombatActionsHeal.DataBindings.Add("Checked", MudSettings.Instance, "Heal",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cbxCombatActionsBuff.DataBindings.Add("Checked", MudSettings.Instance, "CombatBuff",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cbxCombatActionsCombat.DataBindings.Add("Checked", MudSettings.Instance, "Combat",
                false, DataSourceUpdateMode.OnPropertyChanged);

            // Movement
            cmbNavigationProvider.DataSource = MudAssist.SupportedNavigationProviders;
            cmbNavigationProvider.DataBindings.Add("SelectedIndex", MudSettings.Instance, "NavigationProvider",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cbxAutoFace.DataBindings.Add("Checked", MudSettings.Instance, "AutoFaceTarget",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cbxAutoMoveTarget.DataBindings.Add("Checked", MudSettings.Instance, "AutoMove",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cmbTargetingMode.DataSource = MudAssist.TargetingModes;
            cmbTargetingMode.DataBindings.Add("SelectedIndex", MudSettings.Instance, "TargetingMode",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cmbMovementMode.DataSource = MudAssist.MovementModes;
            cmbMovementMode.DataBindings.Add("SelectedIndex", MudSettings.Instance, "MovementMode",
                false, DataSourceUpdateMode.OnPropertyChanged);

            // Hotkey
            cbxEnableHotkeyUnPause.DataBindings.Add("Checked", MudSettings.Instance, "EnableHotkeyPause",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cbxEnableHotkeyTargetMode.DataBindings.Add("Checked", MudSettings.Instance, "EnableHotkeyTargetMode",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cbxEnableHotkeyToogleMovement.DataBindings.Add("Checked", MudSettings.Instance,
                "EnableHotkeyToogleMovement",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cbxEnableHotkeyMovementMode.DataBindings.Add("Checked", MudSettings.Instance, "EnableHotkeyMovementMode",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cmbHotkeyModifierPause.Items.Clear();
            cmbHotkeyModifierPause.Items.AddRange(MudAssist.ModifierKeyStrings);
            cmbHotkeyModifierPause.DataBindings.Add("SelectedIndex", MudSettings.Instance, "HotkeyModifierPause",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cmbHotkeyModifierTargetMode.Items.Clear();
            cmbHotkeyModifierTargetMode.Items.AddRange(MudAssist.ModifierKeyStrings);
            cmbHotkeyModifierTargetMode.DataBindings.Add("SelectedIndex", MudSettings.Instance,
                "HotkeyModifierTargetMode",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cmbHotkeyModifierToogleMovement.Items.Clear();
            cmbHotkeyModifierToogleMovement.Items.AddRange(MudAssist.ModifierKeyStrings);
            cmbHotkeyModifierToogleMovement.DataBindings.Add("SelectedIndex", MudSettings.Instance,
                "HotkeyModifierToogleMovement",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cmbHotkeyModifierMovementMode.Items.Clear();
            cmbHotkeyModifierMovementMode.Items.AddRange(MudAssist.ModifierKeyStrings);
            cmbHotkeyModifierMovementMode.DataBindings.Add("SelectedIndex", MudSettings.Instance,
                "HotkeyModifierMovementMode",
                false, DataSourceUpdateMode.OnPropertyChanged);
            tbxHotkeyPause.DataBindings.Add("Text", MudSettings.Instance, "HotkeyPause",
                false, DataSourceUpdateMode.OnPropertyChanged);
            tbxHotkeyTargetMode.DataBindings.Add("Text", MudSettings.Instance, "HotkeyTargetMode",
                false, DataSourceUpdateMode.OnPropertyChanged);
            tbxHotkeyMovementMode.DataBindings.Add("Text", MudSettings.Instance, "HotkeyMovementMode",
                false, DataSourceUpdateMode.OnPropertyChanged);
            tbxHotkeyToogleMovement.DataBindings.Add("Text", MudSettings.Instance, "HotkeyToogleMovement",
                false, DataSourceUpdateMode.OnPropertyChanged);

            // Misc
            numMinMoveDistanceTank.DataBindings.Add("Value", MudSettings.Instance, "FollowRangeMin",
                false, DataSourceUpdateMode.OnPropertyChanged);
            numMaxMoveDistanceTank.DataBindings.Add("Value", MudSettings.Instance, "FollowRangeMax",
                false, DataSourceUpdateMode.OnPropertyChanged);
            numTargetingDistance.DataBindings.Add("Value", MudSettings.Instance, "MaxTargetDistance",
                false, DataSourceUpdateMode.OnPropertyChanged);

            cbxPaused.DataBindings.Add("Checked", MudSettings.Instance, "Paused",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cbxExecuteWhileMoving.DataBindings.Add("Checked", MudSettings.Instance, "ExecuteWhileMoving",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cbxAlwaysOnTop.DataBindings.Add("Checked", MudSettings.Instance, "AlwaysOnTop",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cbxEnableOverlay.DataBindings.Add("Checked", MudSettings.Instance, "EnableOverlay",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cbxSprintOutOfCombat.DataBindings.Add("Checked", MudSettings.Instance, "SprintOutOfCombat",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cbxSprintInCombat.DataBindings.Add("Checked", MudSettings.Instance, "SprintInCombat",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cbxSprintInInstance.DataBindings.Add("Checked", MudSettings.Instance, "SprintInInstance",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cbxAutoTalkToNPCs.DataBindings.Add("Checked", MudSettings.Instance, "TalkToNpc",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cbxAutoAcceptQuests.DataBindings.Add("Checked", MudSettings.Instance, "AcceptQuests",
                false, DataSourceUpdateMode.OnPropertyChanged);
            cbxAutoSkipCutscenes.DataBindings.Add("Checked", MudSettings.Instance, "SkipCutscenes",
                false, DataSourceUpdateMode.OnPropertyChanged);
        }

        public static void UpdateStatus()
        {
            if (_instance != null)
            {
                if (MudSettings.Instance.Paused)
                {
                    _instance.tspPauseStatus.Text = @"STOPPED";
                    _instance.tspPauseStatus.ForeColor = Color.Red;
                }
                else
                {
                    _instance.tspPauseStatus.Text = @"RUNNING";
                    _instance.tspPauseStatus.ForeColor = Color.Green;
                }

                if (MudSettings.Instance.AutoMove)
                {
                    _instance.tspMovementStatus.Text = @"+AMOVE";
                    _instance.tspMovementStatus.ForeColor = Color.Cyan;
                }
                else
                {
                    _instance.tspMovementStatus.Text = @"-AMOVE";
                    _instance.tspMovementStatus.ForeColor = Color.RoyalBlue;
                }

                _instance.tspFollowModeStatus.Text =
                    @"M: " + MudAssist.MovementModes[MudSettings.Instance.TargetingMode].ToUpper();
                _instance.tspTargetModeStatus.Text =
                    @"T: " + MudAssist.TargetingModes[MudSettings.Instance.TargetingMode].ToUpper();
            }
        }

        private void LoadCharInfo()
        {
            #region General Stats

            tbxCharName.Text = $@"Name : {JobHelper.Name}";
            tbxCharJobNameLevel.Text = $@"Job : {JobHelper.Job} / Level : {JobHelper.Level}";

            tbxCharHP.Text = $@"{JobHelper.Curhp}/{JobHelper.Maxhp}";
            tbxCharTP.Text = $@"{JobHelper.Curtp}/{JobHelper.Maxtp}";

            tbxCharHPPerc.Text = $@"{JobHelper.Curhpperc}/100 %";
            tbxCharTPPerc.Text = $@"{JobHelper.Curtpperc}/100 %";

            tbxCharStrength.Text = $@"STR : {JobHelper.Str}";
            tbxCharDexterity.Text = $@"DEX : {JobHelper.Dex}";
            tbxCharVitality.Text = $@"VIT : {JobHelper.Vit}";
            tbxCharIntelligence.Text = $@"INT : {JobHelper.Int}";
            tbxCharMind.Text = $@"MND : {JobHelper.Mnd}";

            tbxCharFireResistance.Text = $@"{JobHelper.Fire}";
            tbxCharIceResistance.Text = $@"{JobHelper.Ice}";
            tbxCharWindResistance.Text = $@"{JobHelper.Wind}";
            tbxCharEarthResistance.Text = $@"{JobHelper.Earth}";
            tbxCharLightningResistance.Text = $@"{JobHelper.Lightining}";
            tbxCharWaterResistance.Text = $@"{JobHelper.Water}";

            tbxCharCriticalHit.Text = $@"CRIT : {JobHelper.Crit}";
            tbxCharDirectHit.Text = $@"DHIT : {JobHelper.Dhit}";
            tbxCharDefense.Text = $@"DEF : {JobHelper.Def}";
            tbxCharMagicDefense.Text = $@"MDEF : {JobHelper.Mdef}";

            tbxCharAttackPower.Text = $@"ATK : {JobHelper.Atk}";
            tbxCharSkillSpeed.Text = $@"SPD : {JobHelper.Pspd}";

            #endregion General Stats

            #region Job Icons & Check Stats

            switch (Core.Player.CurrentJob)
            {
                case ClassJobType.Adventurer:
                    ptbCharJobIcon.Image = Resources.ERROR;
                    break;

                case ClassJobType.Alchemist:
                    ptbCharJobIcon.Image = Resources.ALC;
                    break;

                case ClassJobType.Armorer:
                    ptbCharJobIcon.Image = Resources.ARM;
                    break;

                case ClassJobType.Blacksmith:
                    ptbCharJobIcon.Image = Resources.BSM;
                    break;

                case ClassJobType.Carpenter:
                    ptbCharJobIcon.Image = Resources.CRP;
                    break;

                case ClassJobType.Culinarian:
                    ptbCharJobIcon.Image = Resources.CUL;
                    break;

                case ClassJobType.Goldsmith:
                    ptbCharJobIcon.Image = Resources.GSM;
                    break;

                case ClassJobType.Leatherworker:
                    ptbCharJobIcon.Image = Resources.LTW;
                    break;

                case ClassJobType.Weaver:
                    ptbCharJobIcon.Image = Resources.WVR;
                    break;

                case ClassJobType.Botanist:
                    ptbCharJobIcon.Image = Resources.BTN;
                    break;

                case ClassJobType.Fisher:
                    ptbCharJobIcon.Image = Resources.FSH;
                    break;

                case ClassJobType.Miner:
                    ptbCharJobIcon.Image = Resources.MIN;
                    break;

                case ClassJobType.Arcanist:
                    ptbCharJobIcon.Image = Resources.ACN;
                    break;

                case ClassJobType.Archer:
                    ptbCharJobIcon.Image = Resources.ARC;
                    break;

                case ClassJobType.Astrologian:
                    ptbCharJobIcon.Image = Resources.AST;
                    break;

                case ClassJobType.Bard:
                    ptbCharJobIcon.Image = Resources.BRD;
                    break;

                case ClassJobType.BlackMage:
                    ptbCharJobIcon.Image = Resources.BLM;
                    break;

                case ClassJobType.Conjurer:
                    ptbCharJobIcon.Image = Resources.CNJ;
                    break;

                case ClassJobType.DarkKnight:
                    ptbCharJobIcon.Image = Resources.DRK;
                    break;

                case ClassJobType.Dragoon:
                    ptbCharJobIcon.Image = Resources.DRG;
                    break;

                case ClassJobType.Gladiator:
                    ptbCharJobIcon.Image = Resources.GLA;
                    break;

                case ClassJobType.Lancer:
                    ptbCharJobIcon.Image = Resources.LNC;
                    break;

                case ClassJobType.Machinist:
                    ptbCharJobIcon.Image = Resources.MCH;
                    break;

                case ClassJobType.Marauder:
                    ptbCharJobIcon.Image = Resources.MRD;
                    break;

                case ClassJobType.Monk:
                    ptbCharJobIcon.Image = Resources.MNK;
                    break;

                case ClassJobType.Ninja:
                    ptbCharJobIcon.Image = Resources.NIN;
                    break;

                case ClassJobType.Paladin:
                    ptbCharJobIcon.Image = Resources.PLD;
                    break;

                case ClassJobType.Pugilist:
                    ptbCharJobIcon.Image = Resources.PGL;
                    break;

                case ClassJobType.RedMage:
                    ptbCharJobIcon.Image = Resources.RDM;
                    break;

                case ClassJobType.Rogue:
                    ptbCharJobIcon.Image = Resources.ROG;
                    break;

                case ClassJobType.Samurai:
                    ptbCharJobIcon.Image = Resources.SAM;
                    break;

                case ClassJobType.Scholar:
                    ptbCharJobIcon.Image = Resources.SCH;
                    break;

                case ClassJobType.Summoner:
                    ptbCharJobIcon.Image = Resources.SMN;
                    break;

                case ClassJobType.Thaumaturge:
                    ptbCharJobIcon.Image = Resources.THM;
                    break;

                case ClassJobType.Warrior:
                    ptbCharJobIcon.Image = Resources.WAR;
                    break;

                case ClassJobType.WhiteMage:
                    ptbCharJobIcon.Image = Resources.WHM;
                    break;

                default:
                    ptbCharJobIcon.Image = Resources.ERROR;
                    break;
            }

            if (JobHelper.IsDoH(Core.Player))
            {
                lblCharMP_CP_GP.Text = @"CP";
                tbxCharMP_CP_GP.Text = $@"{JobHelper.Curcp}/{JobHelper.Maxcp}";
                tbxCharMP_CP_GPPerc.Text = $@"{JobHelper.Curcpperc}/100 %";
                gbxCharExtra.Text = @"Craft";
                tbxCharAttackMagicPotency.Text = $@"CSM : {JobHelper.Csm}";
                tbxCharHealingMagicPotency.Text = $@"CTL : {JobHelper.Ctl}";
                gbxCharRole.Visible = false;
                tbxCharSpellSpeed.Visible = false;
                gbxCharExtra.Visible = false;
            }
            else if (JobHelper.IsDoL(Core.Player))
            {
                lblCharMP_CP_GP.Text = @"GP";
                tbxCharMP_CP_GP.Text = $@"{JobHelper.Curgp}/{JobHelper.Maxgp}";
                tbxCharMP_CP_GPPerc.Text = $@"{JobHelper.Curgpperc}/100 %";
                gbxCharExtra.Text = @"Gather";
                tbxCharAttackMagicPotency.Text = $@"GTH : {JobHelper.Gth}";
                tbxCharHealingMagicPotency.Text = $@"PRT : {JobHelper.Prt}";
                gbxCharRole.Visible = false;
                tbxCharSpellSpeed.Visible = false;
                gbxCharExtra.Visible = false;
            }
            else
            {
                lblCharMP_CP_GP.Text = @"MP";
                tbxCharMP_CP_GP.Text = $@"{JobHelper.Curmp}/{JobHelper.Maxmp}";
                tbxCharMP_CP_GPPerc.Text = $@"{JobHelper.Curmpperc}/100 %";
                gbxCharExtra.Visible = true;
                gbxCharExtra.Text = @"Mental";
                tbxCharSpellSpeed.Visible = true;
                tbxCharAttackMagicPotency.Text = $@"AMP : {JobHelper.Amp}";
                tbxCharHealingMagicPotency.Text = $@"HMP : {JobHelper.Hmp}";
                gbxCharRole.Visible = true;
                tbxCharSpellSpeed.Text = $@"SPD : {JobHelper.Mspd}";
                tbxCharTenacity.Text = $@"TNC : {JobHelper.Tnc}";
                tbxCharPiety.Text = $@"PTY : {JobHelper.Pty}";
            }

            switch (Core.Player.GrandCompany)
            {
                case GrandCompany.Twin_Adder:
                    ptbCharGrandCompany.Image = Resources.order_of_the_twin_adder;
                    tbxCharGrandCompany.Text = @"Order Of The Twin Adder";
                    break;

                case GrandCompany.Immortal_Flames:
                    ptbCharGrandCompany.Image = Resources.immortal_flames;
                    tbxCharGrandCompany.Text = @"Immortal Flames";
                    break;

                case GrandCompany.Maelstrom:
                    ptbCharGrandCompany.Image = Resources.maelstrom;
                    tbxCharGrandCompany.Text = @"Maelstrom";
                    break;

                default:
                    tbxCharGrandCompany.Text = Core.Player.GrandCompany.ToString();
                    ptbCharGrandCompany.Image = Resources.ERROR;
                    break;
            }

            #endregion Job Icons & Check Stats
        }

        private void ReloadSettings()
        {
            cmbCombatRoutines.Items.Clear();
            RoutineManager.Routines.ForEach(r => cmbCombatRoutines.Items.Add(r.Name));
            cmbCombatRoutines.SelectedIndex = cmbCombatRoutines.Items.IndexOf(RoutineManager.Current.Name);
        }

        private void UpdateCheckBoxes(object sender)
        {
            if (sender == cbxEnableHotkeyUnPause)
            {
                cmbHotkeyModifierPause.Enabled = cbxEnableHotkeyUnPause.Checked;
                tbxHotkeyPause.Enabled = cbxEnableHotkeyUnPause.Checked;
            }
            else if (sender == cbxEnableHotkeyTargetMode)
            {
                cmbHotkeyModifierTargetMode.Enabled = cbxEnableHotkeyTargetMode.Checked;
                tbxHotkeyTargetMode.Enabled = cbxEnableHotkeyTargetMode.Checked;
            }
            else if (sender == cbxEnableHotkeyToogleMovement)
            {
                cmbHotkeyModifierToogleMovement.Enabled = cbxEnableHotkeyToogleMovement.Checked;
                tbxHotkeyToogleMovement.Enabled = cbxEnableHotkeyToogleMovement.Checked;
            }
            else if (sender == cbxEnableHotkeyMovementMode)
            {
                cmbHotkeyModifierMovementMode.Enabled = cbxEnableHotkeyMovementMode.Checked;
                tbxHotkeyMovementMode.Enabled = cbxEnableHotkeyMovementMode.Checked;
            }
            else
            {
                UpdateCheckBoxes(cbxEnableHotkeyUnPause);
                UpdateCheckBoxes(cbxEnableHotkeyTargetMode);
                UpdateCheckBoxes(cbxEnableHotkeyToogleMovement);
                UpdateCheckBoxes(cbxEnableHotkeyMovementMode);
            }

            MudAssist.ResetHotkeys();
        }

        #endregion Custom Methods

        #region CheckBox Events

        private void OnCheckedEnableHotkeyMovementMode(object sender, EventArgs e)
        {
            UpdateCheckBoxes(sender);
        }

        private void OnCheckedEnableHotkeyTargetMode(object sender, EventArgs e)
        {
            UpdateCheckBoxes(sender);
        }

        private void OnCheckedEnableHotkeyUnPause(object sender, EventArgs e)
        {
            UpdateCheckBoxes(sender);
        }

        private void OnCheckedEnableToogleMovement(object sender, EventArgs e)
        {
            UpdateCheckBoxes(sender);
        }

        private void OnCheckedAutoFace(object sender, EventArgs e)
        {
            GameSettingsManager.FaceTargetOnAction = cbxAutoFace.Checked;
        }

        private void OnCheckedHideCharName(object sender, EventArgs e)
        {
            tbxCharName.UseSystemPasswordChar = cbxCharHideName.Checked;
        }

        #endregion CheckBox Events

        #region ComboBox Events

        private void OnSelectedCombatRoutine(object sender, EventArgs e)
        {
            var selected = (sender as ComboBox)?.Items[cmbCombatRoutines.SelectedIndex].ToString();
            if (selected != null && selected.Equals(RoutineManager.Current.Name)) return;
            RoutineManager.Current.ShutDown();
            RoutineManager.PreferedRoutine = (sender as ComboBox)?.Items[cmbCombatRoutines.SelectedIndex].ToString();
            RoutineManager.PickRoutine();
        }

        private void OnSelectedNavigationProvider(object sender, EventArgs e)
        {
            MudAssist.UpdateNavigationProvider();
        }

        #endregion ComboBox Events
    }
}