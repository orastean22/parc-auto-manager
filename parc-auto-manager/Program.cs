using parc_auto_manager.controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parc_auto_manager
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ControlMasina control = new ControlMasina();
            control.afisare();


            Console.ReadKey();
        }
    }
}
    