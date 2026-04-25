//Programa que permite calcular el IMC
//Declarar las variables
double peso;
double altura;
double imc;
//Obntener datos del usuario
Console.WriteLine("Ingrese su peso (KG): ");
peso = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su altura (m): ");
altura = double.Parse(Console.ReadLine());
// calcular el IMC
imc = peso / Math.Pow(altura, 2);
//Mostar la informacion al usuario
Console.WriteLine("Su imc es: " + imc);
