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
    public partial class TrainGUI : UserControl
    {


        public TrainGUI()
        {
            InitializeComponent();
            this.BackgroundImage = imageList1.Images[0];
        }

        public TrainGUI(Train t)
        {
            InitializeComponent();
            int vagn = t.getNumber();
            InstaControlLibrary.Color c = t.getColor();
            if (vagn == 1) { this.BackgroundImage = imageList1.Images[2]; }
            if (vagn == 2) { this.BackgroundImage = imageList1.Images[5]; }
            if (vagn == 3) { this.BackgroundImage = imageList1.Images[8]; }
            if (vagn == 1 && c == InstaControlLibrary.Color.Green) { this.BackgroundImage = imageList1.Images[3]; }
            if (vagn == 1 && c == InstaControlLibrary.Color.Red) { this.BackgroundImage = imageList1.Images[1]; }
            if (vagn == 2 && c == InstaControlLibrary.Color.Green) { this.BackgroundImage = imageList1.Images[3]; }
            if (vagn == 2 && c == InstaControlLibrary.Color.Red) { this.BackgroundImage = imageList1.Images[1]; }
            if (vagn == 3 && c == InstaControlLibrary.Color.Green) { this.BackgroundImage = imageList1.Images[9]; }
            if (vagn == 3 && c == InstaControlLibrary.Color.Red) { this.BackgroundImage = imageList1.Images[7]; }
            if (vagn == 4 && c == InstaControlLibrary.Color.Green) { this.BackgroundImage = imageList1.Images[3]; }
            if (vagn == 4 && c == InstaControlLibrary.Color.Red) { this.BackgroundImage = imageList1.Images[1]; }
            if (vagn == 5 && c == InstaControlLibrary.Color.Green) { this.BackgroundImage = imageList1.Images[6]; }
            if (vagn == 5 && c == InstaControlLibrary.Color.Red) { this.BackgroundImage = imageList1.Images[4]; }
        }        
    }
}
