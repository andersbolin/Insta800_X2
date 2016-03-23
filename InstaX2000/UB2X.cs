using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// Created by Anders Bolin AB2633 datum: 2013-06-02 email: anders@bolin.nu 
/// Eget Project i Programmering i .NET: Fortsättningskurs
/// </summary>

namespace InstaX2000
{
    public partial class UB2X : Form
    {
        //Declaring variables
        private int place1, seat1nr, seat2nr, seat3nr;
        private int place2;
        private int place3;
        private int place4;
        private int m_wagonnumber;
        private string m_trainnr;

        public UB2X()
        {
            InitializeComponent();
        }
        public UB2X(int one, int two, int three, int extra, int wagonnumber, int seat1, int seat2, int seat3, string wagonnr)
        {
            InitializeComponent();
            this.place1 = one;
            this.place2 = two;
            this.place3 = three;
            this.place4 = extra;
            this.seat1nr = seat1;
            this.seat2nr = seat2;
            this.seat3nr = seat3;
            this.m_wagonnumber = wagonnumber;
            this.m_trainnr = wagonnr;
            initform();
            cmbBoxChair1Damm.SelectedIndex = 0;
            cmbBoxChair1Flackar.SelectedIndex = 0;
            cmbBoxChair1Skrap.SelectedIndex = 0;
            cmbBoxChair2Damm.SelectedIndex = 0;
            cmbBoxChair2Flackar.SelectedIndex = 0;
            cmbBoxChair2Skrap.SelectedIndex = 0;
            cmbBoxChair3Damm.SelectedIndex = 0;
            cmbBoxChair3Flackar.SelectedIndex = 0;
            cmbBoxChair3Skrap.SelectedIndex = 0;
            cmbBoxExtraDamm.SelectedIndex = 0;
            cmbBoxExtraFlackar.SelectedIndex = 0;
            cmbBoxExtraSkrap.SelectedIndex = 0;
        }
        public void initform()
        {
            lblStolnummer1.Text = place1.ToString();
            lblStolnummer2.Text = place2.ToString();
            lblStolnummer3.Text = place3.ToString();
            if (place4 == 1)
            {
                label11.Text = "WC B-ända";
            }
            else
            {
                bool any = false;
                Random random = new Random();
                int ran = random.Next(0, 2);
                if (ran == 1) { any = true; }
                string strout = (any ? "Vestibul A-ände" : "Vestibul B-Ände");
                label11.Text = strout;
            }
        }

        private void btnDone_Click_1(object sender, EventArgs e)
        {
            int chair1damm = cmbBoxChair1Damm.SelectedIndex;
            int chair1Fla = cmbBoxChair1Flackar.SelectedIndex;
            int chair1Skr = cmbBoxChair1Skrap.SelectedIndex;
            int chair2damm = cmbBoxChair2Damm.SelectedIndex;
            int chair2Fla = cmbBoxChair2Flackar.SelectedIndex;
            int chair2Skr = cmbBoxChair2Skrap.SelectedIndex;
            int chair3damm = cmbBoxChair3Damm.SelectedIndex;
            int chair3Fla = cmbBoxChair3Flackar.SelectedIndex;
            int chair3Skr = cmbBoxChair3Skrap.SelectedIndex;
            int extra1 = cmbBoxExtraDamm.SelectedIndex;
            int extra2 = cmbBoxExtraFlackar.SelectedIndex;
            int extra3 = cmbBoxExtraSkrap.SelectedIndex;
            String ExtraName = label11.Text;
            InstaControlLibrary.Manager.requestedWagonResultControl(InstaControlLibrary.WagonType.UB2X, chair1damm, chair1Fla, chair1Skr, chair2damm, chair2Fla, chair2Skr, chair3damm, chair3Fla, chair3Skr, extra1, extra2, extra3, ExtraName, m_wagonnumber, seat1nr, seat2nr, seat3nr, m_trainnr);
            this.Close();
        }
    }
}
