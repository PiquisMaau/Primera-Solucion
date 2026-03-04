namespace Ejercicio8_FOR_EACH
{
    class VehiculosInstitucionles
    {
        public string Marca { get; set; }  //estas son propiedades, tienen get y set
        public string Modelo { get; set; }   //cuando tienen es una variable
        public int Año { get; set; }  //las propiedades pueden restringir el acceso a datos
        public double Precio { get; set; }

        public VehiculosInstitucionles() //ctor es un método especial que se llama automáticamente al crear una instancia de la clase, se utiliza para inicializar los objetos
        {
        }

        public VehiculosInstitucionles(string marca, string modelo, int año, double precio)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Precio = precio;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          //  var variable = 10;
            //Console.WriteLine(variable);
            //Console.WriteLine(variable.GetType());

            List<int> listaNumerosPares = new List<int>() { 2,4,6,8,10,12,14,16};
            List<float> listaNumerosFlotantes = new List<float>() { 3.14f, 2.71f, 5.89f };
            List<String> listaComiteCum = new List<string>() { "Lore", "Karla", "Maité" };

            VehiculosInstitucionles vehiculo1 = new VehiculosInstitucionles();
            vehiculo1.Marca = "KIA";
            vehiculo1.Modelo = "Cerato";
            vehiculo1.Año = 2024;
            vehiculo1.Precio = 15000;

            VehiculosInstitucionles vehiculo2 = new VehiculosInstitucionles("Toyota", "Corolla", 2023, 18000);  
            VehiculosInstitucionles vehiculo3 = new VehiculosInstitucionles("Honda", "Civic", 2022, 17000);
            VehiculosInstitucionles vehiculo4 = new VehiculosInstitucionles("Ford", "Focus", 2021, 16000);
            VehiculosInstitucionles vehiculo5 = new VehiculosInstitucionles("Chevrolet", "Cruze", 2020, 14000);

            foreach (var elemento in listaComiteCum)
            {
                Console.WriteLine(elemento);
            }

        }
    }
}
