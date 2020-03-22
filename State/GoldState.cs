using System;

namespace State
{
    public class GoldState : AccountStateBase
    {
        private IAccountState _previousAccountState;

        public override IAccountState NextAccountState => null;
        public override int AmountUpperBound { get; }
        public override int AmountLowerBound { get; }

        public override IAccountState PreviousAccountState => _previousAccountState??= new SilverState(Account, CurrentAmount);


        public GoldState(IAccount account, int initialAmount) : base(account, initialAmount)
        {
            AmountUpperBound = 2000;
            AmountLowerBound = 1200;
        }
    }
}