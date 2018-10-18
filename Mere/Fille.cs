using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mere
{
    public partial class Fille : Form
    {
        private string monNon;
        private FMere maMere;


        public Fille(FMere maMere, int numero)
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Fille_FormClosing);
            this.Text = "Fille n°"+numero;
            this.monNon = this.Text;
            this.maMere = maMere;
            this.btnMaMere.Click += new EventHandler(btnMaMere_Click);
            this.Load += new EventHandler(Fille_Load);
            this.btnChanger.Click += new EventHandler(btnChanger_Click);
            this.tbChangeNom.TextChanged += new EventHandler(btnChanger_Click);
        }


        void btnChanger_Click(object sender, EventArgs e)
        {
            monNon = tbChangeNom.Text;

            this.Text = tbChangeNom.Text;
            maMere.MaFilleChangeDeNom(this,monNon);
        }

        void Fille_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Evenement Load sur "+this.monNon);
        }

        void Fille_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnMaMere_Click(object sender, EventArgs e)
        {
            FMere maman = new FMere();

            MessageBox.Show("Ma Mere est : " + maman.NomMere);
        }






    }
}
