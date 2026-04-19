Algoritmo Ejer_en_casa_4
	definir opciones Como Caracter
	definir valores, resultado Como Real
	
	Escribir "Conversor de medidas"
	Escribir "a - Metros"
	Escribir "b - Pies"
	Escribir "c - Centimetros"
	Escribir "d - Pulgadas"
	
	Escribir "seleccione entre las opciones"
	leer opciones
	
	Escribir "Ingrese el valor a convertir"
	leer valores
	
	Segun opciones Hacer
		"a":
			resultado = valores
			Escribir "resultado en metros:", resultado
		"b":
			resultado = valores* 0.3048
			Escribir "resultado en pies:", resultado
		"c":
			resultado = valores/100
			Escribir "resultado en centimetros:", resultado
		"d":
			resultado = valores*0.0254
			Escribir "resultado en pulgadas:", resultado
		De Otro Modo:
			Escribir "opcion invalida"
	Fin Segun
FinAlgoritmo
