using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Interface_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Populates the class roster for prog 140
            SchoolClass prog140 = new SchoolClass();
            prog140.AddStudent("Jane");
            prog140.AddStudent("Rodrigo");
            prog140.AddStudent("Alex");
            prog140.AddStudent("Rachael");
            prog140.AddStudent("James");
            prog140.AddStudent("Kelly");
            prog140.AddStudent("Astrid");
            prog140.AddStudent("Zhenling");
            prog140.AddStudent("Chen");
            prog140.AddStudent("Bea");
            prog140.AddStudent("River");
            prog140.AddStudent("Joaquin");
            prog140.AddStudent("Preston");
            prog140.AddStudent("Jacque");
            prog140.AddStudent("Simon");
            prog140.AddStudent("Ace");
            prog140.AddStudent("Anna");
            prog140.AddStudent("Claire");
            prog140.AddStudent("Fabian");
            prog140.AddStudent("Felix");
            prog140.AddStudent("Joy");

            // Using IEnumerator - displays the class roster
            foreach (Student student in prog140)
            {
                Console.WriteLine(student);
            }
            Console.ReadKey();
        }

    }
}
