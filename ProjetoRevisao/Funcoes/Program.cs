// Funções
// C -> Programação estrutura. 

// Fazer uma multiplicação entre dois numeros

// Criei uma função chamada FazerMultiplicação -> Toda função tem uma estrutura:
// <TIPO DE RETORNO> <NOME DA FUNCAO> () { Z}

double FazerMultiplicacao()
{
    int num1 = 7;
    int num2 = 5;

    double resultado = num1 * num2;

    return resultado; // -> o que vai sair da função é aqui
}

// Retorno - A saida da função

// Chamando a função
FazerMultiplicacao(); // Aqui chamando a função mas aqui o resultado vai para o espaço

Console.WriteLine(FazerMultiplicacao()); // Aqui está sendo exibido em conjunto com o writeLine

double
    resultadoFinal =
        FazerMultiplicacao(); // Aqui vocë está atribuindo o resultado da função a alguma variável como o resultado final.

// Quero multiplicar e com o resultado subtrair 2

double resultadoMult = FazerMultiplicacao();

double subtraido = resultadoMult - 2;

// Preciso fazer varias multiplicações
// Parenteses - Entradas da Função (O que ela recebe)
double Multiplicar(double numero1, double numero2)
{
    double resultado = numero1 * numero2;

    return resultado;
}

Multiplicar(2, 4);

Multiplicar(3, 5);

Console.WriteLine(Multiplicar(2, 4));
Console.WriteLine(Multiplicar(10, 10));

int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine(Multiplicar(n1, n2));

// Crie uma função de Soma

//int FazerSoma(int num1, int num2)
int FazerSoma(int num1, int num2)
{
    num1 = int.Parse(Console.ReadLine());
    num2 = int.Parse(Console.ReadLine());

    int resultado = num1 + num2;

    return resultado;
}

Console.WriteLine(FazerSoma(2, 3));
