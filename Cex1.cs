using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Bonjour, est-ce qu'il pleut aujourd'hui ? (indiquez true ou false)");
         bool rainy = bool.Parse(Console.ReadLine());
            if (rainy)       
                Console.WriteLine("« Bonjour, il pleut aujourd’hui, vous devriez prendre votre parapluie. »");
            else
                Console.WriteLine("« Bonjour, il ne pleut pas aujourd’hui, bonne journée. »");
        }
    }
      
    
    
}
/* CORRIGE :
class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Bonjour, est-ce qu'il pleut aujourd'hui ? (indiquez true ou false)");
            bool rainy = bool.Parse(Console.ReadLine());*/
            bool rainy = true; 
            if (rainy) // if (!rainy)        ! négation 
                // if (rainy == false)       == op. de comparaison  = attribut de valeur
            {
                Console.WriteLine("« Bonjour, il pleut aujourd’hui, vous devriez prendre votre parapluie. »"); // \ pour les guillemets
            }
            else
            {
                Console.WriteLine("« Bonjour, il ne pleut pas aujourd’hui, bonne journée. »"); */
            }
