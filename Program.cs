using System;
using Figgle;

namespace UltimaParcela
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal ValorTotal;
            decimal Parcelas;
            decimal ValorFinal;

            DateTime dataAtual = DateTime.Now;
            DateTime ParcelaFinal;

            Console.WriteLine("----Ultima Parcela----!");

            Console.Write(" Valor Total Das Parcelas: ");
            ValorFinal = decimal.Parse(Console.ReadLine());

            Console.Write("Valor de Cada Parcela: ");
            Parcelas = decimal.Parse(Console.ReadLine());

            ValorTotal = ValorFinal / Parcelas;

            ParcelaFinal = dataAtual.AddMonths(8);
            Console.WriteLine($"A Ultima Parcela Será Em: {ParcelaFinal}, No Valor De R${ValorTotal}");

                        
            Console.WriteLine(FiggleFonts.Standard.Render("OBRIGADO!"));







            
            

        }
    }
}
