using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

if (args.Length > 0)
{
    switch (args[0].ToLower())
    {
        case "--help":
            MostrarAyuda();
            Environment.Exit(0);
            break:

        case "--version":
            Console.WriteLine($"Versión: {version}");
            Environment.Exit(0);
            break;

        default:
        Console.WriteLine($" Error: Comando desconocido: {args[0]}");
        Console.WriteLine(" Usa --help para ver las opciones disponibles.");
        Environment.Exit(1);
        break;

    }
}

// ============================================================
// SISTEMA DE INVENTARIO - Clase 1.1
// Estado: Mensaje de bienvenida
// ============================================================

Console.WriteLine("==========================================");
Console.WriteLine("    SISTEMA DE GESTIÓN DE INVENTARIO      ");
Console.WriteLine("==========================================");
Console.WriteLine();
Console.WriteLine($"Versión: {version}");
Console.WriteLine($"Plataforma: {Environment.OSVersion}");
Console.WriteLine($".NET Version: {Environment.Version}");
Console.WriteLine();
Console.WriteLine("Estado: Proyecto inicializado");
Console.WriteLine("Estructura del proyecto");
Console.WriteLine(" InventarioConsoleApp/");
Console.WriteLine("  |-- Program.cs");
Console.WriteLine("  |-- ConsoleAppHMac.csproj");
Console.WriteLine("  |-- .gitignore" );
Console.WriteLine("  |-- README.md" );
Console.WriteLine("  |-- src/" );
Console.WriteLine("     |-- Models/ info" );

Console.WriteLine("Configuracion .csproject: Define el proyecto y sus dependencias.");
Console.WriteLine("Carpeta src/ creada para organizar el código fuente.");
Console.WriteLine("Metadatos configurados");
Console.WriteLine();
Console.WriteLine("Proximos pasos: Agregar argumentos CLI yy configuración del repositorio en GitHub");
Console.WriteLine("B.F.E.C.D.A");

// ============================================================
// funcionaes
// ============================================================

void MostrarAyuda()
{
    Console.WriteLine("USO: InventarioApp [comando] [opciones]");
    Console.WriteLine();
    Console.WriteLine("COMANDOS:");
    Console.WriteLine("  --help, -h      Muestra esta ayuda");
    Console.WriteLine("  --version, -v   Muestra la version del programa");
    Console.WriteLine();
    Console.WriteLine("EJEMPLOS:");
    Console.WriteLine(" dotnet run -- --help");
    Console.WriteLine(" dotnet run -- --version");
}