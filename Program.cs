using System;

namespace _Teste04

{
    class Program
    {
        static void Main(string[] args)
        {
            Entradas e = new Entradas();
            Console.WriteLine("\nQual o valor investido?");
            e.entrada = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual a taxa de juros aplicada?");
            e.taxa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pretende manter o valor investido por quantos anos?");
            e.periodo = Convert.ToInt32(Console.ReadLine());
            e.tabela();
        }

    }

}