using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KurshachForm
{
    public partial class StreetsForm : Form
    {
        bool admin;
        public StreetsForm()
        {
            InitializeComponent();
        }

        private void StreetsForm_Load(object sender, EventArgs e)
        {
            GridView.DataSource = DataBaseHandling.visualStreetsTable;
        }

        public void Start(bool admin)
        {
            this.admin = admin;


            if (admin)
                StartAdmin();
        }

        

        public void StartAdmin()
        {
            this.Text = "База данных. Граждане - админ доступ";
        }

        private void StreetsButton_Click(object sender, EventArgs e)
        {

        }

        private void Filter_DistrictComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Filter_ApplyButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Filter_ResetButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}
