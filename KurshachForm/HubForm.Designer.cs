namespace KurshachForm
{
    partial class HubForm
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
            this.CitizensButton = new System.Windows.Forms.Button();
            this.CarsButton = new System.Windows.Forms.Button();
            this.DistrictsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CitizensButton
            // 
            this.CitizensButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CitizensButton.Location = new System.Drawing.Point(262, 87);
            this.CitizensButton.Name = "CitizensButton";
            this.CitizensButton.Size = new System.Drawing.Size(286, 73);
            this.CitizensButton.TabIndex = 0;
            this.CitizensButton.Text = "Граждане города";
            this.CitizensButton.UseVisualStyleBackColor = true;
            this.CitizensButton.Click += new System.EventHandler(this.CitizensButton_Click);
            // 
            // CarsButton
            // 
            this.CarsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CarsButton.Location = new System.Drawing.Point(262, 166);
            this.CarsButton.Name = "CarsButton";
            this.CarsButton.Size = new System.Drawing.Size(286, 73);
            this.CarsButton.TabIndex = 1;
            this.CarsButton.Text = "Автомобили";
            this.CarsButton.UseVisualStyleBackColor = true;
            this.CarsButton.Click += new System.EventHandler(this.CarsButton_Click);
            // 
            // DistrictsButton
            // 
            this.DistrictsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.DistrictsButton.Location = new System.Drawing.Point(262, 245);
            this.DistrictsButton.Name = "DistrictsButton";
            this.DistrictsButton.Size = new System.Drawing.Size(286, 73);
            this.DistrictsButton.TabIndex = 2;
            this.DistrictsButton.Text = "Районы города";
            this.DistrictsButton.UseVisualStyleBackColor = true;
            this.DistrictsButton.Click += new System.EventHandler(this.DistrictsButton_Click);
            // 
            // HubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DistrictsButton);
            this.Controls.Add(this.CarsButton);
            this.Controls.Add(this.CitizensButton);
            this.Name = "HubForm";
            this.Text = "База данных. Справка";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CitizensButton;
        private System.Windows.Forms.Button CarsButton;
        private System.Windows.Forms.Button DistrictsButton;
    }
}