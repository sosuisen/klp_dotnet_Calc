namespace Calc
{
    internal class Model
    {
        private int _value = 0;
        private Operator _prevOperator = Operator.Empty;

        public void Clear()
        {
            _value = 0;
            _prevOperator = Operator.Empty;
        }

        public int Calc(int num, Operator nextOp)
        {
            switch (_prevOperator)
            {
                case Operator.Empty:
                    // First operation is just to set the total
                    _value = num;
                    break;
                case Operator.Plus:
                    _value += num;
                    break;
                case Operator.Minus:
                    _value -= num;
                    break;
                case Operator.Multiply:
                    _value *= num;
                    break;
                case Operator.Equal:
                    // Do nothing
                    break;
            }
            _prevOperator = nextOp;
            return _value;
        }
    }
}
