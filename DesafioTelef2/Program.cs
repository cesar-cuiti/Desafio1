using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTelef2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Ingrese modelo y marca: ");
            string Mod = Console.ReadLine();
            string Mar = Console.ReadLine();
            Telefono t1 = new Telefono(Mod, Mar);
            Console.WriteLine(" Ingrese el numero de tel: ");
            t1.NumTele = Console.ReadLine();
            Console.WriteLine(t1.llamar());
            Console.WriteLine(" Ingresar contacto ");
            string contac = Console.ReadLine();
            Console.WriteLine(t1.llamar(contac));
            Console.WriteLine(" Codigo de operador: ");
            t1.CodOpe = int.Parse(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
