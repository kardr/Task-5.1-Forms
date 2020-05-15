using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_5._1_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            static double f(double x)
            {
                if ((x * x * x - 1) < 0 || (x * x - 1) < 0) throw new System.ArgumentException("Квадратный корень из отрицательного числа");
                if ((x * x - 1) == 0) throw new System.ArgumentException("Деление на ноль");
                else return Math.Sqrt(x * x * x - 1) / Math.Sqrt(x * x - 1);
            }
        private void button1_Click(object sender, EventArgs e)
        {
                try
                {
                    double a = double.Parse(textBox1.Text);
                    double b = double.Parse(textBox2.Text);
                    double h = double.Parse(textBox3.Text);
                    double x = a, y = 0;
                    while (x <= b)
                        try
                        {
                            y = f(x);
                           textBox4.Text += "\n\r"+ "x = " + x + " y = " + y + "\n\r";
                        }
                        catch (Exception ex)
                        {
                        textBox4.Text += "\n\r" + "x = "  + x + " error: " +  ex.Message + "\n\r";
                        }
                        finally
                        {
                            x += h;
                        }
                }
                catch (FormatException)
                {
                        textBox4.Text += "Неверный формат ввода данных";
                }
                catch (Exception E)
                {
                        MessageBox.Show(E.Message);
                }
        }
    }
}
