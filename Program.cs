

Calculadora calc = new();
Console.WriteLine("Ingrese N1");
int n1=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese N2");
int n2=int.Parse(Console.ReadLine());
Console.WriteLine("Seleccione: SUMA S/nRESTA R/nMULTIPLICACION M/nDIVISION D");
string opcion=Console.ReadLine();
int res = opcion.equals("S") ? calc.Sumar(n1, n2) : 
          opcion.equals("R") ? calc.Restar(n1, n2) :
          opcion.equals("M") ? calc.Multiplicar(n1, n2) :
          opcion.equals("D") ? calc.Dividir(n1, n2) : 0;
Console.WriteLine("RESPUESTA "+res);