// Project Prolog
// Name: K.Ndlovu
// CS3260 Section 001
// Project: Lab_05
// Date: 10/14/2017 
// Purpose: This program models creates objects of an employee database
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes plagiarism, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace EmployeeDB
{
    partial class FrmEmployee
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
            this.TabEmployee = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.TxtMiddleName = new System.Windows.Forms.TextBox();
            this.LblMiddleName = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RBtnBenefitsMarried = new System.Windows.Forms.RadioButton();
            this.RBtnBenefitsSingle = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.CBXTCompe = new System.Windows.Forms.ComboBox();
            this.LblComp = new System.Windows.Forms.Label();
            this.GBoxComp = new System.Windows.Forms.GroupBox();
            this.RBtnComNo = new System.Windows.Forms.RadioButton();
            this.RBtnComYes = new System.Windows.Forms.RadioButton();
            this.GBoxEB = new System.Windows.Forms.GroupBox();
            this.RBtnEdNo = new System.Windows.Forms.RadioButton();
            this.RBtnEdYes = new System.Windows.Forms.RadioButton();
            this.GBoxBenefits = new System.Windows.Forms.GroupBox();
            this.RBtnBenefitsYes = new System.Windows.Forms.RadioButton();
            this.RBtnBenefitsNo = new System.Windows.Forms.RadioButton();
            this.GBoxOT = new System.Windows.Forms.GroupBox();
            this.RBtnOTNo = new System.Windows.Forms.RadioButton();
            this.RBtnOTYes = new System.Windows.Forms.RadioButton();
            this.BtnRead = new System.Windows.Forms.Button();
            this.BtnWrite = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnView = new System.Windows.Forms.Button();
            this.LblBRules = new System.Windows.Forms.Label();
            this.RtxtBRules = new System.Windows.Forms.RichTextBox();
            this.TxtOther3 = new System.Windows.Forms.TextBox();
            this.LblOther3 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.RTxtInfo = new System.Windows.Forms.RichTextBox();
            this.CBXType = new System.Windows.Forms.ComboBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtOther2 = new System.Windows.Forms.TextBox();
            this.LblOther2 = new System.Windows.Forms.Label();
            this.TxtOther = new System.Windows.Forms.TextBox();
            this.LblOther = new System.Windows.Forms.Label();
            this.LblSurname = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LblType = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.TabSearch = new System.Windows.Forms.TabPage();
            this.LblError = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBtnLast = new System.Windows.Forms.RadioButton();
            this.RBtnID = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.RtxtBSearch = new System.Windows.Forms.RichTextBox();
            this.TxtLastSearch = new System.Windows.Forms.TextBox();
            this.LblLast = new System.Windows.Forms.Label();
            this.LblEmpId = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtIdSearch = new System.Windows.Forms.TextBox();
            this.Course = new System.Windows.Forms.TabPage();
            this.CBoxGrade = new System.Windows.Forms.ComboBox();
            this.RTBoxCourse = new System.Windows.Forms.RichTextBox();
            this.CBoxCredits = new System.Windows.Forms.ComboBox();
            this.BtnCSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LblCredits = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblGrade = new System.Windows.Forms.Label();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.TxtCourseId = new System.Windows.Forms.TextBox();
            this.LblDesc = new System.Windows.Forms.Label();
            this.LblCourseId = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.EPEmpId = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.EREducation = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.TabEmployee.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.GBoxComp.SuspendLayout();
            this.GBoxEB.SuspendLayout();
            this.GBoxBenefits.SuspendLayout();
            this.GBoxOT.SuspendLayout();
            this.TabSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Course.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPEmpId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EREducation)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabEmployee
            // 
            this.TabEmployee.Controls.Add(this.tabMain);
            this.TabEmployee.Controls.Add(this.TabSearch);
            this.TabEmployee.Controls.Add(this.Course);
            this.TabEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabEmployee.Location = new System.Drawing.Point(0, 0);
            this.TabEmployee.Name = "TabEmployee";
            this.TabEmployee.SelectedIndex = 0;
            this.TabEmployee.Size = new System.Drawing.Size(1212, 596);
            this.TabEmployee.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.Gainsboro;
            this.tabMain.Controls.Add(this.TxtMiddleName);
            this.tabMain.Controls.Add(this.LblMiddleName);
            this.tabMain.Controls.Add(this.LblTitle);
            this.tabMain.Controls.Add(this.comboBox1);
            this.tabMain.Controls.Add(this.RBtnBenefitsMarried);
            this.tabMain.Controls.Add(this.RBtnBenefitsSingle);
            this.tabMain.Controls.Add(this.label2);
            this.tabMain.Controls.Add(this.CBXTCompe);
            this.tabMain.Controls.Add(this.LblComp);
            this.tabMain.Controls.Add(this.GBoxComp);
            this.tabMain.Controls.Add(this.GBoxEB);
            this.tabMain.Controls.Add(this.GBoxBenefits);
            this.tabMain.Controls.Add(this.GBoxOT);
            this.tabMain.Controls.Add(this.BtnRead);
            this.tabMain.Controls.Add(this.BtnWrite);
            this.tabMain.Controls.Add(this.BtnClear);
            this.tabMain.Controls.Add(this.BtnView);
            this.tabMain.Controls.Add(this.LblBRules);
            this.tabMain.Controls.Add(this.RtxtBRules);
            this.tabMain.Controls.Add(this.TxtOther3);
            this.tabMain.Controls.Add(this.LblOther3);
            this.tabMain.Controls.Add(this.lblInfo);
            this.tabMain.Controls.Add(this.RTxtInfo);
            this.tabMain.Controls.Add(this.CBXType);
            this.tabMain.Controls.Add(this.BtnSave);
            this.tabMain.Controls.Add(this.TxtOther2);
            this.tabMain.Controls.Add(this.LblOther2);
            this.tabMain.Controls.Add(this.TxtOther);
            this.tabMain.Controls.Add(this.LblOther);
            this.tabMain.Controls.Add(this.LblSurname);
            this.tabMain.Controls.Add(this.TxtSurname);
            this.tabMain.Controls.Add(this.TxtName);
            this.tabMain.Controls.Add(this.TxtID);
            this.tabMain.Controls.Add(this.LblType);
            this.tabMain.Controls.Add(this.LblID);
            this.tabMain.Controls.Add(this.LblFirstName);
            this.tabMain.Controls.Add(this.menuStrip1);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(1204, 570);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.Click += new System.EventHandler(this.tabMain_Click);
            // 
            // TxtMiddleName
            // 
            this.TxtMiddleName.Location = new System.Drawing.Point(202, 108);
            this.TxtMiddleName.Name = "TxtMiddleName";
            this.TxtMiddleName.Size = new System.Drawing.Size(44, 20);
            this.TxtMiddleName.TabIndex = 89;
            // 
            // LblMiddleName
            // 
            this.LblMiddleName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.LblMiddleName.AutoSize = true;
            this.LblMiddleName.Location = new System.Drawing.Point(38, 114);
            this.LblMiddleName.Name = "LblMiddleName";
            this.LblMiddleName.Size = new System.Drawing.Size(69, 13);
            this.LblMiddleName.TabIndex = 88;
            this.LblMiddleName.Text = "Middle Name";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(449, 122);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(27, 13);
            this.LblTitle.TabIndex = 87;
            this.LblTitle.Text = "Title";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mr",
            "Miss",
            "Mrs"});
            this.comboBox1.Location = new System.Drawing.Point(579, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 86;
            // 
            // RBtnBenefitsMarried
            // 
            this.RBtnBenefitsMarried.AutoSize = true;
            this.RBtnBenefitsMarried.Location = new System.Drawing.Point(673, 66);
            this.RBtnBenefitsMarried.Name = "RBtnBenefitsMarried";
            this.RBtnBenefitsMarried.Size = new System.Drawing.Size(60, 17);
            this.RBtnBenefitsMarried.TabIndex = 85;
            this.RBtnBenefitsMarried.Text = "Married";
            this.RBtnBenefitsMarried.UseVisualStyleBackColor = true;
            // 
            // RBtnBenefitsSingle
            // 
            this.RBtnBenefitsSingle.AutoSize = true;
            this.RBtnBenefitsSingle.Checked = true;
            this.RBtnBenefitsSingle.Location = new System.Drawing.Point(580, 64);
            this.RBtnBenefitsSingle.Name = "RBtnBenefitsSingle";
            this.RBtnBenefitsSingle.Size = new System.Drawing.Size(54, 17);
            this.RBtnBenefitsSingle.TabIndex = 84;
            this.RBtnBenefitsSingle.TabStop = true;
            this.RBtnBenefitsSingle.Text = "Single";
            this.RBtnBenefitsSingle.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Marital Status";
            // 
            // CBXTCompe
            // 
            this.CBXTCompe.FormattingEnabled = true;
            this.CBXTCompe.Items.AddRange(new object[] {
            "Monthly Salary",
            "Monthly Pay",
            "Hourly Rate"});
            this.CBXTCompe.Location = new System.Drawing.Point(202, 259);
            this.CBXTCompe.Name = "CBXTCompe";
            this.CBXTCompe.Size = new System.Drawing.Size(165, 21);
            this.CBXTCompe.TabIndex = 81;
            this.CBXTCompe.SelectedIndexChanged += new System.EventHandler(this.CBXTCompe_SelectedIndexChanged);
            // 
            // LblComp
            // 
            this.LblComp.AutoSize = true;
            this.LblComp.Location = new System.Drawing.Point(38, 259);
            this.LblComp.Name = "LblComp";
            this.LblComp.Size = new System.Drawing.Size(74, 13);
            this.LblComp.TabIndex = 80;
            this.LblComp.Text = "Compensation";
            // 
            // GBoxComp
            // 
            this.GBoxComp.Controls.Add(this.RBtnComNo);
            this.GBoxComp.Controls.Add(this.RBtnComYes);
            this.GBoxComp.Location = new System.Drawing.Point(41, 213);
            this.GBoxComp.Name = "GBoxComp";
            this.GBoxComp.Size = new System.Drawing.Size(340, 22);
            this.GBoxComp.TabIndex = 79;
            this.GBoxComp.TabStop = false;
            this.GBoxComp.Text = "Commission";
            // 
            // RBtnComNo
            // 
            this.RBtnComNo.AutoSize = true;
            this.RBtnComNo.Location = new System.Drawing.Point(295, 0);
            this.RBtnComNo.Name = "RBtnComNo";
            this.RBtnComNo.Size = new System.Drawing.Size(39, 17);
            this.RBtnComNo.TabIndex = 1;
            this.RBtnComNo.TabStop = true;
            this.RBtnComNo.Text = "No";
            this.RBtnComNo.UseVisualStyleBackColor = true;
            // 
            // RBtnComYes
            // 
            this.RBtnComYes.AutoSize = true;
            this.RBtnComYes.Location = new System.Drawing.Point(175, 0);
            this.RBtnComYes.Name = "RBtnComYes";
            this.RBtnComYes.Size = new System.Drawing.Size(43, 17);
            this.RBtnComYes.TabIndex = 0;
            this.RBtnComYes.TabStop = true;
            this.RBtnComYes.Text = "Yes";
            this.RBtnComYes.UseVisualStyleBackColor = true;
            // 
            // GBoxEB
            // 
            this.GBoxEB.Controls.Add(this.RBtnEdNo);
            this.GBoxEB.Controls.Add(this.RBtnEdYes);
            this.GBoxEB.Location = new System.Drawing.Point(442, 259);
            this.GBoxEB.Name = "GBoxEB";
            this.GBoxEB.Size = new System.Drawing.Size(281, 29);
            this.GBoxEB.TabIndex = 78;
            this.GBoxEB.TabStop = false;
            this.GBoxEB.Text = "Education Benefits";
            // 
            // RBtnEdNo
            // 
            this.RBtnEdNo.AutoSize = true;
            this.RBtnEdNo.Location = new System.Drawing.Point(232, 0);
            this.RBtnEdNo.Name = "RBtnEdNo";
            this.RBtnEdNo.Size = new System.Drawing.Size(39, 17);
            this.RBtnEdNo.TabIndex = 75;
            this.RBtnEdNo.TabStop = true;
            this.RBtnEdNo.Text = "No";
            this.RBtnEdNo.UseVisualStyleBackColor = true;
            // 
            // RBtnEdYes
            // 
            this.RBtnEdYes.AutoSize = true;
            this.RBtnEdYes.Location = new System.Drawing.Point(133, 0);
            this.RBtnEdYes.Name = "RBtnEdYes";
            this.RBtnEdYes.Size = new System.Drawing.Size(43, 17);
            this.RBtnEdYes.TabIndex = 74;
            this.RBtnEdYes.TabStop = true;
            this.RBtnEdYes.Text = "Yes";
            this.RBtnEdYes.UseVisualStyleBackColor = true;
            // 
            // GBoxBenefits
            // 
            this.GBoxBenefits.Controls.Add(this.RBtnBenefitsYes);
            this.GBoxBenefits.Controls.Add(this.RBtnBenefitsNo);
            this.GBoxBenefits.Location = new System.Drawing.Point(446, 212);
            this.GBoxBenefits.Name = "GBoxBenefits";
            this.GBoxBenefits.Size = new System.Drawing.Size(277, 23);
            this.GBoxBenefits.TabIndex = 70;
            this.GBoxBenefits.TabStop = false;
            this.GBoxBenefits.Text = "Benefits";
            // 
            // RBtnBenefitsYes
            // 
            this.RBtnBenefitsYes.AutoSize = true;
            this.RBtnBenefitsYes.Location = new System.Drawing.Point(129, 0);
            this.RBtnBenefitsYes.Name = "RBtnBenefitsYes";
            this.RBtnBenefitsYes.Size = new System.Drawing.Size(43, 17);
            this.RBtnBenefitsYes.TabIndex = 70;
            this.RBtnBenefitsYes.TabStop = true;
            this.RBtnBenefitsYes.Text = "Yes";
            this.RBtnBenefitsYes.UseVisualStyleBackColor = true;
            // 
            // RBtnBenefitsNo
            // 
            this.RBtnBenefitsNo.AutoSize = true;
            this.RBtnBenefitsNo.Location = new System.Drawing.Point(228, 0);
            this.RBtnBenefitsNo.Name = "RBtnBenefitsNo";
            this.RBtnBenefitsNo.Size = new System.Drawing.Size(39, 17);
            this.RBtnBenefitsNo.TabIndex = 71;
            this.RBtnBenefitsNo.TabStop = true;
            this.RBtnBenefitsNo.Text = "No";
            this.RBtnBenefitsNo.UseVisualStyleBackColor = true;
            // 
            // GBoxOT
            // 
            this.GBoxOT.BackColor = System.Drawing.Color.Gainsboro;
            this.GBoxOT.Controls.Add(this.RBtnOTNo);
            this.GBoxOT.Controls.Add(this.RBtnOTYes);
            this.GBoxOT.Location = new System.Drawing.Point(446, 164);
            this.GBoxOT.Name = "GBoxOT";
            this.GBoxOT.Size = new System.Drawing.Size(340, 23);
            this.GBoxOT.TabIndex = 77;
            this.GBoxOT.TabStop = false;
            this.GBoxOT.Text = "Over time";
            // 
            // RBtnOTNo
            // 
            this.RBtnOTNo.AutoSize = true;
            this.RBtnOTNo.Location = new System.Drawing.Point(301, 6);
            this.RBtnOTNo.Name = "RBtnOTNo";
            this.RBtnOTNo.Size = new System.Drawing.Size(39, 17);
            this.RBtnOTNo.TabIndex = 69;
            this.RBtnOTNo.TabStop = true;
            this.RBtnOTNo.Text = "No";
            this.RBtnOTNo.UseVisualStyleBackColor = true;
            // 
            // RBtnOTYes
            // 
            this.RBtnOTYes.AutoSize = true;
            this.RBtnOTYes.Location = new System.Drawing.Point(175, 6);
            this.RBtnOTYes.Name = "RBtnOTYes";
            this.RBtnOTYes.Size = new System.Drawing.Size(43, 17);
            this.RBtnOTYes.TabIndex = 68;
            this.RBtnOTYes.TabStop = true;
            this.RBtnOTYes.Text = "Yes";
            this.RBtnOTYes.UseVisualStyleBackColor = true;
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(96, 321);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(106, 27);
            this.BtnRead.TabIndex = 55;
            this.BtnRead.Text = "Read from File";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // BtnWrite
            // 
            this.BtnWrite.Location = new System.Drawing.Point(250, 321);
            this.BtnWrite.Name = "BtnWrite";
            this.BtnWrite.Size = new System.Drawing.Size(83, 27);
            this.BtnWrite.TabIndex = 54;
            this.BtnWrite.Text = "Write to File";
            this.BtnWrite.UseVisualStyleBackColor = true;
            this.BtnWrite.Click += new System.EventHandler(this.BtnWrite_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(764, 327);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 50;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click_1);
            // 
            // BtnView
            // 
            this.BtnView.Location = new System.Drawing.Point(393, 321);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(75, 29);
            this.BtnView.TabIndex = 49;
            this.BtnView.Text = "View list";
            this.BtnView.UseVisualStyleBackColor = true;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click_1);
            // 
            // LblBRules
            // 
            this.LblBRules.AutoSize = true;
            this.LblBRules.Location = new System.Drawing.Point(199, 362);
            this.LblBRules.Name = "LblBRules";
            this.LblBRules.Size = new System.Drawing.Size(89, 13);
            this.LblBRules.TabIndex = 48;
            this.LblBRules.Text = "Business rules list";
            // 
            // RtxtBRules
            // 
            this.RtxtBRules.Location = new System.Drawing.Point(29, 387);
            this.RtxtBRules.Name = "RtxtBRules";
            this.RtxtBRules.Size = new System.Drawing.Size(557, 162);
            this.RtxtBRules.TabIndex = 47;
            this.RtxtBRules.Text = "";
            // 
            // TxtOther3
            // 
            this.TxtOther3.Location = new System.Drawing.Point(976, 164);
            this.TxtOther3.Name = "TxtOther3";
            this.TxtOther3.Size = new System.Drawing.Size(165, 20);
            this.TxtOther3.TabIndex = 46;
            this.TxtOther3.Visible = false;
            this.TxtOther3.Validating += new System.ComponentModel.CancelEventHandler(this.TxtOther3_Validating);
            // 
            // LblOther3
            // 
            this.LblOther3.AutoSize = true;
            this.LblOther3.Location = new System.Drawing.Point(797, 171);
            this.LblOther3.Name = "LblOther3";
            this.LblOther3.Size = new System.Drawing.Size(42, 13);
            this.LblOther3.TabIndex = 45;
            this.LblOther3.Text = "Other 3";
            this.LblOther3.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(849, 362);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(108, 13);
            this.lblInfo.TabIndex = 44;
            this.lblInfo.Text = "Employee Information";
            // 
            // RTxtInfo
            // 
            this.RTxtInfo.Location = new System.Drawing.Point(651, 387);
            this.RTxtInfo.Name = "RTxtInfo";
            this.RTxtInfo.Size = new System.Drawing.Size(513, 162);
            this.RTxtInfo.TabIndex = 43;
            this.RTxtInfo.Text = "";
            // 
            // CBXType
            // 
            this.CBXType.FormattingEnabled = true;
            this.CBXType.Items.AddRange(new object[] {
            "Hourly",
            "Salary",
            "Contract",
            "Sales"});
            this.CBXType.Location = new System.Drawing.Point(202, 32);
            this.CBXType.Name = "CBXType";
            this.CBXType.Size = new System.Drawing.Size(179, 21);
            this.CBXType.TabIndex = 42;
            this.CBXType.SelectedIndexChanged += new System.EventHandler(this.CBXType_SelectedIndexChanged_1);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(541, 321);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(155, 29);
            this.BtnSave.TabIndex = 40;
            this.BtnSave.Text = "Save employee";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click_1);
            // 
            // TxtOther2
            // 
            this.TxtOther2.Location = new System.Drawing.Point(976, 111);
            this.TxtOther2.Name = "TxtOther2";
            this.TxtOther2.Size = new System.Drawing.Size(165, 20);
            this.TxtOther2.TabIndex = 39;
            this.TxtOther2.Visible = false;
            this.TxtOther2.Validating += new System.ComponentModel.CancelEventHandler(this.TxtOther2_Validating);
            // 
            // LblOther2
            // 
            this.LblOther2.AutoSize = true;
            this.LblOther2.Location = new System.Drawing.Point(797, 111);
            this.LblOther2.Name = "LblOther2";
            this.LblOther2.Size = new System.Drawing.Size(42, 13);
            this.LblOther2.TabIndex = 38;
            this.LblOther2.Text = "Other 2";
            this.LblOther2.Visible = false;
            // 
            // TxtOther
            // 
            this.TxtOther.Location = new System.Drawing.Point(976, 36);
            this.TxtOther.Name = "TxtOther";
            this.TxtOther.Size = new System.Drawing.Size(165, 20);
            this.TxtOther.TabIndex = 37;
            this.TxtOther.Visible = false;
            this.TxtOther.Validating += new System.ComponentModel.CancelEventHandler(this.TxtOther_Validating);
            // 
            // LblOther
            // 
            this.LblOther.AutoSize = true;
            this.LblOther.Location = new System.Drawing.Point(797, 36);
            this.LblOther.Name = "LblOther";
            this.LblOther.Size = new System.Drawing.Size(33, 13);
            this.LblOther.TabIndex = 36;
            this.LblOther.Text = "Other";
            this.LblOther.Visible = false;
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Location = new System.Drawing.Point(38, 164);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(58, 13);
            this.LblSurname.TabIndex = 35;
            this.LblSurname.Text = "Last Name";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(202, 161);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(179, 20);
            this.TxtSurname.TabIndex = 34;
            this.TxtSurname.Validating += new System.ComponentModel.CancelEventHandler(this.TxtSurname_Validating);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(202, 66);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(179, 20);
            this.TxtName.TabIndex = 33;
            this.TxtName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtName_Validating);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(580, 33);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(154, 20);
            this.TxtID.TabIndex = 32;
            this.TxtID.Validating += new System.ComponentModel.CancelEventHandler(this.TxtID_Validating);
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(32, 32);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(80, 13);
            this.LblType.TabIndex = 30;
            this.LblType.Text = "Employee Type";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(449, 35);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(67, 13);
            this.LblID.TabIndex = 29;
            this.LblID.Text = "Employee ID";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(38, 66);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(57, 13);
            this.LblFirstName.TabIndex = 31;
            this.LblFirstName.Text = "First Name";
            // 
            // TabSearch
            // 
            this.TabSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.TabSearch.Controls.Add(this.LblError);
            this.TabSearch.Controls.Add(this.groupBox1);
            this.TabSearch.Controls.Add(this.label1);
            this.TabSearch.Controls.Add(this.RtxtBSearch);
            this.TabSearch.Controls.Add(this.TxtLastSearch);
            this.TabSearch.Controls.Add(this.LblLast);
            this.TabSearch.Controls.Add(this.LblEmpId);
            this.TabSearch.Controls.Add(this.BtnSearch);
            this.TabSearch.Controls.Add(this.TxtIdSearch);
            this.TabSearch.Location = new System.Drawing.Point(4, 22);
            this.TabSearch.Name = "TabSearch";
            this.TabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.TabSearch.Size = new System.Drawing.Size(1204, 570);
            this.TabSearch.TabIndex = 1;
            this.TabSearch.Text = "Search";
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Location = new System.Drawing.Point(847, 124);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(10, 13);
            this.LblError.TabIndex = 62;
            this.LblError.Text = " ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBtnLast);
            this.groupBox1.Controls.Add(this.RBtnID);
            this.groupBox1.Location = new System.Drawing.Point(90, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 68);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by";
            // 
            // RBtnLast
            // 
            this.RBtnLast.AutoSize = true;
            this.RBtnLast.Location = new System.Drawing.Point(134, 31);
            this.RBtnLast.Name = "RBtnLast";
            this.RBtnLast.Size = new System.Drawing.Size(74, 17);
            this.RBtnLast.TabIndex = 1;
            this.RBtnLast.TabStop = true;
            this.RBtnLast.Text = "Last name";
            this.RBtnLast.UseVisualStyleBackColor = true;
            this.RBtnLast.CheckedChanged += new System.EventHandler(this.RBtnLast_CheckedChanged);
            // 
            // RBtnID
            // 
            this.RBtnID.AutoSize = true;
            this.RBtnID.Location = new System.Drawing.Point(6, 31);
            this.RBtnID.Name = "RBtnID";
            this.RBtnID.Size = new System.Drawing.Size(36, 17);
            this.RBtnID.TabIndex = 0;
            this.RBtnID.TabStop = true;
            this.RBtnID.Text = "ID";
            this.RBtnID.UseVisualStyleBackColor = true;
            this.RBtnID.CheckedChanged += new System.EventHandler(this.RBtnID_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Search results";
            // 
            // RtxtBSearch
            // 
            this.RtxtBSearch.Location = new System.Drawing.Point(23, 320);
            this.RtxtBSearch.Name = "RtxtBSearch";
            this.RtxtBSearch.Size = new System.Drawing.Size(793, 229);
            this.RtxtBSearch.TabIndex = 59;
            this.RtxtBSearch.Text = "";
            this.RtxtBSearch.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // TxtLastSearch
            // 
            this.TxtLastSearch.Location = new System.Drawing.Point(576, 192);
            this.TxtLastSearch.Name = "TxtLastSearch";
            this.TxtLastSearch.Size = new System.Drawing.Size(240, 20);
            this.TxtLastSearch.TabIndex = 58;
            this.TxtLastSearch.Visible = false;
            this.TxtLastSearch.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLastSearch_Validating);
            // 
            // LblLast
            // 
            this.LblLast.AutoSize = true;
            this.LblLast.Location = new System.Drawing.Point(53, 192);
            this.LblLast.Name = "LblLast";
            this.LblLast.Size = new System.Drawing.Size(58, 13);
            this.LblLast.TabIndex = 57;
            this.LblLast.Text = "Last Name";
            this.LblLast.Visible = false;
            // 
            // LblEmpId
            // 
            this.LblEmpId.AutoSize = true;
            this.LblEmpId.Location = new System.Drawing.Point(53, 121);
            this.LblEmpId.Name = "LblEmpId";
            this.LblEmpId.Size = new System.Drawing.Size(67, 13);
            this.LblEmpId.TabIndex = 56;
            this.LblEmpId.Text = "Employee ID";
            this.LblEmpId.Visible = false;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnSearch.Location = new System.Drawing.Point(298, 240);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(122, 23);
            this.BtnSearch.TabIndex = 55;
            this.BtnSearch.Text = "Search for employee";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Visible = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtIdSearch
            // 
            this.TxtIdSearch.Location = new System.Drawing.Point(576, 121);
            this.TxtIdSearch.Name = "TxtIdSearch";
            this.TxtIdSearch.Size = new System.Drawing.Size(240, 20);
            this.TxtIdSearch.TabIndex = 54;
            this.TxtIdSearch.Visible = false;
            this.TxtIdSearch.Validating += new System.ComponentModel.CancelEventHandler(this.TxtIdSearch_Validating);
            // 
            // Course
            // 
            this.Course.BackColor = System.Drawing.Color.Gainsboro;
            this.Course.Controls.Add(this.CBoxGrade);
            this.Course.Controls.Add(this.RTBoxCourse);
            this.Course.Controls.Add(this.CBoxCredits);
            this.Course.Controls.Add(this.BtnCSave);
            this.Course.Controls.Add(this.dateTimePicker1);
            this.Course.Controls.Add(this.LblCredits);
            this.Course.Controls.Add(this.LblDate);
            this.Course.Controls.Add(this.LblGrade);
            this.Course.Controls.Add(this.TxtDesc);
            this.Course.Controls.Add(this.TxtCourseId);
            this.Course.Controls.Add(this.LblDesc);
            this.Course.Controls.Add(this.LblCourseId);
            this.Course.Location = new System.Drawing.Point(4, 22);
            this.Course.Name = "Course";
            this.Course.Padding = new System.Windows.Forms.Padding(3);
            this.Course.Size = new System.Drawing.Size(1204, 570);
            this.Course.TabIndex = 2;
            this.Course.Text = "Education";
            // 
            // CBoxGrade
            // 
            this.CBoxGrade.FormattingEnabled = true;
            this.CBoxGrade.Items.AddRange(new object[] {
            "A",
            "A-",
            "B+",
            "B",
            "B-",
            "C+",
            "C",
            "C-",
            "D+",
            "D",
            "D-",
            "E"});
            this.CBoxGrade.Location = new System.Drawing.Point(565, 154);
            this.CBoxGrade.Name = "CBoxGrade";
            this.CBoxGrade.Size = new System.Drawing.Size(90, 21);
            this.CBoxGrade.TabIndex = 2;
            // 
            // RTBoxCourse
            // 
            this.RTBoxCourse.Location = new System.Drawing.Point(52, 390);
            this.RTBoxCourse.Name = "RTBoxCourse";
            this.RTBoxCourse.Size = new System.Drawing.Size(780, 172);
            this.RTBoxCourse.TabIndex = 14;
            this.RTBoxCourse.Text = "";
            // 
            // CBoxCredits
            // 
            this.CBoxCredits.FormattingEnabled = true;
            this.CBoxCredits.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CBoxCredits.Location = new System.Drawing.Point(565, 276);
            this.CBoxCredits.Name = "CBoxCredits";
            this.CBoxCredits.Size = new System.Drawing.Size(66, 21);
            this.CBoxCredits.TabIndex = 13;
            this.CBoxCredits.Validating += new System.ComponentModel.CancelEventHandler(this.CBoxCredits_Validating);
            // 
            // BtnCSave
            // 
            this.BtnCSave.Location = new System.Drawing.Point(321, 326);
            this.BtnCSave.Name = "BtnCSave";
            this.BtnCSave.Size = new System.Drawing.Size(153, 23);
            this.BtnCSave.TabIndex = 11;
            this.BtnCSave.Text = "Save";
            this.BtnCSave.UseVisualStyleBackColor = true;
            this.BtnCSave.Click += new System.EventHandler(this.BtnCSave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(565, 222);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // LblCredits
            // 
            this.LblCredits.AutoSize = true;
            this.LblCredits.Location = new System.Drawing.Point(81, 276);
            this.LblCredits.Name = "LblCredits";
            this.LblCredits.Size = new System.Drawing.Size(39, 13);
            this.LblCredits.TabIndex = 9;
            this.LblCredits.Text = "Credits";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(81, 222);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(75, 13);
            this.LblDate.TabIndex = 8;
            this.LblDate.Text = "Approval Date";
            // 
            // LblGrade
            // 
            this.LblGrade.AutoSize = true;
            this.LblGrade.Location = new System.Drawing.Point(81, 154);
            this.LblGrade.Name = "LblGrade";
            this.LblGrade.Size = new System.Drawing.Size(36, 13);
            this.LblGrade.TabIndex = 7;
            this.LblGrade.Text = "Grade";
            // 
            // TxtDesc
            // 
            this.TxtDesc.Location = new System.Drawing.Point(565, 102);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(228, 20);
            this.TxtDesc.TabIndex = 3;
            this.TxtDesc.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDesc_Validating);
            // 
            // TxtCourseId
            // 
            this.TxtCourseId.Location = new System.Drawing.Point(565, 41);
            this.TxtCourseId.Name = "TxtCourseId";
            this.TxtCourseId.Size = new System.Drawing.Size(228, 20);
            this.TxtCourseId.TabIndex = 2;
            this.TxtCourseId.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCourseId_Validating);
            // 
            // LblDesc
            // 
            this.LblDesc.AutoSize = true;
            this.LblDesc.Location = new System.Drawing.Point(81, 102);
            this.LblDesc.Name = "LblDesc";
            this.LblDesc.Size = new System.Drawing.Size(60, 13);
            this.LblDesc.TabIndex = 1;
            this.LblDesc.Text = "Description";
            // 
            // LblCourseId
            // 
            this.LblCourseId.AutoSize = true;
            this.LblCourseId.Location = new System.Drawing.Point(81, 44);
            this.LblCourseId.Name = "LblCourseId";
            this.LblCourseId.Size = new System.Drawing.Size(52, 13);
            this.LblCourseId.TabIndex = 0;
            this.LblCourseId.Text = "Course Id";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EPEmpId
            // 
            this.EPEmpId.ContainerControl = this;
            // 
            // ErrorProv
            // 
            this.ErrorProv.ContainerControl = this;
            // 
            // EREducation
            // 
            this.EREducation.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1198, 24);
            this.menuStrip1.TabIndex = 90;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 596);
            this.Controls.Add(this.TabEmployee);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmEmployee";
            this.Text = "Employee Database";
            this.TabEmployee.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.GBoxComp.ResumeLayout(false);
            this.GBoxComp.PerformLayout();
            this.GBoxEB.ResumeLayout(false);
            this.GBoxEB.PerformLayout();
            this.GBoxBenefits.ResumeLayout(false);
            this.GBoxBenefits.PerformLayout();
            this.GBoxOT.ResumeLayout(false);
            this.GBoxOT.PerformLayout();
            this.TabSearch.ResumeLayout(false);
            this.TabSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Course.ResumeLayout(false);
            this.Course.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPEmpId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EREducation)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabEmployee;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Button BtnWrite;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Label LblBRules;
        private System.Windows.Forms.RichTextBox RtxtBRules;
        private System.Windows.Forms.TextBox TxtOther3;
        private System.Windows.Forms.Label LblOther3;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.RichTextBox RTxtInfo;
        private System.Windows.Forms.ComboBox CBXType;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtOther2;
        private System.Windows.Forms.Label LblOther2;
        private System.Windows.Forms.TextBox TxtOther;
        private System.Windows.Forms.Label LblOther;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.TabPage TabSearch;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.RadioButton RBtnOTNo;
        private System.Windows.Forms.RadioButton RBtnOTYes;
        private System.Windows.Forms.RadioButton RBtnBenefitsNo;
        private System.Windows.Forms.RadioButton RBtnBenefitsYes;
        private System.Windows.Forms.RadioButton RBtnEdNo;
        private System.Windows.Forms.RadioButton RBtnEdYes;
        private System.Windows.Forms.GroupBox GBoxComp;
        private System.Windows.Forms.RadioButton RBtnComNo;
        private System.Windows.Forms.RadioButton RBtnComYes;
        private System.Windows.Forms.GroupBox GBoxEB;
        private System.Windows.Forms.GroupBox GBoxBenefits;
        private System.Windows.Forms.GroupBox GBoxOT;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox CBXTCompe;
        private System.Windows.Forms.Label LblComp;
        private System.Windows.Forms.TextBox TxtLastSearch;
        private System.Windows.Forms.Label LblLast;
        private System.Windows.Forms.Label LblEmpId;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtIdSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RtxtBSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBtnLast;
        private System.Windows.Forms.RadioButton RBtnID;
        private System.Windows.Forms.TabPage Course;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.TextBox TxtCourseId;
        private System.Windows.Forms.Label LblDesc;
        private System.Windows.Forms.Label LblCourseId;
        private System.Windows.Forms.Label LblCredits;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblGrade;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CBoxCredits;
        private System.Windows.Forms.ComboBox CBoxGrade;
        private System.Windows.Forms.Button BtnCSave;
        private System.Windows.Forms.RichTextBox RTBoxCourse;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider EPEmpId;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.ErrorProvider ErrorProv;
        private System.Windows.Forms.ErrorProvider EREducation;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton RBtnBenefitsMarried;
        private System.Windows.Forms.RadioButton RBtnBenefitsSingle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMiddleName;
        private System.Windows.Forms.Label LblMiddleName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}