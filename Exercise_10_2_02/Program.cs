namespace Exercise_10_2_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Writer writer = new Writer();
            ((IWriter)writer).Write();
        }
    }
}
