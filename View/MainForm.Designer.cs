namespace GeometryFigures
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TableFigures = new System.Windows.Forms.DataGridView();
            this.AddFigure = new System.Windows.Forms.Button();
            this.RemoveFigure = new System.Windows.Forms.Button();
            this.CreateRandomData = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindFigures = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableFigures)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TableFigures);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 312);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Figures";
            // 
            // TableFigures
            // 
            this.TableFigures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableFigures.Location = new System.Drawing.Point(6, 19);
            this.TableFigures.Name = "TableFigures";
            this.TableFigures.ReadOnly = true;
            this.TableFigures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableFigures.Size = new System.Drawing.Size(427, 285);
            this.TableFigures.TabIndex = 0;
            // 
            // AddFigure
            // 
            this.AddFigure.Location = new System.Drawing.Point(476, 46);
            this.AddFigure.Name = "AddFigure";
            this.AddFigure.Size = new System.Drawing.Size(117, 23);
            this.AddFigure.TabIndex = 2;
            this.AddFigure.Text = "Add Figure";
            this.AddFigure.UseVisualStyleBackColor = true;
            this.AddFigure.Click += new System.EventHandler(this.AddFigure_Click);
            // 
            // RemoveFigure
            // 
            this.RemoveFigure.Location = new System.Drawing.Point(475, 75);
            this.RemoveFigure.Name = "RemoveFigure";
            this.RemoveFigure.Size = new System.Drawing.Size(117, 23);
            this.RemoveFigure.TabIndex = 1;
            this.RemoveFigure.Text = "Remove Figure";
            this.RemoveFigure.UseVisualStyleBackColor = true;
            this.RemoveFigure.Click += new System.EventHandler(this.RemoveFigure_Click);
            // 
            // CreateRandomData
            // 
            this.CreateRandomData.AutoSize = true;
            this.CreateRandomData.Location = new System.Drawing.Point(476, 104);
            this.CreateRandomData.Name = "CreateRandomData";
            this.CreateRandomData.Size = new System.Drawing.Size(117, 23);
            this.CreateRandomData.TabIndex = 3;
            this.CreateRandomData.Text = "Create Random Data";
            this.CreateRandomData.UseVisualStyleBackColor = true;
            this.CreateRandomData.Click += new System.EventHandler(this.CreateRandomData_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(605, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FindFigures
            // 
            this.FindFigures.AutoSize = true;
            this.FindFigures.Location = new System.Drawing.Point(476, 133);
            this.FindFigures.Name = "FindFigures";
            this.FindFigures.Size = new System.Drawing.Size(117, 23);
            this.FindFigures.TabIndex = 5;
            this.FindFigures.Text = "Find Figures";
            this.FindFigures.UseVisualStyleBackColor = true;
            this.FindFigures.Click += new System.EventHandler(this.FindFigures_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 347);
            this.Controls.Add(this.FindFigures);
            this.Controls.Add(this.CreateRandomData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddFigure);
            this.Controls.Add(this.RemoveFigure);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(621, 386);
            this.MinimumSize = new System.Drawing.Size(621, 386);
            this.Name = "MainForm";
            this.Text = "Figures";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableFigures)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddFigure;
        private System.Windows.Forms.Button RemoveFigure;
        private System.Windows.Forms.DataGridView TableFigures;
        private System.Windows.Forms.Button CreateRandomData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button FindFigures;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

