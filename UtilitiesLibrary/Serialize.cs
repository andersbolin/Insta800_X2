using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

/// <summary>
/// Created by Anders Bolin AB2633 datum: 2013-06-02 email: anders@bolin.nu 
/// Eget Project i Programmering i .NET: Fortsättningskurs
/// </summary>

namespace UtilitiesLibrary
{
    public class Serialize
    {
        private static List<Object> lstCopy = new List<Object>();


        /// <summary>
        /// Clears the list so its empty for new copy
        /// </summary>
        public static void clearlist()
        {
            lstCopy.Clear();
        }

        public static void createListCopy(Object obj)
        {
            lstCopy.Add(obj);
        }

        /// <summary>
        /// This method serializes the animal list into binary stream.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="objectToSerialize"></param>
        public static void serializeFile(String filename)
        {
            Stream stream = File.Open(filename, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            try
            {
                bFormatter.Serialize(stream, lstCopy);
            }
            catch
            {
                throw;
            }
            finally
            {
                stream.Close();
            }
        }

        /// <summary>
        /// This methid Deserialize binary serialized animal file list
        /// </summary>
        /// <param name="filename">The url to the file being deserialized</param>
        public static List<Object> deSerializeObject(string filename)
        {
            List<Object> objectToSerialize;
            Stream stream = File.Open(filename, FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            try
            {
                objectToSerialize = (List<Object>)bFormatter.Deserialize(stream);
            }
            catch
            {
                throw;
            }
            finally
            {
                stream.Close();
            }
            return objectToSerialize;
        }
        /// <summary>
        /// This method Deserialize binary serialized train file list
        /// </summary>
        /// <param name="filename">The url to the file being deserialized</param>
        public static List<Object> deSerializeObject1(string filename)
        {
            List<Object> objectToSerialize;
            Stream stream = File.Open(filename, FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            try
            {
                objectToSerialize = (List<Object>)bFormatter.Deserialize(stream);
            }
            catch
            {
                throw;
            }
            finally
            {
                stream.Close();
            }
            return objectToSerialize;
        }
    }
}
