using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonkeyGame
{
    class GameHearth
    {
        public int StartingPoint { get; set; }
        public int TrackLength { get; set; }
        public int Location { get; set; }
        public int CarPoint { get; set; }
        public int BuffalloPoint { get; set; }
        public PictureBox MyPictureBox = null;
        public bool CarMove()
        {
            //Location = 5;
            MyPictureBox.Top -= Location;
            if(MyPictureBox.Top <= 0)
            {
                CarPoint += 1;
                return true;
            }
            return false;
        }

        public bool BuffalloMove()
        {
            MyPictureBox.Top += Location;
            if(MyPictureBox.Top >= TrackLength)
            {
                BuffalloPoint += 1;
                return true;
            }
            return false;
        }
        public void StartAgain()
        {
            //Location = 0;
            MyPictureBox.Top = StartingPoint; 
        }

        public void BuffalloAgain()
        {
            MyPictureBox.Top = StartingPoint;
        }
    }
}
