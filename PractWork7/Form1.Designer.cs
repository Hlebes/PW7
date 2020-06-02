namespace PractWork7
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchFormButton = new System.Windows.Forms.Button();
            this.shoppingFormButton = new System.Windows.Forms.Button();
            this.notesFormButton = new System.Windows.Forms.Button();
            this.registrationFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchFormButton
            // 
            this.searchFormButton.Location = new System.Drawing.Point(12, 12);
            this.searchFormButton.Name = "searchFormButton";
            this.searchFormButton.Size = new System.Drawing.Size(165, 47);
            this.searchFormButton.TabIndex = 0;
            this.searchFormButton.Text = "Форма поиска";
            this.searchFormButton.UseVisualStyleBackColor = true;
            this.searchFormButton.Click += new System.EventHandler(this.searchFormButton_Click);
            // 
            // shoppingFormButton
            // 
            this.shoppingFormButton.Location = new System.Drawing.Point(12, 65);
            this.shoppingFormButton.Name = "shoppingFormButton";
            this.shoppingFormButton.Size = new System.Drawing.Size(165, 47);
            this.shoppingFormButton.TabIndex = 1;
            this.shoppingFormButton.Text = "Форма покупок";
            this.shoppingFormButton.UseVisualStyleBackColor = true;
            this.shoppingFormButton.Click += new System.EventHandler(this.shoppingFormButton_Click);
            // 
            // notesFormButton
            // 
            this.notesFormButton.Location = new System.Drawing.Point(12, 118);
            this.notesFormButton.Name = "notesFormButton";
            this.notesFormButton.Size = new System.Drawing.Size(165, 47);
            this.notesFormButton.TabIndex = 2;
            this.notesFormButton.Text = "Форма записи заметок";
            this.notesFormButton.UseVisualStyleBackColor = true;
            this.notesFormButton.Click += new System.EventHandler(this.notesFormButton_Click);
            // 
            // registrationFormButton
            // 
            this.registrationFormButton.Location = new System.Drawing.Point(12, 171);
            this.registrationFormButton.Name = "registrationFormButton";
            this.registrationFormButton.Size = new System.Drawing.Size(165, 47);
            this.registrationFormButton.TabIndex = 3;
            this.registrationFormButton.Text = "Форма регистрации";
            this.registrationFormButton.UseVisualStyleBackColor = true;
            this.registrationFormButton.Click += new System.EventHandler(this.registrationFormButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 228);
            this.Controls.Add(this.registrationFormButton);
            this.Controls.Add(this.notesFormButton);
            this.Controls.Add(this.shoppingFormButton);
            this.Controls.Add(this.searchFormButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchFormButton;
        private System.Windows.Forms.Button shoppingFormButton;
        private System.Windows.Forms.Button notesFormButton;
        private System.Windows.Forms.Button registrationFormButton;
    }
}

