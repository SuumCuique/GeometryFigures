using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeometryFigures
{
    public partial class CreateFigureForm : Form
    {
        public List<Figure> list = new List<Figure>();
        
        public CreateFigureForm()
        {
            InitializeComponent();
            TypeFigure.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeFigure.SelectedIndex == 0)
            {
                label2.Text = "Radius:";
                label3.Visible = false;
                label4.Visible = false;
                SideB.Visible = false;
                SideC.Visible = false;
                SideA.Value= 1;
            }
            else if (TypeFigure.SelectedIndex == 1)
            {
                label2.Text = "Side A:";
                label3.Visible = true;
                label4.Visible = true;
                SideB.Visible = true;
                SideC.Visible = true;
                SideA.Value = 1;
                SideB.Value = 1;
                SideC.Value = 1;
            }
            else if (TypeFigure.SelectedIndex == 2)
            {
                label2.Text = "Side A:";
                label3.Visible = true;
                label4.Visible = false;
                SideB.Visible = true;
                SideC.Visible = false;
                SideA.Value = 1;
                SideB.Value = 1;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (TypeFigure.SelectedIndex == 0)
            {
                Circle circle = new Circle(Convert.ToDouble(SideA.Text));
                circle.CalculateArea();
                list.Add(circle);
            }
            else if (TypeFigure.SelectedIndex == 1)
            {
                Triangle triangle = new Triangle(Convert.ToDouble(SideA.Text), Convert.ToDouble(SideB.Text), Convert.ToDouble(SideC.Text));
                triangle.CalculateArea();
                list.Add(triangle);
            }
            else if (TypeFigure.SelectedIndex == 2)
            {
                Rectangle rectangle = new Rectangle(Convert.ToDouble(SideA.Text), Convert.ToDouble(SideB.Text));
                rectangle.CalculateArea();
                list.Add(rectangle);
            }
            Hide();
        }
    }
}
