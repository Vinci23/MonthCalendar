using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTermin_Click(object sender, EventArgs e)
        {
            TimeSpan period = monthCal.SelectionEnd - monthCal.SelectionStart;

            if (period.Days < 1)
            {
                MessageBox.Show("Niste odabrali više dana pritisnite SHIFT da odaberete", "GREŠKA!!!!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            { 
            MessageBox.Show("Rezervirali ste period od " + monthCal.SelectionStart.ToShortDateString() + " do " + monthCal.SelectionEnd.ToShortDateString() , "Rezervacija",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
