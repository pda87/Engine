using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engine
{
    public partial class EngineForm : Form
    {
        Engine engine;
        Random random = new Random();
        bool isFirstStart = true;
        int timerInterval = 63;

        public EngineForm()
        {
            InitializeComponent();
            timer.Interval = timerInterval;
            engine = new Engine();
            List<Label> labelList = new List<Label>()
            {
                engineSpeedLabel,
                oilLevelLabel,
                petrolLevelLabel,
                engineStateLabel,
                piston1Label,
                piston2Label,
                piston3Label,
                piston4Label,
            };

            foreach (Label label in labelList)
            {
                label.Text = string.Empty;
            }

            piston1Label.Text = 0.ToString();
            piston1ProgressLabel.Text = string.Empty;
            piston2ProgressLabel.Text = "||||";
            piston2Label.Text = 40.ToString();
            piston3ProgressLabel.Text = "||||||||";
            piston3Label.Text = 80.ToString();
            piston4ProgressLabel.Text = "||";
            piston4Label.Text = 20.ToString();

            petrolLevelLabel.Text = engine.PetrolLevel.ToString();
            oilLevelLabel.Text = engine.OilLevel.ToString();
            engineSpeedLabel.Text = 0.ToString();

        }

        private void ignitionButton_Click(object sender, EventArgs e)
        {
            ignitionButton.Enabled = false;
            stopButton.Enabled = true;

            if (isFirstStart)
            {
                engine.StartEngine();
                isFirstStart = false;
            }

            oilLevelLabel.Text = engine.OilLevel.ToString();
            oilLevelLabel.Refresh();
            petrolLevelLabel.Text = engine.PetrolLevel.ToString();
            petrolLevelLabel.Refresh();

            engineStateLabel.Text = engine.EngineState.ToString();
            engineStateLabel.Refresh();

            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            engineLoop();
        }

        private void engineLoop()
        {
            engine.RunEngine();

            if (engine.EngineState.ToString().Contains("OutOfOil") || engine.EngineState.ToString().Contains("OutOfPetrol"))
            {
                engineStateLabel.Text = engine.EngineState.ToString();
                engineStateLabel.Refresh();
                oilLevelLabel.Text = engine.OilLevel.ToString();
                oilLevelLabel.Refresh();
                petrolLevelLabel.Text = engine.PetrolLevel.ToString();
                petrolLevelLabel.Refresh();
                timer.Stop();
                return;
            }

            if (engine.EngineState.ToString().Contains("LowOnOil") || engine.EngineState.ToString().Contains("LowOnPetrol"))
            {
                engineStateLabel.Text = engine.EngineState.ToString();
                engineStateLabel.Refresh();
                oilLevelLabel.Text = engine.OilLevel.ToString();
                oilLevelLabel.Refresh();
                petrolLevelLabel.Text = engine.PetrolLevel.ToString();
                petrolLevelLabel.Refresh();
            }

            updateAllLabels();
        }

        private void updateAllLabels()
        {
            piston1Label.Text = engine.Piston1.PistonHeight.ToString();
            piston2Label.Text = engine.Piston2.PistonHeight.ToString();
            piston3Label.Text = engine.Piston3.PistonHeight.ToString();
            piston4Label.Text = engine.Piston4.PistonHeight.ToString();

            piston1Label.Refresh();
            piston2Label.Refresh();
            piston3Label.Refresh();
            piston4Label.Refresh();

            piston1ProgressLabel.Text = engine.Piston1.PistonProgress.ToString();
            piston2ProgressLabel.Text = engine.Piston2.PistonProgress.ToString();
            piston3ProgressLabel.Text = engine.Piston3.PistonProgress.ToString();
            piston4ProgressLabel.Text = engine.Piston4.PistonProgress.ToString();

            piston1ProgressLabel.Refresh();
            piston2ProgressLabel.Refresh();
            piston3ProgressLabel.Refresh();
            piston4ProgressLabel.Refresh();

            engineSpeedLabel.Refresh();
            engineSpeedLabel.Text = engine.EngineSpeed.ToString();
            engineStateLabel.Text = engine.EngineState.ToString();
            engineStateLabel.Refresh();
            engineSpeedLabel.Text = engine.EngineSpeed.ToString();
            engineSpeedLabel.Refresh();
            petrolLevelLabel.Text = engine.PetrolLevel.ToString();
            petrolLevelLabel.Refresh();
            oilLevelLabel.Text = engine.OilLevel.ToString();
            oilLevelLabel.Refresh();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            ignitionButton.Enabled = true;
            stopButton.Enabled = false;
        }

        private void increaseSpeed_Click(object sender, EventArgs e)
        {
            engine.Accelerate();

            timerInterval -= 10;

            if (timerInterval <= 5)
            {
                timerInterval = 5;
            }

            timer.Interval = timerInterval;
        }

        private void decreaseSpeed_Click(object sender, EventArgs e)
        {
            engine.Decelerate();

            timerInterval += 10;

            if (timerInterval >= 650)
            {
                timerInterval = 650;
            }

            timer.Interval = timerInterval;
        }

        private void addPetrol_Click(object sender, EventArgs e)
        {
            engine.AddPetrol();
        }

        private void addOil_Click(object sender, EventArgs e)
        {
            engine.AddOil();
        }

    }
}
