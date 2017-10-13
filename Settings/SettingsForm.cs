using ff14bot;
using ff14bot.Behavior;
using ff14bot.Enums;
using ff14bot.Helpers;
using ff14bot.Managers;
using Mud.Helpers;
using Mud.Properties;
using System;
using System.Windows.Forms;
using System.Windows.Media;

namespace Mud.Settings.Forms
{
    public partial class SettingsForm : Form
    {
        private static SettingsForm _instance;

        private int seconds;
        private Timer t;

        public SettingsForm()
        {
            InitializeComponent();
            _instance = this;
        }

        private void MudSettingsForm_Load(object sender, EventArgs e)
        {
            t = new Timer { Interval = 1000 };
            t.Tick += new EventHandler(OnTickTimer);
            try
            {
                if (!CommonBehaviors.IsLoading)
                {
                    if (!t.Enabled) t.Enabled = true;
                    t.Start();
                }
                //else
                //{
                //    if (t.Enabled) t.Enabled = false;
                //    t.Stop();
                //}
            }
            catch (Exception ex) { Logging.Write(Colors.Brown, $"{ex}"); }

            TopMost = MudAssist.Settings.AlwaysOnTop;
            if (MudAssist.IsBeta) Text = $"Mud Assist v{MudAssist.Version} {MudAssist.Beta}-{MudAssist.BetaVer} - Settings";
            else Text = $"Mud Assist v{MudAssist.Version} - Settings";
            if (!CommonBehaviors.IsLoading) LoadCharInfo();
            ReloadSettings();
            UpdateCheckBoxes(null, false);
            UpdateStatus();
        }

        #region Custom Methods

        public static void SelectMovementMode(int p)
        {
            if (_instance != null) _instance.cmbMovementMode.SelectedIndex = p;
        }

        public static void SelectTargetingMode(int p)
        {
            if (_instance != null) _instance.cmbTargetingMode.SelectedIndex = p;
        }

        public static void UpdateStatus()
        {
            if (_instance != null)
            {
                if (MudAssist.Settings.Paused)
                {
                    _instance.tspPauseStatus.Text = "STOPPED";
                    _instance.tspPauseStatus.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    _instance.tspPauseStatus.Text = "RUNNING";
                    _instance.tspPauseStatus.ForeColor = System.Drawing.Color.Green;
                }

                if (MudAssist.Settings.AutoMove)
                {
                    _instance.tspMovementStatus.Text = "+AMOVE";
                    _instance.tspMovementStatus.ForeColor = System.Drawing.Color.Cyan;
                }
                else
                {
                    _instance.tspMovementStatus.Text = "-AMOVE";
                    _instance.tspMovementStatus.ForeColor = System.Drawing.Color.RoyalBlue;
                }

                _instance.tspFollowModeStatus.Text = "M: " + MudAssist.MovementModes[MudAssist.Settings.TargetingMode].ToUpper();
                _instance.tspTargetModeStatus.Text = "T: " + MudAssist.TargetingModes[MudAssist.Settings.TargetingMode].ToUpper();
            }
        }

