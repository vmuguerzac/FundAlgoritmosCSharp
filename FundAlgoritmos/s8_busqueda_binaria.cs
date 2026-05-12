int[] arreglo = [20, 50, 12, 16, 21, 38, 44];
// Precondicion, arreglo debe estar ordenado
Array.Sort(arreglo); // Ordenar 
for(int i=0; i<arreglo.Length; i++)
{
    Console.Write(arreglo[i] + ", ");
}
int valor_buscado = 21;
int izq = 0; // Inicio del arreglo
int der = arreglo.Length - 1; // Fin del arreglo
int mit = -1;
bool encontrado = false;

while(izq <= der){
    // Determinar la mitad
    mit = (izq + der)/2;
    // Comparacion
    if(arreglo[mit] == valor_buscado){
        encontrado = true;
        break;
    }else if (arreglo[mit] < valor_buscado){
        izq = mit + 1;
    }else{
        der = mit - 1;
    }
}
if(encontrado == true){
    Console.WriteLine("Encontrado en indice: " + mit);
}
else{
    Console.WriteLine("Valor no encontrado");
}

