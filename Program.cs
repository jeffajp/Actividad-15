Dictionary<int, Producto> productos = new Dictionary<int, Producto>();


int opcion = 0;
do
{
    Console.WriteLine("1. agregar producto: ");
    Console.WriteLine("2. modificar producto");
    Console.WriteLine("3. eliminar producto: ");
    Console.WriteLine("4. buscar producto: ");
    Console.WriteLine("5. mostrar todos los producto: ");
    Console.WriteLine("6. registrar ventas: ");
    Console.WriteLine("7. registrar compra o ingreso de inventario: ");
    Console.WriteLine("8. mostrar el prodcuto mas caro: ");
    Console.WriteLine("9. mostrar el producto con menor existencia: ");
    Console.WriteLine("10. mostrar el valor total del inventario: ");
    Console.WriteLine("11. salir: ");

    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
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
 
            break;
        case 2:
            Console.WriteLine("ingrese el codigo del producto a modificar: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el nuevo producto: ");

            if (productos.ContainsKey(nuevo))
            {
                Console.WriteLine("codigo encontrado: ");
                productos[codigo] = nuevoproducto;
            }
           
            break;
        case 3:
            Console.WriteLine("ingrese el codigo del producto que desea eliminar: ");
            int codigo = int.Parse(Console.ReadLine());
            if(productos.ContainsKey(codigo))
            {

            }

            break;
        case 4:
            Console.WriteLine("ingrese el codigo del producto que desea buscar: ");
            break;
        case 5:
            Console.WriteLine("los productos registrados son: ");
            break;
        case 6:
            Console.WriteLine("registrar venta: ");
            break;
        case 7:
            Console.WriteLine("ingrese los productos que compro o ingrese los productos agregar: ");
            break;
        case 8:
            Console.WriteLine("el producto mas caro en la tienda es: ");
            break;
        case 9:
            Console.WriteLine("el prodcuto con menos unidades de existencia es: ");
            break;
        case 10:
            Console.WriteLine("el valor total de los productos en el inventario es: ");
            break;
        default:
            Console.WriteLine("ingreso una opcion invalida: ");
            break;
            

    }
    Console.ReadLine();



} while (opcion != 0);



/*Dictionary<int, Producto> productos = new Dictionary<int, Producto>();
Console.WriteLine("ingrese cuantos productos desea guardar: ");
int n = int.Parse(Console.ReadLine());
*/
            /*for(int i=0; i<n; i++)
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
            */

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