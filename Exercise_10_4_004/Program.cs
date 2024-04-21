namespace Exercise_10_4_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGarageManager<Car, Garage> garageManager1 = new GarageManagerBase();
            IGarageManager<Bike, Garage> garageManager2 = new GarageManagerBase();
            IGarageManager<Bike, House> garageManager3 = new GarageManagerBase();
        }
    }
}
