//Consigna: Cálcular el ÁREA de un CÍRCULO DE 2 METROS DE RADIO. O sea cuánto mide lo de adentro de un círculo

//Introducción

var bienvenida = "Este es un programa que cálcula el área de un círculo";
var presionar = "Presione cualquier tecla para continuar";

Console.WriteLine(bienvenida + "\n" + "\n" + presionar);
Console.ReadKey();
Console.Clear();

//Constante PI
const float Pi = 3.1416f;

//Funcionalidad
int areaEnMts;
Console.WriteLine("Ingresar el radio del círculo en m2" + "\n");
areaEnMts = int.Parse(Console.ReadLine());
Console.Clear();

//Operación Lógica
var operacion = areaEnMts * areaEnMts * Pi;
var resultado = "El Área del Círuclo es de:";
Console.WriteLine(resultado + "\n" + operacion);

