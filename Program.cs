using CalculadoraConsola.Logica;

Operaciones calculadora = new();
Console.WriteLine("Ingrese N1");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese N2");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Seleccione: SUMA(S) RESTA(R) MULTIPLICACION(M) DIVISION (D)");
string opcion = Console.ReadLine();
int res = opcion.Equals("S") ? calculadora.Suma(n1, n2) :
          opcion.Equals("R") ? calculadora.Resta(n1, n2) :
          opcion.Equals("M") ? calculadora.Multiplicacion(n1, n2) :
          opcion.Equals("D") ? calculadora.Division(n1, n2) : 0;
Console.WriteLine("RESPUESTA " + res);
