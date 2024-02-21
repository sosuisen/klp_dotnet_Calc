namespace Calc
{
    internal class Model
    {
        public Operator CurrentOperator { get; set; } = Operator.Empty;

        public int Total { get; set; } = 0;

        public void Clear()
        {
            CurrentOperator = Operator.Empty;
            Total = 0;
        }

        public int EnterOperation(int num, Operator nextOp)
        {
            switch (CurrentOperator)
            {
                case Operator.Empty:
                    // First operation is just to set the total
                    Total = num;
                    break;
                case Operator.Plus:
                    Total += num;
                    break;
                case Operator.Minus:
                    Total -= num;
                    break;
                case Operator.Multiply:
                    Total *= num;
                    break;
                case Operator.Equal:
                    // Do nothing
                    break;
            }

            // Set the next operation
            CurrentOperator = nextOp;

            return Total;
        }
    }
}
