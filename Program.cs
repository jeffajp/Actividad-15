
int opcion = 0;
do
{
    Console.WriteLine("1. agregar producto: ");
    Console.WriteLine("2. modificar producto");
    Console.WriteLine("1. eliminar producto: ");
    Console.WriteLine("1. agregar producto: ");
    Console.WriteLine("1. agregar producto: ");
    Console.WriteLine("1. agregar producto: ");
    Console.WriteLine("1. agregar producto: ");
    Console.WriteLine("1. agregar producto: ");
    Console.WriteLine("1. agregar producto: ");
    Console.WriteLine("1. agregar producto: ");
    Console.WriteLine("1. agregar producto: ");


} while (opcion != 0);



Dictionary<int, Producto> productos = new Dictionary<int, Producto>();
Console.WriteLine("ingrese cuantos productos desea guardar: ");
int n = int.Parse(Console.ReadLine());
for(int i=0; i<n; i++)
{
    Console.WriteLine("ingrese el codigo del producto: ");
    int codigo = int.Parse(Console.ReadLine());
    Producto p = new Producto();
    Console.WriteLine("ingrese el nombre del producto: "); p.Nombre = Console.ReadLine();
    Console.WriteLine("ingrese el precio del producto: "); p.Precio = double.Parse(Console.ReadLine());
    Console.WriteLine("ingrese la cantidad fisica: "); p.CantidadExistente = int.Parse(Console.ReadLine());
    productos[codigo] = p;

}
foreach(KeyValuePair<int, Producto> item in productos)
{
    Console.WriteLine($"codigo: {item.Key}");
    item.Value.MostrarDatos();
    
}

class Producto
{
    public string Nombre;
    public double Precio;
    public int CantidadExistente;

    public void MostrarDatos()
    {
        Console.WriteLine($"Producto: {Nombre}--Precio: {Precio}-- Cantidad: {CantidadExistente}");
    }
   
    
}