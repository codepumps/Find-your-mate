using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace Esini_Bul_Uygulamasi
{
    public partial class E : DevExpress.XtraEditors.XtraForm
    {
        private List<SimpleButton>secimler=new List<SimpleButton>();
        private int toplamSure = 0;
        //private int toplamHata = 0;
        public E()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            List<int>sayilar=new List<int>();
            Random rastgele=new Random();
            if ((Convert.ToInt32(txtYatay.Text) * Convert.ToInt32(txtDikey.Text)) % 2 == 0)
            {

                for (int i = 1; i <= (Convert.ToInt32(txtYatay.Text) * Convert.ToInt32(txtDikey.Text)) / 2; i++)
                {
                    sayilar.Add(i);
                    sayilar.Add(i);
                }

                for (int i = 0; i < Convert.ToInt32(txtYatay.Text); i++)
                {
                    for (int j = 0; j < Convert.ToInt32(txtDikey.Text); j++)
                    {
                        int secilen = rastgele.Next(0, sayilar.Count);
                        SimpleButton buton = new SimpleButton
                        {
                            Name = sayilar[secilen].ToString(),
                            Text = null, //Kullanıcının görmemesi lazım.
                            //Text = sayilar[secilen].ToString(),
                            Tag = sayilar[secilen].ToString(),
                            Height = 35,
                            Width = 35,
                            Appearance = { BackColor = Color.Red},
                            ButtonStyle = BorderStyles.HotFlat,
                            //Butonun location kısmı
                            Top = (j + 1) * 35 + 20,
                            Left = (i) * 35 + 20,
                            Font = new Font("Arial", 12, FontStyle.Bold),
                        };
                        //Generate method
                        buton.Click += Buton_Click;
                        groupOyun.Controls.Add(buton);
                        int sayi = sayilar[secilen];
                        sayilar.Remove(sayi);

                    }
                }



                if (MessageBox.Show("Game created. Are you ready?", "Information", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtSure.Time = DateTime.Parse("00:00:00");
                    txtDikey.Text = 0.ToString();
                    txtYatay.Text = 0.ToString();
                    timer1.Enabled = true;
                    timer1.Start();
                }
            }
            else
            {
                MessageBox.Show("Total must be double!", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        private void Buton_Click(object sender, EventArgs e)
        {
            SimpleButton buton = (SimpleButton) sender;
            buton.Appearance.BackColor = Color.Green;
            buton.BorderStyle = BorderStyles.HotFlat;
            if (string.IsNullOrEmpty(buton.Text))
            {
                buton.Text = buton.Name;
                //Buton isminin gözükmesi için refresh yaptık.Çok hızlı çalıştığından text görünmeyebiliyor.
                buton.Refresh();
                secimler.Add(buton);
            }
            if (secimler.Count == 2)
            {
                //Sistemi bekletmek için
                System.Threading.Thread.Sleep(400);
                if (secimler[0].Text == secimler[1].Text)
                {
                        //Butonları silme
                        secimler[0].Dispose();
                        secimler[1].Dispose();
                    if (groupOyun.Controls.Count==0)
                    {
                        MessageBox.Show("Congrulations! Game Over.", "Game Over", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        timer1.Enabled = false;
                        timer1.Stop();
                        clcHata.Value = 0;
                    }
                    
                }
                else
                {
                    secimler[0].Appearance.BackColor = Color.Red;
                    secimler[0].BorderStyle = BorderStyles.HotFlat;
                    secimler[1].Appearance.BackColor = Color.Red;
                    secimler[1].BorderStyle = BorderStyles.HotFlat;
                    secimler[0].Text = null;
                    secimler[1].Text = null;
                    //Hata sayısı
                    clcHata.Value += 1;
                }
                secimler.Clear();
            }
        }
        //Timer->eventler->tick özelliğinden(1000->1 sny)
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Her seferinde time üstüne 1 saniye ekleyerek devam eder.
            txtSure.Time = txtSure.Time.AddSeconds(1);
            toplamSure++;
        }

        //Checkbutonların groupIndex'i 1 yapılırsa sadece biri seçilebilir.
        private void chkKolay_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkKolay.Checked)
            {
                txtYatay.Text = 3.ToString();
                txtDikey.Text = 4.ToString();
                
            }
        }

        private void chkOrta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOrta.Checked)
            {
                txtYatay.Text = 5.ToString();
                txtDikey.Text = 6.ToString();
            }
        }

        private void chkZor_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkZor.Checked)
            {
                txtYatay.Text = 8.ToString();
                txtDikey.Text = 8.ToString();
            }
        }

        private void chkCokZor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCokZor.Checked)
            {
                txtYatay.Text = 10.ToString();
                txtDikey.Text = 10.ToString();
            }
        }

        private void ChkBenimSecimim_CheckedChanged(object sender, EventArgs e)
        {
            
            txtDikey.Text = 0.ToString();
            txtYatay.Text = 0.ToString();

            if (ChkBenimSecimim.Checked)
            {
                txtDikey.Enabled = true;
                txtYatay.Enabled = true;
            }
            else
            {
                txtDikey.Enabled = false;
                txtYatay.Enabled = false;
            }
        }

        private void BtnReplay_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                groupOyun.Controls.Clear();
                timer1.Enabled = false;
                timer1.Stop();
                txtSure.Time=DateTime.Parse("00:00:00");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Bu formu kapatmak
            this.Close();
        }
    }
}
