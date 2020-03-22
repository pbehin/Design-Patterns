using System;

namespace State
{
    public class Account : IAccount
    {
        public IAccountState AccountState { get; private set; }

        public Account()
        {
           AccountState = new BlueState(this, 500);
        }

        public void Deposit(int amount)
        {
            AccountState.Deposit(amount);
        }

        public void Withdrew(int amount)
        {
            AccountState.Withdrew(amount);
        }

        public void SetState(IAccountState accountState)
        {
            this.AccountState = accountState;
        }
    }
}