using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

/// <summary>
/// Created by Anders Bolin AB2633 datum: 2013-06-02 email: anders@bolin.nu 
/// Eget Project i Programmering i .NET: Fortsättningskurs
/// </summary>

namespace InstaControlLibrary
{
    [Serializable]
    public class Manager
    {
        //Declaring events
        public static event EventHandler<InstaControlLibrary.TestResultArgs> TestResults;
        public static event EventHandler<EventArgs> ResetGUIt;
        public static event EventHandler<EventArgs> ControlFinished;

        //Declaring the list 
        public static List<Object> lst = new List<Object>();
        public static int tally = 0;
        public static int createdchecks = 0;

        //Public constructor
        public Manager()
        {
        }
        /// <summary>
        /// Creates the requested train wagon and saves that into the list
        /// </summary>
        /// <param name="catagory"></param>
        /// <param name="chair1dust"></param>
        /// <param name="chair1spots"></param>
        /// <param name="chair1garbage"></param>
        /// <param name="chair2dust"></param>
        /// <param name="chair2spots"></param>
        /// <param name="chair2garbage"></param>
        /// <param name="chair3dust"></param>
        /// <param name="chair3spots"></param>
        /// <param name="chair3garbage"></param>
        /// <param name="Extradust"></param>
        /// <param name="Extraspots"></param>
        /// <param name="Extragarbage"></param>
        /// <param name="ExtraName"></param>
        /// <param name="wagonnumber"></param>
        /// <param name="seat1nr"></param>
        /// <param name="seat2nr"></param>
        /// <param name="seat3nr"></param>
        public static void requestedWagonResultControl(InstaControlLibrary.WagonType catagory, int chair1dust, int chair1spots, int chair1garbage, int chair2dust, int chair2spots, int chair2garbage, int chair3dust, int chair3spots, int chair3garbage, int Extradust, int Extraspots, int Extragarbage, string ExtraName, int wagonnumber, int seat1nr, int seat2nr, int seat3nr, string trainnr)
        {
            switch (catagory)
            {
                case InstaControlLibrary.WagonType.UA2:
                    object ua2wagon = WagonFactory.CreateWagon(InstaControlLibrary.WagonType.UA2, chair1dust, chair1spots, chair1garbage, chair2dust, chair2spots, chair2garbage, chair3dust, chair3garbage, chair3spots, Extradust, Extragarbage, Extraspots, ExtraName, wagonnumber, seat1nr, seat2nr, seat3nr, trainnr);
                    addToList(ua2wagon);
                    break;
                case InstaControlLibrary.WagonType.UB2:
                    object ub2wagon = WagonFactory.CreateWagon(InstaControlLibrary.WagonType.UB2, chair1dust, chair1spots, chair1garbage, chair2dust, chair2spots, chair2garbage, chair3dust, chair3garbage, chair3spots, Extradust, Extragarbage, Extraspots, ExtraName, wagonnumber, seat1nr, seat2nr, seat3nr, trainnr);
                    addToList(ub2wagon);
                    break;
                case InstaControlLibrary.WagonType.UB2X:
                    object ubx2wagon = WagonFactory.CreateWagon(InstaControlLibrary.WagonType.UB2X, chair1dust, chair1spots, chair1garbage, chair2dust, chair2spots, chair2garbage, chair3dust, chair3garbage, chair3spots, Extradust, Extragarbage, Extraspots, ExtraName, wagonnumber, seat1nr, seat2nr, seat3nr, trainnr);
                    addToList(ubx2wagon);
                    break;
                case InstaControlLibrary.WagonType.URB2:
                    object urb2wagon = WagonFactory.CreateWagon(InstaControlLibrary.WagonType.URB2, chair1dust, chair1spots, chair1garbage, chair2dust, chair2spots, chair2garbage, chair3dust, chair3garbage, chair3spots, Extradust, Extragarbage, Extraspots, ExtraName, wagonnumber, seat1nr, seat2nr, seat3nr, trainnr);
                    addToList(urb2wagon);
                    break;

            }
            createdchecks++;
            tally = chair1dust + chair1spots + chair1garbage + chair2dust + chair2spots + chair2garbage + chair3dust + chair3spots + chair3garbage + Extradust + Extraspots + Extragarbage;
            InstaControlLibrary.Color c = InstaControlLibrary.Color.Red;
            if (tally <= 12)
            {
                c = InstaControlLibrary.Color.Green;
            }
            InstaControlLibrary.TestResultArgs arg = new InstaControlLibrary.TestResultArgs(c, wagonnumber, tally);
            OnTestResult(arg);
            tally = 0;
            if (createdchecks == 5)
            {
                EventArgs ev = new EventArgs();
                onControlFinished(ev);
            }
        }
        /// <summary>
        /// Resets the GUI with event/delegate
        /// </summary>
        public static void resetGUI()
        {
            EventArgs arg = new EventArgs();
            OnResetGUIt(arg);
        }
        /// <summary>
        /// Adds wagon to the list
        /// </summary>
        /// <param name="wagon"></param>
        public static void addToList(Object wagon)
        {
            lst.Add(wagon);
        }
        /// <summary>
        /// Returns the number of items in the list
        /// </summary>
        /// <returns></returns>
        public static int getPostsInList()
        {
            return lst.Count;
        }
        /// <summary>
        /// Returns the item at index from the list
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static Object GetMainList(int index)
        {
            return lst[index];
        }
        /// <summary>
        /// Sends the event to the delegate
        /// </summary>
        /// <param name="e"></param>
        public static void OnTestResult(InstaControlLibrary.TestResultArgs e)
        {
            if (TestResults != null)
            {
                TestResults(null, e);
            }
        }
        /// <summary>
        /// Sends the event to the delegate
        /// </summary>
        /// <param name="e"></param>
        public static void OnResetGUIt(EventArgs e)
        {
            if (ResetGUIt != null)
            {
                ResetGUIt(null, e);
            }
        }
        /// <summary>
        /// Sends the event to the delegate
        /// </summary>
        /// <param name="e"></param>
        public static void onControlFinished(EventArgs e)
        {
            if (ControlFinished != null)
            {
                ControlFinished(null, e);
            }
        }
        /// <summary>
        /// Creates a copy of the list
        /// </summary>
        public static void createcopiedlist()
        {
            foreach (Object element in lst)
            {
                UtilitiesLibrary.Serialize.createListCopy(element);
            }
        }
        /// <summary>
        /// Clears the list
        /// </summary>
        public static void lstClear()
        {
            lst.Clear();
        }
        /// <summary>
        /// Creates a serilized file that is saved on HDD
        /// </summary>
        /// <param name="strFileName"></param>
        public static void createserializefile(string strFileName)
        {
            UtilitiesLibrary.Serialize.clearlist();
            createcopiedlist();
            UtilitiesLibrary.Serialize.serializeFile(strFileName);
        }
        /// <summary>
        /// Method calls for deserialize .dat file in XMLSerialize
        /// </summary>
        /// <param name="strFileName"></param>
        public static void loadseriallist(string strFileName)
        {
            List<Object> newlst = UtilitiesLibrary.Serialize.deSerializeObject1(strFileName);
            lst = newlst;
        }
        /// <summary>
        /// This method creates objects of the train array and sends them to be stored in the Database
        /// </summary>
        public static void creatTrainListDB()
        {
            foreach (Object element in lst)
            {
                if (element is Vagnar.UA2)
                {
                    Vagnar.UA2 obj = (Vagnar.UA2)element;
                    String TYP = "UA2";
                    int CHAIR1DUST = obj.place1Dust;
                    int CHAIR1SPOTS = obj.place1Spots;
                    int CHAIR1GARBAGE = obj.place1Garbage;
                    int CHAIR2DUST = obj.place2Dust;
                    int CHAIR2SPOTS = obj.place2Spots;
                    int CHAIR2GARBAGE = obj.place2Garbage;
                    int CHAIR3DUST = obj.place3Dust;
                    int CHAIR3SPOTS = obj.place3Spots;
                    int CHAIR3GARBAGE = obj.place3Garbage;
                    int EXTRADUST = obj.placeExtraDust;
                    int EXTRASPOTS = obj.placeExtraSpots;
                    int EXTRAGARBAGE = obj.placeExtraGarbage;
                    String EXTRANAME = obj.placeExtraName;
                    int WAGONNUMBER = obj.wagNum;
                    int CHAIR1 = obj.Position1;
                    int CHAIR2 = obj.Position2;
                    int CHAIR3 = obj.Position3;
                    String ID = obj.TrainNumber;

                    DAL.DataAccess.createrow(TYP, CHAIR1DUST, CHAIR1SPOTS, CHAIR1GARBAGE, CHAIR2DUST, CHAIR2SPOTS, CHAIR2GARBAGE, CHAIR3DUST, CHAIR3SPOTS, CHAIR3GARBAGE, EXTRADUST, EXTRASPOTS, EXTRAGARBAGE, EXTRANAME, WAGONNUMBER, CHAIR1, CHAIR2, CHAIR3, ID);

                }
                else if (element is Vagnar.UB2)
                {
                    Vagnar.UB2 obj = (Vagnar.UB2)element;
                    String TYP = "UB2";
                    int CHAIR1DUST = obj.place1Dust;
                    int CHAIR1SPOTS = obj.place1Spots;
                    int CHAIR1GARBAGE = obj.place1Garbage;
                    int CHAIR2DUST = obj.place2Dust;
                    int CHAIR2SPOTS = obj.place2Spots;
                    int CHAIR2GARBAGE = obj.place2Garbage;
                    int CHAIR3DUST = obj.place3Dust;
                    int CHAIR3SPOTS = obj.place3Spots;
                    int CHAIR3GARBAGE = obj.place3Garbage;
                    int EXTRADUST = obj.placeExtraDust;
                    int EXTRASPOTS = obj.placeExtraSpots;
                    int EXTRAGARBAGE = obj.placeExtraGarbage;
                    String EXTRANAME = obj.placeExtraName;
                    int WAGONNUMBER = obj.wagNum;
                    int CHAIR1 = obj.Position1;
                    int CHAIR2 = obj.Position2;
                    int CHAIR3 = obj.Position3;
                    String ID = obj.TrainNumber;

                    DAL.DataAccess.createrow(TYP, CHAIR1DUST, CHAIR1SPOTS, CHAIR1GARBAGE, CHAIR2DUST, CHAIR2SPOTS, CHAIR2GARBAGE, CHAIR3DUST, CHAIR3SPOTS, CHAIR3GARBAGE, EXTRADUST, EXTRASPOTS, EXTRAGARBAGE, EXTRANAME, WAGONNUMBER, CHAIR1, CHAIR2, CHAIR3, ID);

                }
                else if (element is Vagnar.UB2X)
                {
                    Vagnar.UB2X obj = (Vagnar.UB2X)element;
                    String TYP = "UB2X";
                    int CHAIR1DUST = obj.place1Dust;
                    int CHAIR1SPOTS = obj.place1Spots;
                    int CHAIR1GARBAGE = obj.place1Garbage;
                    int CHAIR2DUST = obj.place2Dust;
                    int CHAIR2SPOTS = obj.place2Spots;
                    int CHAIR2GARBAGE = obj.place2Garbage;
                    int CHAIR3DUST = obj.place3Dust;
                    int CHAIR3SPOTS = obj.place3Spots;
                    int CHAIR3GARBAGE = obj.place3Garbage;
                    int EXTRADUST = obj.placeExtraDust;
                    int EXTRASPOTS = obj.placeExtraSpots;
                    int EXTRAGARBAGE = obj.placeExtraGarbage;
                    String EXTRANAME = obj.placeExtraName;
                    int WAGONNUMBER = obj.wagNum;
                    int CHAIR1 = obj.Position1;
                    int CHAIR2 = obj.Position2;
                    int CHAIR3 = obj.Position3;
                    String ID = obj.TrainNumber;

                    DAL.DataAccess.createrow(TYP, CHAIR1DUST, CHAIR1SPOTS, CHAIR1GARBAGE, CHAIR2DUST, CHAIR2SPOTS, CHAIR2GARBAGE, CHAIR3DUST, CHAIR3SPOTS, CHAIR3GARBAGE, EXTRADUST, EXTRASPOTS, EXTRAGARBAGE, EXTRANAME, WAGONNUMBER, CHAIR1, CHAIR2, CHAIR3, ID);

                }
                else if (element is Vagnar.URB2)
                {
                    Vagnar.URB2 obj = (Vagnar.URB2)element;
                    String TYP = "URB2";
                    int CHAIR1DUST = obj.place1Dust;
                    int CHAIR1SPOTS = obj.place1Spots;
                    int CHAIR1GARBAGE = obj.place1Garbage;
                    int CHAIR2DUST = obj.place2Dust;
                    int CHAIR2SPOTS = obj.place2Spots;
                    int CHAIR2GARBAGE = obj.place2Garbage;
                    int CHAIR3DUST = obj.place3Dust;
                    int CHAIR3SPOTS = obj.place3Spots;
                    int CHAIR3GARBAGE = obj.place3Garbage;
                    int EXTRADUST = obj.placeExtraDust;
                    int EXTRASPOTS = obj.placeExtraSpots;
                    int EXTRAGARBAGE = obj.placeExtraGarbage;
                    String EXTRANAME = obj.placeExtraName;
                    int WAGONNUMBER = obj.wagNum;
                    int CHAIR1 = obj.Position1;
                    int CHAIR2 = obj.Position2;
                    int CHAIR3 = obj.Position3;
                    String ID = obj.TrainNumber;

                    DAL.DataAccess.createrow(TYP, CHAIR1DUST, CHAIR1SPOTS, CHAIR1GARBAGE, CHAIR2DUST, CHAIR2SPOTS, CHAIR2GARBAGE, CHAIR3DUST, CHAIR3SPOTS, CHAIR3GARBAGE, EXTRADUST, EXTRASPOTS, EXTRAGARBAGE, EXTRANAME, WAGONNUMBER, CHAIR1, CHAIR2, CHAIR3, ID);

                }

            }
        }
        /// <summary>
        /// Method reads the TrainDB and sends the train objects to the requestedWagonResultControl where they
        /// are created as individual wagons again and stored in the array.
        /// </summary>
        public static void readTrainDB()
        {
            int x = DAL.DataAccess.TrainDBCount();
            string typ;
            int chair1dust, chair1spots, chair1garbage;
            int chair2dust, chair2spots, chair2garbage;
            int chair3dust, chair3spots, chair3garbage;
            int extradust, extraspots, extragarbage;
            string extraname;
            int wagonnumber;
            int chair1, chair2, chair3;
            string trainnumber;
            for (int y = 1; y <= x; y++)
            {
                DAL.DataAccess.loadTrainData(y, out typ, out chair1dust, out chair1spots, out chair1garbage, out chair2dust, out chair2spots, out chair2garbage, out chair3dust, out chair3spots, out chair3garbage, out extradust, out extraspots, out extragarbage, out extraname, out wagonnumber, out chair1, out chair2, out chair3, out trainnumber);
                WagonType wagon = (WagonType)Enum.Parse(typeof(WagonType), typ, true);
                requestedWagonResultControl(wagon, chair1dust, chair1spots, chair1garbage, chair2dust, chair2spots, chair2garbage, chair3dust, chair3spots, chair3garbage, extradust, extraspots, extragarbage, extraname, wagonnumber, chair1, chair2, chair3, trainnumber);
            }
        }
    }
}
