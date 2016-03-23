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

namespace InstaControlLibrary.Vagnar
{
    [Serializable]
    public class UA2 : X2000
    {
        //Declaring variables
        public int m_place1dust, m_place2dust, m_place3dust, m_placeToiletdust;
        public int m_place1spots, m_place2spots, m_place3spots, m_placeToiletspots;
        public int m_place1garbage, m_place2garbage, m_place3garbage, m_placeToiletgarbage;
        public string m_placeExtraName = "", trainnumber;
        public bool test = false;

        //Public constructor
        public UA2()
        {
        }

        public string TrainNumber
        {
            get { return trainnumber; }
            set { trainnumber = value; }
        }

        //Position 1
        public int place1Dust
        {
            get { return m_place1dust; }
            set { m_place1dust = value; }
        }
        public int place1Spots
        {
            get { return m_place1spots; }
            set { m_place1spots = value; }
        }
        public int place1Garbage
        {
            get { return m_place1garbage; }
            set { m_place1garbage = value; }
        }

        //Position 2
        public int place2Dust
        {
            get { return m_place2dust; }
            set { m_place2dust = value; }
        }
        public int place2Spots
        {
            get { return m_place2spots; }
            set { m_place2spots = value; }
        }
        public int place2Garbage
        {
            get { return m_place2garbage; }
            set { m_place2garbage = value; }
        }

        //Position 3
        public int place3Dust
        {
            get { return m_place3dust; }
            set { m_place3dust = value; }
        }
        public int place3Spots
        {
            get { return m_place3spots; }
            set { m_place3spots = value; }
        }
        public int place3Garbage
        {
            get { return m_place3garbage; }
            set { m_place3garbage = value; }
        }

        //Position Extra
        public int placeExtraDust
        {
            get { return m_placeToiletdust; }
            set { m_placeToiletdust = value; }
        }
        public int placeExtraSpots
        {
            get { return m_placeToiletspots; }
            set { m_placeToiletspots = value; }
        }
        public int placeExtraGarbage
        {
            get { return m_placeToiletgarbage; }
            set { m_placeToiletgarbage = value; }
        }
        public String placeExtraName
        {
            get { return m_placeExtraName; }
            set { m_placeExtraName = value; }
        }

        public override String getWagonSpecificResults()
        {
            int tally = place1Dust + place1Garbage + place1Spots + place2Dust + place2Garbage + place2Spots + 
                place3Dust + m_place3garbage + place3Spots + placeExtraDust + placeExtraGarbage + placeExtraSpots;
            Console.WriteLine("UA2 tally= " + tally);
            if(tally <= 12) { test = true; } 
            String result = (test ? " Godkänd" : " Ej Godkänd");
            string strout = string.Format("{0,-5}{1,9}{2,15}{3,23}\n", wagNum, TrainNumber, wagTyp.ToString(), result);
            return strout;
        }
        
    }
}
