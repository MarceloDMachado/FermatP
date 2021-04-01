using System;

namespace FermatP
{
    class Program
    {
        static void Main(string[] args)
        {
            Exponenciacao a = new Exponenciacao(3);
            Exponenciacao b = new Exponenciacao(6);
            Exponenciacao c = new Exponenciacao(9);


            //Próximo Passo: Substituir por uma lista de tarefas assíncronas para reduzir o tempo total de processamento.
            a.setExpoente(3);
            b.setExpoente(3);
            c.setExpoente(3);

            
            ulong somaDasPotencias = Calculadora.somarPotencias(a.Potencia, b.Potencia, c.Potencia);

            

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(somaDasPotencias);
        }
    }
}
