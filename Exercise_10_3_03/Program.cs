namespace Exercise_10_3_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectronicBook electronicBook = new ElectronicBook();
            ((IBook)electronicBook).Read();
            ((IDevice)electronicBook).TurnOn();
            ((IDevice)electronicBook).TurnOff();
        }
    }
}