        private void LoadCharInfo()
        {
            #region General Stats

            tbxCharName.Text = $"Name : {JobHelper.NAME}";
            tbxCharJobNameLevel.Text = $"Job : {JobHelper.JOB} / Level : {JobHelper.LEVEL}";

            tbxCharHP.Text = $"{JobHelper.CURHP}/{JobHelper.MAXHP}";
            tbxCharTP.Text = $"{JobHelper.CURTP}/{JobHelper.MAXTP}";

            tbxCharHPPerc.Text = $"{JobHelper.CURHPPERC}/100 %";
            tbxCharTPPerc.Text = $"{JobHelper.CURTPPERC}/100 %";

            tbxCharStrength.Text = $"STR : {JobHelper.STR}";
            tbxCharDexterity.Text = $"DEX : {JobHelper.DEX}";
            tbxCharVitality.Text = $"VIT : {JobHelper.VIT}";
            tbxCharIntelligence.Text = $"INT : {JobHelper.INT}";
            tbxCharMind.Text = $"MND : {JobHelper.MND}";

            tbxCharFireResistance.Text = $"{JobHelper.FIRE}";
            tbxCharIceResistance.Text = $"{JobHelper.ICE}";
            tbxCharWindResistance.Text = $"{JobHelper.WIND}";
            tbxCharEarthResistance.Text = $"{JobHelper.EARTH}";
            tbxCharLightningResistance.Text = $"{JobHelper.LIGHTINING}";
            tbxCharWaterResistance.Text = $"{JobHelper.WATER}";

            tbxCharCriticalHit.Text = $"CRIT : {JobHelper.CRIT}";
            tbxCharDirectHit.Text = $"DHIT : {JobHelper.DHIT}";
            tbxCharDefense.Text = $"DEF : {JobHelper.DEF}";
            tbxCharMagicDefense.Text = $"MDEF : {JobHelper.MDEF}";

            tbxCharAttackPower.Text = $"ATK : {JobHelper.ATK}";
            tbxCharSkillSpeed.Text = $"SPD : {JobHelper.PSPD}";

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
                lblCharMP_CP_GP.Text = "CP";
                tbxCharMP_CP_GP.Text = $"{JobHelper.CURCP}/{JobHelper.MAXCP}";
                tbxCharMP_CP_GPPerc.Text = $"{JobHelper.CURCPPERC}/100 %";
                gbxCharExtra.Text = "Craft";
                tbxCharAttackMagicPotency.Text = $"CSM : {JobHelper.CSM}";
                tbxCharHealingMagicPotency.Text = $"CTL : {JobHelper.CTL}";
                gbxCharRole.Visible = false;
                tbxCharSpellSpeed.Visible = false;
                gbxCharExtra.Visible = false;
            }
            else if (JobHelper.IsDoL(Core.Player))
            {
                lblCharMP_CP_GP.Text = "GP";
                tbxCharMP_CP_GP.Text = $"{JobHelper.CURGP}/{JobHelper.MAXGP}";
                tbxCharMP_CP_GPPerc.Text = $"{JobHelper.CURGPPERC}/100 %";
                gbxCharExtra.Text = "Gather";
                tbxCharAttackMagicPotency.Text = $"GTH : {JobHelper.GTH}";
                tbxCharHealingMagicPotency.Text = $"PRT : {JobHelper.PRT}";
                gbxCharRole.Visible = false;
                tbxCharSpellSpeed.Visible = false;
                gbxCharExtra.Visible = false;
            }
            else
            {
                lblCharMP_CP_GP.Text = "MP";
                tbxCharMP_CP_GP.Text = $"{JobHelper.CURMP}/{JobHelper.MAXMP}";
                tbxCharMP_CP_GPPerc.Text = $"{JobHelper.CURMPPERC}/100 %";
                gbxCharExtra.Visible = true;
                gbxCharExtra.Text = "Mental";
                tbxCharSpellSpeed.Visible = true;
                tbxCharAttackMagicPotency.Text = $"AMP : {JobHelper.AMP}";
                tbxCharHealingMagicPotency.Text = $"HMP : {JobHelper.HMP}";
                gbxCharRole.Visible = true;
                tbxCharSpellSpeed.Text = $"SPD : {JobHelper.MSPD}";
                tbxCharTenacity.Text = $"TNC : {JobHelper.TNC}";
                tbxCharPiety.Text = $"PTY : {JobHelper.PTY}";
            }

