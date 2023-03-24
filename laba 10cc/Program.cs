namespace laba_10
{
    public class Car
    {
        public string Avto { get; set; }
    }
    public class Garage
    {
        public List<Car> garage = new List<Car>();

        public void AddAvto(Car car)
        {
            garage.Add(car);
        }

    }
    public class Washer
    {
        public delegate void WashCar(Car car);
        public WashCar carDelegate = new WashCar(Wash);
        public static void Wash(Car car)
        {
            Console.WriteLine("Автомобиль: " + car.Avto + " вымыт");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car { Avto = "Мазда" };
            Car car2 = new Car { Avto = "Лада" };

            Garage garage = new Garage();
            garage.AddAvto(car1);
            garage.AddAvto(car2);

            Washer washer = new Washer();

            foreach (var car in garage.garage)
            {
                washer.carDelegate(car);
            }
        }
    }
}