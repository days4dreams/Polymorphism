using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Vertebrate v = new Vertebrate();
            v.backbone = "AAA";
            //we declare a variable 

            Vertebrate v2 = new Vertebrate();
            //v2 = ChangeBackbone(v);

            Mammal m = new Mammal();
            m.warmBlooded = true;

            v2 = ChangeBackbone(m);

            Mammal m = new Mammal();
            if (m is Mammal)
            { }
            //test whether an object is a particular type requires use of the “is” keyword like this

            Mammal m2 = (Mammal)v2;
            //here we cast the mammal to a vertebrate - see alternative below using "as"

            Vertebrate v = new Vertebrate();
            Mammal m = v as Mammal;
            //To convert between types which are related from each other you can use the “as” keyword which is nicer than the bracket notation

            Bird b = new Bird();
            b.backbone = "BBB";
            b.wingSpan = 5;

            v2 = ChangeBackbone(b);

            Console.WriteLine(b.backbone);
            Console.WriteLine(b.wingSpan);
            Console.ReadLine();
        }

        static Vertebrate ChangeBackbone (Vertebrate ver)
        {
            ver.backbone = "ABC";
            return ver;
        }


    }
}
