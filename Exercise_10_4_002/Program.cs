namespace Exercise_10_4_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMessanger<Phone> viberInPhone = new Viber<Phone>();
            IMessanger<Phone> viberInIphone = new Viber<IPhone>();

            viberInPhone.DeviceInfo();
            viberInIphone.DeviceInfo();
        }
    }
}
