// REFERENCIA NULA - NullPointerException
// Nula - Não tem espaço reservado na memória.

//1
int numero1 = int.Parse(Console.ReadLine());
int numero2 = int.Parse(Console.ReadLine());

//Console.WriteLine(numero1);

if (numero1 > numero2)
{
    Console.WriteLine($"O maior númeor é { numero1 }");
} else
{
    Console.WriteLine($"O maior numero é {numero2}");
}

//2
Console.WriteLine("Informe a sua idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade <= 12)
{
    Console.WriteLine("Criança");
} else if (idade > 12 && idade <= 17)
{
    Console.WriteLine("Adolescente");
} else
{
    Console.WriteLine("Adulto");
}

//3
Console.WriteLine("PAR ou IMPAR - Informe o número: ");
int parImpar = int.Parse(Console.ReadLine());
int resultado = parImpar % 2;
if (resultado == 0)
{
    Console.WriteLine("Numero Par");
} else
{
    Console.WriteLine("numero impar");
};

//4 
int numeroMaior1 = int.Parse(Console.ReadLine());
int numeroMaior2 = int.Parse(Console.ReadLine());
int numeroMaior3 = int.Parse(Console.ReadLine());

if (numeroMaior1 > numeroMaior2 && numeroMaior1 > numeroMaior3)
{
    Console.WriteLine(numeroMaior1);
} else if (numeroMaior2 > numeroMaior1 && numeroMaior2 > numeroMaior3)
{
    Console.WriteLine(numeroMaior2);
} else
{
    Console.WriteLine(numeroMaior3);
}

//5 
Console.WriteLine("Bhaskara");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

double delta = ((Math.Pow(b, 2)) - (4 * a * c));

double x1 = ((-b) + (delta)) / (2 * a);
double x2 = ((-b) - (delta)) / (2 * a);
Console.WriteLine($"Valor de delta {delta}");
Console.WriteLine($"Valor de x1 = {x1}");
Console.WriteLine($"Valor de x2 = {x2}");

//6
Console.WriteLine("Calculadora");
Console.WriteLine("Digite o primeiro valor: ");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o operador de cálculo: +, -, /, ou *");
char operador = char.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo valor: ");
double num2 = double.Parse(Console.ReadLine());

if (operador == '+')
{
    Console.WriteLine("Resultado: " + (num1 + num2));
} else if (operador == '-')
{
    Console.WriteLine("Resultado: " + (num1 - num2));
} else if (operador == '*')
{
    Console.WriteLine("Resultado: " + (num1 * num2));
} else if (operador == '/')
{
    if (num1 != 0)
    {
        Console.WriteLine("Resultado: " + (num1 / num2));
    }
    else
    {
        Console.WriteLine("Erro: Divisão por zero");
    }
}
else
{
    Console.WriteLine("Operador Inválido");
}

// 7 
Console.WriteLine("Ano Bissexto");
Console.WriteLine("Digite um ano: ");
int ano = int.Parse(Console.ReadLine());

if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
{
    Console.WriteLine("O ano é bissexto");
}
else
{
    Console.WriteLine("O ano não é bissexto");
}


// 8 
Console.WriteLine("Triangulo Válido");
Console.WriteLine("Digite o primeiro lado: ");
int lado1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo lado: ");
int lado2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o terceiro lado: ");
int lado3 = int.Parse(Console.ReadLine());

// para validar o tringulo, a soma de dois lados deve ser maior que o terceiro. Isso deve ser válido para todos os lados simultâneamente
if ((lado1 + lado2) > lado3 && (lado2 + lado3) > lado1 && (lado1 + lado3) > lado2)
{
    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("triangulo equilátero");
    } else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
    {
        Console.WriteLine("triangulo isósceles");
    }
    else
    {
        Console.WriteLine("Triangulo escaleno");
    }
}
else
{
    Console.WriteLine("Valores Invalidos para formar um trinagulo");
}

// 9
Console.WriteLine("Classificação Nota");
Console.WriteLine("Informe a nota");
int nota = int.Parse(Console.ReadLine());

if (nota >= 90)
{
    Console.WriteLine("Nota A");
} else if (nota < 90 && nota >= 80)
{
    Console.WriteLine("Nota B");
} else if (nota < 79 && nota >= 70)
{
    Console.WriteLine("Nota C");
} else if (nota < 69 && nota >= 60)
{
    Console.WriteLine("Nota D");
}
else
{
    Console.WriteLine("Nota F");
}