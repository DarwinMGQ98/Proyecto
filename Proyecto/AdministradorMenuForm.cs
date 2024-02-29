using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class AdministradorMenuForm : Form
    {
        public AdministradorMenuForm()
        {
            InitializeComponent();
        }

        private void btnIngresardvds_Click(object sender, EventArgs e)
        {
            Ingresas_DVDs ingresas = new Ingresas_DVDs();
            ingresas.ShowDialog();
        }

        private void btneliminardvd_Click(object sender, EventArgs e)
        {
            Eliminar_DVDs eliminar_DVDs = new Eliminar_DVDs();
            eliminar_DVDs.ShowDialog();
        }

        private void btnlistadodirector_Click(object sender, EventArgs e)
        {
            Listados_Por_Director listados_Por_Director = new Listados_Por_Director();
            listados_Por_Director.ShowDialog();
        }

        private void btnordenadogenero_Click(object sender, EventArgs e)
        {
            Ordenados_Por_Genero ordenados_Por_Genero = new Ordenados_Por_Genero();
            ordenados_Por_Genero.ShowDialog();
        }
    }
}
