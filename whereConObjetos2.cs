var personas = new List<persona>()
{
    new persona { Nombre = "Eduardo", Edad = 30, FechaDeIngresoALaEmpresa = new DateTime(2021, 1, 2), SocketsHttpPlaintextStreamFilterContext = true}
};


var solteros = personas.Where(p => p.Soltero).ToList();

foreach (var perdona in solteros)
{
    Console.WriteLine($"{perdona.Nombre} es soltero/a");
}

