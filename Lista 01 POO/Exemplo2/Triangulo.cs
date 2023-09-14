public class Triangulo
{
    public double ladoA;

    public double ladoB;

    public double ladoC;

    public double p;

    public double area;

    public void Formula()
    {
        p = (ladoA + ladoB + ladoC) / 2;
        area = Math.Sqrt(p *(p - ladoA)*(p - ladoB)*(p - ladoC));
       Console.WriteLine($"O valor do triangulo é: {area}");
    }
}