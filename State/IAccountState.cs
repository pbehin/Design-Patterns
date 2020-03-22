namespace State
{
    public interface IAccountState
    {
        void Deposit(int amount);
        void Withdrew(int amount);
        int CurrentAmount { get; }
        int AmountUpperBound { get; }
        int AmountLowerBound { get; }
        IAccountState PreviousAccountState { get; }
        IAccountState NextAccountState { get; }

    }
}