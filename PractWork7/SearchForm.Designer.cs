namespace PractWork7
{
    partial class SearchForm
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
            this.chooseDirButton = new System.Windows.Forms.Button();
            this.findFileButton = new System.Windows.Forms.Button();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.listBox = new System.Windows.Forms.ListBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chooseDirButton
            // 
            this.chooseDirButton.Location = new System.Drawing.Point(12, 83);
            this.chooseDirButton.Name = "chooseDirButton";
            this.chooseDirButton.Size = new System.Drawing.Size(118, 35);
            this.chooseDirButton.TabIndex = 0;
            this.chooseDirButton.Text = "Выбрать папку";
            this.chooseDirButton.UseVisualStyleBackColor = true;
            this.chooseDirButton.Click += new System.EventHandler(this.chooseDirButton_Click);
            // 
            // findFileButton
            // 
            this.findFileButton.Enabled = false;
            this.findFileButton.Location = new System.Drawing.Point(136, 83);
            this.findFileButton.Name = "findFileButton";
            this.findFileButton.Size = new System.Drawing.Size(118, 35);
            this.findFileButton.TabIndex = 1;
            this.findFileButton.Text = "Найти файл";
            this.findFileButton.UseVisualStyleBackColor = true;
            this.findFileButton.Click += new System.EventHandler(this.findFileButton_Click);
            // 
            // directoryLabel
            // 
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.Location = new System.Drawing.Point(9, 41);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(35, 13);
            this.directoryLabel.TabIndex = 2;
            this.directoryLabel.Text = "label1";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(260, 16);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(242, 134);
            this.listBox.TabIndex = 3;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 57);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(242, 20);
            this.textBox.TabIndex = 4;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 165);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.directoryLabel);
            this.Controls.Add(this.findFileButton);
            this.Controls.Add(this.chooseDirButton);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseDirButton;
        private System.Windows.Forms.Button findFileButton;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox textBox;
    }
}