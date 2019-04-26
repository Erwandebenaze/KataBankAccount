namespace KataBankAccountTest
{
    public class Operation
    {
        private readonly int _number;
        public Operation(int number)
        {
            _number = number;
        }
        public override string ToString()
        {
            return "Operation number " +_number;
        }
    }
}