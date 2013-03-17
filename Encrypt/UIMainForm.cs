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
            uiCryptTextBox.Text = Caesar.Encrypt(uiCryptTextBox.Text.Trim(), Convert.ToInt32(uiShiftTextBox.Text));
        }

        private void uiDecryptButton_Click(object sender, EventArgs e)
        {
            uiCryptTextBox.Text = Caesar.Decrypt(uiCryptTextBox.Text.Trim(), Convert.ToInt32(uiShiftTextBox.Text));
        }

        public int GetShift()
        {
            return Convert.ToInt32(uiShiftTextBox.Text);
        }
    }
}
