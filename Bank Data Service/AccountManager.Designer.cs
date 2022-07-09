
namespace Bank_Data_Service {
    partial class AccountManager {
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
            this.url_site = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startDrop = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DelayTime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DelayTime)).BeginInit();
            this.SuspendLayout();
            // 
            // url_site
            // 
            this.url_site.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.url_site.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.url_site.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9F, System.Drawing.FontStyle.Italic);
            this.url_site.ForeColor = System.Drawing.Color.White;
            this.url_site.Location = new System.Drawing.Point(77, 16);
            this.url_site.Name = "url_site";
            this.url_site.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.url_site.Size = new System.Drawing.Size(434, 19);
            this.url_site.TabIndex = 0;
            this.url_site.Text = "https://www.zalando.pl/mezczyzni-home/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Url strony:";
            // 
            // startDrop
            // 
            this.startDrop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.startDrop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.startDrop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.startDrop.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.startDrop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.startDrop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.startDrop.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.startDrop.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9F, System.Drawing.FontStyle.Italic);
            this.startDrop.ForeColor = System.Drawing.Color.White;
            this.startDrop.Location = new System.Drawing.Point(634, 410);
            this.startDrop.Name = "startDrop";
            this.startDrop.Size = new System.Drawing.Size(154, 28);
            this.startDrop.TabIndex = 2;
            this.startDrop.Text = "Odpal";
            this.startDrop.Click += new System.EventHandler(this.startDrop_Click);
            // 
            // DelayTime
            // 
            this.DelayTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.DelayTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DelayTime.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9F, System.Drawing.FontStyle.Italic);
            this.DelayTime.ForeColor = System.Drawing.Color.White;
            this.DelayTime.Location = new System.Drawing.Point(140, 46);
            this.DelayTime.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.DelayTime.Name = "DelayTime";
            this.DelayTime.Size = new System.Drawing.Size(120, 19);
            this.DelayTime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(14, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Delay (max 20000):";
            // 
            // MainBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DelayTime);
            this.Controls.Add(this.startDrop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.url_site);
            this.Name = "MainBot";
            this.Text = "MainBot";
            ((System.ComponentModel.ISupportInitialize)(this.DelayTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox url_site;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton startDrop;
        private System.Windows.Forms.NumericUpDown DelayTime;
        private System.Windows.Forms.Label label3;
    }
}