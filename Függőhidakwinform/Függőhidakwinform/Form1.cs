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

namespace Függőhidakwinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Fix: Corrected the variable name to avoid using the type name 'Fuggohid' directly.
            List<Fuggohid> fuggohidak = Beolvasahid.FuggohidBeolvasas();

            foreach (var hid in fuggohidak)
            {
                függöhidlistBox.Items.Add(hid.Híd);
            }
        }

        private void függöhidlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //3. A függőhidak nevei egy ListBox-ban jelenjenek meg, a függőhidak további adatai szövegdobozokban jelenjenek meg, amikor kiválasztunk egy hidat a listából.
            List<Fuggohid> fuggohidak = Beolvasahid.FuggohidBeolvasas();
            if (függöhidlistBox.SelectedIndex != -1)
            {
                Fuggohid kiválasztottHid = fuggohidak[függöhidlistBox.SelectedIndex];

                helytextBox.Text = kiválasztottHid.Hely;
                orszagtextBox.Text = kiválasztottHid.Ország;
                hossztextBox.Text = kiválasztottHid.Hossz.ToString();
                evtextBox.Text = kiválasztottHid.Év.ToString();
            }

        }

        //4. Rádiógombok segítségével jelenítse meg a 2000 előtt, illetve 2000-ben és utána épült hidak számát! 
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                List<Fuggohid> fuggohidak = Beolvasahid.FuggohidBeolvasas();
                int count = fuggohidak.Count(hid => hid.Év < 2000);
                textBox1.Text = count.ToString();


            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                List<Fuggohid> fuggohidak = Beolvasahid.FuggohidBeolvasas();
                int count = fuggohidak.Count(hid => hid.Év >= 2000);
                textBox1.Text = count.ToString();
            }
        }

        private void keresésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //A Keresés menüpont hatására jelenjen meg a keresés form, a főformot rejtse el.
            Keresés keresésForm = new Keresés();
            keresésForm.Show();
            this.Hide();

        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //5. Hozza létre a főmenüben a Keresés és a Kilépés menüpontokat, a Kilépés menüpont és a Kilépés gomb hatására záródjon be az alkalmazás!
            Application.Exit();


        }

        private void kilepesbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
        

