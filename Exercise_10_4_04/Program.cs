namespace Exercise_10_4_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUpdater<User> updater1 = new UserService();
            IUpdater<Accounr>updater2= new UserService();
        }
    }
}
