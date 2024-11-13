using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaccineSystem
{
    public partial class Card_Generation : Form
    {
        public Card_Generation()
        {
            InitializeComponent();
        }

        private void Card_Generation_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recordDL.cardgenerate();
            recordDL.storecardDataIntoFile();
            MessageBox.Show("Card is generated for all vaccinated person");
        }
    }
}
