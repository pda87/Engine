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

        public EngineForm()
        {
            InitializeComponent();

            List<Label> labelList = new List<Label>() {
                engineSpeedLabel,
                oilLevelLabel,
                petrolLevelLabel,
                engineStateLabel,
                piston1Label,
                piston2Label,
                piston3Label,
                piston4Label
            };

            foreach (Label label in labelList)
            {
                label.Text = "";
            }
        }
        
        private void ignitionButton_Click(object sender, EventArgs e)
        {
            Engine engine = new Engine();
            engine.StartEngine(engineSpeedLabel, piston1Label, piston2Label, piston3Label, piston4Label, oilLevelLabel, petrolLevelLabel, engineStateLabel);
        }
    }
}
