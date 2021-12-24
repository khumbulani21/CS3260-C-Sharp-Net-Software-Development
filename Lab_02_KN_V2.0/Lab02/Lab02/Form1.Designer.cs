namespace Lab02
{
    partial class FrmMain
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LblNum1 = new System.Windows.Forms.Label();
            this.LblNum2 = new System.Windows.Forms.Label();
            this.TxtReal1 = new System.Windows.Forms.TextBox();
            this.TxtImg1 = new System.Windows.Forms.TextBox();
            this.BtnSubtract = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.TxtReal2 = new System.Windows.Forms.TextBox();
            this.TxtImg2 = new System.Windows.Forms.TextBox();
            this.LblPlus = new System.Windows.Forms.Label();
            this.LblPlus2 = new System.Windows.Forms.Label();
            this.LblInfo = new System.Windows.Forms.Label();
            this.i = new System.Windows.Forms.Label();
            this.Lbli = new System.Windows.Forms.Label();
            this.LblAnswer = new System.Windows.Forms.Label();
            this.TxtBxAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(130, 316);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(86, 76);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblNum1
            // 
            this.LblNum1.AutoSize = true;
            this.LblNum1.Location = new System.Drawing.Point(85, 66);
            this.LblNum1.Name = "LblNum1";
            this.LblNum1.Size = new System.Drawing.Size(94, 13);
            this.LblNum1.TabIndex = 1;
            this.LblNum1.Text = "Complex number 1";
            // 
            // LblNum2
            // 
            this.LblNum2.AutoSize = true;
            this.LblNum2.Location = new System.Drawing.Point(85, 188);
            this.LblNum2.Name = "LblNum2";
            this.LblNum2.Size = new System.Drawing.Size(94, 13);
            this.LblNum2.TabIndex = 2;
            this.LblNum2.Text = "Complex number 2";
            // 
            // TxtReal1
            // 
            this.TxtReal1.Location = new System.Drawing.Point(257, 66);
            this.TxtReal1.Name = "TxtReal1";
            this.TxtReal1.Size = new System.Drawing.Size(115, 20);
            this.TxtReal1.TabIndex = 3;
            this.TxtReal1.TextChanged += new System.EventHandler(this.TxtReal1_TextChanged);
            // 
            // TxtImg1
            // 
            this.TxtImg1.Location = new System.Drawing.Point(408, 66);
            this.TxtImg1.Name = "TxtImg1";
            this.TxtImg1.Size = new System.Drawing.Size(108, 20);
            this.TxtImg1.TabIndex = 4;
            // 
            // BtnSubtract
            // 
            this.BtnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubtract.Location = new System.Drawing.Point(244, 316);
            this.BtnSubtract.Name = "BtnSubtract";
            this.BtnSubtract.Size = new System.Drawing.Size(86, 76);
            this.BtnSubtract.TabIndex = 5;
            this.BtnSubtract.Text = "-";
            this.BtnSubtract.UseVisualStyleBackColor = true;
            this.BtnSubtract.Click += new System.EventHandler(this.BtnSubtract_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiply.Location = new System.Drawing.Point(363, 316);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(86, 76);
            this.BtnMultiply.TabIndex = 6;
            this.BtnMultiply.Text = "*";
            this.BtnMultiply.UseVisualStyleBackColor = true;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivide.Location = new System.Drawing.Point(483, 316);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(86, 76);
            this.BtnDivide.TabIndex = 7;
            this.BtnDivide.Text = "/";
            this.BtnDivide.UseVisualStyleBackColor = true;
            this.BtnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // TxtReal2
            // 
            this.TxtReal2.Location = new System.Drawing.Point(257, 185);
            this.TxtReal2.Name = "TxtReal2";
            this.TxtReal2.Size = new System.Drawing.Size(115, 20);
            this.TxtReal2.TabIndex = 8;
            // 
            // TxtImg2
            // 
            this.TxtImg2.Location = new System.Drawing.Point(408, 185);
            this.TxtImg2.Name = "TxtImg2";
            this.TxtImg2.Size = new System.Drawing.Size(108, 20);
            this.TxtImg2.TabIndex = 9;
            // 
            // LblPlus
            // 
            this.LblPlus.AutoSize = true;
            this.LblPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlus.Location = new System.Drawing.Point(378, 66);
            this.LblPlus.Name = "LblPlus";
            this.LblPlus.Size = new System.Drawing.Size(24, 25);
            this.LblPlus.TabIndex = 11;
            this.LblPlus.Text = "+";
            // 
            // LblPlus2
            // 
            this.LblPlus2.AutoSize = true;
            this.LblPlus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlus2.Location = new System.Drawing.Point(378, 185);
            this.LblPlus2.Name = "LblPlus2";
            this.LblPlus2.Size = new System.Drawing.Size(24, 25);
            this.LblPlus2.TabIndex = 12;
            this.LblPlus2.Text = "+";
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(351, 35);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(85, 13);
            this.LblInfo.TabIndex = 13;
            this.LblInfo.Text = "Real + imaginery";
            // 
            // i
            // 
            this.i.AutoSize = true;
            this.i.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i.Location = new System.Drawing.Point(522, 66);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(17, 25);
            this.i.TabIndex = 14;
            this.i.Text = "i";
            // 
            // Lbli
            // 
            this.Lbli.AutoSize = true;
            this.Lbli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbli.Location = new System.Drawing.Point(522, 180);
            this.Lbli.Name = "Lbli";
            this.Lbli.Size = new System.Drawing.Size(17, 25);
            this.Lbli.TabIndex = 15;
            this.Lbli.Text = "i";
            // 
            // LblAnswer
            // 
            this.LblAnswer.AutoSize = true;
            this.LblAnswer.Location = new System.Drawing.Point(85, 262);
            this.LblAnswer.Name = "LblAnswer";
            this.LblAnswer.Size = new System.Drawing.Size(42, 13);
            this.LblAnswer.TabIndex = 16;
            this.LblAnswer.Text = "Answer";
            // 
            // TxtBxAnswer
            // 
            this.TxtBxAnswer.Location = new System.Drawing.Point(257, 255);
            this.TxtBxAnswer.Name = "TxtBxAnswer";
            this.TxtBxAnswer.Size = new System.Drawing.Size(259, 20);
            this.TxtBxAnswer.TabIndex = 17;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 439);
            this.Controls.Add(this.TxtBxAnswer);
            this.Controls.Add(this.LblAnswer);
            this.Controls.Add(this.Lbli);
            this.Controls.Add(this.i);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.LblPlus2);
            this.Controls.Add(this.LblPlus);
            this.Controls.Add(this.TxtImg2);
            this.Controls.Add(this.TxtReal2);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.BtnSubtract);
            this.Controls.Add(this.TxtImg1);
            this.Controls.Add(this.TxtReal1);
            this.Controls.Add(this.LblNum2);
            this.Controls.Add(this.LblNum1);
            this.Controls.Add(this.BtnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmMain";
            this.Text = "Complex Number calculator";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label LblNum1;
        private System.Windows.Forms.Label LblNum2;
        private System.Windows.Forms.TextBox TxtReal1;
        private System.Windows.Forms.TextBox TxtImg1;
        private System.Windows.Forms.Button BtnSubtract;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.TextBox TxtReal2;
        private System.Windows.Forms.TextBox TxtImg2;
        private System.Windows.Forms.Label LblPlus;
        private System.Windows.Forms.Label LblPlus2;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Label i;
        private System.Windows.Forms.Label Lbli;
        private System.Windows.Forms.Label LblAnswer;
        private System.Windows.Forms.TextBox TxtBxAnswer;
    }
}

