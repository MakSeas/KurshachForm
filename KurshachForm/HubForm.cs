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
    public partial class HubForm : Form
    {
        bool admin;

        Form1 mainForm;
        public HubForm()
        {
            InitializeComponent();
        }

        public void Start(Form1 mainForm, bool admin)
        {
            this.mainForm = mainForm;
            this.admin = admin;

            if (admin)
                StartAdmin();

            mainForm.activeForms.Add(this);
        }

        public void StartAdmin()
        {
            this.Text = "База даннвх. Справка - админ доступ";
        }

        private void CitizensButton_Click(object sender, EventArgs e)
        {
            CitizensForm form = new CitizensForm();
            form.Start(admin);
            
            form.Show();
            mainForm.activeForms.Add(form);
        }

        private void CarsButton_Click(object sender, EventArgs e)
        {
            CarForm form = new CarForm();
            form.Start(admin);

            form.Show();
            mainForm.activeForms.Add(form);
        }

        private void DistrictsButton_Click(object sender, EventArgs e)
        {
            DistrictsForm form = new DistrictsForm();
            form.Start(mainForm, admin);

            form.Show();
            mainForm.activeForms.Add(form);
        }
    }
}
