using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engine
{
    public class Piston
    {
        public int PistonHeight { get; set; }
        public bool Direction { get; set; }
        public StringBuilder PistonProgress { get; set; }

        public Piston()
        {
            this.PistonProgress = new StringBuilder();
        }


        public void PistonLoop(Label pistontextlabel, Label pistonprogresslabel)
        {
            
            if (this.Direction == true)
            {
                pistontextlabel.Text = this.PistonHeight.ToString();
                Thread.Sleep(40);
                this.PistonHeight = this.PistonHeight + 10;
                this.PistonProgress.Append("|");
                pistonprogresslabel.Text = this.PistonProgress.ToString();
                pistonprogresslabel.Refresh();
                pistontextlabel.Refresh();

                if (this.PistonHeight == 100)
                {
                    this.Direction = false;
                }

            }

            if (this.Direction == false)
            {
                pistontextlabel.Text = this.PistonHeight.ToString();
                Thread.Sleep(40);
                this.PistonHeight = this.PistonHeight - 10;
                

                if (this.PistonHeight == 0)
                {
                    this.PistonProgress.Remove(this.PistonProgress.Length, 0);
                    this.Direction = true;
                }

                if (this.PistonProgress.Length != 0)
                {
                    this.PistonProgress.Remove(this.PistonProgress.Length - 1, 1);
                }

                pistonprogresslabel.Text = this.PistonProgress.ToString();
                pistonprogresslabel.Refresh();
                pistontextlabel.Refresh();
            }
        }
    }
}
