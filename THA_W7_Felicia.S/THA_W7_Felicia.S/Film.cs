using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_Felicia.S
{
    public partial class Film : Form
    {
        int book = Form2.book;
        Random rendem = new Random();
        int unavailable, status, terpilih;
        List<string> movie = new List<string>(Form2.movie);
        List<char> row = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
        List<string> pilih = new List<string>();
        int xPict = 60;
        int yPict = 90;
        int xLabel = 85;
        int yLabel = 260;
        int xRange = 81;
        int yRange = 310;
        int xButton = 200;
        int yButton = 110;
        int xSeat = 10;
        int ySeat = 10;
        int xJudul = 60;
        int yJudul = 30;
        int filmke, jamke;

        Label pilihKursi;
        Button[] time;
        Button[,] sit;
        string kursiKe, bookKursi;
        public Film()
        {
            InitializeComponent();
        }

        private void Film_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            this.BackColor = Color.DarkRed;
            filmke = Convert.ToInt32(Form2.book);

            time = new Button[3];
            sit = new Button[10, 10];

            /*for (int i = 0; i < 3; i++)
            {
                kursi(filmke, i);
            }*/

            for (int i = 0; i < 3; i++)
            {
                time[i] = new Button();
                time[i].Location = new Point(xButton, yButton);
                time[i].Size = new Size(80, 20);
                time[i].BackColor = Color.Transparent;
                time[i].ForeColor = Color.Black;
                time[i].Tag = i;
                if (i == 0)
                {
                    time[i].Text = "12.35";
                }
                else if (i == 1)
                {
                    time[i].Text = "15.40";
                }
                else if (i == 2)
                {
                    time[i].Text = "19.20";
                }
                time[i].Click += time_Click;
                this.Controls.Add(time[i]);
                yButton += 30;
            }
            Label Judul = new Label();
            Judul.Location = new Point(xJudul, yJudul);
            Judul.Size = new Size(400, 40);
            Judul.Text = movie[filmke];
            Judul.Font = new Font("Monotype Corsiva", 20, FontStyle.Bold);
            this.Controls.Add(Judul);

            Label range = new Label();
            range.Text = Form2.Range[filmke];
            range.Location = new Point(xRange, yRange);
            range.BackColor = Color.SkyBlue;
            if (Form2.Range[filmke] == "2D   SU")
            {
                range.Size = new Size(47, 13);
            }
            else
            {
                range.Size = new Size(56, 13);
            }
            this.Controls.Add(range);

            Button clear = new Button();
            clear.Location = new Point(600, 40);
            clear.Size = new Size(50, 20);
            clear.Text = "Clear";
            clear.BackColor = Color.Transparent;
            clear.ForeColor = Color.Black;
            clear.Click += clear_Click;
            this.Controls.Add(clear);

            pilihKursi = new Label();
            pilihKursi.Location = new Point(180, 280);
            pilihKursi.Size = new Size(150, 50);
            pilihKursi.Text = "Seat chosen: ";
            this.Controls.Add(pilihKursi);

            Button submit = new Button();
            submit.Location = new Point(xButton, yButton + 30);
            submit.Size = new Size(60, 20);
            submit.Text = "Reserve";
            submit.Click += Submit_Click;
            this.Controls.Add(submit);

            switch (book)
            {
                case 0:
                    PictureBox pictJohn = new PictureBox();
                    pictJohn.Image = Image.FromFile(Form2.poster[0]);
                    pictJohn.Location = new Point(xPict, yPict);
                    pictJohn.Size = new Size(100, 150);
                    pictJohn.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Controls.Add(pictJohn);

                    Label labelJohn = new Label();
                    labelJohn.Text = movie[0];
                    labelJohn.Location = new Point(xLabel - ((movie[0].Length) / 2), yLabel);
                    this.Controls.Add(labelJohn);
                    break;

                case 1:
                    PictureBox pictMario = new PictureBox();
                    pictMario.Image = Image.FromFile(Form2.poster[1]);
                    pictMario.Location = new Point(xPict, yPict);
                    pictMario.Size = new Size(100, 150);
                    pictMario.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Controls.Add(pictMario);

                    Label labelMario = new Label();
                    labelMario.Text = movie[1];
                    labelMario.Location = new Point(xLabel - 7 - ((movie[1].Length) / 2), yLabel);
                    labelMario.Size = new Size(100, 30);
                    this.Controls.Add(labelMario);

                    break;

                case 2:
                    PictureBox pictDD = new PictureBox();
                    pictDD.Image = Image.FromFile(Form2.poster[2]);
                    pictDD.Location = new Point(xPict, yPict);
                    pictDD.Size = new Size(100, 150);
                    pictDD.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Controls.Add(pictDD);

                    Label labelDD = new Label();
                    labelDD.Text = movie[2];
                    labelDD.Location = new Point(xLabel - 23 - ((movie[2].Length) / 2), yLabel);
                    labelDD.Size = new Size(130, 30);
                    this.Controls.Add(labelDD);
                    break;

                case 3:
                    PictureBox pictEnd = new PictureBox();
                    pictEnd.Image = Image.FromFile(Form2.poster[3]);
                    pictEnd.Location = new Point(xPict, yPict);
                    pictEnd.Size = new Size(100, 150);
                    pictEnd.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Controls.Add(pictEnd);

                    Label labelEnd = new Label();
                    labelEnd.Text = movie[3];
                    labelEnd.Location = new Point(xLabel - 22 - ((movie[3].Length) / 2), yLabel);
                    labelEnd.Size = new Size(130, 30);
                    this.Controls.Add(labelEnd);
                    break;

                case 4:
                    PictureBox pictGotg = new PictureBox();
                    pictGotg.Image = Image.FromFile(Form2.poster[4]);
                    pictGotg.Location = new Point(xPict, yPict);
                    pictGotg.Size = new Size(100, 150);
                    pictGotg.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Controls.Add(pictGotg);

                    Label labelGotg = new Label();
                    labelGotg.Text = movie[4];
                    labelGotg.Location = new Point(xLabel - 17 - ((movie[4].Length) / 2), yLabel);
                    labelGotg.Size = new Size(130, 30);
                    this.Controls.Add(labelGotg);
                    break;

                case 5:
                    PictureBox pictShazam = new PictureBox();
                    pictShazam.Image = Image.FromFile(Form2.poster[5]);
                    pictShazam.Location = new Point(xPict, yPict);
                    pictShazam.Size = new Size(100, 150);
                    pictShazam.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Controls.Add(pictShazam);

                    Label labelShazam = new Label();
                    labelShazam.Text = movie[5];
                    labelShazam.Location = new Point(xLabel + 2 - ((movie[5].Length) / 2), yLabel);
                    labelShazam.Size = new Size(130, 30);
                    this.Controls.Add(labelShazam);
                    break;

                case 6:
                    PictureBox pictDoctor = new PictureBox();
                    pictDoctor.Image = Image.FromFile(Form2.poster[6]);
                    pictDoctor.Location = new Point(xPict, yPict);
                    pictDoctor.Size = new Size(100, 150);
                    pictDoctor.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Controls.Add(pictDoctor);

                    Label labelDoctor = new Label();
                    labelDoctor.Text = movie[6];
                    labelDoctor.Location = new Point(xLabel - 8 - ((movie[6].Length) / 2), yLabel);
                    labelDoctor.Size = new Size(130, 30);
                    this.Controls.Add(labelDoctor);
                    break;

                case 7:
                    PictureBox pictCaptain = new PictureBox();
                    pictCaptain.Image = Image.FromFile(Form2.poster[7]);
                    pictCaptain.Location = new Point(xPict, yPict);
                    pictCaptain.Size = new Size(100, 150);
                    pictCaptain.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Controls.Add(pictCaptain);

                    Label labelCaptain = new Label();
                    labelCaptain.Text = movie[7];
                    labelCaptain.Location = new Point(xLabel - 7 - ((movie[7].Length) / 2), yLabel);
                    labelCaptain.Size = new Size(130, 30);
                    this.Controls.Add(labelCaptain);
                    break;
            }
        }
        private void kursi(int filmKe, int jamKe)
        {
            ySeat = 10;
            terpilih = 0;
            unavailable = rendem.Next(70);
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    status = rendem.Next(2);
                    sit[i, j] = new Button();
                    sit[i, j].Location = new Point(xSeat, ySeat);
                    sit[i, j].Size = new Size(30, 30);
                    sit[i, j].BackColor = Color.Transparent;
                    sit[i, j].ForeColor = Color.White;
                    sit[i, j].Text = row[i].ToString() + (j + 1).ToString();
                    sit[i, j].Tag = row[i].ToString() + (j + 1).ToString();
                    sit[i, j].Font = new Font("Times New Roman", 7);
                    if (status == 1)
                    {
                        sit[i, j].BackColor = Color.Gray;
                    }
                    else if(terpilih <= unavailable && status == 0)
                    {
                        sit[i, j].BackColor = Color.Red;
                        terpilih++;
                    }
                    else
                    {
                        sit[i, j].BackColor = Color.Gray;
                    }
                    sit[i, j].Click += Seat_Click;
                    Form2.jadwal[filmKe][jamKe].seat.Add(sit[i, j]);

                    xSeat += 30;
                }
                xSeat = 10;
                ySeat += 30;
            }
        }

        private void time_Click(object sender, EventArgs e)
        {
            pilih.Clear();
            pilihKursi.Text = "Seat chosen: ";
            this.SeatPanel.Controls.Clear();
            var send = sender as Button;
            jamke = Convert.ToInt32(send.Tag);

            foreach (Button seat in Form2.jadwal[filmke][jamke].seat)
            {
                if (seat.BackColor == Color.Green)
                {
                    seat.BackColor = Color.Gray;
                }
            }

            if (Form2.jadwal[filmke][jamke].seat.Count == 100)
            {
                foreach (Button seat in Form2.jadwal[filmke][jamke].seat)
                {
                    this.SeatPanel.Controls.Add(seat);
                }
            }
            else
            {
                kursi(filmke, jamke);
                foreach (Button seat in Form2.jadwal[filmke][jamke].seat)
                {
                    this.SeatPanel.Controls.Add(seat);
                }
            }
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            var hmm = sender as Button;
            kursiKe = hmm.Tag.ToString();
            if (hmm.BackColor == Color.Gray)
            {
                hmm.BackColor = Color.Green;
                pilih.Add(kursiKe);
            }
            else if (hmm.BackColor == Color.Green)
            {
                hmm.BackColor = Color.Gray;
                pilih.Remove(kursiKe);
            }
            else
            {
                MessageBox.Show("Seat is reserved. Please choose another seat");
            }
            pilihKursi.Text = "Seat chosen: ";
            foreach (string pilih in pilih)
            {
                if (!pilihKursi.Text.Contains(pilih))
                {
                    pilihKursi.Text += pilih + " ";
                }
            }
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            pilihKursi.Text = "Seat chosen: ";
            foreach (Button kursi in Form2.jadwal[filmke][jamke].seat)
            {
                if (kursi.BackColor == Color.Green)
                {
                    kursi.BackColor = Color.Red;
                }
            }
            foreach (string seat in pilih)
            {
                bookKursi += seat + " ";
            }

            if (pilih.Count != 0)
            {
                MessageBox.Show("You reserve " + bookKursi);
            }
            else
            {
                MessageBox.Show("Please reserve a seat");
            }
        }
        private void clear_Click(object sender, EventArgs e)
        {
            pilih.Clear();
            pilihKursi.Text = "Seat chosen: ";
            foreach (Button seat in Form2.jadwal[filmke][jamke].seat)
            {
                 seat.BackColor = Color.Gray;
            }
        }
    }
}