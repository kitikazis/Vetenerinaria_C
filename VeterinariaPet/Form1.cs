using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaPet.Formularios;
using VeterinariaPet.Formularios.Reportes;

namespace VeterinariaPet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            abriFormHija(new N_2());
        }

        private void SubMenu_Reportes_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void sub_menu_reportes_Click(object sender, EventArgs e)
        {
            sub_menu_reportes.Visible = true;
        }

        private void btn_reporte_ventas_Click(object sender, EventArgs e)
        {
            sub_menu_reportes.Visible = false;
            abriFormHija(new Ventas());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abriFormHija(new N_3());
        }

        private void btn_producto_Click(object sender, EventArgs e)
        {
            abriFormHija(new N_1());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            abriFormHija(new N_5());
        }

        private void btn_reportes_ventas_Click(object sender, EventArgs e)
        {
            sub_menu_reportes.Visible = false;
            abriFormHija(new Compras());
        }

        private void btn_reportes_pagos_Click(object sender, EventArgs e)
        {
            sub_menu_reportes.Visible = false;
            abriFormHija(new Pagos());
        }


        private void abriFormHija(object formhija)
        {

            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock=DockStyle.Fill;
            this.panel_contenedor.Controls.Add(fh);
            this.panel_contenedor.Tag= fh;
            fh.Show();

            {
                
            }
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            abriFormHija(new N_4());
        }
    }
}
