namespace MobChecker.Forms
{
    partial class Settings
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstLevel = new System.Windows.Forms.NumericUpDown();
            this.SecondLevel = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ThirdLevel = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.FourthLevel = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.FifthLevel = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalPoints = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FirstLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FifthLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "1 Уровень";
            // 
            // FirstLevel
            // 
            this.FirstLevel.Location = new System.Drawing.Point(95, 18);
            this.FirstLevel.Name = "FirstLevel";
            this.FirstLevel.Size = new System.Drawing.Size(45, 20);
            this.FirstLevel.TabIndex = 0;
            // 
            // SecondLevel
            // 
            this.SecondLevel.Location = new System.Drawing.Point(95, 53);
            this.SecondLevel.Name = "SecondLevel";
            this.SecondLevel.Size = new System.Drawing.Size(45, 20);
            this.SecondLevel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "2 Уровень";
            // 
            // ThirdLevel
            // 
            this.ThirdLevel.Location = new System.Drawing.Point(95, 92);
            this.ThirdLevel.Name = "ThirdLevel";
            this.ThirdLevel.Size = new System.Drawing.Size(45, 20);
            this.ThirdLevel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "3 Уровень";
            // 
            // FourthLevel
            // 
            this.FourthLevel.Location = new System.Drawing.Point(95, 133);
            this.FourthLevel.Name = "FourthLevel";
            this.FourthLevel.Size = new System.Drawing.Size(45, 20);
            this.FourthLevel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "4 Уровень";
            // 
            // FifthLevel
            // 
            this.FifthLevel.Location = new System.Drawing.Point(95, 174);
            this.FifthLevel.Name = "FifthLevel";
            this.FifthLevel.Size = new System.Drawing.Size(45, 20);
            this.FifthLevel.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "5 Уровень";
            // 
            // TotalPoints
            // 
            this.TotalPoints.Location = new System.Drawing.Point(95, 212);
            this.TotalPoints.Name = "TotalPoints";
            this.TotalPoints.Size = new System.Drawing.Size(45, 20);
            this.TotalPoints.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Всего очков";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 297);
            this.ControlBox = false;
            this.Controls.Add(this.TotalPoints);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FifthLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FourthLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ThirdLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SecondLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FirstLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FifthLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown FirstLevel;
        private System.Windows.Forms.NumericUpDown SecondLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ThirdLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown FourthLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown FifthLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown TotalPoints;
        private System.Windows.Forms.Label label6;
    }
}