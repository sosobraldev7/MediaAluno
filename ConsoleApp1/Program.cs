     float nota1, nota2, mediafinal;
   Console.WriteLine("Digite a primeira nota: ");
nota1 = float.Parse(Console.ReadLine()!);
   Console.WriteLine("Digite a segunda nota: ");
     nota2 = float.Parse(Console.ReadLine()!);
        mediafinal = (nota1 + nota2) / 2;
if (mediafinal <= 6)
{
    Console.WriteLine("Reprovado");
}
    else if (mediafinal <= 7)
{
    Console.WriteLine("Recuperação");
} 
    else 
{
    Console.WriteLine("Aprovado");
}