            switch (Core.Player.GrandCompany.ToString())
            {
                case "Order_Of_The_Twin_Adder":
                    ptbCharGrandCompany.Image = Resources.order_of_the_twin_adder;
                    tbxCharGrandCompany.Text = "Order Of The Twin Adder";
                    break;

                case "Immortal_Flames":
                    ptbCharGrandCompany.Image = Resources.immortal_flames;
                    tbxCharGrandCompany.Text = "Immortal Flames";
                    break;

                case "Maelstrom":
                    ptbCharGrandCompany.Image = Resources.maelstrom;
                    tbxCharGrandCompany.Text = "Maelstrom";
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
            cbxCharHideName.Checked = MudAssist.Settings.HideName;
            cmbSecondsBetweenUpdate.Items.Clear();
            cmbSecondsBetweenUpdate.Items.AddRange(MudAssist.SecondsBetweenUpdates);
            cmbSecondsBetweenUpdate.SelectedIndex = MudAssist.Settings.SecondsBetweenUpdate;

            cmbCombatRoutines.Items.Clear();
            RoutineManager.Routines.ForEach(r => cmbCombatRoutines.Items.Add(r.Name));
            cmbCombatRoutines.SelectedIndex = cmbCombatRoutines.Items.IndexOf(RoutineManager.Current.Name);
            cbxOutOfCombatRest.Checked = MudAssist.Settings.Rest;
            cbxOutOfCombatHeal.Checked = MudAssist.Settings.HealOutOfCombat;
            cbxOutOfCombatBuff.Checked = MudAssist.Settings.PreCombatBuff;
            cbxOutOfCombatPullBuff.Checked = MudAssist.Settings.PullBuff;
            cbxCombatActionsPull.Checked = MudAssist.Settings.Pull;
            cbxCombatActionsHeal.Checked = MudAssist.Settings.Heal;
            cbxCombatActionsBuff.Checked = MudAssist.Settings.CombatBuff;
            cbxCombatActionsCombat.Checked = MudAssist.Settings.Combat;

            cmbNavigationProvider.Items.Clear();
            cmbNavigationProvider.Items.AddRange(MudAssist.SupportedNavigationProviders);
            cmbNavigationProvider.SelectedIndex = MudAssist.Settings.NavigationProvider;
            cbxAutoFace.Checked = MudAssist.Settings.AutoFaceTarget = GameSettingsManager.FaceTargetOnAction;
            cbxAutoMoveTarget.Checked = MudAssist.Settings.AutoMove;
            numMinMoveDistanceTank.Value = MudAssist.Settings.FollowRangeMin;
            numMaxMoveDistanceTank.Value = MudAssist.Settings.FollowRangeMax;
            numTargetingDistance.Value = MudAssist.Settings.MaxTargetDistance;
            cmbTargetingMode.Items.Clear();
            cmbTargetingMode.Items.AddRange(MudAssist.TargetingModes);
            cmbTargetingMode.SelectedIndex = MudAssist.Settings.TargetingMode;
            SelectTargetingMode(MudAssist.Settings.TargetingMode);
            cmbMovementMode.Items.Clear();
            cmbMovementMode.Items.AddRange(MudAssist.MovementModes);
            cmbMovementMode.SelectedIndex = MudAssist.Settings.MovementMode;

            cbxEnableHotkeyUnPause.Checked = MudAssist.Settings.EnableHotkeyPause;
            cbxEnableHotkeyTargetMode.Checked = MudAssist.Settings.EnableHotkeyTargetMode;
            cbxEnableHotkeyToogleMovement.Checked = MudAssist.Settings.EnableHotkeyToogleMovement;
            cbxEnableHotkeyMovementMode.Checked = MudAssist.Settings.EnableHotkeyMovementMode;
            cmbHotkeyModifierPause.Items.Clear();
            cmbHotkeyModifierPause.Items.AddRange(MudAssist.ModifierKeyStrings);
            cmbHotkeyModifierPause.SelectedIndex = MudAssist.Settings.HotkeyModifierPause;
            cmbHotkeyModifierTargetMode.Items.Clear();
            cmbHotkeyModifierTargetMode.Items.AddRange(MudAssist.ModifierKeyStrings);
            cmbHotkeyModifierTargetMode.SelectedIndex = MudAssist.Settings.HotkeyModifierTargetMode;
            cmbHotkeyModifierToogleMovement.Items.Clear();
            cmbHotkeyModifierToogleMovement.Items.AddRange(MudAssist.ModifierKeyStrings);
            cmbHotkeyModifierToogleMovement.SelectedIndex = MudAssist.Settings.HotkeyModifierToogleMovement;
            cmbHotkeyModifierMovementMode.Items.Clear();
            cmbHotkeyModifierMovementMode.Items.AddRange(MudAssist.ModifierKeyStrings);
            cmbHotkeyModifierMovementMode.SelectedIndex = MudAssist.Settings.HotkeyModifierMovementMode;
            tbxHotkeyPause.Text = MudAssist.Settings.HotkeyPause;
            tbxHotkeyTargetMode.Text = MudAssist.Settings.HotkeyTargetMode;
            tbxHotkeyMovementMode.Text = MudAssist.Settings.HotkeyMovementMode;
            tbxHotkeyToogleMovement.Text = MudAssist.Settings.HotkeyToogleMovement;
        }

