Algoritmo Ejer_en_clase_2
	definir n1, n2 Como Real
	Escribir "ingrese el primer numero"
	Leer n1
	Escribir "ingrese el segundo numero"
	leer n2
	
	Escribir "1 suma"
	Escribir "2 resta"
	Escribir "3 division"
	escribir "4 multiplicacion"
	leer opciones 
	
	Segun opciones Hacer
		1:
			Escribir "resultado:", n1+n2
		2:
			Escribir "resultado:", n1-n2
		3:
			Escribir "resultado:", n1/n2
		4: 
			Escribir "resultado:", n1*n2
		De Otro Modo:
			Escribir "opcion invalida"
	Fin Segun
	
	
FinAlgoritmo
