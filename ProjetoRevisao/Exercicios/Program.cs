// 1
//int[] numeros = new int[5];

//for (int i = 0; i < numeros.Length; i++)
//{
//    Console.WriteLine("Insira os numeros");
//    numeros[i] = int.Parse(Console.ReadLine());
//}

int[] numeros = [1, 2, 3, 4, 5];

foreach (var num in numeros)
{
    Console.WriteLine(num);
}

// 2
int[] numerosSoma = [1, 2, 3, 4, 5];
int soma = 0;

for (int i = 0; i < numerosSoma.Length; i++)
{
    //soma = soma + numerosSoma[i]; -> Abaixo tem a mesma função
    soma += numeros[i];
}
Console.WriteLine(soma);

// 3
int[] numeroMaior = [1,2,30,4,5];
int consulta = 0;
//int.maiorNumero = numeroMaior.Max();

for (int i = 0; i < numeroMaior.Length; i++)
{
    if(numeroMaior[i] > consulta)
    {
        consulta = numeroMaior[i];
    }
}
Console.WriteLine($"Numero maior {consulta}");

// 4 - Contagem de Números Pares
int[] numerosPares = new int[10];

for (int i = 0; i < numerosPares.Length; i++)
{
    Console.WriteLine("Numeros Pares - Informe 10 números");
    numerosPares[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < numerosPares.Length; i++)
{
    if (numerosPares[i] % 2 == 0)
    {
        Console.WriteLine(numerosPares[i]);
    }
}

// 5 - Inversão de Elementos
int[] numerosInversos = new int[8];

for (int i = 0; i < numerosInversos.Length; i++)
{
    Console.WriteLine("Numeros Inversos - Informe 8 números");
    numerosInversos[i] = int.Parse(Console.ReadLine());
}

for(int i = numerosInversos.Length -1; i >= 0; i--)
{
    Console.WriteLine(numerosInversos[i]);
}

// 6 

