int idade = int.Parse(Console.ReadLine());

// Crianca, Adolscente, Adulto, Idoso
if(idade >= 60)
{
    Console.WriteLine("Idoso");
}
else if (idade > 18)
{
    Console.WriteLine("Adulto");
}
else if (idade < 18 && idade > 12)
{
    Console.WriteLine("Adolescente");
} else
{
    Console.WriteLine("Criança");
}

// Ternário
idade = 20;

string msg = (idade > 18) ? "Maior de Idade" : "Menor de Idade";

//Exemplificando com if/else

string msg;

if (idade > 18)
{
    msg = "Maior de Idade";
}
else
{
    msg = "Menor de Idade";
}

// Outro Exemplo - PAR ou IMPAR

int numero = 4;

string tipo = (numero % 2 == 0) ? "Par" : "Impar";

// Math
// Potência
Math.Pow(2, 3);
// Raiz
Math.Sqrt(9);