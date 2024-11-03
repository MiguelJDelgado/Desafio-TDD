using NewTalents;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("ola");

        Calculadora calc = new Calculadora(DateTime.Now);
        Console.WriteLine(calc.somar(1, 2));
        Console.WriteLine(calc.subtrair(3, 2));
        Console.WriteLine(calc.multiplicar(3, 2));
        Console.WriteLine(calc.dividir(4, 2));
        
        var historico = calc.historico();
        Console.WriteLine("Historico:\n\n");

        foreach (var item in historico)
        {
            Console.WriteLine(item);
        }
        
    }
}


