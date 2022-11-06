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
            Masina nume1 = new Masina("Toyota", "Avensis ", "Negru ", 2007, 160, 0);
            Masina nume2 = new Masina("Dacia", "Logan ", "Gri ", 2022, 100, 0);
            Masina nume3 = new Masina("Dacia", "S300 ", "Rosu", 2014, 300, 0);
            Masina nume4 = new Masina("Honda", "Civic", "Albastru ", 2000, 180, 0);

            //adaugat masini in lista
            this.listaMasini.Add(nume1);
            this.listaMasini.Add(nume2);
            this.listaMasini.Add(nume3);
            this.listaMasini.Add(nume4);

        }

        //metoda de afisare a masinilor din lista
        public void afisare()
        {
            for (int i = 0; i < listaMasini.Count; i++)
            {
                Console.WriteLine(listaMasini[i].descriere());
            }
        }
        //functie ce priemste ca parametru  o marca si returneaza o lista cu toate masinile cu marca respectiva

        public List<Masina> findByMarcaAuto(string marca)   //metoda de tip lista masina
        {
            List<Masina> listaMasiniMarca = new List<Masina>();  //
            for (int i = 0; i < listaMasini.Count; i++)
            {
                if (listaMasini[i].getmarcaAuto().Equals(marca))
                {
                    listaMasini.Add(listaMasini[i]);
                }

            }
            return listaMasiniMarca;
        }

        public Masina afisazaMasinaMaxCaiPutere()
        {
            Masina maxim = listaMasini[0];
            for (int i = 0; i < listaMasini.Count; i++)
            {
                if (listaMasini[i].getcaiPutere() > maxim.getcaiPutere())
                {
                    maxim = listaMasini[i];
                }
            }
            return maxim;
        }

        //metoda care afisaza 
        public Masina afisazaMasinaMinCaiPutere()
        {
            Masina minim = listaMasini[0];
            for (int i = 0; i < listaMasini.Count; i++)
            {
                if (listaMasini[i].getcaiPutere() < minim.getcaiPutere())
                {
                    minim = listaMasini[i];
                }
            }
            return minim;
        }

        public void addMasina(string a, string b, string c, int d, int e, int f)
        {
            Masina nume5 = new Masina(a, b, c, d, e, f);
            this.listaMasini.Add(nume5);

        }

        //functie care sterge din lista o masina dupa marca
        public void stergeMasinaDupaMarca(string marcaAuto)
        {
            int x = aflaPozitieMarca(marcaAuto);

            if (x != -1)
            {
                this.listaMasini.RemoveAt(aflaPozitieMarca(marcaAuto));

                Console.WriteLine("Masina s-a sters");

            }
            else
            {
                Console.WriteLine("Masina nu exista");
            }

        }


        //functie care returneaza pozitia pe care este o marca auto in lista.
        public int aflaPozitieMarca(string marcaAuto)
        {
            int pozitie = -1;
            for (int j = 0; j < listaMasini.Count; j++)
            {
                if (listaMasini[j].getmarcaAuto().Equals(marcaAuto))
                {
                    pozitie = j;
                }
            }
            return pozitie;
        }

        public void likeMarcaAuto(string marcaAutoLike)
        {
            int poz = aflaPozitieMarca(marcaAutoLike);
            listaMasini[poz].setlike(listaMasini[poz].getlike() + 1);
        }

        public int numaraLikeMarca(string marca) //functie care numara likeuriile in functie de marca
        {
           int poz = aflaPozitieMarca(marca);
           return listaMasini[poz].getlike();
        }

        public Masina masinaMaxLike()  //functie care afisaza masina in functie de likeuri
        {
            Masina maxiLike = listaMasini[0];
            for(int i = 0; i < listaMasini.Count; i++)
            {
                if(listaMasini[i].getlike() >maxiLike.getlike())
                {
                    maxiLike = listaMasini[i];
                }
            }
            return maxiLike;
        }

        public Masina masinaMinLike()
        {
            Masina minLike = listaMasini[0];
            for(int i = 0; i < listaMasini.Count; i++)
            {
                if(listaMasini[i].getlike() <minLike.getlike())
                {
                    minLike = listaMasini[i];
                }
            }
            return minLike;
        }

    }
}
