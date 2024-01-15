namespace KurshachForm
{
    partial class ParticipatorsForm
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
            this.GridView = new System.Windows.Forms.DataGridView();
            this.TabControll = new System.Windows.Forms.TabControl();
            this.SearchingPage = new System.Windows.Forms.TabPage();
            this.NewParticipatorPage = new System.Windows.Forms.TabPage();
            this.RemovalPage = new System.Windows.Forms.TabPage();
            this.ChangePage = new System.Windows.Forms.TabPage();
            this.Search_IDtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Add_AccidentComboBox = new System.Windows.Forms.ComboBox();
            this.Add_CtitizenComboBox = new System.Windows.Forms.ComboBox();
            this.Add_CarComboBox = new System.Windows.Forms.ComboBox();
            this.Add_RoleComboBox = new System.Windows.Forms.ComboBox();
            this.Add_StateComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Add_AddButton = new System.Windows.Forms.Button();
            this.Removal_IDtextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Change_ChangeButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Change_StateComboBox = new System.Windows.Forms.ComboBox();
            this.Change_RoleComboBox = new System.Windows.Forms.ComboBox();
            this.Change_CarComboBox = new System.Windows.Forms.ComboBox();
            this.Change_CitizenComboBox = new System.Windows.Forms.ComboBox();
            this.Change_AccidentComboBox = new System.Windows.Forms.ComboBox();
            this.Change_IDtextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.TabControll.SuspendLayout();
            this.SearchingPage.SuspendLayout();
            this.NewParticipatorPage.SuspendLayout();
            this.RemovalPage.SuspendLayout();
            this.ChangePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(12, 12);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidth = 51;
            this.GridView.RowTemplate.Height = 24;
            this.GridView.Size = new System.Drawing.Size(776, 253);
            this.GridView.TabIndex = 0;
            // 
            // TabControll
            // 
            this.TabControll.Controls.Add(this.SearchingPage);
            this.TabControll.Controls.Add(this.NewParticipatorPage);
            this.TabControll.Controls.Add(this.RemovalPage);
            this.TabControll.Controls.Add(this.ChangePage);
            this.TabControll.Location = new System.Drawing.Point(12, 288);
            this.TabControll.Name = "TabControll";
            this.TabControll.SelectedIndex = 0;
            this.TabControll.Size = new System.Drawing.Size(776, 367);
            this.TabControll.TabIndex = 1;
            // 
            // SearchingPage
            // 
            this.SearchingPage.Controls.Add(this.button1);
            this.SearchingPage.Controls.Add(this.label1);
            this.SearchingPage.Controls.Add(this.Search_IDtextBox);
            this.SearchingPage.Location = new System.Drawing.Point(4, 25);
            this.SearchingPage.Name = "SearchingPage";
            this.SearchingPage.Padding = new System.Windows.Forms.Padding(3);
            this.SearchingPage.Size = new System.Drawing.Size(768, 338);
            this.SearchingPage.TabIndex = 0;
            this.SearchingPage.Text = "Поиск";
            this.SearchingPage.UseVisualStyleBackColor = true;
            // 
            // NewParticipatorPage
            // 
            this.NewParticipatorPage.Controls.Add(this.Add_AddButton);
            this.NewParticipatorPage.Controls.Add(this.label7);
            this.NewParticipatorPage.Controls.Add(this.label6);
            this.NewParticipatorPage.Controls.Add(this.label5);
            this.NewParticipatorPage.Controls.Add(this.label4);
            this.NewParticipatorPage.Controls.Add(this.label3);
            this.NewParticipatorPage.Controls.Add(this.Add_StateComboBox);
            this.NewParticipatorPage.Controls.Add(this.Add_RoleComboBox);
            this.NewParticipatorPage.Controls.Add(this.Add_CarComboBox);
            this.NewParticipatorPage.Controls.Add(this.Add_CtitizenComboBox);
            this.NewParticipatorPage.Controls.Add(this.Add_AccidentComboBox);
            this.NewParticipatorPage.Location = new System.Drawing.Point(4, 25);
            this.NewParticipatorPage.Name = "NewParticipatorPage";
            this.NewParticipatorPage.Size = new System.Drawing.Size(768, 338);
            this.NewParticipatorPage.TabIndex = 2;
            this.NewParticipatorPage.Text = "Добавить";
            this.NewParticipatorPage.UseVisualStyleBackColor = true;
            // 
            // RemovalPage
            // 
            this.RemovalPage.Controls.Add(this.button3);
            this.RemovalPage.Controls.Add(this.label8);
            this.RemovalPage.Controls.Add(this.Removal_IDtextBox);
            this.RemovalPage.Location = new System.Drawing.Point(4, 25);
            this.RemovalPage.Name = "RemovalPage";
            this.RemovalPage.Size = new System.Drawing.Size(768, 338);
            this.RemovalPage.TabIndex = 3;
            this.RemovalPage.Text = "Удалить";
            this.RemovalPage.UseVisualStyleBackColor = true;
            // 
            // ChangePage
            // 
            this.ChangePage.Controls.Add(this.label14);
            this.ChangePage.Controls.Add(this.Change_IDtextBox);
            this.ChangePage.Controls.Add(this.Change_ChangeButton);
            this.ChangePage.Controls.Add(this.label9);
            this.ChangePage.Controls.Add(this.label10);
            this.ChangePage.Controls.Add(this.label11);
            this.ChangePage.Controls.Add(this.label12);
            this.ChangePage.Controls.Add(this.label13);
            this.ChangePage.Controls.Add(this.Change_StateComboBox);
            this.ChangePage.Controls.Add(this.Change_RoleComboBox);
            this.ChangePage.Controls.Add(this.Change_CarComboBox);
            this.ChangePage.Controls.Add(this.Change_CitizenComboBox);
            this.ChangePage.Controls.Add(this.Change_AccidentComboBox);
            this.ChangePage.Location = new System.Drawing.Point(4, 25);
            this.ChangePage.Name = "ChangePage";
            this.ChangePage.Size = new System.Drawing.Size(768, 338);
            this.ChangePage.TabIndex = 4;
            this.ChangePage.Text = "Изменить";
            this.ChangePage.UseVisualStyleBackColor = true;
            // 
            // Search_IDtextBox
            // 
            this.Search_IDtextBox.Location = new System.Drawing.Point(6, 6);
            this.Search_IDtextBox.Name = "Search_IDtextBox";
            this.Search_IDtextBox.Size = new System.Drawing.Size(117, 22);
            this.Search_IDtextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_AccidentComboBox
            // 
            this.Add_AccidentComboBox.FormattingEnabled = true;
            this.Add_AccidentComboBox.Location = new System.Drawing.Point(18, 15);
            this.Add_AccidentComboBox.Name = "Add_AccidentComboBox";
            this.Add_AccidentComboBox.Size = new System.Drawing.Size(421, 24);
            this.Add_AccidentComboBox.TabIndex = 0;
            // 
            // Add_CtitizenComboBox
            // 
            this.Add_CtitizenComboBox.FormattingEnabled = true;
            this.Add_CtitizenComboBox.Location = new System.Drawing.Point(18, 46);
            this.Add_CtitizenComboBox.Name = "Add_CtitizenComboBox";
            this.Add_CtitizenComboBox.Size = new System.Drawing.Size(421, 24);
            this.Add_CtitizenComboBox.TabIndex = 1;
            // 
            // Add_CarComboBox
            // 
            this.Add_CarComboBox.FormattingEnabled = true;
            this.Add_CarComboBox.Location = new System.Drawing.Point(18, 76);
            this.Add_CarComboBox.Name = "Add_CarComboBox";
            this.Add_CarComboBox.Size = new System.Drawing.Size(421, 24);
            this.Add_CarComboBox.TabIndex = 2;
            // 
            // Add_RoleComboBox
            // 
            this.Add_RoleComboBox.FormattingEnabled = true;
            this.Add_RoleComboBox.Items.AddRange(new object[] {
            "Пострадавший",
            "Виновный"});
            this.Add_RoleComboBox.Location = new System.Drawing.Point(18, 106);
            this.Add_RoleComboBox.Name = "Add_RoleComboBox";
            this.Add_RoleComboBox.Size = new System.Drawing.Size(421, 24);
            this.Add_RoleComboBox.TabIndex = 3;
            // 
            // Add_StateComboBox
            // 
            this.Add_StateComboBox.FormattingEnabled = true;
            this.Add_StateComboBox.Items.AddRange(new object[] {
            "Без травм",
            "Ушиб",
            "Госпитализирован"});
            this.Add_StateComboBox.Location = new System.Drawing.Point(18, 136);
            this.Add_StateComboBox.Name = "Add_StateComboBox";
            this.Add_StateComboBox.Size = new System.Drawing.Size(421, 24);
            this.Add_StateComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Происшествие";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Участник";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Автомобиль участника";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Роль";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Состояние";
            // 
            // Add_AddButton
            // 
            this.Add_AddButton.Location = new System.Drawing.Point(18, 166);
            this.Add_AddButton.Name = "Add_AddButton";
            this.Add_AddButton.Size = new System.Drawing.Size(421, 60);
            this.Add_AddButton.TabIndex = 10;
            this.Add_AddButton.Text = "Добавить";
            this.Add_AddButton.UseVisualStyleBackColor = true;
            this.Add_AddButton.Click += new System.EventHandler(this.Add_AddButton_Click);
            // 
            // Removal_IDtextBox
            // 
            this.Removal_IDtextBox.Location = new System.Drawing.Point(14, 14);
            this.Removal_IDtextBox.Name = "Removal_IDtextBox";
            this.Removal_IDtextBox.Size = new System.Drawing.Size(42, 22);
            this.Removal_IDtextBox.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "ID";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Change_ChangeButton
            // 
            this.Change_ChangeButton.Location = new System.Drawing.Point(14, 191);
            this.Change_ChangeButton.Name = "Change_ChangeButton";
            this.Change_ChangeButton.Size = new System.Drawing.Size(421, 60);
            this.Change_ChangeButton.TabIndex = 21;
            this.Change_ChangeButton.Text = "Изменить";
            this.Change_ChangeButton.UseVisualStyleBackColor = true;
            this.Change_ChangeButton.Click += new System.EventHandler(this.Change_ChangeButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(441, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Состояние";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(441, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Роль";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(441, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Автомобиль участника";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(441, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Участник";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(441, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "Происшествие";
            // 
            // Change_StateComboBox
            // 
            this.Change_StateComboBox.FormattingEnabled = true;
            this.Change_StateComboBox.Items.AddRange(new object[] {
            "Без травм",
            "Ушибы",
            "Госпитализирован"});
            this.Change_StateComboBox.Location = new System.Drawing.Point(14, 161);
            this.Change_StateComboBox.Name = "Change_StateComboBox";
            this.Change_StateComboBox.Size = new System.Drawing.Size(421, 24);
            this.Change_StateComboBox.TabIndex = 15;
            // 
            // Change_RoleComboBox
            // 
            this.Change_RoleComboBox.FormattingEnabled = true;
            this.Change_RoleComboBox.Items.AddRange(new object[] {
            "Потерпевший",
            "Виновный"});
            this.Change_RoleComboBox.Location = new System.Drawing.Point(14, 131);
            this.Change_RoleComboBox.Name = "Change_RoleComboBox";
            this.Change_RoleComboBox.Size = new System.Drawing.Size(421, 24);
            this.Change_RoleComboBox.TabIndex = 14;
            // 
            // Change_CarComboBox
            // 
            this.Change_CarComboBox.FormattingEnabled = true;
            this.Change_CarComboBox.Location = new System.Drawing.Point(14, 101);
            this.Change_CarComboBox.Name = "Change_CarComboBox";
            this.Change_CarComboBox.Size = new System.Drawing.Size(421, 24);
            this.Change_CarComboBox.TabIndex = 13;
            // 
            // Change_CitizenComboBox
            // 
            this.Change_CitizenComboBox.FormattingEnabled = true;
            this.Change_CitizenComboBox.Location = new System.Drawing.Point(14, 71);
            this.Change_CitizenComboBox.Name = "Change_CitizenComboBox";
            this.Change_CitizenComboBox.Size = new System.Drawing.Size(421, 24);
            this.Change_CitizenComboBox.TabIndex = 12;
            // 
            // Change_AccidentComboBox
            // 
            this.Change_AccidentComboBox.FormattingEnabled = true;
            this.Change_AccidentComboBox.Location = new System.Drawing.Point(14, 40);
            this.Change_AccidentComboBox.Name = "Change_AccidentComboBox";
            this.Change_AccidentComboBox.Size = new System.Drawing.Size(421, 24);
            this.Change_AccidentComboBox.TabIndex = 11;
            // 
            // Change_IDtextBox
            // 
            this.Change_IDtextBox.Location = new System.Drawing.Point(14, 12);
            this.Change_IDtextBox.Name = "Change_IDtextBox";
            this.Change_IDtextBox.Size = new System.Drawing.Size(421, 22);
            this.Change_IDtextBox.TabIndex = 22;
            this.Change_IDtextBox.TextChanged += new System.EventHandler(this.Change_IDtextBox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(441, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "ID";
            // 
            // ParticipatorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.TabControll);
            this.Controls.Add(this.GridView);
            this.Name = "ParticipatorsForm";
            this.Text = "База данных. Участники происшествий";
            this.Load += new System.EventHandler(this.ParticipatorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.TabControll.ResumeLayout(false);
            this.SearchingPage.ResumeLayout(false);
            this.SearchingPage.PerformLayout();
            this.NewParticipatorPage.ResumeLayout(false);
            this.NewParticipatorPage.PerformLayout();
            this.RemovalPage.ResumeLayout(false);
            this.RemovalPage.PerformLayout();
            this.ChangePage.ResumeLayout(false);
            this.ChangePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.TabControl TabControll;
        private System.Windows.Forms.TabPage SearchingPage;
        private System.Windows.Forms.TabPage NewParticipatorPage;
        private System.Windows.Forms.TabPage RemovalPage;
        private System.Windows.Forms.TabPage ChangePage;
        private System.Windows.Forms.TextBox Search_IDtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Add_CtitizenComboBox;
        private System.Windows.Forms.ComboBox Add_AccidentComboBox;
        private System.Windows.Forms.ComboBox Add_CarComboBox;
        private System.Windows.Forms.ComboBox Add_RoleComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Add_StateComboBox;
        private System.Windows.Forms.Button Add_AddButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Removal_IDtextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Change_IDtextBox;
        private System.Windows.Forms.Button Change_ChangeButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Change_StateComboBox;
        private System.Windows.Forms.ComboBox Change_RoleComboBox;
        private System.Windows.Forms.ComboBox Change_CarComboBox;
        private System.Windows.Forms.ComboBox Change_CitizenComboBox;
        private System.Windows.Forms.ComboBox Change_AccidentComboBox;
        private System.Windows.Forms.Label label14;
    }
}