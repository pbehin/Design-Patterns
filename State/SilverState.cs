using System;

namespace State
{
    public class SilverState : AccountStateBase
    {
        private IAccountState _nextAccountState;
        private IAccountState _previousAccountState;

        public override IAccountState NextAccountState => _nextAccountState ??= new GoldState(Account, CurrentAmount);
        public override int AmountUpperBound { get; }
        public override int AmountLowerBound { get; }

        public override IAccountState PreviousAccountState => _previousAccountState??= new BlueState(Account, CurrentAmount);

        public SilverState(IAccount account, int initialAmount) : base(account, initialAmount)
        {
            AmountUpperBound = 1200;
            AmountLowerBound = 800;
        }
    }
}