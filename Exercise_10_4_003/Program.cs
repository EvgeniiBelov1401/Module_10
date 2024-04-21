namespace Exercise_10_4_003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMessanger<Phone> viberInPhone = new Viber<Phone>();
            viberInPhone.GetDeviceInfo(new Phone());

            IMessanger<IPhone>viberInIphone = new Viber<Phone>();
            viberInIphone.GetDeviceInfo(new IPhone());
        }
    }
}
