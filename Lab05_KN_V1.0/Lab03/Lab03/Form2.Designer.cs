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
            this.LblID = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.LblSurname = new System.Windows.Forms.Label();
            this.LblOther = new System.Windows.Forms.Label();
            this.TxtOther = new System.Windows.Forms.TextBox();
            this.LblOther2 = new System.Windows.Forms.Label();
            this.TxtOther2 = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CBXType = new System.Windows.Forms.ComboBox();
            this.RTxtInfo = new System.Windows.Forms.RichTextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.LblOther3 = new System.Windows.Forms.Label();
            this.TxtOther3 = new System.Windows.Forms.TextBox();
            this.RtxtBRules = new System.Windows.Forms.RichTextBox();
            this.LblBRules = new System.Windows.Forms.Label();
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(452, 35);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(67, 13);
            this.LblID.TabIndex = 0;
            this.LblID.Text = "Employee ID";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(41, 27);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(80, 13);
            this.LblType.TabIndex = 1;
            this.LblType.Text = "Employee Type";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(41, 88);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(57, 13);
            this.LblFirstName.TabIndex = 2;
            this.LblFirstName.Text = "First Name";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(544, 35);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(154, 20);
            this.TxtID.TabIndex = 3;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(219, 88);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(165, 20);
            this.TxtName.TabIndex = 5;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(548, 95);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(150, 20);
            this.TxtSurname.TabIndex = 6;
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Location = new System.Drawing.Point(452, 95);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(58, 13);
            this.LblSurname.TabIndex = 7;
            this.LblSurname.Text = "Last Name";
            // 
            // LblOther
            // 
            this.LblOther.AutoSize = true;
            this.LblOther.Location = new System.Drawing.Point(41, 147);
            this.LblOther.Name = "LblOther";
            this.LblOther.Size = new System.Drawing.Size(33, 13);
            this.LblOther.TabIndex = 8;
            this.LblOther.Text = "Other";
            this.LblOther.Visible = false;
            // 
            // TxtOther
            // 
            this.TxtOther.Location = new System.Drawing.Point(219, 140);
            this.TxtOther.Name = "TxtOther";
            this.TxtOther.Size = new System.Drawing.Size(165, 20);
            this.TxtOther.TabIndex = 9;
            this.TxtOther.Visible = false;
            // 
            // LblOther2
            // 
            this.LblOther2.AutoSize = true;
            this.LblOther2.Location = new System.Drawing.Point(452, 140);
            this.LblOther2.Name = "LblOther2";
            this.LblOther2.Size = new System.Drawing.Size(42, 13);
            this.LblOther2.TabIndex = 10;
            this.LblOther2.Text = "Other 2";
            this.LblOther2.Visible = false;
            // 
            // TxtOther2
            // 
            this.TxtOther2.Location = new System.Drawing.Point(544, 144);
            this.TxtOther2.Name = "TxtOther2";
            this.TxtOther2.Size = new System.Drawing.Size(150, 20);
            this.TxtOther2.TabIndex = 11;
            this.TxtOther2.Visible = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(455, 249);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(155, 29);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "Save employee";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // CBXType
            // 
            this.CBXType.FormattingEnabled = true;
            this.CBXType.Items.AddRange(new object[] {
            "Hourly",
            "Salary",
            "Contract",
            "Sales"});
            this.CBXType.Location = new System.Drawing.Point(219, 27);
            this.CBXType.Name = "CBXType";
            this.CBXType.Size = new System.Drawing.Size(165, 21);
            this.CBXType.TabIndex = 14;
            this.CBXType.SelectedIndexChanged += new System.EventHandler(this.CBXType_SelectedIndexChanged);
            // 
            // RTxtInfo
            // 
            this.RTxtInfo.Location = new System.Drawing.Point(455, 313);
            this.RTxtInfo.Name = "RTxtInfo";
            this.RTxtInfo.Size = new System.Drawing.Size(421, 127);
            this.RTxtInfo.TabIndex = 15;
            this.RTxtInfo.Text = "";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(659, 287);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(132, 13);
            this.lblInfo.TabIndex = 16;
            this.lblInfo.Text = "New employee Information";
            // 
            // LblOther3
            // 
            this.LblOther3.AutoSize = true;
            this.LblOther3.Location = new System.Drawing.Point(41, 197);
            this.LblOther3.Name = "LblOther3";
            this.LblOther3.Size = new System.Drawing.Size(42, 13);
            this.LblOther3.TabIndex = 17;
            this.LblOther3.Text = "Other 3";
            this.LblOther3.Visible = false;
            // 
            // TxtOther3
            // 
            this.TxtOther3.Location = new System.Drawing.Point(219, 199);
            this.TxtOther3.Name = "TxtOther3";
            this.TxtOther3.Size = new System.Drawing.Size(165, 20);
            this.TxtOther3.TabIndex = 18;
            this.TxtOther3.Visible = false;
            // 
            // RtxtBRules
            // 
            this.RtxtBRules.Location = new System.Drawing.Point(44, 313);
            this.RtxtBRules.Name = "RtxtBRules";
            this.RtxtBRules.Size = new System.Drawing.Size(388, 127);
            this.RtxtBRules.TabIndex = 19;
            this.RtxtBRules.Text = "";
            // 
            // LblBRules
            // 
            this.LblBRules.AutoSize = true;
            this.LblBRules.Location = new System.Drawing.Point(162, 287);
            this.LblBRules.Name = "LblBRules";
            this.LblBRules.Size = new System.Drawing.Size(89, 13);
            this.LblBRules.TabIndex = 20;
            this.LblBRules.Text = "Business rules list";
            // 
            // BtnView
            // 
            this.BtnView.Location = new System.Drawing.Point(309, 249);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(75, 29);
            this.BtnView.TabIndex = 21;
            this.BtnView.Text = "View list";
            this.BtnView.UseVisualStyleBackColor = true;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(703, 255);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 22;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 478);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnView);
            this.Controls.Add(this.LblBRules);
            this.Controls.Add(this.RtxtBRules);
            this.Controls.Add(this.TxtOther3);
            this.Controls.Add(this.LblOther3);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.RTxtInfo);
            this.Controls.Add(this.CBXType);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtOther2);
            this.Controls.Add(this.LblOther2);
            this.Controls.Add(this.TxtOther);
            this.Controls.Add(this.LblOther);
            this.Controls.Add(this.LblSurname);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.LblFirstName);
            this.Controls.Add(this.LblType);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmEmployee";
            this.Text = "Employee Database";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.Label LblOther;
        private System.Windows.Forms.TextBox TxtOther;
        private System.Windows.Forms.Label LblOther2;
        private System.Windows.Forms.TextBox TxtOther2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox CBXType;
        private System.Windows.Forms.RichTextBox RTxtInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label LblOther3;
        private System.Windows.Forms.TextBox TxtOther3;
        private System.Windows.Forms.RichTextBox RtxtBRules;
        private System.Windows.Forms.Label LblBRules;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Button BtnClear;
    }
}