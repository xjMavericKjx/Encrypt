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
            this.uiCaesarEncryptButton = new System.Windows.Forms.Button();
            this.uiCaesarDecryptButton = new System.Windows.Forms.Button();
            this.uiCaesarCryptTextBox = new System.Windows.Forms.TextBox();
            this.uiCaesarShiftTextBox = new System.Windows.Forms.TextBox();
            this.uiVijinerShiftTextBox = new System.Windows.Forms.TextBox();
            this.uiVijinerCryptTextBox = new System.Windows.Forms.TextBox();
            this.uiVijinerDecryptButton = new System.Windows.Forms.Button();
            this.uiVijinerEncryptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiCaesarEncryptButton
            // 
            this.uiCaesarEncryptButton.Location = new System.Drawing.Point(12, 38);
            this.uiCaesarEncryptButton.Name = "uiCaesarEncryptButton";
            this.uiCaesarEncryptButton.Size = new System.Drawing.Size(214, 23);
            this.uiCaesarEncryptButton.TabIndex = 0;
            this.uiCaesarEncryptButton.Text = "Шифровать";
            this.uiCaesarEncryptButton.UseVisualStyleBackColor = true;
            this.uiCaesarEncryptButton.Click += new System.EventHandler(this.uiEncryptButton_Click);
            // 
            // uiCaesarDecryptButton
            // 
            this.uiCaesarDecryptButton.Location = new System.Drawing.Point(12, 68);
            this.uiCaesarDecryptButton.Name = "uiCaesarDecryptButton";
            this.uiCaesarDecryptButton.Size = new System.Drawing.Size(214, 23);
            this.uiCaesarDecryptButton.TabIndex = 1;
            this.uiCaesarDecryptButton.Text = "Расшифровать";
            this.uiCaesarDecryptButton.UseVisualStyleBackColor = true;
            this.uiCaesarDecryptButton.Click += new System.EventHandler(this.uiDecryptButton_Click);
            // 
            // uiCaesarCryptTextBox
            // 
            this.uiCaesarCryptTextBox.Location = new System.Drawing.Point(12, 12);
            this.uiCaesarCryptTextBox.Name = "uiCaesarCryptTextBox";
            this.uiCaesarCryptTextBox.Size = new System.Drawing.Size(175, 20);
            this.uiCaesarCryptTextBox.TabIndex = 2;
            // 
            // uiCaesarShiftTextBox
            // 
            this.uiCaesarShiftTextBox.Location = new System.Drawing.Point(210, 12);
            this.uiCaesarShiftTextBox.Name = "uiCaesarShiftTextBox";
            this.uiCaesarShiftTextBox.Size = new System.Drawing.Size(32, 20);
            this.uiCaesarShiftTextBox.TabIndex = 3;
            this.uiCaesarShiftTextBox.Text = "3";
            // 
            // uiVijinerShiftTextBox
            // 
            this.uiVijinerShiftTextBox.Location = new System.Drawing.Point(413, 12);
            this.uiVijinerShiftTextBox.Name = "uiVijinerShiftTextBox";
            this.uiVijinerShiftTextBox.Size = new System.Drawing.Size(58, 20);
            this.uiVijinerShiftTextBox.TabIndex = 7;
            // 
            // uiVijinerCryptTextBox
            // 
            this.uiVijinerCryptTextBox.Location = new System.Drawing.Point(258, 12);
            this.uiVijinerCryptTextBox.Name = "uiVijinerCryptTextBox";
            this.uiVijinerCryptTextBox.Size = new System.Drawing.Size(149, 20);
            this.uiVijinerCryptTextBox.TabIndex = 6;
            // 
            // uiVijinerDecryptButton
            // 
            this.uiVijinerDecryptButton.Location = new System.Drawing.Point(257, 68);
            this.uiVijinerDecryptButton.Name = "uiVijinerDecryptButton";
            this.uiVijinerDecryptButton.Size = new System.Drawing.Size(214, 23);
            this.uiVijinerDecryptButton.TabIndex = 5;
            this.uiVijinerDecryptButton.Text = "Расшифровать";
            this.uiVijinerDecryptButton.UseVisualStyleBackColor = true;
            this.uiVijinerDecryptButton.Click += new System.EventHandler(this.uiVijinerDecryptButton_Click);
            // 
            // uiVijinerEncryptButton
            // 
            this.uiVijinerEncryptButton.Location = new System.Drawing.Point(257, 38);
            this.uiVijinerEncryptButton.Name = "uiVijinerEncryptButton";
            this.uiVijinerEncryptButton.Size = new System.Drawing.Size(214, 23);
            this.uiVijinerEncryptButton.TabIndex = 4;
            this.uiVijinerEncryptButton.Text = "Шифровать";
            this.uiVijinerEncryptButton.UseVisualStyleBackColor = true;
            this.uiVijinerEncryptButton.Click += new System.EventHandler(this.uiVijinerEncryptButton_Click);
            // 
            // UIMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 102);
            this.Controls.Add(this.uiVijinerShiftTextBox);
            this.Controls.Add(this.uiVijinerCryptTextBox);
            this.Controls.Add(this.uiVijinerDecryptButton);
            this.Controls.Add(this.uiVijinerEncryptButton);
            this.Controls.Add(this.uiCaesarShiftTextBox);
            this.Controls.Add(this.uiCaesarCryptTextBox);
            this.Controls.Add(this.uiCaesarDecryptButton);
            this.Controls.Add(this.uiCaesarEncryptButton);
            this.Name = "UIMainForm";
            this.Text = "Шифрование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiCaesarEncryptButton;
        private System.Windows.Forms.Button uiCaesarDecryptButton;
        private System.Windows.Forms.TextBox uiCaesarCryptTextBox;
        private System.Windows.Forms.TextBox uiCaesarShiftTextBox;
        private System.Windows.Forms.TextBox uiVijinerShiftTextBox;
        private System.Windows.Forms.TextBox uiVijinerCryptTextBox;
        private System.Windows.Forms.Button uiVijinerDecryptButton;
        private System.Windows.Forms.Button uiVijinerEncryptButton;
    }
}

