using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engine
{
    class Engine
    {
        public string CurrentState { get; set; }
        public int OilLevel { get; set; }
        public int PetrolLevel { get; set; }
        public int EngineSpeed { get; set; }
        public Piston Piston1 { get; set; }
        public Piston Piston2 { get; set; }
        public Piston Piston3 { get; set; }
        public Piston Piston4 { get; set; }

        public Engine()
        {
            this.Piston1 = new Piston();
            this.Piston2 = new Piston();
            this.Piston3 = new Piston();
            this.Piston4 = new Piston();
        }

        public void StartEngine(Label enginespeedlabel, Label piston1label, Label piston2label,
            Label piston3label, Label piston4label, Label oillevellabel, Label petrollevellabel, Label enginestatelabel, Label piston1progresslabel,
            Label piston2progresslabel, Label piston3progresslabel, Label piston4progresslabel)
        {
            this.CurrentState = "Starting...";
            this.EngineSpeed = 0;

            this.OilLevel = 2000;
            this.PetrolLevel = 25000;

            oillevellabel.Text = this.OilLevel.ToString();
            oillevellabel.Refresh();
            petrollevellabel.Text = this.PetrolLevel.ToString();
            petrollevellabel.Refresh();

            enginestatelabel.Text = this.CurrentState;
            enginestatelabel.Refresh();

            this.Piston1 = new Piston();
            this.Piston1.PistonHeight = 0;
            this.Piston1.Direction = true;

            this.Piston2 = new Piston();
            this.Piston2.PistonHeight = 40;
            this.Piston2.Direction = true;
            this.Piston2.PistonProgress.Append("||||");

            this.Piston3 = new Piston();
            this.Piston3.PistonHeight = 80;
            this.Piston3.Direction = false;
            this.Piston3.PistonProgress.Append("||||||||");

            this.Piston4 = new Piston();
            this.Piston4.PistonHeight = 20;
            this.Piston4.Direction = false;
            this.Piston4.PistonProgress.Append("||");

            Random random = new Random();

            while (true)
            {
                enginespeedlabel.Refresh();
                enginespeedlabel.Text = this.EngineSpeed.ToString();

                this.EngineSpeed = this.EngineSpeed + random.Next(200, 360);
                Thread.Sleep(63);
                if (this.EngineSpeed >= 3500)
                {
                    break;
                }

                this.Piston1.PistonLoop(piston1label, piston1progresslabel);
                this.Piston2.PistonLoop(piston2label, piston2progresslabel);
                this.Piston3.PistonLoop(piston3label, piston3progresslabel);
                this.Piston4.PistonLoop(piston4label, piston4progresslabel);

            }

            int i = 0;

            int fixedEngineSpeed = this.EngineSpeed;

            oillevellabel.Text = this.OilLevel.ToString();
            oillevellabel.Refresh();

            petrollevellabel.Text = this.PetrolLevel.ToString();
            petrollevellabel.Refresh();

            this.CurrentState = "Running...";

            enginestatelabel.Text = this.CurrentState;
            enginestatelabel.Refresh();

            this.PetrolLevel--;
            petrollevellabel.Text = this.PetrolLevel.ToString();
            this.OilLevel--;
            oillevellabel.Text = this.OilLevel.ToString();
            petrollevellabel.Refresh();
            oillevellabel.Refresh();
            this.PetrolLevel--;
            petrollevellabel.Text = this.PetrolLevel.ToString();
            this.OilLevel--;
            oillevellabel.Text = this.OilLevel.ToString();
            petrollevellabel.Refresh();
            oillevellabel.Refresh();

            while (true)
            {

                if (this.PetrolLevel <= 0)
                {
                    this.PetrolLevel = 0;
                    this.CurrentState = "Out of petrol...";
                    petrollevellabel.Text = this.PetrolLevel.ToString();
                    petrollevellabel.Refresh();
                    enginestatelabel.Text = this.CurrentState;
                    enginestatelabel.Refresh();
                    break;
                }

                if (this.OilLevel <= 0)
                {
                    this.OilLevel = 0;
                    this.CurrentState = "Out of oil...";
                    oillevellabel.Text = this.OilLevel.ToString();
                    oillevellabel.Refresh();
                    enginestatelabel.Text = this.CurrentState;
                    enginestatelabel.Refresh();
                    break;
                }

                i++;

                if (i == 4)
                {
                    this.PetrolLevel--;
                    petrollevellabel.Refresh();
                    petrollevellabel.Text = this.PetrolLevel.ToString();
                    this.EngineSpeed = this.EngineSpeed - random.Next(0, 10);
                    enginespeedlabel.Refresh();
                }

                if (i == 18)
                {
                    this.EngineSpeed = fixedEngineSpeed;
                    enginespeedlabel.Text = this.EngineSpeed.ToString();
                    enginespeedlabel.Refresh();
                    this.OilLevel--;
                    oillevellabel.Refresh();
                    oillevellabel.Text = this.OilLevel.ToString();
                    this.PetrolLevel--;
                    petrollevellabel.Refresh();
                    petrollevellabel.Text = this.PetrolLevel.ToString();
                    i = 0;
                }

                if (i == 8)
                {
                    this.EngineSpeed = this.EngineSpeed - random.Next(10, 20);
                    enginespeedlabel.Text = this.EngineSpeed.ToString();
                    enginespeedlabel.Refresh();
                }

                if (i == 15)
                {
                    this.EngineSpeed = this.EngineSpeed + random.Next(10, 20);
                    enginespeedlabel.Text = this.EngineSpeed.ToString();
                    enginespeedlabel.Refresh();
                    this.PetrolLevel--;
                    petrollevellabel.Refresh();
                    petrollevellabel.Text = this.PetrolLevel.ToString();
                }

                this.Piston1.PistonLoop(piston1label, piston1progresslabel);
                this.Piston2.PistonLoop(piston2label, piston2progresslabel);
                this.Piston3.PistonLoop(piston3label, piston3progresslabel);
                this.Piston4.PistonLoop(piston4label, piston4progresslabel);

            }
        }
    }
}
