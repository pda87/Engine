using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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

        public void PistonLoop()
        {

            if (this.Direction == true)
            {
                this.PistonHeight = this.PistonHeight + 10;
                this.PistonProgress.Append("|");

                if (this.PistonHeight == 100)
                {
                    this.Direction = false;
                }

            }

            if (this.Direction == false)
            {
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

            }
        }
    }
}
