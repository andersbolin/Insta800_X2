using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Created by Anders Bolin AB2633 datum: 2013-06-02 email: anders@bolin.nu 
/// Eget Project i Programmering i .NET: Fortsättningskurs
/// </summary>

namespace InstaControlLibrary
{
    public class TestResultArgs : EventArgs
    {
        //Declaring variables
        InstaControlLibrary.Color m_col;
        int m_wagonnumber;
        int m_testresultat;


        public TestResultArgs(InstaControlLibrary.Color c, int wagonnumber, int resultat)
        {
            this.m_wagonnumber = wagonnumber;
            this.m_col = c;
            this.m_testresultat = resultat;
        }

        public int getWagonumber
        {
            get { return m_wagonnumber; }
            set { m_wagonnumber = value; }
        }
        public InstaControlLibrary.Color getColor
        {
            get { return m_col; }
            set { m_col = value; }
        }

        public int getTestResult
        {
            get { return m_testresultat; }
            set { m_testresultat = value; }
        }

    }
}
