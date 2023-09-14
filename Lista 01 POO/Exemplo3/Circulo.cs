public class Circulo
{
    public double area;

    public double raio;

    public void Formula()
    {
        area = Math.PI * raio;
        Console.WriteLine($" A area do circulo é {area}");
    }
}