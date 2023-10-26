namespace VeterinariaPet.Formularios.Reportes
{
    partial class Pagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Tabla_Mascota = new System.Windows.Forms.DataGridView();
            this.dateTime_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_genero = new System.Windows.Forms.TextBox();
            this.animalPetData = new VeterinariaPet.AnimalPetData();
            this.recetasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recetasTableAdapter = new VeterinariaPet.AnimalPetDataTableAdapters.RecetasTableAdapter();
            this.recetaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historiaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamentoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Mascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalPetData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabla_Mascota
            // 
            this.Tabla_Mascota.AllowUserToOrderColumns = true;
            this.Tabla_Mascota.AutoGenerateColumns = false;
            this.Tabla_Mascota.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tabla_Mascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_Mascota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recetaidDataGridViewTextBoxColumn,
            this.historiaidDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.medicamentoidDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.Tabla_Mascota.DataSource = this.recetasBindingSource;
            this.Tabla_Mascota.Location = new System.Drawing.Point(328, 48);
            this.Tabla_Mascota.Name = "Tabla_Mascota";
            this.Tabla_Mascota.Size = new System.Drawing.Size(571, 316);
            this.Tabla_Mascota.TabIndex = 38;
            this.Tabla_Mascota.VirtualMode = true;
            this.Tabla_Mascota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabla_Mascota_CellContentClick);
            // 
            // dateTime_Nacimiento
            // 
            this.dateTime_Nacimiento.Location = new System.Drawing.Point(27, 158);
            this.dateTime_Nacimiento.Name = "dateTime_Nacimiento";
            this.dateTime_Nacimiento.Size = new System.Drawing.Size(100, 20);
            this.dateTime_Nacimiento.TabIndex = 37;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Location = new System.Drawing.Point(328, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 42);
            this.button3.TabIndex = 36;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(521, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 44);
            this.button1.TabIndex = 35;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Green;
            this.btn_agregar.ForeColor = System.Drawing.Color.Black;
            this.btn_agregar.Location = new System.Drawing.Point(784, 420);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(124, 42);
            this.btn_agregar.TabIndex = 34;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // txt_genero
            // 
            this.txt_genero.Location = new System.Drawing.Point(27, 208);
            this.txt_genero.Name = "txt_genero";
            this.txt_genero.Size = new System.Drawing.Size(100, 20);
            this.txt_genero.TabIndex = 27;
            // 
            // animalPetData
            // 
            this.animalPetData.DataSetName = "AnimalPetData";
            this.animalPetData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recetasBindingSource
            // 
            this.recetasBindingSource.DataMember = "Recetas";
            this.recetasBindingSource.DataSource = this.animalPetData;
            // 
            // recetasTableAdapter
            // 
            this.recetasTableAdapter.ClearBeforeFill = true;
            // 
            // recetaidDataGridViewTextBoxColumn
            // 
            this.recetaidDataGridViewTextBoxColumn.DataPropertyName = "receta_id";
            this.recetaidDataGridViewTextBoxColumn.HeaderText = "receta_id";
            this.recetaidDataGridViewTextBoxColumn.Name = "recetaidDataGridViewTextBoxColumn";
            this.recetaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // historiaidDataGridViewTextBoxColumn
            // 
            this.historiaidDataGridViewTextBoxColumn.DataPropertyName = "historia_id";
            this.historiaidDataGridViewTextBoxColumn.HeaderText = "historia_id";
            this.historiaidDataGridViewTextBoxColumn.Name = "historiaidDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // medicamentoidDataGridViewTextBoxColumn
            // 
            this.medicamentoidDataGridViewTextBoxColumn.DataPropertyName = "medicamento_id";
            this.medicamentoidDataGridViewTextBoxColumn.HeaderText = "medicamento_id";
            this.medicamentoidDataGridViewTextBoxColumn.Name = "medicamentoidDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1190, 570);
            this.Controls.Add(this.Tabla_Mascota);
            this.Controls.Add(this.dateTime_Nacimiento);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_genero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pagos";
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.Pagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Mascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalPetData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tabla_Mascota;
        private System.Windows.Forms.DateTimePicker dateTime_Nacimiento;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_genero;
        private AnimalPetData animalPetData;
        private System.Windows.Forms.BindingSource recetasBindingSource;
        private AnimalPetDataTableAdapters.RecetasTableAdapter recetasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recetaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historiaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamentoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
    }
}