namespace Lab010
{
    partial class FrmLab10
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
            this.RTBoxInfo = new System.Windows.Forms.RichTextBox();
            this.BtnList = new System.Windows.Forms.Button();
            this.LblNType = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblSName = new System.Windows.Forms.Label();
            this.LblModel = new System.Windows.Forms.Label();
            this.BtnPFirst = new System.Windows.Forms.Button();
            this.TxtSName = new System.Windows.Forms.TextBox();
            this.TxtModel = new System.Windows.Forms.TextBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.TxtYear = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.LblCost = new System.Windows.Forms.Label();
            this.LblYear = new System.Windows.Forms.Label();
            this.DTime = new System.Windows.Forms.DateTimePicker();
            this.RBtnCNode = new System.Windows.Forms.RadioButton();
            this.RBtnSNode = new System.Windows.Forms.RadioButton();
            this.RTBoxList = new System.Windows.Forms.RichTextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnPopLast = new System.Windows.Forms.Button();
            this.BtnPopFirst = new System.Windows.Forms.Button();
            this.BtnPLast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTBoxInfo
            // 
            this.RTBoxInfo.Location = new System.Drawing.Point(6, 322);
            this.RTBoxInfo.Name = "RTBoxInfo";
            this.RTBoxInfo.Size = new System.Drawing.Size(506, 126);
            this.RTBoxInfo.TabIndex = 0;
            this.RTBoxInfo.Text = "";
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(255, 240);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(75, 23);
            this.BtnList.TabIndex = 1;
            this.BtnList.Text = "Display List";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // LblNType
            // 
            this.LblNType.AutoSize = true;
            this.LblNType.Location = new System.Drawing.Point(74, 23);
            this.LblNType.Name = "LblNType";
            this.LblNType.Size = new System.Drawing.Size(60, 13);
            this.LblNType.TabIndex = 2;
            this.LblNType.Text = "Node Type";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(74, 136);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(33, 13);
            this.LblDate.TabIndex = 3;
            this.LblDate.Text = "Date ";
            this.LblDate.Visible = false;
            // 
            // LblSName
            // 
            this.LblSName.AutoSize = true;
            this.LblSName.Location = new System.Drawing.Point(423, 77);
            this.LblSName.Name = "LblSName";
            this.LblSName.Size = new System.Drawing.Size(70, 13);
            this.LblSName.TabIndex = 4;
            this.LblSName.Text = "Supply Name";
            this.LblSName.Visible = false;
            // 
            // LblModel
            // 
            this.LblModel.AutoSize = true;
            this.LblModel.Location = new System.Drawing.Point(74, 191);
            this.LblModel.Name = "LblModel";
            this.LblModel.Size = new System.Drawing.Size(66, 13);
            this.LblModel.TabIndex = 5;
            this.LblModel.Text = "Make Model";
            this.LblModel.Visible = false;
            // 
            // BtnPFirst
            // 
            this.BtnPFirst.Location = new System.Drawing.Point(107, 240);
            this.BtnPFirst.Name = "BtnPFirst";
            this.BtnPFirst.Size = new System.Drawing.Size(75, 23);
            this.BtnPFirst.TabIndex = 7;
            this.BtnPFirst.Text = "Push First";
            this.BtnPFirst.UseVisualStyleBackColor = true;
            this.BtnPFirst.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtSName
            // 
            this.TxtSName.Location = new System.Drawing.Point(584, 74);
            this.TxtSName.Name = "TxtSName";
            this.TxtSName.Size = new System.Drawing.Size(159, 20);
            this.TxtSName.TabIndex = 9;
            this.TxtSName.Visible = false;
            // 
            // TxtModel
            // 
            this.TxtModel.Location = new System.Drawing.Point(181, 191);
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Size = new System.Drawing.Size(121, 20);
            this.TxtModel.TabIndex = 10;
            this.TxtModel.Visible = false;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(584, 12);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(159, 20);
            this.TxtDescription.TabIndex = 11;
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(181, 74);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(121, 20);
            this.TxtQuantity.TabIndex = 12;
            this.TxtQuantity.Visible = false;
            // 
            // TxtCost
            // 
            this.TxtCost.Location = new System.Drawing.Point(584, 122);
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.Size = new System.Drawing.Size(159, 20);
            this.TxtCost.TabIndex = 13;
            this.TxtCost.Visible = false;
            // 
            // TxtYear
            // 
            this.TxtYear.Location = new System.Drawing.Point(584, 174);
            this.TxtYear.Name = "TxtYear";
            this.TxtYear.Size = new System.Drawing.Size(159, 20);
            this.TxtYear.TabIndex = 14;
            this.TxtYear.Visible = false;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(423, 19);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(60, 13);
            this.LblDescription.TabIndex = 15;
            this.LblDescription.Text = "Description";
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Location = new System.Drawing.Point(74, 77);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(46, 13);
            this.LblQuantity.TabIndex = 16;
            this.LblQuantity.Text = "Quantity";
            this.LblQuantity.Visible = false;
            // 
            // LblCost
            // 
            this.LblCost.AutoSize = true;
            this.LblCost.Location = new System.Drawing.Point(424, 129);
            this.LblCost.Name = "LblCost";
            this.LblCost.Size = new System.Drawing.Size(28, 13);
            this.LblCost.TabIndex = 17;
            this.LblCost.Text = "Cost";
            this.LblCost.Visible = false;
            // 
            // LblYear
            // 
            this.LblYear.AutoSize = true;
            this.LblYear.Location = new System.Drawing.Point(424, 191);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(29, 13);
            this.LblYear.TabIndex = 18;
            this.LblYear.Text = "Year";
            this.LblYear.Visible = false;
            // 
            // DTime
            // 
            this.DTime.Location = new System.Drawing.Point(181, 129);
            this.DTime.Name = "DTime";
            this.DTime.Size = new System.Drawing.Size(200, 20);
            this.DTime.TabIndex = 19;
            this.DTime.Visible = false;
            // 
            // RBtnCNode
            // 
            this.RBtnCNode.AutoSize = true;
            this.RBtnCNode.Location = new System.Drawing.Point(181, 19);
            this.RBtnCNode.Name = "RBtnCNode";
            this.RBtnCNode.Size = new System.Drawing.Size(58, 17);
            this.RBtnCNode.TabIndex = 20;
            this.RBtnCNode.TabStop = true;
            this.RBtnCNode.Text = "CNode";
            this.RBtnCNode.UseVisualStyleBackColor = true;
            this.RBtnCNode.CheckedChanged += new System.EventHandler(this.RBtnCNode_CheckedChanged);
            // 
            // RBtnSNode
            // 
            this.RBtnSNode.AutoSize = true;
            this.RBtnSNode.Location = new System.Drawing.Point(272, 19);
            this.RBtnSNode.Name = "RBtnSNode";
            this.RBtnSNode.Size = new System.Drawing.Size(58, 17);
            this.RBtnSNode.TabIndex = 21;
            this.RBtnSNode.TabStop = true;
            this.RBtnSNode.Text = "SNode";
            this.RBtnSNode.UseVisualStyleBackColor = true;
            this.RBtnSNode.CheckedChanged += new System.EventHandler(this.RBtnSNode_CheckedChanged);
            // 
            // RTBoxList
            // 
            this.RTBoxList.Location = new System.Drawing.Point(549, 322);
            this.RTBoxList.Name = "RTBoxList";
            this.RTBoxList.Size = new System.Drawing.Size(563, 126);
            this.RTBoxList.TabIndex = 22;
            this.RTBoxList.Text = "";
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(255, 287);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 23;
            this.BtnClear.Text = "Clear list";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnPopLast
            // 
            this.BtnPopLast.Location = new System.Drawing.Point(393, 287);
            this.BtnPopLast.Name = "BtnPopLast";
            this.BtnPopLast.Size = new System.Drawing.Size(75, 23);
            this.BtnPopLast.TabIndex = 24;
            this.BtnPopLast.Text = "Pop last";
            this.BtnPopLast.UseVisualStyleBackColor = true;
            this.BtnPopLast.Click += new System.EventHandler(this.BtnPopLast_Click);
            // 
            // BtnPopFirst
            // 
            this.BtnPopFirst.Location = new System.Drawing.Point(393, 240);
            this.BtnPopFirst.Name = "BtnPopFirst";
            this.BtnPopFirst.Size = new System.Drawing.Size(75, 23);
            this.BtnPopFirst.TabIndex = 25;
            this.BtnPopFirst.Text = "Pop First";
            this.BtnPopFirst.UseVisualStyleBackColor = true;
            this.BtnPopFirst.Click += new System.EventHandler(this.BtnPopFirst_Click);
            // 
            // BtnPLast
            // 
            this.BtnPLast.Location = new System.Drawing.Point(107, 287);
            this.BtnPLast.Name = "BtnPLast";
            this.BtnPLast.Size = new System.Drawing.Size(75, 23);
            this.BtnPLast.TabIndex = 26;
            this.BtnPLast.Text = "Push Last";
            this.BtnPLast.UseVisualStyleBackColor = true;
            this.BtnPLast.Click += new System.EventHandler(this.BtnPLast_Click);
            // 
            // FrmLab10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 485);
            this.Controls.Add(this.BtnPLast);
            this.Controls.Add(this.BtnPopFirst);
            this.Controls.Add(this.BtnPopLast);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.RTBoxList);
            this.Controls.Add(this.RBtnSNode);
            this.Controls.Add(this.RBtnCNode);
            this.Controls.Add(this.DTime);
            this.Controls.Add(this.LblYear);
            this.Controls.Add(this.LblCost);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.TxtYear);
            this.Controls.Add(this.TxtCost);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.TxtModel);
            this.Controls.Add(this.TxtSName);
            this.Controls.Add(this.BtnPFirst);
            this.Controls.Add(this.LblModel);
            this.Controls.Add(this.LblSName);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblNType);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.RTBoxInfo);
            this.Name = "FrmLab10";
            this.Text = "Doubly Linked list";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBoxInfo;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Label LblNType;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblSName;
        private System.Windows.Forms.Label LblModel;
        private System.Windows.Forms.Button BtnPFirst;
        private System.Windows.Forms.TextBox TxtSName;
        private System.Windows.Forms.TextBox TxtModel;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.TextBox TxtCost;
        private System.Windows.Forms.TextBox TxtYear;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Label LblCost;
        private System.Windows.Forms.Label LblYear;
        private System.Windows.Forms.DateTimePicker DTime;
        private System.Windows.Forms.RadioButton RBtnCNode;
        private System.Windows.Forms.RadioButton RBtnSNode;
        private System.Windows.Forms.RichTextBox RTBoxList;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnPopLast;
        private System.Windows.Forms.Button BtnPopFirst;
        private System.Windows.Forms.Button BtnPLast;
    }
}

