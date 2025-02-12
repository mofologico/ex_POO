class Home
{
    public static void Main()
    {

        while (true)
        {
            Console.WriteLine("qual exercicio?\n\n 1 - calculadora\n 2 - Soma e média\n 3 - Jogar dados\n 4 - Datas\n 5 - Conversão de moedas\n 6 - Jogo da forca\n 7 - Sair");
            int exercicio = int.Parse(Console.ReadLine());

            if (exercicio == 7)
            {
                //sair
                Console.WriteLine("tchau");
                Environment.Exit(0);
            }


            switch (exercicio)
            {

                case 1:

                    Calculadora.Executar();

                    break;

                case 2:

                    Soma_e_media.Executar();

                    break;

                case 3:

                    Jogar_dados.Executar();

                    break;

            }

        }

    }
}

