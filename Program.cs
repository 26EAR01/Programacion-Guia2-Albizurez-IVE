
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Clasificacion de letras por rango");
        Console.Write("Dame una letra");
        char letra= Convert.ToChar(Console.ReadLine().ToLower());

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
                Console.WriteLine("Digite una letra entre A,B,C,D,F");
                break;
   
        }
    }
}