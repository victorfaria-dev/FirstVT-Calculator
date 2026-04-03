using System.ComponentModel;
using System.Runtime.Serialization;
//calculado do Viquitor(projeto pessoal de calculadora)
Console.WriteLine("======================================");
Console.WriteLine("    Bem-vindo à Calculadora do VT!    ");
Console.WriteLine("======================================\n\n\n");

//histórico para armazenar os resultados das operações
List<double> historico = new List<double>();


//repetição para realizar várias operações
while (true)
{
    //contador para o histórico
    int contador = 1;

    //declaração de variáveis
    double num1, num2;
    double resultado = 0;
    int operacao;

    //qual operação deseja realizar?
    Console.WriteLine("Qual operação deseja realizar?");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Potência");
    Console.WriteLine("6 - Raiz Quadrada");
    Console.WriteLine("=====================================");


    //repetição para validar a escolha da operação
    while (true)
    {

        if (int.TryParse(Console.ReadLine(), out operacao) &&
            operacao >= 1 && operacao <= 6)
        {
            Console.WriteLine("\n\n\n");
            break;
        }


        Console.WriteLine("Escolha uma operação (1 a 6):");

    }

    //receber demais operações
    if (operacao != 6 && operacao != 4)
    {
        Console.WriteLine("Insira o primeiro número:");
        double.TryParse(Console.ReadLine(), out num1);

        Console.WriteLine("Insira o segundo número:");
        double.TryParse(Console.ReadLine(), out num2);
    }

    //receber raiz quadrada
    else if (operacao == 6)
    {
        num2 = 0;
        Console.WriteLine("Insira o número para calcular a raiz quadrada:");
        while (true)
        {

            if (double.TryParse(Console.ReadLine(), out num1) &&
                num1 >= 0)
            {
                break;
            }
            Console.WriteLine("O número não pode ser negativo!");

        }
    }

    //receber divisão
    else
    {
        Console.WriteLine("Insira o primeiro número:");
        double.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("Insira o segundo número (diferente de zero):");
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out num2) &&
                num2 != 0)
            {
                break;
            }
            Console.WriteLine("O número não pode ser zero!");
        }
    }

    //casos das operações e apresentação do resultado
    switch (operacao)
    {
        case 1:
            Console.WriteLine("Você escolheu Soma.");
            resultado = num1 + num2;
            break;
        case 2:
            Console.WriteLine("Você escolheu Subtração.");
            resultado = num1 - num2;
            break;
        case 3:
            Console.WriteLine("Você escolheu Multiplicação.");
            resultado = num1 * num2;
            break;
        case 4:
            Console.WriteLine("Você escolheu Divisão.");
            resultado = num1 / num2;
            break;
        case 5:
            Console.WriteLine("Você escolheu Potência.");
            resultado = Math.Pow(num1, num2);
            break;
        case 6:
            resultado = Math.Sqrt(num1);
            break;
    }
    Console.WriteLine($"\n\n\nO resultado é: {resultado};");
    if (resultado == 0)
        Console.WriteLine("Não sobrou absolutamente nada para o betinha moggado!!!!");

    //perguntar se deseja salvar o resultado
    Console.WriteLine("\n\n\nDeseja salvar o resultado? (s/n)");
    while (true)
    {
        string resposta = Console.ReadLine().ToLower();
        if (resposta == "s" || resposta == "n")
        {
            if (resposta == "s")
            {
                historico.Add(resultado);
                Console.WriteLine("\nResultado salvo no histórico!");
                foreach (double r in historico)
                {

                    Console.WriteLine($"Resultado {contador}: {r}");
                    contador++;
                }
            }
            break;
        }
        Console.WriteLine("Digite 's' para sim ou 'n' para não:");
    }

    //perguntar se deseja limpar a tela
    Console.WriteLine("\n\n\nDeseja limpar a tela? (s/n)");
    while (true)
    {
        string resposta = Console.ReadLine().ToLower();
        if (resposta == "s" || resposta == "n")
        {
            if (resposta == "s")
            {
                Console.Clear();
            }
            break;
        }
        Console.WriteLine("Digite 's' para sim ou 'n' para não:");
    }

    //perguntar se deseja realizar outra operação
    Console.WriteLine("\n\n\nDeseja realizar outra operação? (s/n)");
    while (true)
    {
        string resposta = Console.ReadLine().ToLower();
        if (resposta == "s" || resposta == "n")
        {
            if (resposta == "n")
            {
                Console.WriteLine("Obrigado por usar a Calculadora do VT! Até a próxima!");
                Console.WriteLine("Pressione qualquer tecla para sair...");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("\n\n\n");
            break;
        }
        Console.WriteLine("Digite 's' para sim ou 'n' para não:");
    }

}
