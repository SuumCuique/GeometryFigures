namespace GeometryFigures
{
    partial class CreateFigureForm
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
			this.TypeFigure = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Ok = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.SideA = new System.Windows.Forms.NumericUpDown();
			this.SideB = new System.Windows.Forms.NumericUpDown();
			this.SideC = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.SideA)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SideB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SideC)).BeginInit();
			this.SuspendLayout();
			// 
			// TypeFigure
			// 
			this.TypeFigure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TypeFigure.FormattingEnabled = true;
			this.TypeFigure.Items.AddRange(new object[] {
            "Circle",
            "Triangle",
            "Rectangle"});
			this.TypeFigure.Location = new System.Drawing.Point(123, 12);
			this.TypeFigure.Name = "TypeFigure";
			this.TypeFigure.Size = new System.Drawing.Size(121, 21);
			this.TypeFigure.TabIndex = 0;
			this.TypeFigure.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Type Figure:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Radius:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Side B:";
			this.label3.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(32, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Side C:";
			this.label4.Visible = false;
			// 
			// Ok
			// 
			this.Ok.Location = new System.Drawing.Point(23, 171);
			this.Ok.Name = "Ok";
			this.Ok.Size = new System.Drawing.Size(75, 23);
			this.Ok.TabIndex = 8;
			this.Ok.Text = "Ok";
			this.Ok.UseVisualStyleBackColor = true;
			this.Ok.Click += new System.EventHandler(this.Ok_Click);
			// 
			// Cancel
			// 
			this.Cancel.Location = new System.Drawing.Point(169, 171);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(75, 23);
			this.Cancel.TabIndex = 9;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// SideA
			// 
			this.SideA.DecimalPlaces = 2;
			this.SideA.Location = new System.Drawing.Point(124, 50);
			this.SideA.Name = "SideA";
			this.SideA.Size = new System.Drawing.Size(120, 20);
			this.SideA.TabIndex = 16;
			this.SideA.ThousandsSeparator = true;
			// 
			// SideB
			// 
			this.SideB.DecimalPlaces = 2;
			this.SideB.Location = new System.Drawing.Point(124, 87);
			this.SideB.Name = "SideB";
			this.SideB.Size = new System.Drawing.Size(120, 20);
			this.SideB.TabIndex = 17;
			// 
			// SideC
			// 
			this.SideC.DecimalPlaces = 2;
			this.SideC.Location = new System.Drawing.Point(124, 123);
			this.SideC.Name = "SideC";
			this.SideC.Size = new System.Drawing.Size(120, 20);
			this.SideC.TabIndex = 18;
			this.SideC.ThousandsSeparator = true;
			// 
			// CreateFigureForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 216);
			this.ControlBox = false;
			this.Controls.Add(this.SideC);
			this.Controls.Add(this.SideB);
			this.Controls.Add(this.SideA);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.Ok);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TypeFigure);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(309, 255);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(309, 255);
			this.Name = "CreateFigureForm";
			this.Text = "Create Figure";
			((System.ComponentModel.ISupportInitialize)(this.SideA)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SideB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SideC)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TypeFigure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.NumericUpDown SideA;
		private System.Windows.Forms.NumericUpDown SideB;
		private System.Windows.Forms.NumericUpDown SideC;
	}
}