using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace Форма_Хилл
{
    public partial class Lognform : Form
    {
        private SQLiteConnection Database;
        public Lognform()
        {
            InitializeComponent();

            this.passwordtext.AutoSize = false;
            this.passwordtext.Size = new Size(this.passwordtext.Size.Width, 33);
        }

        private void Lognform_Load(object sender, EventArgs e)
        {
            Database = new SQLiteConnection("DataSource=Database.db; Version=3");
            Database.Open();
        }

        private void Lognform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Database.Close();
        }

        private void registrationbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string loginuse = logintext.Text;
            string passworduse = passwordtext.Text;

            DataTable table = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter();

            SQLiteCommand enter = Database.CreateCommand();

            enter.CommandText = " select * from registrationtable where login like @log and password like @pas";

            enter.Parameters.Add("@log", DbType.String).Value = loginuse;
            enter.Parameters.Add("@pas", DbType.String).Value = GetHash(passworduse);

            adapter.SelectCommand = enter;
            adapter.Fill(table);

            if( table.Rows.Count > 0)
            {
                this.Hide();
                Shifr shifr = new Shifr();
                shifr.Show();
            }
            else if (logintext.Text =="" && passwordtext.Text =="")
            {
                MessageBox.Show("Заполните все поля.");
            }
            else
            {
                MessageBox.Show("Такого пользователя нет.");
            }
        }
        public string GetHash(string pass)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(pass));
            return Convert.ToBase64String(hash);
        }

    }
}
