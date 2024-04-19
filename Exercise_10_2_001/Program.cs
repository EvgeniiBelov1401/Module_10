namespace Exercise_10_2_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Messanger messanger = new Messanger();

            ((IWhatsApp)messanger).SendMassage("Привет от WhatsApp");
            ((IViber)messanger).SendMassage("Привет от Viber");
        }
    }
}
