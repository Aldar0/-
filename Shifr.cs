using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Форма_Хилл
{
    public partial class Shifr : Form
    {
        public Shifr()
        {
            InitializeComponent();
        }
        private void Regestration_button_Click(object sender, EventArgs e)
        {
            if (wordtext1.Text == "" && keybox1.Text == "")
            {
                MessageBox.Show("Заполните все поля для шифрования.");
            }
            else
            {
                if (keybox1.Text.Length < 9)
                {
                    MessageBox.Show("Ключ должен состоять из 9 символов");
                }
                else if(wordtext1.Text == "")
                {
                    MessageBox.Show("Введите слово");
                }
                else
                {
                    Encryption word = new Hill(wordtext1.Text, keybox1.Text, wordtext2.Text, keybox2.Text);
                    word.Check();
                    if (word.C == 1)
                    {
                        MessageBox.Show("Введите другой ключ");
                    }
                    word.Encpted();
                    encryptbox.Text = word.Enc;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (wordtext2.Text == "" && keybox2.Text == "")
            {
                MessageBox.Show("Заполните все поля для дешифрования.");
            }
            else
            {
                if (keybox2.Text.Length < 9)
                {
                    MessageBox.Show("Ключ должен состоять из 9 символов");
                }
                else if (wordtext2.Text == "")
                {
                    MessageBox.Show("Введите слово");
                }
                else
                {
                    Encryption word = new Hill(wordtext1.Text, keybox1.Text, wordtext2.Text, keybox2.Text);
                    word.Check();
                    if (word.C == 1)
                    {
                        MessageBox.Show("Введите другой ключ");
                    }
                    word.Decpted();
                    decrytpbox.Text = word.Dec;
                }
            }
        }

        private void Shifr_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string text = @"text.txt";
            
            StreamWriter write = File.CreateText(text);
            {
                write.WriteLine(wordtext1.Text);
                write.WriteLine(keybox1.Text);
                write.WriteLine(encryptbox.Text);
                write.WriteLine(wordtext2.Text);
                write.WriteLine(keybox2.Text);
                write.WriteLine(decrytpbox.Text);
                write.Close();
            }
        }
    }
}
