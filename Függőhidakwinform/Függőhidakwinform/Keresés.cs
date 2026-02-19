using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Függőhidakwinform
{
    public partial class Keresés : Form
    {
        public Keresés()
        {
            InitializeComponent();
        }

        private void Keresés_Load(object sender, EventArgs e)
        {
            // Ensure Fuggohid is a strongly-typed list of Fuggohid objects
            List<Fuggohid> Fuggohid = Beolvasahid.FuggohidBeolvasas();

            var orszagok = Fuggohid
                            .Select(h => h.Ország) // Accessing the 'Ország' property of Fuggohid
                            .Distinct()
                            .OrderBy(o => o)
                            .ToList();

            orszagkeresocomboBox.DataSource = orszagok;
        }

        private void bezarobutton_Click(object sender, EventArgs e)
        {
            // csak a bezárás gombra kattintva jelenjen meg újra a főform, a keresés form bezáródjon!
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Close();
        }

        private void orszagkeresocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //7. A keresés form megjelenésekor a legördülő lista (ComboBox) elemeit dinamikusan töltse fel a forrásfájlban szereplő országok neveivel!
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //8.A Keresés gomb hatására a megadott feltételeknek megfelelő függőhidak nevei jelenjenek meg a szövegdobozban.

        }

        private void keresobutton_Click(object sender, EventArgs e)
        {
            // Ensure Fuggohid is a strongly-typed list of Fuggohid objects
            List<Fuggohid> Fuggohid = Beolvasahid.FuggohidBeolvasas();

            string kivalasztottOrszag = orszagkeresocomboBox.SelectedItem.ToString();

            var talalatok = Fuggohid
                            .Where(h => h.Ország == kivalasztottOrszag) // Ensure LINQ is used for filtering
                            .ToList();

            listBox1.Items.Clear(); // Clear the existing items in the ListBox

            foreach (var hid in talalatok)
            {
                listBox1.Items.Add(hid.Híd); // Add each matching bridge name to the ListBox
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //9. A keresés form tartalmazzon egy jelölőnégyzetet (CheckBox), melynek segítségével a felhasználó szűkítheti a keresést azokra a hidakra, melyek 1 km-nél hosszabbak!
            if (checkBox1.Checked)
            {
                List<Fuggohid> Fuggohid = Beolvasahid.FuggohidBeolvasas();
                string kivalasztottOrszag = orszagkeresocomboBox.SelectedItem.ToString();
                var talalatok = Fuggohid
                                .Where(h => h.Ország == kivalasztottOrszag && h.Hossz > 1000) // Filter by country and length
                                .ToList();
                listBox1.Items.Clear(); // Clear the existing items in the ListBox
                foreach (var hid in talalatok)
                {
                    listBox1.Items.Add(hid.Híd); // Add each matching bridge name to the ListBox
                }

            }
        }
    }
}
