Console.Write("Digite um número de 1 a 9: ");
if(!int.TryParse(Console.ReadLine(), out var numb))
{
    Console.WriteLine("Preciso de um número inteiro de 1 a 9...");
}
else
{
    Verifica1a9();
}
void Verifica1a9()
{
    if (numb < 1 || numb > 9)
    {
        Console.WriteLine("Entre 1 e 9 por favor");
    }
    else
    {
        Console.WriteLine("Você escolheu o {0}.\n\n" +
        "Tome-lhe a tabuada do {0}:\n", numb);
        ImprimeTabuada();
    }
}
void ImprimeTabuada()
{
    for (int i = 1; i <= 10; i++)
        Console.WriteLine("{0} X {1} = {2}", numb, i, (numb * i));
}
