namespace Proyecto_Clase_R
{

    public class Usuario
    {
        private string Nombre;     //Atributo -> Siempre private (Visible únicamente por los metodos de la misma clase
        private String Contraseña; //Atributo
        private Busqueda Busqueda;
        List<Busqueda> listahistorico = new List<Busqueda>(); //creamos un historico para ese usuario

        public Metodos Metodos
        {
            get => default;
            set
            {
            }
        }

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
            Busqueda busqueda = new Busqueda();
        }

        public Usuario()
        {
        }
    }
}
