using System;

namespace Lab3ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Screiti un program care va numara vocalele dintr-un sir de caractere citit de la tastatura.

            string vocale = "aeiou";
            Console.WriteLine("Introduceti un sir de caractere");
            string mesaj = Console.ReadLine();

            int length = mesaj.Length;
            int lengthVocale = vocale.Length;

            int count = 0;

            for (int i=0; i<length; i++)

            {

                for (int j=0; j<lengthVocale; j++)

                {

                if ( Char.ToLower(vocale[j]) == Char.ToLower( mesaj[i]) )
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Numarul total de vocale este: {0} ", count);



        }
    }
}
