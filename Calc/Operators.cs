namespace Calc
{
    public enum Operator
    {
        Plus,
        Minus,
        Multiply,
        Equal,
        Empty
    }

    public static class OperatorExtensions
    {
        public static string ToSymbol(this Operator op)
        {
            switch (op)
            {
                case Operator.Plus:
                    return "+";
                case Operator.Minus:
                    return "-";
                case Operator.Multiply:
                    return "x";
                case Operator.Equal:
                    return "=";
                case Operator.Empty:
                    return "";
                default:
                    return "";
            }
        }
    }
}
