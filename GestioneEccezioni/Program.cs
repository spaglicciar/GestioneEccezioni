using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneEccezioni
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            Console.WriteLine("Per favore inserisci l'età");

            string a = "pippo";
            a = "pluto";

            try
            {
                string età = Console.ReadLine();
                m.SetEtà(età);
                Console.WriteLine("L'età inserità è: " + m.Età);
            }
            catch (CustomException ex)
            {
                Console.WriteLine("C'è stato un problema.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Dettagli tecnici: " + ex.InnerException.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Il valore inserito non è corretto");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Grazie per aver utilizzato il nostro software");
            }

            //Console.WriteLine("Inserisci un'età");

            //MyClass m = new MyClass();
            //try
            //{
            //    m.SetEtà(Console.ReadLine());
            //    Console.WriteLine("L'età inserità è: " + m.Età);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Grazie per aver utilizzato il nostro software");
            //}
            Console.ReadLine();
        }
    }
}
