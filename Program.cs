using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
            string firstname;
            string lastname;
            string color;
            string auto;

            
        
            Console.WriteLine("Your First Name Please");
            firstname = Console.ReadLine();
            Console.WriteLine("Your Last Name Please");
            lastname = Console.ReadLine();




            //Console.WriteLine("Nice to meet you, " + firstname + " " + lastname + "!");
            //I am just a annoying comment
            Console.WriteLine("Mis on sinu lemmikvärv");
            color = Console.ReadLine();
            Console.WriteLine("Nice to meet you {0} {1},minu lemmikvärv on {2}", firstname, lastname, color);
           
            Console.WriteLine("milline on sinu lemmik auto");
            auto = Console.ReadLine();

            
            
            
            Console.WriteLine("Minu lemmik auto on " + auto);








            Console.ReadLine();
        }
    }
}
