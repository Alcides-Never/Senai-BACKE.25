
//Exibição no console (saída)
//Toda instrução tem que terminar com ;
Console.WriteLine("Hello, World!");

//Constante e Variáveis
// <tipo do dado> <nome> = <valor inicial>;
// = -> Atribuição - No exemplo abaixo, idade está recebendo 18 ou o 18 foi atribuido a variável idade.
// Variável -> O valor pode mudar.
int idade = 18;

idade = 22;
idade = 23;

Console.WriteLine(idade);

// Constantes -> O valor não muda
const int novaIdade = 24;

//novaIdade = 26;

Console.WriteLine(novaIdade);

// NUMEROS
// Principais Tipos:

// int -> Numero Inteiro
int quantidade = 5;

// double -> Números Quebrados(Números Reais) -> Comum
double preco = 12.99;

// float -> Numeros Quebrados -> Limite é muito menor e pouco usado atualmente -> Vantagem é que gasta menos memoria.
float altura = 1.80f;

// Booleano -> aceite somnte false ou true;
bool careca = false;

// Textos e Caracteres

// String -> textos
string texto  = "Olá, tudo bem? Tenho 22 anos";

//no chat, ao atribuir o valor, o mesmo será passado usando ''
char letra = 'B';

string nome = "Vinicio";
string novoNome = nome;

int numero1 = 5;
int numero2 = 2;

int resultado = numero1 + numero2;

// Operadores

// Operadores Aritméticos

// + -> Soma ou Contatena(Juntar Textos)

Console.WriteLine(5 + 4);

// Abaixo, a prioridade é o que está em aspas e o C# converte o numero 5 para texto
Console.WriteLine(5 + "5");

// - -> Subtração 
Console.WriteLine(4 - 2);

// * -> Multiplicação 
Console.WriteLine(4 * 2);

// / -> Divisao - Ao declarar, se colocar o . no numero, o C# usa como douvle. Por padrão ele usa como int
Console.WriteLine(9.0 / 2);

// As prioridades: 
// 1 - Parenteses
// 2 - Multiplicação e Divisão
// 3 - Soma e Subtração

Console.WriteLine((4 - 9) / 2.0);

// Modulo -> Resto da divisão inteira
Console.WriteLine(5 % 2);


// Operadores de Comparação

// Igual
Console.WriteLine(5 == 5);

// Diferente
Console.WriteLine(5 != 6);

// Maior 
Console.WriteLine(5 > 3);

// Maior ou Igual
Console.WriteLine(5 >= 4);

// Menor
Console.WriteLine(7 < 9);

// Menor ou Igual
Console.WriteLine(9 <= 11);

