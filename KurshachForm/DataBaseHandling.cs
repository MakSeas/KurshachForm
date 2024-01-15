using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Interop.Word;

namespace KurshachForm
{
    public static class DataBaseHandling
    {
        private static Microsoft.Office.Interop.Word.Application wordapp;
        private static Microsoft.Office.Interop.Word.Document worddocument;
        private static Microsoft.Office.Interop.Word.Documents worddocuments;
        private static Microsoft.Office.Interop.Word.Paragraphs wordparagraphs;
        private static Microsoft.Office.Interop.Word.Paragraph wordparagraph;
        private static Microsoft.Office.Interop.Word.Range wordrange;

        static SqlConnection connection;
        static SqlDataAdapter accidentsAdapter;

        public static System.Data.DataTable carsTable=new System.Data.DataTable();
        public static System.Data.DataTable accidentsTable=new System.Data.DataTable();
        public static System.Data.DataTable citizensTable = new System.Data.DataTable();
        public static System.Data.DataTable districtsTable=new System.Data.DataTable();
        public static System.Data.DataTable streetsTable=new System.Data.DataTable();
        public static System.Data.DataTable participatorsTable=new System.Data.DataTable();

        public static System.Data.DataTable visualParticipatorsTable = new System.Data.DataTable();
        public static System.Data.DataTable visualAccidentsTable = new System.Data.DataTable();
        public static System.Data.DataTable visualCitizensTable = new System.Data.DataTable();
        public static System.Data.DataTable visualCarsTable = new System.Data.DataTable();
        public static System.Data.DataTable visualStreetsTable = new System.Data.DataTable();
        public static System.Data.DataTable visualDistrictsTable = new System.Data.DataTable();

        public static void Initialize()
        {
            string connectionString = "Data Source=PC2; Initial Catalog=Kursachik; Integrated Security=True";
            connection = new SqlConnection(connectionString);

            SqlCommand getAccidentsCommand = new SqlCommand();
            getAccidentsCommand.Connection = connection;
            getAccidentsCommand.CommandText = "SELECT ID, Name, StreetID, Date FROM dbo.RoadAccidents";

            accidentsAdapter=new SqlDataAdapter(getAccidentsCommand);

            connection.Open();

            accidentsAdapter.Fill(accidentsTable);

            SqlDataAdapter visualAccidentDataAdapter = new SqlDataAdapter("select RoadAccidents.ID, RoadAccidents.Name as Наименование, Streets.Name as Улица, Date as Дата from RoadAccidents inner join Streets on RoadAccidents.StreetID=Streets.ID", connection);
            visualAccidentDataAdapter.Fill(visualAccidentsTable);

            SqlDataAdapter streetsDataAdapter=new SqlDataAdapter("select * from Streets", connection);
            streetsDataAdapter.Fill(streetsTable);

            SqlDataAdapter participatorAdapter=new SqlDataAdapter("select * from Participators", connection);
            participatorAdapter.Fill(participatorsTable);

            SqlDataAdapter visualParticipatorAdapter = new SqlDataAdapter("select Participators.ID as ID, Participators.AccidentID as Происшествие, Citizens.Name as ФИО, Cars.License as Автомобиль, Role as Роль, State as Состояние from Participators inner join Citizens on CitizenID=Citizens.ID inner join Cars on ControlledCarID=Cars.ID", connection);
            visualParticipatorAdapter.Fill(visualParticipatorsTable);

            SqlDataAdapter carsAdapter=new SqlDataAdapter("select * from Cars", connection);
            carsAdapter.Fill(carsTable);


            SqlDataAdapter districtAdapter = new SqlDataAdapter("select * from Districts", connection);
            districtAdapter.Fill(districtsTable);

            SqlDataAdapter citizenAdapter = new SqlDataAdapter("select * from Citizens", connection);
            citizenAdapter.Fill(citizensTable);

            SqlDataAdapter visualCitizenAdapter = new SqlDataAdapter("select Citizens.ID as ID, Citizens.Name as Имя, Streets.Name as Адрес, Birthdate as Рожден from Citizens inner join Streets on Citizens.StreetID=Streets.ID", connection);
            visualCitizenAdapter.Fill(visualCitizensTable);

            SqlDataAdapter visualCarsAdapter = new SqlDataAdapter("select ID as ID, Name as Название, Color as Цвет, License as Госномер, RegistrationDate as Зарегестрирован from Cars where ID!=1",connection);
            visualCarsAdapter.Fill(visualCarsTable);

            SqlDataAdapter visualDistrictsAdapter = new SqlDataAdapter("select ID as ID, Name as Название from Districts", connection);
            visualDistrictsAdapter.Fill(visualDistrictsTable);

            SqlDataAdapter visualStreetsAdapter = new SqlDataAdapter("select Streets.ID as ID, Streets.Name as Название, Districts.Name as Район from Streets inner join Districts on Streets.DistrictID=Districts.ID ", connection);
            visualStreetsAdapter.Fill(visualStreetsTable);
            //SqlDataAdapter participatorAdapter = new SqlDataAdapter("select * from PArticipators", connection);

            connection.Close();
        }

