
namespace MobChecker
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofdUpload = new System.Windows.Forms.OpenFileDialog();
            this.UploadButton = new System.Windows.Forms.Button();
            this.btnGetFailures = new System.Windows.Forms.Button();
            this.rtbFailures = new System.Windows.Forms.RichTextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdUpload
            // 
            this.ofdUpload.Filter = "|*.csv";
            this.ofdUpload.Multiselect = true;
            // 
            // UploadButton
            // 
            this.UploadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UploadButton.Location = new System.Drawing.Point(597, 659);
            this.UploadButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(267, 27);
            this.UploadButton.TabIndex = 0;
            this.UploadButton.Text = "Загрузить";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // btnGetFailures
            // 
            this.btnGetFailures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetFailures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetFailures.Location = new System.Drawing.Point(11, 659);
            this.btnGetFailures.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetFailures.Name = "btnGetFailures";
            this.btnGetFailures.Size = new System.Drawing.Size(267, 27);
            this.btnGetFailures.TabIndex = 1;
            this.btnGetFailures.Text = "Настройки";
            this.btnGetFailures.UseVisualStyleBackColor = true;
            this.btnGetFailures.Click += new System.EventHandler(this.btnGetFailures_Click);
            // 
            // rtbFailures
            // 
            this.rtbFailures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbFailures.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbFailures.Location = new System.Drawing.Point(8, 8);
            this.rtbFailures.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbFailures.Name = "rtbFailures";
            this.rtbFailures.Size = new System.Drawing.Size(857, 649);
            this.rtbFailures.TabIndex = 2;
            this.rtbFailures.Text = "";
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExcel.Location = new System.Drawing.Point(305, 659);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(267, 27);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 694);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.rtbFailures);
            this.Controls.Add(this.btnGetFailures);
            this.Controls.Add(this.UploadButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdUpload;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Button btnGetFailures;
        private System.Windows.Forms.RichTextBox rtbFailures;
        private System.Windows.Forms.Button btnExcel;
    }
}

