// See https://aka.ms/new-console-template for more information
using PatronStrategy.Implementacion;

Console.WriteLine("Hello, World!");

Equipos Argentina = new Equipos();
Argentina.SetTipoDeJuego(new Presionar());
Argentina.MostrarEstrategia();
Console.WriteLine($"{nameof(Argentina)}");


Equipos Brasil = new Equipos();
Brasil.SetTipoDeJuego(new PosesionPelota());
Brasil.MostrarEstrategia();

Console.WriteLine($"{nameof(Brasil)}");


Equipos PaisesBajos = new Equipos();
PaisesBajos.SetTipoDeJuego(new Contragolpe());
PaisesBajos.MostrarEstrategia();

Console.WriteLine($"{nameof(PaisesBajos)}");


Console.ReadKey();