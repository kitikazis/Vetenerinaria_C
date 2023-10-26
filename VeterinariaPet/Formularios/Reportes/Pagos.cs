using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinariaPet.Formularios.Reportes
{
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
        }

        private void Pagos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'animalPetData.Recetas' Puede moverla o quitarla según sea necesario.
            this.recetasTableAdapter.Fill(this.animalPetData.Recetas);

        }

        private void Tabla_Mascota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
