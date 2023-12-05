using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Ogrenci ogrenci;
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Ogrenci> ogrenciListe = new List<Ogrenci>();

            ogrenciListe.Add(new Ogrenci(1533, "Rukiye Balı","10/A", "05156328471"));
            ogrenciListe.Add(new Ogrenci(1544, "İlayda Daban", "10/A", "05387593647"));
            ogrenciListe.Add(new Ogrenci(1545, "Fatih Yiner", "10/A", "05346982145"));
            ogrenciListe.Add(new Ogrenci(1515, "Behiye Öztürk", "10/A", "05684256892"));
            ogrenciListe.Add(new Ogrenci(1514, "Toprak Akın", "10/A", "0532859395"));
            ogrenciListe.Add(new Ogrenci(1533, "Mahmet Arıkan", "10/A", "05347723416"));
            ogrenciListe.Add(new Ogrenci(1533, "Ahmet Cansever", "16/A", "05322684195"));

            dataGridView1.DataSource = ogrenciListe.ToList();





        }
    }
}
