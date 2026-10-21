using System;

namespace audi
{
    class Audi
    {
        public string model;
        public string culoare;
        public int pret;
        public static int count = 0;

        public Audi(string model, string culoare, int pret)
        {
            this.model = model;     
            this.culoare = culoare;
            this.pret = pret;
            count++;
        }

        public void setDate()
        {
            Console.WriteLine("Model la audi: " + this.model + " | culoarea: " + this.culoare + " | pretul in euro: " + this.pret);
        }
    }
}