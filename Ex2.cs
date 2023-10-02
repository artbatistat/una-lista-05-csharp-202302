var vetor = new int [10];

for(int i = 0;i < 10;i++)
{
    Console.WriteLine("Digite o valor para a posição {0} do vetor:",i);
    vetor[i] = Convert.ToInt16(Console.ReadLine());
}

for(int i = 9;i >= 0;i--)
Console.WriteLine("Posição do vetor: {0} \nValor : {1}",i,vetor[i]);

Console.ReadLine();



