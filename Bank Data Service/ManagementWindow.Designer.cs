
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
            this.ChangesButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AccountID = new System.Windows.Forms.TextBox();
            this.TransactionHistoryButton = new System.Windows.Forms.Button();
            this.ChangeMaxTransactionBalanceButton = new System.Windows.Forms.Button();
            this.MaxBalanceTransactionMoneyText = new System.Windows.Forms.TextBox();
            this.MaxTransactionBalanceMoneyType = new System.Windows.Forms.Label();
            this.VSeparator = new Guna.UI2.WinForms.Guna2VSeparator();
            this.MoneyText = new System.Windows.Forms.TextBox();
            this.MoneyType = new System.Windows.Forms.Label();
            this.TransferMoneyButton = new System.Windows.Forms.Button();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.HistoryList = new System.Windows.Forms.ListBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.InformationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InformationPanel
            // 
            this.InformationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InformationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.InformationPanel.Controls.Add(this.RefreshButton);
            this.InformationPanel.Controls.Add(this.ChangesButton);
            this.InformationPanel.Controls.Add(this.textBox2);
            this.InformationPanel.Controls.Add(this.textBox1);
            this.InformationPanel.Controls.Add(this.AccountID);
            this.InformationPanel.Controls.Add(this.TransactionHistoryButton);
            this.InformationPanel.Controls.Add(this.ChangeMaxTransactionBalanceButton);
            this.InformationPanel.Controls.Add(this.MaxBalanceTransactionMoneyText);
            this.InformationPanel.Controls.Add(this.MaxTransactionBalanceMoneyType);
            this.InformationPanel.Controls.Add(this.VSeparator);
            this.InformationPanel.Controls.Add(this.MoneyText);
            this.InformationPanel.Controls.Add(this.MoneyType);
            this.InformationPanel.Controls.Add(this.TransferMoneyButton);
            this.InformationPanel.Location = new System.Drawing.Point(0, 0);
            this.InformationPanel.Name = "InformationPanel";
            this.InformationPanel.Size = new System.Drawing.Size(800, 188);
            this.InformationPanel.TabIndex = 0;
            // 
            // ChangesButton
            // 
            this.ChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.ChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangesButton.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangesButton.ForeColor = System.Drawing.Color.White;
            this.ChangesButton.Location = new System.Drawing.Point(59, 129);
            this.ChangesButton.Name = "ChangesButton";
            this.ChangesButton.Size = new System.Drawing.Size(131, 36);
            this.ChangesButton.TabIndex = 15;
            this.ChangesButton.Text = "Historia Zmian";
            this.Tooltip.SetToolTip(this.ChangesButton, "Wyświetl historię wszystkich zmian");
            this.ChangesButton.UseVisualStyleBackColor = false;
            this.ChangesButton.Click += new System.EventHandler(this.ChangesButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(605, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(183, 19);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "Dostępne środki:";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tooltip.SetToolTip(this.textBox2, "Aktualna ilość pieniędzy na twoim koncie");
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(72, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(255, 19);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Maksymalna Wartość Transakcji:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tooltip.SetToolTip(this.textBox1, "Maksymalna wartość środków możliwych do użycia podczas jednej transakcji\r\n");
            // 
            // AccountID
            // 
            this.AccountID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.AccountID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AccountID.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountID.ForeColor = System.Drawing.Color.White;
            this.AccountID.Location = new System.Drawing.Point(349, 8);
            this.AccountID.Name = "AccountID";
            this.AccountID.Size = new System.Drawing.Size(161, 17);
            this.AccountID.TabIndex = 12;
            this.AccountID.Text = "00000000";
            this.Tooltip.SetToolTip(this.AccountID, "Numer Konta");
            // 
            // TransactionHistoryButton
            // 
            this.TransactionHistoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TransactionHistoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.TransactionHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionHistoryButton.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionHistoryButton.ForeColor = System.Drawing.Color.White;
            this.TransactionHistoryButton.Location = new System.Drawing.Point(520, 135);
            this.TransactionHistoryButton.Name = "TransactionHistoryButton";
            this.TransactionHistoryButton.Size = new System.Drawing.Size(131, 36);
            this.TransactionHistoryButton.TabIndex = 11;
            this.TransactionHistoryButton.Text = "Historia Transakcji";
            this.Tooltip.SetToolTip(this.TransactionHistoryButton, "Wyświetl historię wszystkich transakcji");
            this.TransactionHistoryButton.UseVisualStyleBackColor = false;
            this.TransactionHistoryButton.Click += new System.EventHandler(this.TransactionHistoryButton_Click);
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
            this.Tooltip.SetToolTip(this.ChangeMaxTransactionBalanceButton, "Zmień maksymalną wartość transakcji");
            this.ChangeMaxTransactionBalanceButton.UseVisualStyleBackColor = false;
            this.ChangeMaxTransactionBalanceButton.Click += new System.EventHandler(this.ChangeMaxTransactionBalanceButton_Click);
            // 
            // MaxBalanceTransactionMoneyText
            // 
            this.MaxBalanceTransactionMoneyText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.MaxBalanceTransactionMoneyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaxBalanceTransactionMoneyText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaxBalanceTransactionMoneyText.Font = new System.Drawing.Font("ITC Avant Garde Std Md", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxBalanceTransactionMoneyText.ForeColor = System.Drawing.Color.White;
            this.MaxBalanceTransactionMoneyText.Location = new System.Drawing.Point(61, 83);
            this.MaxBalanceTransactionMoneyText.Name = "MaxBalanceTransactionMoneyText";
            this.MaxBalanceTransactionMoneyText.ReadOnly = true;
            this.MaxBalanceTransactionMoneyText.Size = new System.Drawing.Size(227, 49);
            this.MaxBalanceTransactionMoneyText.TabIndex = 9;
            this.MaxBalanceTransactionMoneyText.Text = "0.00 ";
            this.MaxBalanceTransactionMoneyText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.MoneyText.ReadOnly = true;
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
            this.Tooltip.SetToolTip(this.TransferMoneyButton, "Wykonaj transakcję");
            this.TransferMoneyButton.UseVisualStyleBackColor = false;
            this.TransferMoneyButton.Click += new System.EventHandler(this.TransferMoneyButton_Click);
            // 
            // HistoryList
            // 
            this.HistoryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.HistoryList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HistoryList.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryList.ForeColor = System.Drawing.Color.White;
            this.HistoryList.FormattingEnabled = true;
            this.HistoryList.ItemHeight = 24;
            this.HistoryList.Location = new System.Drawing.Point(0, 185);
            this.HistoryList.Name = "HistoryList";
            this.HistoryList.Size = new System.Drawing.Size(800, 264);
            this.HistoryList.TabIndex = 1;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.ForeColor = System.Drawing.Color.White;
            this.RefreshButton.Location = new System.Drawing.Point(729, 3);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(68, 22);
            this.RefreshButton.TabIndex = 16;
            this.RefreshButton.Text = "Odśwież";
            this.Tooltip.SetToolTip(this.RefreshButton, "Odśwież wszystkie wartości");
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ManagementWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HistoryList);
            this.Controls.Add(this.InformationPanel);
            this.Name = "ManagementWindow";
            this.Text = "Usługa Danych Bankowości";
            this.InformationPanel.ResumeLayout(false);
            this.InformationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InformationPanel;
        private System.Windows.Forms.Button TransferMoneyButton;
        private System.Windows.Forms.Label MoneyType;
        private System.Windows.Forms.TextBox MoneyText;
        private System.Windows.Forms.ToolTip Tooltip;
        private Guna.UI2.WinForms.Guna2VSeparator VSeparator;
        private System.Windows.Forms.TextBox MaxBalanceTransactionMoneyText;
        private System.Windows.Forms.Label MaxTransactionBalanceMoneyType;
        private System.Windows.Forms.Button TransactionHistoryButton;
        private System.Windows.Forms.Button ChangeMaxTransactionBalanceButton;
        private System.Windows.Forms.TextBox AccountID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox HistoryList;
        private System.Windows.Forms.Button ChangesButton;
        private System.Windows.Forms.Button RefreshButton;
    }
}