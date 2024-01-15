namespace KurshachForm
{
    partial class DistrictsForm
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
            this.StreetsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(12, 12);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidth = 51;
            this.GridView.RowTemplate.Height = 24;
            this.GridView.Size = new System.Drawing.Size(776, 228);
            this.GridView.TabIndex = 0;
            // 
            // StreetsButton
            // 
            this.StreetsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.StreetsButton.Location = new System.Drawing.Point(12, 246);
            this.StreetsButton.Name = "StreetsButton";
            this.StreetsButton.Size = new System.Drawing.Size(776, 58);
            this.StreetsButton.TabIndex = 1;
            this.StreetsButton.Text = "Улицы города";
            this.StreetsButton.UseVisualStyleBackColor = true;
            this.StreetsButton.Click += new System.EventHandler(this.StreetsButton_Click);
            // 
            // DistrictsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StreetsButton);
            this.Controls.Add(this.GridView);
            this.Name = "DistrictsForm";
            this.Text = "База данных. Районы города";
            this.Load += new System.EventHandler(this.DistrictsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Button StreetsButton;
    }
}