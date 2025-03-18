// 1
int numero = 1;

while (numero <= 20)
{
    Console.WriteLine(numero);
    numero++;
}

// 2

int senha;
do
{
    Console.WriteLine("Digite a senha: ");
    senha = int.Parse(Console.ReadLine());
} while (senha != 1234);

// 3
Console.WriteLine("Tabuada - Digite o número: ");
int numeroTabuada = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    int resultado = numeroTabuada * i;
    Console.WriteLine(resultado);
}

// 4
Console.WriteLine("Contagem Regressiva - Digite um numero: ");
int numeroContagem = int.Parse(Console.ReadLine());

for (int i = numeroContagem; i >= 0; i--)
{
    Console.WriteLine(i);
}

// 5 
Console.WriteLine("Media de Notas - Digite a sua nota: ");
