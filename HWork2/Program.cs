using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Ivanov Ivan Ivanovich";
            string email = "ivan@gmail.com";
            int age = 17;
            float markPhysics = 80.9f;
            float markProgramming = 90.5f;
            float markMath = 77.5F;
            float sumMarks;
            sumMarks = (markPhysics + markProgramming + markMath) / 3;
            Console.WriteLine(fullName);
            Console.WriteLine(age);
            Console.WriteLine(email);
            Console.WriteLine(markPhysics);
            Console.WriteLine(markProgramming);
            Console.WriteLine(markMath);
            Console.ReadKey();
            Console.WriteLine(sumMarks);
            Console.ReadKey();
        }
    }
}
