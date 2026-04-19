internal class Program
{
    private static void Main(string[] args)
    {
        int sector;
        int cantidad;
        double precio = 0;
        double total;

        Console.WriteLine("Seleccione el sector:");
        Console.WriteLine("1 - Palco");
        Console.WriteLine("2 - Tribuna");
        Console.WriteLine("3 - Preferencia");
        Console.WriteLine("4 - Generales");

        sector = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese cantidad de entradas:");
        cantidad = int.Parse(Console.ReadLine());

        switch (sector)
        {
            case 1:
                precio = 300;
                break;

            case 2:
                precio = 125;
                break;

            case 3:
                precio = 75;
                break;

            case 4:
                precio = 50;
                break;

            default:
                Console.WriteLine("Sector invalido");
                break;
        }

        total = precio * cantidad;

        Console.WriteLine("Total a pagar: Q" + total);
    }
}
