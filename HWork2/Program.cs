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
            string FullName = "Ivanov Ivan Ivanovich";
            string Email = "ivan@gmail.com";
            int Age = 17;
            float MarkPhysics = 80.9f;
            float MarkProgramming = 90.5f;
            float MarkMath = 77.5F;
            float SumMarks;
            SumMarks = (MarkPhysics + MarkProgramming + MarkMath) / 3;
            Console.WriteLine(FullName);
            Console.WriteLine(Age);
            Console.WriteLine(Email);
            Console.WriteLine(MarkPhysics);
            Console.WriteLine(MarkProgramming);
            Console.WriteLine(MarkMath);
            Console.ReadKey();
            Console.WriteLine(SumMarks);
            Console.ReadKey();
        }
    }
}
