using Negocio;

var dias = new List<string>();
dias.Add("Lunes");
dias.Add("Martes");
dias.Add("Miercoles");
dias.Add("Jueves");
dias.Add("Viernes");
dias.Add("Sabado");
dias.Add("Domingo");

var numeros = new List<int>();
numeros.Add(1);
numeros.Add(2);
numeros.Add(3);
numeros.Add(4);
numeros.Add(5);


// See https://aka.ms/new-console-template for more informatio36Console.WriteLine("Hello, World!");


var rafa = new Empleado();
rafa.Nombre = "Rafa Sanchez";
Console.WriteLine(rafa.ToString());



var juan = new Operario();
juan.Nombre = "Juan Martinez";
Console.WriteLine(juan.ToString());
var jose = new Administrativo();
var maria = new Operario();
var manuel = new Administrativo();
var antonio = new Operario();
var gawain = new Administrativo();
var ataulfo = new Operario();
var manuela = new Administrativo();

var pepe = new Operario();
var julia = new Administrativo();


juan.Nombre = "Juan";
jose.Nombre = "Jose";
maria.Nombre = "María";
manuel.Nombre = "Manuel";
antonio.Nombre = "Antonio";
gawain.Nombre = "Gawain";
ataulfo.Nombre = "Ataulfo";
manuela.Nombre = "Manuela";
rafa.Nombre = "Rafa";
pepe.Nombre = "Pepe";
julia.Nombre = "Julia";




//juan.DiasVacaciones = 364;
//jose.DiasVacaciones = 30;
//maria.DiasVacaciones = 15;
//ataulfo.DiasVacaciones = 1;




juan.Turno = "mañana";
maria.Turno = "tarde";
antonio.Turno = "tarde";
ataulfo.Turno = "noche";


jose.Plazaparking = "P2";
manuel.Plazaparking = "P3";

var empleados = new List<Empleado>();
empleados.Add(juan);
empleados.Add(jose);
empleados.Add(maria);
empleados.Add(antonio);
empleados.Add(manuel);
empleados.Add(gawain);
empleados.Add(ataulfo);

Console.WriteLine(empleados.Count);