        private void UpdateCheckBoxes(object sender, bool updateSettings)
        {
            if (sender == cbxEnableHotkeyUnPause)
            {
                if (updateSettings) MudAssist.Settings.EnableHotkeyPause = cbxEnableHotkeyUnPause.Checked;
                cmbHotkeyModifierPause.Enabled = cbxEnableHotkeyUnPause.Checked;
                tbxHotkeyPause.Enabled = cbxEnableHotkeyUnPause.Checked;
            }
            else if (sender == cbxEnableHotkeyTargetMode)
            {
                if (updateSettings) MudAssist.Settings.EnableHotkeyTargetMode = cbxEnableHotkeyTargetMode.Checked;
                cmbHotkeyModifierTargetMode.Enabled = cbxEnableHotkeyTargetMode.Checked;
                tbxHotkeyTargetMode.Enabled = cbxEnableHotkeyTargetMode.Checked;
            }
            else if (sender == cbxEnableHotkeyToogleMovement)
            {
                if (updateSettings) MudAssist.Settings.EnableHotkeyToogleMovement = cbxEnableHotkeyToogleMovement.Checked;
                cmbHotkeyModifierToogleMovement.Enabled = cbxEnableHotkeyToogleMovement.Checked;
                tbxHotkeyToogleMovement.Enabled = cbxEnableHotkeyToogleMovement.Checked;
            }
            else if (sender == cbxEnableHotkeyMovementMode)
            {
                if (updateSettings) MudAssist.Settings.EnableHotkeyMovementMode = cbxEnableHotkeyMovementMode.Checked;
                cmbHotkeyModifierMovementMode.Enabled = cbxEnableHotkeyMovementMode.Checked;
                tbxHotkeyMovementMode.Enabled = cbxEnableHotkeyMovementMode.Checked;
            }
            else
            {
                UpdateCheckBoxes(cbxEnableHotkeyUnPause, false);
                UpdateCheckBoxes(cbxEnableHotkeyTargetMode, false);
                UpdateCheckBoxes(cbxEnableHotkeyToogleMovement, false);
                UpdateCheckBoxes(cbxEnableHotkeyMovementMode, false);
                cbxEnableHotkeyUnPause.Checked = MudAssist.Settings.EnableHotkeyPause;
                cbxEnableHotkeyTargetMode.Checked = MudAssist.Settings.EnableHotkeyTargetMode;
                cbxEnableHotkeyToogleMovement.Checked = MudAssist.Settings.EnableHotkeyToogleMovement;
                cbxEnableHotkeyMovementMode.Checked = MudAssist.Settings.EnableHotkeyMovementMode;
            }

            MudAssist.ResetHotkeys();
        }

        #endregion Custom Methods

        #region Misc Events

