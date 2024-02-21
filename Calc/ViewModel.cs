using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Calc
{
    internal partial class ViewModel: ObservableObject
    {
        private Model _model;

        [ObservableProperty]
        private string _currentOperator = "";

        [ObservableProperty]
        private int _total = 0;

        [ObservableProperty]
        private int _currentInput = 0;

        [RelayCommand]
        private void ClearNumber()
        {
            CurrentInput = 0;
        }

        [RelayCommand]
        private void Clear()
        {
            _model.Clear();
            CurrentOperator = "";
            Total = 0;
            CurrentInput = 0;
        }

        [RelayCommand]
        private void EnterNumber(string numStr)
        {
            CurrentInput = CurrentInput * 10 + Convert.ToInt32(numStr);
        }

        [RelayCommand]
        private void EnterOperation(Operator op)
        {
            CurrentOperator = op.ToSymbol();
            Total = _model.EnterOperation(op, CurrentInput);
            CurrentInput = 0;
        }

        public ViewModel()
        {
            _model = new Model();
        }
    }
}
