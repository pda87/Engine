namespace Engine
{
    partial class EngineForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ignitionButton = new System.Windows.Forms.Button();
            this.engineSpeedLabel = new System.Windows.Forms.Label();
            this.piston1Label = new System.Windows.Forms.Label();
            this.piston2Label = new System.Windows.Forms.Label();
            this.piston3Label = new System.Windows.Forms.Label();
            this.piston4Label = new System.Windows.Forms.Label();
            this.oilLevelLabel = new System.Windows.Forms.Label();
            this.petrolLevelLabel = new System.Windows.Forms.Label();
            this.engineStateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.piston1ProgressLabel = new System.Windows.Forms.Label();
            this.piston2ProgressLabel = new System.Windows.Forms.Label();
            this.piston3ProgressLabel = new System.Windows.Forms.Label();
            this.piston4ProgressLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.increaseSpeed = new System.Windows.Forms.Button();
            this.decreaseSpeed = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.addPetrol = new System.Windows.Forms.Button();
            this.addOil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ignitionButton
            // 
            this.ignitionButton.Location = new System.Drawing.Point(12, 16);
            this.ignitionButton.Name = "ignitionButton";
            this.ignitionButton.Size = new System.Drawing.Size(75, 23);
            this.ignitionButton.TabIndex = 0;
            this.ignitionButton.Text = "Start Engine";
            this.ignitionButton.UseVisualStyleBackColor = true;
            this.ignitionButton.Click += new System.EventHandler(this.ignitionButton_Click);
            // 
            // engineSpeedLabel
            // 
            this.engineSpeedLabel.AutoSize = true;
            this.engineSpeedLabel.Location = new System.Drawing.Point(221, 12);
            this.engineSpeedLabel.Name = "engineSpeedLabel";
            this.engineSpeedLabel.Size = new System.Drawing.Size(96, 13);
            this.engineSpeedLabel.TabIndex = 1;
            this.engineSpeedLabel.Text = "engineSpeedLabel";
            // 
            // piston1Label
            // 
            this.piston1Label.AutoSize = true;
            this.piston1Label.Location = new System.Drawing.Point(221, 93);
            this.piston1Label.Name = "piston1Label";
            this.piston1Label.Size = new System.Drawing.Size(67, 13);
            this.piston1Label.TabIndex = 2;
            this.piston1Label.Text = "piston1Label";
            // 
            // piston2Label
            // 
            this.piston2Label.AutoSize = true;
            this.piston2Label.Location = new System.Drawing.Point(221, 175);
            this.piston2Label.Name = "piston2Label";
            this.piston2Label.Size = new System.Drawing.Size(41, 13);
            this.piston2Label.TabIndex = 3;
            this.piston2Label.Text = "piston2";
            // 
            // piston3Label
            // 
            this.piston3Label.AutoSize = true;
            this.piston3Label.Location = new System.Drawing.Point(221, 257);
            this.piston3Label.Name = "piston3Label";
            this.piston3Label.Size = new System.Drawing.Size(41, 13);
            this.piston3Label.TabIndex = 4;
            this.piston3Label.Text = "piston3";
            // 
            // piston4Label
            // 
            this.piston4Label.AutoSize = true;
            this.piston4Label.Location = new System.Drawing.Point(221, 339);
            this.piston4Label.Name = "piston4Label";
            this.piston4Label.Size = new System.Drawing.Size(41, 13);
            this.piston4Label.TabIndex = 5;
            this.piston4Label.Text = "piston4";
            // 
            // oilLevelLabel
            // 
            this.oilLevelLabel.AutoSize = true;
            this.oilLevelLabel.Location = new System.Drawing.Point(418, 12);
            this.oilLevelLabel.Name = "oilLevelLabel";
            this.oilLevelLabel.Size = new System.Drawing.Size(69, 13);
            this.oilLevelLabel.TabIndex = 6;
            this.oilLevelLabel.Text = "oilLevelLabel";
            // 
            // petrolLevelLabel
            // 
            this.petrolLevelLabel.AutoSize = true;
            this.petrolLevelLabel.Location = new System.Drawing.Point(418, 37);
            this.petrolLevelLabel.Name = "petrolLevelLabel";
            this.petrolLevelLabel.Size = new System.Drawing.Size(85, 13);
            this.petrolLevelLabel.TabIndex = 7;
            this.petrolLevelLabel.Text = "petrolLevelLabel";
            // 
            // engineStateLabel
            // 
            this.engineStateLabel.AutoSize = true;
            this.engineStateLabel.Location = new System.Drawing.Point(12, 72);
            this.engineStateLabel.Name = "engineStateLabel";
            this.engineStateLabel.Size = new System.Drawing.Size(90, 13);
            this.engineStateLabel.TabIndex = 8;
            this.engineStateLabel.Text = "engineStateLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Oil Level (ml)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Petrol Level (ml)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Engine Speed (rpm)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Piston 1 Height (mm)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Piston 2 Height (mm)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Piston 3 Height (mm)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Piston 4 Height (mm)";
            // 
            // piston1ProgressLabel
            // 
            this.piston1ProgressLabel.AutoSize = true;
            this.piston1ProgressLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piston1ProgressLabel.Location = new System.Drawing.Point(99, 37);
            this.piston1ProgressLabel.Name = "piston1ProgressLabel";
            this.piston1ProgressLabel.Size = new System.Drawing.Size(194, 56);
            this.piston1ProgressLabel.TabIndex = 16;
            this.piston1ProgressLabel.Text = "piston1";
            // 
            // piston2ProgressLabel
            // 
            this.piston2ProgressLabel.AutoSize = true;
            this.piston2ProgressLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piston2ProgressLabel.Location = new System.Drawing.Point(99, 119);
            this.piston2ProgressLabel.Name = "piston2ProgressLabel";
            this.piston2ProgressLabel.Size = new System.Drawing.Size(194, 56);
            this.piston2ProgressLabel.TabIndex = 17;
            this.piston2ProgressLabel.Text = "piston2";
            // 
            // piston3ProgressLabel
            // 
            this.piston3ProgressLabel.AutoSize = true;
            this.piston3ProgressLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piston3ProgressLabel.Location = new System.Drawing.Point(99, 201);
            this.piston3ProgressLabel.Name = "piston3ProgressLabel";
            this.piston3ProgressLabel.Size = new System.Drawing.Size(194, 56);
            this.piston3ProgressLabel.TabIndex = 18;
            this.piston3ProgressLabel.Text = "piston3";
            // 
            // piston4ProgressLabel
            // 
            this.piston4ProgressLabel.AutoSize = true;
            this.piston4ProgressLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piston4ProgressLabel.Location = new System.Drawing.Point(99, 283);
            this.piston4ProgressLabel.Name = "piston4ProgressLabel";
            this.piston4ProgressLabel.Size = new System.Drawing.Size(194, 56);
            this.piston4ProgressLabel.TabIndex = 19;
            this.piston4ProgressLabel.Text = "piston4";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(12, 118);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 20;
            this.stopButton.Text = "Stop Button";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // increaseSpeed
            // 
            this.increaseSpeed.Location = new System.Drawing.Point(315, 93);
            this.increaseSpeed.Name = "increaseSpeed";
            this.increaseSpeed.Size = new System.Drawing.Size(138, 23);
            this.increaseSpeed.TabIndex = 21;
            this.increaseSpeed.Text = "Increase Speed";
            this.increaseSpeed.UseVisualStyleBackColor = true;
            this.increaseSpeed.Click += new System.EventHandler(this.increaseSpeed_Click);
            // 
            // decreaseSpeed
            // 
            this.decreaseSpeed.Location = new System.Drawing.Point(315, 160);
            this.decreaseSpeed.Name = "decreaseSpeed";
            this.decreaseSpeed.Size = new System.Drawing.Size(138, 23);
            this.decreaseSpeed.TabIndex = 22;
            this.decreaseSpeed.Text = "Decrease Speed";
            this.decreaseSpeed.UseVisualStyleBackColor = true;
            this.decreaseSpeed.Click += new System.EventHandler(this.decreaseSpeed_Click);
            // 
            // timer
            // 
            this.timer.Interval = 63;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // addPetrol
            // 
            this.addPetrol.Location = new System.Drawing.Point(315, 227);
            this.addPetrol.Name = "addPetrol";
            this.addPetrol.Size = new System.Drawing.Size(138, 23);
            this.addPetrol.TabIndex = 23;
            this.addPetrol.Text = "Add Petrol";
            this.addPetrol.UseVisualStyleBackColor = true;
            this.addPetrol.Click += new System.EventHandler(this.addPetrol_Click);
            // 
            // addOil
            // 
            this.addOil.Location = new System.Drawing.Point(315, 294);
            this.addOil.Name = "addOil";
            this.addOil.Size = new System.Drawing.Size(138, 23);
            this.addOil.TabIndex = 24;
            this.addOil.Text = "Add Oil";
            this.addOil.UseVisualStyleBackColor = true;
            this.addOil.Click += new System.EventHandler(this.addOil_Click);
            // 
            // EngineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 369);
            this.Controls.Add(this.addOil);
            this.Controls.Add(this.addPetrol);
            this.Controls.Add(this.decreaseSpeed);
            this.Controls.Add(this.increaseSpeed);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.piston4ProgressLabel);
            this.Controls.Add(this.piston3ProgressLabel);
            this.Controls.Add(this.piston2ProgressLabel);
            this.Controls.Add(this.piston1ProgressLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.engineStateLabel);
            this.Controls.Add(this.petrolLevelLabel);
            this.Controls.Add(this.oilLevelLabel);
            this.Controls.Add(this.piston4Label);
            this.Controls.Add(this.piston3Label);
            this.Controls.Add(this.piston2Label);
            this.Controls.Add(this.piston1Label);
            this.Controls.Add(this.engineSpeedLabel);
            this.Controls.Add(this.ignitionButton);
            this.Name = "EngineForm";
            this.Text = "Engine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label engineSpeedLabel;
        private System.Windows.Forms.Label piston1Label;
        private System.Windows.Forms.Label piston2Label;
        private System.Windows.Forms.Label piston3Label;
        private System.Windows.Forms.Label piston4Label;
        private System.Windows.Forms.Label oilLevelLabel;
        private System.Windows.Forms.Label petrolLevelLabel;
        private System.Windows.Forms.Label engineStateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label piston1ProgressLabel;
        private System.Windows.Forms.Label piston2ProgressLabel;
        private System.Windows.Forms.Label piston3ProgressLabel;
        private System.Windows.Forms.Label piston4ProgressLabel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button increaseSpeed;
        private System.Windows.Forms.Button decreaseSpeed;
        private System.Windows.Forms.Timer timer;
        internal System.Windows.Forms.Button ignitionButton;
        private System.Windows.Forms.Button addPetrol;
        private System.Windows.Forms.Button addOil;
    }
}

