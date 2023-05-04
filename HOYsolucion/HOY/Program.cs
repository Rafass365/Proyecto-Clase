using System.Linq;
namespace Proyecto_Clase_R
{
    internal class Program
    {
        
    
        static void Main(string[] args)
        {
                  
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
            bool correcta;
            bool existeUsuario;
            bool correctamenteLogueado = false;


            Console.WriteLine("Hola, es usted usuario nuevo(n) o ya esta registrado(r)");
            nuevo = Console.ReadLine();
            
            
            Console.WriteLine(listaUsuarios.Count);

         
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
                    
                    break;

               
                default: 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No es una entrada correcta.");
                    break;                                   
            }
            
        }
        
    }

    }
