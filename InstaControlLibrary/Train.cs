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
    public class Train
    {
        //Declaring Variables
        private int m_wagon;
        private InstaControlLibrary.Color m_color;

        public Train(int wagon, InstaControlLibrary.Color c)
        {
            m_wagon = wagon;
            m_color = c;
        }

        public int getNumber()
        {
            return m_wagon;
        }

        public InstaControlLibrary.Color getColor()
        {
            return m_color;
        }
    }
}
