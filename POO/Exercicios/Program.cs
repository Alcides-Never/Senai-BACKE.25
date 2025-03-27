using Exercicios;

Livro livro1 = new Livro();

livro1.titulo = "Crime e Castigo";
livro1.autor = "Dostoievsky";
livro1.paginas = 500;

// Pode ser abreviado desta maneira: 

Livro livro2 = new Livro()
{
    titulo = "Clean Code",
    autor = "Robert Martin",
    paginas = 353
};


// 2

Aluno aluno = new Aluno();

aluno.nome = "João";
aluno.idade = 16;
aluno.notaFinal = 9.5;

Console.WriteLine(aluno.nome);
Console.WriteLine(aluno.idade);
Console.WriteLine(aluno.notaFinal);

// 3

Produto produto = new Produto();

produto.nome = "batata";
produto.quantidadeEmEstoque = 50;
produto.preco = 0.50;

Console.WriteLine(produto.CalcularTotal());
