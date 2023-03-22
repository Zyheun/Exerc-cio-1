// See https://aka.ms/new-console-template for more information
int pontos = 3;
Console.WriteLine("quanto é 2+2");
int numero1 = Convert.ToInt32(Console.ReadLine());
if(numero1 == 4)
{
    Console.WriteLine("Parabéns você acertou!");
}
else
{
    Console.WriteLine("Tente novamente!");
}


Console.WriteLine("quanto é 3+3");
int numero2 = Convert.ToInt32(Console.ReadLine());
if (numero2 == 6)
{
    Console.WriteLine("Parabéns você acertou!");
}
else
{
    Console.WriteLine("Tente novamente!");
}
Console.WriteLine("quanto é 4+4");
int numero3 = Convert.ToInt32(Console.ReadLine());
if (numero3 == 8)
{
    Console.WriteLine("Parabéns você acertou!");
}
else
{
    Console.WriteLine("Tente novamente!");

}
if (pontos == 3)
{
    Console.WriteLine("Parabéns você fez 3 pontos");
}