        public static void ShowWordAccident(string name, string role, string state)
        {

            int id = GetCitizenByName(name);

            SqlDataAdapter adapter=new SqlDataAdapter($"Select * from dbo.GetParticipators({id},'{role}','{state}')", connection);
            System.Data.DataTable table=new System.Data.DataTable();
            adapter.Fill(table);

            Form form = new Form();
            

            DataGridView gridView=new DataGridView();
            form.Controls.Add(gridView);
            gridView.DataSource = table;

            wordapp = new Microsoft.Office.Interop.Word.Application();
            wordapp.Visible = true;

            object template = Type.Missing;
            Object newTemplate = false;
            Object documentType = Microsoft.Office.Interop.Word.WdNewDocumentType.wdNewBlankDocument;
            Object visible = true;

            Microsoft.Office.Interop.Word._Document word_doc = wordapp.Documents.Add(ref template, ref newTemplate, ref documentType, ref visible);

            Object number = 1;
            worddocument = (Microsoft.Office.Interop.Word.Document)wordapp.Documents.get_Item(ref number);
            object oMissing = System.Reflection.Missing.Value;
            worddocument.Paragraphs.Add(ref oMissing);

            int RowCount = table.Rows.Count;
            int ColumnCount = table.Columns.Count;
            //Переходим к первому добавленному параграфу
            wordparagraph = worddocument.Paragraphs[1];
            //Word.Range wordrange = wordparagraph.Range;
            Object start = 0;
            Object end = 0;
            Microsoft.Office.Interop.Word.Range wordrange = worddocument.Range(ref start, ref end);
            Object defaultTableBehavior = Microsoft.Office.Interop.Word.WdDefaultTableBehavior.wdWord9TableBehavior;
            Object autoFitBehavior = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitWindow;
            //Добавляем таблицу и получаем объект wordtable 
            
            Paragraph information = worddocument.Paragraphs.Add();
            information.Range.Text = $"Все случаи, когда {name} {role} и исход происшествия - {state}:";

            //Table wordtable = worddocument.Tables.Add(worddocument.Paragraphs[1].Range, RowCount + 1, ColumnCount);
            Microsoft.Office.Interop.Word.Table wordtable = worddocument.Tables.Add(worddocument.Paragraphs.Last.Range, RowCount + 1, ColumnCount);
            //Word.Table wordtable = worddocument.Tables.Add(wordrange, 5, 5, ref defaultTableBehavior, ref autoFitBehavior);
            wordtable.Borders.Enable = 1; // Устанавливает видимость границ
            for (int i = 0; i < ColumnCount; i++)
            {
                wordtable.Cell(1, i + 1).Range.Text = gridView.Columns[i].HeaderText;
            }
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    wordtable.Cell(i + 2, j + 1).Range.Text = gridView[j, i].Value.ToString();
                }
            }

        }

        public static void RefreshAccidentTable(DataGridView grid)
        {
            SqlCommand getAccidentsCommand = new SqlCommand();
            getAccidentsCommand.Connection = connection;
            getAccidentsCommand.CommandText = "SELECT ID, Name, StreetID, Date FROM dbo.RoadAccidents";

            accidentsAdapter = new SqlDataAdapter(getAccidentsCommand);

            accidentsTable=new System.Data.DataTable();
            visualAccidentsTable=new System.Data.DataTable();

            accidentsAdapter.Fill(accidentsTable);

            grid.DataSource = accidentsTable;

            SqlDataAdapter visualAccidentDataAdapter = new SqlDataAdapter("select RoadAccidents.ID, RoadAccidents.Name as Наименование, Streets.Name as Улица, Date as Дата from RoadAccidents inner join Streets on RoadAccidents.StreetID=Streets.ID", connection);
            visualAccidentDataAdapter.Fill(visualAccidentsTable);
        }
        
        static void CreateRandomCitizens()
        {
            string[] fams = { "Безменов", "Елисеев","Боголюбов", "Украинцев", "Фомин", "Макаров", "Волков", "Семирадов", "Крыскин", "Данилов", "Тушин", "Елисеева", "Тихомирова", "Ивлеева", "Манулова", "Кузнецова", "Камарова", "Добронравова", "Дурнова", "Благова", "Репкина" };
            string[] Names = { "Данил", "Андрей", "Елисей", "Дмитрий", "Вячеслав", "Максим", "Александр", "Алексей", "Олег", "Денис", "Кирилл", "Анна", "Наталья", "Вероника", "Мария", "Елизавета", "Арина", "Елена", "Ксения", "Дарья" };
            string[] fathers = { "Андреевич", "Владимирович", "Алексеевич", "Константинович", "Дмитриевич", "Максимович", "Николаевич", "Ашотович", "Денисович", "Александрович", "Константиновна", "Евгениевна", "Василиевна", "Максимовна", "Дмитриевна", "Алексеевна", "Сергеевна", "Владимировна" };
            
            SqlCommand citizenCreation=new SqlCommand();
            citizenCreation.Connection = connection;

            System.Random random = new System.Random();

             int nameLow, nameHigh, fathLow, fathHigh;

            int fam, name, fath;

            

            for (int i = 0; i < 50; i++)
            {
                fam = random.Next(fams.Length);

                if (fam < 11)
                {
                    nameLow = 0; nameHigh = 11;
                    fathLow = 0; fathHigh = 10;
                }
                else
                {
                    nameLow = 11; nameHigh = Names.Length;
                    fathLow = 10; fathHigh = fathers.Length;
                }

                name = random.Next(nameLow, nameHigh);
                fath = random.Next(fathLow, fathHigh);

                int street = random.Next(1, 34);

                citizenCreation.CommandText = "Insert into dbo.Citizens(dbo.Citizens.Name, dbo.Citizens.StreetID, dbo.Citizens.Birthdate)" +
                    $"Values(@CitizenName, {street}, '{random.Next(1940, 2015)}-{random.Next(1, 13)}-{random.Next(1, 32)}')";

                citizenCreation.Parameters.Add("@CitizenName", SqlDbType.NVarChar).Value= $"{fams[fam]} {Names[name]} {fathers[fath]}";

                citizenCreation.ExecuteNonQuery();

                citizenCreation.Parameters.Clear();
            }
        }

        public static void AddNewAccident(string Name, int StreetID, DateTime date)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "NewAccident";

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@StreetID", StreetID);
            command.Parameters.AddWithValue("@AccidentDate", date);

            connection.Open();

            command.ExecuteNonQuery();

            //RefreshAccidentTable();

            connection.Close();
        }

        public static void RemoveAccident(int ID)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "RemoveAccident";

            command.Parameters.AddWithValue("@AccidentID", ID);

            connection.Open();

            command.ExecuteNonQuery();

            //RefreshAccidentTable();

            connection.Close();
        }

        public static void ChangeAccident(int ID ,string Name, int StreetID, DateTime date)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "UpdateAccident";

            command.Parameters.AddWithValue("@AccidentID", ID);
            command.Parameters.AddWithValue("@NewName", Name);
            command.Parameters.AddWithValue("@NewStreetID", StreetID);
            command.Parameters.AddWithValue("@NewDate", date);

            connection.Open();

            command.ExecuteNonQuery();

            //RefreshAccidentTable();

            connection.Close();
        }

        public static void AddParticipator(int AccidentID, int CitizenID, int ControlledCarID, string Role, string State)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "NewParticipator";

            command.Parameters.AddWithValue("@AccidentID", AccidentID);
            command.Parameters.AddWithValue("@CitizenID", CitizenID);
            command.Parameters.AddWithValue("@ControlledCarID", ControlledCarID);
            command.Parameters.AddWithValue("@Role", Role);
            command.Parameters.AddWithValue("@State", State);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public static void RemoveParticipator(int ParticipatorID)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "RemoveParticipator";

            command.Parameters.AddWithValue("@ParticipatorID", ParticipatorID);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public static void ChangeParticipator(int ID, int AccidentID, int CitizenID, int ControlledCarID, string Role, string State)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "UpdateParticipator";

            command.Parameters.AddWithValue("@ParticipatorID", ID);
            command.Parameters.AddWithValue("@NewAccidentID", AccidentID);
            command.Parameters.AddWithValue("@NewCtitizenID", CitizenID);
            command.Parameters.AddWithValue("@NewControlledCar", ControlledCarID);
            command.Parameters.AddWithValue("@NewRole", Role);
            command.Parameters.AddWithValue("@NewState", State);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public static System.Data.DataTable GetAccidentByStreet(int ID)
        {
            System.Data.DataTable partAccidentTable=new System.Data.DataTable();

            SqlCommand getTable=new SqlCommand();
            getTable.Connection = connection;
            getTable.CommandText = $"select * from dbo.GetAccidentsIn({ID})";
            //getTable.Parameters.Add("TheStreetID", ID);

            SqlDataAdapter adapter=new SqlDataAdapter(getTable);

            connection.Open();

            adapter.Fill(partAccidentTable);

            connection.Close();

            return partAccidentTable;
        }

        public static void FillComboBox(ComboBox comboBox, int parameterID, int district)
        {
            System.Data.DataTable dataTable = new System.Data.DataTable();
            SqlDataAdapter adapter=new SqlDataAdapter($"select * from dbo.Streets where Streets.DistrictID={district}",connection);
            adapter.Fill(dataTable);

            comboBox.Items.Clear(); 

            foreach (DataRow row in dataTable.Rows)         
                comboBox.Items.Add($"{row[parameterID].ToString()}");    
        }

        public static void FillDistrictComboBox(ComboBox comboBox, int parameterID)
        {
            foreach (DataRow row in districtsTable.Rows)
                comboBox.Items.Add($"{row[parameterID].ToString()}");
                
        }

        public static void FillCitizensComboBox(ComboBox comboBox)
        {
            foreach (DataRow row in citizensTable.Rows)
                comboBox.Items.Add($"{row[1].ToString()}");
        }

        public static void FillCarComboBox(ComboBox comboBox)
        {
            foreach (DataRow row in carsTable.Rows)
                comboBox.Items.Add($"{row[3].ToString()} {row[2]} {row[1]}");
        }

        public static void FillAccidentComboBox(ComboBox comboBox)
        {
            foreach (DataRow row in accidentsTable.Rows)
                comboBox.Items.Add($"{row[1].ToString()}-{row[0]} на {streetsTable.Rows[int.Parse(row[2].ToString())].ItemArray[1].ToString()} {row[3]}");
        }

        public static string GetAccidentName(int id)
        {
            string result="";

            foreach(DataRow row in accidentsTable.Rows)
            {
                if (int.Parse(row.ItemArray[0].ToString()) == id)
                {
                    result = $"{row[1].ToString()}-{row[0]} на {streetsTable.Rows[int.Parse(row[2].ToString())].ItemArray[1].ToString()} {row[3]}";
                    break;
                }
                
            }

            return result;
        }

        public static System.Data.DataTable GetCitizensByStreet(int id)
        {
            System.Data.DataTable partAccidentTable = new System.Data.DataTable();

            SqlCommand getTable = new SqlCommand();
            getTable.Connection = connection;
            getTable.CommandText = $"select * from dbo.GetCitizensFrom({id})";
            //getTable.Parameters.Add("TheStreetID", ID);

            SqlDataAdapter adapter = new SqlDataAdapter(getTable);

            connection.Open();

            adapter.Fill(partAccidentTable);

            connection.Close();

            return partAccidentTable;
        }

        public static int GetStreetByName(string name)
        {
            int id = 0;

            foreach (DataRow row in DataBaseHandling.streetsTable.Rows)
            {
                if (row.ItemArray[1].ToString() == name)
                {
                    id = int.Parse(row.ItemArray[0].ToString());
                }
            }

            return id;
        }

        public static int GetDistrictByName(string name)
        {
            int id = 0;

            foreach (DataRow row in DataBaseHandling.districtsTable.Rows)
            {
                if (row.ItemArray[1].ToString() == name)
                {
                    id = int.Parse(row.ItemArray[0].ToString());
                }
            }

            return id;
        }

        public static DataRow GetAccidentByID(int ID)
        {
            DataRow row = null;

            foreach(DataRow theRow in visualAccidentsTable.Rows)
                if (theRow.ItemArray[0].ToString()==ID.ToString())
                    row=theRow;

            return row;
        }

        public static DataRow GetParticipatorByID(int ID)
        {
            DataRow row = null;

            foreach (DataRow theRow in visualParticipatorsTable.Rows)
                if (theRow.ItemArray[0].ToString() == ID.ToString())
                    row = theRow;

            return row;
        }

        public static string GetCitizenByID(int ID)
        {
            string name = "";

            foreach (DataRow row in DataBaseHandling.citizensTable.Rows)
            {
                if (int.Parse(row.ItemArray[0].ToString()) == ID)
                {
                    name = row.ItemArray[1].ToString();
                }
            }

            return name;
        }

        public static int GetCitizenByName(string name)
        {
            int id = 0;

            foreach (DataRow row in DataBaseHandling.citizensTable.Rows)
            {
                if (row.ItemArray[1].ToString() == name)
                {
                    id = int.Parse(row.ItemArray[0].ToString());
                }
            }

            return id;
        }

        public static int GetCarByName(string name)
        {
            int id = 0;

            string license = "";

            for(int i=0;i<name.Length;i++)
            {
                if (name[i] == ' ')
                    break;

                license += name[i];
            }

            foreach (DataRow row in DataBaseHandling.carsTable.Rows)
            {
                if (row.ItemArray[3].ToString() == license)
                {
                    id = int.Parse(row.ItemArray[0].ToString());
                }
            }

            return id;
        }

        public static int GetAccidentByName(string name)
        {
            int id = 0;

            string theID = "";

            bool read=false;

            for (int i=0;i<name.Length;i++)
            {
                if (read && name[i] == ' ')
                    break;
                if (read)
                    theID += name[i];
                

                if (name[i] == '-')
                    read = true;
            }

                id = int.Parse(theID);

            return id;
        }
    }
}
