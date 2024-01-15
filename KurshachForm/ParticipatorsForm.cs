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
    public partial class ParticipatorsForm : Form
    {
        public ParticipatorsForm()
        {
            InitializeComponent();
        }

        private void ParticipatorsForm_Load(object sender, EventArgs e)
        {
            InitializeTablesAndComboBoxes();
        }

        public void InitializeTablesAndComboBoxes()
        {
            GridView.DataSource = DataBaseHandling.visualParticipatorsTable;

            DataBaseHandling.FillCitizensComboBox(Add_CtitizenComboBox);
            DataBaseHandling.FillCitizensComboBox(Change_CitizenComboBox);

            DataBaseHandling.FillAccidentComboBox(Add_AccidentComboBox);
            DataBaseHandling.FillAccidentComboBox(Change_AccidentComboBox);

            DataBaseHandling.FillCarComboBox(Add_CarComboBox);
            DataBaseHandling.FillCarComboBox(Change_CarComboBox);
        }

        public void Start(bool admin)
        {
            TabControll.TabPages.Remove(NewParticipatorPage);
            TabControll.TabPages.Remove(ChangePage);
            TabControll.TabPages.Remove(RemovalPage);

            if (admin)
                StartAdmin();
        }

        void StartAdmin()
        {
            this.Text = "База данных. Участники происшествий - админ доступ";

            TabControll.TabPages.Add(NewParticipatorPage);
            TabControll.TabPages.Add(ChangePage);
            TabControll.TabPages.Add(RemovalPage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Search_IDtextBox.Text != "")
            {
                if (GridView.Rows.Count > 0)
                {
                    GridView.ClearSelection();

                    for (int i = 0; i < GridView.RowCount; i++)
                        if (GridView.Rows[i].Cells[0].Value.ToString() == Search_IDtextBox.Text)
                        {
                            GridView.Rows[i].Selected = true;
                            break;
                        }
                }
            }
        }

        private void Add_AddButton_Click(object sender, EventArgs e)
        {
            if (Add_AccidentComboBox.Text!=""&&Add_CtitizenComboBox.Text!=""&&Add_RoleComboBox.Text!=""&&Add_StateComboBox.Text!="")
            {
                int accidentID = DataBaseHandling.GetAccidentByName(Add_AccidentComboBox.Text);
                int citizenID = DataBaseHandling.GetCitizenByName(Add_CtitizenComboBox.Text);
                int carID = DataBaseHandling.GetCarByName(Add_CarComboBox.Text);

                if (carID == 0)
                    carID = 1;

                string Role = Add_RoleComboBox.Text;
                string State = Add_StateComboBox.Text;

                DataBaseHandling.AddParticipator(accidentID, citizenID, carID, Role, State);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(Removal_IDtextBox.Text);

            if (Removal_IDtextBox.Text != "")
            {
                DataBaseHandling.RemoveParticipator(ID);
            }
        }

        private void Change_IDtextBox_TextChanged(object sender, EventArgs e)
        {
            DataRow row = DataBaseHandling.GetParticipatorByID(int.Parse(Change_IDtextBox.Text));

            if (row != null)
            {
                Change_AccidentComboBox.Text = DataBaseHandling.GetAccidentName(int.Parse(row.ItemArray[1].ToString()));
                Change_CitizenComboBox.Text = row.ItemArray[2].ToString();
                Change_CarComboBox.Text = row.ItemArray[3].ToString();
                Change_RoleComboBox.Text = row.ItemArray[4].ToString();
                Change_StateComboBox.Text = row.ItemArray[5].ToString();
            }
            else
            {
                Change_AccidentComboBox.Text = "";
                Change_CitizenComboBox.Text = "";
                Change_CarComboBox.Text = "";
                Change_RoleComboBox.Text = "";
                Change_StateComboBox.Text = "";
            }
        }

        private void Change_ChangeButton_Click(object sender, EventArgs e)
        {

            int ID=int.Parse(Change_IDtextBox.Text);
            int accidentID = DataBaseHandling.GetAccidentByName(Change_AccidentComboBox.Text);
            int citizenID = DataBaseHandling.GetCitizenByName(Change_CitizenComboBox.Text);
            int carID = DataBaseHandling.GetCarByName(Change_CarComboBox.Text);

            string Role = Change_RoleComboBox.Text;
            string State = Change_StateComboBox.Text;

            DataBaseHandling.ChangeParticipator(ID, accidentID, citizenID, carID, Role, State);
        }
    }
}
