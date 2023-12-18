

using HerancaPolimorfismoExercicio.Entities;
using HerancaPolimorfismoExercicio.Entities.Enums;

class Program
{
    static void Main(string[] args)
    {
        Circle circulo = new Circle(12.4, Color.BLACK);

        Console.WriteLine(circulo.Area());
    }
}
