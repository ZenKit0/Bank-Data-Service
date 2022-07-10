
namespace Bank_Data_Service {
    partial class AuthWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.ShowPasswd = new System.Windows.Forms.CheckBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ExitButton = new System.Windows.Forms.PictureBox();
            this.LoginButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PinText = new System.Windows.Forms.TextBox();
            this.PinLabel = new System.Windows.Forms.Label();
            this.ShowPin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.White;
            this.PasswordLabel.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.PasswordLabel.Location = new System.Drawing.Point(12, 84);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(42, 15);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Hasło:";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.White;
            this.LoginLabel.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.LoginLabel.Location = new System.Drawing.Point(12, 25);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(42, 15);
            this.LoginLabel.TabIndex = 7;
            this.LoginLabel.Text = "Login:";
            // 
            // PasswordText
            // 
            this.PasswordText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordText.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9F, System.Drawing.FontStyle.Italic);
            this.PasswordText.Location = new System.Drawing.Point(12, 101);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(325, 16);
            this.PasswordText.TabIndex = 4;
            // 
            // LoginText
            // 
            this.LoginText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.LoginText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginText.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9F, System.Drawing.FontStyle.Italic);
            this.LoginText.Location = new System.Drawing.Point(12, 43);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(325, 16);
            this.LoginText.TabIndex = 1;
            // 
            // ShowPasswd
            // 
            this.ShowPasswd.AutoSize = true;
            this.ShowPasswd.Checked = true;
            this.ShowPasswd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowPasswd.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9F, System.Drawing.FontStyle.Italic);
            this.ShowPasswd.Location = new System.Drawing.Point(161, 80);
            this.ShowPasswd.Name = "ShowPasswd";
            this.ShowPasswd.Size = new System.Drawing.Size(88, 19);
            this.ShowPasswd.TabIndex = 2;
            this.ShowPasswd.Text = "Ukryj hasło";
            this.ShowPasswd.UseVisualStyleBackColor = true;
            this.ShowPasswd.CheckedChanged += new System.EventHandler(this.ShowPasswd_CheckedChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ExitButton
            // 
            this.ExitButton.ImageLocation = "https://cdn-icons-png.flaticon.com/128/2919/2919590.png";
            this.ExitButton.Location = new System.Drawing.Point(308, 11);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(22, 22);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitButton.TabIndex = 9;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginButton.FillColor = System.Drawing.Color.Aqua;
            this.LoginButton.FillColor2 = System.Drawing.Color.Fuchsia;
            this.LoginButton.FocusedColor = System.Drawing.Color.Transparent;
            this.LoginButton.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9F, System.Drawing.FontStyle.Italic);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(24, 175);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(301, 27);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Zaloguj";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PinText
            // 
            this.PinText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.PinText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PinText.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9F, System.Drawing.FontStyle.Italic);
            this.PinText.Location = new System.Drawing.Point(12, 143);
            this.PinText.Name = "PinText";
            this.PinText.PasswordChar = '*';
            this.PinText.Size = new System.Drawing.Size(325, 16);
            this.PinText.TabIndex = 5;
            // 
            // PinLabel
            // 
            this.PinLabel.AutoSize = true;
            this.PinLabel.BackColor = System.Drawing.Color.White;
            this.PinLabel.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.PinLabel.Location = new System.Drawing.Point(12, 126);
            this.PinLabel.Name = "PinLabel";
            this.PinLabel.Size = new System.Drawing.Size(28, 15);
            this.PinLabel.TabIndex = 9;
            this.PinLabel.Text = "Pin:";
            // 
            // ShowPin
            // 
            this.ShowPin.AutoSize = true;
            this.ShowPin.Checked = true;
            this.ShowPin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowPin.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9F, System.Drawing.FontStyle.Italic);
            this.ShowPin.Location = new System.Drawing.Point(255, 80);
            this.ShowPin.Name = "ShowPin";
            this.ShowPin.Size = new System.Drawing.Size(75, 19);
            this.ShowPin.TabIndex = 3;
            this.ShowPin.Text = "Ukryj pin";
            this.ShowPin.UseVisualStyleBackColor = true;
            this.ShowPin.CheckedChanged += new System.EventHandler(this.ShowPin_CheckedChanged);
            // 
            // AuthWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(349, 221);
            this.Controls.Add(this.ShowPin);
            this.Controls.Add(this.PinText);
            this.Controls.Add(this.PinLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ShowPasswd);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthWindow";
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.CheckBox ShowPasswd;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox ExitButton;
        private Guna.UI2.WinForms.Guna2GradientButton LoginButton;
        private System.Windows.Forms.TextBox PinText;
        private System.Windows.Forms.Label PinLabel;
        private System.Windows.Forms.CheckBox ShowPin;
    }
}