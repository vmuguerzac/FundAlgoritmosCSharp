// Declaracion
// Recordar arrays son de tamaño definido
int[] nums = new int[5]; // arreglo de 5 elementos
String[] nom = new String[5]; 

Console.WriteLine(nums[4]); // Sale 0
Console.WriteLine(nom[4]); // Sale null

int[] nums2 = {3, 2, 4, 1, 5};
string[] nombres = new string[] {"Alicia", "Bob", "Carolina"};

// Agregar un valor
nums[1] = 100;
// Acceder a un valor
Console.WriteLine(nums[1]);
// Modificar un valor
nums[1] = 50;
Console.WriteLine(nums[1]);

Console.WriteLine("Mostar los datos de un array");
// Mostrar un array
for(int i = 0;i < nums2.Length; i++)
{
    Console.WriteLine(nums2[i]);
}

// Busqueda Lineal
// Encontrar si el valor 1 está en el array nums2
int valor_a_buscar = 200;
bool encontrado = false;
// Recorrer
for(int i = 0;i < nums2.Length; i++)
{
    if(nums2[i] == valor_a_buscar)
    {
        Console.WriteLine("Valor encontrado");
        encontrado = true;
        break;
    }
}
if(encontrado == false)
{
    Console.WriteLine("Valor no encontrado");
}

// Ordenamiento