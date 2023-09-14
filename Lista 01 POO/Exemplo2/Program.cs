public class Program
{
    static void Main(String[] args)
    {
        Triangulo triangulo = new Triangulo();
        Console.WriteLine($"Digite o valor do lado A do triangulo {triangulo.ladoA}:");
        triangulo.ladoA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Digite o valor do lado B do triangulo {triangulo.ladoB}:");
        triangulo.ladoB = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Digite o valor do lado C do triangulo {triangulo.ladoC}:");
        triangulo.ladoC = Convert.ToDouble(Console.ReadLine());

        triangulo.Formula();
        
    }
}