using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonkeyGame
{
    public partial class Form1 : Form
    {
        GameHearth Game;
        GameHearth Game1;
        Random Myrandom = new Random();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            GamePlay();
        }

        public void GamePlay()
        {
            Game = new GameHearth() { MyPictureBox = Car, StartingPoint = Car.Top, CarPoint = 0,
                /*TrackLength = Car.Parent.Height - Car.Height,*/ Location = 10 };
            Game1 = new GameHearth()
            {
                MyPictureBox = Buffallo,
                StartingPoint = Buffallo.Top,
                Location = 30,
                TrackLength = Buffallo.Parent.Height - Buffallo.Height,
                BuffalloPoint = 0
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Game.CarMove())
            {
                //timer1.Stop();
                label4.Text = Game.CarPoint.ToString();
                //MessageBox.Show(Game.TrackLength.ToString());
                Game.StartAgain();
            }

            if(Game1.BuffalloMove())
            {
                string[] buffalloLocations = new string[] { "319", "153" };
                int RandomValue = int.Parse(buffalloLocations[Myrandom.Next(buffalloLocations.Length)]);
                Buffallo.Left = RandomValue;
                Game1.BuffalloAgain();
            }

            /*if(Car.Bounds.IntersectsWith(Buffallo.Bounds))
            {
                label2.Text = Game1.BuffalloPoint.ToString();
                crashed.Visible = false;
                timer1.Stop();
                Game.StartAgain();
                Game1.BuffalloAgain();
                crashed.Visible = true;
                timer1.Start();
                crashed.Visible = false;
                //crashed.Visible = false;
            }*/
            crashed.Visible = DisplayCrash();
            
        }

        public bool DisplayCrash()
        {
            if (Car.Bounds.IntersectsWith(Buffallo.Bounds))
            {
                label2.Text = Game1.BuffalloPoint.ToString();
                timer1.Stop();
                Game.StartAgain();
                Game1.BuffalloAgain();
                
                timer1.Start();
                //timer1.Interval = 3;
                return true;
            }
            else
                return false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Car.Left = 153;
            }

            if(e.KeyCode == Keys.Right)
            {
                Car.Left = 319;
            }

            if(e.KeyCode == Keys.Q)
            {
                this.Close();
            }
        }
    }
}
