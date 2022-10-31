using parc_auto_manager.controllers;
using parc_auto_manager.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parc_auto_manager.view
{
    internal class View
    {

        private ControlMasina control;  //referinta obiect de tip masina
      
        public View()
        {
            control = new ControlMasina();  //creare obiect "contro" de tip masina

            play();
        }



        public void meniu()
        {

            Console.WriteLine("Apasati tasta 1 pentru a afisa toate masinile  din parc ");
            Console.WriteLine("Apasati tasta 2 pentru a vedea cea mai puternica masina ");
            Console.WriteLine("Apasati tasta 3 pentru a vedea masina cu cei mai putini cap putere ");
            Console.WriteLine("Apasati tasta 4 pentru a introduceti o masina noua ");
        }

        public void play()
        {
            bool running = true;
            while (running == true)
            {
                meniu();
                int alegere = Int32.Parse(Console.ReadLine());
                switch (alegere)
                {
                    case 1: control.afisare();
                            break;
                    case 2: afisazaMaximCaiPueter();
                            break;
                    case 3: afisazaMinimCaiPueter();
                            break;
                    case 4: adaugaMasinaNoua();
                            break;  

                    default:
                            Console.WriteLine("gresit");
                    break;
                }
            }
        }

        //metoda care afisaza capPuere maxim
        public void afisazaMaximCaiPueter()
        {
            Masina maxCP = control.afisazaMasinaMaxCaiPutere();
            Console.WriteLine(maxCP.descriere());
        }

        //metoda care afisaza capPuere minim
        public void afisazaMinimCaiPueter()
        {
            Masina minCM = control.afisazaMasinaMinCaiPutere();
            Console.WriteLine(minCM.descriere());
        }
        //metoda care adauga o masina noua
        public void adaugaMasinaNoua()
        {
            Console.WriteLine("Introduceti  marca masinii: ");
            string marca = Console.ReadLine();
            Console.WriteLine("introduceti model masina: ");
            string model = Console.ReadLine();
            Console.WriteLine("Introduceti culoare masina: ");
            string culoare = Console.ReadLine();
            Console.WriteLine("Introduceti an fabricatie masina: ");
            int anFabricatie = Int32.Parse(Console.ReadLine());  //conversie string la int -  Parse in orice limbaj convertes string la int
            Console.WriteLine("Introduceti cai putere masina: ");
            int caiPutere = Int32.Parse(Console.ReadLine());
             control.addMasina(marca,model,culoare,anFabricatie,caiPutere);

        }


    }
}
