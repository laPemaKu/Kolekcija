using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolekcije_ocjenska
{
    public partial class Form1 : Form
    {
        List<Upis> list = new List<Upis>();
        public Form1()
        {
            InitializeComponent();
        }
        class Upis
        {
            string prvi, drugi, treci, spol, dodatak;

            public Upis(string prvi, string drugi, string treci, string spol)
            {
                this.prvi = prvi;
                this.drugi = drugi;
                this.treci = treci;
                this.spol = spol;
            }
            public Upis(string dodatak)
            {
                this.dodatak = dodatak;
            }

            public string Prvi { get => prvi; set => prvi = value; }
            public string Drugi { get => drugi; set => drugi = value; }
            public string Treci { get => treci; set => treci = value; }
            public string Spol { get => spol; set => spol = value; }
            public string Dodatak { get => dodatak; set => dodatak = value; }

            public override string ToString()
            {
                return this.prvi + "\t\t" + this.drugi + "\t\t" + this.treci + "\t\t" + spol + "\t" + dodatak;
            }

            public string CsvUpis()
            {
                return this.prvi + ", " + this.drugi + ", " + this.treci + ", " + this.spol + ", " + this.dodatak;
            }
        }
        private void btnUnos_Click(object sender, EventArgs e)
        {
            
            try
            {
                Upis upis = new Upis(txtPrviUpis.Text, txtDrugiUpis.Text, txtTreciUpis.Text, cboxSpol.Text);
                list.Add(upis);
                txtPrviUpis.Clear();
                txtDrugiUpis.Clear();
                txtTreciUpis.Clear();
            }catch(Exception greska)
            {
                MessageBox.Show(greska.Message, "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            txtIspis.Clear();
            txtIspis.AppendText("Prvi upis\t\tDrugi Upis\tTreci Upis\tSpol\tDodatak");
            foreach(Upis u in list)
            {
                string newLine = Environment.NewLine;
                txtIspis.AppendText(newLine);
                txtIspis.AppendText(u.ToString());
            }
        }

        private void btnObrada_Click(object sender, EventArgs e)
        {
            foreach(Upis u in list)
            {
                if(u.Spol == "M")
                {
                    u.Dodatak = "Imam brkove";
                }else if(u.Spol == "Ž")
                {
                    u.Dodatak = "Nemam brkove";
                }
                else
                {
                    u.Dodatak = "Neznao";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dialog.SelectedPath + "\\datoteka.csv");
                sw.WriteLine("Prvi upis, Drugi Upis, Treci Upis, Spol, Dodatak");
                foreach(Upis u in list)
                {
                    sw.WriteLine(u.CsvUpis());
                }
                sw.Close();
            }
        }
    }
}
