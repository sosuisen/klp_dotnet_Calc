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
        private int _currentInput;

        [RelayCommand]
        private void ClearNumber()
        {
            CurrentInput = 0;
        }

        [RelayCommand]
        private void Clear()
        {
            _calcModel.Clear();
            Total = 0;
            CurrentInput = 0;
            Operation = Constants.EMPTY;
        }

        [RelayCommand]
        private void EnterNumber(string numStr)
        {
            CurrentInput = CurrentInput * 10 + Convert.ToInt32(numStr);
        }

        [RelayCommand]
        private void EnterOperation(string op)
        {
            Operation = op;
            Total = _calcModel.EnterOperation(op, Convert.ToInt32(CurrentInput));
            CurrentInput = 0;
        }

        public ViewModel()
        {
            _calcModel = new CalcModel();
            Operation = _calcModel.Operation;
            Total = _calcModel.Total;
            CurrentInput = 0;
        }
    }
}
