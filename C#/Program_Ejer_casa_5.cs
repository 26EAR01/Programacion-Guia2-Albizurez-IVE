internal class Program
{
    private static void Main(string[] args)
    {
        int cantidad;
        int formaPago;

        double precioUnitario = 650;
        double precioIVA;
        double totalSinDescuento;
        double descuento = 0;
        double totalFinal;

        Console.WriteLine("Ingrese cantidad de impresoras:");
        cantidad = int.Parse(Console.ReadLine());

        Console.WriteLine("Seleccione forma de pago:");
        Console.WriteLine("1 - Efectivo (10%)");
        Console.WriteLine("2 - Tarjeta de credito (5%)");
        Console.WriteLine("3 - Vale de regalo (15%)");

        formaPago = int.Parse(Console.ReadLine());

        precioIVA = precioUnitario * 1.12;

        totalSinDescuento = precioIVA * cantidad;

        switch (formaPago)
        {
            case 1:
                descuento = totalSinDescuento * 0.10;
                Console.WriteLine("Forma de pago: Efectivo");
                break;

            case 2:
                descuento = totalSinDescuento * 0.05;
                Console.WriteLine("Forma de pago: Tarjeta de credito");
                break;

            case 3:
                descuento = totalSinDescuento * 0.15;
                Console.WriteLine("Forma de pago: Vale de regalo");
                break;

            default:
                Console.WriteLine("Forma de pago invalida");
                break;
        }

        totalFinal = totalSinDescuento - descuento;

        Console.WriteLine("Cantidad de impresoras: " + cantidad);
        Console.WriteLine("Precio unitario con IVA: Q" + precioIVA);
        Console.WriteLine("Total sin descuento: Q" + totalSinDescuento);
        Console.WriteLine("Descuento aplicado: Q" + descuento);
        Console.WriteLine("Total a pagar: Q" + totalFinal);
    }
}