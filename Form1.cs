using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1labaoopc
{
    public partial class Form1 : Form
    {
        private Circle circle;
        public Form1()
        {
            InitializeComponent();
            circle = new Circle();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = Convert.ToDouble(txtRadius.Text);
                circle.Radius = radius;
                circle.Center = new Point(0, 0);

                double area = circle.CalculateArea();
                lblResult.Text = $"Area: {area}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric value for the radius.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримання значення радіуса з TextBox
                double radius = Convert.ToDouble(txtRadius.Text);

                // Створення об'єкта Circle з введеним радіусом
                circle.Radius = radius;
                circle.Center = new Point(0, 0);
                // Обчислення периметра та відображення результату у Label
                double perimeter = circle.CalculatePerimeter();
                lblResult.Text = $"Perimeter: {perimeter}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric value for the radius.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckPoint_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримання значення координат x та y з TextBox
                int pointX = Convert.ToInt32(txtPointX.Text);
                int pointY = Convert.ToInt32(txtPointY.Text);

                // Створення об'єкта Point з введеними координатами
                Point point = new Point(pointX, pointY);
             
                circle.Center = point;

                // Перевірка, чи входить точка в середину кола
                bool isInside = circle.IsPointInside(point);

                // Відображення результату в MessageBox
                if (isInside)
                    MessageBox.Show("The point is inside the circle.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("The point is outside the circle.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for the point coordinates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
