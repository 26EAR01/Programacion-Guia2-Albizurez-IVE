internal class Program
{
    private static void Main(string[] args)
    {
        char opcion;
        double valor;
        double resultado = 0;

        Console.WriteLine("CONVERSOR DE MEDIDAS");
        Console.WriteLine("a - Metros");
        Console.WriteLine("b - Pies");
        Console.WriteLine("c - Centimetros");
        Console.WriteLine("d - Pulgadas");

        Console.WriteLine("Seleccione una opcion:");
        opcion = char.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el valor a convertir:");
        valor = double.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 'a':
                resultado = valor;
                Console.WriteLine("Resultado en metros: " + resultado);
                break;

            case 'b':
                resultado = valor * 0.3048;
                Console.WriteLine("Resultado en metros: " + resultado);
                break;

            case 'c':
                resultado = valor / 100;
                Console.WriteLine("Resultado en metros: " + resultado);
                break;

            case 'd':
                resultado = valor * 0.0254;
                Console.WriteLine("Resultado en metros: " + resultado);
                break;

            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}