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
    public partial class CitizensForm : Form
    {
        bool admin;

        public CitizensForm()
        {
            InitializeComponent();
        }

        public void Start(bool admin)
        {
            this.admin = admin;

            Initialize();

            if(admin)
                StartAdmin();
        }

        public void StartAdmin()
        {
            this.Text = "База данных. Граждане города - админ доступ";
        }

        void Initialize()
        {
            DataBaseHandling.FillDistrictComboBox(Filter_DistrictComboBox, 1);
        }

        private void CitizensForm_Load(object sender, EventArgs e)
        {
            GridView.DataSource = DataBaseHandling.visualCitizensTable;
        }

        private void Filter_ApplyButton_Click(object sender, EventArgs e)
        {
            if (Filter_StreetComboBox.Text != "")
            {
                int ID = DataBaseHandling.GetStreetByName(Filter_StreetComboBox.Text);

                GridView.DataSource = DataBaseHandling.GetCitizensByStreet(ID);
            }
        }

        private void Filter_DistrictComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = DataBaseHandling.GetDistrictByName(Filter_DistrictComboBox.Text);

            DataBaseHandling.FillComboBox(Filter_StreetComboBox, 1, ID);
        }

        private void Filter_ResetButton_Click(object sender, EventArgs e)
        {
            GridView.DataSource = DataBaseHandling.visualStreetsTable;
            Filter_StreetComboBox.Text = "";
            Filter_DistrictComboBox.Text = "";
        }
    }
}
