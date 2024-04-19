namespace Exercise_10_2_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            ((IWorker)worker).Build();
        }
    }
}
