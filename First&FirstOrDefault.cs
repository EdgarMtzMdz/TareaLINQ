var personas = new List<persona>()
{
    new persona { Nombre = "Eduardo", Edad = 30, FechaDeIngresoALaEmpresa = new DateTime(2021, 1, 2), SocketsHttpPlaintextStreamFilterContext = true}
};

var primeraPerdona = personas.First();
var primeraPerdona2 = personas.FirstOrDefault();

var paises = new List<string>();
try
{
    var primerPais = paises.First();
}
catch (Exception ex)
{
    Console.WriteLine("A ocurrido un error");
}

var primerPais = paises.FirstOrDefault();

var numeros = new List<int>();
var primerNumero = numeros.FirstOrDefault();

var primeraPersonaNoSoltera = personas.FirstOrDefault(p => !p.Soltero);

var primeraPersonaNoSoltera_2 = (from p in personas
                                where p.Soltero 
                                select p).FirstOrDefault();