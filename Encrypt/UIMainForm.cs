using System;
using System.Windows.Forms;

namespace Encrypt
{
    public partial class UIMainForm : Form
    {
        public UIMainForm()
        {
            InitializeComponent();
        }
        
        private void uiEncryptButton_Click(object sender, EventArgs e)
        {
            uiCaesarCryptTextBox.Text = Caesar.Encrypt(uiCaesarCryptTextBox.Text.Trim(), Convert.ToInt32(uiCaesarShiftTextBox.Text));
        }

        private void uiDecryptButton_Click(object sender, EventArgs e)
        {
            uiCaesarCryptTextBox.Text = Caesar.Decrypt(uiCaesarCryptTextBox.Text.Trim(), Convert.ToInt32(uiCaesarShiftTextBox.Text));
        }

        public int GetShift()
        {
            return Convert.ToInt32(uiCaesarShiftTextBox.Text);
        }

        private void uiVijinerEncryptButton_Click(object sender, EventArgs e)
        {
            uiVijinerCryptTextBox.Text = Vijiner.Encrypt(uiVijinerCryptTextBox.Text.Trim(),
                                                         uiVijinerShiftTextBox.Text.Trim());
        }

        private void uiVijinerDecryptButton_Click(object sender, EventArgs e)
        {
            uiVijinerCryptTextBox.Text = Vijiner.Decrypt(uiVijinerCryptTextBox.Text.Trim(),
                                                         uiVijinerShiftTextBox.Text.Trim());
        }
    }
}
