namespace KurshachForm
{
    partial class AccidentsFrom
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
            this.ParticipatorsButton = new System.Windows.Forms.Button();
            this.TabControll = new System.Windows.Forms.TabControl();
            this.FilterPage = new System.Windows.Forms.TabPage();
            this.Filter_DistrictComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Filter_ResetButton = new System.Windows.Forms.Button();
            this.Filter_ApplyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Filter_StreetComboBox = new System.Windows.Forms.ComboBox();
            this.SearchPage = new System.Windows.Forms.TabPage();
            this.Search_FindButton = new System.Windows.Forms.Button();
            this.Search_IDtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddNewPage = new System.Windows.Forms.TabPage();
            this.Add_DistrictComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Add_AddButton = new System.Windows.Forms.Button();
            this.Add_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.Add_StreetComboBox = new System.Windows.Forms.ComboBox();
            this.Add_AccidentNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RemovalPage = new System.Windows.Forms.TabPage();
            this.Removal_RemoveButton = new System.Windows.Forms.Button();
            this.Removal_IDtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ChangePage = new System.Windows.Forms.TabPage();
            this.Change_ChangeButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Change_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.Change_StreetComboBox = new System.Windows.Forms.ComboBox();
            this.Change_DistrictComboBox = new System.Windows.Forms.ComboBox();
            this.Change_NameTextBox = new System.Windows.Forms.TextBox();
            this.Change_IDtextBox = new System.Windows.Forms.TextBox();
            this.WordPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Word_CitizenComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Word_RoleComboBox = new System.Windows.Forms.ComboBox();
            this.Word_StateComboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.TabControll.SuspendLayout();
            this.FilterPage.SuspendLayout();
            this.SearchPage.SuspendLayout();
            this.AddNewPage.SuspendLayout();
            this.RemovalPage.SuspendLayout();
            this.ChangePage.SuspendLayout();
            this.WordPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(12, 12);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RowHeadersWidth = 51;
            this.GridView.RowTemplate.Height = 24;
            this.GridView.Size = new System.Drawing.Size(776, 293);
            this.GridView.TabIndex = 0;
            // 
            // ParticipatorsButton
            // 
            this.ParticipatorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ParticipatorsButton.Location = new System.Drawing.Point(16, 311);
            this.ParticipatorsButton.Name = "ParticipatorsButton";
            this.ParticipatorsButton.Size = new System.Drawing.Size(768, 55);
            this.ParticipatorsButton.TabIndex = 1;
            this.ParticipatorsButton.Text = "Участники происшествий";
            this.ParticipatorsButton.UseVisualStyleBackColor = true;
            this.ParticipatorsButton.Click += new System.EventHandler(this.ParticipatorsButton_Click);
            // 
            // TabControll
            // 
            this.TabControll.Controls.Add(this.FilterPage);
            this.TabControll.Controls.Add(this.SearchPage);
            this.TabControll.Controls.Add(this.AddNewPage);
            this.TabControll.Controls.Add(this.RemovalPage);
            this.TabControll.Controls.Add(this.ChangePage);
            this.TabControll.Controls.Add(this.WordPage);
            this.TabControll.Location = new System.Drawing.Point(12, 372);
            this.TabControll.Name = "TabControll";
            this.TabControll.SelectedIndex = 0;
            this.TabControll.Size = new System.Drawing.Size(776, 223);
            this.TabControll.TabIndex = 2;
            // 
            // FilterPage
            // 
            this.FilterPage.Controls.Add(this.Filter_DistrictComboBox);
            this.FilterPage.Controls.Add(this.label7);
            this.FilterPage.Controls.Add(this.Filter_ResetButton);
            this.FilterPage.Controls.Add(this.Filter_ApplyButton);
            this.FilterPage.Controls.Add(this.label1);
            this.FilterPage.Controls.Add(this.Filter_StreetComboBox);
            this.FilterPage.Location = new System.Drawing.Point(4, 25);
            this.FilterPage.Name = "FilterPage";
            this.FilterPage.Padding = new System.Windows.Forms.Padding(3);
            this.FilterPage.Size = new System.Drawing.Size(768, 194);
            this.FilterPage.TabIndex = 0;
            this.FilterPage.Text = "Фильтр";
            this.FilterPage.UseVisualStyleBackColor = true;
            // 
            // Filter_DistrictComboBox
            // 
            this.Filter_DistrictComboBox.FormattingEnabled = true;
            this.Filter_DistrictComboBox.Location = new System.Drawing.Point(60, 14);
            this.Filter_DistrictComboBox.Name = "Filter_DistrictComboBox";
            this.Filter_DistrictComboBox.Size = new System.Drawing.Size(191, 24);
            this.Filter_DistrictComboBox.TabIndex = 6;
            this.Filter_DistrictComboBox.SelectedIndexChanged += new System.EventHandler(this.Filter_DistrictComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Район";
            // 
            // Filter_ResetButton
            // 
            this.Filter_ResetButton.Location = new System.Drawing.Point(161, 83);
            this.Filter_ResetButton.Name = "Filter_ResetButton";
            this.Filter_ResetButton.Size = new System.Drawing.Size(90, 23);
            this.Filter_ResetButton.TabIndex = 4;
            this.Filter_ResetButton.Text = "Сбросить";
            this.Filter_ResetButton.UseVisualStyleBackColor = true;
            this.Filter_ResetButton.Click += new System.EventHandler(this.Filter_ResetButton_Click);
            // 
            // Filter_ApplyButton
            // 
            this.Filter_ApplyButton.Location = new System.Drawing.Point(63, 83);
            this.Filter_ApplyButton.Name = "Filter_ApplyButton";
            this.Filter_ApplyButton.Size = new System.Drawing.Size(92, 23);
            this.Filter_ApplyButton.TabIndex = 3;
            this.Filter_ApplyButton.Text = "Применить";
            this.Filter_ApplyButton.UseVisualStyleBackColor = true;
            this.Filter_ApplyButton.Click += new System.EventHandler(this.Filter_ApplyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Улица";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Filter_StreetComboBox
            // 
            this.Filter_StreetComboBox.FormattingEnabled = true;
            this.Filter_StreetComboBox.Location = new System.Drawing.Point(60, 53);
            this.Filter_StreetComboBox.Name = "Filter_StreetComboBox";
            this.Filter_StreetComboBox.Size = new System.Drawing.Size(191, 24);
            this.Filter_StreetComboBox.TabIndex = 1;
            this.Filter_StreetComboBox.SelectedIndexChanged += new System.EventHandler(this.Filter_StreetComboBox_SelectedIndexChanged);
            // 
            // SearchPage
            // 
            this.SearchPage.Controls.Add(this.Search_FindButton);
            this.SearchPage.Controls.Add(this.Search_IDtextBox);
            this.SearchPage.Controls.Add(this.label2);
            this.SearchPage.Location = new System.Drawing.Point(4, 25);
            this.SearchPage.Name = "SearchPage";
            this.SearchPage.Size = new System.Drawing.Size(768, 194);
            this.SearchPage.TabIndex = 1;
            this.SearchPage.Text = "Поиск";
            this.SearchPage.UseVisualStyleBackColor = true;
            // 
            // Search_FindButton
            // 
            this.Search_FindButton.Location = new System.Drawing.Point(147, 6);
            this.Search_FindButton.Name = "Search_FindButton";
            this.Search_FindButton.Size = new System.Drawing.Size(75, 23);
            this.Search_FindButton.TabIndex = 2;
            this.Search_FindButton.Text = "Найти";
            this.Search_FindButton.UseVisualStyleBackColor = true;
            this.Search_FindButton.Click += new System.EventHandler(this.Search_FindButton_Click);
            // 
            // Search_IDtextBox
            // 
            this.Search_IDtextBox.Location = new System.Drawing.Point(41, 6);
            this.Search_IDtextBox.Name = "Search_IDtextBox";
            this.Search_IDtextBox.Size = new System.Drawing.Size(100, 22);
            this.Search_IDtextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // AddNewPage
            // 
            this.AddNewPage.Controls.Add(this.Add_DistrictComboBox);
            this.AddNewPage.Controls.Add(this.label8);
            this.AddNewPage.Controls.Add(this.Add_AddButton);
            this.AddNewPage.Controls.Add(this.Add_DatePicker);
            this.AddNewPage.Controls.Add(this.Add_StreetComboBox);
            this.AddNewPage.Controls.Add(this.Add_AccidentNameTextBox);
            this.AddNewPage.Controls.Add(this.label5);
            this.AddNewPage.Controls.Add(this.label4);
            this.AddNewPage.Controls.Add(this.label3);
            this.AddNewPage.Location = new System.Drawing.Point(4, 25);
            this.AddNewPage.Name = "AddNewPage";
            this.AddNewPage.Size = new System.Drawing.Size(768, 194);
            this.AddNewPage.TabIndex = 2;
            this.AddNewPage.Text = "Добавить";
            this.AddNewPage.UseVisualStyleBackColor = true;
            // 
            // Add_DistrictComboBox
            // 
            this.Add_DistrictComboBox.FormattingEnabled = true;
            this.Add_DistrictComboBox.Location = new System.Drawing.Point(16, 37);
            this.Add_DistrictComboBox.Name = "Add_DistrictComboBox";
            this.Add_DistrictComboBox.Size = new System.Drawing.Size(146, 24);
            this.Add_DistrictComboBox.TabIndex = 9;
            this.Add_DistrictComboBox.SelectedIndexChanged += new System.EventHandler(this.Add_DistrictComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Район";
            // 
            // Add_AddButton
            // 
            this.Add_AddButton.Location = new System.Drawing.Point(16, 120);
            this.Add_AddButton.Name = "Add_AddButton";
            this.Add_AddButton.Size = new System.Drawing.Size(354, 52);
            this.Add_AddButton.TabIndex = 6;
            this.Add_AddButton.Text = "Внести запись о происшествии";
            this.Add_AddButton.UseVisualStyleBackColor = true;
            this.Add_AddButton.Click += new System.EventHandler(this.Add_AddButton_Click);
            // 
            // Add_DatePicker
            // 
            this.Add_DatePicker.Location = new System.Drawing.Point(16, 92);
            this.Add_DatePicker.Name = "Add_DatePicker";
            this.Add_DatePicker.Size = new System.Drawing.Size(146, 22);
            this.Add_DatePicker.TabIndex = 5;
            // 
            // Add_StreetComboBox
            // 
            this.Add_StreetComboBox.FormattingEnabled = true;
            this.Add_StreetComboBox.Location = new System.Drawing.Point(16, 64);
            this.Add_StreetComboBox.Name = "Add_StreetComboBox";
            this.Add_StreetComboBox.Size = new System.Drawing.Size(146, 24);
            this.Add_StreetComboBox.TabIndex = 4;
            // 
            // Add_AccidentNameTextBox
            // 
            this.Add_AccidentNameTextBox.Location = new System.Drawing.Point(16, 11);
            this.Add_AccidentNameTextBox.Name = "Add_AccidentNameTextBox";
            this.Add_AccidentNameTextBox.Size = new System.Drawing.Size(146, 22);
            this.Add_AccidentNameTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Улица";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Наименование происшествия";
            // 
            // RemovalPage
            // 
            this.RemovalPage.Controls.Add(this.Removal_RemoveButton);
            this.RemovalPage.Controls.Add(this.Removal_IDtextBox);
            this.RemovalPage.Controls.Add(this.label6);
            this.RemovalPage.Location = new System.Drawing.Point(4, 25);
            this.RemovalPage.Name = "RemovalPage";
            this.RemovalPage.Size = new System.Drawing.Size(768, 194);
            this.RemovalPage.TabIndex = 3;
            this.RemovalPage.Text = "Удалить";
            this.RemovalPage.UseVisualStyleBackColor = true;
            // 
            // Removal_RemoveButton
            // 
            this.Removal_RemoveButton.Location = new System.Drawing.Point(13, 35);
            this.Removal_RemoveButton.Name = "Removal_RemoveButton";
            this.Removal_RemoveButton.Size = new System.Drawing.Size(231, 48);
            this.Removal_RemoveButton.TabIndex = 2;
            this.Removal_RemoveButton.Text = "Удалить запись о происшествии";
            this.Removal_RemoveButton.UseVisualStyleBackColor = true;
            this.Removal_RemoveButton.Click += new System.EventHandler(this.Removal_RemoveButton_Click);
            // 
            // Removal_IDtextBox
            // 
            this.Removal_IDtextBox.Location = new System.Drawing.Point(13, 7);
            this.Removal_IDtextBox.Name = "Removal_IDtextBox";
            this.Removal_IDtextBox.Size = new System.Drawing.Size(98, 22);
            this.Removal_IDtextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID происшествия";
            // 
            // ChangePage
            // 
            this.ChangePage.Controls.Add(this.Change_ChangeButton);
            this.ChangePage.Controls.Add(this.label13);
            this.ChangePage.Controls.Add(this.label12);
            this.ChangePage.Controls.Add(this.label11);
            this.ChangePage.Controls.Add(this.label10);
            this.ChangePage.Controls.Add(this.label9);
            this.ChangePage.Controls.Add(this.Change_DatePicker);
            this.ChangePage.Controls.Add(this.Change_StreetComboBox);
            this.ChangePage.Controls.Add(this.Change_DistrictComboBox);
            this.ChangePage.Controls.Add(this.Change_NameTextBox);
            this.ChangePage.Controls.Add(this.Change_IDtextBox);
            this.ChangePage.Location = new System.Drawing.Point(4, 25);
            this.ChangePage.Name = "ChangePage";
            this.ChangePage.Size = new System.Drawing.Size(768, 194);
            this.ChangePage.TabIndex = 4;
            this.ChangePage.Text = "Изменить";
            this.ChangePage.UseVisualStyleBackColor = true;
            // 
            // Change_ChangeButton
            // 
            this.Change_ChangeButton.Location = new System.Drawing.Point(15, 158);
            this.Change_ChangeButton.Name = "Change_ChangeButton";
            this.Change_ChangeButton.Size = new System.Drawing.Size(216, 36);
            this.Change_ChangeButton.TabIndex = 10;
            this.Change_ChangeButton.Text = "Изменить";
            this.Change_ChangeButton.UseVisualStyleBackColor = true;
            this.Change_ChangeButton.Click += new System.EventHandler(this.Change_ChangeButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(183, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "Дата";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(183, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Улица";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(183, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Район";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(183, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(183, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "ID";
            // 
            // Change_DatePicker
            // 
            this.Change_DatePicker.Location = new System.Drawing.Point(15, 129);
            this.Change_DatePicker.Name = "Change_DatePicker";
            this.Change_DatePicker.Size = new System.Drawing.Size(160, 22);
            this.Change_DatePicker.TabIndex = 4;
            // 
            // Change_StreetComboBox
            // 
            this.Change_StreetComboBox.FormattingEnabled = true;
            this.Change_StreetComboBox.Location = new System.Drawing.Point(15, 99);
            this.Change_StreetComboBox.Name = "Change_StreetComboBox";
            this.Change_StreetComboBox.Size = new System.Drawing.Size(160, 24);
            this.Change_StreetComboBox.TabIndex = 3;
            // 
            // Change_DistrictComboBox
            // 
            this.Change_DistrictComboBox.FormattingEnabled = true;
            this.Change_DistrictComboBox.Location = new System.Drawing.Point(15, 69);
            this.Change_DistrictComboBox.Name = "Change_DistrictComboBox";
            this.Change_DistrictComboBox.Size = new System.Drawing.Size(160, 24);
            this.Change_DistrictComboBox.TabIndex = 2;
            this.Change_DistrictComboBox.SelectedIndexChanged += new System.EventHandler(this.Change_DistrictComboBox_SelectedIndexChanged);
            // 
            // Change_NameTextBox
            // 
            this.Change_NameTextBox.Location = new System.Drawing.Point(15, 41);
            this.Change_NameTextBox.Name = "Change_NameTextBox";
            this.Change_NameTextBox.Size = new System.Drawing.Size(160, 22);
            this.Change_NameTextBox.TabIndex = 1;
            // 
            // Change_IDtextBox
            // 
            this.Change_IDtextBox.Location = new System.Drawing.Point(15, 13);
            this.Change_IDtextBox.Name = "Change_IDtextBox";
            this.Change_IDtextBox.Size = new System.Drawing.Size(160, 22);
            this.Change_IDtextBox.TabIndex = 0;
            this.Change_IDtextBox.TextChanged += new System.EventHandler(this.Change_IDtextBox_TextChanged);
            // 
            // WordPage
            // 
            this.WordPage.Controls.Add(this.label16);
            this.WordPage.Controls.Add(this.label15);
            this.WordPage.Controls.Add(this.label14);
            this.WordPage.Controls.Add(this.Word_StateComboBox);
            this.WordPage.Controls.Add(this.Word_RoleComboBox);
            this.WordPage.Controls.Add(this.button1);
            this.WordPage.Controls.Add(this.Word_CitizenComboBox);
            this.WordPage.Location = new System.Drawing.Point(4, 25);
            this.WordPage.Name = "WordPage";
            this.WordPage.Size = new System.Drawing.Size(768, 194);
            this.WordPage.TabIndex = 5;
            this.WordPage.Text = "Сводка";
            this.WordPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "Отобразить сводку по происшествию в Word";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Word_CitizenComboBox
            // 
            this.Word_CitizenComboBox.FormattingEnabled = true;
            this.Word_CitizenComboBox.Location = new System.Drawing.Point(3, 13);
            this.Word_CitizenComboBox.Name = "Word_CitizenComboBox";
            this.Word_CitizenComboBox.Size = new System.Drawing.Size(268, 24);
            this.Word_CitizenComboBox.TabIndex = 0;
            // 
            // Word_RoleComboBox
            // 
            this.Word_RoleComboBox.FormattingEnabled = true;
            this.Word_RoleComboBox.Items.AddRange(new object[] {
            "Пострадавший",
            "Виновный"});
            this.Word_RoleComboBox.Location = new System.Drawing.Point(3, 43);
            this.Word_RoleComboBox.Name = "Word_RoleComboBox";
            this.Word_RoleComboBox.Size = new System.Drawing.Size(268, 24);
            this.Word_RoleComboBox.TabIndex = 2;
            // 
            // Word_StateComboBox
            // 
            this.Word_StateComboBox.FormattingEnabled = true;
            this.Word_StateComboBox.Items.AddRange(new object[] {
            "Без травм",
            "Ушиб",
            "Госпитализирован"});
            this.Word_StateComboBox.Location = new System.Drawing.Point(3, 73);
            this.Word_StateComboBox.Name = "Word_StateComboBox";
            this.Word_StateComboBox.Size = new System.Drawing.Size(268, 24);
            this.Word_StateComboBox.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(277, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Участник";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(277, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 16);
            this.label15.TabIndex = 5;
            this.label15.Text = "Роль";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(277, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 16);
            this.label16.TabIndex = 6;
            this.label16.Text = "Состояние";
            // 
            // AccidentsFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.TabControll);
            this.Controls.Add(this.ParticipatorsButton);
            this.Controls.Add(this.GridView);
            this.Name = "AccidentsFrom";
            this.Text = "База данных. Происшествия";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccidentsFrom_FormClosing);
            this.Load += new System.EventHandler(this.AccidentsFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.TabControll.ResumeLayout(false);
            this.FilterPage.ResumeLayout(false);
            this.FilterPage.PerformLayout();
            this.SearchPage.ResumeLayout(false);
            this.SearchPage.PerformLayout();
            this.AddNewPage.ResumeLayout(false);
            this.AddNewPage.PerformLayout();
            this.RemovalPage.ResumeLayout(false);
            this.RemovalPage.PerformLayout();
            this.ChangePage.ResumeLayout(false);
            this.ChangePage.PerformLayout();
            this.WordPage.ResumeLayout(false);
            this.WordPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Button ParticipatorsButton;
        private System.Windows.Forms.TabControl TabControll;
        private System.Windows.Forms.TabPage FilterPage;
        private System.Windows.Forms.TabPage SearchPage;
        private System.Windows.Forms.TabPage AddNewPage;
        private System.Windows.Forms.TabPage RemovalPage;
        private System.Windows.Forms.Button Filter_ApplyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Filter_StreetComboBox;
        private System.Windows.Forms.Button Filter_ResetButton;
        private System.Windows.Forms.Button Search_FindButton;
        private System.Windows.Forms.TextBox Search_IDtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Add_DatePicker;
        private System.Windows.Forms.ComboBox Add_StreetComboBox;
        private System.Windows.Forms.TextBox Add_AccidentNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Add_AddButton;
        private System.Windows.Forms.TextBox Removal_IDtextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Filter_DistrictComboBox;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox Add_DistrictComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Removal_RemoveButton;
        private System.Windows.Forms.TabPage ChangePage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker Change_DatePicker;
        private System.Windows.Forms.ComboBox Change_StreetComboBox;
        private System.Windows.Forms.ComboBox Change_DistrictComboBox;
        private System.Windows.Forms.TextBox Change_NameTextBox;
        private System.Windows.Forms.TextBox Change_IDtextBox;
        private System.Windows.Forms.Button Change_ChangeButton;
        private System.Windows.Forms.TabPage WordPage;
        private System.Windows.Forms.ComboBox Word_CitizenComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox Word_StateComboBox;
        private System.Windows.Forms.ComboBox Word_RoleComboBox;
    }
}