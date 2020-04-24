using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GeometryFigures {
    public partial class MainForm : Form {
        public List<Figure> list = new List<Figure>();
        public MainForm() {
            InitializeComponent();
            TableFigures.ColumnCount = 3;
            TableFigures.Columns[0].HeaderText = "ID";
            TableFigures.Columns[1].HeaderText = "Figure";
            TableFigures.Columns[2].HeaderText = "Area";
            for (int i = 0; i < list.Count(); i++) {
                TableFigures.Rows[i].HeaderCell.Value = (i).ToString();
                TableFigures.Columns[i].HeaderCell.Value = (i).ToString();
                TableFigures.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        CreateFigureForm form = new CreateFigureForm();

        private void AddFigure_Click(object sender, EventArgs e) {
            form.Show();
            form.VisibleChanged += new System.EventHandler(this.CreateFigureForm_VisibleChanged);
        }

        private void CreateFigureForm_VisibleChanged(object sender, EventArgs e) {
            if (form.list.Count != 0) {
                list.Add(form.list.First());
                if (TableFigures.Rows.Count == 0)
                    TableFigures.Rows.Add(Convert.ToString(list.Count - 1), list.Last().GetType().ToString().Split('.')[1], list.Last().ReturnArea());
                else {
                    int x = TableFigures.Rows.Count - 1;
                    int id;
                    if (x>0) id = Convert.ToInt32(TableFigures.Rows[TableFigures.Rows.Count - 2].Cells[0].Value.ToString()) + 1;
                    else id = 0;
                    TableFigures.Rows.Add(Convert.ToString(id), list.Last().GetType().ToString().Split('.')[1], list.Last().ReturnArea());
                }
                form.list.Clear();
            }
        }

        private void RemoveFigure_Click(object sender, EventArgs e) {
            if(TableFigures.SelectedRows.Count > 0 && TableFigures.Rows.Count>1) {
                int index = Convert.ToInt32(TableFigures.SelectedRows[0].Index);
                if (index < TableFigures.Rows.Count - 1) {
                    list.RemoveAt(index);
                    TableFigures.Rows.RemoveAt(index);
                }
            }
        }

        private void CreateRandomData_Click(object sender, EventArgs e) {
            TableFigures.Rows.Clear();
            list.Clear();
            Random rand = new Random();
            Figure figure = new Circle();
            for(int i=0;i<10;i++) {
                int x= rand.Next(1, 4);
                switch (x) {
                    case 1:
                        Circle circle= new Circle(rand.Next(1, 11));
                        circle.CalculateArea();
                        figure = circle;
                        break;
                    case 2:
                        Triangle triangle = new Triangle(rand.Next(1, 11), rand.Next(1, 11), rand.Next(1, 11));
                        triangle.CalculateArea();
                        figure = triangle;
                        break;
                    case 3:
                        Rectangle rectangle= new Rectangle(rand.Next(1, 11), rand.Next(1, 11));
                        rectangle.CalculateArea();
                        figure = rectangle;
                        break;
                }
                list.Add(figure);
                TableFigures.Rows.Add(Convert.ToString(i), figure.GetType().ToString().Split('.')[1], figure.ReturnArea());
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void FindFigures_Click(object sender, EventArgs e) {
            if (list.Count == 0)
                MessageBox.Show("List of Figures is empty!");
            else {
                FindForm findForm = new FindForm(list);
                findForm.Show();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (list.Count > 0) {
                saveFileDialog1.Filter = "Figures|*.figures";
                saveFileDialog1.ShowDialog();
                if(File.Exists(saveFileDialog1.FileName))
                    File.Delete(saveFileDialog1.FileName);
                XmlSerializer formatter = new XmlSerializer(typeof(List<Figure>));
                using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate)) {
                    formatter.Serialize(fs, list);
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            openFileDialog1.Filter = "Figures|*.figures";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Figure>));
            using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate)) {
                double result = 0;
                list = (List<Figure>)formatter.Deserialize(fs);
                TableFigures.Rows.Clear();
                for(int i = 0; i < list.Count; i++) {
                    if(double.IsNaN(list[i].Area))
                        MessageBox.Show("Фигура с ID " + i.ToString() + " имеет неверное значение!");
                    TableFigures.Rows.Add(Convert.ToString(i), list[i].GetType().ToString().Split('.')[1],list[i].Area);
                }
            }
        }
    }
}
