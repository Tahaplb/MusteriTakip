using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgAraSınav
{
    public partial class Form6 : Form
    {
        SqlConnection baglanti = null;
        public Form6()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                baglanti = new SqlConnection("");
                baglanti.Open();

                // SqlCommand sqlKOmut = new SqlCommand("SELECT Nick , Pass  FROM bahceid", baglanti);

                SqlCommand cmd = new SqlCommand("insert into Bahceid values (@Nick,@Pass)", baglanti);
                cmd.Parameters.AddWithValue("@id", textBox3.Text);
                cmd.Parameters.AddWithValue("@Nick", textBox1.Text);
                cmd.Parameters.AddWithValue("@Pass", textBox2.Text);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { baglanti.Close(); }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {

                baglanti = new SqlConnection("");
                baglanti.Open();

                // SqlCommand sqlKOmut = new SqlCommand("SELECT Nick , Pass  FROM bahceid", baglanti);

                SqlCommand cmd = new SqlCommand("Update Bahceid set Nick=@Nick, Pass=@Pass where id=@id ", baglanti);


                cmd.Parameters.AddWithValue("@id", textBox3.Text);
                cmd.Parameters.AddWithValue("@Nick", textBox1.Text);
                cmd.Parameters.AddWithValue("@Pass", textBox2.Text);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { baglanti.Close(); }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {

                baglanti = new SqlConnection("");
                baglanti.Open();

                // SqlCommand sqlKOmut = new SqlCommand("SELECT Nick , Pass  FROM bahceid", baglanti);

                SqlCommand cmd = new SqlCommand("Delete Bahceid where id=@id ", baglanti);


                cmd.Parameters.AddWithValue("@id", textBox3.Text);
                cmd.Parameters.AddWithValue("@Nick", textBox1.Text);
                cmd.Parameters.AddWithValue("@Pass", textBox2.Text);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { baglanti.Close(); }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {

                baglanti = new SqlConnection("");
                baglanti.Open();

                // SqlCommand sqlKOmut = new SqlCommand("SELECT Nick , Pass  FROM bahceid", baglanti);

                SqlCommand cmd = new SqlCommand("Select * from Bahceid where id=@id ", baglanti);



                cmd.Parameters.AddWithValue("@id", textBox3.Text);
                cmd.Parameters.AddWithValue("@Nick", textBox1.Text);
                cmd.Parameters.AddWithValue("@Pass", textBox2.Text);
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { baglanti.Close(); }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {

                baglanti = new SqlConnection("");
                baglanti.Open();

                // SqlCommand sqlKOmut = new SqlCommand("SELECT Nick , Pass  FROM bahceid", baglanti);

                SqlCommand cmd = new SqlCommand("Select * from Bahceid ", baglanti);



                cmd.Parameters.AddWithValue("@id", textBox3.Text);
                cmd.Parameters.AddWithValue("@Nick", textBox1.Text);
                cmd.Parameters.AddWithValue("@Pass", textBox2.Text);
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { baglanti.Close(); }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }



}
