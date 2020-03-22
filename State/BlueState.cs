using System;

namespace State
{
    public class BlueState : AccountStateBase
    {
        private IAccountState _nextAccountState;

        public override IAccountState NextAccountState => _nextAccountState ??= new SilverState(Account, CurrentAmount);
        public override int AmountUpperBound { get; }
        public override int AmountLowerBound { get; }

        public override IAccountState PreviousAccountState => null;

        public BlueState(IAccount account, int initialAmount) : base(account, initialAmount)
        {
            AmountUpperBound = 700;
            AmountLowerBound = 100;
        }
    }
}