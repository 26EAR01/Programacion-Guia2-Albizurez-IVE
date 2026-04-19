internal class Program
{
    private static void Main(string[] args)
    {
        int mes;

        Console.WriteLine("Ingrese un numero del 1 al 12:");
        mes = int.Parse(Console.ReadLine());

        switch (mes)
        {
            case 1:
                Console.WriteLine("Enero - 31 dias");
                break;

            case 2:
                Console.WriteLine("Febrero - 28 dias");
                break;

            case 3:
                Console.WriteLine("Marzo - 31 dias");
                break;

            case 4:
                Console.WriteLine("Abril - 30 dias");
                break;

            case 5:
                Console.WriteLine("Mayo - 31 dias");
                break;

            case 6:
                Console.WriteLine("Junio - 30 dias");
                break;

            case 7:
                Console.WriteLine("Julio - 31 dias");
                break;

            case 8:
                Console.WriteLine("Agosto - 31 dias");
                break;

            case 9:
                Console.WriteLine("Septiembre - 30 dias");
                break;

            case 10:
                Console.WriteLine("Octubre - 31 dias");
                break;

            case 11:
                Console.WriteLine("Noviembre - 30 dias");
                break;

            case 12:
                Console.WriteLine("Diciembre - 31 dias");
                break;

            default:
                Console.WriteLine("Mes invalido");
                break;
        }
    }
}