using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Calc
{
    internal partial class ViewModel: ObservableObject
    {
        private CalcModel _calcModel;

        [ObservableProperty]
        private string? _operation;

        [ObservableProperty]
        private int _total;

        [ObservableProperty]
        private string? _number;

        [ObservableProperty]
        private string? _formula;

        [RelayCommand]
        private void ClearNumber()
        {
            _calcModel.ClearNumber();
            Number = "";
        }

        [RelayCommand]
        private void Clear()
        {
            _calcModel.Clear();
            Total = 0;
            Number = "";
            Operation = Constants.EMPTY;
            Formula = "";
        }

        [RelayCommand]
        private void EnterNumber(string numStr)
        {
            var num = Convert.ToInt32(numStr);
            Number = _calcModel.EnterNumber(num).ToString();
            Formula += numStr;
        }

        [RelayCommand]
        private void EnterOperation(string op)
        {
            Operation = op;
            Number = "";
            Total = _calcModel.EnterOperation(op);
            Formula += op;
        }

        public ViewModel()
        {
            _calcModel = new CalcModel();
            _operation = _calcModel.Operation;
            _total = _calcModel.Total;
            _number = _calcModel.Number.ToString();
        }
    }
}
