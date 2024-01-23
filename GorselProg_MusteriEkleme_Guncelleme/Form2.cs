using GorselProgAraSınav.ContextVeri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgAraSınav
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        MusteriDbContext dbContext = new MusteriDbContext();


        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource=dbContext.musteris.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            var ara = from x in dbContext.musteris select x;
            if (textBox6.Text != null)
            {
                dataGridView2.DataSource = ara.Where(x => x.AdiSoyadi.Contains(textBox6.Text)).ToList(); 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            dataGridView2.DataSource = dbContext.musteris.ToList();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }
    }
}
