string nombre;
string correo;
string[] correo_modificado;
Console.Write("Ingresa tu nombre: ");
 nombre = Console.ReadLine();
Console.WriteLine("---------Bienvenido {0} -----", nombre);

Console.Write("Ingresa un correo de tipo gmail: ");
correo = Console.ReadLine();

correo_modificado = correo.Split("@gmail.com");


Console.WriteLine("Tu correo institucional es: {0}@miumg.edu.gt ", correo_modificado);

Console.ReadKey(true);

