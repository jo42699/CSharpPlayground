using System;
using System.ComponentModel.Design.Serialization;
using System.Threading.Tasks.Dataflow;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // CONVERSION 
            //double pi = 3.12456;
           // int b = Convert.ToInt32(pi);
           // String f = Convert.ToString(pi);

           // Console.WriteLine(f.GetType());
           // Console.WriteLine(); 




           // collecting data 

           Console.WriteLine("What is your name ");
           String name = Console.ReadLine();

           Console.WriteLine("What is your age");
           int age = Convert.ToInt32(Console.ReadLine());


         Console.WriteLine("Your name is " + name);
         Console.WriteLine("Your age are " + age + " years old");


            
        }
    }
}
