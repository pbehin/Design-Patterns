namespace State
{
    public abstract class AccountStateBase : IAccountState
    {
        public IAccount Account { get; }
        public int CurrentAmount { get; protected set; }

        protected AccountStateBase(IAccount account, int initialAmount)
        {
            Account = account;
            CurrentAmount = initialAmount;
        }


        public abstract IAccountState PreviousAccountState { get; }
        public abstract IAccountState NextAccountState { get; }
        public abstract int AmountUpperBound { get; }
        public abstract int AmountLowerBound { get; }

        public virtual void Deposit(int amount)
        {
            CurrentAmount += amount;
            if (CurrentAmount > AmountUpperBound &&
                CurrentAmount > NextAccountState.AmountLowerBound
            )
                Account.SetState(NextAccountState);
        }

        public virtual void Withdrew(int amount)
        {
            CurrentAmount -= amount;
            if (CurrentAmount < AmountUpperBound &&
                CurrentAmount < NextAccountState.AmountUpperBound
            )
                Account.SetState(PreviousAccountState);
        }
    }
}