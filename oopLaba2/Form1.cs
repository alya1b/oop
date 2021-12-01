using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopLaba2
{
    public partial class Pensia : Form
    {
        private string path;
        private readonly string pathXsl = @"XSL.xsl";
        private readonly string pathHtml = @"HTML.html";
        private bool istoHtmlPressed = false;
        bool isNew;

        public Pensia()
        {
            InitializeComponent();
        }
        /*--OPEN File segment--*/
        bool IsStratagyChosen = false;

        private void SAX_button_CheckedChanged(object sender, EventArgs e)
        {
            Global.ParsingStrategy = new SAX();
            IsStratagyChosen = true;
        }

        private void DOM_button_CheckedChanged(object sender, EventArgs e)
        {
            Global.ParsingStrategy = new DOM();
            IsStratagyChosen = true;
        }

        private void LINQ_button_CheckedChanged(object sender, EventArgs e)
        {
            Global.ParsingStrategy = new LINQ();
            IsStratagyChosen = true;
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            if (!IsStratagyChosen)
            {
                MessageBox.Show("You should choose an option!!!");
                return;
            }

            if ( openFile.ShowDialog() == DialogResult.Cancel)
                return;

            Global.ParsingStrategy.Parse(openFile.FileName);

            outData(Global.FileData);

            var namelist = new List<string>();
            var departmentlist = new List<string>();
            var cathedralist = new List<string>();
            var datalist = new List<string>();
            var degreelist = new List<string>();
            var genderlist = new List<string>();

            foreach(var worker in Global.FileData)
            {
                if (! namelist.Contains(worker.Name)) { namelist.Add(worker.Name); }
                if (! departmentlist.Contains(worker.Department)) { departmentlist.Add(worker.Department); }
                if (! cathedralist.Contains(worker.Cathedra)) { cathedralist.Add(worker.Cathedra); }
                if (! datalist.Contains(worker.Date)) { datalist.Add(worker.Date); }
                if (! degreelist.Contains(worker.Degree)) { degreelist.Add(worker.Degree); }
                if (! genderlist.Contains(worker.Gender)) { genderlist.Add(worker.Gender); }
            }

            name_box.DataSource = namelist;
            departament_box.DataSource = departmentlist;
            cathedra_box.DataSource = cathedralist;
            date_box.DataSource = datalist;
            degree_box.DataSource = degreelist;
            gender_box.DataSource = genderlist;
        }

        private void outData(List<Worker> data)
        {
            Table.Columns.Clear();
            Table.Rows.Clear();

            foreach
               (
               var columnName in Global.Field
               )
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderCell.Value = columnName;
                Table.Columns.Add(column);
            }
            foreach
                (
                var worker in data
                )
            {
                Table.Rows.Add(new DataGridViewRow());

                Table.Rows[Table.RowCount - 1].Cells[0].Value = worker.Name;
                Table.Rows[Table.RowCount - 1].Cells[1].Value = worker.Department;
                Table.Rows[Table.RowCount - 1].Cells[2].Value = worker.Cathedra;
                Table.Rows[Table.RowCount - 1].Cells[3].Value = worker.Date;
                Table.Rows[Table.RowCount - 1].Cells[4].Value = worker.Degree;
                Table.Rows[Table.RowCount - 1].Cells[5].Value = worker.Gender;

            }
        }

    


        /*--Search segment--*/

        private void name_CheckedChanged(object sender, EventArgs e)
        {
            if (name.Checked == true)
            {
                Global.ActiveFilter.Add("name", null);
                Global.ActiveFilter["name"] = name_box.SelectedItem.ToString();
            }
            else
            {
                Global.ActiveFilter.Remove("name");
            }
        }

        private void department_CheckedChanged(object sender, EventArgs e)
        {
            if (department.Checked == true)
            {
                Global.ActiveFilter.Add("department", null);
                Global.ActiveFilter["department"] = departament_box.SelectedItem.ToString();
            }
            else
            {
                Global.ActiveFilter.Remove("department");
            }
        }

        private void cathedra_CheckedChanged(object sender, EventArgs e)
        {
            if (cathedra.Checked == true)
            {
                Global.ActiveFilter.Add("cathedra", null);
                Global.ActiveFilter["cathedra"] = cathedra_box.SelectedItem.ToString();

            }
            else
            {
                Global.ActiveFilter.Remove("cathedra");
            }
        }

        private void date_CheckedChanged(object sender, EventArgs e)
        {
            if (date.Checked == true)
            {
                Global.ActiveFilter.Add("date", null);
                Global.ActiveFilter["date"] = date_box.SelectedItem.ToString();
            }
            else
            {
                Global.ActiveFilter.Remove("date");
            }
        }

        private void degree_CheckedChanged(object sender, EventArgs e)
        {
            if (degree.Checked == true)
            {
                Global.ActiveFilter.Add("degree", null);
                Global.ActiveFilter["degree"] = degree_box.SelectedItem.ToString();

            }
            else
            {
                Global.ActiveFilter.Remove("degree");
            }
        }

        private void gender_CheckedChanged(object sender, EventArgs e)
        {
            if (gender.Checked == true)
            {
                Global.ActiveFilter.Add("gender", null);
                Global.ActiveFilter["gender"] = gender_box.SelectedItem.ToString();
            }
            else
            {
                Global.ActiveFilter.Remove("gender");
            }

        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            var filterData = new List<Worker>();

            if (Global.ActiveFilter.TryGetValue("name", out var name))
            {
                foreach (var worker in Global.FileData)
                {
                    if (worker.Name == name && !filterData.Contains(worker)) filterData.Add(worker);
                }
            }

            if (Global.ActiveFilter.TryGetValue("department", out var department))
            {
                foreach (var worker in Global.FileData)
                {
                    if (worker.Department == department && !filterData.Contains(worker)) filterData.Add(worker);
                }
            }

            if (Global.ActiveFilter.TryGetValue("cathedra", out var cathedra))
            {
                foreach (var worker in Global.FileData)
                {
                    if (worker.Cathedra == cathedra && !filterData.Contains(worker)) filterData.Add(worker);
                }
            }

            if (Global.ActiveFilter.TryGetValue("date", out var date))
            {
                foreach (var worker in Global.FileData)
                {
                    if (worker.Date == date && !filterData.Contains(worker)) filterData.Add(worker);
                }
            }

            if (Global.ActiveFilter.TryGetValue("degree", out var degree))
            {
                foreach (var worker in Global.FileData)
                {
                    if (worker.Degree == degree && !filterData.Contains(worker)) filterData.Add(worker);
                }
            }

            if (Global.ActiveFilter.TryGetValue("gender", out var gender))
            {
                foreach (var worker in Global.FileData)
                {
                    if (worker.Gender == gender && !filterData.Contains(worker)) filterData.Add(worker);
                }
            }

            if (filterData.Count == 0)
            {
                outData(Global.FileData);
            }
            else
                outData(filterData);
        }
    
        
        private void name_box_SelectedValueChanged(object sender, EventArgs e)
        {
            if (name.Checked == true)
                Global.ActiveFilter["name"] = name_box.SelectedItem.ToString();
        }

        private void departament_box_SelectedValueChanged(object sender, EventArgs e)
        {
            if (name.Checked == true)
                Global.ActiveFilter["departament"] = departament_box.SelectedItem.ToString();
        }

        private void cathedra_box_SelectedValueChanged(object sender, EventArgs e)
        {
            if (name.Checked == true)
                Global.ActiveFilter["cathedra"] = cathedra_box.SelectedItem.ToString();
        }

        private void date_box_SelectedValueChanged(object sender, EventArgs e)
        {
            if (name.Checked == true)
                Global.ActiveFilter["date"] = date_box.SelectedItem.ToString();
        }

        private void degree_box_SelectedValueChanged(object sender, EventArgs e)
        {
            if (name.Checked == true)
                Global.ActiveFilter["degree"] = degree_box.SelectedItem.ToString();
        }

        private void gender_box_SelectedValueChanged(object sender, EventArgs e)
        {
            if (name.Checked == true)
                Global.ActiveFilter["gender"] = gender_box.SelectedItem.ToString();
        }

        /*--Covert segment--*/
        private void Convert_button_Click(object sender, EventArgs e)
        {
            if(saveFile.ShowDialog() == DialogResult.Cancel)
                return;
           Converter.ToHtml(Table, saveFile.FileName);
        }
    }
}
