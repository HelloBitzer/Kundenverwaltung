using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SchnellerKaputtWPF
{
    class LadenSpeichern
    {

        public void KundenSpeichern(List<kunde> Kundenliste)
        {
            //Serializer und Filestream erstellen

            XmlSerializer xmlser = new XmlSerializer(typeof(List<kunde>));
            FileStream fs = new FileStream("Kundendaten.xml", FileMode.Create);

            xmlser.Serialize(fs, Kundenliste);
            fs.Close();


        }

        public List<kunde> KundenLaden()
        {
            try
            {

                if (File.Exists("Kundendaten.xml"))
                {

                    XmlSerializer xmlser = new XmlSerializer(typeof(List<kunde>));
                    FileStream fs = new FileStream("Kundendaten.xml", FileMode.Open);

                    List<kunde> geladeneListe = (List<kunde>)xmlser.Deserialize(fs);
                    fs.Close();

                    return geladeneListe;
                }

            }
            catch (Exception)
            {
                Trace.WriteLine("SDFSDF");
              
            }

            return new List<kunde>();

        }


    }
}
