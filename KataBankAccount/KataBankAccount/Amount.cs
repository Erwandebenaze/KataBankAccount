namespace KataBankAccount
{
    public class Amount
    {
        private double _amount;

        private Amount(double amount)
        {
            _amount = amount;
        }

        public static Amount Of(double amount)
        {
            return new Amount(amount);
        }

        internal void IncreaseAmount(Amount amount)
        {
            _amount += amount._amount;
        }

        internal void DecreaseAmount(Amount amount)
        {
            _amount -= amount._amount;
        }

        public Amount GetOppositeAmount()
        {
            return Amount.Of(-_amount);
        }

        internal bool IsSuperiorThan(Amount amount)
        {
            return _amount > amount._amount;
        }

        internal Amount CreateCopy()
        {
            return Amount.Of(_amount);
        }
        public override string ToString()
        {
            return _amount.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Amount amount &&
                   _amount == amount._amount;
        }

        public override int GetHashCode()
        {
            return 68920802 + _amount.GetHashCode();
        }
    }

}
