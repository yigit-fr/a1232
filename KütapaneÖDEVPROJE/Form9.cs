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

namespace KütapaneÖDEVPROJE
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kütüphane.rezervasyon( Kütüphane.rezervasyonID,);
            MessageBox.Show("Rezervasyon Başaralı", "BAŞARILI");
        }

        private void Form9_Load(object sender, EventArgs e)
        {
       
        }
        private void Bilgiler(string BarkodNo)
        {

            SqlConnection con = new SqlConnection(Kütüphane.constr);
            SqlCommand com = new SqlCommand("select * from Book where BarkodNo=@BarkodNo", con);
            com.Parameters.AddWithValue("BarkodNo", BarkodNo);
          

            try
            {
                con.Open();
                SqlDataReader da = com.ExecuteReader();
                if (da.Read())
                {
                    
                    maskedTextBox1.Text = da["Barkod No"].ToString();
                    

                }
                else
                {
                    MessageBox.Show("KAYIT BULUNMADI");
                }

                da.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);

            }
            finally
            {
                con.Close();

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
