﻿class Calculadora
{
    public static void Executar()
    {
        while (true)
        {
            Console.WriteLine("qual operação?\n\n 1 - soma\n 2 - subtração\n 3 - multiplicação\n 4 - divisão\n 5 - voltar");
            int operacao = int.Parse(Console.ReadLine());

            if (operacao == 5)
            {
                //voltar
                Home.Main();
            }

            Console.WriteLine("digite o primeiro número da operação.");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo número da operação.");
            int valor2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    //soma
                    resultado = valor1 + valor2;
                    Console.WriteLine("O resultado é: " + resultado);

                    break;
                case 2:
                    //subtração
                    resultado = valor1 - valor2;
                    Console.WriteLine("O resultado é: " + resultado);

                    break;
                case 3:
                    //multiplicação
                    resultado = valor1 * valor2;
                    Console.WriteLine("O resultado é: " + resultado);

                    break;
                case 4:
                    //divisão
                    if (valor1 != 0 || valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                        Console.WriteLine("O resultado é: " + resultado);

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Não é possível dividir por zero.");
                        break;
                    }
            }
            Console.WriteLine(" "); //espaço entre operações
        }
    }
}

