using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace MeteosisIseGirisProjesi.Models
{
    public class SehirDal
    {
        // sql bağlantı oluştur
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-L6NJT48\\SQLEXPRESS;Initial Catalog=Meteosis;Integrated Security=True;TrustServerCertificate=True");
        // datatable listele
        public DataTable GetAll()
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            else
            {
                ///
            }
            SqlCommand command = new SqlCommand("Select * From Sehir", connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable db = new DataTable();
            db.Load(reader);
            reader.Close();
            connection.Close();
            return db;
        }
        public void ConnectionKontrol()
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

        }
        public float MaxDeger()
        {
            return  0;
        }
        public float MinDeger()
        {
            return 0;
        }
        public float StandartSapma()
        {
            return 0;
        }
        public void Total()
        {
           SqlCommand toplaIzmir= new SqlCommand("SELECT Sum(data1,data2,data3,data4,data5,data6,data7,data8,data9,data10) AS Sehir_Mak_Toplam_Degeri WHERE Sehir Like 'İzmir%'", connection);
           SqlCommand toplaIstanbul = new SqlCommand("SELECT Sum(data1,data2,data3,data4,data5,data6,data7,data8,data9,data10) AS Sehir_Mak_Toplam_Degeri WHERE Sehir Like 'İstanbul%'", connection);
           SqlCommand toplaAnkara = new SqlCommand("SELECT Sum(data1,data2,data3,data4,data5,data6,data7,data8,data9,data10) AS Sehir_Mak_Toplam_Degeri WHERE Sehir Like 'Ankara%'", connection);
        }
        public int ToplamKayit()
        {
            return 0;
        }
        public float Ortalama()
        {
            return 0;
        }
    }
}