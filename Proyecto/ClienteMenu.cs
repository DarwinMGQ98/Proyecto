﻿using System;
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
            alquila_DVDs.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pagar_por_el_alquiler pagar_Por_El_Alquiler = new Pagar_por_el_alquiler();
            pagar_Por_El_Alquiler.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            Historial_del_Cliente historial = new Historial_del_Cliente();
            historial.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
