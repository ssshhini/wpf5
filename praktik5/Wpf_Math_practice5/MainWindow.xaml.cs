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

namespace Wpf_Math_practice5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 1; i <= 30; i++)
            {
                TaskComboBox.Items.Add($"Task {i}");
            }
        }

        private void TaskComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedTask = TaskComboBox.SelectedItem as string;
            if (selectedTask != null)
            {
                int taskNumber = int.Parse(selectedTask.Split(' ')[1]);
                ResultTextBox.Text = SolveTask(taskNumber);
            }
        }

        private string SolveTask(int taskNumber)
        {
            switch (taskNumber)
            {
                case 1:
                    return SolveTask1().ToString();
                case 2:
                    return SolveTask2(123).ToString();
                case 3:
                    return SolveTask3(40, 50, 60).ToString();
                case 4:
                    return SolveTask4(30).ToString();
                case 5:
                    return SolveTask5(-100).ToString();
                case 6:
                    return SolveTask6(1, 0).ToString();
                case 7:
                    return SolveTask7(85, 75, 90).ToString();
                case 8:
                    return SolveTask8(true, false, false).ToString();
                case 9:
                    return SolveTask9(false, false, true).ToString();

                case 11:
                    return SolveTask11(-6).ToString();
                case 12:
                    return SolveTask12(10).ToString();
                case 13:
                    return SolveTask13(1000).ToString();
                case 14:
                    return SolveTask14(1, 2, 3, 4).ToString();
                case 15:
                    return SolveTask15(4).ToString();
                case 16:
                    return SolveTask16(-2).ToString();
                case 17:
                    return SolveTask17(5).ToString();
                case 18:
                    return SolveTask18(3).ToString();
                case 19:
                    return SolveTask19(2).ToString();
                case 20:
                    return SolveTask20(7).ToString();
                case 21:
                    return SolveTask21(6).ToString();
                case 22:
                    return SolveTask22(4).ToString();
                case 23:
                    return SolveTask23(3).ToString();
                case 24:
                    return SolveTask24(2).ToString();
                case 25:
                    return SolveTask25(1).ToString();
                case 26:
                    return SolveTask26(0).ToString();
                case 27:
                    return SolveTask27(-1).ToString();
                case 28:
                    return SolveTask28(4).ToString();
                case 29:
                    return SolveTask29(5).ToString();
                case 30:
                    return SolveTask30(6).ToString();
                default:
                    return "выберите другой номер";
            }
        }

        private bool SolveTask1()
        {
            int x = 2, y = 1;
            return (x * y != 0) || (y < x);
        }

        private bool SolveTask2(int A)
        {
            return A >= 100 && A <= 999;
        }

        private bool SolveTask3(int A, int B, int C)
        {
            int count = 0;
            if (A < 45) count++;
            if (B < 45) count++;
            if (C < 45) count++;
            return count == 1;
        }

        private bool SolveTask4(int A)
        {
            return A % 3 != 0 && A % 10 == 0;
        }

        private bool SolveTask5(int A)
        {
            return (A >= -137 && A <= -51) || (A >= 55 && A <= 123);
        }

        private bool SolveTask6(int X, int Y)
        {
            return -4 < Y && Y <= 2 && X > 0;
        }

        private bool SolveTask7(int X, int Y, int Z)
        {
            return X > 80 || Y > 80 || Z > 80;
        }

        private bool SolveTask8(bool A, bool B, bool C)
        {
            return A && !B || C;
        }

        private bool SolveTask9(bool A, bool B, bool C)
        {
            return !(!A || !B) && !C;
        }



        private bool SolveTask11(int x)
        {
            return !(x <= -5 && x > 5);
        }

        private bool SolveTask12(int A)
        {
            return !(A >= -10 && A <= -1) && !(A >= 2 && A <= 15);
        }

        private bool SolveTask13(int A)
        {
            return A >= 1000 && A <= 9999 && A != 4999;
        }

        private bool SolveTask14(int A, int B, int C, int D)
        {
            return (A / B) > (C / D);
        }

        private bool SolveTask15(int x)
        {
            return !(x > 0 && x < 5);
        }

        private bool SolveTask16(int x)
        {
            return x > 3 || x < -1;
        }

        private bool SolveTask17(int x)
        {
            return x > 0 && x < 7;
        }

        private bool SolveTask18(int x)
        {
            return x != 0;
        }

        private bool SolveTask19(int x)
        {
            return x > 0;
        }

        private bool SolveTask20(int x)
        {
            return x < 0;
        }

        private bool SolveTask21(int x)
        {
            return x >= 0;
        }

        private bool SolveTask22(int x)
        {
            return x <= 0;
        }

        private bool SolveTask23(int x)
        {
            return x == 0;
        }

        private bool SolveTask24(int x)
        {
            return x != 0;
        }

        private bool SolveTask25(int x)
        {
            return x > 0;
        }

        private bool SolveTask26(int x)
        {
            return x < 0;
        }

        private bool SolveTask27(int x)
        {
            return x >= 0;
        }

        private bool SolveTask28(int x)
        {
            return x != 3;
        }

        private bool SolveTask29(int x)
        {
            return x % 2 == 0;
        }

        private bool SolveTask30(int x)
        {
            return x % 2 != 0;
        }
    }
}
