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
    public partial class Form1 : Form
    {
        bool delog=false;
        bool admin;
        List<Account> accounts = new List<Account>();
        public List<Form> activeForms = new List<Form>();

        public Form1()
        {
            InitializeComponent();

            accounts.Add(new Account("Admin","SayGex", true));
            accounts.Add(new Account("BruhUser", "NotAdmin", false));


            //allForms.Add();
        }

        void AutoFill(string login, string password)
        {
            Auth_LoginTextBox.Text = login;
            Auth_PasswordTextBox.Text = password;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TabControll.TabPages.Remove(Portal);

            Auth_PasswordTextBox.UseSystemPasswordChar = true;

            DataBaseHandling.Initialize();

            AutoFill("Admin", "SayGex");
        }



        private void AuthWindow_Click(object sender, EventArgs e)
        {

        }

        private void Auth_AuthButton_Click(object sender, EventArgs e)
        {
            if (!delog)
            {
                string login = Auth_LoginTextBox.Text;
                string password = Auth_PasswordTextBox.Text;

                bool success = false;

                foreach (Account account in accounts)
                {
                    if (account.GetLogin() == login)
                    {
                        if (account.GetPassword() == password)
                        {
                            Authorize(account.AdminStatus());
                            ShowDelog(login);
                            success = true;
                        }
                    }
                }

                if (!success)
                    MessageBox.Show("Логин или пароль введен не верно");
            }
            else
            {
                Delog();
            }
        }

        void ShowDelog(string accountName)
        {
            delog = true;

            Auth_LoginTextBox.Hide();
            Auth_PasswordTextBox.Hide();

            Auth_LoginTextBox.Text = "";
            Auth_PasswordTextBox.Text = "";

            label2.Hide();
            label3.Hide();

            label1.Text = accountName;
            Auth_AuthButton.Text = "Выйти";
        }


        void ShowLogin()
        {
            delog = false;

            label2.Show();
            label3.Show();

            Auth_AuthButton.Text = "Войти";

            Auth_LoginTextBox.Show();
            Auth_PasswordTextBox.Show();

            label1.Text = "Авторизация";
        }

        void Authorize(bool admin)
        {
            this.admin = admin;

            if (admin)
            {
                this.Text = "База данных - админ доступ";
            }

            TabControll.TabPages.Add(Portal);
            TabControll.SelectedIndex++;
        }

        void Delog()
        {
            this.Text="База данных";

            ShowLogin();

            for (int i=1;i<TabControll.TabPages.Count;i++)
            {
                TabControll.TabPages.Remove(TabControll.TabPages[i]);
            }

            foreach (Form form in activeForms)
            {
                form.Hide();
            }

            activeForms.Clear();
        }

        private void Portal_Click(object sender, EventArgs e)
        {

        }

        private void Portal_AccidentsButton_Click(object sender, EventArgs e)
        {
            AccidentsFrom accidentForm = new AccidentsFrom();

            

            
                accidentForm.Start(this, admin);

                accidentForm.Show();
                activeForms.Add(accidentForm);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HubForm accidentForm = new HubForm();




            accidentForm.Start(this, admin);

            accidentForm.Show();
            activeForms.Add(accidentForm);
        }
    }
}
