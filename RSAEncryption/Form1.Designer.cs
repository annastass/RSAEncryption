
namespace RSAEncryption
{
    partial class Form1
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
            this.publicKeyTextBox = new System.Windows.Forms.TextBox();
            this.privateKeyTextBox = new System.Windows.Forms.TextBox();
            this.generateKeysButton = new System.Windows.Forms.Button();
            this.exportPublicKeyButton = new System.Windows.Forms.Button();
            this.exportPrivateKeyButton = new System.Windows.Forms.Button();
            this.ecryptButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.importPrivateKeyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // publicKeyTextBox
            // 
            this.publicKeyTextBox.Location = new System.Drawing.Point(12, 12);
            this.publicKeyTextBox.Name = "publicKeyTextBox";
            this.publicKeyTextBox.Size = new System.Drawing.Size(152, 22);
            this.publicKeyTextBox.TabIndex = 1;
            // 
            // privateKeyTextBox
            // 
            this.privateKeyTextBox.Location = new System.Drawing.Point(12, 56);
            this.privateKeyTextBox.Name = "privateKeyTextBox";
            this.privateKeyTextBox.Size = new System.Drawing.Size(152, 22);
            this.privateKeyTextBox.TabIndex = 2;
            // 
            // generateKeysButton
            // 
            this.generateKeysButton.Location = new System.Drawing.Point(205, 23);
            this.generateKeysButton.Name = "generateKeysButton";
            this.generateKeysButton.Size = new System.Drawing.Size(189, 38);
            this.generateKeysButton.TabIndex = 3;
            this.generateKeysButton.Text = "Сгенерировать ключ";
            this.generateKeysButton.UseVisualStyleBackColor = true;
            this.generateKeysButton.Click += new System.EventHandler(this.generateKeysButton_Click);
            // 
            // exportPublicKeyButton
            // 
            this.exportPublicKeyButton.Location = new System.Drawing.Point(207, 102);
            this.exportPublicKeyButton.Name = "exportPublicKeyButton";
            this.exportPublicKeyButton.Size = new System.Drawing.Size(196, 35);
            this.exportPublicKeyButton.TabIndex = 4;
            this.exportPublicKeyButton.Text = "Экспорт публ ключа";
            this.exportPublicKeyButton.UseVisualStyleBackColor = true;
            this.exportPublicKeyButton.Click += new System.EventHandler(this.exportPublicKeyButton_Click);
            // 
            // exportPrivateKeyButton
            // 
            this.exportPrivateKeyButton.Location = new System.Drawing.Point(12, 101);
            this.exportPrivateKeyButton.Name = "exportPrivateKeyButton";
            this.exportPrivateKeyButton.Size = new System.Drawing.Size(189, 36);
            this.exportPrivateKeyButton.TabIndex = 6;
            this.exportPrivateKeyButton.Text = "Экспорт прив ключа";
            this.exportPrivateKeyButton.UseVisualStyleBackColor = true;
            this.exportPrivateKeyButton.Click += new System.EventHandler(this.exportPrivateKeyButton_Click);
            // 
            // ecryptButton
            // 
            this.ecryptButton.Location = new System.Drawing.Point(12, 159);
            this.ecryptButton.Name = "ecryptButton";
            this.ecryptButton.Size = new System.Drawing.Size(189, 36);
            this.ecryptButton.TabIndex = 8;
            this.ecryptButton.Text = "Зашифровать";
            this.ecryptButton.UseVisualStyleBackColor = true;
            this.ecryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(207, 159);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(196, 36);
            this.encryptButton.TabIndex = 9;
            this.encryptButton.Text = "Дешифровать";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // importPrivateKeyButton
            // 
            this.importPrivateKeyButton.Location = new System.Drawing.Point(432, 102);
            this.importPrivateKeyButton.Name = "importPrivateKeyButton";
            this.importPrivateKeyButton.Size = new System.Drawing.Size(189, 36);
            this.importPrivateKeyButton.TabIndex = 10;
            this.importPrivateKeyButton.Text = "Импорт приватного";
            this.importPrivateKeyButton.UseVisualStyleBackColor = true;
            this.importPrivateKeyButton.Click += new System.EventHandler(this.importPrivateKeyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.importPrivateKeyButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.ecryptButton);
            this.Controls.Add(this.exportPrivateKeyButton);
            this.Controls.Add(this.exportPublicKeyButton);
            this.Controls.Add(this.generateKeysButton);
            this.Controls.Add(this.privateKeyTextBox);
            this.Controls.Add(this.publicKeyTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox publicKeyTextBox;
        private System.Windows.Forms.TextBox privateKeyTextBox;
        private System.Windows.Forms.Button generateKeysButton;
        private System.Windows.Forms.Button exportPublicKeyButton;
        private System.Windows.Forms.Button exportPrivateKeyButton;
        private System.Windows.Forms.Button ecryptButton;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button importPrivateKeyButton;
    }
}

