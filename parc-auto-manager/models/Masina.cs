using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parc_auto_manager.models
{
    internal class Masina
    {
        private string marcaAuto;
        private string modelAuto;
        private string culoare;
        private int anFabricatie;
        private int caiPutere;
        
        public string descriere()
        {
            string text = " ";
            text += marcaAuto + " ";
            text += modelAuto + " ";
            text += culoare + " ";
            text += anFabricatie + " ";
            text += caiPutere + " \n";
            return text;
        }

        //constructorul clasei Masina cu 5 parametrii
        public Masina(string marcaAuto, string modelAuto, string culoare, int anFabricatie, int caiPutere)
        {
            this.marcaAuto = marcaAuto;
            this.modelAuto = modelAuto;
            this.culoare = culoare;
            this.anFabricatie = anFabricatie;
            this.caiPutere = caiPutere;
        }

        //gettere
        public string getmarcaAuto() { return this.marcaAuto; }
        public string getmodelAuto() { return this.modelAuto; }
        public string getculoare() { return this.culoare; }
        public int getanFabricatie() { return this.anFabricatie; }
        public int getcaiPutere() { return this.caiPutere; }

        //settere
        public void setmarcaAuto(string marcaAuto) { this.marcaAuto = marcaAuto; }
        public void setmodelAuto(string modelAuto) { this.modelAuto = modelAuto; }
        public void setculoare(string culoare) { this.culoare = culoare; }
        public void setanFabricatie(int anFabricatie) { this.anFabricatie = anFabricatie; }
        public void setcaiPutere(int caiPutere) { this.caiPutere = caiPutere; }

        


    }
}
