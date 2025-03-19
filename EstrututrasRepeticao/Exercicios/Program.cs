// 1
int numero = 1;

while (numero <= 20)
{
    Console.WriteLine(numero);
    numero++;
}

//Resposta do professor:
//for (int i = 1; i < 21; i++)
//{
//    Console.WriteLine(i);
//}

// 2

int senha;
do
{
    Console.WriteLine("Digite a senha: ");
    senha = int.Parse(Console.ReadLine());
} while (senha != 1234);

//Resposta do professor é a mesma feito acima

// 3
Console.WriteLine("Tabuada - Digite o número: ");
int numeroTabuada = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    int resultado = numeroTabuada * i;
    Console.WriteLine(resultado);
}

// Resposta do professor: 
//Console.WriteLine("Informe um valor");
//int valor = int.Parse(Console.ReadLine());

//for (int i = 0; i < 11;  i++)
//{
//    Console.WriteLine($"{valor} * {i} = {valor * i}");
//}

// 4
Console.WriteLine("Contagem Regressiva - Digite um numero: ");
int numeroContagem = int.Parse(Console.ReadLine());

for (int i = numeroContagem; i >= 0; i--)
{
    Console.WriteLine(i);
}

// Resposta do professor segue as instruções acima

// 5 

//Console.WriteLine("Media de Notas - Digite a sua nota: ");

////int nota = int.Parse(Console.ReadLine());
////int nota = 0;
//int soma = 0;
//int contador = 0;


//while (nota <= 10 && nota >= 0)
//{
//    nota = int.Parse(Console.ReadLine());
//    soma = soma + nota;
//    contador++;
//    if (nota > 10 || nota < 0)
//    {
//        break;
//    }
//}

////int media = soma / contador;

//Console.WriteLine(soma);
//Console.WriteLine(contador);
//Console.WriteLine($"media: {media}");

// Resposta do professor: 

int nota;
int somaNotas = 0;
int qtdNotas = 0;
do
{
    Console.WriteLine("Informe uma nota: ");
    nota = int.Parse(Console.ReadLine());

    if(nota >= 0 && nota <= 10)
    {
    somaNotas = nota + somaNotas;
    qtdNotas++;
    }
} while (nota >= 0 && nota <= 10);

int media = somaNotas / qtdNotas;
Console.WriteLine(media);

