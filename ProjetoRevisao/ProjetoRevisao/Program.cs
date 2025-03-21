//string[] aluno = new string[10];

int[] nota = new int[5];
int somatoria = 0;
double media = 0;

for (int i = 0; i < nota.Length; i++)
{
    Console.WriteLine($"Digite a {i + 1}ª nota: ");
    nota[i] = int.Parse(Console.ReadLine());
    somatoria = somatoria + nota[i];
}

Console.WriteLine("Notas do aluno: ");

foreach (int x in nota)
{
    Console.Write(x + " ");
}
Console.WriteLine();

media = somatoria / nota.Length;
Console.WriteLine($"Média: {media}");

if (media >= 7)
{
    Console.WriteLine("O aluno foi APROVADO! 🎉");
} else
{
    Console.WriteLine("O aluno NÃO foi APROVADO!👎");
}