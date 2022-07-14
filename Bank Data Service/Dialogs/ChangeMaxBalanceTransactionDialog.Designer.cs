
namespace Bank_Data_Service {
    partial class ChangeMaxBalanceTransactionDialog {
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
            this.InformationPanel = new System.Windows.Forms.Panel();
            this.MoneyValue = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.InformationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyValue)).BeginInit();
            this.SuspendLayout();
            // 
            // InformationPanel
            // 
            this.InformationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InformationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.InformationPanel.Controls.Add(this.MoneyValue);
            this.InformationPanel.Controls.Add(this.textBox3);
            this.InformationPanel.Controls.Add(this.ChangeButton);
            this.InformationPanel.Location = new System.Drawing.Point(0, 0);
            this.InformationPanel.Name = "InformationPanel";
            this.InformationPanel.Size = new System.Drawing.Size(444, 179);
            this.InformationPanel.TabIndex = 0;
            // 
            // MoneyValue
            // 
            this.MoneyValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.MoneyValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MoneyValue.DecimalPlaces = 2;
            this.MoneyValue.Font = new System.Drawing.Font("ITC Avant Garde Std Md", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyValue.ForeColor = System.Drawing.Color.White;
            this.MoneyValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MoneyValue.Location = new System.Drawing.Point(12, 37);
            this.MoneyValue.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.MoneyValue.Name = "MoneyValue";
            this.MoneyValue.Size = new System.Drawing.Size(419, 31);
            this.MoneyValue.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(12, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(183, 19);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "Kwota:";
            // 
            // ChangeButton
            // 
            this.ChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(7)))), ((int)(((byte)(64)))));
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeButton.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeButton.ForeColor = System.Drawing.Color.White;
            this.ChangeButton.Location = new System.Drawing.Point(160, 74);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(131, 36);
            this.ChangeButton.TabIndex = 2;
            this.ChangeButton.Text = "Wykonaj";
            this.Tooltip.SetToolTip(this.ChangeButton, "Wykonaj zmianę");
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ChangeMaxBalanceTransactionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(444, 118);
            this.Controls.Add(this.InformationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChangeMaxBalanceTransactionDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zmiana Maksymalnej Wartości Transakcji";
            this.InformationPanel.ResumeLayout(false);
            this.InformationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InformationPanel;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.ToolTip Tooltip;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown MoneyValue;
    }
}