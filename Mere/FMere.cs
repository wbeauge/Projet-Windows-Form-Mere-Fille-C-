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
    public partial class FMere : Form
    {
        private List<Fille> lesFilles;
        private int nombreFille;
        private string maMere;

        public FMere()
        {
            InitializeComponent();
            this.Text = "Mère";
            this.maMere = "Maman";
            lesFilles = new List<Fille>();
            btnNew.Click += new EventHandler(btnNew_Click);
            btnNew.Click += new EventHandler(btnNew_Click_Message);
            btnShow.Click += new EventHandler(btnShow_Click);
            btnHide.Click += new EventHandler(btnHide_Click);
            btnShowDialog.Click += new EventHandler(btnShowDialog_Click);
            btnClose.Click += new EventHandler(btnClose_Click);
        }

        void btnNew_Click_Message(object sender, EventArgs e)
        {
            MessageBox.Show("Une fenêtre fille a été instanciée");
        }

        void btnClose_Click(object sender, EventArgs e)
        {
            int position = lbLesFilles.SelectedIndex;
            if (position != -1)
            {
                lesFilles[position].Close();
                lesFilles.RemoveAt(position);
                lbLesFilles.Items.RemoveAt(position);

            }
        }

        void btnShowDialog_Click(object sender, EventArgs e)
        {
            int position = lbLesFilles.SelectedIndex;
            if (position != -1)
            {
                lesFilles[position].ShowDialog();
            }
        }

        void btnHide_Click(object sender, EventArgs e)
        {
            int position = lbLesFilles.SelectedIndex;
            if (position != -1)
            {
                lesFilles[position].Hide();
            } 
        }

        void btnShow_Click(object sender, EventArgs e)
        {
            int position = lbLesFilles.SelectedIndex;
            if(position != -1){
                lesFilles[position].Show();
            }
        }

        void btnNew_Click(object sender, EventArgs e)
        {
            Fille nouvelleFille;
            nombreFille = nombreFille + 1;
            nouvelleFille = new Fille(this, nombreFille);
            lesFilles.Add(nouvelleFille);
            lbLesFilles.Items.Add("Fille n°" + this.nombreFille);
        }

        public string NomMere
        {
            get { return this.maMere; }
        }

        public void MaFilleChangeDeNom(Fille ffille, string nouveauNom) {

            int position = lesFilles.IndexOf(ffille);
            if (position != -1)
            {
                lesFilles[position] = ffille;
                lbLesFilles.Items[position] = nouveauNom;

            }
        }


    }
}
