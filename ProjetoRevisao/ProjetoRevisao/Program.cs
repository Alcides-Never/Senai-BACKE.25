//string[] aluno = new string[10];

double[] nota = new double[5];
double somatoria = 0;
double media;
bool verificacaoEntrada = true;

try
{
    for (int i = 0; i < nota.Length; i++)
    {
        Console.WriteLine($"Digite a {i + 1}ª nota: ");
        nota[i] = double.Parse(Console.ReadLine());
        if (nota[i] > 10 || nota[i] < 0)
        {
            throw new ArgumentOutOfRangeException("Erro: Nota não pode ser maior que 10 ou menor que 0");
        }

        somatoria = somatoria + nota[i];
    }
}
catch (FormatException)
{
    Console.WriteLine("Erro: Insira apenas números válidos");
    verificacaoEntrada = false;
    return;
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("Erro: Nota não pode ser maior que 10 ou menor que 0");
    verificacaoEntrada = false;
    return;
}

if (verificacaoEntrada)
{
    Console.WriteLine("Notas do aluno: ");

    foreach (double x in nota)
    {
        Console.Write(x + " ");
    }

    Console.WriteLine();

    media = somatoria / nota.Length;
    Console.WriteLine($"Média: {media}");

    if (media >= 7)
    {
        Console.WriteLine("O aluno foi APROVADO! 🎉");
    }
    else
    {
        Console.WriteLine("O aluno NÃO foi APROVADO!👎");
    }
}

string[] alunos = new string[2];





// // Resposta do professor
//
// // 1 - Inserir as nodas de um aluno (5 notas)
//
// int[] notasR = new int[5];
//
// for (int i = 0; i < notasR.Length; i++)
// {
//     Console.WriteLine("Informe a nota: ");
//     notasR[i] = int.Parse(Console.ReadLine());
// }
//
// // 2 - Exibir as notas
//
// for (int i = 0; i < notasR.Length; i++)
// {
//     Console.WriteLine(notasR[i] + " ");
// }
//
// // 3 - Calcular a Média
// // Soma das Notas - Quantidade (Já possuo)
//
// int somaNotas = 0;
//
// for (int i = 0; i <= notasR.Length; i++)
// {
//     somaNotas = notasR[i] + somaNotas;
// }
//
// int mediaR = somaNotas / notasR.Length;
//
// Console.WriteLine(mediaR);
//
// if (mediaR >= 7)
// {
//     Console.WriteLine("O aluno foi aprovado");
// }
// else
// {
//     Console.WriteLine("O aluno foi reprovado");
// }