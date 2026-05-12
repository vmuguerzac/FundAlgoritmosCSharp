// Ordenamiento por burbuja
int[] arreglo = [20, 50, 12, 16, 21, 38, 44];
int n = arreglo.Length;

for (int i=0; i<n-1; i++)
{
    for(int j=0; j < n-i-1; j++)
    {
        if(arreglo[j] > arreglo[j + 1])
        {
            (arreglo[j], arreglo[j + 1]) = (arreglo[j+1], arreglo[j]); //swap
        }
    }
}
Console.WriteLine("Arreglo despues de ordenar");
for(int i = 0; i < n; i++)
{
    Console.Write(arreglo[i] + ", ");
}