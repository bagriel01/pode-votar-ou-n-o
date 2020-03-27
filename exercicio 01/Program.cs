using System;
namespace exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int anasc;
            
            Console.WriteLine("Olá, Bom Dia");
            Console.WriteLine("Vamos averiguar se você já pode votar nas eleições de 2020.");
            Console.WriteLine("Digite o ano de seu nascimento (Exemplo : 1997)");
            anasc = int.Parse(Console.ReadLine());
            if (anasc > 2004)
            {
                Console.WriteLine("Oh Não. Você ainda não pode votar, pois não tem 16 anos de idade.");
            }
            else
            {
                Console.WriteLine("Parabéns. Você já pode votar. Encaminhe-se até um TRE e faça seu título de Eleitor se não tiver.");
            } 
            
            
           

        }
    }
}
