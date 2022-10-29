using parc_auto_manager.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parc_auto_manager.controllers
{
    internal class ControlMasina
    {

        //creare lista masini
        private List<Masina> listaMasini;  
        
        
        //constructorul clasei ControlMasina
        public ControlMasina() 
        {
            this.listaMasini = new List<Masina>();
            this.load();

        }
        
        public void load()
        {
            //declarat masiini
            Masina nume1 = new Masina("Toyota ","Avensis ","Negru ",2007,160);    
            Masina nume2 = new Masina("Dacia ","Logan ","Gri ",2022,100);
            Masina nume3 = new Masina("Mercedes ","S300 ","Rosu",2014,300);
            Masina nume4 = new Masina("Honda", "Civic", "Albastru ", 2000, 180);

            //adaugat masini in lista
            this.listaMasini.Add(nume1);  
            this.listaMasini.Add(nume2);
            this.listaMasini.Add(nume3);
            this.listaMasini.Add(nume4);

        }

        //metoda de afisare a masinilor din lista
        public void afisare()
        {
           for(int i = 0; i < listaMasini.Count; i++)
            {
                Console.WriteLine(listaMasini[i].descriere());
            }
        }

    }
}
