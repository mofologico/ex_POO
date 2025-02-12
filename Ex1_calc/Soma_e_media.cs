using System;
using System.Collections.Generic;

class Soma_e_media
{
    public static void Executar()
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Digite a quantidade de números que deseja adicionar à lista:");
        int quantidade = 0;
        while (quantidade <= 0)
        {
            try
            {
                quantidade = int.Parse(Console.ReadLine());
                if (quantidade <= 0)
                {
                    Console.WriteLine("Quantidade inválida. Digite um número inteiro positivo:");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Digite um número inteiro:");
            }
        }


        for (int i = 1; i <= quantidade; i++)
        {
            Console.WriteLine($"Digite o {i}º número:");
            while (true)
            {
                try
                {
                    int numero = int.Parse(Console.ReadLine());
                    numeros.Add(numero);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida. Digite um número inteiro:");
                }
            }
        }


        Console.WriteLine("\nNúmeros digitados:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}