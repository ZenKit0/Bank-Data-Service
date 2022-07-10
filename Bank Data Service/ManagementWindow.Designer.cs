﻿
namespace Bank_Data_Service {
    partial class ManagementWindow {
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
            this.HistoryButton = new System.Windows.Forms.Button();
            this.ChangeMaxTransactionBalanceButton = new System.Windows.Forms.Button();
            this.MaxTransactionBalanceMoneyText = new System.Windows.Forms.TextBox();
            this.MaxTransactionBalanceMoneyType = new System.Windows.Forms.Label();
            this.VSeparator = new Guna.UI2.WinForms.Guna2VSeparator();
            this.MaxTransactionBalance = new System.Windows.Forms.Label();
            this.MoneyText = new System.Windows.Forms.TextBox();
            this.MoneyType = new System.Windows.Forms.Label();
            this.TransferMoneyButton = new System.Windows.Forms.Button();
            this.CurrentBalance = new System.Windows.Forms.Label();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.InformationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InformationPanel
            // 
            this.InformationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InformationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.InformationPanel.Controls.Add(this.HistoryButton);
            this.InformationPanel.Controls.Add(this.ChangeMaxTransactionBalanceButton);
            this.InformationPanel.Controls.Add(this.MaxTransactionBalanceMoneyText);
            this.InformationPanel.Controls.Add(this.MaxTransactionBalanceMoneyType);
            this.InformationPanel.Controls.Add(this.VSeparator);
            this.InformationPanel.Controls.Add(this.MaxTransactionBalance);
            this.InformationPanel.Controls.Add(this.MoneyText);
            this.InformationPanel.Controls.Add(this.MoneyType);
            this.InformationPanel.Controls.Add(this.TransferMoneyButton);
            this.InformationPanel.Controls.Add(this.CurrentBalance);
            this.InformationPanel.Location = new System.Drawing.Point(0, 0);
            this.InformationPanel.Name = "InformationPanel";
            this.InformationPanel.Size = new System.Drawing.Size(800, 179);
            this.InformationPanel.TabIndex = 0;
            // 
            // HistoryButton
            // 
            this.HistoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.HistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoryButton.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryButton.ForeColor = System.Drawing.Color.White;
            this.HistoryButton.Location = new System.Drawing.Point(509, 135);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(131, 36);
            this.HistoryButton.TabIndex = 11;
            this.HistoryButton.Text = "Historia";
            this.HistoryButton.UseVisualStyleBackColor = false;
            // 
            // ChangeMaxTransactionBalanceButton
            // 
            this.ChangeMaxTransactionBalanceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(7)))), ((int)(((byte)(64)))));
            this.ChangeMaxTransactionBalanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeMaxTransactionBalanceButton.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeMaxTransactionBalanceButton.ForeColor = System.Drawing.Color.White;
            this.ChangeMaxTransactionBalanceButton.Location = new System.Drawing.Point(196, 129);
            this.ChangeMaxTransactionBalanceButton.Name = "ChangeMaxTransactionBalanceButton";
            this.ChangeMaxTransactionBalanceButton.Size = new System.Drawing.Size(131, 36);
            this.ChangeMaxTransactionBalanceButton.TabIndex = 10;
            this.ChangeMaxTransactionBalanceButton.Text = "Edytuj";
            this.ChangeMaxTransactionBalanceButton.UseVisualStyleBackColor = false;
            // 
            // MaxTransactionBalanceMoneyText
            // 
            this.MaxTransactionBalanceMoneyText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.MaxTransactionBalanceMoneyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaxTransactionBalanceMoneyText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaxTransactionBalanceMoneyText.Font = new System.Drawing.Font("ITC Avant Garde Std Md", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxTransactionBalanceMoneyText.ForeColor = System.Drawing.Color.White;
            this.MaxTransactionBalanceMoneyText.Location = new System.Drawing.Point(61, 83);
            this.MaxTransactionBalanceMoneyText.Name = "MaxTransactionBalanceMoneyText";
            this.MaxTransactionBalanceMoneyText.Size = new System.Drawing.Size(227, 49);
            this.MaxTransactionBalanceMoneyText.TabIndex = 9;
            this.MaxTransactionBalanceMoneyText.Text = "0.00 ";
            this.MaxTransactionBalanceMoneyText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MaxTransactionBalanceMoneyType
            // 
            this.MaxTransactionBalanceMoneyType.AutoSize = true;
            this.MaxTransactionBalanceMoneyType.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxTransactionBalanceMoneyType.ForeColor = System.Drawing.Color.White;
            this.MaxTransactionBalanceMoneyType.Location = new System.Drawing.Point(283, 98);
            this.MaxTransactionBalanceMoneyType.Name = "MaxTransactionBalanceMoneyType";
            this.MaxTransactionBalanceMoneyType.Size = new System.Drawing.Size(49, 26);
            this.MaxTransactionBalanceMoneyType.TabIndex = 8;
            this.MaxTransactionBalanceMoneyType.Text = "PLN";
            // 
            // VSeparator
            // 
            this.VSeparator.Location = new System.Drawing.Point(333, 12);
            this.VSeparator.Name = "VSeparator";
            this.VSeparator.Size = new System.Drawing.Size(10, 153);
            this.VSeparator.TabIndex = 7;
            // 
            // MaxTransactionBalance
            // 
            this.MaxTransactionBalance.AutoSize = true;
            this.MaxTransactionBalance.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxTransactionBalance.ForeColor = System.Drawing.Color.White;
            this.MaxTransactionBalance.Location = new System.Drawing.Point(84, 60);
            this.MaxTransactionBalance.Name = "MaxTransactionBalance";
            this.MaxTransactionBalance.Size = new System.Drawing.Size(243, 19);
            this.MaxTransactionBalance.TabIndex = 5;
            this.MaxTransactionBalance.Text = "Maksymalna Wartość Transakcji:";
            this.Tooltip.SetToolTip(this.MaxTransactionBalance, "Maksymalna ilość pieniędzy możliwych do przesłania za pomocą jednej transakcji.");
            // 
            // MoneyText
            // 
            this.MoneyText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoneyText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.MoneyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MoneyText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MoneyText.Font = new System.Drawing.Font("ITC Avant Garde Std Md", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyText.ForeColor = System.Drawing.Color.White;
            this.MoneyText.Location = new System.Drawing.Point(349, 83);
            this.MoneyText.Name = "MoneyText";
            this.MoneyText.Size = new System.Drawing.Size(395, 49);
            this.MoneyText.TabIndex = 4;
            this.MoneyText.Text = "0.00 ";
            this.MoneyText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MoneyType
            // 
            this.MoneyType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoneyType.AutoSize = true;
            this.MoneyType.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyType.ForeColor = System.Drawing.Color.White;
            this.MoneyType.Location = new System.Drawing.Point(739, 98);
            this.MoneyType.Name = "MoneyType";
            this.MoneyType.Size = new System.Drawing.Size(49, 26);
            this.MoneyType.TabIndex = 3;
            this.MoneyType.Text = "PLN";
            // 
            // TransferMoneyButton
            // 
            this.TransferMoneyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TransferMoneyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(7)))), ((int)(((byte)(64)))));
            this.TransferMoneyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransferMoneyButton.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferMoneyButton.ForeColor = System.Drawing.Color.White;
            this.TransferMoneyButton.Location = new System.Drawing.Point(657, 135);
            this.TransferMoneyButton.Name = "TransferMoneyButton";
            this.TransferMoneyButton.Size = new System.Drawing.Size(131, 36);
            this.TransferMoneyButton.TabIndex = 2;
            this.TransferMoneyButton.Text = "Przelew";
            this.TransferMoneyButton.UseVisualStyleBackColor = false;
            // 
            // CurrentBalance
            // 
            this.CurrentBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentBalance.AutoSize = true;
            this.CurrentBalance.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBalance.ForeColor = System.Drawing.Color.White;
            this.CurrentBalance.Location = new System.Drawing.Point(658, 60);
            this.CurrentBalance.Name = "CurrentBalance";
            this.CurrentBalance.Size = new System.Drawing.Size(130, 19);
            this.CurrentBalance.TabIndex = 1;
            this.CurrentBalance.Text = "Dostępne środki:";
            // 
            // ManagementWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InformationPanel);
            this.Name = "ManagementWindow";
            this.Text = "ManagementWindow";
            this.InformationPanel.ResumeLayout(false);
            this.InformationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InformationPanel;
        private System.Windows.Forms.Label CurrentBalance;
        private System.Windows.Forms.Button TransferMoneyButton;
        private System.Windows.Forms.Label MoneyType;
        private System.Windows.Forms.TextBox MoneyText;
        private System.Windows.Forms.Label MaxTransactionBalance;
        private System.Windows.Forms.ToolTip Tooltip;
        private Guna.UI2.WinForms.Guna2VSeparator VSeparator;
        private System.Windows.Forms.TextBox MaxTransactionBalanceMoneyText;
        private System.Windows.Forms.Label MaxTransactionBalanceMoneyType;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Button ChangeMaxTransactionBalanceButton;
    }
}