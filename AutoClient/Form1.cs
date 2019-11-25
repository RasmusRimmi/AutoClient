using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClient
{
    public partial class Form1 : Form
    {
        AutokauppaService.Service1Client registerHandler = new AutokauppaService.Service1Client();
        AutokauppaService.Auto nykAuto = new AutokauppaService.Auto();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbMerkki.DataSource = registerHandler.getAllAutoMakers();
            cbMerkki.DisplayMember = "MerkkiNimi";
            cbMerkki.ValueMember = "Id";
        }

        private void LisaaMallit(object sender, EventArgs e)
        {
            try
            {
                if (cbMerkki.SelectedValue is int)
                {
                    int MerkkiId = (int)cbMerkki.SelectedValue;
                    var mallit = registerHandler.getAutoModels(MerkkiId);
                    cbMalli.DataSource = mallit;
                    cbMalli.DisplayMember = "MalliNimi";
                    cbMalli.ValueMember = "Id";
                    cbVari.DataSource = registerHandler.GetCarColors();
                    cbVari.DisplayMember = "Varin_nimi";
                    cbVari.ValueMember = "Id";
                    cbPolttoaine.DataSource = registerHandler.GetCarFuels();
                    cbPolttoaine.DisplayMember = "Polttoaineen_nimi";
                    cbPolttoaine.ValueMember = "Id";
                }

            }

            catch
            {

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void testaaTietokantayhteyttäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (registerHandler.TestDatabaseConnection())
            {
                MessageBox.Show("Toimii");
            }

            else
            {
                MessageBox.Show("Ei toimi");
            }
        }

        private void btnUusiTietue_Click(object sender, EventArgs e)
        {
            ClearBoxes(this);
        }

        void ClearBoxes(Control control)
        {

            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c is ComboBox)
                {
                    ((ComboBox)c).ResetText();
                }

                else
                {
                    ClearBoxes(c);
                }
            }

        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            AutokauppaService.Auto pirssi = new AutokauppaService.Auto();
            pirssi.AutonMerkkiID = (int)cbMerkki.SelectedValue;
            pirssi.AutonMalliID = (int)cbMalli.SelectedValue;
            pirssi.VaritID = (int)cbVari.SelectedValue;
            pirssi.PolttoaineID = (int)cbPolttoaine.SelectedValue;
            pirssi.Moottorin_Tilavuus = decimal.Parse(tbMoottorinTilavuus.Text);
            pirssi.Hinta = decimal.Parse(tbHinta.Text);
            pirssi.Mittarilukema = int.Parse(tbMittarilukema.Text);
            pirssi.Rekisteri_paivamaara = dtpRekisteriPVM.Value;

            registerHandler.saveAuto(pirssi);

            MessageBox.Show("Auto tallennettu");
            ClearBoxes(this);
        }

        private void btnSeuraava_Click(object sender, EventArgs e)
        {
            nykAuto = registerHandler.NextAuto(nykAuto.Id);
            TulostaAuto(nykAuto);
        }

        private void TulostaAuto(AutokauppaService.Auto uusiAuto)
        {
            cbMerkki.SelectedValue = uusiAuto.AutonMerkkiID;
            cbMalli.SelectedValue = uusiAuto.AutonMalliID;
            cbVari.SelectedValue = uusiAuto.VaritID;
            cbPolttoaine.SelectedValue = uusiAuto.PolttoaineID;
            tbMoottorinTilavuus.Text = uusiAuto.Moottorin_Tilavuus.ToString();
            tbHinta.Text = uusiAuto.Hinta.ToString();
            tbMittarilukema.Text = uusiAuto.Mittarilukema.ToString();
            dtpRekisteriPVM.Text = uusiAuto.Rekisteri_paivamaara.ToString();

        }

        private void btnEdellinen_Click(object sender, EventArgs e)
        {
            nykAuto = registerHandler.PrevAuto(nykAuto.Id);
            TulostaAuto(nykAuto);
        }
    }
}
