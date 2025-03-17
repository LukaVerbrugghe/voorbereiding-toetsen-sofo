using Apollo.DA;
using Apollo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apollo
{
    public partial class frmApollo: Form
    {
        public frmApollo()
        {
            InitializeComponent();
            inladenLeveranciers();
        }

        private void inladenLeveranciers()
        {
            lsvLeveranciers.Items.Clear();
            foreach(Leverancier l in leveranciersDA.OphalenLeveranciers())
            {
                ListViewItem item = new ListViewItem(new String[] {l.id.ToString(), l.firmanaam, l.adres, l.postnr, l.gemeente });
                item.Tag = l;
                lsvLeveranciers.Items.Add(item);
            }
        }
    }
}
