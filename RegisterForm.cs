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
    public partial class RegisterForm : Form
    {
        private SQLiteConnection Database;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Regestration_button_Click(object sender, EventArgs e)
        {
            if( Logintext.Text!=""&& Passwordtext.Text != ""&&Passwordtext2.Text != "")
            {
                SQLiteCommand add = Database.CreateCommand();
                SQLiteCommand delete = Database.CreateCommand();
                if (chekuser())
                {
                    return;
                }
                add.CommandText = "insert into registrationtable(Login, Password) values(@login, @password)";

                if (Passwordtext.Text ==Passwordtext2.Text)
                {
                    add.Parameters.Add("@password", DbType.String).Value = GetHash(Passwordtext.Text);
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают.");
                }
                add.Parameters.Add("@login", DbType.String).Value = Logintext.Text;
                add.ExecuteNonQuery();
                this.Hide();
                Shifr shifr = new Shifr();
                shifr.Show();
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }
        public bool chekuser()
        {
            DataTable table = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            SQLiteCommand rk = Database.CreateCommand();
            rk.CommandText = "select * from registrationtable where Login like @log";

            rk.Parameters.Add("@log", DbType.String).Value = Logintext.Text;

            adapter.SelectCommand = rk;
            adapter.Fill(table);
            if (table.Rows.Count>0)
            {
                MessageBox.Show("Такой пользователь уже зарегестрирован.");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            Database = new SQLiteConnection("DataSource=Database.db; Version=3");
            Database.Open();
        }
        public string GetHash (string pass)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(pass));
            return Convert.ToBase64String(hash);
        }
    }
}
