using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace VeterinariaPet
{
    public partial class N_1 : Form
    {
        public N_1()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            // Get the data from the UI elements (labels or textboxes).
            string nombre = txt_nombre.Text;
            //  string especie = txt_especie.Text;
            //   string raza = txt_raza.Text;
            //   DateTime fechaNacimiento = dateTime_Nacimiento.Value;
            //   string genero = txt_genero.Text;

            // Validate the data if necessary.
            //     if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(especie) || string.IsNullOrEmpty(raza))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Assuming you have a SQL connection string and SqlConnection object.
            string connectionString = "Data Source=DESKTOP-3I4ECV8;Initial Catalog=AnimalPet;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Replace this line with the actual code to retrieve the owner's ID.


                string insertQuery = "INSERT INTO Mascotas (nombre, especie, raza, fecha_de_nacimiento, género, dueño_id) " +
                                    "VALUES (@nombre, @especie, @raza, @fechaNacimiento, @genero, @dueñoId)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    //          cmd.Parameters.AddWithValue("@especie", especie);
                    //        cmd.Parameters.AddWithValue("@raza", raza);
                    //            cmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                    //        cmd.Parameters.AddWithValue("@genero", genero);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data added successfully.");
                        // You can clear the input fields here if needed.
                        txt_nombre.Clear();
                        //         txt_especie.Clear();
                        //         txt_raza.Clear();
                        //          dateTime_Nacimiento.Value = DateTime.Now;
                        //         txt_genero.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add data.");
                    }
                }
            }
        }

        private void N_1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'animalPetData.Dueños' Puede moverla o quitarla según sea necesario.
            this.dueñosTableAdapter.Fill(this.animalPetData.Dueños);
            // TODO: esta línea de código carga datos en la tabla 'animalPetData.Logistica' Puede moverla o quitarla según sea necesario.
            this.logisticaTableAdapter.Fill(this.animalPetData.Logistica);
            // TODO: esta línea de código carga datos en la tabla 'animalPetData.Mascotas' Puede moverla o quitarla según sea necesario.
            this.mascotasTableAdapter.Fill(this.animalPetData.Mascotas);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tabla_Mascota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}