using HOY;
using System.Linq;
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
            List<Usuario> listaUsuarios = Metodos.crearListaUsuarioInicial();
            List<Moneda> listaMonedas = crearListaMonedasInicial();
            List<Tasa> listaTasa = Metodos.crearListaTasasInicial();

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
            private static List<Moneda> crearListaMonedasInicial()
            {
                List<Moneda> listaMonedas = new List<Moneda>();     // Crea una lista de Monedas
                Moneda euro = new Moneda("Euro", "e");              // Crea una Moneda nueva
                listaMonedas.Add(euro);                             // Añadimos la moneda a la lista de monedas creada
                Moneda dolar = new Moneda("Dolar", "d");
                listaMonedas.Add(dolar);
                Moneda libra = new Moneda("Libra", "l");
                listaMonedas.Add(libra);
                return listaMonedas;
            }

            //TODO: factorizar el Case 
            List<Busqueda> historico = new List<Busqueda>();

            string nuevo;
            string nombre;
            string password;
            bool correcta;
            bool correctamenteLogueado = false;

            Console.WriteLine("Hola, es usted usuario nuevo(n) o ya esta registrado(r)");
            nuevo = Console.ReadLine();
            //TODO: Comprobar entrada correcta

            //Console.WriteLine(listaUsuarios.Count);


            switch (nuevo)
            {
                case "n":               // Es un nuevo Ususario -> Registrarlo
                    nombre = Metodos.nuevoUsuarioNombre();
                    do
                    {
                        correcta = Metodos.nuevoUsuarioContraseña();
                        if (correcta)                      //"Las contraseñas coinciden"
                        {
                            Metodos.contraseñasCoinciden(nombre);
                        }
                        else                                //"Las contraseñas NO coinciden"
                        {
                            Metodos.contraseñasNoCoinciden(nombre);
                        }

                    } while (correcta != true); //Hacer mientras las contraseñas NO coincidan
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
                    Console.WriteLine("No es una entrada correcta.");
                    break;
            }

        }

    }

}
