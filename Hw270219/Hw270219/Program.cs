using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hw270219
{
    class Program
    {
        static void Main(string[] args)
        {
            Camp tzehelim1 = new Camp(800, 400, 1500, 100, 20);

            Camp zikim1 = new Camp(100, -2, 900, 1200, 2000);



            Camp joined = tzehelim1 + zikim1;

            Console.WriteLine($"joines = {joined}");

            Console.WriteLine($"tzehelim > zikim {tzehelim1 > zikim1}");

            Console.WriteLine($"tzehelim < zikim {tzehelim1 < zikim1}");

            Console.WriteLine(tzehelim1 == zikim1);



            if (tzehelim1 > zikim1)

                Console.WriteLine("Tzehelim is bigger");



            Console.WriteLine("===========================================");

            Console.WriteLine("Etgdar");



            Campser tzehelim = new Campser(800, 400, 1500, 100, 20);

            Campser zikim = new Campser(100, -2, 900, 1200, 2000);



            XmlSerializer  myXmlSerializer = new XmlSerializer(typeof(Campser));



            using (Stream file = new FileStream(@"c:\temp\xml", FileMode.Create)) // creating new file stream

            {

                myXmlSerializer.Serialize(file, tzehelim);



            } //closing file stream



            Campser readCampOne = null;

            Campser readCampTwo = null;

            using (Stream file = new FileStream(@"c:\temp\xml", FileMode.Open)) // creating new file stream

            {

                readCampOne = myXmlSerializer.Deserialize(file) as Campser;



            } //closing file stream

            using (Stream file = new FileStream(@"c:\temp\xml", FileMode.Open)) // creating new file stream

            {

                readCampTwo = myXmlSerializer.Deserialize(file) as Campser;

            }



            Console.WriteLine(readCampOne.GetHashCode() == readCampTwo.GetHashCode());




        }
    }
}
