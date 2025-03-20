// Estruturas Condicionais

// Estruturas de Repetição
// Repete uma ação

// Cenário: Imprimir todos os números de 1 a 5

// Estrutura -> Enquanto - While
// Usaremos para imprimir os numeros de 1 a 5

int numero = 1;

// O que faz: Repete uma ação, ENQUANTO algo for verdade
while (numero < 6)
{
    Console.WriteLine(numero);
    //numero = numero + 1;
    numero++;
}

// Faça - Enquanto (Do/While)

//Console.WriteLine("Informe a idade: ");
//int idade = int.Parse(Console.ReadLine());

//while (idade != 22)
//{
//    Console.WriteLine("Informe a idade: ");
//    idade = int.Parse(Console.ReadLine());
//}

int idade;
do
{
    Console.WriteLine("Informe a idade: ");
    idade = int.Parse(Console.ReadLine());
} while (idade != 22);


// Para - FOR
// Quero imprimir os números do 1 ao 5

// 1 - Cria uma chave chamada i (indice)
// 2 - Condição para continuar
// 3 - Incremento ao executar as chaves

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(i);
}


// Tratamento de Exceções
int numero = int.Parse(Console.ReadLine());

// Exception -> Tem várias categorias de erro
// IOException -> Um das categorias do exception - In and Out - Entrada e Saída
// FormatException - Um dos erros dentro da IOException sendo um tipo específico - Erros no formato (tipo de dado)

// try/catch - Tentar / Pegar -> Uma das formas de tratamento de erro, exemplo abaixo
// Breakpoint

StreamReader reader = null;
try
{
    reader = new StreamReader("/meuarquivo.txt");
    int num = int.Parse(Console.ReadLine());
}
catch (FormatException ex)
{
    Console.WriteLine("Erro: Informe apenas números");
} catch (OverflowException ex)
{
    Console.WriteLine("Erro: número muito grande");
}
finally
{
    reader.Close();
}

int idade = int.Parse(Console.ReadLine());

if (idade > 120)
{
    throw new ArgumentOutOfRangeException("Idade Invalida");
}

// Continuação
// Sempre espero o pior do seu usuário, náo deixe brecha para que erros possam ocorrer.
// Ao colocar o ponteiro do mouse dentro da instrução, irá aparecer os possíveis exceptions na tela

try
{
    int number = int.Parse(Console.ReadLine());
}
catch (FormatException ex)
{
    Console.WriteLine("Erro: Apenas números são aceitos");
}

int idade = int.Parse(Console.ReadLine());

if (idade < 0)
{
    throw new ArgumentOutOfRangeException("Idade não pode ser negativa");
}


// Fundamentos de Programação 
// Vetores (Arrays) e Listas
// Funções

// Coding Dojo

// Vetores
// Pegar 5 idades
int idade1;
int idade2;
int idade3;
int idade4;
int idade5;

// Conjunto de informações/dados
// Vetor/Array - Tem um limite
int[] idades = new int[5];

string[] nomes = new string[10];

// Crio o Vetor e dou um nome
// <TIPO>[] idades;

// Inicializo o Vetor
// new <TIPO>[<QUANTIDADE>];


// Como funciona um vetor?
// Funciona por base da Posição

// Posição
// 0 1 2 3 4 5 6 7 8 9
nomes[0] = "Vinicio";

Console.WriteLine(nomes[0]);

nomes[1] = Console.ReadLine();

idades[4] = 26;


// FOR - Percorrer Listas/Vetores
// Cadastrar todos os nomes
for (int i = 0; i < 5; i++)
{
    //Console.WriteLine(i);
    Console.WriteLine("Insira um nome: ");
    nomes[i] = Console.ReadLine();
}

// Listar todos os nomes
for (int i = 0;i < 10; i++)
{
    Console.WriteLine(nomes[i]);
}

// Para cada
foreach (var item in nomes)
{
    Console.WriteLine(item);
}

// Os dois acimas são a mesma coisa

// Cria um vetor de idades com 4 posições
// Use um for para preencher as idades
// Use for para mostrar cada nome da lista