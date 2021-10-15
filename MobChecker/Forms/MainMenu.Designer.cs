
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
            this.UploadButton.Location = new System.Drawing.Point(896, 1014);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(400, 42);
            this.UploadButton.TabIndex = 0;
            this.UploadButton.Text = "Загрузить";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // btnGetFailures
            // 
            this.btnGetFailures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetFailures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetFailures.Location = new System.Drawing.Point(12, 1014);
            this.btnGetFailures.Name = "btnGetFailures";
            this.btnGetFailures.Size = new System.Drawing.Size(400, 42);
            this.btnGetFailures.TabIndex = 1;
            this.btnGetFailures.Text = "Косячники";
            this.btnGetFailures.UseVisualStyleBackColor = true;
            this.btnGetFailures.Click += new System.EventHandler(this.btnGetFailures_Click);
            // 
            // rtbFailures
            // 
            this.rtbFailures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbFailures.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbFailures.Location = new System.Drawing.Point(12, 12);
            this.rtbFailures.Name = "rtbFailures";
            this.rtbFailures.Size = new System.Drawing.Size(1284, 996);
            this.rtbFailures.TabIndex = 2;
            this.rtbFailures.Text = "";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 1068);
            this.Controls.Add(this.rtbFailures);
            this.Controls.Add(this.btnGetFailures);
            this.Controls.Add(this.UploadButton);
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
    }
}

