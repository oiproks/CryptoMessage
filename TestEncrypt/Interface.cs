using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CryptoMessage
{
    public partial class Interface : Form
    {
        #region Global Variables
        const string FILENAME = "\\CryptoKey.ckf";
        AesManaged aes;
        string keyString, ivString, keyName;
        ToolTip tip = new ToolTip();
        bool mouseDown = false;
        Point lastLocation;
        #endregion

        public Interface()
        {
            InitializeComponent();
        }

        #region Form Management
        private void Interface_Load(object sender, EventArgs e)
        {
            aes = new AesManaged();
        }

        private void Interface_Shown(object sender, EventArgs e)
        {
            loadAESfromConfig();
        }

        private void Interface_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Interface_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void Interface_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void txtEncrypted_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Return)
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Tag.Equals("decrypted"))
                    btnEncrypt_Click(sender, e);
                else
                    btnDecrypt_Click(sender, e);
            }
        }

        private void DisplayAES()
        {
            txtKeyName.Text = keyName;
            txtKeyValue.Text = keyString;
            foreach (Control control in Controls)
            {
                if (!control.Enabled)
                    control.Enabled = true;
            }
        }
        #endregion

        #region Config Management
        private void loadAESfromConfig()
        {
            keyString = Properties.Settings.Default.KEY;
            ivString = Properties.Settings.Default.IV;
            if (string.IsNullOrEmpty(keyString) || string.IsNullOrEmpty(ivString))
            {
                keyString = Convert.ToBase64String(aes.Key);
                ivString = Convert.ToBase64String(aes.IV);
                Properties.Settings.Default.KEY = keyString;
                Properties.Settings.Default.IV = ivString;
                Properties.Settings.Default.Save();
            } else
            {
                ShowMessage("Local key loaded", 35);
            }
            keyName = "Local Key";
            DisplayAES();
        }
        #endregion

        #region Buttons Click Management
        private void btnReloadKey_click(object sender, EventArgs e)
        {
            loadAESfromConfig();
        }

        private void btnNewKey_click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("This is going to overwrite your previous local key.", "Warning",
                                 MessageBoxButtons.OKCancel,
                                 MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                aes = new AesManaged();
                keyString = Convert.ToBase64String(aes.Key);
                ivString = Convert.ToBase64String(aes.IV);
                Properties.Settings.Default.KEY = keyString;
                Properties.Settings.Default.IV = ivString;
                Properties.Settings.Default.Save();
            }
            keyName = "Local Key";
            DisplayAES();
        }

        private void btnExportKey_Click(object sender, EventArgs e)
        {
            var folder = new FolderBrowserDialog();
            DialogResult result = folder.ShowDialog();
            if (result == DialogResult.OK)
            {
                string exportedKeyName = string.Empty;
                if (InputBox.InputBoxA("Exported Key", "Provide key name:", ref exportedKeyName) == DialogResult.OK)
                {
                    string filePath = folder.SelectedPath + FILENAME;
                    string keyValue = string.Concat(new[] { exportedKeyName, "####", keyString, "####", ivString });
                    File.WriteAllText(filePath, EncodeDecode.Encode(keyValue, Properties.Resources.password));
                }                
            }
        }

        private void btnImportKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter =
               "ckf files (*.ckf)|*.ckf";
            dialog.InitialDirectory = "C:\\";
            dialog.Title = "Select the file containing key";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string encryptedstring = File.ReadAllText(dialog.FileName);
                string decryptedstring = EncodeDecode.Decode(encryptedstring, Properties.Resources.password);
                string[] keyValues = decryptedstring.Split(new string[] { "####" }, StringSplitOptions.None);
                keyName = keyValues[0];
                keyString = keyValues[1];
                ivString = keyValues[2];
                DisplayAES();
            }
            
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (txtDecrypted.TextLength > 0)
            {
                byte[] encrypted = EncryptDecrypt.Encrypt(txtDecrypted.Text.ToString(),
                                            Convert.FromBase64String(keyString),
                                            Convert.FromBase64String(ivString));
                txtEncrypted.Text = Convert.ToBase64String(encrypted);

                Clipboard.SetText(txtEncrypted.Text);
                Point p = btnClear.Location;
                ShowMessage("Encrypted text copied on the clipboard", 80);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (txtEncrypted.TextLength > 0)
            {
                byte[] utf8Bytes = Encoding.UTF8.GetBytes(txtEncrypted.Text);
                string decrypted = EncryptDecrypt.Decrypt(Convert.FromBase64String(txtEncrypted.Text),
                                            Convert.FromBase64String(keyString),
                                            Convert.FromBase64String(ivString));
                txtDecrypted.Text = decrypted;

                Clipboard.SetText(decrypted);
                Point p = btnClear.Location;
                ShowMessage("Decrypted text copied on the clipboard", 80);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEncrypted.Clear();
            txtDecrypted.Clear();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOnTop_click(object sender, EventArgs e)
        {
            string text;
            int textWidth = 0;
            Point p = btnClear.Location;
            if (TopMost)
            {
                TopMost = false;
                text = "Window won't stay on top anymore";
                textWidth = 70;
            }
            else
            {
                TopMost = true;
                text = "Window will stay on top";
                textWidth = 50;
            }
            ShowMessage(text, textWidth);
        }

        private void btn_MouseOver(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = string.Empty;
            int x = 0;
            int y = 0;
            int time = 500;
            switch (button.Tag)
            {
                case "reload":
                    text = "Reload local key";
                    y = - 20;
                    time = 1000;
                    break;
                case "new":
                    text = "Generate new key";
                    y = - 20;
                    time = 1000;
                    break;
                case "import":
                    text = "Import key from file";
                    y = - 20;
                    time = 1000;
                    break;
                case "export":
                    text = "Export key to file";
                    y = - 20;
                    time = 1000;
                    break;
                case "ontop":
                    if (!TopMost)
                        text = "Stay On Top";
                    else
                        text = "Remove From Top";
                    y = - button.Height - 10;
                    break;
                case "minimize":
                    text = "Decrypt text";
                    y = - button.Height - 10;
                    break;
                case "close":
                    text = "Decrypt text";
                    y = - button.Height - 10;
                    break;
                case "delete":
                    text = "Clear text";
                    x = button.Width;
                    break;
                case "encrypt":
                    text = "Encrypt text";
                    x = button.Width;
                    break;
                case "decrypt":
                    text = "Decrypt text";
                    x = button.Width;
                    break;
                default:
                    break;
            }
            tip.Show(text,
                this, 
                button.Location.X + x,
                button.Location.Y + y,
                time);
        }
        #endregion

        #region Utilities
        private void ShowMessage(string text, int x)
        {
            Point p = btnClear.Location;
            ToolTip tip = new ToolTip();
            tip.Show(text, this, p.X - x, p.Y + btnClear.Height, 2000);
        }
        #endregion
    }
}
