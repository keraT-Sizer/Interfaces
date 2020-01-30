using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Fachinformatiker fiae = new Fachinformatiker();// Neues Objekt von Typ Fachinformatiker erzeugen
            Eigenschaften e = new Eigenschaften();
            fiae.fliegen();
            fiae.programmieren();

            // Vogel v = new Vogel();   // Das geht nicht denn Vogel ist keine Klasse sonst ist eine Interface
            Vogel v = new Fachinformatiker();
            Kaufmann kfm = new Fachinformatiker();
            
            //Vogel Mein = new Vogel();
            Vogel[] vogelArray = new Vogel[2]; // Neues Array von Typ Vogel erzeugt, und mit verschiedene Datentypen
            vogelArray[0] = v;
            vogelArray[1] = new Tier();

            for (int i = 0; i < vogelArray.Length; i++)
            {
                vogelArray[i].fliegen();
            }
            Console.ReadLine();
        }
    }
}
