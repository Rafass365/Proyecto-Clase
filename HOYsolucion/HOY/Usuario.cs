using Proyecto_Clase_R;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clase_R
{

    public class Usuario
    {
        private string Nombre;     //Atributo -> Siempre private (Visible únicamente por los metodos de la misma clase
        private String Contraseña; //Atributo
        List<Busqueda> historicoUsuario = new List<Busqueda>(); //creamos un historico para ese usuario

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

        public static List<Usuario> añadirUsuario(List<Usuario> listaUsuarios, string nombre, string password)
        {
            Usuario usuario = new Usuario(nombre, password);
            listaUsuarios.Add(usuario);
            return listaUsuarios;
        }
        public override string ToString() //Polimorfismo --> Hacer que un método cambie de funcionamiento 
        {
            return $"[Usuario. Nombre: {Nombre}]";
        }


        /// Constructores
        public Usuario(string nombre, string contraseña )
        {
            this.Nombre = nombre;
            this.Contraseña = contraseña;
            List<Busqueda> listahistorico = new List<Busqueda>(10);
        }

        public Usuario()
        {
        }
        public static List<Usuario> crearListaUsuarioInicial(List<Usuario> listaUsuarios)
        {
            Usuario Rafa = new Usuario("Rafa", "Rafa");         // Crea un usuario nuevo
            listaUsuarios.Add(Rafa);                            // añadimos el usuario a la lista creada
            Usuario Paco = new Usuario("Paco", "Paco");
            listaUsuarios.Add(Paco);
            Usuario Pepe = new Usuario("Pepe", "Pepe");
            listaUsuarios.Add(Pepe);
            return listaUsuarios;
        }
    }
}
