using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOY
{
    internal class Moneda

    {
        private string Nombre;     //Atributo -> Siempre private (Visible únicamente por los metodos de la misma clase
        private double Tasa;
        List<Moneda> listaMonedas = new List<Moneda>();
        Moneda euro = new Moneda("Euro");
        Moneda dolar = new Moneda("Dolar");
        Moneda libra = new Moneda("Libra");
        

        public Moneda(string nombre, double tasa)
        {
            this.Nombre = nombre;
            this.Tasa = tasa;
        }

        public Moneda(string nombre)
        {
            this.Nombre = nombre;
            
        }

        public Moneda()
        {
        }
        //private int Nombre
        //{
        //    get => default;
        //    set
        //    {
        //    }
        //}

        //enum Monedas
        //{
        //    Euros,
        //    Dolares,
        //    Libras,
        //}

        


        public static void conversorMonedas() 
            {
                bool seguir = true;
                string continuar;
                string monedas;
                double cantidad;
                double resultado;
                const double tasaED = 1.10;
                const double tasaEL = 0.80;
                const double tasaDL = 0.88;

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
                            resultado = Math.Round(Convert.ToDouble(cantidad * tasaED), 2);
                            Console.WriteLine($"{cantidad} Euros son {resultado} Dolares");
                            break;

                        case "el":
                            resultado = Math.Round(Convert.ToDouble(cantidad * tasaEL), 2);
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

