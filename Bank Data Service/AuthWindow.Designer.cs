
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
            this.LoginButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PinText = new System.Windows.Forms.TextBox();
            this.PinLabel = new System.Windows.Forms.Label();
            this.ShowPin = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.PasswordLabel.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 60);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(42, 15);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Hasło:";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.LoginLabel.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.White;
            this.LoginLabel.Location = new System.Drawing.Point(12, 9);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(42, 15);
            this.LoginLabel.TabIndex = 7;
            this.LoginLabel.Text = "Login:";
            // 
            // PasswordText
            // 
            this.PasswordText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordText.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9F, System.Drawing.FontStyle.Italic);
            this.PasswordText.ForeColor = System.Drawing.Color.White;
            this.PasswordText.Location = new System.Drawing.Point(12, 79);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(325, 16);
            this.PasswordText.TabIndex = 4;
            // 
            // LoginText
            // 
            this.LoginText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.LoginText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginText.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9F, System.Drawing.FontStyle.Italic);
            this.LoginText.ForeColor = System.Drawing.Color.White;
            this.LoginText.Location = new System.Drawing.Point(12, 27);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(325, 16);
            this.LoginText.TabIndex = 1;
            // 
            // ShowPasswd
            // 
            this.ShowPasswd.AutoSize = true;
            this.ShowPasswd.Checked = true;
            this.ShowPasswd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowPasswd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPasswd.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9F, System.Drawing.FontStyle.Italic);
            this.ShowPasswd.ForeColor = System.Drawing.Color.White;
            this.ShowPasswd.Location = new System.Drawing.Point(161, 49);
            this.ShowPasswd.Name = "ShowPasswd";
            this.ShowPasswd.Size = new System.Drawing.Size(85, 19);
            this.ShowPasswd.TabIndex = 2;
            this.ShowPasswd.Text = "Ukryj hasło";
            this.ShowPasswd.UseVisualStyleBackColor = true;
            this.ShowPasswd.CheckedChanged += new System.EventHandler(this.ShowPasswd_CheckedChanged);
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
            this.LoginButton.Location = new System.Drawing.Point(24, 144);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(301, 27);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Zaloguj";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PinText
            // 
            this.PinText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.PinText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PinText.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9F, System.Drawing.FontStyle.Italic);
            this.PinText.ForeColor = System.Drawing.Color.White;
            this.PinText.Location = new System.Drawing.Point(12, 119);
            this.PinText.Name = "PinText";
            this.PinText.PasswordChar = '*';
            this.PinText.Size = new System.Drawing.Size(325, 16);
            this.PinText.TabIndex = 5;
            // 
            // PinLabel
            // 
            this.PinLabel.AutoSize = true;
            this.PinLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.PinLabel.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinLabel.ForeColor = System.Drawing.Color.White;
            this.PinLabel.Location = new System.Drawing.Point(12, 101);
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
            this.ShowPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPin.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9F, System.Drawing.FontStyle.Italic);
            this.ShowPin.ForeColor = System.Drawing.Color.White;
            this.ShowPin.Location = new System.Drawing.Point(255, 49);
            this.ShowPin.Name = "ShowPin";
            this.ShowPin.Size = new System.Drawing.Size(72, 19);
            this.ShowPin.TabIndex = 3;
            this.ShowPin.Text = "Ukryj pin";
            this.ShowPin.UseVisualStyleBackColor = true;
            this.ShowPin.CheckedChanged += new System.EventHandler(this.ShowPin_CheckedChanged);
            // 
            // AuthWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(349, 181);
            this.Controls.Add(this.ShowPin);
            this.Controls.Add(this.PinText);
            this.Controls.Add(this.PinLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.ShowPasswd);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Name = "AuthWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.CheckBox ShowPasswd;
        private Guna.UI2.WinForms.Guna2GradientButton LoginButton;
        private System.Windows.Forms.TextBox PinText;
        private System.Windows.Forms.Label PinLabel;
        private System.Windows.Forms.CheckBox ShowPin;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}