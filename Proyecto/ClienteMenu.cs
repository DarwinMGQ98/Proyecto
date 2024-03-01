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
    public partial class ClienteMenu : Form
    {
        public ClienteMenu()
        {
            InitializeComponent();
        }

        private void btnAlquilardvd_Click(object sender, EventArgs e)
        {
            Alquila_DVDs alquila_DVDs = new Alquila_DVDs();
            alquila_DVDs.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pagar_por_el_alquiler pagar_Por_El_Alquiler = new Pagar_por_el_alquiler();
            pagar_Por_El_Alquiler.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Historial_del_Cliente historial = new Historial_del_Cliente();
            historial.ShowDialog();
        }
    }
}
