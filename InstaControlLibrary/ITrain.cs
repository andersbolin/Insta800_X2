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
    public interface ITrain
    {
        //Contract for WagonNumber
        int wagNum { get; set; }

        //Contract for WagonType
        WagonType wagTyp { get; set; }

        //Contract for method
        string getWagonSpecificResults();

    }
}
