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

        override public string ToString() //sobrescribir el método ToString para mostrar la información del vehículo de manera personalizada
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Año: {Año}, Precio: {Precio}";
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

            List<VehiculosInstitucionles> listaVehiculosUTA = new List<VehiculosInstitucionles>();
            listaVehiculosUTA.Add(vehiculo1);
            listaVehiculosUTA.Add(vehiculo2);
            listaVehiculosUTA.Add(vehiculo3);
            listaVehiculosUTA.Add(vehiculo4);
            listaVehiculosUTA.Add(vehiculo5);



            //foreach (var elemento in listaComiteCum)
            //{
            //    Console.WriteLine(elemento);
            //}


            //1) Imprimir todos los vehiculos de la UTA
            foreach (var vehiculo in listaVehiculosUTA)
                {
                    Console.WriteLine($"Marca: {vehiculo.Marca}, Modelo: {vehiculo.Modelo}, Año: {vehiculo.Año}, Precio: {vehiculo.Precio}");
                Console.WriteLine("Con el ToString: "+vehiculo.ToString());
            }

            //2)Cuanto suman todos los precios de los vehículos de la UTA
            double suma = 0;
            foreach (var vehiculo in listaVehiculosUTA)
            {
                suma += vehiculo.Precio;
                
            }
            Console.WriteLine($"Precio: {suma}");

            //3)Cual es el promedio de los precios de los vehículos de la UTA

            foreach (var vehiculo in listaVehiculosUTA)
            {
                suma += vehiculo.Precio;

            }
            Console.WriteLine($"Precio: {suma/listaVehiculosUTA.Count}");
            //4)Cuantos vehículos de la UTA tienen menos de 5 años de antigüedad
            int contador = 0;
            foreach (var vehiculo in listaVehiculosUTA)
            {
                if (vehiculo.Año >= 5)
                {
                    contador++;
                }

            }
            Console.WriteLine($"Los vehiculos con menos de 5 años son: {contador}");

            //5)Cual es el vehiculo mas barato de la UTA
                 double precioMasBarato = 0;
            foreach (var vehiculo in listaVehiculosUTA)
            {
                precioMasBarato = vehiculo.Precio;
                while (precioMasBarato > vehiculo.Precio)
                {
                    precioMasBarato = vehiculo.Precio;
                }   

            }
            Console.WriteLine($"Precio mas barato: {precioMasBarato}");
            //6)Cual es el vehiculo mas caro de la UTA

        }
    }
}
