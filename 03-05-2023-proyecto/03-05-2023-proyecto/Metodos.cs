using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_05_2023_proyecto
{
    internal class Metodos
    {
    }
}
public class Metodos
{
    public static string nuevoUsuarioNombre()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("VAMOS A REGISTRARLE EN LA APLICACION");
        Console.WriteLine("Introducca su nombre:");
        Console.ForegroundColor = ConsoleColor.White;
        var nombre = Console.ReadLine();
        Usuario.nuevoUsuario = new Usuario();
        
        Usuario.nuevoUsuario.setNombre(nombre);
        return nombre;
    }

    public static bool nuevoUsuarioContraseña()
    {

        Console.ForegroundColor = ConsoleColor.Green;   //Obtenemos la contraseña
        Console.WriteLine("Introducca su contraseña:");
        Console.ForegroundColor = ConsoleColor.Black;
        var password = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Repita su contraseña:");
        Console.ForegroundColor = ConsoleColor.Black;
        var npassword = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.White;

        return (npassword == password);
    }
}