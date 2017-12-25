using System.ComponentModel;
using System.Windows.Forms;

namespace Mud.Settings.Forms
{
	partial class SettingsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.stpStatus = new System.Windows.Forms.StatusStrip();
            this.tspPauseStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspMovementStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspFollowModeStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspTargetModeStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabCharInfo = new System.Windows.Forms.TabPage();
            this.gbxCharInfo = new System.Windows.Forms.GroupBox();
            this.tbxCharMP_CP_GPPerc = new System.Windows.Forms.TextBox();
            this.tbxCharTPPerc = new System.Windows.Forms.TextBox();
            this.tbxCharHPPerc = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.cmbSecondsBetweenUpdate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxCharRole = new System.Windows.Forms.GroupBox();
            this.tbxCharPiety = new System.Windows.Forms.TextBox();
            this.tbxCharTenacity = new System.Windows.Forms.TextBox();
            this.gbxCharExtra = new System.Windows.Forms.GroupBox();
            this.tbxCharSpellSpeed = new System.Windows.Forms.TextBox();
            this.tbxCharAttackMagicPotency = new System.Windows.Forms.TextBox();
            this.tbxCharHealingMagicPotency = new System.Windows.Forms.TextBox();
            this.gbxCharPhysical = new System.Windows.Forms.GroupBox();
            this.tbxCharSkillSpeed = new System.Windows.Forms.TextBox();
            this.tbxCharAttackPower = new System.Windows.Forms.TextBox();
            this.gbxElementalResistances = new System.Windows.Forms.GroupBox();
            this.ptbCharLightningResistance = new System.Windows.Forms.PictureBox();
            this.ptbCharEarthResistance = new System.Windows.Forms.PictureBox();
            this.ptbCharWaterResistance = new System.Windows.Forms.PictureBox();
            this.ptbCharWindResistance = new System.Windows.Forms.PictureBox();
            this.ptbCharIceResistance = new System.Windows.Forms.PictureBox();
            this.ptbCharFireResistance = new System.Windows.Forms.PictureBox();
            this.tbxCharWaterResistance = new System.Windows.Forms.TextBox();
            this.tbxCharLightningResistance = new System.Windows.Forms.TextBox();
            this.tbxCharEarthResistance = new System.Windows.Forms.TextBox();
            this.tbxCharWindResistance = new System.Windows.Forms.TextBox();
            this.tbxCharIceResistance = new System.Windows.Forms.TextBox();
            this.tbxCharFireResistance = new System.Windows.Forms.TextBox();
            this.gbxCharDefensive = new System.Windows.Forms.GroupBox();
            this.tbxCharDefense = new System.Windows.Forms.TextBox();
            this.tbxCharMagicDefense = new System.Windows.Forms.TextBox();
            this.gbxCharOffensive = new System.Windows.Forms.GroupBox();
            this.tbxCharDirectHit = new System.Windows.Forms.TextBox();
            this.tbxCharCriticalHit = new System.Windows.Forms.TextBox();
            this.cbxCharHideName = new System.Windows.Forms.CheckBox();
            this.tbxCharGrandCompany = new System.Windows.Forms.TextBox();
            this.ptbCharGrandCompany = new System.Windows.Forms.PictureBox();
            this.tbxCharTP = new System.Windows.Forms.TextBox();
            this.tbxCharMP_CP_GP = new System.Windows.Forms.TextBox();
            this.tbxCharHP = new System.Windows.Forms.TextBox();
            this.gbxCharAttributes = new System.Windows.Forms.GroupBox();
            this.tbxCharMind = new System.Windows.Forms.TextBox();
            this.tbxCharIntelligence = new System.Windows.Forms.TextBox();
            this.tbxCharVitality = new System.Windows.Forms.TextBox();
            this.tbxCharDexterity = new System.Windows.Forms.TextBox();
            this.tbxCharStrength = new System.Windows.Forms.TextBox();
            this.tbxCharJobNameLevel = new System.Windows.Forms.TextBox();
            this.tbxCharName = new System.Windows.Forms.TextBox();
            this.ptbCharJobIcon = new System.Windows.Forms.PictureBox();
            this.lblCharHP = new System.Windows.Forms.Label();
            this.lblCharMP_CP_GP = new System.Windows.Forms.Label();
            this.lblCharTP = new System.Windows.Forms.Label();
            this.tabRoutine = new System.Windows.Forms.TabPage();
            this.spcRoutineActions = new System.Windows.Forms.SplitContainer();
            this.gbxOutOfCombat = new System.Windows.Forms.GroupBox();
            this.cbxOutOfCombatPullBuff = new System.Windows.Forms.CheckBox();
            this.cbxOutOfCombatRest = new System.Windows.Forms.CheckBox();
            this.cbxOutOfCombatHeal = new System.Windows.Forms.CheckBox();
            this.cbxOutOfCombatBuff = new System.Windows.Forms.CheckBox();
            this.gbxCombatActions = new System.Windows.Forms.GroupBox();
            this.cbxCombatActionsCombat = new System.Windows.Forms.CheckBox();
            this.cbxCombatActionsHeal = new System.Windows.Forms.CheckBox();
            this.cbxCombatActionsBuff = new System.Windows.Forms.CheckBox();
            this.cbxCombatActionsPull = new System.Windows.Forms.CheckBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cmbCombatRoutines = new System.Windows.Forms.ComboBox();
            this.lblCombatRoutineName = new System.Windows.Forms.Label();
            this.tabMovement = new System.Windows.Forms.TabPage();
            this.cbxAutoFace = new System.Windows.Forms.CheckBox();
            this.lblDistanceYalms = new System.Windows.Forms.Label();
            this.gbxMoveInRange = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cmbTargetingMode = new System.Windows.Forms.ComboBox();
            this.lblTargetingDistanceYalms = new System.Windows.Forms.Label();
            this.lblTargetingDistance = new System.Windows.Forms.Label();
            this.lblTargetingMode = new System.Windows.Forms.Label();
            this.numTargetingDistance = new System.Windows.Forms.NumericUpDown();
            this.lblMoveWithinFollow = new System.Windows.Forms.Label();
            this.cbxAutoMoveTarget = new System.Windows.Forms.CheckBox();
            this.numMaxMoveDistanceTank = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbMovementMode = new System.Windows.Forms.ComboBox();
            this.lblOfFollowTarget = new System.Windows.Forms.Label();
            this.lblMovementMode = new System.Windows.Forms.Label();
            this.lblWhen = new System.Windows.Forms.Label();
            this.numMinMoveDistanceTank = new System.Windows.Forms.NumericUpDown();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cmbNavigationProvider = new System.Windows.Forms.ComboBox();
            this.lblNavigationProvider = new System.Windows.Forms.Label();
            this.tabHotkeys = new System.Windows.Forms.TabPage();
            this.cbxEnableHotkeyMovementMode = new System.Windows.Forms.CheckBox();
            this.cbxEnableHotkeyToogleMovement = new System.Windows.Forms.CheckBox();
            this.cbxEnableHotkeyTargetMode = new System.Windows.Forms.CheckBox();
            this.cbxEnableHotkeyUnPause = new System.Windows.Forms.CheckBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cmbHotkeyModifierMovementMode = new System.Windows.Forms.ComboBox();
            this.lblHotkeyMoveMode = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbHotkeyModifierPause = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbHotkeyModifierTargetMode = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbHotkeyModifierToogleMovement = new System.Windows.Forms.ComboBox();
            this.lblHotkeyMovement = new System.Windows.Forms.Label();
            this.lblHotkeyTargetMode = new System.Windows.Forms.Label();
            this.lblHotkeyPause = new System.Windows.Forms.Label();
            this.tbxHotkeyMovementMode = new System.Windows.Forms.TextBox();
            this.tbxHotkeyToogleMovement = new System.Windows.Forms.TextBox();
            this.tbxHotkeyTargetMode = new System.Windows.Forms.TextBox();
            this.tbxHotkeyPause = new System.Windows.Forms.TextBox();
            this.tabMisc = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxSprint = new System.Windows.Forms.GroupBox();
            this.cbxSprintInInstance = new System.Windows.Forms.CheckBox();
            this.cbxSprintInCombat = new System.Windows.Forms.CheckBox();
            this.cbxSprintOutOfCombat = new System.Windows.Forms.CheckBox();
            this.gbxGeneralSettings = new System.Windows.Forms.GroupBox();
            this.cbxPaused = new System.Windows.Forms.CheckBox();
            this.cbxExecuteWhileMoving = new System.Windows.Forms.CheckBox();
            this.cbxAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.gbxHotkeyMessages = new System.Windows.Forms.GroupBox();
            this.cbxEnableOverlay = new System.Windows.Forms.CheckBox();
            this.gbxQuesting = new System.Windows.Forms.GroupBox();
            this.cbxAutoCompleteQuests = new System.Windows.Forms.CheckBox();
            this.cbxAutoSkipCutscenes = new System.Windows.Forms.CheckBox();
            this.cbxAutoTalkToNPCs = new System.Windows.Forms.CheckBox();
            this.cbxAutoAcceptQuests = new System.Windows.Forms.CheckBox();
            this.stpStatus.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabCharInfo.SuspendLayout();
            this.gbxCharInfo.SuspendLayout();
            this.panel11.SuspendLayout();
            this.gbxCharRole.SuspendLayout();
            this.gbxCharExtra.SuspendLayout();
            this.gbxCharPhysical.SuspendLayout();
            this.gbxElementalResistances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCharLightningResistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCharEarthResistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCharWaterResistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCharWindResistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCharIceResistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCharFireResistance)).BeginInit();
            this.gbxCharDefensive.SuspendLayout();
            this.gbxCharOffensive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCharGrandCompany)).BeginInit();
            this.gbxCharAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCharJobIcon)).BeginInit();
            this.tabRoutine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcRoutineActions)).BeginInit();
            this.spcRoutineActions.Panel1.SuspendLayout();
            this.spcRoutineActions.Panel2.SuspendLayout();
            this.spcRoutineActions.SuspendLayout();
            this.gbxOutOfCombat.SuspendLayout();
            this.gbxCombatActions.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tabMovement.SuspendLayout();
            this.gbxMoveInRange.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetingDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMoveDistanceTank)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinMoveDistanceTank)).BeginInit();
            this.panel8.SuspendLayout();
            this.tabHotkeys.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabMisc.SuspendLayout();
            this.gbxSprint.SuspendLayout();
            this.gbxGeneralSettings.SuspendLayout();
            this.gbxHotkeyMessages.SuspendLayout();
            this.gbxQuesting.SuspendLayout();
            this.SuspendLayout();
            //
            // stpStatus
            //
            this.stpStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspPauseStatus,
            this.tspMovementStatus,
            this.tspFollowModeStatus,
            this.tspTargetModeStatus});
            this.stpStatus.Location = new System.Drawing.Point(0, 336);
            this.stpStatus.Name = "stpStatus";
            this.stpStatus.Size = new System.Drawing.Size(341, 22);
            this.stpStatus.TabIndex = 4;
            this.stpStatus.Text = "statusStrip1";
            //
            // tspPauseStatus
            //
            this.tspPauseStatus.Name = "tspPauseStatus";
            this.tspPauseStatus.Size = new System.Drawing.Size(108, 17);
            this.tspPauseStatus.Spring = true;
            //
            // tspMovementStatus
            //
            this.tspMovementStatus.Name = "tspMovementStatus";
            this.tspMovementStatus.Size = new System.Drawing.Size(108, 17);
            this.tspMovementStatus.Spring = true;
            //
            // tspFollowModeStatus
            //
            this.tspFollowModeStatus.Name = "tspFollowModeStatus";
            this.tspFollowModeStatus.Size = new System.Drawing.Size(108, 17);
            this.tspFollowModeStatus.Spring = true;
            //
            // tspTargetModeStatus
            //
            this.tspTargetModeStatus.Name = "tspTargetModeStatus";
            this.tspTargetModeStatus.Size = new System.Drawing.Size(0, 17);
            //
            // tabControlMain
            //
            this.tabControlMain.Controls.Add(this.tabCharInfo);
            this.tabControlMain.Controls.Add(this.tabRoutine);
            this.tabControlMain.Controls.Add(this.tabMovement);
            this.tabControlMain.Controls.Add(this.tabHotkeys);
            this.tabControlMain.Controls.Add(this.tabMisc);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(341, 336);
            this.tabControlMain.TabIndex = 20;
            this.tabControlMain.Tag = "XC";
            //
            // tabCharInfo
            //
            this.tabCharInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tabCharInfo.Controls.Add(this.gbxCharInfo);
            this.tabCharInfo.Location = new System.Drawing.Point(4, 22);
            this.tabCharInfo.Name = "tabCharInfo";
            this.tabCharInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCharInfo.Size = new System.Drawing.Size(333, 310);
            this.tabCharInfo.TabIndex = 5;
            this.tabCharInfo.Tag = "XC";
            this.tabCharInfo.Text = "Char Info";
            //
            // gbxCharInfo
            //
            this.gbxCharInfo.Controls.Add(this.tbxCharMP_CP_GPPerc);
            this.gbxCharInfo.Controls.Add(this.tbxCharTPPerc);
            this.gbxCharInfo.Controls.Add(this.tbxCharHPPerc);
            this.gbxCharInfo.Controls.Add(this.panel11);
            this.gbxCharInfo.Controls.Add(this.label2);
            this.gbxCharInfo.Controls.Add(this.gbxCharRole);
            this.gbxCharInfo.Controls.Add(this.gbxCharExtra);
            this.gbxCharInfo.Controls.Add(this.gbxCharPhysical);
            this.gbxCharInfo.Controls.Add(this.gbxElementalResistances);
            this.gbxCharInfo.Controls.Add(this.gbxCharDefensive);
            this.gbxCharInfo.Controls.Add(this.gbxCharOffensive);
            this.gbxCharInfo.Controls.Add(this.cbxCharHideName);
            this.gbxCharInfo.Controls.Add(this.tbxCharGrandCompany);
            this.gbxCharInfo.Controls.Add(this.ptbCharGrandCompany);
            this.gbxCharInfo.Controls.Add(this.tbxCharTP);
            this.gbxCharInfo.Controls.Add(this.tbxCharMP_CP_GP);
            this.gbxCharInfo.Controls.Add(this.tbxCharHP);
            this.gbxCharInfo.Controls.Add(this.gbxCharAttributes);
            this.gbxCharInfo.Controls.Add(this.tbxCharJobNameLevel);
            this.gbxCharInfo.Controls.Add(this.tbxCharName);
            this.gbxCharInfo.Controls.Add(this.ptbCharJobIcon);
            this.gbxCharInfo.Controls.Add(this.lblCharHP);
            this.gbxCharInfo.Controls.Add(this.lblCharMP_CP_GP);
            this.gbxCharInfo.Controls.Add(this.lblCharTP);
            this.gbxCharInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxCharInfo.Location = new System.Drawing.Point(3, 3);
            this.gbxCharInfo.Name = "gbxCharInfo";
            this.gbxCharInfo.Padding = new System.Windows.Forms.Padding(0);
            this.gbxCharInfo.Size = new System.Drawing.Size(327, 304);
            this.gbxCharInfo.TabIndex = 11;
            this.gbxCharInfo.TabStop = false;
            //
            // tbxCharMP_CP_GPPerc
            //
            this.tbxCharMP_CP_GPPerc.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharMP_CP_GPPerc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharMP_CP_GPPerc.Location = new System.Drawing.Point(146, 97);
            this.tbxCharMP_CP_GPPerc.Name = "tbxCharMP_CP_GPPerc";
            this.tbxCharMP_CP_GPPerc.ReadOnly = true;
            this.tbxCharMP_CP_GPPerc.Size = new System.Drawing.Size(76, 15);
            this.tbxCharMP_CP_GPPerc.TabIndex = 32;
            this.tbxCharMP_CP_GPPerc.Tag = "XC";
            this.tbxCharMP_CP_GPPerc.Text = "0/100 %";
            this.tbxCharMP_CP_GPPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // tbxCharTPPerc
            //
            this.tbxCharTPPerc.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharTPPerc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharTPPerc.Location = new System.Drawing.Point(252, 97);
            this.tbxCharTPPerc.Name = "tbxCharTPPerc";
            this.tbxCharTPPerc.ReadOnly = true;
            this.tbxCharTPPerc.Size = new System.Drawing.Size(70, 15);
            this.tbxCharTPPerc.TabIndex = 31;
            this.tbxCharTPPerc.Tag = "XC";
            this.tbxCharTPPerc.Text = "0/100 %";
            this.tbxCharTPPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // tbxCharHPPerc
            //
            this.tbxCharHPPerc.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharHPPerc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharHPPerc.Location = new System.Drawing.Point(35, 97);
            this.tbxCharHPPerc.Name = "tbxCharHPPerc";
            this.tbxCharHPPerc.ReadOnly = true;
            this.tbxCharHPPerc.Size = new System.Drawing.Size(76, 15);
            this.tbxCharHPPerc.TabIndex = 30;
            this.tbxCharHPPerc.Tag = "XC";
            this.tbxCharHPPerc.Text = "0/100 %";
            this.tbxCharHPPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // panel11
            //
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.cmbSecondsBetweenUpdate);
            this.panel11.Location = new System.Drawing.Point(280, 273);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(42, 23);
            this.panel11.TabIndex = 29;
            //
            // cmbSecondsBetweenUpdate
            //
            this.cmbSecondsBetweenUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSecondsBetweenUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecondsBetweenUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSecondsBetweenUpdate.FormattingEnabled = true;
            this.cmbSecondsBetweenUpdate.Location = new System.Drawing.Point(0, 0);
            this.cmbSecondsBetweenUpdate.Name = "cmbSecondsBetweenUpdate";
            this.cmbSecondsBetweenUpdate.Size = new System.Drawing.Size(40, 21);
            this.cmbSecondsBetweenUpdate.TabIndex = 9;
            this.cmbSecondsBetweenUpdate.Tag = "XC";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 28;
            this.label2.Tag = "XC";
            this.label2.Text = "Sec Between updates";
            //
            // gbxCharRole
            //
            this.gbxCharRole.Controls.Add(this.tbxCharPiety);
            this.gbxCharRole.Controls.Add(this.tbxCharTenacity);
            this.gbxCharRole.Location = new System.Drawing.Point(5, 263);
            this.gbxCharRole.Name = "gbxCharRole";
            this.gbxCharRole.Size = new System.Drawing.Size(154, 33);
            this.gbxCharRole.TabIndex = 26;
            this.gbxCharRole.TabStop = false;
            this.gbxCharRole.Tag = "XC";
            this.gbxCharRole.Text = "Role";
            //
            // tbxCharPiety
            //
            this.tbxCharPiety.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharPiety.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharPiety.Location = new System.Drawing.Point(81, 15);
            this.tbxCharPiety.Name = "tbxCharPiety";
            this.tbxCharPiety.ReadOnly = true;
            this.tbxCharPiety.Size = new System.Drawing.Size(65, 15);
            this.tbxCharPiety.TabIndex = 27;
            this.tbxCharPiety.Tag = "XC";
            this.tbxCharPiety.Text = "PTY : 9999";
            //
            // tbxCharTenacity
            //
            this.tbxCharTenacity.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharTenacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharTenacity.Location = new System.Drawing.Point(6, 15);
            this.tbxCharTenacity.Name = "tbxCharTenacity";
            this.tbxCharTenacity.ReadOnly = true;
            this.tbxCharTenacity.Size = new System.Drawing.Size(65, 15);
            this.tbxCharTenacity.TabIndex = 26;
            this.tbxCharTenacity.Tag = "XC";
            this.tbxCharTenacity.Text = "TNC : 9999";
            //
            // gbxCharExtra
            //
            this.gbxCharExtra.Controls.Add(this.tbxCharSpellSpeed);
            this.gbxCharExtra.Controls.Add(this.tbxCharAttackMagicPotency);
            this.gbxCharExtra.Controls.Add(this.tbxCharHealingMagicPotency);
            this.gbxCharExtra.Location = new System.Drawing.Point(250, 184);
            this.gbxCharExtra.Name = "gbxCharExtra";
            this.gbxCharExtra.Size = new System.Drawing.Size(72, 75);
            this.gbxCharExtra.TabIndex = 27;
            this.gbxCharExtra.TabStop = false;
            this.gbxCharExtra.Tag = "XC";
            this.gbxCharExtra.Text = "Mental";
            //
            // tbxCharSpellSpeed
            //
            this.tbxCharSpellSpeed.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharSpellSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharSpellSpeed.Location = new System.Drawing.Point(6, 55);
            this.tbxCharSpellSpeed.Name = "tbxCharSpellSpeed";
            this.tbxCharSpellSpeed.ReadOnly = true;
            this.tbxCharSpellSpeed.Size = new System.Drawing.Size(60, 15);
            this.tbxCharSpellSpeed.TabIndex = 25;
            this.tbxCharSpellSpeed.Tag = "XC";
            this.tbxCharSpellSpeed.Text = "SPD : 9999";
            //
            // tbxCharAttackMagicPotency
            //
            this.tbxCharAttackMagicPotency.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharAttackMagicPotency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharAttackMagicPotency.Location = new System.Drawing.Point(7, 17);
            this.tbxCharAttackMagicPotency.Name = "tbxCharAttackMagicPotency";
            this.tbxCharAttackMagicPotency.ReadOnly = true;
            this.tbxCharAttackMagicPotency.Size = new System.Drawing.Size(59, 15);
            this.tbxCharAttackMagicPotency.TabIndex = 22;
            this.tbxCharAttackMagicPotency.Tag = "XC";
            this.tbxCharAttackMagicPotency.Text = "AMP : 9999";
            //
            // tbxCharHealingMagicPotency
            //
            this.tbxCharHealingMagicPotency.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharHealingMagicPotency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharHealingMagicPotency.Location = new System.Drawing.Point(6, 36);
            this.tbxCharHealingMagicPotency.Name = "tbxCharHealingMagicPotency";
            this.tbxCharHealingMagicPotency.ReadOnly = true;
            this.tbxCharHealingMagicPotency.Size = new System.Drawing.Size(60, 15);
            this.tbxCharHealingMagicPotency.TabIndex = 24;
            this.tbxCharHealingMagicPotency.Tag = "XC";
            this.tbxCharHealingMagicPotency.Text = "HMP : 9999";
            //
            // gbxCharPhysical
            //
            this.gbxCharPhysical.Controls.Add(this.tbxCharSkillSpeed);
            this.gbxCharPhysical.Controls.Add(this.tbxCharAttackPower);
            this.gbxCharPhysical.Location = new System.Drawing.Point(250, 118);
            this.gbxCharPhysical.Name = "gbxCharPhysical";
            this.gbxCharPhysical.Size = new System.Drawing.Size(72, 60);
            this.gbxCharPhysical.TabIndex = 26;
            this.gbxCharPhysical.TabStop = false;
            this.gbxCharPhysical.Tag = "XC";
            this.gbxCharPhysical.Text = "Physical";
            //
            // tbxCharSkillSpeed
            //
            this.tbxCharSkillSpeed.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharSkillSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharSkillSpeed.Location = new System.Drawing.Point(6, 38);
            this.tbxCharSkillSpeed.Name = "tbxCharSkillSpeed";
            this.tbxCharSkillSpeed.ReadOnly = true;
            this.tbxCharSkillSpeed.Size = new System.Drawing.Size(60, 15);
            this.tbxCharSkillSpeed.TabIndex = 20;
            this.tbxCharSkillSpeed.Tag = "XC";
            this.tbxCharSkillSpeed.Text = "SPD : 9999";
            //
            // tbxCharAttackPower
            //
            this.tbxCharAttackPower.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharAttackPower.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharAttackPower.Location = new System.Drawing.Point(6, 17);
            this.tbxCharAttackPower.Name = "tbxCharAttackPower";
            this.tbxCharAttackPower.ReadOnly = true;
            this.tbxCharAttackPower.Size = new System.Drawing.Size(60, 15);
            this.tbxCharAttackPower.TabIndex = 18;
            this.tbxCharAttackPower.Tag = "XC";
            this.tbxCharAttackPower.Text = "ATK : 9999";
            //
            // gbxElementalResistances
            //
            this.gbxElementalResistances.Controls.Add(this.ptbCharLightningResistance);
            this.gbxElementalResistances.Controls.Add(this.ptbCharEarthResistance);
            this.gbxElementalResistances.Controls.Add(this.ptbCharWaterResistance);
            this.gbxElementalResistances.Controls.Add(this.ptbCharWindResistance);
            this.gbxElementalResistances.Controls.Add(this.ptbCharIceResistance);
            this.gbxElementalResistances.Controls.Add(this.ptbCharFireResistance);
            this.gbxElementalResistances.Controls.Add(this.tbxCharWaterResistance);
            this.gbxElementalResistances.Controls.Add(this.tbxCharLightningResistance);
            this.gbxElementalResistances.Controls.Add(this.tbxCharEarthResistance);
            this.gbxElementalResistances.Controls.Add(this.tbxCharWindResistance);
            this.gbxElementalResistances.Controls.Add(this.tbxCharIceResistance);
            this.gbxElementalResistances.Controls.Add(this.tbxCharFireResistance);
            this.gbxElementalResistances.Location = new System.Drawing.Point(90, 118);
            this.gbxElementalResistances.Name = "gbxElementalResistances";
            this.gbxElementalResistances.Size = new System.Drawing.Size(69, 141);
            this.gbxElementalResistances.TabIndex = 27;
            this.gbxElementalResistances.TabStop = false;
            this.gbxElementalResistances.Tag = "XC";
            this.gbxElementalResistances.Text = "Elem Res";
            //
            // ptbCharLightningResistance
            //
            this.ptbCharLightningResistance.Image = global::Mud.Properties.Resources.LIGHTNING;
            this.ptbCharLightningResistance.Location = new System.Drawing.Point(6, 100);
            this.ptbCharLightningResistance.MaximumSize = new System.Drawing.Size(16, 16);
            this.ptbCharLightningResistance.Name = "ptbCharLightningResistance";
            this.ptbCharLightningResistance.Size = new System.Drawing.Size(16, 16);
            this.ptbCharLightningResistance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCharLightningResistance.TabIndex = 33;
            this.ptbCharLightningResistance.TabStop = false;
            this.ptbCharLightningResistance.Tag = "XC";
            //
            // ptbCharEarthResistance
            //
            this.ptbCharEarthResistance.Image = global::Mud.Properties.Resources.EARTH;
            this.ptbCharEarthResistance.Location = new System.Drawing.Point(6, 79);
            this.ptbCharEarthResistance.MaximumSize = new System.Drawing.Size(16, 16);
            this.ptbCharEarthResistance.Name = "ptbCharEarthResistance";
            this.ptbCharEarthResistance.Size = new System.Drawing.Size(16, 16);
            this.ptbCharEarthResistance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCharEarthResistance.TabIndex = 32;
            this.ptbCharEarthResistance.TabStop = false;
            this.ptbCharEarthResistance.Tag = "XC";
            //
            // ptbCharWaterResistance
            //
            this.ptbCharWaterResistance.Image = global::Mud.Properties.Resources.WATER;
            this.ptbCharWaterResistance.Location = new System.Drawing.Point(6, 120);
            this.ptbCharWaterResistance.MaximumSize = new System.Drawing.Size(16, 16);
            this.ptbCharWaterResistance.Name = "ptbCharWaterResistance";
            this.ptbCharWaterResistance.Size = new System.Drawing.Size(16, 16);
            this.ptbCharWaterResistance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCharWaterResistance.TabIndex = 31;
            this.ptbCharWaterResistance.TabStop = false;
            this.ptbCharWaterResistance.Tag = "XC";
            //
            // ptbCharWindResistance
            //
            this.ptbCharWindResistance.Image = global::Mud.Properties.Resources.WIND;
            this.ptbCharWindResistance.Location = new System.Drawing.Point(6, 58);
            this.ptbCharWindResistance.MaximumSize = new System.Drawing.Size(16, 16);
            this.ptbCharWindResistance.Name = "ptbCharWindResistance";
            this.ptbCharWindResistance.Size = new System.Drawing.Size(16, 16);
            this.ptbCharWindResistance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCharWindResistance.TabIndex = 30;
            this.ptbCharWindResistance.TabStop = false;
            this.ptbCharWindResistance.Tag = "XC";
            //
            // ptbCharIceResistance
            //
            this.ptbCharIceResistance.Image = global::Mud.Properties.Resources.ICE;
            this.ptbCharIceResistance.Location = new System.Drawing.Point(6, 37);
            this.ptbCharIceResistance.MaximumSize = new System.Drawing.Size(16, 16);
            this.ptbCharIceResistance.Name = "ptbCharIceResistance";
            this.ptbCharIceResistance.Size = new System.Drawing.Size(16, 16);
            this.ptbCharIceResistance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCharIceResistance.TabIndex = 29;
            this.ptbCharIceResistance.TabStop = false;
            this.ptbCharIceResistance.Tag = "XC";
            //
            // ptbCharFireResistance
            //
            this.ptbCharFireResistance.Image = global::Mud.Properties.Resources.FIRE;
            this.ptbCharFireResistance.Location = new System.Drawing.Point(6, 15);
            this.ptbCharFireResistance.MaximumSize = new System.Drawing.Size(16, 16);
            this.ptbCharFireResistance.Name = "ptbCharFireResistance";
            this.ptbCharFireResistance.Size = new System.Drawing.Size(16, 16);
            this.ptbCharFireResistance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCharFireResistance.TabIndex = 28;
            this.ptbCharFireResistance.TabStop = false;
            this.ptbCharFireResistance.Tag = "XC";
            //
            // tbxCharWaterResistance
            //
            this.tbxCharWaterResistance.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharWaterResistance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharWaterResistance.Location = new System.Drawing.Point(30, 122);
            this.tbxCharWaterResistance.Name = "tbxCharWaterResistance";
            this.tbxCharWaterResistance.ReadOnly = true;
            this.tbxCharWaterResistance.Size = new System.Drawing.Size(31, 15);
            this.tbxCharWaterResistance.TabIndex = 25;
            this.tbxCharWaterResistance.Tag = "XC";
            this.tbxCharWaterResistance.Text = "99999";
            //
            // tbxCharLightningResistance
            //
            this.tbxCharLightningResistance.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharLightningResistance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharLightningResistance.Location = new System.Drawing.Point(30, 101);
            this.tbxCharLightningResistance.Name = "tbxCharLightningResistance";
            this.tbxCharLightningResistance.ReadOnly = true;
            this.tbxCharLightningResistance.Size = new System.Drawing.Size(31, 15);
            this.tbxCharLightningResistance.TabIndex = 24;
            this.tbxCharLightningResistance.Tag = "XC";
            this.tbxCharLightningResistance.Text = "99999";
            //
            // tbxCharEarthResistance
            //
            this.tbxCharEarthResistance.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharEarthResistance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharEarthResistance.Location = new System.Drawing.Point(30, 80);
            this.tbxCharEarthResistance.Name = "tbxCharEarthResistance";
            this.tbxCharEarthResistance.ReadOnly = true;
            this.tbxCharEarthResistance.Size = new System.Drawing.Size(31, 15);
            this.tbxCharEarthResistance.TabIndex = 22;
            this.tbxCharEarthResistance.Tag = "XC";
            this.tbxCharEarthResistance.Text = "99999";
            //
            // tbxCharWindResistance
            //
            this.tbxCharWindResistance.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharWindResistance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharWindResistance.Location = new System.Drawing.Point(30, 59);
            this.tbxCharWindResistance.Name = "tbxCharWindResistance";
            this.tbxCharWindResistance.ReadOnly = true;
            this.tbxCharWindResistance.Size = new System.Drawing.Size(31, 15);
            this.tbxCharWindResistance.TabIndex = 20;
            this.tbxCharWindResistance.Tag = "XC";
            this.tbxCharWindResistance.Text = "99999";
            //
            // tbxCharIceResistance
            //
            this.tbxCharIceResistance.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharIceResistance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharIceResistance.Location = new System.Drawing.Point(30, 38);
            this.tbxCharIceResistance.Name = "tbxCharIceResistance";
            this.tbxCharIceResistance.ReadOnly = true;
            this.tbxCharIceResistance.Size = new System.Drawing.Size(31, 15);
            this.tbxCharIceResistance.TabIndex = 19;
            this.tbxCharIceResistance.Tag = "XC";
            this.tbxCharIceResistance.Text = "99999";
            //
            // tbxCharFireResistance
            //
            this.tbxCharFireResistance.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharFireResistance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharFireResistance.Location = new System.Drawing.Point(30, 17);
            this.tbxCharFireResistance.Name = "tbxCharFireResistance";
            this.tbxCharFireResistance.ReadOnly = true;
            this.tbxCharFireResistance.Size = new System.Drawing.Size(31, 15);
            this.tbxCharFireResistance.TabIndex = 18;
            this.tbxCharFireResistance.Tag = "XC";
            this.tbxCharFireResistance.Text = "99999";
            //
            // gbxCharDefensive
            //
            this.gbxCharDefensive.Controls.Add(this.tbxCharDefense);
            this.gbxCharDefensive.Controls.Add(this.tbxCharMagicDefense);
            this.gbxCharDefensive.Location = new System.Drawing.Point(165, 184);
            this.gbxCharDefensive.Name = "gbxCharDefensive";
            this.gbxCharDefensive.Size = new System.Drawing.Size(79, 63);
            this.gbxCharDefensive.TabIndex = 26;
            this.gbxCharDefensive.TabStop = false;
            this.gbxCharDefensive.Tag = "XC";
            this.gbxCharDefensive.Text = "Defensive";
            //
            // tbxCharDefense
            //
            this.tbxCharDefense.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharDefense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharDefense.Location = new System.Drawing.Point(6, 20);
            this.tbxCharDefense.Name = "tbxCharDefense";
            this.tbxCharDefense.ReadOnly = true;
            this.tbxCharDefense.Size = new System.Drawing.Size(65, 15);
            this.tbxCharDefense.TabIndex = 22;
            this.tbxCharDefense.Tag = "XC";
            this.tbxCharDefense.Text = "DEF : 9999";
            //
            // tbxCharMagicDefense
            //
            this.tbxCharMagicDefense.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharMagicDefense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharMagicDefense.Location = new System.Drawing.Point(6, 41);
            this.tbxCharMagicDefense.Name = "tbxCharMagicDefense";
            this.tbxCharMagicDefense.ReadOnly = true;
            this.tbxCharMagicDefense.Size = new System.Drawing.Size(65, 15);
            this.tbxCharMagicDefense.TabIndex = 24;
            this.tbxCharMagicDefense.Tag = "XC";
            this.tbxCharMagicDefense.Text = "MDEF : 9999";
            //
            // gbxCharOffensive
            //
            this.gbxCharOffensive.Controls.Add(this.tbxCharDirectHit);
            this.gbxCharOffensive.Controls.Add(this.tbxCharCriticalHit);
            this.gbxCharOffensive.Location = new System.Drawing.Point(165, 118);
            this.gbxCharOffensive.Name = "gbxCharOffensive";
            this.gbxCharOffensive.Size = new System.Drawing.Size(79, 60);
            this.gbxCharOffensive.TabIndex = 25;
            this.gbxCharOffensive.TabStop = false;
            this.gbxCharOffensive.Tag = "XC";
            this.gbxCharOffensive.Text = "Offensive";
            //
            // tbxCharDirectHit
            //
            this.tbxCharDirectHit.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharDirectHit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharDirectHit.Location = new System.Drawing.Point(6, 38);
            this.tbxCharDirectHit.Name = "tbxCharDirectHit";
            this.tbxCharDirectHit.ReadOnly = true;
            this.tbxCharDirectHit.Size = new System.Drawing.Size(65, 15);
            this.tbxCharDirectHit.TabIndex = 20;
            this.tbxCharDirectHit.Tag = "XC";
            this.tbxCharDirectHit.Text = "DHIT : 9999";
            //
            // tbxCharCriticalHit
            //
            this.tbxCharCriticalHit.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharCriticalHit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharCriticalHit.Location = new System.Drawing.Point(6, 17);
            this.tbxCharCriticalHit.Name = "tbxCharCriticalHit";
            this.tbxCharCriticalHit.ReadOnly = true;
            this.tbxCharCriticalHit.Size = new System.Drawing.Size(65, 15);
            this.tbxCharCriticalHit.TabIndex = 18;
            this.tbxCharCriticalHit.Tag = "XC";
            this.tbxCharCriticalHit.Text = "CRIT : 9999";
            //
            // cbxCharHideName
            //
            this.cbxCharHideName.AutoSize = true;
            this.cbxCharHideName.Location = new System.Drawing.Point(272, 11);
            this.cbxCharHideName.Name = "cbxCharHideName";
            this.cbxCharHideName.Size = new System.Drawing.Size(50, 17);
            this.cbxCharHideName.TabIndex = 20;
            this.cbxCharHideName.Text = "Hide";
            this.cbxCharHideName.UseVisualStyleBackColor = true;
            this.cbxCharHideName.CheckedChanged += new System.EventHandler(this.OnCheckedHideCharName);
            //
            // tbxCharGrandCompany
            //
            this.tbxCharGrandCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharGrandCompany.Location = new System.Drawing.Point(108, 52);
            this.tbxCharGrandCompany.Name = "tbxCharGrandCompany";
            this.tbxCharGrandCompany.ReadOnly = true;
            this.tbxCharGrandCompany.Size = new System.Drawing.Size(214, 15);
            this.tbxCharGrandCompany.TabIndex = 19;
            this.tbxCharGrandCompany.Tag = "XC";
            this.tbxCharGrandCompany.Text = "Grand Company Name";
            //
            // ptbCharGrandCompany
            //
            this.ptbCharGrandCompany.Location = new System.Drawing.Point(78, 47);
            this.ptbCharGrandCompany.MaximumSize = new System.Drawing.Size(24, 24);
            this.ptbCharGrandCompany.Name = "ptbCharGrandCompany";
            this.ptbCharGrandCompany.Size = new System.Drawing.Size(24, 24);
            this.ptbCharGrandCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCharGrandCompany.TabIndex = 18;
            this.ptbCharGrandCompany.TabStop = false;
            this.ptbCharGrandCompany.Tag = "XC";
            //
            // tbxCharTP
            //
            this.tbxCharTP.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharTP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharTP.Location = new System.Drawing.Point(252, 76);
            this.tbxCharTP.Name = "tbxCharTP";
            this.tbxCharTP.ReadOnly = true;
            this.tbxCharTP.Size = new System.Drawing.Size(70, 15);
            this.tbxCharTP.TabIndex = 17;
            this.tbxCharTP.Tag = "XC";
            this.tbxCharTP.Text = "9999/9999";
            this.tbxCharTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // tbxCharMP_CP_GP
            //
            this.tbxCharMP_CP_GP.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharMP_CP_GP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharMP_CP_GP.Location = new System.Drawing.Point(146, 76);
            this.tbxCharMP_CP_GP.Name = "tbxCharMP_CP_GP";
            this.tbxCharMP_CP_GP.ReadOnly = true;
            this.tbxCharMP_CP_GP.Size = new System.Drawing.Size(76, 15);
            this.tbxCharMP_CP_GP.TabIndex = 16;
            this.tbxCharMP_CP_GP.Tag = "XC";
            this.tbxCharMP_CP_GP.Text = "99999/99999";
            this.tbxCharMP_CP_GP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // tbxCharHP
            //
            this.tbxCharHP.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharHP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharHP.Location = new System.Drawing.Point(35, 76);
            this.tbxCharHP.Name = "tbxCharHP";
            this.tbxCharHP.ReadOnly = true;
            this.tbxCharHP.Size = new System.Drawing.Size(76, 15);
            this.tbxCharHP.TabIndex = 15;
            this.tbxCharHP.Tag = "XC";
            this.tbxCharHP.Text = "99999/99999";
            this.tbxCharHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // gbxCharAttributes
            //
            this.gbxCharAttributes.Controls.Add(this.tbxCharMind);
            this.gbxCharAttributes.Controls.Add(this.tbxCharIntelligence);
            this.gbxCharAttributes.Controls.Add(this.tbxCharVitality);
            this.gbxCharAttributes.Controls.Add(this.tbxCharDexterity);
            this.gbxCharAttributes.Controls.Add(this.tbxCharStrength);
            this.gbxCharAttributes.Location = new System.Drawing.Point(5, 118);
            this.gbxCharAttributes.Name = "gbxCharAttributes";
            this.gbxCharAttributes.Size = new System.Drawing.Size(79, 122);
            this.gbxCharAttributes.TabIndex = 14;
            this.gbxCharAttributes.TabStop = false;
            this.gbxCharAttributes.Tag = "XC";
            this.gbxCharAttributes.Text = "Attributes";
            //
            // tbxCharMind
            //
            this.tbxCharMind.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharMind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharMind.Location = new System.Drawing.Point(6, 102);
            this.tbxCharMind.Name = "tbxCharMind";
            this.tbxCharMind.ReadOnly = true;
            this.tbxCharMind.Size = new System.Drawing.Size(65, 15);
            this.tbxCharMind.TabIndex = 24;
            this.tbxCharMind.Tag = "XC";
            this.tbxCharMind.Text = "MND : 9999";
            //
            // tbxCharIntelligence
            //
            this.tbxCharIntelligence.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharIntelligence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharIntelligence.Location = new System.Drawing.Point(6, 81);
            this.tbxCharIntelligence.Name = "tbxCharIntelligence";
            this.tbxCharIntelligence.ReadOnly = true;
            this.tbxCharIntelligence.Size = new System.Drawing.Size(65, 15);
            this.tbxCharIntelligence.TabIndex = 22;
            this.tbxCharIntelligence.Tag = "XC";
            this.tbxCharIntelligence.Text = "INT : 9999";
            //
            // tbxCharVitality
            //
            this.tbxCharVitality.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharVitality.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharVitality.Location = new System.Drawing.Point(6, 60);
            this.tbxCharVitality.Name = "tbxCharVitality";
            this.tbxCharVitality.ReadOnly = true;
            this.tbxCharVitality.Size = new System.Drawing.Size(65, 15);
            this.tbxCharVitality.TabIndex = 20;
            this.tbxCharVitality.Tag = "XC";
            this.tbxCharVitality.Text = "VIT : 9999";
            //
            // tbxCharDexterity
            //
            this.tbxCharDexterity.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharDexterity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharDexterity.Location = new System.Drawing.Point(6, 39);
            this.tbxCharDexterity.Name = "tbxCharDexterity";
            this.tbxCharDexterity.ReadOnly = true;
            this.tbxCharDexterity.Size = new System.Drawing.Size(65, 15);
            this.tbxCharDexterity.TabIndex = 19;
            this.tbxCharDexterity.Tag = "XC";
            this.tbxCharDexterity.Text = "DEX : 9999";
            //
            // tbxCharStrength
            //
            this.tbxCharStrength.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharStrength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharStrength.Location = new System.Drawing.Point(6, 18);
            this.tbxCharStrength.Name = "tbxCharStrength";
            this.tbxCharStrength.ReadOnly = true;
            this.tbxCharStrength.Size = new System.Drawing.Size(65, 15);
            this.tbxCharStrength.TabIndex = 18;
            this.tbxCharStrength.Tag = "XC";
            this.tbxCharStrength.Text = "STR : 9999";
            //
            // tbxCharJobNameLevel
            //
            this.tbxCharJobNameLevel.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharJobNameLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharJobNameLevel.Location = new System.Drawing.Point(78, 28);
            this.tbxCharJobNameLevel.Name = "tbxCharJobNameLevel";
            this.tbxCharJobNameLevel.ReadOnly = true;
            this.tbxCharJobNameLevel.Size = new System.Drawing.Size(173, 15);
            this.tbxCharJobNameLevel.TabIndex = 12;
            this.tbxCharJobNameLevel.Tag = "XC";
            this.tbxCharJobNameLevel.Text = "Job : classes / Level : 99";
            //
            // tbxCharName
            //
            this.tbxCharName.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharName.Location = new System.Drawing.Point(78, 11);
            this.tbxCharName.Name = "tbxCharName";
            this.tbxCharName.ReadOnly = true;
            this.tbxCharName.Size = new System.Drawing.Size(173, 15);
            this.tbxCharName.TabIndex = 11;
            this.tbxCharName.Tag = "XC";
            this.tbxCharName.Text = "Character Name";
            //
            // ptbCharJobIcon
            //
            this.ptbCharJobIcon.Location = new System.Drawing.Point(5, 8);
            this.ptbCharJobIcon.MaximumSize = new System.Drawing.Size(64, 64);
            this.ptbCharJobIcon.Name = "ptbCharJobIcon";
            this.ptbCharJobIcon.Size = new System.Drawing.Size(64, 64);
            this.ptbCharJobIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCharJobIcon.TabIndex = 10;
            this.ptbCharJobIcon.TabStop = false;
            this.ptbCharJobIcon.Tag = "XC";
            //
            // lblCharHP
            //
            this.lblCharHP.AutoSize = true;
            this.lblCharHP.Location = new System.Drawing.Point(8, 87);
            this.lblCharHP.Name = "lblCharHP";
            this.lblCharHP.Size = new System.Drawing.Size(21, 13);
            this.lblCharHP.TabIndex = 4;
            this.lblCharHP.Tag = "XC";
            this.lblCharHP.Text = "HP";
            //
            // lblCharMP_CP_GP
            //
            this.lblCharMP_CP_GP.AutoSize = true;
            this.lblCharMP_CP_GP.Location = new System.Drawing.Point(117, 87);
            this.lblCharMP_CP_GP.Name = "lblCharMP_CP_GP";
            this.lblCharMP_CP_GP.Size = new System.Drawing.Size(23, 13);
            this.lblCharMP_CP_GP.TabIndex = 6;
            this.lblCharMP_CP_GP.Tag = "XC";
            this.lblCharMP_CP_GP.Text = "MP";
            //
            // lblCharTP
            //
            this.lblCharTP.AutoSize = true;
            this.lblCharTP.Location = new System.Drawing.Point(228, 87);
            this.lblCharTP.Name = "lblCharTP";
            this.lblCharTP.Size = new System.Drawing.Size(18, 13);
            this.lblCharTP.TabIndex = 8;
            this.lblCharTP.Tag = "XC";
            this.lblCharTP.Text = "TP";
            //
            // tabRoutine
            //
            this.tabRoutine.Controls.Add(this.spcRoutineActions);
            this.tabRoutine.Controls.Add(this.panel9);
            this.tabRoutine.Controls.Add(this.lblCombatRoutineName);
            this.tabRoutine.Location = new System.Drawing.Point(4, 22);
            this.tabRoutine.Name = "tabRoutine";
            this.tabRoutine.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoutine.Size = new System.Drawing.Size(333, 310);
            this.tabRoutine.TabIndex = 2;
            this.tabRoutine.Tag = "XC";
            this.tabRoutine.Text = "Routine";
            //
            // spcRoutineActions
            //
            this.spcRoutineActions.IsSplitterFixed = true;
            this.spcRoutineActions.Location = new System.Drawing.Point(3, 37);
            this.spcRoutineActions.Name = "spcRoutineActions";
            //
            // spcRoutineActions.Panel1
            //
            this.spcRoutineActions.Panel1.Controls.Add(this.gbxOutOfCombat);
            //
            // spcRoutineActions.Panel2
            //
            this.spcRoutineActions.Panel2.Controls.Add(this.gbxCombatActions);
            this.spcRoutineActions.Size = new System.Drawing.Size(324, 233);
            this.spcRoutineActions.SplitterDistance = 160;
            this.spcRoutineActions.TabIndex = 19;
            //
            // gbxOutOfCombat
            //
            this.gbxOutOfCombat.Controls.Add(this.cbxOutOfCombatPullBuff);
            this.gbxOutOfCombat.Controls.Add(this.cbxOutOfCombatRest);
            this.gbxOutOfCombat.Controls.Add(this.cbxOutOfCombatHeal);
            this.gbxOutOfCombat.Controls.Add(this.cbxOutOfCombatBuff);
            this.gbxOutOfCombat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxOutOfCombat.Location = new System.Drawing.Point(0, 0);
            this.gbxOutOfCombat.Name = "gbxOutOfCombat";
            this.gbxOutOfCombat.Size = new System.Drawing.Size(160, 233);
            this.gbxOutOfCombat.TabIndex = 20;
            this.gbxOutOfCombat.TabStop = false;
            this.gbxOutOfCombat.Text = "Non-Combat Actions";
            //
            // cbxOutOfCombatPullBuff
            //
            this.cbxOutOfCombatPullBuff.Checked = true;
            this.cbxOutOfCombatPullBuff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxOutOfCombatPullBuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxOutOfCombatPullBuff.Location = new System.Drawing.Point(8, 90);
            this.cbxOutOfCombatPullBuff.Name = "cbxOutOfCombatPullBuff";
            this.cbxOutOfCombatPullBuff.Size = new System.Drawing.Size(67, 17);
            this.cbxOutOfCombatPullBuff.TabIndex = 17;
            this.cbxOutOfCombatPullBuff.Tag = "XC";
            this.cbxOutOfCombatPullBuff.Text = "Pull Buff";
            this.cbxOutOfCombatPullBuff.UseVisualStyleBackColor = true;
            //
            // cbxOutOfCombatRest
            //
            this.cbxOutOfCombatRest.Checked = true;
            this.cbxOutOfCombatRest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxOutOfCombatRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxOutOfCombatRest.Location = new System.Drawing.Point(8, 21);
            this.cbxOutOfCombatRest.Name = "cbxOutOfCombatRest";
            this.cbxOutOfCombatRest.Size = new System.Drawing.Size(45, 17);
            this.cbxOutOfCombatRest.TabIndex = 16;
            this.cbxOutOfCombatRest.Tag = "XC";
            this.cbxOutOfCombatRest.Text = "Rest";
            this.cbxOutOfCombatRest.UseVisualStyleBackColor = true;
            //
            // cbxOutOfCombatHeal
            //
            this.cbxOutOfCombatHeal.Checked = true;
            this.cbxOutOfCombatHeal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxOutOfCombatHeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxOutOfCombatHeal.Location = new System.Drawing.Point(8, 44);
            this.cbxOutOfCombatHeal.Name = "cbxOutOfCombatHeal";
            this.cbxOutOfCombatHeal.Size = new System.Drawing.Size(46, 17);
            this.cbxOutOfCombatHeal.TabIndex = 12;
            this.cbxOutOfCombatHeal.Tag = "XC";
            this.cbxOutOfCombatHeal.Text = "Heal";
            this.cbxOutOfCombatHeal.UseVisualStyleBackColor = true;
            //
            // cbxOutOfCombatBuff
            //
            this.cbxOutOfCombatBuff.Checked = true;
            this.cbxOutOfCombatBuff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxOutOfCombatBuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxOutOfCombatBuff.Location = new System.Drawing.Point(8, 67);
            this.cbxOutOfCombatBuff.Name = "cbxOutOfCombatBuff";
            this.cbxOutOfCombatBuff.Size = new System.Drawing.Size(108, 17);
            this.cbxOutOfCombatBuff.TabIndex = 15;
            this.cbxOutOfCombatBuff.Tag = "XC";
            this.cbxOutOfCombatBuff.Text = "Pre-Combat Buff";
            this.cbxOutOfCombatBuff.UseVisualStyleBackColor = true;
            //
            // gbxCombatActions
            //
            this.gbxCombatActions.Controls.Add(this.cbxCombatActionsCombat);
            this.gbxCombatActions.Controls.Add(this.cbxCombatActionsHeal);
            this.gbxCombatActions.Controls.Add(this.cbxCombatActionsBuff);
            this.gbxCombatActions.Controls.Add(this.cbxCombatActionsPull);
            this.gbxCombatActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxCombatActions.Location = new System.Drawing.Point(0, 0);
            this.gbxCombatActions.Name = "gbxCombatActions";
            this.gbxCombatActions.Size = new System.Drawing.Size(160, 233);
            this.gbxCombatActions.TabIndex = 19;
            this.gbxCombatActions.TabStop = false;
            this.gbxCombatActions.Text = "In Combat Actions";
            //
            // cbxCombatActionsCombat
            //
            this.cbxCombatActionsCombat.Checked = true;
            this.cbxCombatActionsCombat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxCombatActionsCombat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCombatActionsCombat.Location = new System.Drawing.Point(9, 90);
            this.cbxCombatActionsCombat.Name = "cbxCombatActionsCombat";
            this.cbxCombatActionsCombat.Size = new System.Drawing.Size(63, 17);
            this.cbxCombatActionsCombat.TabIndex = 18;
            this.cbxCombatActionsCombat.Tag = "XC";
            this.cbxCombatActionsCombat.Text = "Combat";
            this.cbxCombatActionsCombat.UseVisualStyleBackColor = true;
            //
            // cbxCombatActionsHeal
            //
            this.cbxCombatActionsHeal.Checked = true;
            this.cbxCombatActionsHeal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxCombatActionsHeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCombatActionsHeal.Location = new System.Drawing.Point(9, 44);
            this.cbxCombatActionsHeal.Name = "cbxCombatActionsHeal";
            this.cbxCombatActionsHeal.Size = new System.Drawing.Size(46, 17);
            this.cbxCombatActionsHeal.TabIndex = 16;
            this.cbxCombatActionsHeal.Tag = "XC";
            this.cbxCombatActionsHeal.Text = "Heal";
            this.cbxCombatActionsHeal.UseVisualStyleBackColor = true;
            //
            // cbxCombatActionsBuff
            //
            this.cbxCombatActionsBuff.Checked = true;
            this.cbxCombatActionsBuff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxCombatActionsBuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCombatActionsBuff.Location = new System.Drawing.Point(9, 67);
            this.cbxCombatActionsBuff.Name = "cbxCombatActionsBuff";
            this.cbxCombatActionsBuff.Size = new System.Drawing.Size(88, 17);
            this.cbxCombatActionsBuff.TabIndex = 17;
            this.cbxCombatActionsBuff.Tag = "XC";
            this.cbxCombatActionsBuff.Text = "Combat Buff";
            this.cbxCombatActionsBuff.UseVisualStyleBackColor = true;
            //
            // cbxCombatActionsPull
            //
            this.cbxCombatActionsPull.Checked = true;
            this.cbxCombatActionsPull.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxCombatActionsPull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCombatActionsPull.Location = new System.Drawing.Point(9, 21);
            this.cbxCombatActionsPull.Name = "cbxCombatActionsPull";
            this.cbxCombatActionsPull.Size = new System.Drawing.Size(42, 17);
            this.cbxCombatActionsPull.TabIndex = 11;
            this.cbxCombatActionsPull.Tag = "XC";
            this.cbxCombatActionsPull.Text = "Pull";
            this.cbxCombatActionsPull.UseVisualStyleBackColor = true;
            //
            // panel9
            //
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.cmbCombatRoutines);
            this.panel9.Location = new System.Drawing.Point(157, 8);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(170, 23);
            this.panel9.TabIndex = 22;
            //
            // cmbCombatRoutines
            //
            this.cmbCombatRoutines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCombatRoutines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCombatRoutines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCombatRoutines.FormattingEnabled = true;
            this.cmbCombatRoutines.Location = new System.Drawing.Point(0, 0);
            this.cmbCombatRoutines.Name = "cmbCombatRoutines";
            this.cmbCombatRoutines.Size = new System.Drawing.Size(168, 21);
            this.cmbCombatRoutines.TabIndex = 9;
            this.cmbCombatRoutines.Tag = "XC";
            this.cmbCombatRoutines.SelectedIndexChanged += new System.EventHandler(this.OnSelectedCombatRoutine);
            //
            // lblCombatRoutineName
            //
            this.lblCombatRoutineName.Location = new System.Drawing.Point(8, 12);
            this.lblCombatRoutineName.Name = "lblCombatRoutineName";
            this.lblCombatRoutineName.Size = new System.Drawing.Size(137, 17);
            this.lblCombatRoutineName.TabIndex = 21;
            this.lblCombatRoutineName.Tag = "XC";
            this.lblCombatRoutineName.Text = "Loaded Combat Routine";
            //
            // tabMovement
            //
            this.tabMovement.BackColor = System.Drawing.SystemColors.Control;
            this.tabMovement.Controls.Add(this.cbxAutoFace);
            this.tabMovement.Controls.Add(this.lblDistanceYalms);
            this.tabMovement.Controls.Add(this.gbxMoveInRange);
            this.tabMovement.Controls.Add(this.panel8);
            this.tabMovement.Controls.Add(this.lblNavigationProvider);
            this.tabMovement.Location = new System.Drawing.Point(4, 22);
            this.tabMovement.Name = "tabMovement";
            this.tabMovement.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovement.Size = new System.Drawing.Size(333, 310);
            this.tabMovement.TabIndex = 3;
            this.tabMovement.Tag = "XC";
            this.tabMovement.Text = "Movement";
            //
            // cbxAutoFace
            //
            this.cbxAutoFace.Checked = true;
            this.cbxAutoFace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAutoFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAutoFace.Location = new System.Drawing.Point(10, 36);
            this.cbxAutoFace.Name = "cbxAutoFace";
            this.cbxAutoFace.Size = new System.Drawing.Size(109, 17);
            this.cbxAutoFace.TabIndex = 45;
            this.cbxAutoFace.Tag = "XC";
            this.cbxAutoFace.Text = "Auto Face Target";
            this.cbxAutoFace.UseVisualStyleBackColor = true;
			this.cbxAutoFace.CheckedChanged += new System.EventHandler(this.OnCheckedAutoFace);
            //
            // lblDistanceYalms
            //
            this.lblDistanceYalms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDistanceYalms.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanceYalms.Location = new System.Drawing.Point(4, 295);
            this.lblDistanceYalms.Name = "lblDistanceYalms";
            this.lblDistanceYalms.Size = new System.Drawing.Size(324, 12);
            this.lblDistanceYalms.TabIndex = 44;
            this.lblDistanceYalms.Text = "*All distances are measured in Yalms";
            //
            // gbxMoveInRange
            //
            this.gbxMoveInRange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxMoveInRange.Controls.Add(this.panel7);
            this.gbxMoveInRange.Controls.Add(this.lblTargetingDistanceYalms);
            this.gbxMoveInRange.Controls.Add(this.lblTargetingDistance);
            this.gbxMoveInRange.Controls.Add(this.lblTargetingMode);
            this.gbxMoveInRange.Controls.Add(this.numTargetingDistance);
            this.gbxMoveInRange.Controls.Add(this.lblMoveWithinFollow);
            this.gbxMoveInRange.Controls.Add(this.cbxAutoMoveTarget);
            this.gbxMoveInRange.Controls.Add(this.numMaxMoveDistanceTank);
            this.gbxMoveInRange.Controls.Add(this.panel1);
            this.gbxMoveInRange.Controls.Add(this.lblOfFollowTarget);
            this.gbxMoveInRange.Controls.Add(this.lblMovementMode);
            this.gbxMoveInRange.Controls.Add(this.lblWhen);
            this.gbxMoveInRange.Controls.Add(this.numMinMoveDistanceTank);
            this.gbxMoveInRange.Location = new System.Drawing.Point(3, 59);
            this.gbxMoveInRange.Name = "gbxMoveInRange";
            this.gbxMoveInRange.Size = new System.Drawing.Size(324, 233);
            this.gbxMoveInRange.TabIndex = 38;
            this.gbxMoveInRange.TabStop = false;
            this.gbxMoveInRange.Text = "Move In Range";
            //
            // panel7
            //
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.cmbTargetingMode);
            this.panel7.Location = new System.Drawing.Point(113, 111);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(204, 23);
            this.panel7.TabIndex = 41;
            //
            // cmbTargetingMode
            //
            this.cmbTargetingMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTargetingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetingMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTargetingMode.FormattingEnabled = true;
            this.cmbTargetingMode.Location = new System.Drawing.Point(0, 0);
            this.cmbTargetingMode.Name = "cmbTargetingMode";
            this.cmbTargetingMode.Size = new System.Drawing.Size(202, 21);
            this.cmbTargetingMode.TabIndex = 9;
            this.cmbTargetingMode.Tag = "XC";
            //
            // lblTargetingDistanceYalms
            //
            this.lblTargetingDistanceYalms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTargetingDistanceYalms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTargetingDistanceYalms.Location = new System.Drawing.Point(179, 142);
            this.lblTargetingDistanceYalms.Name = "lblTargetingDistanceYalms";
            this.lblTargetingDistanceYalms.Size = new System.Drawing.Size(34, 17);
            this.lblTargetingDistanceYalms.TabIndex = 40;
            this.lblTargetingDistanceYalms.Tag = "XC";
            this.lblTargetingDistanceYalms.Text = "Yalms";
            //
            // lblTargetingDistance
            //
            this.lblTargetingDistance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTargetingDistance.Location = new System.Drawing.Point(5, 142);
            this.lblTargetingDistance.Name = "lblTargetingDistance";
            this.lblTargetingDistance.Size = new System.Drawing.Size(102, 17);
            this.lblTargetingDistance.TabIndex = 38;
            this.lblTargetingDistance.Tag = "XC";
            this.lblTargetingDistance.Text = "Targeting Distance";
            //
            // lblTargetingMode
            //
            this.lblTargetingMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTargetingMode.Location = new System.Drawing.Point(5, 115);
            this.lblTargetingMode.Name = "lblTargetingMode";
            this.lblTargetingMode.Size = new System.Drawing.Size(93, 17);
            this.lblTargetingMode.TabIndex = 37;
            this.lblTargetingMode.Tag = "XC";
            this.lblTargetingMode.Text = "Targeting Mode";
            //
            // numTargetingDistance
            //
            this.numTargetingDistance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numTargetingDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTargetingDistance.DecimalPlaces = 1;
            this.numTargetingDistance.Location = new System.Drawing.Point(113, 139);
            this.numTargetingDistance.Name = "numTargetingDistance";
            this.numTargetingDistance.Size = new System.Drawing.Size(60, 22);
            this.numTargetingDistance.TabIndex = 39;
            this.numTargetingDistance.Tag = "XC";
            this.numTargetingDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // lblMoveWithinFollow
            //
            this.lblMoveWithinFollow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMoveWithinFollow.Location = new System.Drawing.Point(63, 50);
            this.lblMoveWithinFollow.Name = "lblMoveWithinFollow";
            this.lblMoveWithinFollow.Size = new System.Drawing.Size(75, 17);
            this.lblMoveWithinFollow.TabIndex = 36;
            this.lblMoveWithinFollow.Tag = "XC";
            this.lblMoveWithinFollow.Text = "Move Within";
            //
            // cbxAutoMoveTarget
            //
            this.cbxAutoMoveTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAutoMoveTarget.Location = new System.Drawing.Point(7, 21);
            this.cbxAutoMoveTarget.Name = "cbxAutoMoveTarget";
            this.cbxAutoMoveTarget.Size = new System.Drawing.Size(132, 17);
            this.cbxAutoMoveTarget.TabIndex = 28;
            this.cbxAutoMoveTarget.Tag = "XC";
            this.cbxAutoMoveTarget.Text = "Auto Move To Target*";
            this.cbxAutoMoveTarget.UseVisualStyleBackColor = true;
            //
            // numMaxMoveDistanceTank
            //
            this.numMaxMoveDistanceTank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numMaxMoveDistanceTank.DecimalPlaces = 1;
            this.numMaxMoveDistanceTank.Location = new System.Drawing.Point(145, 76);
            this.numMaxMoveDistanceTank.Name = "numMaxMoveDistanceTank";
            this.numMaxMoveDistanceTank.Size = new System.Drawing.Size(60, 22);
            this.numMaxMoveDistanceTank.TabIndex = 32;
            this.numMaxMoveDistanceTank.Tag = "XC";
            this.numMaxMoveDistanceTank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // panel1
            //
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbMovementMode);
            this.panel1.Location = new System.Drawing.Point(113, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 23);
            this.panel1.TabIndex = 35;
            //
            // cmbMovementMode
            //
            this.cmbMovementMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbMovementMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMovementMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMovementMode.FormattingEnabled = true;
            this.cmbMovementMode.Location = new System.Drawing.Point(0, 0);
            this.cmbMovementMode.Name = "cmbMovementMode";
            this.cmbMovementMode.Size = new System.Drawing.Size(203, 21);
            this.cmbMovementMode.TabIndex = 16;
            this.cmbMovementMode.Tag = "XC";
            //
            // lblOfFollowTarget
            //
            this.lblOfFollowTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOfFollowTarget.Location = new System.Drawing.Point(211, 50);
            this.lblOfFollowTarget.Name = "lblOfFollowTarget";
            this.lblOfFollowTarget.Size = new System.Drawing.Size(90, 17);
            this.lblOfFollowTarget.TabIndex = 30;
            this.lblOfFollowTarget.Tag = "XC";
            this.lblOfFollowTarget.Text = "of Follow Target";
            //
            // lblMovementMode
            //
            this.lblMovementMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMovementMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMovementMode.Location = new System.Drawing.Point(5, 203);
            this.lblMovementMode.Name = "lblMovementMode";
            this.lblMovementMode.Size = new System.Drawing.Size(94, 17);
            this.lblMovementMode.TabIndex = 31;
            this.lblMovementMode.Tag = "XC";
            this.lblMovementMode.Text = "Movement Mode";
            //
            // lblWhen
            //
            this.lblWhen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWhen.Location = new System.Drawing.Point(73, 78);
            this.lblWhen.Name = "lblWhen";
            this.lblWhen.Size = new System.Drawing.Size(65, 17);
            this.lblWhen.TabIndex = 34;
            this.lblWhen.Tag = "XC";
            this.lblWhen.Text = "When over";
            //
            // numMinMoveDistanceTank
            //
            this.numMinMoveDistanceTank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numMinMoveDistanceTank.DecimalPlaces = 1;
            this.numMinMoveDistanceTank.Location = new System.Drawing.Point(145, 48);
            this.numMinMoveDistanceTank.Name = "numMinMoveDistanceTank";
            this.numMinMoveDistanceTank.Size = new System.Drawing.Size(60, 22);
            this.numMinMoveDistanceTank.TabIndex = 29;
            this.numMinMoveDistanceTank.Tag = "XC";
            this.numMinMoveDistanceTank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // panel8
            //
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.cmbNavigationProvider);
            this.panel8.Location = new System.Drawing.Point(122, 8);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(205, 23);
            this.panel8.TabIndex = 37;
            //
            // cmbNavigationProvider
            //
            this.cmbNavigationProvider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbNavigationProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNavigationProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNavigationProvider.FormattingEnabled = true;
            this.cmbNavigationProvider.Location = new System.Drawing.Point(0, 0);
            this.cmbNavigationProvider.Name = "cmbNavigationProvider";
            this.cmbNavigationProvider.Size = new System.Drawing.Size(203, 21);
            this.cmbNavigationProvider.TabIndex = 24;
            this.cmbNavigationProvider.SelectedIndexChanged += new System.EventHandler(this.OnSelectedNavigationProvider);
            //
            // lblNavigationProvider
            //
            this.lblNavigationProvider.Location = new System.Drawing.Point(8, 12);
            this.lblNavigationProvider.Name = "lblNavigationProvider";
            this.lblNavigationProvider.Size = new System.Drawing.Size(108, 17);
            this.lblNavigationProvider.TabIndex = 36;
            this.lblNavigationProvider.Text = "Navigation Provider";
            //
            // tabHotkeys
            //
            this.tabHotkeys.Controls.Add(this.cbxEnableHotkeyMovementMode);
            this.tabHotkeys.Controls.Add(this.cbxEnableHotkeyToogleMovement);
            this.tabHotkeys.Controls.Add(this.cbxEnableHotkeyTargetMode);
            this.tabHotkeys.Controls.Add(this.cbxEnableHotkeyUnPause);
            this.tabHotkeys.Controls.Add(this.panel10);
            this.tabHotkeys.Controls.Add(this.lblHotkeyMoveMode);
            this.tabHotkeys.Controls.Add(this.panel5);
            this.tabHotkeys.Controls.Add(this.panel4);
            this.tabHotkeys.Controls.Add(this.panel3);
            this.tabHotkeys.Controls.Add(this.lblHotkeyMovement);
            this.tabHotkeys.Controls.Add(this.lblHotkeyTargetMode);
            this.tabHotkeys.Controls.Add(this.lblHotkeyPause);
            this.tabHotkeys.Controls.Add(this.tbxHotkeyMovementMode);
            this.tabHotkeys.Controls.Add(this.tbxHotkeyToogleMovement);
            this.tabHotkeys.Controls.Add(this.tbxHotkeyTargetMode);
            this.tabHotkeys.Controls.Add(this.tbxHotkeyPause);
            this.tabHotkeys.Location = new System.Drawing.Point(4, 22);
            this.tabHotkeys.Name = "tabHotkeys";
            this.tabHotkeys.Padding = new System.Windows.Forms.Padding(3);
            this.tabHotkeys.Size = new System.Drawing.Size(333, 310);
            this.tabHotkeys.TabIndex = 1;
            this.tabHotkeys.Tag = "XC";
            this.tabHotkeys.Text = "Hotkeys";
            //
            // cbxEnableHotkeyMovementMode
            //
            this.cbxEnableHotkeyMovementMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEnableHotkeyMovementMode.Location = new System.Drawing.Point(10, 168);
            this.cbxEnableHotkeyMovementMode.Name = "cbxEnableHotkeyMovementMode";
            this.cbxEnableHotkeyMovementMode.Size = new System.Drawing.Size(15, 17);
            this.cbxEnableHotkeyMovementMode.TabIndex = 28;
            this.cbxEnableHotkeyMovementMode.Tag = "XC";
            this.cbxEnableHotkeyMovementMode.UseVisualStyleBackColor = true;
            this.cbxEnableHotkeyMovementMode.CheckedChanged += new System.EventHandler(this.OnCheckedEnableHotkeyMovementMode);
            //
            // cbxEnableHotkeyToogleMovement
            //
            this.cbxEnableHotkeyToogleMovement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEnableHotkeyToogleMovement.Location = new System.Drawing.Point(10, 122);
            this.cbxEnableHotkeyToogleMovement.Name = "cbxEnableHotkeyToogleMovement";
            this.cbxEnableHotkeyToogleMovement.Size = new System.Drawing.Size(15, 17);
            this.cbxEnableHotkeyToogleMovement.TabIndex = 26;
            this.cbxEnableHotkeyToogleMovement.Tag = "XC";
            this.cbxEnableHotkeyToogleMovement.UseVisualStyleBackColor = true;
            this.cbxEnableHotkeyToogleMovement.CheckedChanged += new System.EventHandler(this.OnCheckedEnableToogleMovement);
            //
            // cbxEnableHotkeyTargetMode
            //
            this.cbxEnableHotkeyTargetMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEnableHotkeyTargetMode.Location = new System.Drawing.Point(10, 77);
            this.cbxEnableHotkeyTargetMode.Name = "cbxEnableHotkeyTargetMode";
            this.cbxEnableHotkeyTargetMode.Size = new System.Drawing.Size(15, 17);
            this.cbxEnableHotkeyTargetMode.TabIndex = 25;
            this.cbxEnableHotkeyTargetMode.Tag = "XC";
            this.cbxEnableHotkeyTargetMode.UseVisualStyleBackColor = true;
            this.cbxEnableHotkeyTargetMode.CheckedChanged += new System.EventHandler(this.OnCheckedEnableHotkeyTargetMode);
            //
            // cbxEnableHotkeyUnPause
            //
            this.cbxEnableHotkeyUnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEnableHotkeyUnPause.Location = new System.Drawing.Point(10, 29);
            this.cbxEnableHotkeyUnPause.Name = "cbxEnableHotkeyUnPause";
            this.cbxEnableHotkeyUnPause.Size = new System.Drawing.Size(15, 17);
            this.cbxEnableHotkeyUnPause.TabIndex = 24;
            this.cbxEnableHotkeyUnPause.Tag = "XC";
            this.cbxEnableHotkeyUnPause.UseVisualStyleBackColor = true;
            this.cbxEnableHotkeyUnPause.CheckedChanged += new System.EventHandler(this.OnCheckedEnableHotkeyUnPause);
            //
            // panel10
            //
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.cmbHotkeyModifierMovementMode);
            this.panel10.Location = new System.Drawing.Point(31, 165);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(217, 23);
            this.panel10.TabIndex = 23;
            //
            // cmbHotkeyModifierMovementMode
            //
            this.cmbHotkeyModifierMovementMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbHotkeyModifierMovementMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHotkeyModifierMovementMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHotkeyModifierMovementMode.FormattingEnabled = true;
            this.cmbHotkeyModifierMovementMode.Location = new System.Drawing.Point(0, 0);
            this.cmbHotkeyModifierMovementMode.Name = "cmbHotkeyModifierMovementMode";
            this.cmbHotkeyModifierMovementMode.Size = new System.Drawing.Size(215, 21);
            this.cmbHotkeyModifierMovementMode.TabIndex = 15;
            this.cmbHotkeyModifierMovementMode.Tag = "XC";
            //
            // lblHotkeyMoveMode
            //
            this.lblHotkeyMoveMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHotkeyMoveMode.Location = new System.Drawing.Point(6, 146);
            this.lblHotkeyMoveMode.Name = "lblHotkeyMoveMode";
            this.lblHotkeyMoveMode.Size = new System.Drawing.Size(131, 17);
            this.lblHotkeyMoveMode.TabIndex = 21;
            this.lblHotkeyMoveMode.Tag = "XC";
            this.lblHotkeyMoveMode.Text = "Toggle Movement Mode";
            //
            // panel5
            //
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.cmbHotkeyModifierPause);
            this.panel5.Location = new System.Drawing.Point(31, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(217, 23);
            this.panel5.TabIndex = 20;
            //
            // cmbHotkeyModifierPause
            //
            this.cmbHotkeyModifierPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbHotkeyModifierPause.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHotkeyModifierPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHotkeyModifierPause.FormattingEnabled = true;
            this.cmbHotkeyModifierPause.Location = new System.Drawing.Point(0, 0);
            this.cmbHotkeyModifierPause.Name = "cmbHotkeyModifierPause";
            this.cmbHotkeyModifierPause.Size = new System.Drawing.Size(215, 21);
            this.cmbHotkeyModifierPause.TabIndex = 1;
            this.cmbHotkeyModifierPause.Tag = "XC";
            //
            // panel4
            //
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cmbHotkeyModifierTargetMode);
            this.panel4.Location = new System.Drawing.Point(31, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(217, 23);
            this.panel4.TabIndex = 19;
            //
            // cmbHotkeyModifierTargetMode
            //
            this.cmbHotkeyModifierTargetMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbHotkeyModifierTargetMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHotkeyModifierTargetMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHotkeyModifierTargetMode.FormattingEnabled = true;
            this.cmbHotkeyModifierTargetMode.Location = new System.Drawing.Point(0, 0);
            this.cmbHotkeyModifierTargetMode.Name = "cmbHotkeyModifierTargetMode";
            this.cmbHotkeyModifierTargetMode.Size = new System.Drawing.Size(215, 21);
            this.cmbHotkeyModifierTargetMode.TabIndex = 4;
            this.cmbHotkeyModifierTargetMode.Tag = "XC";
            //
            // panel3
            //
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cmbHotkeyModifierToogleMovement);
            this.panel3.Location = new System.Drawing.Point(31, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 23);
            this.panel3.TabIndex = 18;
            //
            // cmbHotkeyModifierToogleMovement
            //
            this.cmbHotkeyModifierToogleMovement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbHotkeyModifierToogleMovement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHotkeyModifierToogleMovement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHotkeyModifierToogleMovement.FormattingEnabled = true;
            this.cmbHotkeyModifierToogleMovement.Location = new System.Drawing.Point(0, 0);
            this.cmbHotkeyModifierToogleMovement.Name = "cmbHotkeyModifierToogleMovement";
            this.cmbHotkeyModifierToogleMovement.Size = new System.Drawing.Size(215, 21);
            this.cmbHotkeyModifierToogleMovement.TabIndex = 9;
            this.cmbHotkeyModifierToogleMovement.Tag = "XC";
            //
            // lblHotkeyMovement
            //
            this.lblHotkeyMovement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHotkeyMovement.Location = new System.Drawing.Point(7, 100);
            this.lblHotkeyMovement.Name = "lblHotkeyMovement";
            this.lblHotkeyMovement.Size = new System.Drawing.Size(98, 17);
            this.lblHotkeyMovement.TabIndex = 8;
            this.lblHotkeyMovement.Tag = "XC";
            this.lblHotkeyMovement.Text = "Toggle Movement";
            //
            // lblHotkeyTargetMode
            //
            this.lblHotkeyTargetMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHotkeyTargetMode.Location = new System.Drawing.Point(6, 54);
            this.lblHotkeyTargetMode.Name = "lblHotkeyTargetMode";
            this.lblHotkeyTargetMode.Size = new System.Drawing.Size(108, 17);
            this.lblHotkeyTargetMode.TabIndex = 3;
            this.lblHotkeyTargetMode.Tag = "XC";
            this.lblHotkeyTargetMode.Text = "Toggle Target Mode";
            //
            // lblHotkeyPause
            //
            this.lblHotkeyPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHotkeyPause.Location = new System.Drawing.Point(6, 7);
            this.lblHotkeyPause.Name = "lblHotkeyPause";
            this.lblHotkeyPause.Size = new System.Drawing.Size(152, 17);
            this.lblHotkeyPause.TabIndex = 0;
            this.lblHotkeyPause.Tag = "XC";
            this.lblHotkeyPause.Text = "Pause / Unpause Mud Assist";
            //
            // tbxHotkeyMovementMode
            //
            this.tbxHotkeyMovementMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHotkeyMovementMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHotkeyMovementMode.Location = new System.Drawing.Point(254, 165);
            this.tbxHotkeyMovementMode.Name = "tbxHotkeyMovementMode";
            this.tbxHotkeyMovementMode.Size = new System.Drawing.Size(71, 22);
            this.tbxHotkeyMovementMode.TabIndex = 22;
            this.tbxHotkeyMovementMode.Tag = "XC";
            this.tbxHotkeyMovementMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // tbxHotkeyToogleMovement
            //
            this.tbxHotkeyToogleMovement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHotkeyToogleMovement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHotkeyToogleMovement.Location = new System.Drawing.Point(254, 119);
            this.tbxHotkeyToogleMovement.Name = "tbxHotkeyToogleMovement";
            this.tbxHotkeyToogleMovement.Size = new System.Drawing.Size(71, 22);
            this.tbxHotkeyToogleMovement.TabIndex = 10;
            this.tbxHotkeyToogleMovement.Tag = "XC";
            this.tbxHotkeyToogleMovement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // tbxHotkeyTargetMode
            //
            this.tbxHotkeyTargetMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHotkeyTargetMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHotkeyTargetMode.Location = new System.Drawing.Point(254, 73);
            this.tbxHotkeyTargetMode.Name = "tbxHotkeyTargetMode";
            this.tbxHotkeyTargetMode.Size = new System.Drawing.Size(71, 22);
            this.tbxHotkeyTargetMode.TabIndex = 5;
            this.tbxHotkeyTargetMode.Tag = "XC";
            this.tbxHotkeyTargetMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // tbxHotkeyPause
            //
            this.tbxHotkeyPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHotkeyPause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHotkeyPause.Location = new System.Drawing.Point(254, 26);
            this.tbxHotkeyPause.Name = "tbxHotkeyPause";
            this.tbxHotkeyPause.Size = new System.Drawing.Size(71, 22);
            this.tbxHotkeyPause.TabIndex = 2;
            this.tbxHotkeyPause.Tag = "XC";
            this.tbxHotkeyPause.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // tabMisc
            //
            this.tabMisc.Controls.Add(this.label1);
            this.tabMisc.Controls.Add(this.gbxSprint);
            this.tabMisc.Controls.Add(this.gbxGeneralSettings);
            this.tabMisc.Controls.Add(this.gbxHotkeyMessages);
            this.tabMisc.Controls.Add(this.gbxQuesting);
            this.tabMisc.Location = new System.Drawing.Point(4, 22);
            this.tabMisc.Name = "tabMisc";
            this.tabMisc.Size = new System.Drawing.Size(333, 310);
            this.tabMisc.TabIndex = 0;
            this.tabMisc.Tag = "XC";
            this.tabMisc.Text = "Misc";
            //
            // label1
            //
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 12);
            this.label1.TabIndex = 45;
            this.label1.Text = "*Quests with selectable rewards need to be completed manually";
            //
            // gbxSprint
            //
            this.gbxSprint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSprint.Controls.Add(this.cbxSprintInInstance);
            this.gbxSprint.Controls.Add(this.cbxSprintInCombat);
            this.gbxSprint.Controls.Add(this.cbxSprintOutOfCombat);
            this.gbxSprint.Location = new System.Drawing.Point(4, 127);
            this.gbxSprint.Name = "gbxSprint";
            this.gbxSprint.Size = new System.Drawing.Size(325, 65);
            this.gbxSprint.TabIndex = 26;
            this.gbxSprint.TabStop = false;
            this.gbxSprint.Text = "Sprint";
            //
            // cbxSprintInInstance
            //
            this.cbxSprintInInstance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSprintInInstance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSprintInInstance.Location = new System.Drawing.Point(7, 42);
            this.cbxSprintInInstance.Name = "cbxSprintInInstance";
            this.cbxSprintInInstance.Size = new System.Drawing.Size(133, 17);
            this.cbxSprintInInstance.TabIndex = 25;
            this.cbxSprintInInstance.Tag = "XC";
            this.cbxSprintInInstance.Text = "Sprint In Instance";
            this.cbxSprintInInstance.UseVisualStyleBackColor = true;
            //
            // cbxSprintInCombat
            //
            this.cbxSprintInCombat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSprintInCombat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSprintInCombat.Location = new System.Drawing.Point(178, 19);
            this.cbxSprintInCombat.Name = "cbxSprintInCombat";
            this.cbxSprintInCombat.Size = new System.Drawing.Size(133, 17);
            this.cbxSprintInCombat.TabIndex = 24;
            this.cbxSprintInCombat.Tag = "XC";
            this.cbxSprintInCombat.Text = "Sprint In Combat";
            this.cbxSprintInCombat.UseVisualStyleBackColor = true;
            //
            // cbxSprintOutOfCombat
            //
            this.cbxSprintOutOfCombat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSprintOutOfCombat.Checked = true;
            this.cbxSprintOutOfCombat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxSprintOutOfCombat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSprintOutOfCombat.Location = new System.Drawing.Point(7, 19);
            this.cbxSprintOutOfCombat.Name = "cbxSprintOutOfCombat";
            this.cbxSprintOutOfCombat.Size = new System.Drawing.Size(136, 17);
            this.cbxSprintOutOfCombat.TabIndex = 18;
            this.cbxSprintOutOfCombat.Tag = "XC";
            this.cbxSprintOutOfCombat.Text = "Sprint Out of Combat";
            this.cbxSprintOutOfCombat.UseVisualStyleBackColor = true;
            //
            // gbxGeneralSettings
            //
            this.gbxGeneralSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxGeneralSettings.Controls.Add(this.cbxPaused);
            this.gbxGeneralSettings.Controls.Add(this.cbxExecuteWhileMoving);
            this.gbxGeneralSettings.Controls.Add(this.cbxAlwaysOnTop);
            this.gbxGeneralSettings.Location = new System.Drawing.Point(4, 3);
            this.gbxGeneralSettings.Name = "gbxGeneralSettings";
            this.gbxGeneralSettings.Size = new System.Drawing.Size(325, 65);
            this.gbxGeneralSettings.TabIndex = 26;
            this.gbxGeneralSettings.TabStop = false;
            this.gbxGeneralSettings.Text = "General Settings";
            //
            // cbxPaused
            //
            this.cbxPaused.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPaused.Location = new System.Drawing.Point(7, 19);
            this.cbxPaused.Name = "cbxPaused";
            this.cbxPaused.Size = new System.Drawing.Size(110, 17);
            this.cbxPaused.TabIndex = 0;
            this.cbxPaused.Tag = "XC";
            this.cbxPaused.Text = "Pause All Actions";
            this.cbxPaused.UseVisualStyleBackColor = true;
            //
            // cbxExecuteWhileMoving
            //
            this.cbxExecuteWhileMoving.Checked = true;
            this.cbxExecuteWhileMoving.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxExecuteWhileMoving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxExecuteWhileMoving.Location = new System.Drawing.Point(7, 42);
            this.cbxExecuteWhileMoving.Name = "cbxExecuteWhileMoving";
            this.cbxExecuteWhileMoving.Size = new System.Drawing.Size(137, 17);
            this.cbxExecuteWhileMoving.TabIndex = 11;
            this.cbxExecuteWhileMoving.Tag = "XC";
            this.cbxExecuteWhileMoving.Text = "Execute While Moving";
            this.cbxExecuteWhileMoving.UseVisualStyleBackColor = true;
            //
            // cbxAlwaysOnTop
            //
            this.cbxAlwaysOnTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAlwaysOnTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAlwaysOnTop.Location = new System.Drawing.Point(178, 19);
            this.cbxAlwaysOnTop.Name = "cbxAlwaysOnTop";
            this.cbxAlwaysOnTop.Size = new System.Drawing.Size(98, 17);
            this.cbxAlwaysOnTop.TabIndex = 19;
            this.cbxAlwaysOnTop.Tag = "XC";
            this.cbxAlwaysOnTop.Text = "Always On Top";
            this.cbxAlwaysOnTop.UseVisualStyleBackColor = true;
            //
            // gbxHotkeyMessages
            //
            this.gbxHotkeyMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxHotkeyMessages.Controls.Add(this.cbxEnableOverlay);
            this.gbxHotkeyMessages.Location = new System.Drawing.Point(4, 74);
            this.gbxHotkeyMessages.Name = "gbxHotkeyMessages";
            this.gbxHotkeyMessages.Size = new System.Drawing.Size(325, 47);
            this.gbxHotkeyMessages.TabIndex = 25;
            this.gbxHotkeyMessages.TabStop = false;
            this.gbxHotkeyMessages.Text = "Overlay";
            //
            // cbxEnableOverlay
            //
            this.cbxEnableOverlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxEnableOverlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEnableOverlay.Location = new System.Drawing.Point(7, 19);
            this.cbxEnableOverlay.Name = "cbxEnableOverlay";
            this.cbxEnableOverlay.Size = new System.Drawing.Size(101, 17);
            this.cbxEnableOverlay.TabIndex = 23;
            this.cbxEnableOverlay.Tag = "XC";
            this.cbxEnableOverlay.Text = "Enable Overlay";
            this.cbxEnableOverlay.UseVisualStyleBackColor = true;
            //
            // gbxQuesting
            //
            this.gbxQuesting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxQuesting.Controls.Add(this.cbxAutoCompleteQuests);
            this.gbxQuesting.Controls.Add(this.cbxAutoSkipCutscenes);
            this.gbxQuesting.Controls.Add(this.cbxAutoTalkToNPCs);
            this.gbxQuesting.Controls.Add(this.cbxAutoAcceptQuests);
            this.gbxQuesting.Location = new System.Drawing.Point(4, 198);
            this.gbxQuesting.Name = "gbxQuesting";
            this.gbxQuesting.Size = new System.Drawing.Size(325, 94);
            this.gbxQuesting.TabIndex = 22;
            this.gbxQuesting.TabStop = false;
            this.gbxQuesting.Text = "Questing";
            //
            // cbxAutoCompleteQuests
            //
            this.cbxAutoCompleteQuests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAutoCompleteQuests.Enabled = false;
            this.cbxAutoCompleteQuests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAutoCompleteQuests.Location = new System.Drawing.Point(178, 42);
            this.cbxAutoCompleteQuests.Name = "cbxAutoCompleteQuests";
            this.cbxAutoCompleteQuests.Size = new System.Drawing.Size(143, 17);
            this.cbxAutoCompleteQuests.TabIndex = 23;
            this.cbxAutoCompleteQuests.Tag = "XC";
            this.cbxAutoCompleteQuests.Text = "Auto Complete Quests*";
            this.cbxAutoCompleteQuests.UseVisualStyleBackColor = true;
            //
            // cbxAutoSkipCutscenes
            //
            this.cbxAutoSkipCutscenes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAutoSkipCutscenes.Checked = true;
            this.cbxAutoSkipCutscenes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAutoSkipCutscenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAutoSkipCutscenes.Location = new System.Drawing.Point(7, 42);
            this.cbxAutoSkipCutscenes.Name = "cbxAutoSkipCutscenes";
            this.cbxAutoSkipCutscenes.Size = new System.Drawing.Size(131, 17);
            this.cbxAutoSkipCutscenes.TabIndex = 22;
            this.cbxAutoSkipCutscenes.Tag = "XC";
            this.cbxAutoSkipCutscenes.Text = "Auto Skip Cutscenes";
            this.cbxAutoSkipCutscenes.UseVisualStyleBackColor = true;
            //
            // cbxAutoTalkToNPCs
            //
            this.cbxAutoTalkToNPCs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAutoTalkToNPCs.Checked = true;
            this.cbxAutoTalkToNPCs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAutoTalkToNPCs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAutoTalkToNPCs.Location = new System.Drawing.Point(7, 19);
            this.cbxAutoTalkToNPCs.Name = "cbxAutoTalkToNPCs";
            this.cbxAutoTalkToNPCs.Size = new System.Drawing.Size(137, 17);
            this.cbxAutoTalkToNPCs.TabIndex = 20;
            this.cbxAutoTalkToNPCs.Tag = "XC";
            this.cbxAutoTalkToNPCs.Text = "Auto Talk to NPCs";
            this.cbxAutoTalkToNPCs.UseVisualStyleBackColor = true;
            //
            // cbxAutoAcceptQuests
            //
            this.cbxAutoAcceptQuests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAutoAcceptQuests.Checked = true;
            this.cbxAutoAcceptQuests.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAutoAcceptQuests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAutoAcceptQuests.Location = new System.Drawing.Point(178, 19);
            this.cbxAutoAcceptQuests.Name = "cbxAutoAcceptQuests";
            this.cbxAutoAcceptQuests.Size = new System.Drawing.Size(124, 17);
            this.cbxAutoAcceptQuests.TabIndex = 21;
            this.cbxAutoAcceptQuests.Tag = "XC";
            this.cbxAutoAcceptQuests.Text = "Auto Accept Quests";
            this.cbxAutoAcceptQuests.UseVisualStyleBackColor = true;
            //
            // SettingsForm
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(341, 358);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.stpStatus);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(357, 397);
            this.Name = "SettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "XC";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.MudSettingsForm_Load);
            this.stpStatus.ResumeLayout(false);
            this.stpStatus.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabCharInfo.ResumeLayout(false);
            this.gbxCharInfo.ResumeLayout(false);
            this.gbxCharInfo.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.gbxCharRole.ResumeLayout(false);
            this.gbxCharRole.PerformLayout();
            this.gbxCharExtra.ResumeLayout(false);
            this.gbxCharExtra.PerformLayout();
            this.gbxCharPhysical.ResumeLayout(false);
            this.gbxCharPhysical.PerformLayout();
            this.gbxElementalResistances.ResumeLayout(false);
            this.gbxElementalResistances.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCharLightningResistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCharEarthResistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCharWaterResistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCharWindResistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCharIceResistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCharFireResistance)).EndInit();
            this.gbxCharDefensive.ResumeLayout(false);
            this.gbxCharDefensive.PerformLayout();
            this.gbxCharOffensive.ResumeLayout(false);
            this.gbxCharOffensive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCharGrandCompany)).EndInit();
            this.gbxCharAttributes.ResumeLayout(false);
            this.gbxCharAttributes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCharJobIcon)).EndInit();
            this.tabRoutine.ResumeLayout(false);
            this.spcRoutineActions.Panel1.ResumeLayout(false);
            this.spcRoutineActions.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcRoutineActions)).EndInit();
            this.spcRoutineActions.ResumeLayout(false);
            this.gbxOutOfCombat.ResumeLayout(false);
            this.gbxCombatActions.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.tabMovement.ResumeLayout(false);
            this.gbxMoveInRange.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTargetingDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMoveDistanceTank)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numMinMoveDistanceTank)).EndInit();
            this.panel8.ResumeLayout(false);
            this.tabHotkeys.ResumeLayout(false);
            this.tabHotkeys.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabMisc.ResumeLayout(false);
            this.gbxSprint.ResumeLayout(false);
            this.gbxGeneralSettings.ResumeLayout(false);
            this.gbxHotkeyMessages.ResumeLayout(false);
            this.gbxQuesting.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private StatusStrip stpStatus;
		private ToolStripStatusLabel tspPauseStatus;
		private ToolStripStatusLabel tspMovementStatus;
		private ToolStripStatusLabel tspFollowModeStatus;
		private ToolStripStatusLabel tspTargetModeStatus;
		private TabControl tabControlMain;
		private TabPage tabCharInfo;
		private GroupBox gbxCharInfo;
		private Panel panel11;
		private ComboBox cmbSecondsBetweenUpdate;
		private Label label2;
		private GroupBox gbxCharRole;
		private TextBox tbxCharPiety;
		private TextBox tbxCharTenacity;
		private GroupBox gbxCharExtra;
		private TextBox tbxCharSpellSpeed;
		private TextBox tbxCharAttackMagicPotency;
		private TextBox tbxCharHealingMagicPotency;
		private GroupBox gbxCharPhysical;
		private TextBox tbxCharSkillSpeed;
		private TextBox tbxCharAttackPower;
		private GroupBox gbxElementalResistances;
		private PictureBox ptbCharLightningResistance;
		private PictureBox ptbCharEarthResistance;
		private PictureBox ptbCharWaterResistance;
		private PictureBox ptbCharWindResistance;
		private PictureBox ptbCharIceResistance;
		private PictureBox ptbCharFireResistance;
		private TextBox tbxCharWaterResistance;
		private TextBox tbxCharLightningResistance;
		private TextBox tbxCharEarthResistance;
		private TextBox tbxCharWindResistance;
		private TextBox tbxCharIceResistance;
		private TextBox tbxCharFireResistance;
		private GroupBox gbxCharDefensive;
		private TextBox tbxCharDefense;
		private TextBox tbxCharMagicDefense;
		private GroupBox gbxCharOffensive;
		private TextBox tbxCharDirectHit;
		private TextBox tbxCharCriticalHit;
		private CheckBox cbxCharHideName;
		private TextBox tbxCharGrandCompany;
		private PictureBox ptbCharGrandCompany;
		private TextBox tbxCharTP;
		private TextBox tbxCharMP_CP_GP;
		private TextBox tbxCharHP;
		private GroupBox gbxCharAttributes;
		private TextBox tbxCharMind;
		private TextBox tbxCharIntelligence;
		private TextBox tbxCharVitality;
		private TextBox tbxCharDexterity;
		private TextBox tbxCharStrength;
		private TextBox tbxCharJobNameLevel;
		private TextBox tbxCharName;
		private PictureBox ptbCharJobIcon;
		private Label lblCharHP;
		private Label lblCharMP_CP_GP;
		private Label lblCharTP;
		private TabPage tabRoutine;
		private SplitContainer spcRoutineActions;
		private GroupBox gbxOutOfCombat;
		private CheckBox cbxOutOfCombatPullBuff;
		private CheckBox cbxOutOfCombatRest;
		private CheckBox cbxOutOfCombatHeal;
		private CheckBox cbxOutOfCombatBuff;
		private GroupBox gbxCombatActions;
		private CheckBox cbxCombatActionsCombat;
		private CheckBox cbxCombatActionsHeal;
		private CheckBox cbxCombatActionsBuff;
		private CheckBox cbxCombatActionsPull;
		private Panel panel9;
		private ComboBox cmbCombatRoutines;
		private Label lblCombatRoutineName;
		private TabPage tabMovement;
		private CheckBox cbxAutoFace;
		private Label lblDistanceYalms;
		private GroupBox gbxMoveInRange;
		private Panel panel7;
		private ComboBox cmbTargetingMode;
		private Label lblTargetingDistanceYalms;
		private Label lblTargetingDistance;
		private Label lblTargetingMode;
		private NumericUpDown numTargetingDistance;
		private Label lblMoveWithinFollow;
		private CheckBox cbxAutoMoveTarget;
		private NumericUpDown numMaxMoveDistanceTank;
		private Panel panel1;
		private ComboBox cmbMovementMode;
		private Label lblOfFollowTarget;
		private Label lblMovementMode;
		private Label lblWhen;
		private NumericUpDown numMinMoveDistanceTank;
		private Panel panel8;
		private ComboBox cmbNavigationProvider;
		private Label lblNavigationProvider;
		private TabPage tabHotkeys;
		private CheckBox cbxEnableHotkeyMovementMode;
		private CheckBox cbxEnableHotkeyToogleMovement;
		private CheckBox cbxEnableHotkeyTargetMode;
		private CheckBox cbxEnableHotkeyUnPause;
		private Panel panel10;
		private ComboBox cmbHotkeyModifierMovementMode;
		private Label lblHotkeyMoveMode;
		private Panel panel5;
		private ComboBox cmbHotkeyModifierPause;
		private Panel panel4;
		private ComboBox cmbHotkeyModifierTargetMode;
		private Panel panel3;
		private ComboBox cmbHotkeyModifierToogleMovement;
		private Label lblHotkeyMovement;
		private Label lblHotkeyTargetMode;
		private Label lblHotkeyPause;
		private TextBox tbxHotkeyMovementMode;
		private TextBox tbxHotkeyToogleMovement;
		private TextBox tbxHotkeyTargetMode;
		private TextBox tbxHotkeyPause;
		private TabPage tabMisc;
		private Label label1;
		private GroupBox gbxSprint;
		private CheckBox cbxSprintInInstance;
		private CheckBox cbxSprintInCombat;
		private CheckBox cbxSprintOutOfCombat;
		private GroupBox gbxGeneralSettings;
		private CheckBox cbxPaused;
		private CheckBox cbxExecuteWhileMoving;
		private CheckBox cbxAlwaysOnTop;
		private GroupBox gbxHotkeyMessages;
		private CheckBox cbxEnableOverlay;
		private GroupBox gbxQuesting;
		private CheckBox cbxAutoCompleteQuests;
		private CheckBox cbxAutoSkipCutscenes;
		private CheckBox cbxAutoTalkToNPCs;
		private CheckBox cbxAutoAcceptQuests;
		private TextBox tbxCharMP_CP_GPPerc;
		private TextBox tbxCharTPPerc;
		private TextBox tbxCharHPPerc;
	}
}