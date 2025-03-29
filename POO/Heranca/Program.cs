// Herança - Classe que herda de outra

// Carro - Modelo, Marca, Quilometragem
// CarroELetrico - Bateria, Tempo de Carga
// CarroCombustão - Combustível

using Heranca;

CarroEletrico carroE = new CarroEletrico();

carroE.marca = "Tesla";
carroE.bateria = 200;

CarroCombustao carroC = new CarroCombustao();

carroC.marca = "Fiat";
carroC.combustivel = "Gasolina";

Carro meuCarro;

Console.WriteLine("Digite E - para eletrico ou Digite C - para combustão");

string opcao = Console.ReadLine();

if(opcao == "E")
{
    meuCarro = new CarroEletrico();

    if (meuCarro is CarroEletrico ce)
    {
        ce.bateria = 200;
    }
}
else if (opcao == "C")
{
    meuCarro = new CarroCombustao();
}

// Pessoa - Nome (Classe Pai)
// PessoaFisica - CPF (Classe Filho)
// PessoaJuridica - CNPJ (Classe Filho)

PessoaFisica alguem1 = new PessoaFisica();

alguem1.nome = "fulano";
alguem1.cpf = "1234567900";

PessoaJuridica  alguem2 = new PessoaJuridica();

alguem2.nome = "Cicrano";
alguem2.cnpj = "123456789000100";

Console.WriteLine(alguem1.nome);
Console.WriteLine(alguem1.cpf);

Console.WriteLine(alguem2.nome);
Console.WriteLine(alguem2.cnpj);


// Exemplo
Carro carro1 = new Carro();

CarroEletrico novoCarroE = new CarroEletrico();

carro1.modelo = "Fusca";
carro1.marca = "Volkswagen";
carro1.quilometragem = 3000;

novoCarroE.modelo = "Tesla Model S";
novoCarroE.marca = "Tesla";
novoCarroE.quilometragem = 1000;
novoCarroE.bateria = 200;
novoCarroE.tempoDeCarga = 50;

novoCarroE.MostrarInformacoes();

novoCarroE.MostrarInformacoes("Vinicio");

