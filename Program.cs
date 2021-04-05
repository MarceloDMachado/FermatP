using System;
using System.Collections.Generic;


namespace FermatP
{
    class Program
    {
        static void Main(string[] args)
        {
            Equacao Teorema = new Equacao(3, 6, 9);
            Byte looping = 1;
            do
            {
                Teorema.setExpoente(looping);
                Console.WriteLine(Teorema);
                looping += 1;
            } while (looping < 255);
        }
    }
}
