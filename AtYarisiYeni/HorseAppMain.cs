using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtYarisiYeni.Helpers;

namespace AtYarisiYeni
{
    public partial class HorseAppMain : Form
    {
        public HorseAppMain()
        {
            InitializeComponent();
        }

        #region global değişkenler
        int at1kor, at2kor, at3kor, at4kor;
        int zaman = 0;
        int para = 0;
        int kazanilanPara = 0;
        int kaybedilenPara = 0;
        string kazananKisi = "";
        int secilenOran;
        string atIsmi;
        int oynanacakPara = 0;
        private string bahisci = "";
        private string yarisId = "";
        ConnectionHelper connection = new ConnectionHelper();

        #endregion

        public void Form1_Load(object sender, EventArgs e)
        {
            Temizle();

        }

        public void timer1_Tick(object sender, EventArgs e)
        {

            //Atların 1 den 6 ya kadar rastgele değerlerle ilerlemelerini sağlamak için Random Class'ını kullanarak rastgele sayı ürettim.

            Random rnd = new Random();
            int deger1 = rnd.Next(1, 6);
            int deger2 = rnd.Next(1, 6);
            int deger3 = rnd.Next(1, 6);
            int deger4 = rnd.Next(1, 6);


            //4 tane random sayı üretildi, deger1,deger2,deger3,deger4 degişkenlerine atandı.

            at1.Left += deger1;
            at2.Left += deger2;
            at3.Left += deger3;
            at4.Left += deger4;


            if (at1.Right >= finish.Left)
            {
                timer1.Stop();
                timer2.Stop();
                YarisBitti("SAHBATUR");
            }
            else if (at2.Right >= finish.Left)
            {
                timer1.Stop();
                timer2.Stop();
                YarisBitti("GULBATUR");
            }
            else if (at3.Right >= finish.Left)
            {
                timer1.Stop();
                timer2.Stop();
                YarisBitti("KARABACAK");
            }
            else if (at4.Right >= finish.Left)
            {
                timer1.Stop();
                timer2.Stop();
                YarisBitti("GULBEYAZ");
            }


        }

        public void timer2_Tick(object sender, EventArgs e)
        {
            zaman++;
            lblZaman.Text = zaman.ToString();
        }

        public void btnYatir_Click(object sender, EventArgs e)
        {

            try
            {
                bool tutarKontrol = TutarKontrol();
                if (tutarKontrol == true)
                {
                    string id = Guid.NewGuid().ToString();
                    oynanacakPara = Convert.ToInt32(txtYatir.Text);
                    InsertSonDurum(id, bahisci, oynanacakPara, atIsmi, yarisId);
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Tutar Girişi Yapınız !");
            }
        }

        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


            foreach (ListViewItem item in listView1.SelectedItems)
            {
                atIsmi = item.Text;
                secilenOran = Convert.ToInt32(item.SubItems[1].Text);
            }
        }

        public void btnOyna_Click(object sender, EventArgs e)
        {
            try
            {
                oynanacakPara = Convert.ToInt32(txtYatir.Text);
                if (oynanacakPara > 0)
                {
                    oynanacakPara = Convert.ToInt32(txtYatir.Text);
                    para -= oynanacakPara;
                    txtYatir.Enabled = false;
                    btnYatir.Enabled = false;
                    btnOyna.Enabled = false;
                    listView1.Enabled = false;
                    timer1.Start();
                    timer2.Start();
                }
                else
                {
                    MessageBox.Show("Kasada paranız bulunmamaktadır !");
                }
            }
            catch
            {
                MessageBox.Show("Miktar Giriniz !");
            }
        }

        #region Metotlar
        public void YarisBitti(string atAdi)
        {
            DataTable dtYarisId = GetFinishFromYarisId();
            string sonDurum = "";
            foreach (DataRow item in dtYarisId.Rows)
            {
                sonDurum = sonDurum + " Bahisci Adı : " + item.ItemArray[1].ToString() + " At Adı : " + item.ItemArray[3].ToString() + " Tutar:" + item.ItemArray[2].ToString() + "\n";
            }

            kazanilanPara = oynanacakPara * 2;
            kaybedilenPara = oynanacakPara;
            para += kazanilanPara;
            MessageBox.Show("Tebrikler, yarışı " + atAdi + " kazandı. Yarış " + zaman + " saniye sürdü. " + kazanilanPara.ToString() + " kadar para kazandınız. " + Environment.NewLine + " Yarıştaki bahis bilgileri aşağıdaki gibidir. " + Environment.NewLine + " " + sonDurum + "");
            Temizle();

        }

