namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            IAccount account = new Account();

            account.Deposit(1000);
            account.Withdrew(500);
        }
    }
}
