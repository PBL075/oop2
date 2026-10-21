using System;

namespace audi
{
    class Program
    {
        static void Main(string[] args)
        {
            Audi RS7 = new Audi("RS7", "Albastru", 135000);
            Audi RS6 = new Audi("RS6", "Rosu", 130000);
            Audi A5 = new Audi("A5", "Alb", 45000);

            RS7.setDate();
            RS6.setDate();
            A5.setDate();

            Console.WriteLine("\nIn garaj sunt " + Audi.count + " audiuri.");
        }
    }
}