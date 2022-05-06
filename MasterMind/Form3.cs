using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind
{
    public partial class Statistiche : Form
    {
        public Statistiche()
        {
            InitializeComponent();
            Stat();
        }

        private void Stat()
        {
            int[] stat = new int[2];
            stat = Comandi.Statistiche();
            lb_sconfitte.Text = "" +stat[1];
            lb_vittorie.Text = "" + stat[0];
        }
    }
}
