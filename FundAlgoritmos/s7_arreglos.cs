public class s7_arreglos
{
    public static void Main(String[] args)
    {
        int[] notas = new int[5]; // Creacion de un arreglo de 5 posiciones
        notas[0] = 15;
        notas[1] = 18;
        notas[2] = 12;
        notas[3] = 20;
        notas[4] = 11;
        //notas[5] = 10; lanza una excepcion por cantidad de elementos
        Console.WriteLine("============== Reporte de Notas ==============");
        Console.WriteLine("Las notas son: ");
        ImprimirArray(notas);
        int[] edades = new int[3];
        edades[0] = 18;
        edades[1] = 26;
        edades[2] = 30;
        Console.WriteLine("============== Reporte de Edades ==============");
        Console.WriteLine("Las edades son: ");
        ImprimirArray(edades);
    }  

    static void ImprimirArray(int[] arreglo){
        if(arreglo.Length == 0){
            Console.WriteLine("No hay valores en el arreglo");
        }else{
            // For Var Control; condicion; actualizacio
            for(int i = 0; i < arreglo.Length; i++){
                Console.WriteLine("Valor " + (i+1) + ": " + arreglo[i]);      
            }
        }
    }  
}




