namespace Calc
{
    internal class CalcModel
    {
        public string? Operation { get; set; } = Constants.EMPTY;

        public int Total { get; set; } = 0;

        public int Number { get; set; } = 0;

        public void ClearNumber()
        {
            Number = 0;
        }

        public void Clear()
        {
            Total = 0;
            Number = 0;
            Operation = "";
        }

        public int EnterNumber(int num)
        {
            Number = Number * 10 + num;
            return Number;
        }

        public int EnterOperation(string op)
        {
            switch (Operation)
            {
                case Constants.EMPTY:
                    // First operation is just to set the total
                    Total = Number;
                    break;
                case Constants.PLUS:
                    Total += Number;
                    break;
                case Constants.MINUS:
                    Total -= Number;
                    break;
                case Constants.MULTIPLY:
                    Total *= Number;
                    break;
                case Constants.EQUAL:
                    // Do nothing
                    break;
            }

            // Set the next operation
            Operation = op;

            // Reset the current number
            Number = 0;

            return Total;
        }
    }
}
