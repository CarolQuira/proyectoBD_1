using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoBD_1.models;
using proyectoBD_1.controller;

namespace proyectoBD_1.views
{
    public partial class UIUpdateLector : Form
    {
        public UIUpdateLector()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)//no utilizar :)
        {

        }

        private void label3_Click(object sender, EventArgs e)//no utilizar :)
        {

        }

        private void SelectLector(object sender, EventArgs e)
        {
            ControllerLector objcl = new ControllerLector();
            List<Lectores> listaL = objcl.SelectLectores();
        }
    }
}
