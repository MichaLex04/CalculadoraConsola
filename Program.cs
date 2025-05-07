using 

Calculadora calculadora = new();
Console.WriteLine("Ingrese N1");
int n1=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese N2");
int n2=int.Parse(Console.ReadLine());
Console.WriteLine("Seleccione: SUMA S/nRESTA R/nMULTIPLICACION M/nDIVISION D");
string opcion=Console.ReadLine();
int res = opcion.equals("S") ? Calculadora.Suma(n1, n2) : 
          opcion.equals("R") ? Calculadora.Resta(n1, n2) :
          opcion.equals("M") ? Calculadora.Multiplicacion(n1, n2) :
          opcion.equals("D") ? Calculadora.Division(n1, n2) : 0;
Console.WriteLine("RESPUESTA "+res);