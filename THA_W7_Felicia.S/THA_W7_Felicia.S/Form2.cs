using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_Felicia.S
{
    public partial class Form2 : Form
    {
        Form1 form2form;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form2form = form1;
        }

        int BookSeat, pilihkursi;
        
        Button[] button;

        public static List<string> movie = new List<string>();
        public static List<string> poster = new List<string>();
        public static List<string> Range = new List<string>() { "2D   D17+", "2D   SU", "2D   SU", "2D   R13+", "2D   R13+", "2D   R13+", "2D   R13+", "2D   R13+" };
        List<string> batas;
        int xPict = 70;
        int yPict = 20;
        int xLabel = 95;
        int yLabel = 175;
        int xRange = 91;
        int yrange = 210;
        int xButton = 80;
        int yButton = 230;
        public static int book;
        public static List<List<Time>> jadwal = new List<List<Time>>();
        public class Time
        {
            public string time { get; set; }
            public List<Button> seat;
            public Time(string time)
            {
                this.time = time;
                this.seat = new List<Button>();
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
            this.BackColor = Color.DarkRed;
            string file = "moviefile.txt";
            string[] line = File.ReadAllLines(file);
            batas = new List<string>();
            foreach (string a in line)
            {
                batas.AddRange(a.Split(','));
            }

            foreach (string baris in batas)
            {
                if (baris[0] != 'C')
                {
                    movie.Add(baris);
                }
                else
                {
                    poster.Add(baris);
                }
            }

            

            button = new Button[8];
            for (int j = 0; j < 8; j++)
            {
                if (j == 0)
                {
                    Label labelJohn = new Label();
                    labelJohn.Text = movie[j];
                    labelJohn.Location = new Point(xLabel - ((movie[j].Length)/2), yLabel);
                    labelJohn.ForeColor = Color.White;
                    this.Controls.Add(labelJohn);
                }
                if (j == 1)
                {
                    xRange += 154;

                    Label labelMario = new Label();
                    labelMario.Text = movie[j];
                    labelMario.Location = new Point(xLabel + 5 - ((movie[j].Length) / 2), yLabel);
                    labelMario.Size = new Size(100, 30);
                    labelMario.ForeColor = Color.White;
                    this.Controls.Add(labelMario);
                }
                if (j == 2)
                {
                    xRange += 150;

                    Label labelDD = new Label();
                    labelDD.Text = movie[j];
                    labelDD.Location = new Point(xLabel - 3 - ((movie[j].Length) / 2), yLabel);
                    labelDD.Size = new Size(130, 30);
                    labelDD.ForeColor = Color.White;
                    this.Controls.Add(labelDD);
                }
                if (j == 3)
                {
                    xRange += 147;

                    Label labelEnd = new Label();
                    labelEnd.Text = movie[j];
                    labelEnd.Location = new Point(xLabel + 6 - ((movie[j].Length) / 2), yLabel);
                    labelEnd.Size = new Size(130, 30);
                    labelEnd.ForeColor = Color.White;
                    this.Controls.Add(labelEnd);
                }
                if (j == 4)
                {
                    xPict = 70;
                    xLabel = 95;
                    xButton = 80;
                    xRange = 92;
                    yPict += 250;
                    yLabel += 250;
                    yButton += 250;
                    yrange += 250;

                    Label labelGotg = new Label();
                    labelGotg.Text = movie[j];
                    labelGotg.Location = new Point(xLabel - 17 - ((movie[j].Length) / 2), yLabel);
                    labelGotg.Size = new Size(130, 30);
                    labelGotg.ForeColor = Color.White;
                    this.Controls.Add(labelGotg);

                }
                if (j == 5)
                {
                    xRange += 150;
                    Label labelShazam = new Label();
                    labelShazam.Text = movie[j];
                    labelShazam.Location = new Point(xLabel + 15 - ((movie[j].Length) / 2), yLabel);
                    labelShazam.Size = new Size(130, 30);
                    labelShazam.ForeColor = Color.White;
                    this.Controls.Add(labelShazam);
                }
                if (j == 6)
                {
                    xRange += 150;
                    Label labelDoctor = new Label();
                    labelDoctor.Text = movie[j];
                    labelDoctor.Location = new Point(xLabel + 13 - ((movie[j].Length) / 2), yLabel);
                    labelDoctor.Size = new Size(130, 30);
                    labelDoctor.ForeColor = Color.White;
                    this.Controls.Add(labelDoctor);
                }
                if (j == 7)
                {
                    xRange += 150;

                    Label labelCaptain = new Label();
                    labelCaptain.Text = movie[j];
                    labelCaptain.Location = new Point(xLabel + 22 - ((movie[j].Length) / 2), yLabel);
                    labelCaptain.Size = new Size(130, 30);
                    labelCaptain.ForeColor = Color.White;
                    this.Controls.Add(labelCaptain);
                }

                PictureBox pict = new PictureBox();
                pict.Image = Image.FromFile(poster[j]);
                pict.Location = new Point(xPict, yPict);
                pict.Size = new Size(100, 150);
                pict.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(pict);

                Label range = new Label();
                range.Text = Range[j];
                range.Location = new Point(xRange, yrange);
                range.BackColor = Color.SkyBlue;
                if (Range[j] == "2D   SU")
                {
                    range.Size = new Size(47, 13);
                }
                else
                {
                    range.Size = new Size(56, 13);
                }
                this.Controls.Add(range);

                button[j] = new Button();
                button[j].Location = new Point(xButton, yButton);
                button[j].Size = new Size(80, 20);
                button[j].BackColor = Color.Transparent;
                button[j].Text = "Book Now";
                button[j].ForeColor = Color.Black;
                button[j].Tag = j;
                button[j].Click += booknow_Click;
                this.Controls.Add(button[j]);

                List<Time> Jam = new List<Time>();
                Time waktu1 = new Time("12.35");
                Jam.Add(waktu1);
                Time waktu2 = new Time("15.40");
                Jam.Add(waktu2);
                Time waktu3 = new Time("19.20");
                Jam.Add(waktu3);
                Form2.jadwal.Add(Jam);

                xPict += 150;
                xLabel += 140;
                xButton += 150;    
            }
        }
        private void booknow_Click(object sender, EventArgs e)
        {
            var send = sender as Button;
            book = Convert.ToInt32(send.Tag);
            Film film = new Film();
            form2form.setForm(film);  
        }
    }
}
