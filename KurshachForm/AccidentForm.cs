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
    public partial class AccidentsFrom : Form
    {
        Form1 mainForm=null;

        bool admin;

        public AccidentsFrom()
        {
            InitializeComponent();
        }

        private void AccidentsFrom_Load(object sender, EventArgs e)
        {
            InitializeTablesAndComboBoxes();
        }

        public void Start(Form1 mainForm, bool admin)
        {
            this.mainForm = mainForm;

            TabControll.TabPages.Remove(AddNewPage);
            TabControll.TabPages.Remove(RemovalPage);
            TabControll.TabPages.Remove(ChangePage);

            if (admin)
                StartAdmin();
        }

        void InitializeTablesAndComboBoxes()
        {
            GridView.DataSource = DataBaseHandling.visualAccidentsTable;
            DataBaseHandling.FillDistrictComboBox(Filter_DistrictComboBox, 1);
            DataBaseHandling.FillDistrictComboBox(Add_DistrictComboBox, 1);
            DataBaseHandling.FillDistrictComboBox(Change_DistrictComboBox, 1);

            DataBaseHandling.FillCitizensComboBox(Word_CitizenComboBox);
        }

        public void StartAdmin()
        {
            this.Text = "База данных. Происшествия - админ доступ";

            TabControll.TabPages.Add(AddNewPage);
            TabControll.TabPages.Add(RemovalPage);
            TabControll.TabPages.Add(ChangePage);

            admin=true; 
        }

        private void AccidentsFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.activeForms.Remove(this);
        }

        private void Filter_ApplyButton_Click(object sender, EventArgs e)
        {
            if (Filter_StreetComboBox.Text != "")
            {
                int ID = DataBaseHandling.GetStreetByName(Filter_StreetComboBox.Text);

                GridView.DataSource = DataBaseHandling.GetAccidentByStreet(ID);
            }
        }

        private void Filter_ResetButton_Click(object sender, EventArgs e)
        {
            GridView.DataSource = DataBaseHandling.accidentsTable;
            Filter_StreetComboBox.Text = "";
            Filter_DistrictComboBox.Text = "";
        }

        private void Search_FindButton_Click(object sender, EventArgs e)
        {
            if (Search_IDtextBox.Text != "")
            {
                if (GridView.Rows.Count > 0)
                {
                    GridView.ClearSelection();

                    for (int i=0;i<GridView.RowCount;i++)
                        if (GridView.Rows[i].Cells[0].Value.ToString() == Search_IDtextBox.Text)
                        {
                            GridView.Rows[i].Selected = true;
                            break;
                        }
                }
            }
        }

        private void Filter_StreetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Filter_DistrictComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID=DataBaseHandling.GetDistrictByName(Filter_DistrictComboBox.Text);

            DataBaseHandling.FillComboBox(Filter_StreetComboBox, 1, ID);
        }

        private void Add_DistrictComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = DataBaseHandling.GetDistrictByName(Add_DistrictComboBox.Text);

            DataBaseHandling.FillComboBox(Add_StreetComboBox, 1, ID);
        }

        private void Add_AddButton_Click(object sender, EventArgs e)
        {
            string name=Add_AccidentNameTextBox.Text;
            int StreetID =DataBaseHandling.GetStreetByName(Add_StreetComboBox.Text);

            if (Add_AccidentNameTextBox.Text != "" && Add_StreetComboBox.Text != "")
            {
                DataBaseHandling.AddNewAccident(name, StreetID, Add_DatePicker.Value);
                DataBaseHandling.RefreshAccidentTable(GridView);
                GridView.Refresh();
            }
        }

        private void Removal_RemoveButton_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(Removal_IDtextBox.Text);

            if (Removal_IDtextBox.Text != "")
            {
                DataBaseHandling.RemoveAccident(ID);
                GridView.Refresh();
            }
        }

        private void Change_IDtextBox_TextChanged(object sender, EventArgs e)
        {
            DataRow row = DataBaseHandling.GetAccidentByID(int.Parse(Change_IDtextBox.Text));

            if (row != null)
            {
                Change_NameTextBox.Text = row.ItemArray[1].ToString();
                Change_StreetComboBox.Text= row.ItemArray[2].ToString();
                Change_DatePicker.Value = DateTime.Parse(row.ItemArray[3].ToString());
            }
            else
            {
                Change_NameTextBox.Text = "";
                Change_StreetComboBox.Text = "";
            }
        }

        private void Change_DistrictComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = DataBaseHandling.GetDistrictByName(Change_DistrictComboBox.Text);

            DataBaseHandling.FillComboBox(Change_StreetComboBox, 1, id);
        }

        private void Change_ChangeButton_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(Change_IDtextBox.Text);
            int StreetID = DataBaseHandling.GetStreetByName(Change_StreetComboBox.Text);

            if (Change_IDtextBox.Text!="")
            {
                DataBaseHandling.ChangeAccident(ID, Change_NameTextBox.Text, StreetID, Change_DatePicker.Value);
                GridView.Refresh();
            }
        }

        private void ParticipatorsButton_Click(object sender, EventArgs e)
        {
            ParticipatorsForm form = new ParticipatorsForm();

            form.Start(admin);
            form.Show();
            mainForm.activeForms.Add(form);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Word_CitizenComboBox.Text != "")
            {
                string name = Word_CitizenComboBox.Text;
                string role = Word_RoleComboBox.Text;
                string state = Word_StateComboBox.Text;

                DataBaseHandling.ShowWordAccident(name, role, state);
            }

        }
    }
}
