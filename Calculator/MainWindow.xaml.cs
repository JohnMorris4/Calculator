using System.Windows;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;
        SelectedOperator selectedOperator;


        public MainWindow()
        {
            InitializeComponent();

            ACButton.Click += AcButtonOnClick;
            PandMButton.Click += PandMButtonOnClick;
            PercentButton.Click += PercentButtonOnClick;
            EqualsButton.Click += EqualsButtonOnClick;
        }

        private void EqualsButtonOnClick(object sender, RoutedEventArgs routedEventArgs)
        {
            double newNumber;

            if (double.TryParse(ResultLabel.Content.ToString(), out newNumber))
            {
                switch (selectedOperator)
                {
                    case SelectedOperator.Addition:
                        result = SimpleMath.Add(lastNumber, newNumber);
                        break;

                    case SelectedOperator.Subtraction:
                        result = SimpleMath.Subtract(lastNumber, newNumber);
                        break;

                    case SelectedOperator.Multiplication:
                        result = SimpleMath.Multiply(lastNumber, newNumber);
                        break;

                    case SelectedOperator.Division:
                        result = SimpleMath.Divide(lastNumber, newNumber);
                       
                        break;
                }

                ResultLabel.Content = result.ToString();
            }
        }

        private void PercentButtonOnClick(object sender, RoutedEventArgs routedEventArgs)
        {
            if (double.TryParse(ResultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber /= 100;
                ResultLabel.Content = lastNumber.ToString();
            }
        }

        private void PandMButtonOnClick(object sender, RoutedEventArgs routedEventArgs)
        {
            if (double.TryParse(ResultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber *= -1;
                ResultLabel.Content = lastNumber.ToString();
            }
        }

        private void AcButtonOnClick(object sender, RoutedEventArgs routedEventArgs)
        {

            ResultLabel.Content = "0";

        }

        private void OperationButtonClick(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(ResultLabel.Content.ToString(), out lastNumber))
            {

                ResultLabel.Content = "";

            }

            if (sender == MultiplyButton)
                selectedOperator = SelectedOperator.Multiplication;
            if (sender == DivideButton)
                selectedOperator = SelectedOperator.Division;
            if (sender == PlusButton)
                selectedOperator = SelectedOperator.Addition;
            if (sender == MinusButton)
                selectedOperator = SelectedOperator.Subtraction;
        }

        private void NumberButton_OnClick(object sender, RoutedEventArgs e)
        {
            int selectedValue = 0;
            if (sender == ZeroButton)
                selectedValue = 0;
            if (sender == OneButton)
                selectedValue = 1;
            if (sender == TwoButton)
                selectedValue = 2;
            if (sender == ThreeButton)
                selectedValue = 3;
            if (sender == FourButton)
                selectedValue = 4;
            if (sender == FiveButton)
                selectedValue = 5;
            if (sender == SixButton)
                selectedValue = 6;
            if (sender == SevenButton)
                selectedValue = 7;
            if (sender == EightButton)
                selectedValue = 8;
            if (sender == NineButton)
                selectedValue = 9;


            if (ResultLabel.Content.ToString() == "0")
            {
                ResultLabel.Content = $"{selectedValue}";
            }
            else
            {
                ResultLabel.Content = $"{ResultLabel.Content}{selectedValue}";
            }
        }

        private void PeriodButton_OnClick(object sender, RoutedEventArgs e)
        {
            //if (ResultLabel.Content.ToString().Contains("."))
            //{
            //    //Do nothing
            //    //TODO-Evaluate this to see if it will work like: if (!ResultLabel.Content.ToString().Contains("."))
            //    //{
            //    //    ResultLabel.Content = $"{ResultLabel.Content}.";
            //    //}
            //}
            //else
            //{
            //    ResultLabel.Content = $"{ResultLabel.Content}.";
            //}

            if (!ResultLabel.Content.ToString().Contains("."))
            {
                ResultLabel.Content = $"{ResultLabel.Content}.";
            }
        }
    }

    public enum SelectedOperator
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }
}