        private void OnTickTimer(object sender, EventArgs e)
        {
            if (MudAssist.IsStarted && !CommonBehaviors.IsLoading)
            {
                if (seconds >= 1 && seconds <= 10)
                {
                    t.Interval = seconds * 1000;
                    LoadCharInfo();
                }
                else if (seconds == 0)
                {
                    t.Interval = 1000;
                }
            }
        }

        #endregion Misc Events

        #region CheckBox Events

        private void OnCheckedAlwaysOnTop(object sender, EventArgs e) => MudAssist.Settings.AlwaysOnTop = TopMost = cbxAlwaysOnTop.Checked;

        private void OnCheckedAutoAcceptQuests(object sender, EventArgs e) => MudAssist.Settings.AcceptQuests = cbxAutoAcceptQuests.Checked;

        private void OnCheckedAutoCompleteQuests(object sender, EventArgs e) => MudAssist.Settings.CompleteQuests = cbxAutoCompleteQuests.Checked;

        private void OnCheckedAutoFace(object sender, EventArgs e) => MudAssist.Settings.AutoFaceTarget = GameSettingsManager.FaceTargetOnAction = cbxAutoFace.Checked;

        private void OnCheckedAutoMoveTarget(object sender, EventArgs e) => MudAssist.Settings.AutoMove = cbxAutoMoveTarget.Checked;

        private void OnCheckedAutoTalkToNPCs(object sender, EventArgs e) => MudAssist.Settings.TalkToNPC = cbxAutoTalkToNPCs.Checked;

        private void OnCheckedCombatActionsBuff(object sender, EventArgs e) => MudAssist.Settings.CombatBuff = cbxCombatActionsBuff.Checked;

        private void OnCheckedCombatActionsCombat(object sender, EventArgs e) => MudAssist.Settings.Combat = cbxCombatActionsCombat.Checked;

        private void OnCheckedCombatActionsHeal(object sender, EventArgs e) => MudAssist.Settings.Heal = cbxCombatActionsHeal.Checked;

        private void OnCheckedCombatActionsPull(object sender, EventArgs e) => MudAssist.Settings.Pull = cbxCombatActionsPull.Checked;

        private void OnCheckedEnableHotkeyMovementMode(object sender, EventArgs e) => UpdateCheckBoxes(sender, true);

        private void OnCheckedEnableHotkeyTargetMode(object sender, EventArgs e) => UpdateCheckBoxes(sender, true);

        private void OnCheckedEnableHotkeyUnPause(object sender, EventArgs e) => UpdateCheckBoxes(sender, true);

        private void OnCheckedEnableOverlay(object sender, EventArgs e) => MudAssist.Settings.EnableOverlay = cbxEnableOverlay.Checked;

        private void OnCheckedEnableToogleMovement(object sender, EventArgs e) => UpdateCheckBoxes(sender, true);

        private void OnCheckedExecuteWhileMoving(object sender, EventArgs e) => MudAssist.Settings.ExecuteWhileMoving = cbxExecuteWhileMoving.Checked;

        private void OnCheckedHideCharName(object sender, EventArgs e)
        {
            if (cbxCharHideName.Checked) tbxCharName.UseSystemPasswordChar = true;
            else tbxCharName.UseSystemPasswordChar = false;
            MudAssist.Settings.HideName = cbxCharHideName.Checked;
        }

        private void OnCheckedOutOfCombatBuff(object sender, EventArgs e) => MudAssist.Settings.PreCombatBuff = cbxOutOfCombatBuff.Checked;

        private void OnCheckedOutOfCombatHeal(object sender, EventArgs e) => MudAssist.Settings.HealOutOfCombat = cbxOutOfCombatHeal.Checked;

        private void OnCheckedOutOfCombatPullBuff(object sender, EventArgs e) => MudAssist.Settings.PullBuff = cbxOutOfCombatPullBuff.Checked;

