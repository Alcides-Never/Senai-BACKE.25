string[] nomes = new string[15];

nomes[0] = "Vinicio";
nomes[3] = "Fulado";

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine("Informe o nome: ");
    nomes[i] = Console.ReadLine();
}

// 1 - Listando com o for
for (int i = 0;i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i]);
}

// 2 - Listando com o foreach -> Apenas para exibição, não funciona para captura
foreach (var item in nomes)
{
    Console.WriteLine(item);
}

int[] idades = new int[3];

idades[0] = 22;
idades[1] = 26;
idades[2] = 30;

int[] idades2 = [22,26,30]; 
