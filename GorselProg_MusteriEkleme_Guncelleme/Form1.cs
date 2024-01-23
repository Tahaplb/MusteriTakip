using GorselProgAraSınav.ContextVeri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GorselProgAraSınav
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                using (MusteriDbContext context = new MusteriDbContext())
                {
                    context.Database.Create();
                    MessageBox.Show("işlem başarılı");

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            try
            {

                MusteriDbContext context = new MusteriDbContext();
                var tb = new Musteri();
                tb.AdiSoyadi = "admin";
                context.musteris.Add(tb);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {





        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                MusteriDbContext context = new MusteriDbContext();
                Musteri addedMusteri = context.musteris.FirstOrDefault(x => x.AdiSoyadi == textBox1.Text);
                if (addedMusteri != null)
                {
                    if (textBox2.Text == "admin")
                    {
                        Form2 f2 = new Form2();
                        f2.ShowDialog();
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            



        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
