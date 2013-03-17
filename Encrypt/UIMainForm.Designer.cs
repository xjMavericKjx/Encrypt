namespace Encrypt
{
    partial class UIMainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiEncryptButton = new System.Windows.Forms.Button();
            this.uiDecryptButton = new System.Windows.Forms.Button();
            this.uiCryptTextBox = new System.Windows.Forms.TextBox();
            this.uiShiftTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uiEncryptButton
            // 
            this.uiEncryptButton.Location = new System.Drawing.Point(12, 38);
            this.uiEncryptButton.Name = "uiEncryptButton";
            this.uiEncryptButton.Size = new System.Drawing.Size(214, 23);
            this.uiEncryptButton.TabIndex = 0;
            this.uiEncryptButton.Text = "Шифровать";
            this.uiEncryptButton.UseVisualStyleBackColor = true;
            this.uiEncryptButton.Click += new System.EventHandler(this.uiEncryptButton_Click);
            // 
            // uiDecryptButton
            // 
            this.uiDecryptButton.Location = new System.Drawing.Point(12, 68);
            this.uiDecryptButton.Name = "uiDecryptButton";
            this.uiDecryptButton.Size = new System.Drawing.Size(214, 23);
            this.uiDecryptButton.TabIndex = 1;
            this.uiDecryptButton.Text = "Расшифровать";
            this.uiDecryptButton.UseVisualStyleBackColor = true;
            this.uiDecryptButton.Click += new System.EventHandler(this.uiDecryptButton_Click);
            // 
            // uiCryptTextBox
            // 
            this.uiCryptTextBox.Location = new System.Drawing.Point(12, 12);
            this.uiCryptTextBox.Name = "uiCryptTextBox";
            this.uiCryptTextBox.Size = new System.Drawing.Size(175, 20);
            this.uiCryptTextBox.TabIndex = 2;
            // 
            // uiShiftTextBox
            // 
            this.uiShiftTextBox.Location = new System.Drawing.Point(194, 12);
            this.uiShiftTextBox.Name = "uiShiftTextBox";
            this.uiShiftTextBox.Size = new System.Drawing.Size(32, 20);
            this.uiShiftTextBox.TabIndex = 3;
            this.uiShiftTextBox.Text = "2";
            // 
            // UIMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 102);
            this.Controls.Add(this.uiShiftTextBox);
            this.Controls.Add(this.uiCryptTextBox);
            this.Controls.Add(this.uiDecryptButton);
            this.Controls.Add(this.uiEncryptButton);
            this.Name = "UIMainForm";
            this.Text = "Шифрование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiEncryptButton;
        private System.Windows.Forms.Button uiDecryptButton;
        private System.Windows.Forms.TextBox uiCryptTextBox;
        private System.Windows.Forms.TextBox uiShiftTextBox;
    }
}

