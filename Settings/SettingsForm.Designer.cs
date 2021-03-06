﻿using System.ComponentModel;
using System.Windows.Forms;

namespace Mud.Settings
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
            this.lblSecBetweenUpdates = new System.Windows.Forms.Label();
            this.gbxCharRole = new Mud.Settings.CustomGroupBox();
            this.tbxCharPiety = new System.Windows.Forms.TextBox();
            this.tbxCharTenacity = new System.Windows.Forms.TextBox();
            this.gbxCharExtra = new Mud.Settings.CustomGroupBox();
            this.tbxCharSpellSpeed = new System.Windows.Forms.TextBox();
            this.tbxCharAttackMagicPotency = new System.Windows.Forms.TextBox();
            this.tbxCharHealingMagicPotency = new System.Windows.Forms.TextBox();
            this.gbxCharPhysical = new Mud.Settings.CustomGroupBox();
            this.tbxCharSkillSpeed = new System.Windows.Forms.TextBox();
            this.tbxCharAttackPower = new System.Windows.Forms.TextBox();
            this.gbxCharDefensive = new Mud.Settings.CustomGroupBox();
            this.tbxCharDefense = new System.Windows.Forms.TextBox();
            this.tbxCharMagicDefense = new System.Windows.Forms.TextBox();
            this.gbxCharOffensive = new Mud.Settings.CustomGroupBox();
            this.tbxCharDirectHit = new System.Windows.Forms.TextBox();
            this.tbxCharCriticalHit = new System.Windows.Forms.TextBox();
            this.cbxCharHideName = new System.Windows.Forms.CheckBox();
            this.tbxCharGrandCompany = new System.Windows.Forms.TextBox();
            this.ptbCharGrandCompany = new System.Windows.Forms.PictureBox();
            this.tbxCharTP = new System.Windows.Forms.TextBox();
            this.tbxCharMP_CP_GP = new System.Windows.Forms.TextBox();
            this.tbxCharHP = new System.Windows.Forms.TextBox();
            this.gbxCharAttributes = new Mud.Settings.CustomGroupBox();
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
            this.gbxOutOfCombat = new Mud.Settings.CustomGroupBox();
            this.cbxOutOfCombatPullBuff = new System.Windows.Forms.CheckBox();
            this.cbxOutOfCombatRest = new System.Windows.Forms.CheckBox();
            this.cbxOutOfCombatHeal = new System.Windows.Forms.CheckBox();
            this.cbxOutOfCombatBuff = new System.Windows.Forms.CheckBox();
            this.gbxCombatActions = new Mud.Settings.CustomGroupBox();
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.cmbNavigationProvider = new System.Windows.Forms.ComboBox();
            this.lblNavigationProvider = new System.Windows.Forms.Label();
            this.gbxMoveInRange = new Mud.Settings.CustomGroupBox();
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
            this.lblMiscQuestDescription = new System.Windows.Forms.Label();
            this.gbxSprint = new Mud.Settings.CustomGroupBox();
            this.cbxSprintInInstance = new System.Windows.Forms.CheckBox();
            this.cbxSprintInCombat = new System.Windows.Forms.CheckBox();
            this.cbxSprintOutOfCombat = new System.Windows.Forms.CheckBox();
            this.gbxGeneralSettings = new Mud.Settings.CustomGroupBox();
            this.cbxPaused = new System.Windows.Forms.CheckBox();
            this.cbxExecuteWhileMoving = new System.Windows.Forms.CheckBox();
            this.cbxAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.gbxHotkeyMessages = new Mud.Settings.CustomGroupBox();
            this.cbxEnableOverlay = new System.Windows.Forms.CheckBox();
            this.gbxQuestingDungeon = new Mud.Settings.CustomGroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbSecondsBeforeAccept = new System.Windows.Forms.ComboBox();
            this.lblSecBeforeAccept = new System.Windows.Forms.Label();
            this.cbxAutoCommenceDuty = new System.Windows.Forms.CheckBox();
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
            this.panel8.SuspendLayout();
            this.gbxMoveInRange.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetingDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMoveDistanceTank)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinMoveDistanceTank)).BeginInit();
            this.tabHotkeys.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabMisc.SuspendLayout();
            this.gbxSprint.SuspendLayout();
            this.gbxGeneralSettings.SuspendLayout();
            this.gbxHotkeyMessages.SuspendLayout();
            this.gbxQuestingDungeon.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.stpStatus.Tag = "";
            this.stpStatus.Text = "statusStrip1";
            // 
            // tspPauseStatus
            // 
            this.tspPauseStatus.Name = "tspPauseStatus";
            this.tspPauseStatus.Size = new System.Drawing.Size(108, 17);
            this.tspPauseStatus.Spring = true;
            this.tspPauseStatus.Tag = "";
            // 
            // tspMovementStatus
            // 
            this.tspMovementStatus.Name = "tspMovementStatus";
            this.tspMovementStatus.Size = new System.Drawing.Size(108, 17);
            this.tspMovementStatus.Spring = true;
            this.tspMovementStatus.Tag = "";
            // 
            // tspFollowModeStatus
            // 
            this.tspFollowModeStatus.Name = "tspFollowModeStatus";
            this.tspFollowModeStatus.Size = new System.Drawing.Size(108, 17);
            this.tspFollowModeStatus.Spring = true;
            this.tspFollowModeStatus.Tag = "";
            // 
            // tspTargetModeStatus
            // 
            this.tspTargetModeStatus.Name = "tspTargetModeStatus";
            this.tspTargetModeStatus.Size = new System.Drawing.Size(0, 17);
            this.tspTargetModeStatus.Tag = "";
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
            this.tabControlMain.Tag = "";
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
            this.tabCharInfo.Tag = "";
            this.tabCharInfo.Text = "Char Info";
            // 
            // gbxCharInfo
            // 
            this.gbxCharInfo.Controls.Add(this.tbxCharMP_CP_GPPerc);
            this.gbxCharInfo.Controls.Add(this.tbxCharTPPerc);
            this.gbxCharInfo.Controls.Add(this.tbxCharHPPerc);
            this.gbxCharInfo.Controls.Add(this.panel11);
            this.gbxCharInfo.Controls.Add(this.lblSecBetweenUpdates);
            this.gbxCharInfo.Controls.Add(this.gbxCharRole);
            this.gbxCharInfo.Controls.Add(this.gbxCharExtra);
            this.gbxCharInfo.Controls.Add(this.gbxCharPhysical);
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
            this.gbxCharInfo.Tag = "";
            // 
            // tbxCharMP_CP_GPPerc
            // 
            this.tbxCharMP_CP_GPPerc.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharMP_CP_GPPerc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharMP_CP_GPPerc.Location = new System.Drawing.Point(146, 107);
            this.tbxCharMP_CP_GPPerc.Name = "tbxCharMP_CP_GPPerc";
            this.tbxCharMP_CP_GPPerc.ReadOnly = true;
            this.tbxCharMP_CP_GPPerc.Size = new System.Drawing.Size(76, 15);
            this.tbxCharMP_CP_GPPerc.TabIndex = 32;
            this.tbxCharMP_CP_GPPerc.Tag = "";
            this.tbxCharMP_CP_GPPerc.Text = "0/100 %";
            this.tbxCharMP_CP_GPPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxCharTPPerc
            // 
            this.tbxCharTPPerc.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharTPPerc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharTPPerc.Location = new System.Drawing.Point(252, 107);
            this.tbxCharTPPerc.Name = "tbxCharTPPerc";
            this.tbxCharTPPerc.ReadOnly = true;
            this.tbxCharTPPerc.Size = new System.Drawing.Size(70, 15);
            this.tbxCharTPPerc.TabIndex = 31;
            this.tbxCharTPPerc.Tag = "";
            this.tbxCharTPPerc.Text = "0/100 %";
            this.tbxCharTPPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxCharHPPerc
            // 
            this.tbxCharHPPerc.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharHPPerc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharHPPerc.Location = new System.Drawing.Point(35, 107);
            this.tbxCharHPPerc.Name = "tbxCharHPPerc";
            this.tbxCharHPPerc.ReadOnly = true;
            this.tbxCharHPPerc.Size = new System.Drawing.Size(76, 15);
            this.tbxCharHPPerc.TabIndex = 30;
            this.tbxCharHPPerc.Tag = "";
            this.tbxCharHPPerc.Text = "0/100 %";
            this.tbxCharHPPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.cmbSecondsBetweenUpdate);
            this.panel11.Location = new System.Drawing.Point(154, 273);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(42, 23);
            this.panel11.TabIndex = 29;
            this.panel11.Tag = "";
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
            this.cmbSecondsBetweenUpdate.TabStop = false;
            this.cmbSecondsBetweenUpdate.Tag = "";
            // 
            // lblSecBetweenUpdates
            // 
            this.lblSecBetweenUpdates.AutoSize = true;
            this.lblSecBetweenUpdates.Location = new System.Drawing.Point(5, 279);
            this.lblSecBetweenUpdates.Name = "lblSecBetweenUpdates";
            this.lblSecBetweenUpdates.Size = new System.Drawing.Size(140, 13);
            this.lblSecBetweenUpdates.TabIndex = 28;
            this.lblSecBetweenUpdates.Tag = "";
            this.lblSecBetweenUpdates.Text = "Seconds before UI refresh";
            // 
            // gbxCharRole
            // 
            this.gbxCharRole.BackColor = System.Drawing.Color.Transparent;
            this.gbxCharRole.Controls.Add(this.tbxCharPiety);
            this.gbxCharRole.Controls.Add(this.tbxCharTenacity);
            this.gbxCharRole.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gbxCharRole.Location = new System.Drawing.Point(174, 204);
            this.gbxCharRole.Name = "gbxCharRole";
            this.gbxCharRole.Size = new System.Drawing.Size(72, 63);
            this.gbxCharRole.TabIndex = 26;
            this.gbxCharRole.TabStop = false;
            this.gbxCharRole.Tag = "";
            this.gbxCharRole.Text = "Role";
            // 
            // tbxCharPiety
            // 
            this.tbxCharPiety.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharPiety.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharPiety.Location = new System.Drawing.Point(6, 41);
            this.tbxCharPiety.Name = "tbxCharPiety";
            this.tbxCharPiety.ReadOnly = true;
            this.tbxCharPiety.Size = new System.Drawing.Size(60, 15);
            this.tbxCharPiety.TabIndex = 27;
            this.tbxCharPiety.Tag = "";
            this.tbxCharPiety.Text = "PTY : 9999";
            // 
            // tbxCharTenacity
            // 
            this.tbxCharTenacity.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharTenacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharTenacity.Location = new System.Drawing.Point(6, 15);
            this.tbxCharTenacity.Name = "tbxCharTenacity";
            this.tbxCharTenacity.ReadOnly = true;
            this.tbxCharTenacity.Size = new System.Drawing.Size(60, 15);
            this.tbxCharTenacity.TabIndex = 26;
            this.tbxCharTenacity.Tag = "";
            this.tbxCharTenacity.Text = "TNC : 9999";
            // 
            // gbxCharExtra
            // 
            this.gbxCharExtra.BackColor = System.Drawing.Color.Transparent;
            this.gbxCharExtra.Controls.Add(this.tbxCharSpellSpeed);
            this.gbxCharExtra.Controls.Add(this.tbxCharAttackMagicPotency);
            this.gbxCharExtra.Controls.Add(this.tbxCharHealingMagicPotency);
            this.gbxCharExtra.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gbxCharExtra.Location = new System.Drawing.Point(252, 138);
            this.gbxCharExtra.Name = "gbxCharExtra";
            this.gbxCharExtra.Size = new System.Drawing.Size(72, 75);
            this.gbxCharExtra.TabIndex = 27;
            this.gbxCharExtra.TabStop = false;
            this.gbxCharExtra.Tag = "";
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
            this.tbxCharSpellSpeed.Tag = "";
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
            this.tbxCharAttackMagicPotency.Tag = "";
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
            this.tbxCharHealingMagicPotency.Tag = "";
            this.tbxCharHealingMagicPotency.Text = "HMP : 9999";
            // 
            // gbxCharPhysical
            // 
            this.gbxCharPhysical.BackColor = System.Drawing.Color.Transparent;
            this.gbxCharPhysical.Controls.Add(this.tbxCharSkillSpeed);
            this.gbxCharPhysical.Controls.Add(this.tbxCharAttackPower);
            this.gbxCharPhysical.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gbxCharPhysical.Location = new System.Drawing.Point(174, 138);
            this.gbxCharPhysical.Name = "gbxCharPhysical";
            this.gbxCharPhysical.Size = new System.Drawing.Size(72, 60);
            this.gbxCharPhysical.TabIndex = 26;
            this.gbxCharPhysical.TabStop = false;
            this.gbxCharPhysical.Tag = "";
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
            this.tbxCharSkillSpeed.Tag = "";
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
            this.tbxCharAttackPower.Tag = "";
            this.tbxCharAttackPower.Text = "ATK : 9999";
            // 
            // gbxCharDefensive
            // 
            this.gbxCharDefensive.BackColor = System.Drawing.Color.Transparent;
            this.gbxCharDefensive.Controls.Add(this.tbxCharDefense);
            this.gbxCharDefensive.Controls.Add(this.tbxCharMagicDefense);
            this.gbxCharDefensive.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gbxCharDefensive.Location = new System.Drawing.Point(90, 204);
            this.gbxCharDefensive.Name = "gbxCharDefensive";
            this.gbxCharDefensive.Size = new System.Drawing.Size(79, 63);
            this.gbxCharDefensive.TabIndex = 26;
            this.gbxCharDefensive.TabStop = false;
            this.gbxCharDefensive.Tag = "";
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
            this.tbxCharDefense.Tag = "";
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
            this.tbxCharMagicDefense.Tag = "";
            this.tbxCharMagicDefense.Text = "MDEF : 9999";
            // 
            // gbxCharOffensive
            // 
            this.gbxCharOffensive.BackColor = System.Drawing.Color.Transparent;
            this.gbxCharOffensive.Controls.Add(this.tbxCharDirectHit);
            this.gbxCharOffensive.Controls.Add(this.tbxCharCriticalHit);
            this.gbxCharOffensive.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gbxCharOffensive.Location = new System.Drawing.Point(90, 138);
            this.gbxCharOffensive.Name = "gbxCharOffensive";
            this.gbxCharOffensive.Size = new System.Drawing.Size(79, 60);
            this.gbxCharOffensive.TabIndex = 25;
            this.gbxCharOffensive.TabStop = false;
            this.gbxCharOffensive.Tag = "";
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
            this.tbxCharDirectHit.Tag = "";
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
            this.tbxCharCriticalHit.Tag = "";
            this.tbxCharCriticalHit.Text = "CRIT : 9999";
            // 
            // cbxCharHideName
            // 
            this.cbxCharHideName.AutoSize = true;
            this.cbxCharHideName.Location = new System.Drawing.Point(272, 11);
            this.cbxCharHideName.Name = "cbxCharHideName";
            this.cbxCharHideName.Size = new System.Drawing.Size(50, 17);
            this.cbxCharHideName.TabIndex = 20;
            this.cbxCharHideName.TabStop = false;
            this.cbxCharHideName.Tag = "";
            this.cbxCharHideName.Text = "Hide";
            this.cbxCharHideName.UseVisualStyleBackColor = true;
            this.cbxCharHideName.CheckedChanged += new System.EventHandler(this.OnCheckedHideCharName);
            // 
            // tbxCharGrandCompany
            // 
            this.tbxCharGrandCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharGrandCompany.Location = new System.Drawing.Point(108, 53);
            this.tbxCharGrandCompany.Name = "tbxCharGrandCompany";
            this.tbxCharGrandCompany.ReadOnly = true;
            this.tbxCharGrandCompany.Size = new System.Drawing.Size(214, 15);
            this.tbxCharGrandCompany.TabIndex = 19;
            this.tbxCharGrandCompany.Tag = "";
            this.tbxCharGrandCompany.Text = "Grand Company show here";
            // 
            // ptbCharGrandCompany
            // 
            this.ptbCharGrandCompany.Location = new System.Drawing.Point(78, 48);
            this.ptbCharGrandCompany.MaximumSize = new System.Drawing.Size(24, 24);
            this.ptbCharGrandCompany.Name = "ptbCharGrandCompany";
            this.ptbCharGrandCompany.Size = new System.Drawing.Size(24, 24);
            this.ptbCharGrandCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCharGrandCompany.TabIndex = 18;
            this.ptbCharGrandCompany.TabStop = false;
            this.ptbCharGrandCompany.Tag = "";
            // 
            // tbxCharTP
            // 
            this.tbxCharTP.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharTP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharTP.Location = new System.Drawing.Point(252, 86);
            this.tbxCharTP.Name = "tbxCharTP";
            this.tbxCharTP.ReadOnly = true;
            this.tbxCharTP.Size = new System.Drawing.Size(70, 15);
            this.tbxCharTP.TabIndex = 17;
            this.tbxCharTP.Tag = "";
            this.tbxCharTP.Text = "99999/99999";
            this.tbxCharTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxCharMP_CP_GP
            // 
            this.tbxCharMP_CP_GP.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharMP_CP_GP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharMP_CP_GP.Location = new System.Drawing.Point(146, 86);
            this.tbxCharMP_CP_GP.Name = "tbxCharMP_CP_GP";
            this.tbxCharMP_CP_GP.ReadOnly = true;
            this.tbxCharMP_CP_GP.Size = new System.Drawing.Size(76, 15);
            this.tbxCharMP_CP_GP.TabIndex = 16;
            this.tbxCharMP_CP_GP.Tag = "";
            this.tbxCharMP_CP_GP.Text = "99999/99999";
            this.tbxCharMP_CP_GP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxCharHP
            // 
            this.tbxCharHP.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharHP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharHP.Location = new System.Drawing.Point(35, 86);
            this.tbxCharHP.Name = "tbxCharHP";
            this.tbxCharHP.ReadOnly = true;
            this.tbxCharHP.Size = new System.Drawing.Size(76, 15);
            this.tbxCharHP.TabIndex = 15;
            this.tbxCharHP.Tag = "";
            this.tbxCharHP.Text = "99999/99999";
            this.tbxCharHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbxCharAttributes
            // 
            this.gbxCharAttributes.BackColor = System.Drawing.Color.Transparent;
            this.gbxCharAttributes.Controls.Add(this.tbxCharMind);
            this.gbxCharAttributes.Controls.Add(this.tbxCharIntelligence);
            this.gbxCharAttributes.Controls.Add(this.tbxCharVitality);
            this.gbxCharAttributes.Controls.Add(this.tbxCharDexterity);
            this.gbxCharAttributes.Controls.Add(this.tbxCharStrength);
            this.gbxCharAttributes.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gbxCharAttributes.Location = new System.Drawing.Point(5, 138);
            this.gbxCharAttributes.Name = "gbxCharAttributes";
            this.gbxCharAttributes.Size = new System.Drawing.Size(79, 129);
            this.gbxCharAttributes.TabIndex = 14;
            this.gbxCharAttributes.TabStop = false;
            this.gbxCharAttributes.Tag = "";
            this.gbxCharAttributes.Text = "Attributes";
            // 
            // tbxCharMind
            // 
            this.tbxCharMind.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharMind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharMind.Location = new System.Drawing.Point(6, 107);
            this.tbxCharMind.Name = "tbxCharMind";
            this.tbxCharMind.ReadOnly = true;
            this.tbxCharMind.Size = new System.Drawing.Size(65, 15);
            this.tbxCharMind.TabIndex = 24;
            this.tbxCharMind.Tag = "";
            this.tbxCharMind.Text = "MND : 9999";
            // 
            // tbxCharIntelligence
            // 
            this.tbxCharIntelligence.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharIntelligence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharIntelligence.Location = new System.Drawing.Point(6, 83);
            this.tbxCharIntelligence.Name = "tbxCharIntelligence";
            this.tbxCharIntelligence.ReadOnly = true;
            this.tbxCharIntelligence.Size = new System.Drawing.Size(65, 15);
            this.tbxCharIntelligence.TabIndex = 22;
            this.tbxCharIntelligence.Tag = "";
            this.tbxCharIntelligence.Text = "INT : 9999";
            // 
            // tbxCharVitality
            // 
            this.tbxCharVitality.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharVitality.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharVitality.Location = new System.Drawing.Point(6, 62);
            this.tbxCharVitality.Name = "tbxCharVitality";
            this.tbxCharVitality.ReadOnly = true;
            this.tbxCharVitality.Size = new System.Drawing.Size(65, 15);
            this.tbxCharVitality.TabIndex = 20;
            this.tbxCharVitality.Tag = "";
            this.tbxCharVitality.Text = "VIT : 9999";
            // 
            // tbxCharDexterity
            // 
            this.tbxCharDexterity.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharDexterity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharDexterity.Location = new System.Drawing.Point(6, 41);
            this.tbxCharDexterity.Name = "tbxCharDexterity";
            this.tbxCharDexterity.ReadOnly = true;
            this.tbxCharDexterity.Size = new System.Drawing.Size(65, 15);
            this.tbxCharDexterity.TabIndex = 19;
            this.tbxCharDexterity.Tag = "";
            this.tbxCharDexterity.Text = "DEX : 9999";
            // 
            // tbxCharStrength
            // 
            this.tbxCharStrength.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCharStrength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCharStrength.Location = new System.Drawing.Point(6, 20);
            this.tbxCharStrength.Name = "tbxCharStrength";
            this.tbxCharStrength.ReadOnly = true;
            this.tbxCharStrength.Size = new System.Drawing.Size(65, 15);
            this.tbxCharStrength.TabIndex = 18;
            this.tbxCharStrength.Tag = "";
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
            this.tbxCharJobNameLevel.Tag = "";
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
            this.tbxCharName.Tag = "";
            this.tbxCharName.Text = "Character name show here";
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
            this.ptbCharJobIcon.Tag = "";
            // 
            // lblCharHP
            // 
            this.lblCharHP.AutoSize = true;
            this.lblCharHP.Location = new System.Drawing.Point(8, 97);
            this.lblCharHP.Name = "lblCharHP";
            this.lblCharHP.Size = new System.Drawing.Size(21, 13);
            this.lblCharHP.TabIndex = 4;
            this.lblCharHP.Tag = "";
            this.lblCharHP.Text = "HP";
            // 
            // lblCharMP_CP_GP
            // 
            this.lblCharMP_CP_GP.AutoSize = true;
            this.lblCharMP_CP_GP.Location = new System.Drawing.Point(117, 97);
            this.lblCharMP_CP_GP.Name = "lblCharMP_CP_GP";
            this.lblCharMP_CP_GP.Size = new System.Drawing.Size(23, 13);
            this.lblCharMP_CP_GP.TabIndex = 6;
            this.lblCharMP_CP_GP.Tag = "";
            this.lblCharMP_CP_GP.Text = "MP";
            // 
            // lblCharTP
            // 
            this.lblCharTP.AutoSize = true;
            this.lblCharTP.Location = new System.Drawing.Point(228, 97);
            this.lblCharTP.Name = "lblCharTP";
            this.lblCharTP.Size = new System.Drawing.Size(18, 13);
            this.lblCharTP.TabIndex = 8;
            this.lblCharTP.Tag = "";
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
            this.tabRoutine.Tag = "";
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
            this.spcRoutineActions.Size = new System.Drawing.Size(324, 267);
            this.spcRoutineActions.SplitterDistance = 160;
            this.spcRoutineActions.TabIndex = 19;
            this.spcRoutineActions.Tag = "";
            // 
            // gbxOutOfCombat
            // 
            this.gbxOutOfCombat.BackColor = System.Drawing.Color.Transparent;
            this.gbxOutOfCombat.Controls.Add(this.cbxOutOfCombatPullBuff);
            this.gbxOutOfCombat.Controls.Add(this.cbxOutOfCombatRest);
            this.gbxOutOfCombat.Controls.Add(this.cbxOutOfCombatHeal);
            this.gbxOutOfCombat.Controls.Add(this.cbxOutOfCombatBuff);
            this.gbxOutOfCombat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxOutOfCombat.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gbxOutOfCombat.Location = new System.Drawing.Point(0, 0);
            this.gbxOutOfCombat.Name = "gbxOutOfCombat";
            this.gbxOutOfCombat.Size = new System.Drawing.Size(160, 267);
            this.gbxOutOfCombat.TabIndex = 20;
            this.gbxOutOfCombat.TabStop = false;
            this.gbxOutOfCombat.Tag = "";
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
            this.cbxOutOfCombatPullBuff.TabStop = false;
            this.cbxOutOfCombatPullBuff.Tag = "";
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
            this.cbxOutOfCombatRest.TabStop = false;
            this.cbxOutOfCombatRest.Tag = "";
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
            this.cbxOutOfCombatHeal.TabStop = false;
            this.cbxOutOfCombatHeal.Tag = "";
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
            this.cbxOutOfCombatBuff.TabStop = false;
            this.cbxOutOfCombatBuff.Tag = "";
            this.cbxOutOfCombatBuff.Text = "Pre-Combat Buff";
            this.cbxOutOfCombatBuff.UseVisualStyleBackColor = true;
            // 
            // gbxCombatActions
            // 
            this.gbxCombatActions.BackColor = System.Drawing.Color.Transparent;
            this.gbxCombatActions.Controls.Add(this.cbxCombatActionsCombat);
            this.gbxCombatActions.Controls.Add(this.cbxCombatActionsHeal);
            this.gbxCombatActions.Controls.Add(this.cbxCombatActionsBuff);
            this.gbxCombatActions.Controls.Add(this.cbxCombatActionsPull);
            this.gbxCombatActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxCombatActions.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gbxCombatActions.Location = new System.Drawing.Point(0, 0);
            this.gbxCombatActions.Name = "gbxCombatActions";
            this.gbxCombatActions.Size = new System.Drawing.Size(160, 267);
            this.gbxCombatActions.TabIndex = 19;
            this.gbxCombatActions.TabStop = false;
            this.gbxCombatActions.Tag = "";
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
            this.cbxCombatActionsCombat.TabStop = false;
            this.cbxCombatActionsCombat.Tag = "";
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
            this.cbxCombatActionsHeal.TabStop = false;
            this.cbxCombatActionsHeal.Tag = "";
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
            this.cbxCombatActionsBuff.TabStop = false;
            this.cbxCombatActionsBuff.Tag = "";
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
            this.cbxCombatActionsPull.TabStop = false;
            this.cbxCombatActionsPull.Tag = "";
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
            this.panel9.Tag = "";
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
            this.cmbCombatRoutines.TabStop = false;
            this.cmbCombatRoutines.Tag = "";
            this.cmbCombatRoutines.SelectedIndexChanged += new System.EventHandler(this.OnSelectedCombatRoutine);
            // 
            // lblCombatRoutineName
            // 
            this.lblCombatRoutineName.Location = new System.Drawing.Point(8, 12);
            this.lblCombatRoutineName.Name = "lblCombatRoutineName";
            this.lblCombatRoutineName.Size = new System.Drawing.Size(137, 17);
            this.lblCombatRoutineName.TabIndex = 21;
            this.lblCombatRoutineName.Tag = "";
            this.lblCombatRoutineName.Text = "Loaded Combat Routine";
            // 
            // tabMovement
            // 
            this.tabMovement.BackColor = System.Drawing.SystemColors.Control;
            this.tabMovement.Controls.Add(this.cbxAutoFace);
            this.tabMovement.Controls.Add(this.lblDistanceYalms);
            this.tabMovement.Controls.Add(this.panel8);
            this.tabMovement.Controls.Add(this.lblNavigationProvider);
            this.tabMovement.Controls.Add(this.gbxMoveInRange);
            this.tabMovement.Location = new System.Drawing.Point(4, 22);
            this.tabMovement.Name = "tabMovement";
            this.tabMovement.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovement.Size = new System.Drawing.Size(333, 310);
            this.tabMovement.TabIndex = 3;
            this.tabMovement.Tag = "";
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
            this.cbxAutoFace.TabStop = false;
            this.cbxAutoFace.Tag = "";
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
            this.lblDistanceYalms.Tag = "";
            this.lblDistanceYalms.Text = "*All the distances are expressed in Yalm";
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
            this.panel8.Tag = "";
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
            this.cmbNavigationProvider.TabStop = false;
            this.cmbNavigationProvider.Tag = "";
            this.cmbNavigationProvider.SelectedIndexChanged += new System.EventHandler(this.OnSelectedNavigationProvider);
            // 
            // lblNavigationProvider
            // 
            this.lblNavigationProvider.Location = new System.Drawing.Point(8, 12);
            this.lblNavigationProvider.Name = "lblNavigationProvider";
            this.lblNavigationProvider.Size = new System.Drawing.Size(108, 17);
            this.lblNavigationProvider.TabIndex = 36;
            this.lblNavigationProvider.Tag = "";
            this.lblNavigationProvider.Text = "Navigation Provider";
            // 
            // gbxMoveInRange
            // 
            this.gbxMoveInRange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxMoveInRange.BackColor = System.Drawing.Color.Transparent;
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
            this.gbxMoveInRange.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gbxMoveInRange.Location = new System.Drawing.Point(3, 59);
            this.gbxMoveInRange.Name = "gbxMoveInRange";
            this.gbxMoveInRange.Size = new System.Drawing.Size(324, 233);
            this.gbxMoveInRange.TabIndex = 38;
            this.gbxMoveInRange.TabStop = false;
            this.gbxMoveInRange.Tag = "";
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
            this.panel7.Tag = "";
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
            this.cmbTargetingMode.TabStop = false;
            this.cmbTargetingMode.Tag = "";
            // 
            // lblTargetingDistanceYalms
            // 
            this.lblTargetingDistanceYalms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTargetingDistanceYalms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTargetingDistanceYalms.Location = new System.Drawing.Point(179, 142);
            this.lblTargetingDistanceYalms.Name = "lblTargetingDistanceYalms";
            this.lblTargetingDistanceYalms.Size = new System.Drawing.Size(34, 17);
            this.lblTargetingDistanceYalms.TabIndex = 40;
            this.lblTargetingDistanceYalms.Tag = "";
            this.lblTargetingDistanceYalms.Text = "Yalms";
            // 
            // lblTargetingDistance
            // 
            this.lblTargetingDistance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTargetingDistance.Location = new System.Drawing.Point(5, 142);
            this.lblTargetingDistance.Name = "lblTargetingDistance";
            this.lblTargetingDistance.Size = new System.Drawing.Size(102, 17);
            this.lblTargetingDistance.TabIndex = 38;
            this.lblTargetingDistance.Tag = "";
            this.lblTargetingDistance.Text = "Targeting Distance";
            // 
            // lblTargetingMode
            // 
            this.lblTargetingMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTargetingMode.Location = new System.Drawing.Point(5, 115);
            this.lblTargetingMode.Name = "lblTargetingMode";
            this.lblTargetingMode.Size = new System.Drawing.Size(93, 17);
            this.lblTargetingMode.TabIndex = 37;
            this.lblTargetingMode.Tag = "";
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
            this.numTargetingDistance.TabStop = false;
            this.numTargetingDistance.Tag = "";
            this.numTargetingDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMoveWithinFollow
            // 
            this.lblMoveWithinFollow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMoveWithinFollow.Location = new System.Drawing.Point(63, 50);
            this.lblMoveWithinFollow.Name = "lblMoveWithinFollow";
            this.lblMoveWithinFollow.Size = new System.Drawing.Size(75, 17);
            this.lblMoveWithinFollow.TabIndex = 36;
            this.lblMoveWithinFollow.Tag = "";
            this.lblMoveWithinFollow.Text = "Move Within";
            // 
            // cbxAutoMoveTarget
            // 
            this.cbxAutoMoveTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAutoMoveTarget.Location = new System.Drawing.Point(7, 21);
            this.cbxAutoMoveTarget.Name = "cbxAutoMoveTarget";
            this.cbxAutoMoveTarget.Size = new System.Drawing.Size(132, 17);
            this.cbxAutoMoveTarget.TabIndex = 28;
            this.cbxAutoMoveTarget.TabStop = false;
            this.cbxAutoMoveTarget.Tag = "";
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
            this.numMaxMoveDistanceTank.TabStop = false;
            this.numMaxMoveDistanceTank.Tag = "";
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
            this.panel1.Tag = "";
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
            this.cmbMovementMode.TabStop = false;
            this.cmbMovementMode.Tag = "";
            // 
            // lblOfFollowTarget
            // 
            this.lblOfFollowTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOfFollowTarget.Location = new System.Drawing.Point(211, 50);
            this.lblOfFollowTarget.Name = "lblOfFollowTarget";
            this.lblOfFollowTarget.Size = new System.Drawing.Size(90, 17);
            this.lblOfFollowTarget.TabIndex = 30;
            this.lblOfFollowTarget.Tag = "";
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
            this.lblMovementMode.Tag = "";
            this.lblMovementMode.Text = "Movement Mode";
            // 
            // lblWhen
            // 
            this.lblWhen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWhen.Location = new System.Drawing.Point(73, 78);
            this.lblWhen.Name = "lblWhen";
            this.lblWhen.Size = new System.Drawing.Size(65, 17);
            this.lblWhen.TabIndex = 34;
            this.lblWhen.Tag = "";
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
            this.numMinMoveDistanceTank.TabStop = false;
            this.numMinMoveDistanceTank.Tag = "";
            this.numMinMoveDistanceTank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.tabHotkeys.Tag = "";
            this.tabHotkeys.Text = "Hotkeys";
            // 
            // cbxEnableHotkeyMovementMode
            // 
            this.cbxEnableHotkeyMovementMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEnableHotkeyMovementMode.Location = new System.Drawing.Point(11, 173);
            this.cbxEnableHotkeyMovementMode.Name = "cbxEnableHotkeyMovementMode";
            this.cbxEnableHotkeyMovementMode.Size = new System.Drawing.Size(15, 17);
            this.cbxEnableHotkeyMovementMode.TabIndex = 28;
            this.cbxEnableHotkeyMovementMode.TabStop = false;
            this.cbxEnableHotkeyMovementMode.Tag = "";
            this.cbxEnableHotkeyMovementMode.UseVisualStyleBackColor = true;
            this.cbxEnableHotkeyMovementMode.CheckedChanged += new System.EventHandler(this.OnCheckedEnableHotkeyMovementMode);
            // 
            // cbxEnableHotkeyToogleMovement
            // 
            this.cbxEnableHotkeyToogleMovement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEnableHotkeyToogleMovement.Location = new System.Drawing.Point(11, 127);
            this.cbxEnableHotkeyToogleMovement.Name = "cbxEnableHotkeyToogleMovement";
            this.cbxEnableHotkeyToogleMovement.Size = new System.Drawing.Size(15, 17);
            this.cbxEnableHotkeyToogleMovement.TabIndex = 26;
            this.cbxEnableHotkeyToogleMovement.TabStop = false;
            this.cbxEnableHotkeyToogleMovement.Tag = "";
            this.cbxEnableHotkeyToogleMovement.UseVisualStyleBackColor = true;
            this.cbxEnableHotkeyToogleMovement.CheckedChanged += new System.EventHandler(this.OnCheckedEnableToogleMovement);
            // 
            // cbxEnableHotkeyTargetMode
            // 
            this.cbxEnableHotkeyTargetMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEnableHotkeyTargetMode.Location = new System.Drawing.Point(11, 81);
            this.cbxEnableHotkeyTargetMode.Name = "cbxEnableHotkeyTargetMode";
            this.cbxEnableHotkeyTargetMode.Size = new System.Drawing.Size(15, 17);
            this.cbxEnableHotkeyTargetMode.TabIndex = 25;
            this.cbxEnableHotkeyTargetMode.TabStop = false;
            this.cbxEnableHotkeyTargetMode.Tag = "";
            this.cbxEnableHotkeyTargetMode.UseVisualStyleBackColor = true;
            this.cbxEnableHotkeyTargetMode.CheckedChanged += new System.EventHandler(this.OnCheckedEnableHotkeyTargetMode);
            // 
            // cbxEnableHotkeyUnPause
            // 
            this.cbxEnableHotkeyUnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEnableHotkeyUnPause.Location = new System.Drawing.Point(11, 34);
            this.cbxEnableHotkeyUnPause.Name = "cbxEnableHotkeyUnPause";
            this.cbxEnableHotkeyUnPause.Size = new System.Drawing.Size(15, 17);
            this.cbxEnableHotkeyUnPause.TabIndex = 24;
            this.cbxEnableHotkeyUnPause.TabStop = false;
            this.cbxEnableHotkeyUnPause.Tag = "";
            this.cbxEnableHotkeyUnPause.UseVisualStyleBackColor = true;
            this.cbxEnableHotkeyUnPause.CheckedChanged += new System.EventHandler(this.OnCheckedEnableHotkeyUnPause);
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.cmbHotkeyModifierMovementMode);
            this.panel10.Location = new System.Drawing.Point(30, 171);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(217, 23);
            this.panel10.TabIndex = 23;
            this.panel10.Tag = "";
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
            this.cmbHotkeyModifierMovementMode.TabStop = false;
            this.cmbHotkeyModifierMovementMode.Tag = "";
            // 
            // lblHotkeyMoveMode
            // 
            this.lblHotkeyMoveMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHotkeyMoveMode.Location = new System.Drawing.Point(8, 152);
            this.lblHotkeyMoveMode.Name = "lblHotkeyMoveMode";
            this.lblHotkeyMoveMode.Size = new System.Drawing.Size(131, 17);
            this.lblHotkeyMoveMode.TabIndex = 21;
            this.lblHotkeyMoveMode.Tag = "";
            this.lblHotkeyMoveMode.Text = "Toggle Movement Mode";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.cmbHotkeyModifierPause);
            this.panel5.Location = new System.Drawing.Point(30, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(217, 23);
            this.panel5.TabIndex = 20;
            this.panel5.Tag = "";
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
            this.cmbHotkeyModifierPause.TabStop = false;
            this.cmbHotkeyModifierPause.Tag = "";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cmbHotkeyModifierTargetMode);
            this.panel4.Location = new System.Drawing.Point(30, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(217, 23);
            this.panel4.TabIndex = 19;
            this.panel4.Tag = "";
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
            this.cmbHotkeyModifierTargetMode.TabStop = false;
            this.cmbHotkeyModifierTargetMode.Tag = "";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cmbHotkeyModifierToogleMovement);
            this.panel3.Location = new System.Drawing.Point(30, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 23);
            this.panel3.TabIndex = 18;
            this.panel3.Tag = "";
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
            this.cmbHotkeyModifierToogleMovement.TabStop = false;
            this.cmbHotkeyModifierToogleMovement.Tag = "";
            // 
            // lblHotkeyMovement
            // 
            this.lblHotkeyMovement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHotkeyMovement.Location = new System.Drawing.Point(8, 105);
            this.lblHotkeyMovement.Name = "lblHotkeyMovement";
            this.lblHotkeyMovement.Size = new System.Drawing.Size(98, 17);
            this.lblHotkeyMovement.TabIndex = 8;
            this.lblHotkeyMovement.Tag = "";
            this.lblHotkeyMovement.Text = "Toggle Movement";
            // 
            // lblHotkeyTargetMode
            // 
            this.lblHotkeyTargetMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHotkeyTargetMode.Location = new System.Drawing.Point(8, 60);
            this.lblHotkeyTargetMode.Name = "lblHotkeyTargetMode";
            this.lblHotkeyTargetMode.Size = new System.Drawing.Size(108, 17);
            this.lblHotkeyTargetMode.TabIndex = 3;
            this.lblHotkeyTargetMode.Tag = "";
            this.lblHotkeyTargetMode.Text = "Toggle Target Mode";
            // 
            // lblHotkeyPause
            // 
            this.lblHotkeyPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHotkeyPause.Location = new System.Drawing.Point(8, 12);
            this.lblHotkeyPause.Name = "lblHotkeyPause";
            this.lblHotkeyPause.Size = new System.Drawing.Size(152, 17);
            this.lblHotkeyPause.TabIndex = 0;
            this.lblHotkeyPause.Tag = "";
            this.lblHotkeyPause.Text = "Pause / Unpause Mud Assist";
            // 
            // tbxHotkeyMovementMode
            // 
            this.tbxHotkeyMovementMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHotkeyMovementMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHotkeyMovementMode.Location = new System.Drawing.Point(253, 171);
            this.tbxHotkeyMovementMode.Name = "tbxHotkeyMovementMode";
            this.tbxHotkeyMovementMode.Size = new System.Drawing.Size(71, 22);
            this.tbxHotkeyMovementMode.TabIndex = 22;
            this.tbxHotkeyMovementMode.TabStop = false;
            this.tbxHotkeyMovementMode.Tag = "";
            this.tbxHotkeyMovementMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxHotkeyToogleMovement
            // 
            this.tbxHotkeyToogleMovement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHotkeyToogleMovement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHotkeyToogleMovement.Location = new System.Drawing.Point(253, 125);
            this.tbxHotkeyToogleMovement.Name = "tbxHotkeyToogleMovement";
            this.tbxHotkeyToogleMovement.Size = new System.Drawing.Size(71, 22);
            this.tbxHotkeyToogleMovement.TabIndex = 10;
            this.tbxHotkeyToogleMovement.TabStop = false;
            this.tbxHotkeyToogleMovement.Tag = "";
            this.tbxHotkeyToogleMovement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxHotkeyTargetMode
            // 
            this.tbxHotkeyTargetMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHotkeyTargetMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHotkeyTargetMode.Location = new System.Drawing.Point(253, 79);
            this.tbxHotkeyTargetMode.Name = "tbxHotkeyTargetMode";
            this.tbxHotkeyTargetMode.Size = new System.Drawing.Size(71, 22);
            this.tbxHotkeyTargetMode.TabIndex = 5;
            this.tbxHotkeyTargetMode.TabStop = false;
            this.tbxHotkeyTargetMode.Tag = "";
            this.tbxHotkeyTargetMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxHotkeyPause
            // 
            this.tbxHotkeyPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHotkeyPause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHotkeyPause.Location = new System.Drawing.Point(253, 32);
            this.tbxHotkeyPause.Name = "tbxHotkeyPause";
            this.tbxHotkeyPause.Size = new System.Drawing.Size(71, 22);
            this.tbxHotkeyPause.TabIndex = 2;
            this.tbxHotkeyPause.TabStop = false;
            this.tbxHotkeyPause.Tag = "";
            this.tbxHotkeyPause.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabMisc
            // 
            this.tabMisc.Controls.Add(this.lblMiscQuestDescription);
            this.tabMisc.Controls.Add(this.gbxSprint);
            this.tabMisc.Controls.Add(this.gbxGeneralSettings);
            this.tabMisc.Controls.Add(this.gbxHotkeyMessages);
            this.tabMisc.Controls.Add(this.gbxQuestingDungeon);
            this.tabMisc.Location = new System.Drawing.Point(4, 22);
            this.tabMisc.Name = "tabMisc";
            this.tabMisc.Size = new System.Drawing.Size(333, 310);
            this.tabMisc.TabIndex = 0;
            this.tabMisc.Tag = "";
            this.tabMisc.Text = "Misc";
            // 
            // lblMiscQuestDescription
            // 
            this.lblMiscQuestDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMiscQuestDescription.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiscQuestDescription.Location = new System.Drawing.Point(4, 295);
            this.lblMiscQuestDescription.Name = "lblMiscQuestDescription";
            this.lblMiscQuestDescription.Size = new System.Drawing.Size(324, 12);
            this.lblMiscQuestDescription.TabIndex = 45;
            this.lblMiscQuestDescription.Tag = "";
            this.lblMiscQuestDescription.Text = "*Quests with selectable rewards need to be completed manually";
            // 
            // gbxSprint
            // 
            this.gbxSprint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSprint.BackColor = System.Drawing.Color.Transparent;
            this.gbxSprint.Controls.Add(this.cbxSprintInInstance);
            this.gbxSprint.Controls.Add(this.cbxSprintInCombat);
            this.gbxSprint.Controls.Add(this.cbxSprintOutOfCombat);
            this.gbxSprint.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gbxSprint.Location = new System.Drawing.Point(4, 127);
            this.gbxSprint.Name = "gbxSprint";
            this.gbxSprint.Size = new System.Drawing.Size(325, 65);
            this.gbxSprint.TabIndex = 26;
            this.gbxSprint.TabStop = false;
            this.gbxSprint.Tag = "";
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
            this.cbxSprintInInstance.TabStop = false;
            this.cbxSprintInInstance.Tag = "";
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
            this.cbxSprintInCombat.TabStop = false;
            this.cbxSprintInCombat.Tag = "";
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
            this.cbxSprintOutOfCombat.TabStop = false;
            this.cbxSprintOutOfCombat.Tag = "";
            this.cbxSprintOutOfCombat.Text = "Sprint Out of Combat";
            this.cbxSprintOutOfCombat.UseVisualStyleBackColor = true;
            // 
            // gbxGeneralSettings
            // 
            this.gbxGeneralSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxGeneralSettings.BackColor = System.Drawing.Color.Transparent;
            this.gbxGeneralSettings.Controls.Add(this.cbxPaused);
            this.gbxGeneralSettings.Controls.Add(this.cbxExecuteWhileMoving);
            this.gbxGeneralSettings.Controls.Add(this.cbxAlwaysOnTop);
            this.gbxGeneralSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gbxGeneralSettings.Location = new System.Drawing.Point(4, 3);
            this.gbxGeneralSettings.Name = "gbxGeneralSettings";
            this.gbxGeneralSettings.Size = new System.Drawing.Size(325, 65);
            this.gbxGeneralSettings.TabIndex = 26;
            this.gbxGeneralSettings.TabStop = false;
            this.gbxGeneralSettings.Tag = "";
            this.gbxGeneralSettings.Text = "General Settings";
            // 
            // cbxPaused
            // 
            this.cbxPaused.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPaused.Location = new System.Drawing.Point(7, 19);
            this.cbxPaused.Name = "cbxPaused";
            this.cbxPaused.Size = new System.Drawing.Size(110, 17);
            this.cbxPaused.TabIndex = 0;
            this.cbxPaused.TabStop = false;
            this.cbxPaused.Tag = "";
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
            this.cbxExecuteWhileMoving.TabStop = false;
            this.cbxExecuteWhileMoving.Tag = "";
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
            this.cbxAlwaysOnTop.TabStop = false;
            this.cbxAlwaysOnTop.Tag = "";
            this.cbxAlwaysOnTop.Text = "Always On Top";
            this.cbxAlwaysOnTop.UseVisualStyleBackColor = true;
            this.cbxAlwaysOnTop.CheckedChanged += new System.EventHandler(this.OnCheckedAlwaysOnTop);
            // 
            // gbxHotkeyMessages
            // 
            this.gbxHotkeyMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxHotkeyMessages.BackColor = System.Drawing.Color.Transparent;
            this.gbxHotkeyMessages.Controls.Add(this.cbxEnableOverlay);
            this.gbxHotkeyMessages.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gbxHotkeyMessages.Location = new System.Drawing.Point(4, 74);
            this.gbxHotkeyMessages.Name = "gbxHotkeyMessages";
            this.gbxHotkeyMessages.Size = new System.Drawing.Size(325, 47);
            this.gbxHotkeyMessages.TabIndex = 25;
            this.gbxHotkeyMessages.TabStop = false;
            this.gbxHotkeyMessages.Tag = "";
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
            this.cbxEnableOverlay.TabStop = false;
            this.cbxEnableOverlay.Tag = "";
            this.cbxEnableOverlay.Text = "Enable Overlay";
            this.cbxEnableOverlay.UseVisualStyleBackColor = true;
            // 
            // gbxQuestingDungeon
            // 
            this.gbxQuestingDungeon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxQuestingDungeon.BackColor = System.Drawing.Color.Transparent;
            this.gbxQuestingDungeon.Controls.Add(this.panel2);
            this.gbxQuestingDungeon.Controls.Add(this.lblSecBeforeAccept);
            this.gbxQuestingDungeon.Controls.Add(this.cbxAutoCommenceDuty);
            this.gbxQuestingDungeon.Controls.Add(this.cbxAutoCompleteQuests);
            this.gbxQuestingDungeon.Controls.Add(this.cbxAutoSkipCutscenes);
            this.gbxQuestingDungeon.Controls.Add(this.cbxAutoTalkToNPCs);
            this.gbxQuestingDungeon.Controls.Add(this.cbxAutoAcceptQuests);
            this.gbxQuestingDungeon.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gbxQuestingDungeon.Location = new System.Drawing.Point(4, 198);
            this.gbxQuestingDungeon.Name = "gbxQuestingDungeon";
            this.gbxQuestingDungeon.Size = new System.Drawing.Size(325, 94);
            this.gbxQuestingDungeon.TabIndex = 22;
            this.gbxQuestingDungeon.TabStop = false;
            this.gbxQuestingDungeon.Tag = "";
            this.gbxQuestingDungeon.Text = "Questing / Dungeon";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmbSecondsBeforeAccept);
            this.panel2.Location = new System.Drawing.Point(279, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 21);
            this.panel2.TabIndex = 30;
            this.panel2.Tag = "";
            // 
            // cmbSecondsBeforeAccept
            // 
            this.cmbSecondsBeforeAccept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSecondsBeforeAccept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecondsBeforeAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSecondsBeforeAccept.FormattingEnabled = true;
            this.cmbSecondsBeforeAccept.Location = new System.Drawing.Point(0, 0);
            this.cmbSecondsBeforeAccept.Name = "cmbSecondsBeforeAccept";
            this.cmbSecondsBeforeAccept.Size = new System.Drawing.Size(38, 21);
            this.cmbSecondsBeforeAccept.TabIndex = 9;
            this.cmbSecondsBeforeAccept.TabStop = false;
            this.cmbSecondsBeforeAccept.Tag = "";
            // 
            // lblSecBeforeAccept
            // 
            this.lblSecBeforeAccept.AutoSize = true;
            this.lblSecBeforeAccept.Location = new System.Drawing.Point(175, 69);
            this.lblSecBeforeAccept.Name = "lblSecBeforeAccept";
            this.lblSecBeforeAccept.Size = new System.Drawing.Size(98, 13);
            this.lblSecBeforeAccept.TabIndex = 29;
            this.lblSecBeforeAccept.Tag = "";
            this.lblSecBeforeAccept.Text = "Sec Before Accept";
            // 
            // cbxAutoCommenceDuty
            // 
            this.cbxAutoCommenceDuty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAutoCommenceDuty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAutoCommenceDuty.Location = new System.Drawing.Point(7, 67);
            this.cbxAutoCommenceDuty.Name = "cbxAutoCommenceDuty";
            this.cbxAutoCommenceDuty.Size = new System.Drawing.Size(136, 17);
            this.cbxAutoCommenceDuty.TabIndex = 24;
            this.cbxAutoCommenceDuty.TabStop = false;
            this.cbxAutoCommenceDuty.Tag = "";
            this.cbxAutoCommenceDuty.Text = "Auto Commence Duty";
            this.cbxAutoCommenceDuty.UseVisualStyleBackColor = true;
            // 
            // cbxAutoCompleteQuests
            // 
            this.cbxAutoCompleteQuests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAutoCompleteQuests.Enabled = false;
            this.cbxAutoCompleteQuests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAutoCompleteQuests.Location = new System.Drawing.Point(178, 43);
            this.cbxAutoCompleteQuests.Name = "cbxAutoCompleteQuests";
            this.cbxAutoCompleteQuests.Size = new System.Drawing.Size(143, 17);
            this.cbxAutoCompleteQuests.TabIndex = 23;
            this.cbxAutoCompleteQuests.TabStop = false;
            this.cbxAutoCompleteQuests.Tag = "";
            this.cbxAutoCompleteQuests.Text = "Auto Complete Quests*";
            this.cbxAutoCompleteQuests.UseVisualStyleBackColor = true;
            // 
            // cbxAutoSkipCutscenes
            // 
            this.cbxAutoSkipCutscenes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAutoSkipCutscenes.Checked = true;
            this.cbxAutoSkipCutscenes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAutoSkipCutscenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAutoSkipCutscenes.Location = new System.Drawing.Point(7, 43);
            this.cbxAutoSkipCutscenes.Name = "cbxAutoSkipCutscenes";
            this.cbxAutoSkipCutscenes.Size = new System.Drawing.Size(131, 17);
            this.cbxAutoSkipCutscenes.TabIndex = 22;
            this.cbxAutoSkipCutscenes.TabStop = false;
            this.cbxAutoSkipCutscenes.Tag = "";
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
            this.cbxAutoTalkToNPCs.TabStop = false;
            this.cbxAutoTalkToNPCs.Tag = "";
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
            this.cbxAutoAcceptQuests.TabStop = false;
            this.cbxAutoAcceptQuests.Tag = "";
            this.cbxAutoAcceptQuests.Text = "Auto Accept Quests";
            this.cbxAutoAcceptQuests.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(341, 358);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.stpStatus);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(357, 397);
            this.Name = "SettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MudSettingsForm_Closing);
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
            this.panel8.ResumeLayout(false);
            this.gbxMoveInRange.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTargetingDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMoveDistanceTank)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numMinMoveDistanceTank)).EndInit();
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
            this.gbxQuestingDungeon.ResumeLayout(false);
            this.gbxQuestingDungeon.PerformLayout();
            this.panel2.ResumeLayout(false);
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
		private Label lblSecBetweenUpdates;
		private CustomGroupBox gbxCharRole;
		private TextBox tbxCharPiety;
		private TextBox tbxCharTenacity;
		private CustomGroupBox gbxCharExtra;
		private TextBox tbxCharSpellSpeed;
		private TextBox tbxCharAttackMagicPotency;
		private TextBox tbxCharHealingMagicPotency;
		private CustomGroupBox gbxCharPhysical;
		private TextBox tbxCharSkillSpeed;
		private TextBox tbxCharAttackPower;
		private CustomGroupBox gbxCharDefensive;
		private TextBox tbxCharDefense;
		private TextBox tbxCharMagicDefense;
		private CustomGroupBox gbxCharOffensive;
		private TextBox tbxCharDirectHit;
		private TextBox tbxCharCriticalHit;
		private CheckBox cbxCharHideName;
		private TextBox tbxCharGrandCompany;
		private PictureBox ptbCharGrandCompany;
		private TextBox tbxCharTP;
		private TextBox tbxCharMP_CP_GP;
		private TextBox tbxCharHP;
		private CustomGroupBox gbxCharAttributes;
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
		private CustomGroupBox gbxOutOfCombat;
		private CheckBox cbxOutOfCombatPullBuff;
		private CheckBox cbxOutOfCombatRest;
		private CheckBox cbxOutOfCombatHeal;
		private CheckBox cbxOutOfCombatBuff;
		private CustomGroupBox gbxCombatActions;
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
		private CustomGroupBox gbxMoveInRange;
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
		private Label lblMiscQuestDescription;
		private CustomGroupBox gbxSprint;
		private CheckBox cbxSprintInInstance;
		private CheckBox cbxSprintInCombat;
		private CheckBox cbxSprintOutOfCombat;
		private CustomGroupBox gbxGeneralSettings;
		private CheckBox cbxPaused;
		private CheckBox cbxExecuteWhileMoving;
		private CheckBox cbxAlwaysOnTop;
		private CustomGroupBox gbxHotkeyMessages;
		private CheckBox cbxEnableOverlay;
		private CustomGroupBox gbxQuestingDungeon;
		private CheckBox cbxAutoCompleteQuests;
		private CheckBox cbxAutoSkipCutscenes;
		private CheckBox cbxAutoTalkToNPCs;
		private CheckBox cbxAutoAcceptQuests;
		private TextBox tbxCharMP_CP_GPPerc;
		private TextBox tbxCharTPPerc;
		private TextBox tbxCharHPPerc;
        private CheckBox cbxAutoCommenceDuty;
        private Label lblSecBeforeAccept;
        private Panel panel2;
        private ComboBox cmbSecondsBeforeAccept;
    }
}