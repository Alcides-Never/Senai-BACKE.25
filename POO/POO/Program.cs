// Listas
using POO;

string[] nome = new string[5];  // -> Vetor / Possui limitação e no exemplo aqui são 5

// Generico
List<string> listaDeNomes = new List<string>();

List<string> listaDeNomes2 = new();

listaDeNomes.Add("Vinicio");
listaDeNomes.Add("Fulano");
listaDeNomes.Add("Cicrano");


foreach (var item in listaDeNomes)
{
    Console.WriteLine(item);
}

listaDeNomes.Remove("Vinicio");

// POO
// POO - Programação Orientada a objetos

// Programação Estruturada. -> O código roda da primeira linha té o final
// Problema é que o código fica muito grande e insustentável para manutenção

// POO -> Objetivo - Aproximar a Programação do Mundo Real
// Separar nossos Sistemas em partes Menores

// Classes e Objetos

// Classe - Definição (Item da vida real representando em código)
// Exemplo, como podemos definir um carro para um sistema de gerencimento de carros.
// Toda classe tem: 
// Atributos (características) - Metodos (ações)


// Objeto - Instância de uma classe
Carro carro1 = new Carro(); //-> criado variavel que irá guardar o carro mas não tem nada e só passa a existir quando se cria o new Carro

// Para acessar informações do Objeto eu uso o "."
carro1.modelo = "HB20";
carro1.marca = "Hyundai";
carro1.anoFabricacao = 2024;

carro1.Andar();
carro1.Parar();


// Crie mais 2 carros (Objetos)

Carro carro2 = new Carro();
Carro carro3 = new Carro();

carro2.modelo = "Corolla";
carro2.marca = "Toyota";
carro2.anoFabricacao = 2025;

carro3.modelo = "Civic";
carro3.marca = "Honda";
carro3.anoFabricacao = 2025;

List<Carro> carros = new List<Carro>();

carros.Add(carro1);
carros.Add(carro2);
carros.Add(carro3);


Console.WriteLine(carro3.modelo);
Console.WriteLine(carro3.marca);
Console.WriteLine(carro3.anoFabricacao);


// Continuaç!ao Aula
// Programação Orientada a Objetos
// 4 Pilares da POO

// Classe e Objeto
// Classe - Definição (Molde)
// Objeto - Instância da Classe

// Ferramentas - Formas de trabalhar com POO

// Encapsulamento e Herança

// Sobre Encapsulamento - Esconder comportamento e atributos
// Evitar que sejam acessados diretamente
// Conta Bancaria (saldo) -> Caso a conta seja encapsulada, não pode ser acessado diretamente
// Sacar() - Depositar() -> podem acessar o saldo
// porém se tentarmos acessar via conta.saldo pois o mesmo está encapsulado

// Vantagens: 
// 1 - Esconder atributo/método/classe
// 2 - Defino regras para alteração ou listagem

// No CSharp, o encapsulamento são:
// public - Esse atributo/método/classe pode ser acessado por qualquer um. Obs* Toda classe por padrão é publica.
// private - Este atributo/método/classe só pode ser acessado dentro dele mesmo
// protected/internal - Este atributo/método/classe só pode ser acessado por ele mesmo e por sua classe pai

Carro carro4 = new Carro();

carro4.SetModelo("HB20");
Console.WriteLine(carro4.GetModelo());