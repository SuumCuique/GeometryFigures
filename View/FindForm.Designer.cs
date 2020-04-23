namespace GeometryFigures
{
    partial class FindForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResultFindTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TypeFigure = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FilterCondition = new System.Windows.Forms.ComboBox();
            this.FilterSize = new System.Windows.Forms.NumericUpDown();
            this.Find = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultFindTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterSize)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ResultFindTable);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 312);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Found Figures";
            // 
            // dataGridView1
            // 
            this.ResultFindTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultFindTable.Location = new System.Drawing.Point(6, 19);
            this.ResultFindTable.Name = "dataGridView1";
            this.ResultFindTable.ReadOnly = true;
            this.ResultFindTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResultFindTable.Size = new System.Drawing.Size(427, 285);
            this.ResultFindTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Find By Type Figure:";
            // 
            // TypeFigure
            // 
            this.TypeFigure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeFigure.FormattingEnabled = true;
            this.TypeFigure.Items.AddRange(new object[] {
            "All",
            "Circle",
            "Triangle",
            "Rectangle"});
            this.TypeFigure.Location = new System.Drawing.Point(583, 22);
            this.TypeFigure.Name = "TypeFigure";
            this.TypeFigure.Size = new System.Drawing.Size(121, 21);
            this.TypeFigure.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Find By Size Area:";
            // 
            // FilterCondition
            // 
            this.FilterCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterCondition.FormattingEnabled = true;
            this.FilterCondition.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.FilterCondition.Items.AddRange(new object[] {
            "Greater than",
            "Equal",
            "Lesser than "});
            this.FilterCondition.Location = new System.Drawing.Point(466, 113);
            this.FilterCondition.Name = "FilterCondition";
            this.FilterCondition.Size = new System.Drawing.Size(121, 21);
            this.FilterCondition.TabIndex = 6;
            // 
            // FilterSize
            // 
            this.FilterSize.Location = new System.Drawing.Point(606, 113);
            this.FilterSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FilterSize.Name = "FilterSize";
            this.FilterSize.Size = new System.Drawing.Size(98, 20);
            this.FilterSize.TabIndex = 7;
            this.FilterSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(538, 163);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(107, 23);
            this.Find.TabIndex = 8;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 333);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.FilterSize);
            this.Controls.Add(this.FilterCondition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypeFigure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(749, 372);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(749, 372);
            this.Name = "FindForm";
            this.Text = "Find Figures";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultFindTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ResultFindTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypeFigure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FilterCondition;
        private System.Windows.Forms.NumericUpDown FilterSize;
        private System.Windows.Forms.Button Find;
    }
}