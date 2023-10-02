var numint = new int [20];

for(int i = 0; i < 20; i++)
{
    Console.WriteLine("Digite um valor para a posição {0}:",(i+1));
    numint[i] = Convert.ToInt16(Console.ReadLine());
}

var numpar = new int [20];
var numimpar = new int [20];

for(int i = 0; i < 20; i++)
{
    if(numint[i]% 2 == 0)
    numpar[i] = numint[i];
    else
    numimpar[i] = numint[i];
}

for(int i = 0; i < 20; i++)
Console.WriteLine("Números inteiros digitados: {0}",numint[i]);

for(int i = 0; i < 20; i++)
{
    if(numpar[i] != 0)
    Console.WriteLine("Números pares: {0}",numpar[i]);
}

for(int i = 0; i < 20; i++)
{
    if(numimpar[i] != 0)
    Console.WriteLine("Números impar: {0}",numimpar[i]);
}


Console.ReadLine();