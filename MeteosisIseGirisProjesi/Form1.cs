using MeteosisIseGirisProjesi.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeteosisIseGirisProjesi.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace MeteosisIseGirisProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SehirDal SehirDal = new SehirDal();
        private void button1_Click(object sender, EventArgs e)
        {
          if(comboBox1.Text=="Ankara")
            {
                // sql data verileri
                var data1 = dtgSehir.CurrentRow.Cells[2].Value.ToString;
                var data2= dtgSehir.CurrentRow.Cells[3].Value.ToString;
                var data3 = dtgSehir.CurrentRow.Cells[4].Value.ToString;
                var data4 = dtgSehir.CurrentRow.Cells[5].Value.ToString;
                var data5 = dtgSehir.CurrentRow.Cells[6].Value.ToString;
                var data6 = dtgSehir.CurrentRow.Cells[7].Value.ToString;
                var data7 = dtgSehir.CurrentRow.Cells[8].Value.ToString;
                var data8 = dtgSehir.CurrentRow.Cells[9].Value.ToString;
                var data9 = dtgSehir.CurrentRow.Cells[10].Value.ToString;
                var data10 = dtgSehir.CurrentRow.Cells[11].Value.ToString;
                MessageBox.Show( SehirDal.Total());
            }
            else if (comboBox1.Text == "İstanbul")
            {

                // sql data verileri
                var data1 = dtgSehir.CurrentRow.Cells[2].Value.ToString;
                var data2 = dtgSehir.CurrentRow.Cells[3].Value.ToString;
                var data3 = dtgSehir.CurrentRow.Cells[4].Value.ToString;
                var data4 = dtgSehir.CurrentRow.Cells[5].Value.ToString;
                var data5 = dtgSehir.CurrentRow.Cells[6].Value.ToString;
                var data6 = dtgSehir.CurrentRow.Cells[7].Value.ToString;
                var data7 = dtgSehir.CurrentRow.Cells[8].Value.ToString;
                var data8 = dtgSehir.CurrentRow.Cells[9].Value.ToString;
                var data9 = dtgSehir.CurrentRow.Cells[10].Value.ToString;
                var data10 = dtgSehir.CurrentRow.Cells[11].Value.ToString;

            }
           else if (comboBox1.Text =="İzmir")
            {
                // sql data verileri
                var data1 = dtgSehir.CurrentRow.Cells[2].Value.ToString;
                var data2 = dtgSehir.CurrentRow.Cells[3].Value.ToString;
                var data3 = dtgSehir.CurrentRow.Cells[4].Value.ToString;
                var data4 = dtgSehir.CurrentRow.Cells[5].Value.ToString;
                var data5 = dtgSehir.CurrentRow.Cells[6].Value.ToString;
                var data6 = dtgSehir.CurrentRow.Cells[7].Value.ToString;
                var data7 = dtgSehir.CurrentRow.Cells[8].Value.ToString;
                var data8 = dtgSehir.CurrentRow.Cells[9].Value.ToString;
                var data9 = dtgSehir.CurrentRow.Cells[10].Value.ToString;
                var data10 = dtgSehir.CurrentRow.Cells[11].Value.ToString;
            }
          else
                MessageBox.Show("seçim yapmadınız");
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            dtgSehir.DataSource = SehirDal.GetAll();
            comboBox1.DataSource = dtgSehir.DataSource;
            comboBox1.ValueMember = "sehir";
          // sehir sutunundaki değerleri seç şehrin ismini seçiyor
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
