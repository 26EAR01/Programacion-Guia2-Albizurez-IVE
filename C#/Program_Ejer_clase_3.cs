internal class Program
{
    private static void Main(string[] args)
    {
        char letra;

        Console.WriteLine("Ingrese una letra:");
        letra = char.Parse(Console.ReadLine());

        switch (letra)
        {
            case 'A':
                Console.WriteLine("Excelente");
                break;

            case 'B':
                Console.WriteLine("Bueno");
                break;

            case 'C':
                Console.WriteLine("Regular");
                break;

            case 'D':
                Console.WriteLine("Deficiente");
                break;

            case 'F':
                Console.WriteLine("Reprobado");
                break;

            default:
                Console.WriteLine("Letra invalida");
                break;
        }
    }
}