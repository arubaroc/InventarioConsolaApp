using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

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