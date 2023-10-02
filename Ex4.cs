var caracteres = new char [10];
int qty_consoante = 0;

 for(int z = 0;z < 10;z++)
{
        Console.WriteLine("Digite uma letra para este vetor:");
        caracteres[z] = Convert.ToChar(Console.ReadLine());
}

   
for(int i = 0;i < 10;i++)
{
    if(caracteres[i] != 'a' && caracteres[i] != 'e' && caracteres[i] != 'i' && caracteres[i] != 'o' && caracteres[i] != 'u')
    {
        qty_consoante++;
        Console.WriteLine("Consoante detectada : {0}", caracteres[i]);
    }

}

Console.WriteLine("Número de consoantes detectadas: {0}",qty_consoante);
Console.ReadLine();