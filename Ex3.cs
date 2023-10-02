var nota = new int [4];
int soma = 0;

for(int i = 0;i < 4; i++)
{
    Console.WriteLine("Digite a nota {0}:",(i+1));
    nota[i] = Convert.ToInt16(Console.ReadLine());
    soma += nota[i];
}

for(int i = 0;i < 4;i++)
Console.WriteLine("Nota {0}: {1}",(i+1),nota[i]);

Console.WriteLine("Média das notas :{0}",(soma/4));
Console.ReadLine();