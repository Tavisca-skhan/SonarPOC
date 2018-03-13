using System;

namespace SonarCubePoc
{
    class Program

    {

        static void Main(string[] args)

        {

            int myvariable = 0;
           

            CSharp csharp = new CSharp();

            csharp.SetDetails("2.0", "Asp.Net MVC");

            var details= csharp.GetDetails();
            Console.WriteLine(details);

            Console.ReadKey();
        }

    }
}
