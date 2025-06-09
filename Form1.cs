using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "PassGen";
            this.StartPosition = FormStartPosition.CenterScreen;

            lengthField.KeyPress += lengthField_KeyPress;
            passwordField.KeyDown += passwordField_KeyDown;

            this.lengthField.MaxLength = 3;
            this.passwordField.MaxLength = 999;
            this.isCopied.Visible = false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lengthField.Text))
            {
                MessageBox.Show(this, "Помилка! Ви не вказати розмір паролю.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Пропускаємо, щоб уникнути повторного виклику
            }

            if (int.TryParse(lengthField.Text, out int lengthpass))
            {
                isCopied.Visible = false;
                lengthField.Text = lengthpass.ToString();
                GeneratePassword(sender, e);
            }
            else
            {
                //MessageBox.Show("Помилка! Введено не число.");
                MessageBox.Show(this, "Помилка! Введено некоректні дані!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lengthField.Text = "";
            }
        }

        private void CopyPassword_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(passwordField.Text))
            {
                Clipboard.SetText(passwordField.Text);
                ShowCopiedMessage(sender, e);
            }
            else
            {
                MessageBox.Show(this, "Помилка! Пароль відсутній.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowCopiedMessage(object sender, EventArgs e)
        {
            isCopied.Visible = true;

            Timer timer = new Timer();
            timer.Interval = 2500;
            timer.Tick += (s, args) =>
            {
                isCopied.Visible=false;
                ((Timer)s).Stop();
                ((Timer)s).Dispose();
            };
            timer.Start();
        }

        private void DeletePassword_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(passwordField.Text))
            {
                passwordField.Text = "";
            }
            else
            {
                MessageBox.Show(this, "Помилка! Пароль відсутній.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FullReset_Click(object sender, EventArgs e)
        {
            lengthField.Text = "";
            passwordField.Text = "";
            cbDigit.Checked = false;
            cbSpecial.Checked = false;
            cbUpper.Checked = false;
            cbLower.Checked = false;
        }

        private void passwordField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control) // Перевіряємо, чи натиснуто Ctrl
            {
                if (e.KeyCode == Keys.A) // Ctrl + A (виділення всього тексту)
                {
                    passwordField.SelectAll();
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.C) // Ctrl + C (копіювання)
                {
                    Clipboard.SetText(passwordField.Text);
                    e.Handled = true;
                }
            }
        }

        private void lengthField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Блокуємо символ
            }
        }

        private void GeneratePassword(object sender, EventArgs e)
        {
            string numbers = "1234567890";
            string lowerLetters = "abcdefghijklmnopqrstuvwxyz"; 
            string upperLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string specialChars = "!@#$%^&*()_+-=[]{}|;:'\"\\,.<>?/";
            string password = "";
            
            Random rnd = new Random();

            string characters = "";
            if (cbDigit.Checked) characters += numbers;
            if (cbUpper.Checked) characters += upperLetters;
            if (cbLower.Checked) characters += lowerLetters;
            if (cbSpecial.Checked) characters += specialChars;

            if (string.IsNullOrEmpty(characters))
            {
                MessageBox.Show(this, "Помилка: Ви не обрали жоден вид символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < int.Parse(lengthField.Text); i++)
                {
                    password += characters[rnd.Next(characters.Length)];
                }

                passwordField.Text = password;   
            }
        }

        #region
        private void Form1_Load(object sender, EventArgs e) {}
        private void label1_Click(object sender, EventArgs e) {}
        private void label2_Click(object sender, EventArgs e) {}
        private void label3_Click(object sender, EventArgs e) {}
        private void label4_Click(object sender, EventArgs e) {}
        private void label5_Click(object sender, EventArgs e) {}
        private void label8_Click(object sender, EventArgs e) {}
        private void panel1_Paint(object sender, PaintEventArgs e) {}
        private void panel2_Paint(object sender, PaintEventArgs e) {}
        private void pictureBox1_Click(object sender, EventArgs e) {}
        private void passwordField_TextChanged(object sender, EventArgs e) {}
        private void lengthField_TextChanged(object sender, EventArgs e) {}
        private void cbDigit_CheckedChanged_1(object sender, EventArgs e) {}
        private void cbSpecial_CheckedChanged(object sender, EventArgs e) {}
        private void cbUpper_CheckedChanged(object sender, EventArgs e) {}
        private void cbLower_CheckedChanged(object sender, EventArgs e) {}
        private void lengthField_TextChanged_1(object sender, EventArgs e) {}
        private void label7_Click(object sender, EventArgs e) {}
        private void label9_Click(object sender, EventArgs e) {}
        private void label6_Click(object sender, EventArgs e) {}
        private void isCopied_Click(object sender, EventArgs e) {}
        #endregion
    }
}