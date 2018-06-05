namespace KingFood
{
    partial class UserInfoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbBmi = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBmi = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdvise = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "User name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 100);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(254, 28);
            this.textBox1.TabIndex = 2;
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(198, 177);
            this.lbAge.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(0, 24);
            this.lbAge.TabIndex = 3;
            this.lbAge.TextChanged += new System.EventHandler(this.lbAge_TextChanged);
            // 
            // lbBmi
            // 
            this.lbBmi.AutoSize = true;
            this.lbBmi.Location = new System.Drawing.Point(492, 179);
            this.lbBmi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbBmi.Name = "lbBmi";
            this.lbBmi.Size = new System.Drawing.Size(0, 24);
            this.lbBmi.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(69, 481);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(170, 38);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "CALCULATE BMI";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(184, 254);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(268, 28);
            this.txtHeight.TabIndex = 6;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(184, 333);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(268, 28);
            this.txtWeight.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Weight";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(58, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(455, 50);
            this.label5.TabIndex = 10;
            this.label5.Text = "USER INFORAMATION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 404);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Current BMI";
            // 
            // txtBmi
            // 
            this.txtBmi.Location = new System.Drawing.Point(184, 397);
            this.txtBmi.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBmi.Name = "txtBmi";
            this.txtBmi.ReadOnly = true;
            this.txtBmi.Size = new System.Drawing.Size(150, 28);
            this.txtBmi.TabIndex = 12;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(282, 481);
            this.btnReload.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(170, 38);
            this.btnReload.TabIndex = 13;
            this.btnReload.Text = "RELOAD";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAdvise
            // 
            this.btnAdvise.Location = new System.Drawing.Point(342, 397);
            this.btnAdvise.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAdvise.Name = "btnAdvise";
            this.btnAdvise.Size = new System.Drawing.Size(110, 37);
            this.btnAdvise.TabIndex = 14;
            this.btnAdvise.Text = "ADVISE";
            this.btnAdvise.UseVisualStyleBackColor = true;
            this.btnAdvise.Click += new System.EventHandler(this.btnAdvise_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(28, 565);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 24);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 598);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnAdvise);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.txtBmi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbBmi);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UserInfoForm";
            this.Text = "User Information";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbBmi;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBmi;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdvise;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}