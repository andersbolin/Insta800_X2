using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// Created by Anders Bolin AB2633 datum: 2013-06-02 email: anders@bolin.nu 
/// Eget Project i Programmering i .NET: Fortsättningskurs
/// </summary>

namespace InstaControlLibrary
{
    public partial class TrainDisplay : UserControl
    {
        //Declaring variables

        public TrainDisplay()
        {
            InitializeComponent();
            InstaControlLibrary.Manager.TestResults += OnResultControl;
            InstaControlLibrary.Manager.ResetGUIt += OnResetControl;

            TrainGUI engine = new TrainGUI();
            this.Controls.Add(engine);
            engine.Location = new System.Drawing.Point(10,10);
            
            Train t1 = new Train(1, Color.Grey);            
            TrainGUI vagn1 = new TrainGUI(t1);
            this.Controls.Add(vagn1);
            vagn1.Location = new System.Drawing.Point(60,10);
            
            Train t2 = new Train(1, Color.Grey);
            TrainGUI vagn2 = new TrainGUI(t2);
            this.Controls.Add(vagn2);
            vagn2.Location = new System.Drawing.Point(110, 10);
            
            Train t3 = new Train(3, Color.Grey);
            TrainGUI vagn3 = new TrainGUI(t3);
            this.Controls.Add(vagn3);
            vagn3.Location = new System.Drawing.Point(160, 10);
            
            Train t4 = new Train(1, Color.Grey);
            TrainGUI vagn4 = new TrainGUI(t4);
            this.Controls.Add(vagn4);
            vagn4.Location = new System.Drawing.Point(210, 10);
            
            Train t5 = new Train(2, Color.Grey);
            TrainGUI vagn5 = new TrainGUI(t5);
            this.Controls.Add(vagn5);
            vagn5.Location = new System.Drawing.Point(260, 10);
        }

        public void iTrainDisplay(Train t)
        {           
            TrainGUI wagon = new TrainGUI(t);            
            this.Controls.Add(wagon);
            wagon.BringToFront();
            int number = t.getNumber();
            if (number == 1) { wagon.Location = new System.Drawing.Point(60,10); }
            if (number == 2) { wagon.Location = new System.Drawing.Point(110, 10); }
            if (number == 3) { wagon.Location = new System.Drawing.Point(160, 10); }
            if (number == 4) { wagon.Location = new System.Drawing.Point(210, 10); }
            if (number == 5) { wagon.Location = new System.Drawing.Point(260, 10); }
        }

        private void OnResultControl(object sender, InstaControlLibrary.TestResultArgs e)
        {
            int wagonnumber = e.getWagonumber;
            InstaControlLibrary.Color c = e.getColor;
            InstaControlLibrary.Train t = new InstaControlLibrary.Train(wagonnumber, c);
            iTrainDisplay(t);
        }
        private void OnResetControl(object sender, EventArgs e)
        {
            TrainGUI engine = new TrainGUI();
            this.Controls.Add(engine);
            engine.BringToFront();
            engine.Location = new System.Drawing.Point(10, 10);

            Train t1 = new Train(1, Color.Grey);
            TrainGUI vagn1 = new TrainGUI(t1);
            this.Controls.Add(vagn1);
            vagn1.BringToFront();
            vagn1.Location = new System.Drawing.Point(60, 10);

            Train t2 = new Train(1, Color.Grey);
            TrainGUI vagn2 = new TrainGUI(t2);
            this.Controls.Add(vagn2);
            vagn2.BringToFront();
            vagn2.Location = new System.Drawing.Point(110, 10);

            Train t3 = new Train(3, Color.Grey);
            TrainGUI vagn3 = new TrainGUI(t3);
            this.Controls.Add(vagn3);
            vagn3.BringToFront();
            vagn3.Location = new System.Drawing.Point(160, 10);

            Train t4 = new Train(1, Color.Grey);
            TrainGUI vagn4 = new TrainGUI(t4);
            this.Controls.Add(vagn4);
            vagn4.BringToFront();
            vagn4.Location = new System.Drawing.Point(210, 10);

            Train t5 = new Train(2, Color.Grey);
            TrainGUI vagn5 = new TrainGUI(t5);
            this.Controls.Add(vagn5);
            vagn5.BringToFront();
            vagn5.Location = new System.Drawing.Point(260, 10);
        }
    }
}
