namespace State
{
    public interface IAccount
    {   
        void Deposit(int amount);
        void Withdrew(int amount);
        void SetState(IAccountState accountState);
    }
}