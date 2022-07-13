
namespace Bank_Data_Service {
    partial class TransferMoneyDialog {
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
            this.TransferMoneyButton = new System.Windows.Forms.Button();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ReceiverID = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.MoneyValue = new System.Windows.Forms.NumericUpDown();
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
            this.InformationPanel.Controls.Add(this.textBox2);
            this.InformationPanel.Controls.Add(this.ReceiverID);
            this.InformationPanel.Controls.Add(this.TransferMoneyButton);
            this.InformationPanel.Location = new System.Drawing.Point(0, 0);
            this.InformationPanel.Name = "InformationPanel";
            this.InformationPanel.Size = new System.Drawing.Size(444, 179);
            this.InformationPanel.TabIndex = 0;
            // 
            // TransferMoneyButton
            // 
            this.TransferMoneyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TransferMoneyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(7)))), ((int)(((byte)(64)))));
            this.TransferMoneyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransferMoneyButton.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferMoneyButton.ForeColor = System.Drawing.Color.White;
            this.TransferMoneyButton.Location = new System.Drawing.Point(160, 131);
            this.TransferMoneyButton.Name = "TransferMoneyButton";
            this.TransferMoneyButton.Size = new System.Drawing.Size(131, 36);
            this.TransferMoneyButton.TabIndex = 2;
            this.TransferMoneyButton.Text = "Wykonaj";
            this.Tooltip.SetToolTip(this.TransferMoneyButton, "Wykonaj transakcję");
            this.TransferMoneyButton.UseVisualStyleBackColor = false;
            this.TransferMoneyButton.Click += new System.EventHandler(this.TransferMoneyButton_Click);
            // 
            // ReceiverID
            // 
            this.ReceiverID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.ReceiverID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReceiverID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ReceiverID.Font = new System.Drawing.Font("ITC Avant Garde Std Md", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiverID.ForeColor = System.Drawing.Color.White;
            this.ReceiverID.Location = new System.Drawing.Point(12, 31);
            this.ReceiverID.Name = "ReceiverID";
            this.ReceiverID.Size = new System.Drawing.Size(420, 32);
            this.ReceiverID.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(12, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(183, 19);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "Numer Odbiorcy:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(12, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(183, 19);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "Kwota:";
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
            this.MoneyValue.Location = new System.Drawing.Point(13, 90);
            this.MoneyValue.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.MoneyValue.Name = "MoneyValue";
            this.MoneyValue.Size = new System.Drawing.Size(419, 31);
            this.MoneyValue.TabIndex = 17;
            // 
            // TransferMoneyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(444, 176);
            this.Controls.Add(this.InformationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TransferMoneyDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transakcja";
            this.InformationPanel.ResumeLayout(false);
            this.InformationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InformationPanel;
        private System.Windows.Forms.Button TransferMoneyButton;
        private System.Windows.Forms.ToolTip Tooltip;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox ReceiverID;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown MoneyValue;
    }
}