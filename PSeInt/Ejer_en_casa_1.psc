Algoritmo Ejer_en_casa_1
	Definir angulo, resultado, pii Como Real
	definir opciones Como Entero
	
	pii=3.1416
	
	Escribir "Ingrese el angulo en grados:"
	Leer angulo
	
	Escribir "Seleccione una funcion:"
	Escribir "1 - Seno"
	Escribir "2 - Coseno"
	Escribir "3 - Tangente"
	Leer opciones
	
	Segun opciones Hacer
		1:
			resultado = sen(angulo*pii/180)
			escribir "El seno es:", resultado
		2:
			resultado = cos(angulo*pii/180)
			escribir "El coseno es:", resultado
		3:
			resultado = tan(angulo*pii/180)
			escribir "El tangente es:", resultado
		De Otro Modo:
			Escribir "opciones invalidad"
	Fin Segun
	
FinAlgoritmo
