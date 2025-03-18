// 1
int numero = 1;

while (numero <= 20)
{
    Console.WriteLine(numero);
    numero++;
}

// 2

do
{
    Console.WriteLine("Digite a senha: ");
    int senha = int.Parse(Console.ReadLine());
} while (numero != 1234);

// 3
Console.WriteLine("Tabuada - Digite o número: ");
int numeroTabuada = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    int resultado = numeroTabuada * i;
    i++;
    Console.WriteLine(resultado);
}
