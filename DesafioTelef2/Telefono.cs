using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTelef2
{
    internal class Telefono
    {
        string modelo;
        string marca;
        string numTele;
        int codOpe;

        public string Modelo { get { return modelo; } }
        public string Marca { get { return marca; } }
        public string NumTele { get { return numTele; } set { numTele = value; } }
        public int CodOpe 
        { 
            get { return codOpe; } 
            set 
            {
                if (value > 0 || value < 3)
                { codOpe = value; }
                else { codOpe = 0; }
            } 
        }

        public Telefono(string Modelo, string Marca)
        {
            this.modelo = Modelo;
            this.marca = Marca;
        }
        public string llamar()
        {
            return " Realizando llamada.. ";
        }
        public string llamar(string contacto)
        {
            return " Llamando a " + contacto;
        }
        
        
    }
}
