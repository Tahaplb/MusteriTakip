using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GorselProgAraSınav.ContextVeri;

namespace GorselProgAraSınav
{
    public partial class Form5 : Form
    {
        MusteriDbContext dbContext = new MusteriDbContext();
        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            var tbl = dbContext.musteris.FirstOrDefault(x => x.MusteriID == ID);
            dbContext.musteris.Remove(tbl);
            dbContext.SaveChanges();
            dataGridView2.DataSource = dbContext.musteris.ToList();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = dbContext.musteris.ToList();
        }
    }
}
