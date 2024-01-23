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
    public partial class Form4 : Form
    {
        MusteriDbContext dbContext = new MusteriDbContext();
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(textBox1.Text);
            var tbl = dbContext.musteris.FirstOrDefault(x => x.MusteriID == ID);
            tbl.AdiSoyadi = textBox2.Text;
            tbl.Telefon = Convert.ToInt32(textBox3.Text);
            tbl.Email = textBox4.Text;
            tbl.Sehir = textBox5.Text;
            dbContext.SaveChanges();        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
