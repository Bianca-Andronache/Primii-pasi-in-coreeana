using System;
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
    public partial class Form8 : Form
    {
        Thread th;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Form8()
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
            player.SoundLocation = "sounds/개.wav";
            player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/고양이.wav";
            player.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/토끼.wav";
            player.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/암탉.wav";
            player.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/수탉.wav";
            player.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/닭.wav";
            player.Play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/말.wav";
            player.Play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/돼지.wav";
            player.Play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/암소.wav";
            player.Play();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/양.wav";
            player.Play();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/염소.wav";
            player.Play();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/당나귀.wav";
            player.Play();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/쥐.wav";
            player.Play();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/원숭이.wav";
            player.Play();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/악어.wav";
            player.Play();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/사자.wav";
            player.Play();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/호랑이.wav";
            player.Play();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/코끼리.wav";
            player.Play();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/뱀.wav";
            player.Play();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/다람쥐.wav";
            player.Play();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/여우.wav";
            player.Play();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/늑대.wav";
            player.Play();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/곰.wav";
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
