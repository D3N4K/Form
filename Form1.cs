using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Введите a");
            double a = textbox1.ToDouble();
            Console.WriteLine("Введите b");
            double b = textbox2.ToDouble();
            Console.WriteLine("Введите c");
            double c = textbox3.ToDouble();
            double D = Math.Sqrt((b * b) - (4 * a * c));

            if (D == 0)
            {
                textbox4.Value="Так как дискриминант равен нулю то, квадратное уравнение имеет один действительный корень:";
                double x = -b / (2 * a);
                =$"x = {x}";
            }
            else if (D > 0)
            {
                double x1, x2;
                x1 = (-b + D) / (2 * a);
                x2 = (-b - D) / (2 * a);
                textbox4.Value = x1;
                textbox5.Value = x2;
            }
            else
            {
                textbox4.Value="Так как дискриминант меньше нуля, то уравнение не имеет действительных решений.";
            }
        }
    }
}
