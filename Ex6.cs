var nota = new double [10,4];
var media = new double [10];
int mediaMaior = 0;

for(int i = 0;i < 10; i++)
{
    for(int j = 0; j < 4; j++)
    {
        Console.WriteLine("Digite o valor da nota {0} do aluno {1}:",(j+1),(i+1));
        nota[i,j] = Convert.ToDouble(Console.ReadLine());
        media[i] += nota[i,j];
    }
    media[i] = media[i]/4;

    if(media[i] >= 7)
    {
        mediaMaior++;
    }

}

Console.WriteLine("{0} alunos ficaram na média ou acima da média", mediaMaior);
Console.ReadLine();