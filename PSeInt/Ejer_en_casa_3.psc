Algoritmo Ejer_en_casa_3
	Definir sector, cantidad Como Entero
	definir precio, total Como Real
	
	Escribir "seleccione sector"
	Escribir "1 Palco"
	Escribir "2 Tribuna"
	Escribir "3 Preferemcia"
	Escribir "4 General"
	leer sector
	
	Escribir "Ingrese cantidad de entradas:"
	leer cantidad
	
	Segun sector Hacer
		1:
			precio=300
		2:
			precio=125
		3:
			precio=75
		4:
			precio=50
		De Otro Modo:
			Escribir "sector invalido"
	Fin Segun
	
	total = precio*cantidad
	Escribir "total a pagar: Q",total
FinAlgoritmo