        public void OranBelirle()
        {
            listView1.Items.Clear();
            Random rnd = new Random();
            double oran1 = rnd.Next(1, 10);
            double oran2 = rnd.Next(1, 10);
            double oran3 = rnd.Next(1, 10);
            double oran4 = rnd.Next(1, 10);
            ListViewItem lvi1 = new ListViewItem();
            lvi1.Text = "SAHBATUR";
            lvi1.SubItems.Add(oran1.ToString());
            listView1.Items.Add(lvi1);
            ListViewItem lvi2 = new ListViewItem();
            lvi2.Text = "GULBATUR";
            lvi2.SubItems.Add(oran2.ToString());
            listView1.Items.Add(lvi2);
            ListViewItem lvi3 = new ListViewItem();
            lvi3.Text = "KARABACAK";
            lvi3.SubItems.Add(oran3.ToString());
            listView1.Items.Add(lvi3);
            ListViewItem lvi4 = new ListViewItem();
            lvi4.Text = "GULBEYAZ";
            lvi4.SubItems.Add(oran4.ToString());
            listView1.Items.Add(lvi4);

        }

        public void btnGuncelDurum_Click(object sender, EventArgs e)
        {
            HorseAppDetail openForm = new HorseAppDetail();
            openForm.Show();
        }

        public void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Process.Start("http://www.ilkanoguzvarol.com");
        }

        public void FillComboBahisciler()
        {

            string sql = "SELECT * FROM dbo.Bahisciler WITH(NOLOCK)";
            SqlCommand cmd = new SqlCommand(sql, connection.con);
            SqlDataReader myReader;
            try
            {
                connection.con.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sname = myReader.GetString(1);
                    cmbBahisciler.Items.Add(sname);
                }
                connection.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        public void cmbBahisciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM dbo.Bahisciler WITH(NOLOCK) WHERE Adi= '" + cmbBahisciler.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, connection.con);
            SqlDataReader myReader;
            bahisci = cmbBahisciler.Text;

            try
            {
                connection.con.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    decimal tutar = myReader.GetDecimal(2);
                    txtYatir.Text = Convert.ToString(tutar);
                }
                connection.con.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        public void InsertSonDurum(string Id, string ad, decimal tutar, string atAdi, string yaris_Id)
        {
            try
            {
                connection.con.Open();
                SqlCommand cmd =
                    new SqlCommand(
                        "INSERT INTO dbo.Durum VALUES ('" + Id + "','" + ad + "','" + tutar + "','" +
                        atAdi + "','" + DateTime.Now.ToString("yyyyMMdd 00:00:00") + "' , '" + yaris_Id + "') ",
                        connection.con);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                connection.con.Close();
            }

        }

        public DataTable GetFinishFromYarisId()
        {
            connection.con.Open();
            string query = "SELECT * FROM dbo.Durum WITH(NOLOCK) WHERE yaris_Id='" + yarisId + "'";
            SqlCommand cmd = new SqlCommand(query, connection.con);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.con.Close();
            return dt;
        }

        private void Temizle()
        {
            yarisId = Guid.NewGuid().ToString();
            at1kor = at1.Left;
            at2kor = at2.Left;
            at3kor = at3.Left;
            at4kor = at4.Left;
            zaman = 0;
            lblZaman.Text = zaman.ToString();
            OranBelirle();
            FillComboBahisciler();
        }

        public bool TutarKontrol()
        {
            int oynanacakGuncelPara = 0;
            oynanacakGuncelPara = Convert.ToInt32(txtYatir.Text);
            if (oynanacakGuncelPara == 0)
            {
                MessageBox.Show("5 ile 20 lira  arasında bahis oynayabilirsiniz !");
                return false;
            }
            bool altLimitKontrolChange = altLimitKontrol(oynanacakGuncelPara);
            bool ustLimitKontrolChange = ustLimitKontrol(oynanacakGuncelPara);
            if (altLimitKontrolChange != true)
            {
                MessageBox.Show("Minimum 5 liralık bahis oynayabilirsiniz !");
                oynanacakGuncelPara = 0;
                return false;
            }
            else if (ustLimitKontrolChange != true)
            {
                MessageBox.Show("Maximum 20 liralık bahis oynayabilirsiniz !");
                oynanacakGuncelPara = 0;
                return false;
            }

            return true;
        }

        public bool altLimitKontrol(int oynanacakGuncelPara)
        {
            if (oynanacakGuncelPara != 0)
            {
                int altLimit = 5;

                if (oynanacakGuncelPara < altLimit)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }

            return true;
        }

        public bool ustLimitKontrol(int oynanacakGuncelPara)
        {
            if (oynanacakGuncelPara != 0)
            {
                int altLimit = 20;

                if (oynanacakGuncelPara > altLimit)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            return true;
        }
        #endregion

    }
}