        private void OnCheckedOutOfCombatRest(object sender, EventArgs e) => MudAssist.Settings.Rest = cbxOutOfCombatRest.Checked;

        private void OnCheckedPaused(object sender, EventArgs e) => MudAssist.Settings.Paused = cbxPaused.Checked;

        private void OnCheckedSkipCutscenes(object sender, EventArgs e) => MudAssist.Settings.SkipCustscenes = cbxAutoSkipCutscenes.Checked;

        private void OnCheckedSprintInCombat(object sender, EventArgs e) => MudAssist.Settings.SprintInCombat = cbxSprintInInstance.Checked;

        private void OnCheckedSprintInInstance(object sender, EventArgs e) => MudAssist.Settings.SprintInInstance = cbxSprintInCombat.Checked;

        private void OnCheckedSprintOutOfCombat(object sender, EventArgs e) => MudAssist.Settings.SprintOutOfCombat = cbxSprintOutOfCombat.Checked;

        #endregion CheckBox Events

        #region ComboBox Events

        private void OnSelectedCombatRoutine(object sender, EventArgs e)
        {
            string selected = (sender as ComboBox).Items[cmbCombatRoutines.SelectedIndex].ToString();
            if (selected.Equals(RoutineManager.Current.Name)) return;
            RoutineManager.Current.ShutDown();
            RoutineManager.PreferedRoutine = (sender as ComboBox).Items[cmbCombatRoutines.SelectedIndex].ToString();
            RoutineManager.PickRoutine();
        }

        private void OnSelectedHotkeyModifierMovement(object sender, EventArgs e) => MudAssist.Settings.HotkeyModifierToogleMovement = cmbHotkeyModifierToogleMovement.SelectedIndex;

        private void OnSelectedHotkeyModifierMovementMode(object sender, EventArgs e) => MudAssist.Settings.HotkeyModifierTargetMode = cmbHotkeyModifierMovementMode.SelectedIndex;

        private void OnSelectedHotkeyModifierPause(object sender, EventArgs e) => MudAssist.Settings.HotkeyModifierPause = cmbHotkeyModifierPause.SelectedIndex;

        private void OnSelectedHotkeyModifierTargetMode(object sender, EventArgs e) => MudAssist.Settings.HotkeyModifierTargetMode = cmbHotkeyModifierTargetMode.SelectedIndex;

        private void OnSelectedMovementMode(object sender, EventArgs e) => MudAssist.Settings.MovementMode = cmbMovementMode.SelectedIndex;

        private void OnSelectedNavigationProvider(object sender, EventArgs e)
        {
            MudAssist.Settings.NavigationProvider = cmbNavigationProvider.SelectedIndex;
            MudAssist.UpdateNavigationProvider();
        }

        private void OnSelectedSecondsBetweenUpdate(object sender, EventArgs e) => MudAssist.Settings.SecondsBetweenUpdate = cmbSecondsBetweenUpdate.SelectedIndex;

        private void OnSelectedTargetingMode(object sender, EventArgs e) => MudAssist.Settings.TargetingMode = cmbTargetingMode.SelectedIndex;

        #endregion ComboBox Events

        #region TextBox Events

        private void OnTextChangedtbxHotkeyMovementMode(object sender, EventArgs e) => MudAssist.Settings.HotkeyMovementMode = tbxHotkeyMovementMode.Text;

        private void OnTextChangedtbxHotkeyPause(object sender, EventArgs e) => MudAssist.Settings.HotkeyPause = tbxHotkeyPause.Text;

        private void OnTextChangedtbxHotkeyTargetMode(object sender, EventArgs e) => MudAssist.Settings.HotkeyTargetMode = tbxHotkeyTargetMode.Text;

        private void OnTextChangedtbxHotkeyToogleMovement(object sender, EventArgs e) => MudAssist.Settings.HotkeyToogleMovement = tbxHotkeyToogleMovement.Text;

        #endregion TextBox Events
    }
}