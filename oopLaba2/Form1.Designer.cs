namespace oopLaba2
{
    partial class Pensia
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
            this.Table = new System.Windows.Forms.DataGridView();
            this.open_button = new System.Windows.Forms.Button();
            this.SAX_button = new System.Windows.Forms.RadioButton();
            this.DOM_button = new System.Windows.Forms.RadioButton();
            this.LINQ_button = new System.Windows.Forms.RadioButton();
            this.name = new System.Windows.Forms.CheckBox();
            this.department = new System.Windows.Forms.CheckBox();
            this.cathedra = new System.Windows.Forms.CheckBox();
            this.date = new System.Windows.Forms.CheckBox();
            this.degree = new System.Windows.Forms.CheckBox();
            this.gender = new System.Windows.Forms.CheckBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.Convert_button = new System.Windows.Forms.Button();
            this.name_box = new System.Windows.Forms.ComboBox();
            this.departament_box = new System.Windows.Forms.ComboBox();
            this.cathedra_box = new System.Windows.Forms.ComboBox();
            this.date_box = new System.Windows.Forms.ComboBox();
            this.degree_box = new System.Windows.Forms.ComboBox();
            this.gender_box = new System.Windows.Forms.ComboBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(269, 28);
            this.Table.Name = "Table";
            this.Table.RowTemplate.Height = 24;
            this.Table.Size = new System.Drawing.Size(648, 340);
            this.Table.TabIndex = 0;
            // 
            // open_button
            // 
            this.open_button.Location = new System.Drawing.Point(70, 135);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(85, 31);
            this.open_button.TabIndex = 1;
            this.open_button.Text = "Open File";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // SAX_button
            // 
            this.SAX_button.AutoSize = true;
            this.SAX_button.Location = new System.Drawing.Point(40, 28);
            this.SAX_button.Name = "SAX_button";
            this.SAX_button.Size = new System.Drawing.Size(56, 21);
            this.SAX_button.TabIndex = 2;
            this.SAX_button.Text = "SAX";
            this.SAX_button.UseVisualStyleBackColor = true;
            this.SAX_button.CheckedChanged += new System.EventHandler(this.SAX_button_CheckedChanged);
            // 
            // DOM_button
            // 
            this.DOM_button.AutoSize = true;
            this.DOM_button.Location = new System.Drawing.Point(40, 65);
            this.DOM_button.Name = "DOM_button";
            this.DOM_button.Size = new System.Drawing.Size(61, 21);
            this.DOM_button.TabIndex = 3;
            this.DOM_button.Text = "DOM";
            this.DOM_button.UseVisualStyleBackColor = true;
            this.DOM_button.CheckedChanged += new System.EventHandler(this.DOM_button_CheckedChanged);
            // 
            // LINQ_button
            // 
            this.LINQ_button.AutoSize = true;
            this.LINQ_button.Location = new System.Drawing.Point(40, 102);
            this.LINQ_button.Name = "LINQ_button";
            this.LINQ_button.Size = new System.Drawing.Size(61, 21);
            this.LINQ_button.TabIndex = 4;
            this.LINQ_button.Text = "LINQ";
            this.LINQ_button.UseVisualStyleBackColor = true;
            this.LINQ_button.CheckedChanged += new System.EventHandler(this.LINQ_button_CheckedChanged);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(19, 195);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(67, 21);
            this.name.TabIndex = 5;
            this.name.Text = "Name";
            this.name.UseVisualStyleBackColor = true;
            this.name.CheckedChanged += new System.EventHandler(this.name_CheckedChanged);
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.Location = new System.Drawing.Point(19, 234);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(104, 21);
            this.department.TabIndex = 6;
            this.department.Text = "Department";
            this.department.UseVisualStyleBackColor = true;
            this.department.CheckedChanged += new System.EventHandler(this.department_CheckedChanged);
            // 
            // cathedra
            // 
            this.cathedra.AutoSize = true;
            this.cathedra.Location = new System.Drawing.Point(19, 274);
            this.cathedra.Name = "cathedra";
            this.cathedra.Size = new System.Drawing.Size(88, 21);
            this.cathedra.TabIndex = 7;
            this.cathedra.Text = "Cathedra";
            this.cathedra.UseVisualStyleBackColor = true;
            this.cathedra.CheckedChanged += new System.EventHandler(this.cathedra_CheckedChanged);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(20, 315);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(60, 21);
            this.date.TabIndex = 8;
            this.date.Text = "Date";
            this.date.UseVisualStyleBackColor = true;
            this.date.CheckedChanged += new System.EventHandler(this.date_CheckedChanged);
            // 
            // degree
            // 
            this.degree.AutoSize = true;
            this.degree.Location = new System.Drawing.Point(20, 362);
            this.degree.Name = "degree";
            this.degree.Size = new System.Drawing.Size(77, 21);
            this.degree.TabIndex = 9;
            this.degree.Text = "Degree";
            this.degree.UseVisualStyleBackColor = true;
            this.degree.CheckedChanged += new System.EventHandler(this.degree_CheckedChanged);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(19, 398);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(78, 21);
            this.gender.TabIndex = 10;
            this.gender.Text = "Gender";
            this.gender.UseVisualStyleBackColor = true;
            this.gender.CheckedChanged += new System.EventHandler(this.gender_CheckedChanged);
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(86, 438);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(85, 29);
            this.Search_button.TabIndex = 11;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Convert_button
            // 
            this.Convert_button.Location = new System.Drawing.Point(516, 398);
            this.Convert_button.Name = "Convert_button";
            this.Convert_button.Size = new System.Drawing.Size(185, 33);
            this.Convert_button.TabIndex = 12;
            this.Convert_button.Text = "Convert to HTML";
            this.Convert_button.UseVisualStyleBackColor = true;
            this.Convert_button.Click += new System.EventHandler(this.Convert_button_Click);
            // 
            // name_box
            // 
            this.name_box.FormattingEnabled = true;
            this.name_box.Location = new System.Drawing.Point(92, 195);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(151, 24);
            this.name_box.TabIndex = 13;
            this.name_box.SelectedValueChanged += new System.EventHandler(this.name_box_SelectedValueChanged);
            // 
            // departament_box
            // 
            this.departament_box.FormattingEnabled = true;
            this.departament_box.Location = new System.Drawing.Point(122, 234);
            this.departament_box.Name = "departament_box";
            this.departament_box.Size = new System.Drawing.Size(121, 24);
            this.departament_box.TabIndex = 14;
            this.departament_box.SelectedValueChanged += new System.EventHandler(this.departament_box_SelectedValueChanged);
            // 
            // cathedra_box
            // 
            this.cathedra_box.FormattingEnabled = true;
            this.cathedra_box.Location = new System.Drawing.Point(113, 274);
            this.cathedra_box.Name = "cathedra_box";
            this.cathedra_box.Size = new System.Drawing.Size(130, 24);
            this.cathedra_box.TabIndex = 15;
            this.cathedra_box.SelectedValueChanged += new System.EventHandler(this.cathedra_box_SelectedValueChanged);
            // 
            // date_box
            // 
            this.date_box.FormattingEnabled = true;
            this.date_box.Location = new System.Drawing.Point(92, 315);
            this.date_box.Name = "date_box";
            this.date_box.Size = new System.Drawing.Size(151, 24);
            this.date_box.TabIndex = 16;
            this.date_box.SelectedValueChanged += new System.EventHandler(this.date_box_SelectedValueChanged);
            // 
            // degree_box
            // 
            this.degree_box.FormattingEnabled = true;
            this.degree_box.Location = new System.Drawing.Point(103, 362);
            this.degree_box.Name = "degree_box";
            this.degree_box.Size = new System.Drawing.Size(140, 24);
            this.degree_box.TabIndex = 17;
            this.degree_box.SelectedValueChanged += new System.EventHandler(this.degree_box_SelectedValueChanged);
            // 
            // gender_box
            // 
            this.gender_box.FormattingEnabled = true;
            this.gender_box.Location = new System.Drawing.Point(103, 398);
            this.gender_box.Name = "gender_box";
            this.gender_box.Size = new System.Drawing.Size(140, 24);
            this.gender_box.TabIndex = 18;
            this.gender_box.SelectedValueChanged += new System.EventHandler(this.gender_box_SelectedValueChanged);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // Pensia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 493);
            this.Controls.Add(this.gender_box);
            this.Controls.Add(this.degree_box);
            this.Controls.Add(this.date_box);
            this.Controls.Add(this.cathedra_box);
            this.Controls.Add(this.departament_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.Convert_button);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.degree);
            this.Controls.Add(this.date);
            this.Controls.Add(this.cathedra);
            this.Controls.Add(this.department);
            this.Controls.Add(this.name);
            this.Controls.Add(this.LINQ_button);
            this.Controls.Add(this.DOM_button);
            this.Controls.Add(this.SAX_button);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.Table);
            this.Name = "Pensia";
            this.Text = "Pensia";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.RadioButton SAX_button;
        private System.Windows.Forms.RadioButton DOM_button;
        private System.Windows.Forms.RadioButton LINQ_button;
        private System.Windows.Forms.CheckBox name;
        private System.Windows.Forms.CheckBox department;
        private System.Windows.Forms.CheckBox cathedra;
        private System.Windows.Forms.CheckBox date;
        private System.Windows.Forms.CheckBox degree;
        private System.Windows.Forms.CheckBox gender;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button Convert_button;
        private System.Windows.Forms.ComboBox name_box;
        private System.Windows.Forms.ComboBox departament_box;
        private System.Windows.Forms.ComboBox cathedra_box;
        private System.Windows.Forms.ComboBox date_box;
        private System.Windows.Forms.ComboBox degree_box;
        private System.Windows.Forms.ComboBox gender_box;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}

