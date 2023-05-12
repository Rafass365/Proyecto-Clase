using Proyecto_Clase_R;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clase_R
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //List<Usuario> listaUsuarios = new List<Usuario>();  // Crea una lista de Usuarios
            //Usuario Rafa = new Usuario("Rafa", "Rafa");         // Crea un usuario nuevo
            //listaUsuarios.Add(Rafa);                            // añadimos el usuario a la lista creada
            //Usuario Paco = new Usuario("Paco", "Paco");
            //listaUsuarios.Add(Paco);
            //Usuario Pepe = new Usuario("Pepe", "Pepe");
            //listaUsuarios.Add(Pepe);

            //List<Moneda> listaMonedas = new List<Moneda>();     // Crea una lista de Monedas
            //Moneda euro = new Moneda("Euro", "e");              // Crea una Moneda nueva
            //listaMonedas.Add(euro);                             // Añadimos la moneda a la lista de monedas creada
            //Moneda dolar = new Moneda("Dolar", "d");
            //listaMonedas.Add(dolar);
            //Moneda libra = new Moneda("Libra", "l");
            //listaMonedas.Add(libra);

            //List<Tasa> listaTasas = new List<Tasa>();           // Tasa == Factor de conversion entre dos monedas
            //Tasa ed = new Tasa(euro, dolar, 1.10);              // Creamos una lista de tasa (Dos monedas y su factor de conversion entre ambas
            //listaTasas.Add(ed);                                 // Añadimos esa relacion a la lista de tasas de conversión
            //Tasa el = new Tasa(euro, libra, 0.90);
            //listaTasas.Add(el);
            //Tasa dl = new Tasa(dolar, libra, 0.80);
            //listaTasas.Add(dl);
            List<Usuario> listaUsuarios = new List<Usuario>();
            List<Moneda> listaMonedas = new List<Moneda>();
            List<Tasa> listaTasa = new List<Tasa>();
            List<Busqueda> historico = new List<Busqueda>();

            listaUsuarios = Usuario.crearListaUsuarioInicial(listaUsuarios);
            listaMonedas = Moneda.crearListaMonedasInicial(listaMonedas);
            listaTasa = Tasa.crearListaTasaInicial(listaMonedas, listaTasa);
            //TODO: factorizar el Case 

            string nuevo;
            string nombre;
            string password;
            bool correcta;
            bool correctamenteLogueado = false;

              /////////////
             // INICIO: //
            /////////////
            Console.WriteLine("Hola, es usted usuario nuevo(n) o ya esta registrado(r)");
            nuevo = Console.ReadLine();
            //TODO: Comprobar entrada correcta

            switch (nuevo)
            {
                case "n":                                               // Es un nuevo Ususario -> Registrarlo
                    nombre = Metodos.nuevoUsuarioNombre();              // Obtenemos su nombre
                    do
                    {
                        (password, correcta) = Metodos.nuevoUsuarioContraseña();    // Obtenemos su contraseña y comprobamos que es correcta

                        if (correcta)                                   // Las contraseñas coinciden "Comtraseña correcta"
                        {
                            Metodos.contraseñasCoinciden(nombre);       // Añadimos nuevoUsuario a listaUsuarios
                            listaUsuarios = Usuario.añadirUsuario(listaUsuarios, nombre, password);
                            
                        }
                        else                                            //"Las contraseñas NO coinciden"
                        {
                            Metodos.contraseñasNoCoinciden(nombre);
                        }

                    } while (correcta != true); //Hacer mientras las contraseñas NO coincidan

                    //////////////////////////////////////////////////////////////////////
                    // Las contraseñas son correctas y el nuevo usuario esta registrado //
                    //////////////////////////////////////////////////////////////////////
                    var cantidad = Metodos.obtenerCantidad();
                    Moneda monedaOrigen = Metodos.obtenerOrigen(listaMonedas);
                    Moneda monedaDestino = Metodos.obtenerDestino(listaMonedas);
                    double tasa = Tasa.obtenerTasa(listaTasa, monedaOrigen, monedaDestino);
                    Metodos.conversorMonedas(listaMonedas, historico);
                    break;

                case "r":               // Es un Ususario Registrado -> Comprobar Usuario <-> Contraseña
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Introducca su nombre:");
                        nombre = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;

                        foreach (var usuario in listaUsuarios)
                        {
                            if (usuario.getNombre() == nombre)          // usuario encontrado => comprobar contraseña
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"{nombre} Introduzca su contraseña:");
                                Console.ForegroundColor = ConsoleColor.Black;
                                password = Console.ReadLine();
                                if (usuario.getContraseña() == password) //(usuario.getNombre() == nombre) && (usuario.getContraseña() == password)
                                {
                                    correctamenteLogueado = true;       // usuario Logueado ==> a convertir moneda
                                    Metodos.correctamenteLogueado(nombre);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else                                    //(usuario.getNombre() == nombre) && (usuario.getContraseña() != password)
                                {
                                    correctamenteLogueado = false;      // No coincide el usuario con su contraseña => Volver introducir password 
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine($"{nombre} Su Password no coincide con su usuario");
                                    Console.WriteLine("Vuelva a introducir su password");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                        }
                        if (correctamenteLogueado == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{nombre} Su usuario no coincide con su password");
                            Console.WriteLine("Vuelva a introducir su nombre");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                    } while (correctamenteLogueado == false);
                    Metodos.conversorMonedas(listaMonedas, historico);
                    break;


                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No es una entrada correcta. n o r");
                    break;
            }

        }

    }

}
