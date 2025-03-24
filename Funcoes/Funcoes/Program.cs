// Funcoes
// Ações - Passos - Funcionalidades

// Mostre uma mensagem de Boa noite
// Função com retorno

// parametro
string MostrarMensagem (string nome)
{
    string mensagem = "Boa noite!" + nome;

    return mensagem;
}

string nomeUsuario = Console.ReadLine();

Console.WriteLine(MostrarMensagem(nomeUsuario));

string mensagemBoaNoite = MostrarMensagem("Vinicio");
Console.WriteLine(mensagemBoaNoite + "Seja bem vindo!");

// Função sem Retorno
// Função que exibe a idade

void ExibirIdade(int idade)
{
    Console.WriteLine("A idade da pessoa é " + idade);
}

ExibirIdade(26);