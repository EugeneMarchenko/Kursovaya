using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace kursovaya
{
    public partial class Form2 : MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }    

        private void button2_Click(object sender, EventArgs e)
        {
            int ind = tableDataGridView.SelectedCells[0].RowIndex;
            tableDataGridView.Rows.RemoveAt(ind);
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            Hide(); ;
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.відповідальніОсобиDataSet);
            if (кодTextBox.Text == "" || ім_яTextBox.Text == "" || прізвищеTextBox.Text == "" || по_батьковіTextBox.Text == "")
                MessageBox.Show("Введіть текст!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "відповідальніОсобиDataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.відповідальніОсобиDataSet.Table);

        }
    }
}

