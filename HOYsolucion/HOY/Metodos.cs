using HOY;
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
        Usuario nuevoUsuario = new Usuario();
        //nuevoUsuario = new Usuario();

        nuevoUsuario.setNombre(nombre);
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

    public static void correctamenteLogueado(string nombre)
    {      // usuario Logueado ==> a convertir moneda
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{nombre} Esta correctamente logueado");
        Console.WriteLine($"{nombre} Sus últimas busquedas son:");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"{nombre} 25 Euros son 30 $");
        Console.WriteLine($"{nombre} 190 $ son 210 Libras");
        Console.WriteLine($"{nombre} 1 Libras son 1.5 Euros");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"{nombre} VAMOS A CONVERTIR MONEDAS JUNTOS");
        Console.ForegroundColor = ConsoleColor.White;
        Moneda.conversorMonedas();
    }

    public static void contraseñasCoinciden(string nombre)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Las contraseñas coinciden");
        Console.WriteLine("\n");
        Console.WriteLine($"{nombre} Acaba de ser registrado");
        Console.WriteLine($"{nombre} Vamos a convertir monedas");
        Console.ForegroundColor = ConsoleColor.White;
        Moneda.conversorMonedas();
    }

    public static void contraseñasNoCoinciden(string nombre)
    { 
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Las contraseñas no coinciden");
        Console.ForegroundColor = ConsoleColor.Green;                    
        Console.WriteLine("VOLVAMOS A INTRODUCIR LA CONTRASEÑA");                                        
        Console.ForegroundColor = ConsoleColor.White;  
        
    }
}