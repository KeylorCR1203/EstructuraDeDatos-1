using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSuma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MSJ 
            Console.WriteLine("...APP SUMAR...");
            float numero1 = 0;
            float numero2 = 0;
            float numero3 = 0;
            string dato = "";
            
            //Entrada datos
            Console.WriteLine("Digite el numero 1:");
            dato = Console.ReadLine();//Aqui se almacena los datos de la variable

            //Se convierte el dato escrito en numero tipo de dato
            numero1 = float.Parse(dato);

            Console.WriteLine("Digite el numero 2: ");
            dato = Console.ReadLine();
            numero2 = float.Parse(dato);

            //Procesaminto
            result = numero1 + numero2;


            //Salida datos
            Console.WriteLine("El resultado es: " + result);

            //Finaliza la app 
            Console.ReadKey();//Pausa para esperar la tecla
            Environment.Exit(0);
            //El enviroment se pone siempre ya que cierra la app 






        }
    }
}
