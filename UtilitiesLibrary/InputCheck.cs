using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Created by Anders Bolin AB2633 datum: 2013-06-02 email: anders@bolin.nu 
/// Eget Project i Programmering i .NET: Fortsättningskurs
/// </summary>

namespace UtilitiesLibrary
{
    public class InputCheck
    {
        

        public static bool CheckTrainNumber(String name)
        {
            bool res;
            int numb;
            return res = int.TryParse(name, out numb);            
        }
        
        public static bool CheckStation(Object o)
        {
            if (o == null)
            {
                return false;
            }
            return true;
        }
       
        public static bool checkPerson(String name)
        {
            bool test = true;
            String newname = name.Trim();
            if (string.IsNullOrWhiteSpace(newname))
            {
                test = false;
            }
            return test;
        }
        
        public static bool checkVagnsnummer(int o)
        {
            if (o == -1)
            {
                return false;
            }
            return true;
        }
        
        public static bool checkVagnTyp(int o)
        {
            if (o == -1)
            {
                return false;
            }
            return true;
        }
    }
}
