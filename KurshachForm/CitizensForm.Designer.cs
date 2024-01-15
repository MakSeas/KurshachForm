namespace KurshachForm
{
    partial class CitizensForm
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
            this.FilterPage = new System.Windows.Forms.TabPage();
            this.Filter_DistrictComboBox = new System.Windows.Forms.ComboBox();
            this.Filter_ResetButton = new System.Windows.Forms.Button();
            this.Filter_ApplyButton = new System.Windows.Forms.Button();
            this.Filter_StreetComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.TabControll.SuspendLayout();
            this.FilterPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(12, 12);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidth = 51;
            this.GridView.RowTemplate.Height = 24;
            this.GridView.Size = new System.Drawing.Size(776, 234);
            this.GridView.TabIndex = 0;
            // 
            // TabControll
            // 
            this.TabControll.Controls.Add(this.FilterPage);
            this.TabControll.Location = new System.Drawing.Point(12, 271);
            this.TabControll.Name = "TabControll";
            this.TabControll.SelectedIndex = 0;
            this.TabControll.Size = new System.Drawing.Size(776, 158);
            this.TabControll.TabIndex = 3;
            // 
            // FilterPage
            // 
            this.FilterPage.Controls.Add(this.Filter_DistrictComboBox);
            this.FilterPage.Controls.Add(this.Filter_ResetButton);
            this.FilterPage.Controls.Add(this.Filter_ApplyButton);
            this.FilterPage.Controls.Add(this.Filter_StreetComboBox);
            this.FilterPage.Location = new System.Drawing.Point(4, 25);
            this.FilterPage.Name = "FilterPage";
            this.FilterPage.Padding = new System.Windows.Forms.Padding(3);
            this.FilterPage.Size = new System.Drawing.Size(768, 129);
            this.FilterPage.TabIndex = 0;
            this.FilterPage.Text = "Фильтр";
            this.FilterPage.UseVisualStyleBackColor = true;
            // 
            // Filter_DistrictComboBox
            // 
            this.Filter_DistrictComboBox.FormattingEnabled = true;
            this.Filter_DistrictComboBox.Location = new System.Drawing.Point(6, 6);
            this.Filter_DistrictComboBox.Name = "Filter_DistrictComboBox";
            this.Filter_DistrictComboBox.Size = new System.Drawing.Size(249, 24);
            this.Filter_DistrictComboBox.TabIndex = 3;
            this.Filter_DistrictComboBox.SelectedIndexChanged += new System.EventHandler(this.Filter_DistrictComboBox_SelectedIndexChanged);
            // 
            // Filter_ResetButton
            // 
            this.Filter_ResetButton.Location = new System.Drawing.Point(132, 62);
            this.Filter_ResetButton.Name = "Filter_ResetButton";
            this.Filter_ResetButton.Size = new System.Drawing.Size(123, 23);
            this.Filter_ResetButton.TabIndex = 2;
            this.Filter_ResetButton.Text = "Сбросить";
            this.Filter_ResetButton.UseVisualStyleBackColor = true;
            this.Filter_ResetButton.Click += new System.EventHandler(this.Filter_ResetButton_Click);
            // 
            // Filter_ApplyButton
            // 
            this.Filter_ApplyButton.Location = new System.Drawing.Point(6, 62);
            this.Filter_ApplyButton.Name = "Filter_ApplyButton";
            this.Filter_ApplyButton.Size = new System.Drawing.Size(123, 23);
            this.Filter_ApplyButton.TabIndex = 1;
            this.Filter_ApplyButton.Text = "Применить";
            this.Filter_ApplyButton.UseVisualStyleBackColor = true;
            this.Filter_ApplyButton.Click += new System.EventHandler(this.Filter_ApplyButton_Click);
            // 
            // Filter_StreetComboBox
            // 
            this.Filter_StreetComboBox.FormattingEnabled = true;
            this.Filter_StreetComboBox.Location = new System.Drawing.Point(6, 32);
            this.Filter_StreetComboBox.Name = "Filter_StreetComboBox";
            this.Filter_StreetComboBox.Size = new System.Drawing.Size(249, 24);
            this.Filter_StreetComboBox.TabIndex = 0;
            // 
            // CitizensForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControll);
            this.Controls.Add(this.GridView);
            this.Name = "CitizensForm";
            this.Text = "База данных. Граждане города";
            this.Load += new System.EventHandler(this.CitizensForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.TabControll.ResumeLayout(false);
            this.FilterPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.TabControl TabControll;
        private System.Windows.Forms.TabPage FilterPage;
        private System.Windows.Forms.ComboBox Filter_DistrictComboBox;
        private System.Windows.Forms.Button Filter_ResetButton;
        private System.Windows.Forms.Button Filter_ApplyButton;
        private System.Windows.Forms.ComboBox Filter_StreetComboBox;
    }
}