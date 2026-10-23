using company.ClassLibrary1;

using var context = new AppDbContext();
var servicio = new ProductoService(context);

servicio.Agregar("Cs",20000);
servicio.Agregar("Cv-47 bloodsport",15000);
servicio.Agregar("Karambit Blue gem",100000);

Console.WriteLine("------------Lista de productos------------\n");

foreach(var p in servicio.ObtenerTodos())
{
    Console.WriteLine($"{p.Id} - {p.nombre} - ${p.Precio}");
}


