using Kbg.NppPluginNET.PluginInfrastructure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MarkdownTableGenerator.Forms
{
    public partial class TableGenerator : Form
    {
        private int _columnIndex = 0;
        private int columnIndex
        {
            get{
                return _columnIndex++;
            }
        }
        public TableGenerator()
        {
            InitializeComponent();
            ClearTable();
        }

        private void addColumnButton_Click(object sender, EventArgs e)
        {
            var newcol = new DataGridViewTextBoxColumn();
            //newcol.HeaderText = "Column" + columnIndex;
            //newcol.Name = newcol.HeaderText;
            this.dataGridView.Columns.AddRange(new DataGridViewColumn[] { newcol });
        }

        private void deleteColumnButton_Click(object sender, EventArgs e)
        {
            var selected = this.dataGridView.SelectedCells;
            foreach (DataGridViewTextBoxCell i in selected)
                this.dataGridView.Columns.RemoveAt(i.ColumnIndex);
        }
        private void ClearTable()
        {
            this.dataGridView.Columns.Clear();
            var firstcol = new DataGridViewTextBoxColumn();

            //firstcol.HeaderText = "Column" + columnIndex;
            //firstcol.Name = firstcol.HeaderText;

            this.dataGridView.Columns.AddRange(new DataGridViewColumn[] { firstcol });
        }
        private void clearTableButton_Click(object sender, EventArgs e)
        {
            ClearTable();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                string output = "";
                
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (CheckForEmptyRow(row))
                        continue;
                    if (row != null && row.Cells != null)
                    {
                        output += "| ";
                        foreach (DataGridViewTextBoxCell cell in row.Cells)
                        {
                            if (cell != null && cell.Value != null)
                            {
                                output += cell.Value.ToString();
                            }
                            output += " | ";
                        }
                        output += "\n";
                    }
                }
                new Scintilla(new ScintillaGateway(PluginBase.GetCurrentScintilla()))
                    .Insert(output);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool CheckForEmptyRow(DataGridViewRow row)
        {
            if (row == null || row.Cells == null)
                return true;
            bool output = true;
            foreach(DataGridViewTextBoxCell cell in row.Cells)
            {
                if (cell == null || cell.Value == null)
                    output = true;
                else
                    output = false;
            }
            return output;
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            string sel = new Scintilla(new ScintillaGateway(PluginBase.GetCurrentScintilla()))
                .Fill();
            sel = sel.Replace("\n", "\n\n");
            var reg = new Regex(@"(?:(?:\|[^|\r\n]*)+\|(?:\r?\n|\r)?)+", RegexOptions.Multiline);
            var split = reg.Matches(sel);
            this.dataGridView.Columns.Clear();

            for (var cols = 0; cols < split[0].ToString().Split('|').Length - 2; cols++)
                this.dataGridView.Columns.Add(new DataGridViewTextBoxColumn());
            try
            {
                foreach(var x in split)
                {
                    var rows = x.ToString().Split(new string[] { " | ", " |", "| " }, StringSplitOptions.None);
                    this.dataGridView.Rows.Add(RemoveFirst(rows));
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        private string[] RemoveFirst(string[] arr)
        {
            List<string> temp = new List<string>();
            foreach (var x in arr)
                temp.Add(x);
            temp.RemoveAt(0);
            return temp.ToArray();
        }

        private void centerbutton_Click(object sender, EventArgs e)
        {
            var selected = this.dataGridView.SelectedCells;
            foreach (DataGridViewTextBoxCell x in selected)
                x.Value = ":---:";
        }

        private void ralignbutton_Click(object sender, EventArgs e)
        {
            var selected = this.dataGridView.SelectedCells;
            foreach (DataGridViewTextBoxCell x in selected)
                x.Value = "---:";
        }

        private void lalignbutton_Click(object sender, EventArgs e)
        {
            var selected = this.dataGridView.SelectedCells;
            foreach (DataGridViewTextBoxCell x in selected)
                x.Value = ":---";
        }
    }
}
