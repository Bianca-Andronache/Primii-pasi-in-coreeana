﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Atestat1
{
    public partial class Form11 : Form
    {
        Thread th;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Form11()
        {
            InitializeComponent();
        }

        private void alfabetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewForm2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenNewForm2(object obj)
        {
            Application.Run(new Form2());
        }

        private void numereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewForm3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenNewForm3(object obj)
        {
            Application.Run(new Form3());
        }

        private void teorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewForm4);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenNewForm4(object obj)
        {
            Application.Run(new Form4());
        }

        private void recapitulareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewForm5);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenNewForm5(object obj)
        {
            Application.Run(new Form5());
        }

        private void pronumeSiArticoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewForm6);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenNewForm6(object obj)
        {
            Application.Run(new Form6());
        }

        private void familieSiRelatiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewForm7);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenNewForm7(object obj)
        {
            Application.Run(new Form7());
        }

        private void animaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewForm8);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenNewForm8(object obj)
        {
            Application.Run(new Form8());
        }

        private void cuvinteDeBazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewForm9);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenNewForm9(object obj)
        {
            Application.Run(new Form9());
        }

        private void adjectiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewForm10);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenNewForm10(object obj)
        {
            Application.Run(new Form10());
        }

        private void verbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewForm11);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenNewForm11(object obj)
        {
            Application.Run(new Form11());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/가다.wav";
            player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/오다.wav";
            player.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/있다.wav";
            player.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/이다.wav";
            player.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/먹다.wav";
            player.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/마시다.wav";
            player.Play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/주다.wav";
            player.Play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/보다.wav";
            player.Play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/자다.wav";
            player.Play();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/사다.wav";
            player.Play();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/일어나다.wav";
            player.Play();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/쓰다.wav";
            player.Play();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/웃다.wav";
            player.Play();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/울다.wav";
            player.Play();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/입다.wav";
            player.Play();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/읽다.wav";
            player.Play();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/배우다.wav";
            player.Play();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/공부하다.wav";
            player.Play();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/만나다.wav";
            player.Play();
        }

        private void meniuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewForm1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenNewForm1(object obj)
        {
            Application.Run(new Form1());
        }
    }
}
