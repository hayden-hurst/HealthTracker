namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.healthMetricsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlNewProfile = new System.Windows.Forms.Panel();
            this.btnCloseProfileCreation = new System.Windows.Forms.Button();
            this.btnProfileSubmit = new System.Windows.Forms.Button();
            this.lblProfileCreation = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtProfileHeight = new System.Windows.Forms.TextBox();
            this.txtNewProfileName = new System.Windows.Forms.TextBox();
            this.pnlCurrentProfileSelected = new System.Windows.Forms.Panel();
            this.lblSelectedProfileNone = new System.Windows.Forms.Label();
            this.lblSelectedProfileHeading = new System.Windows.Forms.Label();
            this.lblSelectedProfileHeight = new System.Windows.Forms.Label();
            this.lblSelectedProfileName = new System.Windows.Forms.Label();
            this.lblSelectedProfileID = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlGoalManagement = new System.Windows.Forms.Panel();
            this.lblSetGoalHeader = new System.Windows.Forms.Label();
            this.btnSetGoal = new System.Windows.Forms.Button();
            this.lblTargetCalorieConsumption = new System.Windows.Forms.Label();
            this.btnCloseGoalManagement = new System.Windows.Forms.Button();
            this.lblTargetWaterConsumption = new System.Windows.Forms.Label();
            this.lblTargetBodyWeight = new System.Windows.Forms.Label();
            this.lblTargetExercise = new System.Windows.Forms.Label();
            this.txtCalorieGoal = new System.Windows.Forms.TextBox();
            this.txtWaterIntakeGoal = new System.Windows.Forms.TextBox();
            this.txtExerciseGoal = new System.Windows.Forms.TextBox();
            this.txtBodyWeightGoal = new System.Windows.Forms.TextBox();
            this.txtDaysGoal = new System.Windows.Forms.TextBox();
            this.lblSelectedProfileDaysLeft = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLogMetrics = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTodaysCalorieConsumption = new System.Windows.Forms.Label();
            this.lblTodaysWaterIntake = new System.Windows.Forms.Label();
            this.lblTodaysExercise = new System.Windows.Forms.Label();
            this.lblTodaysBodyWeight = new System.Windows.Forms.Label();
            this.lblHealthMetricDayCounter = new System.Windows.Forms.Label();
            this.txtTodaysCalorieConsumption = new System.Windows.Forms.TextBox();
            this.txtTodaysWaterIntake = new System.Windows.Forms.TextBox();
            this.txtTodaysExercise = new System.Windows.Forms.TextBox();
            this.txtTodaysBodyWeight = new System.Windows.Forms.TextBox();
            this.btnCloseHealthMetrics = new System.Windows.Forms.Button();
            this.btnSetHealthMetrics = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnlNewProfile.SuspendLayout();
            this.pnlCurrentProfileSelected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.pnlGoalManagement.SuspendLayout();
            this.pnlLogMetrics.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.goalsToolStripMenuItem,
            this.healthMetricsToolStripMenuItem,
            this.generateReportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProfileToolStripMenuItem,
            this.loadProfileToolStripMenuItem,
            this.deleteProfileToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // newProfileToolStripMenuItem
            // 
            this.newProfileToolStripMenuItem.Name = "newProfileToolStripMenuItem";
            this.newProfileToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.newProfileToolStripMenuItem.Text = "New Profile";
            this.newProfileToolStripMenuItem.Click += new System.EventHandler(this.newProfileToolStripMenuItem_Click);
            // 
            // loadProfileToolStripMenuItem
            // 
            this.loadProfileToolStripMenuItem.Name = "loadProfileToolStripMenuItem";
            this.loadProfileToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.loadProfileToolStripMenuItem.Text = "Load Profile";
            this.loadProfileToolStripMenuItem.Click += new System.EventHandler(this.loadProfileToolStripMenuItem_Click);
            // 
            // deleteProfileToolStripMenuItem
            // 
            this.deleteProfileToolStripMenuItem.Name = "deleteProfileToolStripMenuItem";
            this.deleteProfileToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.deleteProfileToolStripMenuItem.Text = "Delete Current Profile";
            this.deleteProfileToolStripMenuItem.Click += new System.EventHandler(this.deleteProfileToolStripMenuItem_Click);
            // 
            // goalsToolStripMenuItem
            // 
            this.goalsToolStripMenuItem.Name = "goalsToolStripMenuItem";
            this.goalsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.goalsToolStripMenuItem.Text = "Set Goal";
            this.goalsToolStripMenuItem.Click += new System.EventHandler(this.goalsToolStripMenuItem_Click);
            // 
            // healthMetricsToolStripMenuItem
            // 
            this.healthMetricsToolStripMenuItem.Name = "healthMetricsToolStripMenuItem";
            this.healthMetricsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.healthMetricsToolStripMenuItem.Text = "Log Metrics";
            this.healthMetricsToolStripMenuItem.Click += new System.EventHandler(this.healthMetricsToolStripMenuItem_Click);
            // 
            // generateReportToolStripMenuItem
            // 
            this.generateReportToolStripMenuItem.Name = "generateReportToolStripMenuItem";
            this.generateReportToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.generateReportToolStripMenuItem.Text = "Generate Report";
            this.generateReportToolStripMenuItem.Click += new System.EventHandler(this.generateReportToolStripMenuItem_Click);
            // 
            // pnlNewProfile
            // 
            this.pnlNewProfile.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlNewProfile.Controls.Add(this.btnCloseProfileCreation);
            this.pnlNewProfile.Controls.Add(this.btnProfileSubmit);
            this.pnlNewProfile.Controls.Add(this.lblProfileCreation);
            this.pnlNewProfile.Controls.Add(this.lblHeight);
            this.pnlNewProfile.Controls.Add(this.lblName);
            this.pnlNewProfile.Controls.Add(this.txtProfileHeight);
            this.pnlNewProfile.Controls.Add(this.txtNewProfileName);
            this.pnlNewProfile.Location = new System.Drawing.Point(0, 24);
            this.pnlNewProfile.Name = "pnlNewProfile";
            this.pnlNewProfile.Size = new System.Drawing.Size(660, 547);
            this.pnlNewProfile.TabIndex = 1;
            this.pnlNewProfile.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNewProfile_Paint);
            // 
            // btnCloseProfileCreation
            // 
            this.btnCloseProfileCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseProfileCreation.Location = new System.Drawing.Point(615, 0);
            this.btnCloseProfileCreation.Name = "btnCloseProfileCreation";
            this.btnCloseProfileCreation.Size = new System.Drawing.Size(45, 41);
            this.btnCloseProfileCreation.TabIndex = 3;
            this.btnCloseProfileCreation.Text = "X";
            this.btnCloseProfileCreation.UseVisualStyleBackColor = true;
            this.btnCloseProfileCreation.Click += new System.EventHandler(this.btnCancelProfileCreation_Click);
            // 
            // btnProfileSubmit
            // 
            this.btnProfileSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfileSubmit.Location = new System.Drawing.Point(66, 319);
            this.btnProfileSubmit.Name = "btnProfileSubmit";
            this.btnProfileSubmit.Size = new System.Drawing.Size(109, 41);
            this.btnProfileSubmit.TabIndex = 3;
            this.btnProfileSubmit.Text = "Create";
            this.btnProfileSubmit.UseVisualStyleBackColor = true;
            this.btnProfileSubmit.Click += new System.EventHandler(this.btnProfileSubmit_Click);
            // 
            // lblProfileCreation
            // 
            this.lblProfileCreation.AutoSize = true;
            this.lblProfileCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileCreation.ForeColor = System.Drawing.Color.Snow;
            this.lblProfileCreation.Location = new System.Drawing.Point(60, 87);
            this.lblProfileCreation.Name = "lblProfileCreation";
            this.lblProfileCreation.Size = new System.Drawing.Size(217, 31);
            this.lblProfileCreation.TabIndex = 2;
            this.lblProfileCreation.Text = "Profile Creation";
            this.lblProfileCreation.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.ForeColor = System.Drawing.Color.White;
            this.lblHeight.Location = new System.Drawing.Point(62, 254);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(148, 20);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "HEIGHT (Inches)";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(62, 194);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "NAME";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProfileHeight
            // 
            this.txtProfileHeight.Location = new System.Drawing.Point(66, 277);
            this.txtProfileHeight.Name = "txtProfileHeight";
            this.txtProfileHeight.Size = new System.Drawing.Size(160, 20);
            this.txtProfileHeight.TabIndex = 0;
            // 
            // txtNewProfileName
            // 
            this.txtNewProfileName.Location = new System.Drawing.Point(66, 217);
            this.txtNewProfileName.Name = "txtNewProfileName";
            this.txtNewProfileName.Size = new System.Drawing.Size(160, 20);
            this.txtNewProfileName.TabIndex = 0;
            // 
            // pnlCurrentProfileSelected
            // 
            this.pnlCurrentProfileSelected.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlCurrentProfileSelected.Controls.Add(this.lblSelectedProfileNone);
            this.pnlCurrentProfileSelected.Controls.Add(this.lblSelectedProfileHeading);
            this.pnlCurrentProfileSelected.Controls.Add(this.lblSelectedProfileDaysLeft);
            this.pnlCurrentProfileSelected.Controls.Add(this.lblSelectedProfileHeight);
            this.pnlCurrentProfileSelected.Controls.Add(this.lblSelectedProfileName);
            this.pnlCurrentProfileSelected.Controls.Add(this.lblSelectedProfileID);
            this.pnlCurrentProfileSelected.Location = new System.Drawing.Point(666, 24);
            this.pnlCurrentProfileSelected.Name = "pnlCurrentProfileSelected";
            this.pnlCurrentProfileSelected.Size = new System.Drawing.Size(438, 547);
            this.pnlCurrentProfileSelected.TabIndex = 1;
            this.pnlCurrentProfileSelected.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNewProfile_Paint);
            // 
            // lblSelectedProfileNone
            // 
            this.lblSelectedProfileNone.AutoSize = true;
            this.lblSelectedProfileNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedProfileNone.ForeColor = System.Drawing.Color.IndianRed;
            this.lblSelectedProfileNone.Location = new System.Drawing.Point(149, 165);
            this.lblSelectedProfileNone.Name = "lblSelectedProfileNone";
            this.lblSelectedProfileNone.Size = new System.Drawing.Size(193, 111);
            this.lblSelectedProfileNone.TabIndex = 1;
            this.lblSelectedProfileNone.Text = "NO \r\nPROFILE \r\nSELECTED";
            this.lblSelectedProfileNone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectedProfileHeading
            // 
            this.lblSelectedProfileHeading.AutoSize = true;
            this.lblSelectedProfileHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedProfileHeading.ForeColor = System.Drawing.Color.Snow;
            this.lblSelectedProfileHeading.Location = new System.Drawing.Point(138, 87);
            this.lblSelectedProfileHeading.Name = "lblSelectedProfileHeading";
            this.lblSelectedProfileHeading.Size = new System.Drawing.Size(204, 31);
            this.lblSelectedProfileHeading.TabIndex = 2;
            this.lblSelectedProfileHeading.Text = "Current Profile";
            // 
            // lblSelectedProfileHeight
            // 
            this.lblSelectedProfileHeight.AutoSize = true;
            this.lblSelectedProfileHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedProfileHeight.ForeColor = System.Drawing.Color.White;
            this.lblSelectedProfileHeight.Location = new System.Drawing.Point(50, 250);
            this.lblSelectedProfileHeight.Name = "lblSelectedProfileHeight";
            this.lblSelectedProfileHeight.Size = new System.Drawing.Size(87, 20);
            this.lblSelectedProfileHeight.TabIndex = 1;
            this.lblSelectedProfileHeight.Text = "HEIGHT: ";
            this.lblSelectedProfileHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectedProfileName
            // 
            this.lblSelectedProfileName.AutoSize = true;
            this.lblSelectedProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedProfileName.ForeColor = System.Drawing.Color.White;
            this.lblSelectedProfileName.Location = new System.Drawing.Point(50, 217);
            this.lblSelectedProfileName.Name = "lblSelectedProfileName";
            this.lblSelectedProfileName.Size = new System.Drawing.Size(69, 20);
            this.lblSelectedProfileName.TabIndex = 1;
            this.lblSelectedProfileName.Text = "NAME: ";
            this.lblSelectedProfileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectedProfileID
            // 
            this.lblSelectedProfileID.AutoSize = true;
            this.lblSelectedProfileID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedProfileID.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblSelectedProfileID.Location = new System.Drawing.Point(50, 183);
            this.lblSelectedProfileID.Name = "lblSelectedProfileID";
            this.lblSelectedProfileID.Size = new System.Drawing.Size(33, 20);
            this.lblSelectedProfileID.TabIndex = 1;
            this.lblSelectedProfileID.Text = "ID:";
            this.lblSelectedProfileID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGoalManagement
            // 
            this.pnlGoalManagement.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlGoalManagement.Controls.Add(this.txtDaysGoal);
            this.pnlGoalManagement.Controls.Add(this.txtBodyWeightGoal);
            this.pnlGoalManagement.Controls.Add(this.txtExerciseGoal);
            this.pnlGoalManagement.Controls.Add(this.txtWaterIntakeGoal);
            this.pnlGoalManagement.Controls.Add(this.txtCalorieGoal);
            this.pnlGoalManagement.Controls.Add(this.btnCloseGoalManagement);
            this.pnlGoalManagement.Controls.Add(this.lblSetGoalHeader);
            this.pnlGoalManagement.Controls.Add(this.btnSetGoal);
            this.pnlGoalManagement.Controls.Add(this.lblTargetExercise);
            this.pnlGoalManagement.Controls.Add(this.label1);
            this.pnlGoalManagement.Controls.Add(this.lblTargetBodyWeight);
            this.pnlGoalManagement.Controls.Add(this.lblTargetWaterConsumption);
            this.pnlGoalManagement.Controls.Add(this.lblTargetCalorieConsumption);
            this.pnlGoalManagement.Location = new System.Drawing.Point(0, 24);
            this.pnlGoalManagement.Name = "pnlGoalManagement";
            this.pnlGoalManagement.Size = new System.Drawing.Size(660, 550);
            this.pnlGoalManagement.TabIndex = 4;
            // 
            // lblSetGoalHeader
            // 
            this.lblSetGoalHeader.AutoSize = true;
            this.lblSetGoalHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetGoalHeader.ForeColor = System.Drawing.Color.Snow;
            this.lblSetGoalHeader.Location = new System.Drawing.Point(48, 84);
            this.lblSetGoalHeader.Name = "lblSetGoalHeader";
            this.lblSetGoalHeader.Size = new System.Drawing.Size(250, 31);
            this.lblSetGoalHeader.TabIndex = 2;
            this.lblSetGoalHeader.Text = "Goal Management";
            // 
            // btnSetGoal
            // 
            this.btnSetGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetGoal.Location = new System.Drawing.Point(54, 407);
            this.btnSetGoal.Name = "btnSetGoal";
            this.btnSetGoal.Size = new System.Drawing.Size(109, 41);
            this.btnSetGoal.TabIndex = 3;
            this.btnSetGoal.Text = "Set";
            this.btnSetGoal.UseVisualStyleBackColor = true;
            this.btnSetGoal.Click += new System.EventHandler(this.btnGoalSubmit_Click);
            // 
            // lblTargetCalorieConsumption
            // 
            this.lblTargetCalorieConsumption.AutoSize = true;
            this.lblTargetCalorieConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetCalorieConsumption.ForeColor = System.Drawing.Color.White;
            this.lblTargetCalorieConsumption.Location = new System.Drawing.Point(50, 183);
            this.lblTargetCalorieConsumption.Name = "lblTargetCalorieConsumption";
            this.lblTargetCalorieConsumption.Size = new System.Drawing.Size(152, 20);
            this.lblTargetCalorieConsumption.TabIndex = 1;
            this.lblTargetCalorieConsumption.Text = "Daily Calorie Goal";
            this.lblTargetCalorieConsumption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCloseGoalManagement
            // 
            this.btnCloseGoalManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseGoalManagement.Location = new System.Drawing.Point(615, 0);
            this.btnCloseGoalManagement.Name = "btnCloseGoalManagement";
            this.btnCloseGoalManagement.Size = new System.Drawing.Size(45, 41);
            this.btnCloseGoalManagement.TabIndex = 6;
            this.btnCloseGoalManagement.Text = "X";
            this.btnCloseGoalManagement.UseVisualStyleBackColor = true;
            this.btnCloseGoalManagement.Click += new System.EventHandler(this.btnCloseGoalManagement_Click);
            // 
            // lblTargetWaterConsumption
            // 
            this.lblTargetWaterConsumption.AutoSize = true;
            this.lblTargetWaterConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetWaterConsumption.ForeColor = System.Drawing.Color.White;
            this.lblTargetWaterConsumption.Location = new System.Drawing.Point(50, 217);
            this.lblTargetWaterConsumption.Name = "lblTargetWaterConsumption";
            this.lblTargetWaterConsumption.Size = new System.Drawing.Size(235, 20);
            this.lblTargetWaterConsumption.TabIndex = 1;
            this.lblTargetWaterConsumption.Text = "Daily Water Intake (glasses)";
            this.lblTargetWaterConsumption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTargetBodyWeight
            // 
            this.lblTargetBodyWeight.AutoSize = true;
            this.lblTargetBodyWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetBodyWeight.ForeColor = System.Drawing.Color.White;
            this.lblTargetBodyWeight.Location = new System.Drawing.Point(50, 279);
            this.lblTargetBodyWeight.Name = "lblTargetBodyWeight";
            this.lblTargetBodyWeight.Size = new System.Drawing.Size(243, 20);
            this.lblTargetBodyWeight.TabIndex = 1;
            this.lblTargetBodyWeight.Text = "Target Body Weight (pounds)";
            this.lblTargetBodyWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTargetExercise
            // 
            this.lblTargetExercise.AutoSize = true;
            this.lblTargetExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetExercise.ForeColor = System.Drawing.Color.White;
            this.lblTargetExercise.Location = new System.Drawing.Point(50, 250);
            this.lblTargetExercise.Name = "lblTargetExercise";
            this.lblTargetExercise.Size = new System.Drawing.Size(244, 20);
            this.lblTargetExercise.TabIndex = 1;
            this.lblTargetExercise.Text = "Daily Exercise Goal (minutes)";
            this.lblTargetExercise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCalorieGoal
            // 
            this.txtCalorieGoal.Location = new System.Drawing.Point(312, 185);
            this.txtCalorieGoal.Name = "txtCalorieGoal";
            this.txtCalorieGoal.Size = new System.Drawing.Size(100, 20);
            this.txtCalorieGoal.TabIndex = 7;
            // 
            // txtWaterIntakeGoal
            // 
            this.txtWaterIntakeGoal.Location = new System.Drawing.Point(312, 217);
            this.txtWaterIntakeGoal.Name = "txtWaterIntakeGoal";
            this.txtWaterIntakeGoal.Size = new System.Drawing.Size(100, 20);
            this.txtWaterIntakeGoal.TabIndex = 8;
            // 
            // txtExerciseGoal
            // 
            this.txtExerciseGoal.Location = new System.Drawing.Point(312, 250);
            this.txtExerciseGoal.Name = "txtExerciseGoal";
            this.txtExerciseGoal.Size = new System.Drawing.Size(100, 20);
            this.txtExerciseGoal.TabIndex = 9;
            // 
            // txtBodyWeightGoal
            // 
            this.txtBodyWeightGoal.Location = new System.Drawing.Point(312, 282);
            this.txtBodyWeightGoal.Name = "txtBodyWeightGoal";
            this.txtBodyWeightGoal.Size = new System.Drawing.Size(100, 20);
            this.txtBodyWeightGoal.TabIndex = 10;
            // 
            // txtDaysGoal
            // 
            this.txtDaysGoal.Location = new System.Drawing.Point(312, 315);
            this.txtDaysGoal.Name = "txtDaysGoal";
            this.txtDaysGoal.Size = new System.Drawing.Size(100, 20);
            this.txtDaysGoal.TabIndex = 11;
            // 
            // lblSelectedProfileDaysLeft
            // 
            this.lblSelectedProfileDaysLeft.AutoSize = true;
            this.lblSelectedProfileDaysLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedProfileDaysLeft.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblSelectedProfileDaysLeft.Location = new System.Drawing.Point(50, 282);
            this.lblSelectedProfileDaysLeft.Name = "lblSelectedProfileDaysLeft";
            this.lblSelectedProfileDaysLeft.Size = new System.Drawing.Size(0, 20);
            this.lblSelectedProfileDaysLeft.TabIndex = 1;
            this.lblSelectedProfileDaysLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Days To Meet Goal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLogMetrics
            // 
            this.pnlLogMetrics.BackColor = System.Drawing.Color.Indigo;
            this.pnlLogMetrics.Controls.Add(this.label2);
            this.pnlLogMetrics.Controls.Add(this.lblTodaysCalorieConsumption);
            this.pnlLogMetrics.Controls.Add(this.lblTodaysWaterIntake);
            this.pnlLogMetrics.Controls.Add(this.txtTodaysBodyWeight);
            this.pnlLogMetrics.Controls.Add(this.txtTodaysExercise);
            this.pnlLogMetrics.Controls.Add(this.txtTodaysWaterIntake);
            this.pnlLogMetrics.Controls.Add(this.btnCloseHealthMetrics);
            this.pnlLogMetrics.Controls.Add(this.lblTodaysExercise);
            this.pnlLogMetrics.Controls.Add(this.btnSetHealthMetrics);
            this.pnlLogMetrics.Controls.Add(this.txtTodaysCalorieConsumption);
            this.pnlLogMetrics.Controls.Add(this.lblTodaysBodyWeight);
            this.pnlLogMetrics.Controls.Add(this.lblHealthMetricDayCounter);
            this.pnlLogMetrics.Location = new System.Drawing.Point(0, 24);
            this.pnlLogMetrics.Name = "pnlLogMetrics";
            this.pnlLogMetrics.Size = new System.Drawing.Size(660, 550);
            this.pnlLogMetrics.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(48, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Set Health Metrics";
            // 
            // lblTodaysCalorieConsumption
            // 
            this.lblTodaysCalorieConsumption.AutoSize = true;
            this.lblTodaysCalorieConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaysCalorieConsumption.ForeColor = System.Drawing.Color.White;
            this.lblTodaysCalorieConsumption.Location = new System.Drawing.Point(50, 186);
            this.lblTodaysCalorieConsumption.Name = "lblTodaysCalorieConsumption";
            this.lblTodaysCalorieConsumption.Size = new System.Drawing.Size(237, 20);
            this.lblTodaysCalorieConsumption.TabIndex = 1;
            this.lblTodaysCalorieConsumption.Text = "Todays Calorie Consumption";
            this.lblTodaysCalorieConsumption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTodaysWaterIntake
            // 
            this.lblTodaysWaterIntake.AutoSize = true;
            this.lblTodaysWaterIntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaysWaterIntake.ForeColor = System.Drawing.Color.White;
            this.lblTodaysWaterIntake.Location = new System.Drawing.Point(50, 220);
            this.lblTodaysWaterIntake.Name = "lblTodaysWaterIntake";
            this.lblTodaysWaterIntake.Size = new System.Drawing.Size(253, 20);
            this.lblTodaysWaterIntake.TabIndex = 1;
            this.lblTodaysWaterIntake.Text = "Todays Water Intake (glasses)";
            this.lblTodaysWaterIntake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTodaysExercise
            // 
            this.lblTodaysExercise.AutoSize = true;
            this.lblTodaysExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaysExercise.ForeColor = System.Drawing.Color.White;
            this.lblTodaysExercise.Location = new System.Drawing.Point(50, 253);
            this.lblTodaysExercise.Name = "lblTodaysExercise";
            this.lblTodaysExercise.Size = new System.Drawing.Size(219, 20);
            this.lblTodaysExercise.TabIndex = 1;
            this.lblTodaysExercise.Text = "Todays Exercise (minutes)";
            this.lblTodaysExercise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTodaysBodyWeight
            // 
            this.lblTodaysBodyWeight.AutoSize = true;
            this.lblTodaysBodyWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaysBodyWeight.ForeColor = System.Drawing.Color.White;
            this.lblTodaysBodyWeight.Location = new System.Drawing.Point(50, 280);
            this.lblTodaysBodyWeight.Name = "lblTodaysBodyWeight";
            this.lblTodaysBodyWeight.Size = new System.Drawing.Size(248, 20);
            this.lblTodaysBodyWeight.TabIndex = 1;
            this.lblTodaysBodyWeight.Text = "Todays Body Weight (pounds)";
            this.lblTodaysBodyWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHealthMetricDayCounter
            // 
            this.lblHealthMetricDayCounter.AutoSize = true;
            this.lblHealthMetricDayCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealthMetricDayCounter.ForeColor = System.Drawing.Color.White;
            this.lblHealthMetricDayCounter.Location = new System.Drawing.Point(375, 87);
            this.lblHealthMetricDayCounter.Name = "lblHealthMetricDayCounter";
            this.lblHealthMetricDayCounter.Size = new System.Drawing.Size(103, 37);
            this.lblHealthMetricDayCounter.TabIndex = 1;
            this.lblHealthMetricDayCounter.Text = "Day 1";
            this.lblHealthMetricDayCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTodaysCalorieConsumption
            // 
            this.txtTodaysCalorieConsumption.Location = new System.Drawing.Point(312, 186);
            this.txtTodaysCalorieConsumption.Name = "txtTodaysCalorieConsumption";
            this.txtTodaysCalorieConsumption.Size = new System.Drawing.Size(100, 20);
            this.txtTodaysCalorieConsumption.TabIndex = 7;
            // 
            // txtTodaysWaterIntake
            // 
            this.txtTodaysWaterIntake.Location = new System.Drawing.Point(312, 223);
            this.txtTodaysWaterIntake.Name = "txtTodaysWaterIntake";
            this.txtTodaysWaterIntake.Size = new System.Drawing.Size(100, 20);
            this.txtTodaysWaterIntake.TabIndex = 8;
            // 
            // txtTodaysExercise
            // 
            this.txtTodaysExercise.Location = new System.Drawing.Point(312, 253);
            this.txtTodaysExercise.Name = "txtTodaysExercise";
            this.txtTodaysExercise.Size = new System.Drawing.Size(100, 20);
            this.txtTodaysExercise.TabIndex = 8;
            // 
            // txtTodaysBodyWeight
            // 
            this.txtTodaysBodyWeight.Location = new System.Drawing.Point(312, 283);
            this.txtTodaysBodyWeight.Name = "txtTodaysBodyWeight";
            this.txtTodaysBodyWeight.Size = new System.Drawing.Size(100, 20);
            this.txtTodaysBodyWeight.TabIndex = 8;
            // 
            // btnCloseHealthMetrics
            // 
            this.btnCloseHealthMetrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseHealthMetrics.Location = new System.Drawing.Point(615, 0);
            this.btnCloseHealthMetrics.Name = "btnCloseHealthMetrics";
            this.btnCloseHealthMetrics.Size = new System.Drawing.Size(45, 41);
            this.btnCloseHealthMetrics.TabIndex = 6;
            this.btnCloseHealthMetrics.Text = "X";
            this.btnCloseHealthMetrics.UseVisualStyleBackColor = true;
            this.btnCloseHealthMetrics.Click += new System.EventHandler(this.btnCloseHealthMetrics_Click);
            // 
            // btnSetHealthMetrics
            // 
            this.btnSetHealthMetrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetHealthMetrics.Location = new System.Drawing.Point(54, 407);
            this.btnSetHealthMetrics.Name = "btnSetHealthMetrics";
            this.btnSetHealthMetrics.Size = new System.Drawing.Size(109, 41);
            this.btnSetHealthMetrics.TabIndex = 3;
            this.btnSetHealthMetrics.Text = "Set";
            this.btnSetHealthMetrics.UseVisualStyleBackColor = true;
            this.btnSetHealthMetrics.Click += new System.EventHandler(this.btnSetHealthMetrics_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1104, 572);
            this.Controls.Add(this.pnlLogMetrics);
            this.Controls.Add(this.pnlGoalManagement);
            this.Controls.Add(this.pnlNewProfile);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlCurrentProfileSelected);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Health Tracker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlNewProfile.ResumeLayout(false);
            this.pnlNewProfile.PerformLayout();
            this.pnlCurrentProfileSelected.ResumeLayout(false);
            this.pnlCurrentProfileSelected.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.pnlGoalManagement.ResumeLayout(false);
            this.pnlGoalManagement.PerformLayout();
            this.pnlLogMetrics.ResumeLayout(false);
            this.pnlLogMetrics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem healthMetricsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateReportToolStripMenuItem;
        private System.Windows.Forms.Panel pnlNewProfile;
        private System.Windows.Forms.TextBox txtNewProfileName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProfileCreation;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtProfileHeight;
        private System.Windows.Forms.Button btnProfileSubmit;
        private System.Windows.Forms.Button btnCloseProfileCreation;
        private System.Windows.Forms.Panel pnlCurrentProfileSelected;
        private System.Windows.Forms.Label lblSelectedProfileHeading;
        private System.Windows.Forms.Label lblSelectedProfileName;
        private System.Windows.Forms.Label lblSelectedProfileID;
        private System.Windows.Forms.Label lblSelectedProfileHeight;
        private System.Windows.Forms.Label lblSelectedProfileNone;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel pnlGoalManagement;
        private System.Windows.Forms.Label lblSetGoalHeader;
        private System.Windows.Forms.Label lblTargetCalorieConsumption;
        private System.Windows.Forms.Button btnSetGoal;
        private System.Windows.Forms.Button btnCloseGoalManagement;
        private System.Windows.Forms.Label lblTargetExercise;
        private System.Windows.Forms.Label lblTargetBodyWeight;
        private System.Windows.Forms.Label lblTargetWaterConsumption;
        private System.Windows.Forms.TextBox txtBodyWeightGoal;
        private System.Windows.Forms.TextBox txtExerciseGoal;
        private System.Windows.Forms.TextBox txtWaterIntakeGoal;
        private System.Windows.Forms.TextBox txtCalorieGoal;
        private System.Windows.Forms.TextBox txtDaysGoal;
        private System.Windows.Forms.Label lblSelectedProfileDaysLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlLogMetrics;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTodaysCalorieConsumption;
        private System.Windows.Forms.Label lblTodaysWaterIntake;
        private System.Windows.Forms.Label lblTodaysExercise;
        private System.Windows.Forms.Label lblTodaysBodyWeight;
        private System.Windows.Forms.Label lblHealthMetricDayCounter;
        private System.Windows.Forms.TextBox txtTodaysBodyWeight;
        private System.Windows.Forms.TextBox txtTodaysExercise;
        private System.Windows.Forms.TextBox txtTodaysWaterIntake;
        private System.Windows.Forms.Button btnCloseHealthMetrics;
        private System.Windows.Forms.Button btnSetHealthMetrics;
        private System.Windows.Forms.TextBox txtTodaysCalorieConsumption;
    }
}

