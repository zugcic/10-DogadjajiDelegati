using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vsite.CSharp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // TODO: Pridružiti donja dva rukovatelja događajima Click tipki button i buttonMy

            // TODO: Napraviti klasu MyButton koja će biti izvedena iz klase Button, u njoj pregaziti virtualnu metodu OnClick te unutar metode dodati prikaz kontrole MessageBox
            
            // TODO: Promijeniti objekt buttonMy tako da bude tipa MyButton, pokrenuti kod i provjeriti ponašanje tipke

            // TODO: U metodi OnClick klase MyButton zakomentirati poziv base.OnClick te provjeriti ponašanje tipke nakon toga.
        }

        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kliknuo si me!", "Botun obični");
        }

        private void buttonMy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kliknuo si me!", "Moj botun");
        }
    }
}
