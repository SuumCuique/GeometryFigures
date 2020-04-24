using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GeometryFigures {
    public partial class FindForm : Form {
        public List<Figure> list = new List<Figure>();
        public FindForm(List<Figure> tmp) {
            InitializeComponent();
            list = tmp;
            if(list.Count>0) {
                TypeFigure.SelectedIndex = 0;
                FilterCondition.SelectedIndex = 0;
                ResultFindTable.ColumnCount = 3;
                ResultFindTable.Columns[0].HeaderText = "ID";
                ResultFindTable.Columns[1].HeaderText = "Figure";
                ResultFindTable.Columns[2].HeaderText = "Area";
                for (int i = 0; i < list.Count(); i++) {
                    ResultFindTable.Rows[i].HeaderCell.Value = (i).ToString();
                    ResultFindTable.Rows.Add(Convert.ToString(i), list[i].GetType().ToString().Split('.')[1], list[i].ReturnArea());
                }
            }
        }

        private void Find_Click(object sender, EventArgs e) {
            string Item = TypeFigure.SelectedItem.ToString();

            if (Item != "All")
                for(int i = 0; i < ResultFindTable.Rows.Count-1; i++) {
                    if(ResultFindTable.Rows[i].Cells[1].Value.ToString() != Item)
                        ResultFindTable.Rows.RemoveAt(i--);
                }
            for (int i = 0; i < ResultFindTable.Rows.Count - 1; i++) {
                if (FilterCondition.SelectedIndex == 0) {
                    if (Convert.ToInt32(ResultFindTable.Rows[i].Cells[2].Value) <= Convert.ToInt32(FilterSize.Value))
                        ResultFindTable.Rows.RemoveAt(i--);
                }
                else if (FilterCondition.SelectedIndex == 1) {
                    if (Convert.ToInt32(ResultFindTable.Rows[i].Cells[2].Value) != Convert.ToInt32(FilterSize.Value))
                        ResultFindTable.Rows.RemoveAt(i--);
                }
                else if (FilterCondition.SelectedIndex == 2) {
                    if (Convert.ToInt32(ResultFindTable.Rows[i].Cells[2].Value) >= Convert.ToInt32(FilterSize.Value))
                        ResultFindTable.Rows.RemoveAt(i--);
                }
            }
        }
    }
}
