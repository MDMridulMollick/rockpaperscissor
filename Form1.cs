using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSGame
{
    public partial class Form1 : Form
    {
        Random ran = new Random();
      
        int chr;
        static int round = 0;
        static int hw = 0;
        static int cw = 0;
        static int t = 0;
        int d = 20;

        public Form1()
        {
            InitializeComponent();
        }
        string roc = @"C: \Users\HP\Desktop\AssignmentGame\RPSGame\RPSGame\picture\rock.bmp";
        string paper = @"C: \Users\HP\Desktop\AssignmentGame\RPSGame\RPSGame\picture\paper.bmp";
        string scissors = @"C: \Users\HP\Desktop\AssignmentGame\RPSGame\RPSGame\picture\scissors.bmp";

        private void btnrock_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pcboxhuman.Image = new Bitmap(roc);
            Computer();
            if (chr == 2) { hmc(); }
            else if (chr == 0) { tiec(); }
            else if (chr == 1) { cwc(); }
            round++;
            tbtry.Text = Convert.ToString(round);
   
            if (round%5 ==0)
            {
                this.d = 20;
                timer1.Stop();
                if (hw > cw) { humanwin(); }
                if (hw < cw) { computerwin(); }
                else if (t > hw && t > cw) { nobodywins(); }
             }
            else { this.Show(); }
        }

        private void btnpaper_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pcboxhuman.Image = new Bitmap(paper);
            Computer();
            if (chr == 0) { hmc(); }
            else if (chr == 1) { tiec(); }
            else if (chr == 2) { cwc(); }
            round++;
            tbtry.Text = Convert.ToString(round);
            if (round %5== 0)
            {
                this.d = 20;
                timer1.Stop();
                if (hw > cw) { humanwin(); }
                if (hw < cw) { computerwin();}
                else if (t > cw && t > hw) { nobodywins();}
            }
            else { this.Show(); }
        }
    
        private void btnscissor_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pcboxhuman.Image = new Bitmap(scissors);
            Computer();
            if (chr == 1) { hmc(); }
            else if (chr == 2) { tiec(); }
            else if (chr == 0) { cwc();}
            round++;
            tbtry.Text = Convert.ToString(round);
           
            if (round%5 == 0)
            {
                this.d = 20;
                timer1.Stop();
                if (hw > cw){ humanwin(); }
               else if (hw < cw) { computerwin();}
               else if (t > hw && t > cw) { nobodywins(); }
            }
            else { this.Show(); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Are you sure to close ??", "Confirmation ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(result == DialogResult.No){
                this.Show();
            }


        }
        public void Computer()
        {
           int ch= ran.Next(0, 3);
            this.chr = ch;
            switch (ch)
            {
                case 0:
                    pcboxcomputer.Image = new Bitmap(roc);
                    break;
                case 1:
                    pcboxcomputer.Image = new Bitmap(paper);
                    break;
                case 2:
                    pcboxcomputer.Image = new Bitmap(scissors);
                    break;
            }
        }
       
        public void reset()
        {
            hw = 0;
            cw = 0;
            t = 0;
            d = 20;
            round = 0;
            // stop();
            pcboxcomputer.Image = null;
            pcboxhuman.Image = null;
            tbcomputer.Text =Convert.ToString( 0);
            tbhuman.Text =Convert.ToString( 0);
            tbroud.Text = Convert.ToString(0);
            tbtie.Text = Convert.ToString(0);
            tbtry.Text = "0";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void nobodywins()
        {

            DialogResult r = MessageBox.Show("Do You Want Play Again??", "Nobody Wins", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (timer1.Enabled ==false)
                {
                    timer1.Start();
                }
                else timer1.Start();
                reset();
            }
            else if (r == DialogResult.No) { Application.Exit(); }
            else if (r == DialogResult.Cancel)
            {
                this.Show();
                reset();
                timer1.Stop();
            }
        }
        public void humanwin()
        {
            DialogResult r = MessageBox.Show("Do You Want Play Again??", "Player Wins", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (timer1.Enabled == false)
                {
                    timer1.Start();
                }
                else timer1.Start();
                reset();
            }
            else if (r == DialogResult.No) { Application.Exit(); }
            else if (r == DialogResult.Cancel)
            {
                this.Show();
                reset();
                timer1.Stop();

            }
        }
        public void computerwin()
        {
            DialogResult r = MessageBox.Show("Do You Want Play Again??", "Computer Wins ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (timer1.Enabled == false)
                {
                    timer1.Start();
                }
                else timer1.Start();
                reset();
            }
            else if (r == DialogResult.No) { Application.Exit(); }
            else if (r == DialogResult.Cancel)
            {
                this.Show();
                reset();
                timer1.Stop();
            }
        }

        public void hmc()
        {
            tbroud.Text = "Human Win";
            hw++;
            tbhuman.Text = Convert.ToString(hw);
        }

      

        public void tiec()
        {
            tbroud.Text = "Tie";
            t++;
            tbtie.Text = Convert.ToString(t);
        }
        public void cwc()
        {
            tbroud.Text = "Computer Win";
            cw++;
            tbcomputer.Text = Convert.ToString(cw);
        }

        
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            tbtime.Text = Convert.ToString(d);
            d--;
            if (d == -1) {
                stop();
                DialogResult r = MessageBox.Show("Time Up ", "Do you want play again?" +
                    "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (r == DialogResult.Yes) {
                    reset();
                    timer1.Start();
                   // stop();
                }
                else if (r == DialogResult.No){
                    Application.Exit();
                }
                else if(r == DialogResult.Cancel){
                    this.Show();
                    reset();
                    timer1.Stop();
                    
                }
            } 


        }
        public void stop()
        {
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
          //  d = 20;
        }
    }
}
