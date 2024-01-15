namespace KurshachForm
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
            this.TabControll = new System.Windows.Forms.TabControl();
            this.AuthWindow = new System.Windows.Forms.TabPage();
            this.Auth_AuthButton = new System.Windows.Forms.Button();
            this.Auth_PasswordTextBox = new System.Windows.Forms.TextBox();
            this.Auth_LoginTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Portal = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.Portal_AccidentsButton = new System.Windows.Forms.Button();
            this.TabControll.SuspendLayout();
            this.AuthWindow.SuspendLayout();
            this.Portal.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControll
            // 
            this.TabControll.Controls.Add(this.AuthWindow);
            this.TabControll.Controls.Add(this.Portal);
            this.TabControll.Location = new System.Drawing.Point(3, 0);
            this.TabControll.Name = "TabControll";
            this.TabControll.SelectedIndex = 0;
            this.TabControll.Size = new System.Drawing.Size(795, 449);
            this.TabControll.TabIndex = 0;
            // 
            // AuthWindow
            // 
            this.AuthWindow.Controls.Add(this.Auth_AuthButton);
            this.AuthWindow.Controls.Add(this.Auth_PasswordTextBox);
            this.AuthWindow.Controls.Add(this.Auth_LoginTextBox);
            this.AuthWindow.Controls.Add(this.label3);
            this.AuthWindow.Controls.Add(this.label2);
            this.AuthWindow.Controls.Add(this.label1);
            this.AuthWindow.Location = new System.Drawing.Point(4, 25);
            this.AuthWindow.Name = "AuthWindow";
            this.AuthWindow.Padding = new System.Windows.Forms.Padding(3);
            this.AuthWindow.Size = new System.Drawing.Size(787, 420);
            this.AuthWindow.TabIndex = 0;
            this.AuthWindow.Text = "Авторизация";
            this.AuthWindow.UseVisualStyleBackColor = true;
            this.AuthWindow.Click += new System.EventHandler(this.AuthWindow_Click);
            // 
            // Auth_AuthButton
            // 
            this.Auth_AuthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Auth_AuthButton.Location = new System.Drawing.Point(265, 256);
            this.Auth_AuthButton.Name = "Auth_AuthButton";
            this.Auth_AuthButton.Size = new System.Drawing.Size(277, 63);
            this.Auth_AuthButton.TabIndex = 5;
            this.Auth_AuthButton.Text = "Войти";
            this.Auth_AuthButton.UseVisualStyleBackColor = true;
            this.Auth_AuthButton.Click += new System.EventHandler(this.Auth_AuthButton_Click);
            // 
            // Auth_PasswordTextBox
            // 
            this.Auth_PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Auth_PasswordTextBox.Location = new System.Drawing.Point(342, 168);
            this.Auth_PasswordTextBox.Name = "Auth_PasswordTextBox";
            this.Auth_PasswordTextBox.Size = new System.Drawing.Size(200, 38);
            this.Auth_PasswordTextBox.TabIndex = 4;
            // 
            // Auth_LoginTextBox
            // 
            this.Auth_LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Auth_LoginTextBox.Location = new System.Drawing.Point(342, 101);
            this.Auth_LoginTextBox.Name = "Auth_LoginTextBox";
            this.Auth_LoginTextBox.Size = new System.Drawing.Size(200, 38);
            this.Auth_LoginTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(198, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(198, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(281, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // Portal
            // 
            this.Portal.Controls.Add(this.button2);
            this.Portal.Controls.Add(this.Portal_AccidentsButton);
            this.Portal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Portal.Location = new System.Drawing.Point(4, 25);
            this.Portal.Name = "Portal";
            this.Portal.Padding = new System.Windows.Forms.Padding(3);
            this.Portal.Size = new System.Drawing.Size(787, 420);
            this.Portal.TabIndex = 1;
            this.Portal.Text = "Портал";
            this.Portal.UseVisualStyleBackColor = true;
            this.Portal.Click += new System.EventHandler(this.Portal_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button2.Location = new System.Drawing.Point(259, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Городская справка";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Portal_AccidentsButton
            // 
            this.Portal_AccidentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Portal_AccidentsButton.Location = new System.Drawing.Point(259, 101);
            this.Portal_AccidentsButton.Name = "Portal_AccidentsButton";
            this.Portal_AccidentsButton.Size = new System.Drawing.Size(273, 44);
            this.Portal_AccidentsButton.TabIndex = 1;
            this.Portal_AccidentsButton.Text = "Происшествия";
            this.Portal_AccidentsButton.UseVisualStyleBackColor = true;
            this.Portal_AccidentsButton.Click += new System.EventHandler(this.Portal_AccidentsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControll);
            this.Name = "Form1";
            this.Text = "База данных";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControll.ResumeLayout(false);
            this.AuthWindow.ResumeLayout(false);
            this.AuthWindow.PerformLayout();
            this.Portal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControll;
        private System.Windows.Forms.TabPage AuthWindow;
        private System.Windows.Forms.TextBox Auth_PasswordTextBox;
        private System.Windows.Forms.TextBox Auth_LoginTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Portal;
        private System.Windows.Forms.Button Auth_AuthButton;
        private System.Windows.Forms.Button Portal_AccidentsButton;
        private System.Windows.Forms.Button button2;
    }
}

