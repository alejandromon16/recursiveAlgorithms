using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace recursiveAlgorithms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        public static int recursiveVectorSum(int[] vector, int index)
        {
            if (index == vector.Length)
            {
                return 0;
            }
            else
            {
                return vector[index] + recursiveVectorSum(vector, index + 1);
            }
        }
        public static int recursiveVectorMul(int[] vector, int index)
        {
            if (index == vector.Length)
            {
                return 0;
            }
            else
            {
                return vector[index] * recursiveVectorSum(vector, index + 1);
            }
        }
        public static int recursiveVectorMin(int[] vector, int index)
        {
            if (index == vector.Length)
            {
                return int.MaxValue;
            }
            else
            {
                int current = vector[index];
                int remainingMin = recursiveVectorMin(vector, index + 1);
                return Math.Min(current, remainingMin);
            }
        }
        public static int recursiveVectorMax(int[] vector, int index)
        {
            if (index == vector.Length)
            {
                return int.MaxValue;
            }
            else
            {
                int current = vector[index];
                int remainingMin = recursiveVectorMax(vector, index + 1);
                return Math.Max(current, remainingMin);
            }
        }

        public static int factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }
        public static int fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return fibonacci(n - 1) + fibonacci(n - 2);
            }
        }
        public static int reverse(int n)
        {
            if (n < 10)
            {
                return n;
            }
            else
            {
                int lastDigit = n % 10;
                int remainingDigits = n / 10;
                int reversedRemaining = reverse(remainingDigits);
                int reversed = int.Parse(lastDigit.ToString() + reversedRemaining.ToString());
                return reversed;
            }
        }
        public static int sumDigits(int n)
        {
            if (n < 10)
            {
                return n;
            }
            else
            {
                int lastDigit = n % 10;
                int remainingDigits = n / 10;
                int sumOfRemaining = sumDigits(remainingDigits);
                int sum = lastDigit + sumOfRemaining;
                return sum;
            }
        }

        public static bool isPalindrome(int num)
        {
            string str = num.ToString();

            if (str.Length <= 1) // Base case: A single digit or no digits left
            {
                return true;
            }
            else if (str[0] != str[str.Length - 1]) // Base case: First and last digit don't match
            {
                return false;
            }
            else // Recursive case: Check if the substring inside the first and last digit is a palindrome
            {
                return isPalindrome(int.Parse(str.Substring(1, str.Length - 2)));
            }
        }

        public static bool isEven(int n)
        {
            if (n == 0)
            {
                return true;
            }
            else if (n == 1)
            {
                return false;
            }
            else
            {
                return isEven(n - 2);
            }
        }
        public static bool isPositive(int n)
        {
            if (n == 0)
            {
                return false;
            }
            else if (n > 0)
            {
                return true;
            }
            else
            {
                return isPositive(n + 1);
            }
        }

        public int[] arr = { 1, 4, 8, 3, 2 };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonCapicua_Click(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(inputCapicua.Text);
            inputCapicua.Text = "";
            if (isPalindrome(value))
            {
                outputCapicua.Text = "Si es Capicua";
            }
            else
            {
                outputCapicua.Text = "No es Capicua";
            }
        }

        private void buttonFactorial_Click(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(inputFactorial.Text);
            outputFactorial.Text = factorial(value).ToString();

        }

        private void buttonSumToN(object sender, RoutedEventArgs e)
        {
            int val = sumDigits(int.Parse(inputSumToN.Text));
            outputSumToN.Text = val.ToString();
        }

        private void buttonEven_click(object sender, RoutedEventArgs e)
        {
            int val = int.Parse(inputEven.Text);
            if(isEven(val)) { outputEven.Text = "es par"; }
            else { outputEven.Text = "no es par"; }
        }

        private void buttonPositive(object sender, RoutedEventArgs e)
        {
            int val = int.Parse(inputPositive.Text);
            if(isPositive(val)) { outputPositive.Text = "es positivo"; }
            else
            {
                outputPositive.Text = "no es positivo";
            }
        }

        private void buttonReverse(object sender, RoutedEventArgs e)
        {
            int val = int.Parse(inputReverse.Text);
            outputReverse.Text = reverse(val).ToString();
        }

        private void buttonSumVect(object sender, RoutedEventArgs e)
        {
            outputSum.Text = recursiveVectorSum(arr,0).ToString();

        }

        private void buttonMulVect(object sender, RoutedEventArgs e)
        {
            outputMul.Text = recursiveVectorMul(arr,0).ToString();
        }

        private void buttonMinVect(object sender, RoutedEventArgs e)
        {
            outputMin.Text = recursiveVectorMin(arr,0).ToString();
        }

        private void buttonMaxVect(object sender, RoutedEventArgs e)
        {
            outputMax.Text = recursiveVectorMax(arr,0).ToString();
        }
    }
}
