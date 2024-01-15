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
    public partial class CarForm : Form
    {
        bool admin;
        public CarForm()
        {
            InitializeComponent();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            GridView.DataSource = DataBaseHandling.visualCarsTable;
        }

        public void Start(bool admin)
        {
            this.admin = admin;

            if (admin)
                StartAdmin();
        }

        public void StartAdmin()
        {
            this.Text = "База данных. Автомобили - админ доступ";
        }
    }
}
