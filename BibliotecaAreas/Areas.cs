namespace BibliotecaAreas;

public static class Areas
{
    public static double AreaCuadrado(double lado)
    {
        return lado * lado;
    }
    public static double AreaTriangulo(double _base, double altura)
    {
        return (_base * altura) / 2;
    }
    public static double AreaCirculo(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }

}
