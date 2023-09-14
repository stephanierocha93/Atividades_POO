public class Program
{
    static void Main(string[] args)
    {
        Circulo circulo = new Circulo();
        Console.WriteLine($"Para calcular a Area digite o valor do raio do circulo:");
        circulo.raio = Convert.ToDouble( Console.ReadLine());

        circulo.Formula();
    }
}

