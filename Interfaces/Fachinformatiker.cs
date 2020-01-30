using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Fachinformatiker: Eigenschaften, Kaufmann , Vogel            //Vererbung kann nur von einer Klasse// Mehrfache Vererbung 

    {
        public void fliegen()
        {
            Console.WriteLine("fliegt");
        }

        public void programmieren()
        {
            Console.WriteLine("progrannieren");
        }

        public void verhandeln()
        {
            Console.WriteLine("verhandeln");
        }

        public void verkaufen()
        {
            Console.WriteLine("verkaufen");
        }
    }
}
