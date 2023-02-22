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
using static System.Net.Mime.MediaTypeNames;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_C(object sender, RoutedEventArgs e)
        {
            Input.Text = "";
        }

        private void Button_Click_Del(object sender, RoutedEventArgs e)
        {
            if (Input.Text.Length > 0)
                Input.Text = Input.Text.Remove(Input.Text.Length - 1);
        }

        private void Button_Click_Percent(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Division(object sender, RoutedEventArgs e)
        {
            Button btn = (sender as Button);
            string signs = "*/+-";
            if (Input.Text == "" || signs.Contains(Input.Text[Input.Text.Length - 1]))
                Input.Text += "";
            else
                Input.Text += btn.Content;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (Input.Text.Length != 0 && Input.Text[Input.Text.Length - 1] == ')') return; // Провеерка, чтоб после ")" можно было ставить только знак, а не цифру

                Button btn = (sender as Button);
            Input.Text += btn.Content;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (Input.Text.Length != 0 && Input.Text[Input.Text.Length - 1] == ')') return; // Провеерка, чтоб после ")" можно было ставить только знак, а не цифру

            Button btn = (sender as Button);
            Input.Text += btn.Content;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (Input.Text.Length != 0 && Input.Text[Input.Text.Length - 1] == ')') return; // Провеерка, чтоб после ")" можно было ставить только знак, а не цифру

            Button btn = (sender as Button);
            Input.Text += btn.Content;
        }

        private void Button_Click_Multiply(object sender, RoutedEventArgs e)
        {
            Button btn = (sender as Button);
            string signs = "*/+-";
            if (Input.Text == "" || signs.Contains(Input.Text[Input.Text.Length - 1]))
                Input.Text += "";
            else
                Input.Text += btn.Content;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (Input.Text.Length != 0 && Input.Text[Input.Text.Length - 1] == ')') return; // Провеерка, чтоб после ")" можно было ставить только знак, а не цифру

            Button btn = (sender as Button);
            Input.Text += btn.Content;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (Input.Text.Length != 0 && Input.Text[Input.Text.Length - 1] == ')') return; // Провеерка, чтоб после ")" можно было ставить только знак, а не цифру

            Button btn = (sender as Button);
            Input.Text += btn.Content;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (Input.Text.Length != 0 && Input.Text[Input.Text.Length - 1] == ')') return; // Провеерка, чтоб после ")" можно было ставить только знак, а не цифру

            Button btn = (sender as Button);
            Input.Text += btn.Content;
        }

        private void Button_Click_Minus(object sender, RoutedEventArgs e)
        {
            Button btn = (sender as Button);
            string signs = "*/+-";
            if (Input.Text == "" || signs.Contains(Input.Text[Input.Text.Length - 1]))
                Input.Text += "";
            else
                Input.Text += btn.Content;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Input.Text.Length != 0 && Input.Text[Input.Text.Length - 1] == ')') return; // Провеерка, чтоб после ")" можно было ставить только знак, а не цифру

            Button btn = (sender as Button);
            Input.Text += btn.Content;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Input.Text.Length != 0 && Input.Text[Input.Text.Length - 1] == ')') return; // Провеерка, чтоб после ")" можно было ставить только знак, а не цифру

            Button btn = (sender as Button);
            Input.Text += btn.Content;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (Input.Text.Length != 0 && Input.Text[Input.Text.Length - 1] == ')') return; // Провеерка, чтоб после ")" можно было ставить только знак, а не цифру

            Button btn = (sender as Button);
            Input.Text += btn.Content;
        }

        private void Button_Click_Plus(object sender, RoutedEventArgs e)
        {
            Button btn = (sender as Button);
            string signs = "*/+-";
            if (Input.Text == "" || signs.Contains(Input.Text[Input.Text.Length - 1]))
                Input.Text += "";
            else
                Input.Text += btn.Content;
        }

        private void Button_Click_Parentheses(object sender, RoutedEventArgs e)
        {
            Button btn = (sender as Button);
            if (!Input.Text.Contains('(') && !Input.Text.Contains(')')) // Если ввод не содержит скобок, ставим первую
            {
                Input.Text += "(";
            }
            else  // Если ввод содержит скибки заходим в условие
            {
                if (Input.Text[Input.Text.Length -1] == '(')
                {
                    Input.Text += "(";
                }
                else 
                {
                    int countLeft = 0, countRight = 0;
                    foreach (char el in Input.Text)
                    {
                        if(el == '(')
                            countLeft++;
                        if (el == ')')
                            countRight++;
                    }

                    if(countLeft > countRight)
                        Input.Text += ")";
                    else if(countLeft < countRight)
                        Input.Text += "(";
                    else if(countLeft == countRight && Input.Text[Input.Text.Length - 1] != ')')
                        Input.Text += "(";
                    else
                        return;

                }



            }
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            if (Input.Text.Length != 0 && Input.Text[Input.Text.Length - 1] == ')') return; // Провеерка, чтоб после ")" можно было ставить только знак, а не цифру

            Button btn = (sender as Button);
            Input.Text += btn.Content;
        }

        private void Button_Click_Point(object sender, RoutedEventArgs e)
        {
            if (Input.Text.Length != 0 && Input.Text[Input.Text.Length - 1] == ')') return; // Провеерка, чтоб после ")" можно было ставить только знак, а не цифру

            Button btn = (sender as Button);
            string signs = "*/+-";
            string numbers = "0123456789";
            // Вставка запятой
            if (Input.Text == "" || signs.Contains(Input.Text[Input.Text.Length - 1]))
                Input.Text += "0,";
            else if (Input.Text[Input.Text.Length - 1] == ',')
                Input.Text += "";
            else
            {
                for (int i = Input.Text.Length - 1; i >= 0; i--)
                {
                    if (i == 0 && numbers.Contains(Input.Text[i]))
                        Input.Text += btn.Content;

                    if (numbers.Contains(Input.Text[i]))
                        continue;
                    else if (Input.Text[i] == ',')
                        break;
                    else if (signs.Contains(Input.Text[i]))
                    {
                        Input.Text += btn.Content;
                        break;
                    }
                }
            }
        }

        private void Button_Click_Equal(object sender, RoutedEventArgs e)
        {
            string line = Input.Text;
            if (string.IsNullOrEmpty(line))
                return;

            List<string> mySolutions = FromStringToList(line);
            mySolutions = DelLastSign(mySolutions);
            mySolutions = SolutionOfMyList(mySolutions);

            //string numbers = "0123456789";
            //List<string> solutions = new List<string>();
            //string val = "";

            //// цикл разбиения строки на числа и знаки, и помещение их в лист
            //for (int i = 0; i < line.Length; i++)
            //{



            //    // Дополнение

            //    // При обнаружении скобки заходим в этот if
            //    if (line[i] == '(')
            //    {
            //        string prnthExpression = "";
            //        int lastIndex = Array.LastIndexOf(line.ToArray(), ')');
            //        if(lastIndex < 0)   // Если закрывающей скобки нет, то пропускаем текущую открывающую
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            prnthExpression = line.Substring(i+1, line.Length-i-(line.Length-lastIndex));
                        
            //        }
            //    }






            //    // Прежний код
            //    if (i == 0)
            //        if (line[i] == '-')
            //        {
            //            val += line[i];
            //            continue;
            //        }

            //    if (numbers.Contains(line[i]))
            //    {
            //        val += line[i].ToString();
            //        if (i == line.Length - 1)
            //            solutions.Add(val);
            //    }
            //    else if (line[i] == ',')
            //        val += line[i].ToString();
            //    else
            //    {
            //        solutions.Add(val);
            //        solutions.Add(line[i].ToString());
            //        val = "";
            //    }
            //}




            //// Проверка, если в выражении последним стоит знак - удаляем
            //if (!numbers.Contains( solutions[solutions.Count - 1] [solutions[solutions.Count - 1].Length-1] ))
            //    solutions.RemoveAt(solutions.Count - 1);
            //// Если последняя стоит запятая - удаляем
            //if (solutions[solutions.Count - 1] == ",")
            //    solutions.RemoveAt(solutions.Count - 1);





            // цикл решения выражений листа, пока в нем не останется единственное число
            //for (int i = 0; i < solutions.Count; i++)
            //{
            //    if (solutions.Contains("*") || solutions.Contains("/")) // Если в листе есть * или /, сначала выполняем эти действия. Если этих знаков нет, заходим в следующий if c + и -
            //    {
            //        if (solutions[i] == "*" || solutions[i] == "/")
            //        {
            //            string res = Expression(solutions[i - 1], solutions[i], solutions[i + 1]);
            //            if (res == "Ошибка!") 
            //            {
            //                solutions = new List<string> { res };
            //                break;
            //            }
            //            solutions.RemoveRange(i - 1, 3);
            //            solutions.Insert(i - 1, res);
            //            i = 0;
            //            continue;
            //        }
            //        else
            //            continue;
            //    }

            //    if (solutions[i] == "+" || solutions[i] == "-")
            //    {
            //        if (solutions[i] == "+" || solutions[i] == "-")
            //        {
            //            string res = Expression(solutions[i - 1], solutions[i], solutions[i + 1]);
            //            solutions.RemoveRange(i - 1, 3);
            //            solutions.Insert(i - 1, res);
            //            i = 0;
            //            continue;
            //        }
            //        else
            //            continue;
            //    }
            //}

           

            // Метод, который разбивает строку на числа и знаки, и помещение их в лист
            List<string> FromStringToList(string input)
            {
                string numbers = "0123456789";
                List<string> solutions = new List<string>();
                string val = "";

                for (int i = 0; i < input.Length; i++)
                {
                    //Проверка на первый минус (первое число отрицательное)
                    if (i == 0)
                        if (input[i] == '-')
                        {
                            val += input[i];
                            continue;
                        }

                    // При обнаружении скобки заходим в этот if
                    if (input[i] == '(')
                    {
                        string prnthExpression = "";
                        int lastIndex = Array.LastIndexOf(input.ToArray(), ')');
                        if (lastIndex < 0)   // Если закрывающей скобки нет, то пропускаем текущую открывающую
                        {
                            break;
                        }
                        else
                        {
                            prnthExpression = input.Substring(i + 1, input.Length - i - (input.Length - lastIndex));
                           
                            /////////////////////////// рекурсия???
                        }
                    }

                    // Логика разбиения
                    if (numbers.Contains(input[i]))
                    {
                        val += input[i].ToString();
                        if (i == input.Length - 1)
                            solutions.Add(val);
                    }
                    else if (input[i] == ',')
                        val += input[i].ToString();
                    else
                    {
                        solutions.Add(val);
                        solutions.Add(input[i].ToString());
                        val = "";
                    }
                }
                return solutions;
            }

            // Метод, который удаляет последние знаки или запятую
            List<string> DelLastSign(List<string> solutions)
            {
                string numbers = "0123456789";
                // Проверка, если в выражении последним стоит знак - удаляем
                if (!numbers.Contains(solutions[solutions.Count - 1][solutions[solutions.Count - 1].Length - 1]))
                    solutions.RemoveAt(solutions.Count - 1);
                // Если последняя стоит запятая - удаляем
                if (solutions[solutions.Count - 1] == ",")
                    solutions.RemoveAt(solutions.Count - 1);
                return solutions;
            }

            // Метод решения выражений листа, пока в нем не останется единственное число
            List<string> SolutionOfMyList(List<string> solutions)
            {
                for (int i = 0; i < solutions.Count; i++)
                {
                    if (solutions.Contains("*") || solutions.Contains("/")) // Если в листе есть * или /, сначала выполняем эти действия. Если этих знаков нет, заходим в следующий if c + и -
                    {
                        if (solutions[i] == "*" || solutions[i] == "/")
                        {
                            string res = Expression(solutions[i - 1], solutions[i], solutions[i + 1]);
                            if (res == "Ошибка!")
                            {
                                solutions = new List<string> { res };
                                break;
                            }
                            solutions.RemoveRange(i - 1, 3);
                            solutions.Insert(i - 1, res);
                            i = 0;
                            continue;
                        }
                        else
                            continue;
                    }

                    if (solutions[i] == "+" || solutions[i] == "-")
                    {
                        if (solutions[i] == "+" || solutions[i] == "-")
                        {
                            string res = Expression(solutions[i - 1], solutions[i], solutions[i + 1]);
                            solutions.RemoveRange(i - 1, 3);
                            solutions.Insert(i - 1, res);
                            i = 0;
                            continue;
                        }
                        else
                            continue;
                    }
                }
                return solutions;   
            }

            // Метод, который считает выражение из двух чисел
            string Expression(string num1, string sign, string num2)
            {
                double number1 = double.Parse(num1);
                double number2 = double.Parse(num2);

                switch (sign)
                {
                    case "*": return (number1 * number2).ToString();
                    case "/": return number2 != 0 ? (number1 / number2).ToString() : "Ошибка!";
                    case "+": return (number1 + number2).ToString();
                    case "-": return (number1 - number2).ToString();
                    default: return "";
                }
            }






            if (mySolutions.Count == 0)
                Input.Text = "";
            else
                Input.Text = mySolutions[0];
        }
    }
}
