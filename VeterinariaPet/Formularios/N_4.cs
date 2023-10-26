using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinariaPet.Formularios
{
    public partial class N_4 : Form
    {
        public N_4()
        {
            InitializeComponent();
        }

        private void N_4_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'animalPetData.Citas' Puede moverla o quitarla según sea necesario.
            this.citasTableAdapter.Fill(this.animalPetData.Citas);

        }
    }
}
