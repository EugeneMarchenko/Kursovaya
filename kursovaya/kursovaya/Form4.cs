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
    public partial class Form4 : MetroForm
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.базаліківDataSet);
            if (кодTextBox.Text == "" || назваTextBox.Text == "" || категоріяTextBox.Text == "" || назваTextBox.Text == "" || кількістьTextBox.Text == "" || цінаTextBox.Text == "")
                MessageBox.Show("Введіть текст!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "базаліківDataSet1.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.базаліківDataSet.Table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "базаліківDataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.базаліківDataSet.Table);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            Hide(); ;
        }
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.tableTableAdapter.Update(this.базаліківDataSet.Table);
        }
    }
}
