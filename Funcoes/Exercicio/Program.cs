// 1

using System.Threading.Channels;

string Saudacao(string nome)
{
    string mensagem = "Olá " + nome + "! Bem vindo!";
    
    return mensagem;
}
Console.WriteLine(Saudacao("Carlos"));

// 2

int Soma (int a, int b)
{
    return a + b;
}
int resultado = Soma(5, 3);
Console.WriteLine(resultado);

// 3 

void MostrarMensagem ()
{
    Console.WriteLine("Este é um programa de C# com funções!");
}

MostrarMensagem();

// 4

double CalcularMedia(double a, double b, double c)
{
    return (a + b + c) / 3;
}

double media = CalcularMedia(7.5, 8.0, 6.5);
Console.WriteLine("Media: " + media);

// 5

bool EhPar(int num)
{
    if(num % 2 == 0)
    {
        return true;
    } else
    {
        return false;
    }
}

bool resultadoPar = EhPar(10);
Console.WriteLine(resultadoPar);

// 6 

double CelsiusParaFahrenheit (int C)
{
    double F = (C * 9 / 5) + 32;
    return F;
}

double fahrenheit = CelsiusParaFahrenheit(25);
Console.WriteLine(fahrenheit);

// 7 

int ContarVogais (string palavra)
{
    string teste[] = palavra.Split(' ');
    return teste;
}



//// Correção do Professor

//// 1 

//// Função - sem retorno ou com retorno
//void Saudacao(string nome)
//{
//    Console.WriteLine("Seja bem-vindo! " + nome);
//}

//Saudacao("Vini");

//// Ex.
//string nome = "Vinicio";
//// Parametro
//void Saudacao(string nome)
//{
//    Console.WriteLine("Seja bem-vindo! " + nome);
//}

//// Argumento
//Saudacao(nome);

//// 2

//int Soma(int num1, int num2)
//{
//    return num1 + num2;
//}
//Console.WriteLine(Soma(12, 10));

//// 3

//void MostrarMensagem()
//{
//    Console.WriteLine("Este é um programa de C# com funções!");
//}