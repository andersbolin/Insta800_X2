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
    public class WagonFactory
    {
        
        public WagonFactory()
        {
        }

        public static object CreateWagon(WagonType wtype, int chair1dust, int chair1spots, int chair1garbage, int chair2dust, int chair2garbage, int chair2spots, int chair3dust, int chair3garbage, int chair3spots, int Extradust, int Extragarbage, int Extraspots, String ExtraName, int wagonnumber, int seat1nr, int seat2nr, int seat3nr, string m_trainnr)
        {
            dynamic obj = null;     

            //type determined by late binding
            switch (wtype)
            {
                case WagonType.UA2:
                    obj = new Vagnar.UA2();
                    obj.place1Dust = chair1dust;
                    obj.place1Spots = chair1spots;
                    obj.place1Garbage = chair1garbage;
                    obj.place2Dust = chair2dust;
                    obj.place2Spots = chair2spots;
                    obj.place2Garbage = chair2garbage;
                    obj.place3Dust = chair3dust;
                    obj.place3Spots = chair3spots;
                    obj.place3Garbage = chair3garbage;
                    obj.placeExtraDust = Extradust;
                    obj.placeExtraSpots = Extraspots;
                    obj.placeExtraGarbage = Extragarbage;
                    obj.placeExtraName = ExtraName;
                    obj.wagNum = wagonnumber;
                    obj.TrainNumber = m_trainnr;
                    obj.wagTyp = wtype;
                    obj.Position1 = seat1nr; 
                    obj.Position2 = seat2nr;
                    obj.Position3 = seat3nr;
                    break;
                case WagonType.UB2:
                    obj = new Vagnar.UB2();                     
                    obj.place1Dust = chair1dust;
                    obj.place1Spots = chair1spots;
                    obj.place1Garbage = chair1garbage;
                    obj.place2Dust = chair2dust;
                    obj.place2Spots = chair2spots;
                    obj.place2Garbage = chair2garbage;
                    obj.place3Dust = chair3dust;
                    obj.place3Spots = chair3spots;
                    obj.place3Garbage = chair3garbage;
                    obj.placeExtraDust = Extradust;
                    obj.placeExtraSpots = Extraspots;
                    obj.placeExtraGarbage = Extragarbage;
                    obj.wagNum = wagonnumber;
                    obj.TrainNumber = m_trainnr;
                    obj.wagTyp = wtype;
                    obj.Position1 = seat1nr; 
                    obj.Position2 = seat2nr;
                    obj.Position3 = seat3nr;
                    break;

                case WagonType.UB2X:
                    obj = new Vagnar.UB2X();                   
                    obj.place1Dust = chair1dust;
                    obj.place1Spots = chair1spots;
                    obj.place1Garbage = chair1garbage;
                    obj.place2Dust = chair2dust;
                    obj.place2Spots = chair2spots;
                    obj.place2Garbage = chair2garbage;
                    obj.place3Dust = chair3dust;
                    obj.place3Spots = chair3spots;
                    obj.place3Garbage = chair3garbage;
                    obj.placeExtraDust = Extradust;
                    obj.placeExtraSpots = Extraspots;
                    obj.placeExtraGarbage = Extragarbage;
                    obj.wagNum = wagonnumber;
                    obj.TrainNumber = m_trainnr;
                    obj.wagTyp = wtype;
                    obj.Position1 = seat1nr; 
                    obj.Position2 = seat2nr;
                    obj.Position3 = seat3nr;
                    break;

                case WagonType.URB2:
                    obj = new Vagnar.URB2();                 
                    obj.place1Dust = chair1dust;
                    obj.place1Spots = chair1spots;
                    obj.place1Garbage = chair1garbage;
                    obj.place2Dust = chair2dust;
                    obj.place2Spots = chair2spots;
                    obj.place2Garbage = chair2garbage;
                    obj.place3Dust = chair3dust;
                    obj.place3Spots = chair3spots;
                    obj.place3Garbage = chair3garbage;
                    obj.placeExtraDust = Extradust;
                    obj.placeExtraSpots = Extraspots;
                    obj.placeExtraGarbage = Extragarbage;
                    obj.wagNum = wagonnumber;
                    obj.TrainNumber = m_trainnr;
                    obj.wagTyp = wtype;
                    obj.Position1 = seat1nr; 
                    obj.Position2 = seat2nr;
                    obj.Position3 = seat3nr;
                    break;
            }
            return obj;     //return the created wagon object.
        }



    }
}
