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
    public partial class Form5 : Form
    {
        Thread th;

        List<Panel> listPanel = new List<Panel>();
        int index;

        string s;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        private void Form5_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
            listPanel.Add(panel4);
            listPanel.Add(panel5);
            listPanel.Add(panel6);
            listPanel.Add(panel7);
            listPanel.Add(panel8);
            listPanel.Add(panel9);
            listPanel.Add(panel10);
            listPanel.Add(panel11);
            listPanel.Add(panel12);
            listPanel.Add(panel13);
            listPanel.Add(panel14);
            listPanel.Add(panel15);
            listPanel.Add(panel16);
            listPanel.Add(panel17);
            listPanel.Add(panel18);

            listPanel[index].BringToFront();
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            index++;
            listPanel[index].BringToFront();
            panel2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/coreea.wav";
            player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/china.wav";
            player.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/america.wav";
            player.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/anglia.wav";
            player.Play();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/persoana.wav";
            player.Play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/vreme.wav";
            player.Play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/animale.wav";
            player.Play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/fructe.wav";
            player.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            index++;
            listPanel[index].BringToFront();
            panel3.Visible = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("goodjob.png");
            player.SoundLocation = "sounds/coreea.wav";
            player.Play();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("maybe.png");
            player.SoundLocation = "sounds/china.wav";
            player.Play();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("maybe.png");
            player.SoundLocation = "sounds/anglia.wav";
            player.Play();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("maybe.png");
            player.SoundLocation = "sounds/america.wav";
            player.Play();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pictureBox2.Load("maybe.png");
            player.SoundLocation = "sounds/animale.wav";
            player.Play();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            pictureBox2.Load("maybe.png");
            player.SoundLocation = "sounds/vreme.wav";
            player.Play();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            pictureBox2.Load("maybe.png");
            player.SoundLocation = "sounds/fructe.wav";
            player.Play();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pictureBox2.Load("goodjob.png");
            player.SoundLocation = "sounds/persoana.wav";
            player.Play();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            index++;
            listPanel[index].BringToFront();
            panel4.Visible = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            pictureBox3.Load("maybe.png");
            player.SoundLocation = "sounds/anglia.wav";
            player.Play();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            index++;
            listPanel[index].BringToFront();
            panel5.Visible = true;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            pictureBox3.Load("maybe.png");
            player.SoundLocation = "sounds/coreea.wav";
            player.Play();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            pictureBox3.Load("goodjob.png");
            player.SoundLocation = "sounds/china.wav";
            player.Play();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            pictureBox3.Load("maybe.png");
            player.SoundLocation = "sounds/america.wav";
            player.Play();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "한국";
            player.SoundLocation = "sounds/coreean.wav";
            player.Play();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "미국";
            player.SoundLocation = "sounds/american.wav";
            player.Play();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "사람";
            player.SoundLocation = "sounds/persoana.wav";
            player.Play();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "중국";
            player.SoundLocation = "sounds/chinez.wav";
            player.Play();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true) pictureBox4.Load("goodjob.png");
            else pictureBox4.Load("maybe.png");
            button27.Visible = true;
            button27.BringToFront();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            index++;
            listPanel[index].BringToFront();
            panel6.Visible = true;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            index++;
            listPanel[index].BringToFront();
            panel7.Visible = true;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            pictureBox5.Load("maybe.png");
            player.SoundLocation = "sounds/coreea.wav";
            player.Play();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            pictureBox5.Load("goodjob.png");
            player.SoundLocation = "sounds/america.wav";
            player.Play();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            pictureBox5.Load("maybe.png");
            player.SoundLocation = "sounds/china.wav";
            player.Play();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            pictureBox5.Load("maybe.png");
            player.SoundLocation = "sounds/anglia.wav";
            player.Play();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            index++;
            listPanel[index].BringToFront();
            panel8.Visible = true;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/coreean.wav";
            player.Play();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            pictureBox6.Load("goodjob.png");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            pictureBox6.Load("maybe.png");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            pictureBox6.Load("maybe.png");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            pictureBox6.Load("maybe.png");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            index++;
            listPanel[index].BringToFront();
            panel9.Visible = true;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/chinez.wav";
            player.Play();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            pictureBox8.Load("maybe.png");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            pictureBox8.Load("goodjob.png");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            pictureBox8.Load("maybe.png");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            pictureBox8.Load("maybe.png");
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = "중국";
            player.SoundLocation = "sounds/chinez.wav";
            player.Play();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = "사람";
            player.SoundLocation = "sounds/persoana.wav";
            player.Play();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = "미국";
            player.SoundLocation = "sounds/american.wav";
            player.Play();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = "한국";
            player.SoundLocation = "sounds/coreean.wav";
            player.Play();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if(radioButton7.Checked==true) pictureBox7.Load("goodjob.png");
            else pictureBox7.Load("maybe.png");
            button40.Visible = true;
            button40.BringToFront();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            index++;
            listPanel[index].BringToFront();
            panel10.Visible = true;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            s = string.Concat(label16.Text, "국");
            label16.Text = s;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            s = string.Concat(label16.Text, "미");
            label16.Text = s;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            s = string.Concat(label16.Text, " ");
            label16.Text = s;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            s = string.Concat(label16.Text, "사");
            label16.Text = s;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            s = string.Concat(label16.Text, "람");
            label16.Text = s;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (label16.Text.Length >= 1)
            {
                s = label16.Text.Remove(label16.Text.Length - 1);
                label16.Text = s;
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (label16.Text == "미국 사람")
                pictureBox9.Load("goodjob.png");
            else pictureBox9.Load("maybe.png");
            button54.Visible = true;
            button54.BringToFront();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            index++;
            listPanel[index].BringToFront();
            panel11.Visible = true;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            index++;
            listPanel[index].BringToFront();
            panel12.Visible = true;
        }

        private void button62_Click(object sender, EventArgs e)
        {
            s = string.Concat(label17.Text, "국");
            label17.Text = s;
        }

        private void button61_Click(object sender, EventArgs e)
        {
            s = string.Concat(label17.Text, "한");
            label17.Text = s;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            s = string.Concat(label17.Text, " ");
            label17.Text = s;
        }

        private void button59_Click(object sender, EventArgs e)
        {
            s = string.Concat(label17.Text, "람");
            label17.Text = s;
        }

        private void button58_Click(object sender, EventArgs e)
        {
            s = string.Concat(label17.Text, "사");
            label17.Text = s;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (label17.Text.Length >= 1)
            {
                s = label17.Text.Remove(label17.Text.Length - 1);
                label17.Text = s;
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (label17.Text == "한국 사람")
                pictureBox10.Load("goodjob.png");
            else pictureBox10.Load("maybe.png");
            button55.Visible = true;
            button55.BringToFront();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            index++;
            listPanel[index].BringToFront();
            panel13.Visible = true;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            label22.Text = "이";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            label22.Text = "나";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            label22.Text = "그";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            label22.Text = "저";
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (label22.Text == "저") pictureBox11.Load("goodjob.png");
            else pictureBox11.Load("maybe.png");
            player.SoundLocation = "sounds/eu sunt chinez.wav";
            player.Play();
            button68.Visible = true;
            button68.BringToFront();
        }

        private void button68_Click(object sender, EventArgs e)
        {
            index++;
            listPanel[index].BringToFront();
            panel15.Visible = true;
        }

        private void button65_Click(object sender, EventArgs e)
        {
            index++;
            listPanel[index].BringToFront();
            panel14.Visible = true;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            label25.Text = "이";
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            label25.Text = "는";
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            label25.Text = "은";
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            label25.Text = "가";
        }

        private void button70_Click(object sender, EventArgs e)
        {
            if (label25.Text == "는") pictureBox12.Load("goodjob.png");
            else pictureBox12.Load("maybe.png");
            player.SoundLocation = "sounds/eu sunt coreean.wav";
            player.Play();
            button69.Visible = true;
            button69.BringToFront();
        }

        private void button63_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/eu sunt chinez.wav";
            player.Play();
        }

        private void button64_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/eu sunt coreean.wav";
            player.Play();
        }

        private void button66_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/eu sunt american.wav";
            player.Play();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            label28.Text = "입니다";
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            label28.Text = "습니다";
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            label28.Text = "이다";
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            label28.Text = "합니다";
        }

        private void button72_Click(object sender, EventArgs e)
        {
            if (label28.Text == "입니다") pictureBox13.Load("goodjob.png");
            else pictureBox13.Load("maybe.png");
            player.SoundLocation = "sounds/eu sunt american.wav";
            player.Play();
            button71.Visible = true;
            button71.BringToFront();
        }

        private void button69_Click(object sender, EventArgs e)
        {
            index++;
            listPanel[index].BringToFront();
            panel16.Visible = true;
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button74_Click(object sender, EventArgs e)
        {
            if (radioButton24.Checked == true) pictureBox14.Load("goodjob.png");
            else pictureBox14.Load("maybe.png");
            player.SoundLocation = "sounds/eu sunt chinez.wav";
            player.Play();
            button73.Visible = true;
            button73.BringToFront();
        }

        private void button71_Click(object sender, EventArgs e)
        {
            index++;
            listPanel[index].BringToFront();
            panel17.Visible = true;
        }

        private void button82_Click(object sender, EventArgs e)
        {
            s = string.Concat(label31.Text, "저");
            label31.Text = s;
        }

        private void button81_Click(object sender, EventArgs e)
        {
            s = string.Concat(label31.Text, "는");
            label31.Text = s;
        }

        private void button80_Click(object sender, EventArgs e)
        {
            s = string.Concat(label31.Text, " ");
            label31.Text = s;
        }

        private void button79_Click(object sender, EventArgs e)
        {
            s = string.Concat(label31.Text, "국");
            label31.Text = s;
        }

        private void button78_Click(object sender, EventArgs e)
        {
            s = string.Concat(label31.Text, "미");
            label31.Text = s;
        }

        private void button85_Click(object sender, EventArgs e)
        {
            s = string.Concat(label31.Text, " ");
            label31.Text = s;
        }

        private void button84_Click(object sender, EventArgs e)
        {
            s = string.Concat(label31.Text, "람");
            label31.Text = s;
        }

        private void button83_Click(object sender, EventArgs e)
        {
            s = string.Concat(label31.Text, "사");
            label31.Text = s;
        }

        private void button86_Click(object sender, EventArgs e)
        {
            s = string.Concat(label31.Text, "니");
            label31.Text = s;
        }

        private void button87_Click(object sender, EventArgs e)
        {
            s = string.Concat(label31.Text, "다");
            label31.Text = s;
        }

        private void button88_Click(object sender, EventArgs e)
        {
            s = string.Concat(label31.Text, "입");
            label31.Text = s;
        }

        private void button77_Click(object sender, EventArgs e)
        {
            if (label31.Text.Length >= 1)
            {
                s = label31.Text.Remove(label31.Text.Length - 1);
                label31.Text = s;
            }
        }

        private void button76_Click(object sender, EventArgs e)
        {
            if (label31.Text == "저는 미국 사람입니다")
                pictureBox15.Load("goodjob.png");
            else pictureBox15.Load("maybe.png");
            player.SoundLocation = "sounds/eu sunt american.wav";
            player.Play();
            button75.Visible = true;
            button75.BringToFront();
        }

        private void button73_Click(object sender, EventArgs e)
        {
            index++;
            listPanel[index].BringToFront();
            panel18.Visible = true;
        }

        private void button75_Click(object sender, EventArgs e)
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

        private void alfabetToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void numereToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void teorieToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void recapitulareToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void famileSiRelatiiToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void meniuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewForm1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
