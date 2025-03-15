// Exercícios
// 1

int numero1 = 1;
int numero2 = 2;

Console.WriteLine(numero1 + numero2);

// 2 
int numeroProduto1 = 2;
int numeroProduto2 = 3;

Console.WriteLine(numeroProduto1 * numeroProduto2);

//3
int numeroSubtracao1 = 5;
int numeroSubtracao2 = 3;

Console.WriteLine(numeroSubtracao1 - numeroSubtracao2);

//4
int numeroMedia1 = 5;
int numeroMedia2 = 3;
int numeroMedia3 = 4;

Console.WriteLine((numeroMedia1 + numeroMedia2 + numeroMedia3) / 3.0);

//5
int numeroResto1 = 90;
int numeroResto2 = 4;

Console.WriteLine(numeroResto1 % numeroResto2);

//6 - Avançado
int x = 1;
int y = 3;

x = x + y;
y = x - y;
x = x - y;

Console.WriteLine($"inversão: {x}, {y}");

//7 

int parImpar = int.Parse(Console.ReadLine());

Console.WriteLine((parImpar % 2) ^ 1);

//8 
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int maior = Math.Max(a, Math.Max(b,c));

Console.WriteLine($"O maior número é {maior}");