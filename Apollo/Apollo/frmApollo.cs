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

        private void lsvLeveranciers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Leverancier l = new Leverancier();
            if (lsvLeveranciers.SelectedItems.Count == 0)
                return;
            ListViewItem item = lsvLeveranciers.SelectedItems[0];
            l.id = Convert.ToInt32(item.SubItems[0].Text);
            l.firmanaam = item.SubItems[1].Text;
            l.adres = item.SubItems[2].Text;
            l.postnr = item.SubItems[3].Text;
            l.gemeente = item.SubItems[4].Text;
            
            txtLeverancierLVnr.Text = l.id.ToString();
            txtLeverancierFirmanaam.Text = l.firmanaam;
            txtLeverancierAdres.Text = l.adres;
            txtLeverancierPostnr.Text = l.postnr;
            txtLeverancierGemeente.Text = l.gemeente;
        }
    }
}
