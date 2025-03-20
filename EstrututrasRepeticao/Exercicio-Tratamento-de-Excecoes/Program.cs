// 1

Console.WriteLine("Digite um número inteiro: ");
try
{
    int numero = int.Parse(Console.ReadLine());
}
catch (FormatException ex)
{
    Console.WriteLine("Erro: Entrada inválida, digite um número inteiro válido.");
}

// 2 
Console.WriteLine("Informe dois número para divisão");
try
{
    Console.WriteLine("Primeiro Numero: ");
    int numero1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Segundo Numero: ");
    int numero2 = int.Parse(Console.ReadLine());

    int res = numero1 / numero2;
}
catch (FormatException ex)
{
    Console.WriteLine("Erro: Entrada inválida, digite um número inteiro válido.");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Erro: Não é possível dividir por zero.");
}

// 3 
Console.WriteLine("Informe a idade: ");
int idade = 0;

try
{
    idade = int.Parse(Console.ReadLine());
    if (idade < 0 || idade > 120)
    {
        throw new OverflowException("Erro: Idade inválida.");
    }
}
catch (FormatException ex)
{
    Console.WriteLine("Erro: Entrada inválida, digite um número inteiro válido.");
}
catch (OverflowException ex)
{
    Console.WriteLine("Erro: Idade inválida."); //Aparece Para o usuário
}


// 4 

Console.WriteLine("Contagem Regressiva - Digite um número");
int numeroContagem = 0;
int contador = 1;
try
{
    numeroContagem = int.Parse(Console.ReadLine());
    if (numeroContagem < 0)
    {
        throw new ArgumentOutOfRangeException("Erro: O número deve ser positivo.");
    }
}
catch (FormatException ex)
{
    Console.WriteLine("Erro: Entrada inválida, digite um número inteiro válido.");
}
catch (OverflowException ex)
{
    Console.WriteLine("Erro: Informe um número valido");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine("Erro: O número deve ser positivo.");
}
while (contador <= numeroContagem)
{
    Console.WriteLine(contador);
    contador++;
}

// 5 
Console.WriteLine("Soma : Informe 5 numeros: ");
