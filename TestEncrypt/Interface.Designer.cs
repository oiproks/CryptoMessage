namespace CryptoMessage
{
    partial class Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.txtDecrypted = new System.Windows.Forms.TextBox();
            this.lblDecrypted = new System.Windows.Forms.Label();
            this.lblEncrypted = new System.Windows.Forms.Label();
            this.txtEncrypted = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOnTop = new System.Windows.Forms.Button();
            this.btnReloadKey = new System.Windows.Forms.Button();
            this.btnImportKey = new System.Windows.Forms.Button();
            this.btnExportKey = new System.Windows.Forms.Button();
            this.txtKeyValue = new System.Windows.Forms.TextBox();
            this.txtKeyName = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.btnNewKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Enabled = false;
            this.txtDecrypted.Location = new System.Drawing.Point(5, 102);
            this.txtDecrypted.Multiline = true;
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDecrypted.Size = new System.Drawing.Size(180, 120);
            this.txtDecrypted.TabIndex = 0;
            this.txtDecrypted.Tag = "decrypted";
            this.txtDecrypted.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EncryptDecrypt_KeyDown);
            // 
            // lblDecrypted
            // 
            this.lblDecrypted.AutoSize = true;
            this.lblDecrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecrypted.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDecrypted.Location = new System.Drawing.Point(5, 86);
            this.lblDecrypted.Name = "lblDecrypted";
            this.lblDecrypted.Size = new System.Drawing.Size(69, 13);
            this.lblDecrypted.TabIndex = 1;
            this.lblDecrypted.Text = "Decrypted:";
            // 
            // lblEncrypted
            // 
            this.lblEncrypted.AutoSize = true;
            this.lblEncrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncrypted.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEncrypted.Location = new System.Drawing.Point(232, 86);
            this.lblEncrypted.Name = "lblEncrypted";
            this.lblEncrypted.Size = new System.Drawing.Size(68, 13);
            this.lblEncrypted.TabIndex = 2;
            this.lblEncrypted.Text = "Encrypted:";
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Enabled = false;
            this.txtEncrypted.Location = new System.Drawing.Point(232, 102);
            this.txtEncrypted.Multiline = true;
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEncrypted.Size = new System.Drawing.Size(180, 120);
            this.txtEncrypted.TabIndex = 1;
            this.txtEncrypted.Tag = "encrypted";
            this.txtEncrypted.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EncryptDecrypt_KeyDown);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.Transparent;
            this.btnEncrypt.BackgroundImage = global::CryptoMessage.Properties.Resources.lock_closed;
            this.btnEncrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEncrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Location = new System.Drawing.Point(193, 102);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(30, 36);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.TabStop = false;
            this.btnEncrypt.Tag = "encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            this.btnEncrypt.MouseHover += new System.EventHandler(this.btn_MouseOver);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.Transparent;
            this.btnDecrypt.BackgroundImage = global::CryptoMessage.Properties.Resources.lock_open;
            this.btnDecrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnDecrypt.FlatAppearance.BorderSize = 0;
            this.btnDecrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDecrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Location = new System.Drawing.Point(193, 144);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(30, 36);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.TabStop = false;
            this.btnDecrypt.Tag = "decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            this.btnDecrypt.MouseHover += new System.EventHandler(this.btn_MouseOver);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = global::CryptoMessage.Properties.Resources.delete;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.Enabled = false;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(190, 186);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(36, 36);
            this.btnClear.TabIndex = 0;
            this.btnClear.TabStop = false;
            this.btnClear.Tag = "delete";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseHover += new System.EventHandler(this.btn_MouseOver);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.White;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(353, 6);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 10);
            this.btnMin.TabIndex = 9;
            this.btnMin.TabStop = false;
            this.btnMin.Tag = "minimize";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            this.btnMin.MouseHover += new System.EventHandler(this.btn_MouseOver);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(387, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 10);
            this.button1.TabIndex = 10;
            this.button1.TabStop = false;
            this.button1.Tag = "close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            this.button1.MouseHover += new System.EventHandler(this.btn_MouseOver);
            // 
            // btnOnTop
            // 
            this.btnOnTop.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnOnTop.FlatAppearance.BorderSize = 0;
            this.btnOnTop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnOnTop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnOnTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnTop.Location = new System.Drawing.Point(319, 6);
            this.btnOnTop.Name = "btnOnTop";
            this.btnOnTop.Size = new System.Drawing.Size(25, 10);
            this.btnOnTop.TabIndex = 11;
            this.btnOnTop.TabStop = false;
            this.btnOnTop.Tag = "ontop";
            this.btnOnTop.UseVisualStyleBackColor = false;
            this.btnOnTop.Click += new System.EventHandler(this.btnOnTop_click);
            this.btnOnTop.MouseHover += new System.EventHandler(this.btn_MouseOver);
            // 
            // btnReloadKey
            // 
            this.btnReloadKey.BackColor = System.Drawing.Color.Transparent;
            this.btnReloadKey.BackgroundImage = global::CryptoMessage.Properties.Resources.key_reload;
            this.btnReloadKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReloadKey.FlatAppearance.BorderSize = 0;
            this.btnReloadKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReloadKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReloadKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReloadKey.Location = new System.Drawing.Point(5, 22);
            this.btnReloadKey.Name = "btnReloadKey";
            this.btnReloadKey.Size = new System.Drawing.Size(40, 40);
            this.btnReloadKey.TabIndex = 18;
            this.btnReloadKey.TabStop = false;
            this.btnReloadKey.Tag = "reload";
            this.btnReloadKey.UseVisualStyleBackColor = false;
            this.btnReloadKey.Click += new System.EventHandler(this.btnReloadKey_click);
            this.btnReloadKey.MouseHover += new System.EventHandler(this.btn_MouseOver);
            // 
            // btnImportKey
            // 
            this.btnImportKey.BackColor = System.Drawing.Color.Transparent;
            this.btnImportKey.BackgroundImage = global::CryptoMessage.Properties.Resources.key_import;
            this.btnImportKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImportKey.FlatAppearance.BorderSize = 0;
            this.btnImportKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnImportKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnImportKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportKey.Location = new System.Drawing.Point(97, 22);
            this.btnImportKey.Name = "btnImportKey";
            this.btnImportKey.Size = new System.Drawing.Size(40, 40);
            this.btnImportKey.TabIndex = 19;
            this.btnImportKey.TabStop = false;
            this.btnImportKey.Tag = "import";
            this.btnImportKey.UseVisualStyleBackColor = false;
            this.btnImportKey.Click += new System.EventHandler(this.btnImportKey_Click);
            this.btnImportKey.MouseHover += new System.EventHandler(this.btn_MouseOver);
            // 
            // btnExportKey
            // 
            this.btnExportKey.BackColor = System.Drawing.Color.Transparent;
            this.btnExportKey.BackgroundImage = global::CryptoMessage.Properties.Resources.key_export;
            this.btnExportKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExportKey.FlatAppearance.BorderSize = 0;
            this.btnExportKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExportKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExportKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportKey.Location = new System.Drawing.Point(143, 22);
            this.btnExportKey.Name = "btnExportKey";
            this.btnExportKey.Size = new System.Drawing.Size(40, 40);
            this.btnExportKey.TabIndex = 20;
            this.btnExportKey.TabStop = false;
            this.btnExportKey.Tag = "export";
            this.btnExportKey.UseVisualStyleBackColor = false;
            this.btnExportKey.Click += new System.EventHandler(this.btnExportKey_Click);
            this.btnExportKey.MouseHover += new System.EventHandler(this.btn_MouseOver);
            // 
            // txtKeyValue
            // 
            this.txtKeyValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeyValue.CausesValidation = false;
            this.txtKeyValue.Enabled = false;
            this.txtKeyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtKeyValue.Location = new System.Drawing.Point(232, 32);
            this.txtKeyValue.Multiline = true;
            this.txtKeyValue.Name = "txtKeyValue";
            this.txtKeyValue.ReadOnly = true;
            this.txtKeyValue.Size = new System.Drawing.Size(180, 40);
            this.txtKeyValue.TabIndex = 17;
            this.txtKeyValue.TabStop = false;
            // 
            // txtKeyName
            // 
            this.txtKeyName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtKeyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKeyName.CausesValidation = false;
            this.txtKeyName.Enabled = false;
            this.txtKeyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtKeyName.Location = new System.Drawing.Point(5, 65);
            this.txtKeyName.Multiline = true;
            this.txtKeyName.Name = "txtKeyName";
            this.txtKeyName.ReadOnly = true;
            this.txtKeyName.Size = new System.Drawing.Size(178, 20);
            this.txtKeyName.TabIndex = 22;
            this.txtKeyName.TabStop = false;
            this.txtKeyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKey.Location = new System.Drawing.Point(200, 45);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(32, 13);
            this.lblKey.TabIndex = 23;
            this.lblKey.Text = "Key:";
            // 
            // btnNewKey
            // 
            this.btnNewKey.BackColor = System.Drawing.Color.Transparent;
            this.btnNewKey.BackgroundImage = global::CryptoMessage.Properties.Resources.key_new;
            this.btnNewKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNewKey.FlatAppearance.BorderSize = 0;
            this.btnNewKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNewKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNewKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewKey.Location = new System.Drawing.Point(51, 22);
            this.btnNewKey.Name = "btnNewKey";
            this.btnNewKey.Size = new System.Drawing.Size(40, 40);
            this.btnNewKey.TabIndex = 25;
            this.btnNewKey.TabStop = false;
            this.btnNewKey.Tag = "new";
            this.btnNewKey.UseVisualStyleBackColor = false;
            this.btnNewKey.Click += new System.EventHandler(this.btnNewKey_click);
            this.btnNewKey.MouseHover += new System.EventHandler(this.btn_MouseOver);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(420, 230);
            this.Controls.Add(this.btnNewKey);
            this.Controls.Add(this.txtKeyName);
            this.Controls.Add(this.btnExportKey);
            this.Controls.Add(this.btnImportKey);
            this.Controls.Add(this.btnReloadKey);
            this.Controls.Add(this.txtKeyValue);
            this.Controls.Add(this.btnOnTop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtEncrypted);
            this.Controls.Add(this.lblEncrypted);
            this.Controls.Add(this.lblDecrypted);
            this.Controls.Add(this.txtDecrypted);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CryptoMessage";
            this.Load += new System.EventHandler(this.Interface_Load);
            this.Shown += new System.EventHandler(this.Interface_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Interface_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Interface_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Interface_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Interface_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDecrypted;
        private System.Windows.Forms.Label lblDecrypted;
        private System.Windows.Forms.Label lblEncrypted;
        private System.Windows.Forms.TextBox txtEncrypted;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOnTop;
        private System.Windows.Forms.Button btnReloadKey;
        private System.Windows.Forms.Button btnImportKey;
        private System.Windows.Forms.Button btnExportKey;
        private System.Windows.Forms.TextBox txtKeyValue;
        private System.Windows.Forms.TextBox txtKeyName;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Button btnNewKey;
    }
}

