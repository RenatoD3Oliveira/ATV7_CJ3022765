int opcao;

do
{
    do
    {

        Console.WriteLine("");
        Console.WriteLine("=========MENU=========");
        Console.WriteLine("0 - SAIR");
        Console.WriteLine("1 - EX1");
        Console.WriteLine("2 - EX2");
        Console.WriteLine("3 - EX3");
        Console.WriteLine("4 - EX4");
        Console.WriteLine("5 - EX5");
        Console.WriteLine("6 - EX6");
        Console.WriteLine("7 - EX7");

        opcao = int.Parse(Console.ReadLine());

    } while (opcao < 0 || opcao > 7);

    switch (opcao)
    {
        case 0:
            Console.WriteLine("Obrigado por usar o sistema!");
            break;
        case 1:
            Console.WriteLine("Executando o ex1");

            Console.Write("Digite um número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numero1; i++ )
            {
                Console.Write(i + " ");
            }
            break;

            break;
        case 2:
            Console.WriteLine("Executando o ex2");

            Console.Write("Digite um número inteiro: ");
            int numero2 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numero2; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }

            break;
        case 3:
            Console.WriteLine("Executando o ex3");

            Console.Write("Digite um número inteiro (menor que 1000): ");
            int numero3 = int.Parse(Console.ReadLine());
            for (int i = 1000; i <= numero3; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
            break;

        case 4:
            Console.WriteLine("Executando o ex3");

            int somaPositivos = 0;
            int numero4;
            do
            {
                Console.Write("Digite um número inteiro: ");
                numero4 = int.Parse(Console.ReadLine());
                if (numero4 > 0)
                    somaPositivos += numero4;
            } while (somaPositivos < 200);

            break;
        case 5:
            Console.WriteLine("Executando o ex3");

            Console.Write("Digite um número inteiro: ");
            int numero5 = int.Parse(Console.ReadLine());
            Console.Write("Divisores de " + numero5 + ": ");
            for (int i = 1; i <= numero5; i++)
            {
                if (numero5 % i == 0)
                    Console.Write(i + " ");
            }

            break;
        case 6:
            Console.WriteLine("Executando o ex3");

            int maior = int.MinValue;
            int menor = int.MaxValue;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º número: ");
                int numero6 = int.Parse(Console.ReadLine());
                if (numero6 > maior)
                    maior = numero6;
                if (numero6 < menor)
                    menor = numero6;
            }
            Console.WriteLine("Maior número digitado: " + maior);
            Console.WriteLine("Menor número digitado: " + menor);

            break;
        case 7:
            Console.WriteLine("Executando o ex3");

            int somaPares = 0;
            int somaImpares = 0;
            int numero7;
            do
            {
                Console.Write("Digite um número inteiro (digite 0 para sair): ");
                numero7 = int.Parse(Console.ReadLine());
                if (numero7 % 2 == 0)
                    somaPares += numero7;
                else
                    somaImpares += numero7;
            } while (numero7 != 0);
            Console.WriteLine("Soma dos números pares: " + somaPares);
            Console.WriteLine("Soma dos números ímpares: " + somaImpares);

            break;
    }

} while (opcao != 0);