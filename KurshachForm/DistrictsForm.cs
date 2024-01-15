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
    public partial class DistrictsForm : Form
    {
        bool admin;
        Form1 mainForm;

        public DistrictsForm()
        {
            InitializeComponent();
        }

        private void DistrictsForm_Load(object sender, EventArgs e)
        {
            GridView.DataSource = DataBaseHandling.visualDistrictsTable;
        }

        public void Start(Form1 mainForm,bool admin)
        {
            this.admin = admin;
            this.mainForm= mainForm;

            if (admin)
                StartAdmin();
        }

        public void StartAdmin()
        {
            this.Text = "База данных. Районы города - админ доступ";
        }

        private void StreetsButton_Click(object sender, EventArgs e)
        {
            StreetsForm form = new StreetsForm();
            form.Start(admin);

            form.Show();
            mainForm.activeForms.Add(form);
        }
    }
}
