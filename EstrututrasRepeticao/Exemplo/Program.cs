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