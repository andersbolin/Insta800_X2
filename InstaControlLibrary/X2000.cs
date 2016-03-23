using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

/// <summary>
/// Created by Anders Bolin AB2633 datum: 2013-06-02 email: anders@bolin.nu 
/// Eget Project i Programmering i .NET: Fortsättningskurs
/// </summary>

namespace InstaControlLibrary
{
    [Serializable]
    public abstract class X2000 : ITrain
    {
        //Declaring variables
        public int m_wagNum;
        public WagonType m_wagTyp;
        public int m_pos1, m_pos2, m_pos3;
        public bool toilet1, toilet2;
        

        //Public Constructor
        public X2000()
        {
        }

        
        /// <summary>
        /// Get&Set for wagon number
        /// </summary>
        public int wagNum 
        {
            get { return m_wagNum; }
            set { m_wagNum = value; } 
        }

        /// <summary>
        /// Get&Set for wagon type
        /// </summary>
        public WagonType wagTyp 
        {
            get { return m_wagTyp; }
            set { m_wagTyp = value; } 
        }

        /// <summary>
        /// Setters & Getters of positions in the wagon where the tests will be conducted.
        /// </summary>
        public int Position1
        {
            get { return m_pos1; }
            set { m_pos1 = value; }
        }
        public int Position2
        {
            get { return m_pos2; }
            set { m_pos2 = value; }
        }
        public int Position3
        {
            get { return m_pos3; }
            set { m_pos3 = value; }
        }

        public abstract string getWagonSpecificResults();
    }
}
