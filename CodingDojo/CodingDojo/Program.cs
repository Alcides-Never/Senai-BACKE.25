Console.WriteLine("Informe o nome do vendedor");
string nomeVendedor = Console.ReadLine();
Console.WriteLine("Informe o nível");
int nivelVendedor = int.Parse(Console.ReadLine());
Console.WriteLine("O valor total das vendas");
double valorVenda = int.Parse(Console.ReadLine());

double totalBonific = 0;

if (nivelVendedor == 1)
{
    if (valorVenda > 20000 && valorVenda < 50000)
    {
        totalBonific = valorVenda * 0.20;
        MensagemBonificacao(nomeVendedor, nivelVendedor, totalBonific);
    }
    else if (valorVenda > 50000 && valorVenda < 80000)
    {
        totalBonific = valorVenda * 0.35;
        MensagemBonificacao(nomeVendedor, nivelVendedor, totalBonific);
    }
    else if (valorVenda > 80000)
    {
        Console.WriteLine($"O vendedor {nomeVendedor}, nível 1 foi promovido ao nível 2!");
    }
    else if (valorVenda < 5000)
    {
        Console.WriteLine($"O vendedor {nomeVendedor} está em risco de demissão");
    }

}

else if (nivelVendedor == 2)
{
    if (valorVenda > 90000 && valorVenda < 120000)
    {
        totalBonific = valorVenda * 0.25;
        MensagemBonificacao(nomeVendedor, nivelVendedor, totalBonific);
    }
    else if (valorVenda > 120000 && valorVenda < 200000)
    {
        totalBonific = valorVenda * 0.40;
        MensagemBonificacao(nomeVendedor, nivelVendedor, totalBonific);

    }
    else if (valorVenda < 50000)
    {
        Console.WriteLine($"O vendedor {nomeVendedor}, nivel 2, está em risco de virar nivel 1");
    }

}

else if (nivelVendedor == 3)
{
    if (valorVenda > 210000 && valorVenda < 250000)
    {
        totalBonific = valorVenda * 0.30;
        MensagemBonificacao(nomeVendedor, nivelVendedor, totalBonific);
    }
    else if (valorVenda > 250000 && valorVenda < 500000)
    {
        totalBonific = valorVenda * 0.45;
        MensagemBonificacao(nomeVendedor, nivelVendedor, totalBonific);

    }
    else if (valorVenda > 500000)
    {
        Console.WriteLine($"O vendedor {nomeVendedor} nivel 3, virou o dono da firma"); ;

    }
    else if (valorVenda < 100000)
    {
        Console.WriteLine($"O vendedor {nomeVendedor}, nivel 3, está em risco de virar nivel 2");
    }

}

void MensagemBonificacao(string nomeVendedor, int nivel, double totalBonificacao)
{

    Console.WriteLine($"O vendedor {nomeVendedor}, nivel {nivel}, devera receber uma bonificação de R${totalBonificacao}");

}
