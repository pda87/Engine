using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Engine
{
    class Engine
    {
        public EngineState EngineState { get; set; }
        public int OilLevel { get; set; }
        public int PetrolLevel { get; set; }
        public int EngineSpeed { get; set; }
        public Piston Piston1 { get; set; }
        public Piston Piston2 { get; set; }
        public Piston Piston3 { get; set; }
        public Piston Piston4 { get; set; }
        public int EngineIterations { get; set; }
        public List<Piston> PistonList { get; set; }

        public Engine()
        {
            this.OilLevel = 2000;
            //this.OilLevel = 100;
            this.PetrolLevel = 25000;
            //this.PetrolLevel = 20;

            this.Piston1 = new Piston();
            this.Piston2 = new Piston();
            this.Piston3 = new Piston();
            this.Piston4 = new Piston();
            this.EngineIterations = 0;

            this.PistonList = new List<Piston>();
        }

        public void StartEngine()
        {
            Random random = new Random();

            this.EngineState = EngineState.Starting;
            this.EngineSpeed = 0;

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
            
            this.EngineSpeed = random.Next(200, 360);

            this.PistonList = new List<Piston>()
            { 
                this.Piston1, 
                this.Piston2, 
                this.Piston3, 
                this.Piston4
            };

        }

        public void RunEngine()
        {
            this.EngineState = EngineState.Running;

            Random random = new Random();

            if (this.PetrolLevel <= 0)
            {
                this.PetrolLevel = 0;
                this.EngineState = EngineState.OutOfPetrol;
                return;
            }

            if (this.OilLevel <= 0)
            {
                this.OilLevel = 0;
                this.EngineState = EngineState.OutOfOil;
                return;
            }

            if (this.OilLevel <= 2000 / 4)
            {
                this.EngineState = EngineState.LowOnOil;
            }

            if (this.PetrolLevel <= 25000 / 4)
            {
                this.EngineState = EngineState.LowOnPetrol;
            }

            this.PistonList.ForEach(p => p.PistonLoop());

            this.PetrolLevel--;
            this.OilLevel--;
            this.PetrolLevel--;
            this.OilLevel--;

            int fixedEngineSpeed = this.EngineSpeed;

            this.EngineIterations++;

            if (this.EngineIterations == 4)
            {
                this.PetrolLevel--;
            }

            if (this.EngineIterations == 18)
            {
                this.EngineSpeed = fixedEngineSpeed;
                this.OilLevel--;
                this.PetrolLevel--;
                this.EngineIterations = 0;
            }

            if (this.EngineIterations == 8)
            {
                this.EngineSpeed = this.EngineSpeed - random.Next(10, 20);
            }

            if (this.EngineIterations == 15)
            {
                this.EngineSpeed = this.EngineSpeed + random.Next(10, 20);
                this.PetrolLevel--;
            }

        }

        public void Accelerate()
        {
            Random random = new Random();

            this.EngineSpeed = this.EngineSpeed + random.Next(200, 360);

            if (this.EngineSpeed >= 6000)
            {
                this.EngineSpeed = 6000 + random.Next(0, 200);
            }
        }

        public void Decelerate()
        {
            Random random = new Random();

            this.EngineSpeed = this.EngineSpeed - random.Next(200, 360);

            if (this.EngineSpeed <= 100)
            {
                this.EngineSpeed = 100 + random.Next(0, 20);
            }
        }

        internal void AddPetrol()
        {
            this.PetrolLevel += 20;
        }

        internal void AddOil()
        {
            this.OilLevel += 10;
        }
    }

    enum EngineState
    {
        Starting,
        Running,
        LowOnOil,
        OutOfOil,
        LowOnPetrol,
        OutOfPetrol,
    }
}
