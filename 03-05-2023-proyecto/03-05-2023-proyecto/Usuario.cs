using System;


public class Usuario
{
    private string Nombre;     //Atributo -> Siempre private (Visible únicamente por los metodos de la misma clase
    private String Contraseña; //Atributo


    public int MyProperty { get; set; }         // Declaración de propiedad AUTOMATICA
                                                //Propiedad -> Siempre public (Visible por cuanquier método de la aplicación
                                                //Propiedades son en realidad una forma especial de escribir métodos.
                                                // añadirle ? Significa que puede tener valor nulo (null)
                                                //public string Nombre    //Declaracion de propiedad COMPLETA
                                                //{
                                                //
                                                //    get { return nombre; }
                                                //    set
                                                //    {
                                                //        var nombreMayusculas = value.ToUpper();
                                                //        nombre = nombreMayusculas;
                                                //    }
                                                //}

    public void setNombre(string nombre)
    {
        this.Nombre = nombre;
    }
    public string getNombre()
    {
        return Nombre;

    }
    public void setContraseña(string contraseña)    //Metodos -> pueden o no recibir info
    {                                               //Metodos -> pueden o no devolver info
        this.Contraseña = contraseña;               //Métodos accesores, usados para trabajar con los campos, ya que los atributos deben ser private 
    }
    public string getContraseña()
    {

        return Contraseña;

    }


    public bool PaswordCorrecto(string contraseña)
    {
        //return this.Contraseña == contraseña;
        return (contraseña == "contraseña");
    }

    /// Constructores
    public Usuario(string nombre, string contraseña)
    {
        this.Nombre = nombre;
        this.Contraseña = contraseña;
    }

    public Usuario()
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
        var nuevoUsuario = new Usuario();
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
}

