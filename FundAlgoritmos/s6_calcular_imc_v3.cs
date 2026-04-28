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
imc = CalcularIMC(peso, altura);
if(imc > 0)
{
    Console.WriteLine("Usted tiene un imc de: " + imc);
}

double CalcularIMC(double peso, double altura)
{
    double imc = 0.0;
    // validar datos de entrada
    bool valido = ValidarEntrada(peso, altura);
    if(valido == true)
    {
        imc = peso / Math.Pow(altura, 2);
    }
    else
    {
        Console.WriteLine("Datos de entrada no válido");
    }
    return imc;
}

bool ValidarEntrada(double peso, double altura)
{
    bool valido = false;
    if(peso <= 400 && peso >= 5)
    {
        if(altura <= 2.5 && altura >= 0.6)
        {
            valido = true;
        }
        else
        {
            Console.WriteLine("Altura inválida");
            valido = false;
        }
    }else
    {
        Console.WriteLine("Peso inválido");
        valido = false;
    }
    return valido;
}