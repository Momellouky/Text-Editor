using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using swatchesPanelLib;

namespace ColorSwatchesConsoleHelp
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1.loadForm();
            Class1.CreateCloseBtn();

            Console.ReadKey(); 
        }
    }
}
