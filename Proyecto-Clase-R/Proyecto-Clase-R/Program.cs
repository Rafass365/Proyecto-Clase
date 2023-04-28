using System.Linq;
namespace Proyecto_Clase_R
{
    internal class Program
    {
        
    
        static void Main(string[] args)
        {
            
            // LINQ //
            //var empleadosP = from empleado in listaEmpleados
            //                 where empleado.Nombre == "pepe"
            //                 orderby nombre
            //                 select empleado;

            List<Usuario> listaUsuarios = new List<Usuario>() ;
            Usuario Rafa = new Usuario("Rafa", "Pass");
            listaUsuarios.Add(Rafa);
            Usuario Paco = new Usuario("Paco", "Pass");
            listaUsuarios.Add (Paco);
            Usuario Pepe = new Usuario("Pepe", "Pass");
            listaUsuarios.Add (Pepe);


            string nuevo;
            string nombre;
            string password;
            string npassword;
            bool existeUsuario;
            bool correctamenteLogueado = false;






            Console.WriteLine("Hola, es usted usuario nuevo(n) o ya esta registrado(r)");
            nuevo = Console.ReadLine();
            
            


         
            switch (nuevo)
            {
                case "n":               // Es un nuevo Ususario -> Registrarlo
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("VAMOS A REGISTRARLE EN LA APLICACION");
                    Console.WriteLine("Introducca su nombre:");
                    Console.ForegroundColor = ConsoleColor.White;
                    nombre = Console.ReadLine();
                    Usuario nuevoUsuario = new Usuario();
                    nuevoUsuario.setNombre(nombre);                     //Ponemos nombre a Usuario.Nombre
                    //Metodos.funciona("ESTO");
                    // TODO:
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Green;   //Obtenemos la contraseña
                        Console.WriteLine("Introducca su contraseña:");
                        Console.ForegroundColor = ConsoleColor.Black;
                        password = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Repita su contraseña:");
                        Console.ForegroundColor = ConsoleColor.Black;
                        npassword = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;

                        if (npassword == password)                      //Console.WriteLine("Las contraseñas coinciden");
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{nombre} Acaba de ser registrado");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else                                            //npassword != password
                        {
                            nuevoUsuario.setContraseña(password);       //Ponemos contraseña a Usuario.contraseña
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Las contraseñas no coinciden");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("VOLVAMOS A INTRODUCIR LA CONTRASEÑA");
                            Console.ForegroundColor = ConsoleColor.White;
                            listaUsuarios.Add(nuevoUsuario);            //Añadimos el nuevo usuario a la lista de usuarios
                        }

                    } while (npassword != password);
                    break;

                case "r":                                               // Es un Ususario Registrado -> Comprobar Usuario <-> Contraseña
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
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine($"{nombre} Esta correctamente logueado");
                                    Console.WriteLine($"{nombre} Sus últimas busquedas son:");
                                    Console.WriteLine($"{nombre} VAMOS A CONVERTIR MONEDAS JUNTOS");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else                                    //(usuario.getNombre() == nombre) && (usuario.getContraseña() != password)
                                {
                                    correctamenteLogueado = false;      // No coincide el usuario con su contraseña => Volver introducir password 
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine($"{nombre} Su Password no coincide con su usuario/n"); 
                                    Console.WriteLine("Vuelva a introducir su password");
                                    Console.ForegroundColor = ConsoleColor.White;                                  
                                }
                            }
                        }
                        if (correctamenteLogueado == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{nombre} Su usuario no coincide con su usuario/n Vuelva a introducir su nombre");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    } while (correctamenteLogueado == false);
                    //nombre = nuevoUsuario.getNombre();
                    break;

               
                default: 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No es una entrada correcta.");
                    break;                                   
            }
            
        }
        public void correctamenteLogueado(string nombre)
        {      // usuario Logueado ==> a convertir moneda
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{nombre} Esta correctamente logueado");
            Console.WriteLine($"{nombre} Sus últimas busquedas son:");
            Console.WriteLine($"{nombre} VAMOS A CONVERTIR MONEDAS JUNTOS");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    }
