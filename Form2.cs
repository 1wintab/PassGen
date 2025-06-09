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
    public partial class Form2 : Form
    {
        System.Media.SoundPlayer errorSound = new System.Media.SoundPlayer(Properties.Resources.error_uwu_sound_effect);
        public Form2()
        {
            InitializeComponent();
            errorSound.Stop();
            errorSound.Play();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                Color.Red, 5, ButtonBorderStyle.Solid,  // Ліва сторона
                Color.Red, 5, ButtonBorderStyle.Solid,  // Верхня сторона
                Color.Red, 5, ButtonBorderStyle.Solid,  // Права сторона
                Color.Red, 5, ButtonBorderStyle.Solid); // Нижня сторона
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void SetErrorText(string message)
        {
            label2.Text = message; // Оновлення тексту помилки
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
