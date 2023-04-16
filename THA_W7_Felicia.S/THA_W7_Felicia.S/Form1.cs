using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_Felicia.S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            panel1.AutoScroll = true;
            buttonNowPlay.BackColor = Color.Gold;
            this.BackColor = Color.Black;
            timer1.Start();
            panel1.Controls.Clear();
            Form2 movies = new Form2(this);
            movies.Dock = DockStyle.Fill;
            movies.TopLevel = false;
            this.panel1.Controls.Add(movies);
            movies.Show();
        }
        public void setForm(object form)
        {
            panel1.Controls.Clear();
            if (form.GetType().ToString().Contains("Film"))
            {
                var obj = form as Film;
                obj.Dock = DockStyle.Fill;
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a % 5 == 0)
            {
                label1.ForeColor = Color.Red;
            }
            else if (a % 3 == 0)
            {
                label1.ForeColor = Color.Goldenrod;
            }
            else if (a % 2 == 0)
            {
                label1.ForeColor = Color.Cyan;
            }
            a++;

        }

        private void buttonNowPlay_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form2 movies = new Form2(this);
            movies.Dock = DockStyle.Fill;
            movies.TopLevel = false;
            this.panel1.Controls.Add(movies);
            movies.Show();
        }
    }
}
