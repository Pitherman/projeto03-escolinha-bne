using System;

class Entradas
{
    public double entrada;
    public double taxa;
    public int periodo;


    public double valorF()
    {
        return (entrada*Math.Pow((1+taxa/100), periodo));
    }


    public void tabela()
    {
        double rendimento = Math.Round(valorF(), 2);
        Console.WriteLine("\n| Taxa: "+taxa+"% | Período: "+periodo+" anos | Rendimento: R$"+rendimento+" |\n");
    }
}