using ExercicioHerancaEncapsulamento;
using ExercicioHerancaEncapsulamento.Conta;

// 1
ContaBancaria conta = new ContaBancaria();

conta.Depositar(50);
conta.Depositar(75.99);
Console.WriteLine(conta.VerSaldo());
conta.Sacar(30);
Console.WriteLine(conta.VerSaldo());


// 2 
Funcionario funcionario = new Funcionario();

funcionario.SetSalario(2500);
Console.WriteLine($"Salario {funcionario.GetSalario()}");

// 3

Retangulo retangulo = new Retangulo();
retangulo.SetAltura(10);
retangulo.SetLargura(20);

Console.WriteLine($"Altura: {retangulo.GetAltura()}");
Console.WriteLine($"Largura: {retangulo.GetLargura()}");

Console.WriteLine($"Area: {retangulo.CalcularArea()}");


// 4

ContaCorrente cc = new ContaCorrente();

cc.Depositar(500);
cc.Sacar(30);
Console.WriteLine(cc.VerSaldo());
cc.CobrarTaxa();
Console.WriteLine(cc.VerSaldo());    

ContaPoupanca cp = new ContaPoupanca();

cp.Depositar(5000);
cp.Sacar(50);
Console.WriteLine(cp.VerSaldo());
cp.RenderJuros();
Console.WriteLine(cp.VerSaldo());

// 5 

Gerente gerente = new Gerente();

gerente.SetSalario(5000);
gerente.Bonificar();
Console.WriteLine(gerente.GetSalario());
