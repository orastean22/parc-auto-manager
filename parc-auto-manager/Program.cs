using parc_auto_manager.controllers;
using parc_auto_manager.models;
using parc_auto_manager.view;
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
            View view = new View();  

           //k ControlMasina a= new ControlMasina();//referinta obiect de tip ControlMasina
           //Masina m = a.afisazaMasinaMaxCaiPutere();
           //Console.WriteLine("cea mai puternica masina este: " + m.descriere());
            Console.ReadKey();   //asteapta sa primeasca o tasta

        }
    }
}
    
