//using HOY;

using HOY;
using System.Security.Cryptography;

namespace Proyecto_Clase_R
{


    public class Metodos
    {
        internal Program Program
        {
            get => default;
            set
            {
            }
        }

        public static string nuevoUsuarioNombre()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("VAMOS A REGISTRARLE EN LA APLICACION");
            Console.WriteLine("Introducca su nombre:");
            Console.ForegroundColor = ConsoleColor.White;
            string nombre = Console.ReadLine();
            Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.setNombre(nombre);
            return nombre;
        }

        public static bool nuevoUsuarioContraseña()         //Obtenemos la contraseña
        {
            Console.ForegroundColor = ConsoleColor.Green;
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

        public static void contraseñasCoinciden(string nombre)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Las contraseñas coinciden");
            Console.WriteLine("\n");
            Console.WriteLine($"{nombre} Acaba de ser registrado");
            Console.WriteLine($"{nombre} Vamos a convertir monedas");
            Console.ForegroundColor = ConsoleColor.White;
            
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

        public static void correctamenteLogueado(string nombre)     // usuario Logueado ==> a convertir moneda
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{nombre} Esta correctamente logueado");
            MostrarBusquedas(nombre); //
            
        }

        private static void MostrarBusquedas(string nombre) //Refactorización 
        {       

            //TODO: Buscar en el historico
            Console.WriteLine($"{nombre} Sus últimas busquedas son:"); 
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{nombre} 25 Euros son 30 $");
            Console.WriteLine($"{nombre} 190 $ son 210 Libras");
            Console.WriteLine($"{nombre} 1 Libras son 1.5 Euros");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{nombre} VAMOS A CONVERTIR MONEDAS JUNTOS");
            Console.ForegroundColor = ConsoleColor.White;
        }
             


        public static void conversorMonedas(List<Moneda> listaMonedas, List<Busqueda> historico) 
            {
                bool seguir = true;
                string continuar;
                string monedas;
                double cantidad;
                double resultado;
                Moneda monedaOrigen = new Moneda();
                Moneda monedaDestino = new Moneda();
                //const double tasaED = 1.10;
                //const double tasaEL = 0.80;
                //const double tasaDL = 0.88;

                do
                {
                    //Adquisicion de monedas de origen y destino
                    
                    Console.WriteLine("Introduzca la moneda origen: Euro(e), Dolar(d) o Libra(l)");
                    monedas = Console.ReadLine();
                    Console.WriteLine("Introduzca la moneda destino: Euro(e), Dolar(d) o Libra(l)");
                    monedas = monedas + Console.ReadLine();

                    //Adquisicion de cantidad a convertir
                    Console.WriteLine("Introduzca la cantidad a convertir");
                    //cantidad = Console.ReadLine();
                    cantidad = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

                    //Bloque Switch
                    switch (monedas)
                    {
                        case "ed":
                            //resultado = Math.Round(Convert.ToDouble(cantidad * tasaED), 2);
                            Tasa tasa = (form tasa in listaTasas)
                            monedaOrigen = (from moneda in listaMonedas where moneda.Letra == "e" select moneda).FirstOrDefault();
                           
                            monedaDestino = (from moneda in listaMonedas where moneda.Letra == "d" select moneda).FirstOrDefault();
                            Console.WriteLine($"{cantidad} Euros son {resultado} Dolares");
                            break;

                        case "el":
                            resultado = Math.Round(Convert.ToDouble(cantidad * tasaEL), 2);
                        monedaOrigen = (from moneda in listaMonedas where moneda.Letra == "e" select moneda).FirstOrDefault();

                        monedaDestino = (from moneda in listaMonedas where moneda.Letra == "" select moneda).FirstOrDefault();
                        Console.WriteLine($"{cantidad} Euros son {resultado} Libras");
                            break;

                        case "de":
                            resultado = Math.Round(Convert.ToDouble(cantidad * (1 / tasaED)), 2);
                            Console.WriteLine($"{cantidad} Dolares son {resultado} Euros");
                            break;

                        case "dl":
                            resultado = Math.Round(Convert.ToDouble(cantidad * tasaDL), 2); ;
                            Console.WriteLine($"{cantidad} Dolares son {resultado} Libras");
                            break;

                        case "le":
                            resultado = Math.Round(Convert.ToDouble(cantidad * (1 / tasaEL)), 2);
                            Console.WriteLine($"{cantidad} Libras son {resultado} Euros");
                            break;

                        case "ld":
                            resultado = Math.Round(Convert.ToDouble(cantidad * (1 / tasaDL)), 2);
                            Console.WriteLine($"{cantidad} Libras son {resultado} Dolares");
                            break;

                        default:
                            Console.WriteLine($"Moneda destino u origen erronea.");
                            break;
                    }
                Busqueda nuevaBusqueda = new Busqueda() {
                    monedaDestino = monedaDestino,
                    monedaOrigen = monedaOrigen

                };
                //TODO: Agrgar a la lista de busquedas

                


                    //Control de siguiente conversión o salida de programa
                    Console.WriteLine("Desea convertir otra vez (s/n)?");
                    continuar = Console.ReadLine();
                    if (continuar == "s")
                    {
                        seguir = true;
                    }
                    else
                    {
                        seguir = false;
                    }

                } while (seguir == true);
            }
    }
}