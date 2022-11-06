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
        private int like;

        
        public string descriere()
        {
            string text = " ";
            text += marcaAuto + " ";
            text += modelAuto + " ";
            text += culoare + " ";
            text += anFabricatie + " ";
            text += caiPutere + " ";
            text += like + " \n";
            return text;
        }

        //constructorul clasei Masina cu 5 parametrii
        public Masina(string marcaAuto, string modelAuto, string culoare, int anFabricatie, int caiPutere, int like)
        {
            this.marcaAuto = marcaAuto;
            this.modelAuto = modelAuto;
            this.culoare = culoare;
            this.anFabricatie = anFabricatie;
            this.caiPutere = caiPutere;
            this.like = like;
        }

        //gettere
        public string getmarcaAuto() { return this.marcaAuto; }
        public string getmodelAuto() { return this.modelAuto; }
        public string getculoare() { return this.culoare; }
        public int getanFabricatie() { return this.anFabricatie; }
        public int getcaiPutere() { return this.caiPutere; }
        public int getlike() { return this.like; }

        //settere
        public void setmarcaAuto(string marcaAuto) { this.marcaAuto = marcaAuto; }
        public void setmodelAuto(string modelAuto) { this.modelAuto = modelAuto; }
        public void setculoare(string culoare) { this.culoare = culoare; }
        public void setanFabricatie(int anFabricatie) { this.anFabricatie = anFabricatie; }
        public void setcaiPutere(int caiPutere) { this.caiPutere = caiPutere; }
        public void setlike(int like) { this.like = like; }


        


    }
}
