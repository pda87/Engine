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

        public void PistonLoop(Label label)
        {
            if (this.Direction == true)
            {
                label.Refresh();
                label.Text = this.PistonHeight.ToString();
                Thread.Sleep(40);
                this.PistonHeight = this.PistonHeight + 10;

                if (this.PistonHeight == 100)
                {
                    this.Direction = false;
                }

            }

            if (this.Direction == false)
            {
                label.Refresh();
                label.Text = this.PistonHeight.ToString();
                Thread.Sleep(40);
                this.PistonHeight = this.PistonHeight - 10;

                if (this.PistonHeight == 0)
                {
                    this.Direction = true;
                }
            }
        }
    }
}
