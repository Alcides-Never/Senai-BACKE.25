using ExercicioHerancaEncapsulamento;

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


// 4

