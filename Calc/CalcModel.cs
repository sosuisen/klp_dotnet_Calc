namespace Calc
{
    internal class CalcModel
    {
        public string? Operation { get; set; } = Constants.EMPTY;

        public int Total { get; set; } = 0;

        public void Clear()
        {
            Total = 0;
            Operation = "";
        }

        public int EnterOperation(string op, int num)
        {
            switch (Operation)
            {
                case Constants.EMPTY:
                    // First operation is just to set the total
                    Total = num;
                    break;
                case Constants.PLUS:
                    Total += num;
                    break;
                case Constants.MINUS:
                    Total -= num;
                    break;
                case Constants.MULTIPLY:
                    Total *= num;
                    break;
                case Constants.EQUAL:
                    // Do nothing
                    break;
            }

            // Set the next operation
            Operation = op;

            return Total;
        }
    }
}
