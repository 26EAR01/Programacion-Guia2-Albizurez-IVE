Algoritmo Ejer_en_casa_5
	Definir cantidad, formaPago Como Entero
	definir precioUnitario, precioIVA, totalsindescuento, descuento, totalfinal Como Real
	
	preciounitario = 650
	
	Escribir "Ingrese la cantidad de impresoras:"
	Leer cantidad
	
	Escribir "seleccione la forma de pago"
	Escribir "1 - Efectivo 10%"
	Escribir "2 - Tarjeta de crédito 5%"
	Escribir "3 - Vale de regalo 15%"
	leer formaPago
	
	precioIVA = preciounitario * 1.12
	totalsindescuento = precioIVA * cantidad
	
	Segun formaPago Hacer
		1:
			descuento = totalsindescuento * 0.10
			Escribir  "Forma de pago: Efectivo"
		2:
			descuento = totalsindescuento * 0.5
			Escribir "Froma de pago: Tarjeta de credito"
		3:
			descuento = totalsindescuento * 0.15
			Escribir "Forma de pago: Vale de regalo"
		De Otro Modo:
			Escribir 	"Forma de pago invalida"
	Fin Segun
	
	totalfinal = totalsindescuento - descuento
	
	Escribir "cantidad de impresoras:", cantidad
	Escribir "Precio unitario con IVA: Q", precioIVA
	Escribir "Total sin descuento: Q", totalsindescuento
	Escribir "Descuento aplicado: Q", descuento
	Escribir "total a pagar: Q", totalfinal
FinAlgoritmo
