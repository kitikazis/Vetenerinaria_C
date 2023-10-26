namespace VeterinariaPet.Formularios
{
    partial class N_4
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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.animalPetData = new VeterinariaPet.AnimalPetData();
            this.citasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citasTableAdapter = new VeterinariaPet.AnimalPetDataTableAdapters.CitasTableAdapter();
            this.citaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mascotaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veterinarioidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechahoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivodelacitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTime_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_genero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Mascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalPetData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabla_Mascota
            // 
            this.Tabla_Mascota.AllowUserToOrderColumns = true;
            this.Tabla_Mascota.AutoGenerateColumns = false;
            this.Tabla_Mascota.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tabla_Mascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_Mascota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.citaidDataGridViewTextBoxColumn,
            this.mascotaidDataGridViewTextBoxColumn,
            this.veterinarioidDataGridViewTextBoxColumn,
            this.fechahoraDataGridViewTextBoxColumn,
            this.motivodelacitaDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.Tabla_Mascota.DataSource = this.citasBindingSource;
            this.Tabla_Mascota.Location = new System.Drawing.Point(265, 78);
            this.Tabla_Mascota.Name = "Tabla_Mascota";
            this.Tabla_Mascota.Size = new System.Drawing.Size(661, 316);
            this.Tabla_Mascota.TabIndex = 38;
            this.Tabla_Mascota.VirtualMode = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Location = new System.Drawing.Point(290, 448);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 42);
            this.button3.TabIndex = 36;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(483, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 44);
            this.button1.TabIndex = 35;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Green;
            this.btn_agregar.ForeColor = System.Drawing.Color.Black;
            this.btn_agregar.Location = new System.Drawing.Point(746, 450);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(41, 42);
            this.btn_agregar.TabIndex = 34;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            // 
            // animalPetData
            // 
            this.animalPetData.DataSetName = "AnimalPetData";
            this.animalPetData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citasBindingSource
            // 
            this.citasBindingSource.DataMember = "Citas";
            this.citasBindingSource.DataSource = this.animalPetData;
            // 
            // citasTableAdapter
            // 
            this.citasTableAdapter.ClearBeforeFill = true;
            // 
            // citaidDataGridViewTextBoxColumn
            // 
            this.citaidDataGridViewTextBoxColumn.DataPropertyName = "cita_id";
            this.citaidDataGridViewTextBoxColumn.HeaderText = "cita_id";
            this.citaidDataGridViewTextBoxColumn.Name = "citaidDataGridViewTextBoxColumn";
            this.citaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mascotaidDataGridViewTextBoxColumn
            // 
            this.mascotaidDataGridViewTextBoxColumn.DataPropertyName = "mascota_id";
            this.mascotaidDataGridViewTextBoxColumn.HeaderText = "mascota_id";
            this.mascotaidDataGridViewTextBoxColumn.Name = "mascotaidDataGridViewTextBoxColumn";
            // 
            // veterinarioidDataGridViewTextBoxColumn
            // 
            this.veterinarioidDataGridViewTextBoxColumn.DataPropertyName = "veterinario_id";
            this.veterinarioidDataGridViewTextBoxColumn.HeaderText = "veterinario_id";
            this.veterinarioidDataGridViewTextBoxColumn.Name = "veterinarioidDataGridViewTextBoxColumn";
            // 
            // fechahoraDataGridViewTextBoxColumn
            // 
            this.fechahoraDataGridViewTextBoxColumn.DataPropertyName = "fecha_hora";
            this.fechahoraDataGridViewTextBoxColumn.HeaderText = "fecha_hora";
            this.fechahoraDataGridViewTextBoxColumn.Name = "fechahoraDataGridViewTextBoxColumn";
            // 
            // motivodelacitaDataGridViewTextBoxColumn
            // 
            this.motivodelacitaDataGridViewTextBoxColumn.DataPropertyName = "motivo_de_la_cita";
            this.motivodelacitaDataGridViewTextBoxColumn.HeaderText = "motivo_de_la_cita";
            this.motivodelacitaDataGridViewTextBoxColumn.Name = "motivodelacitaDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "Estado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 313);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 45;
            // 
            // dateTime_Nacimiento
            // 
            this.dateTime_Nacimiento.Location = new System.Drawing.Point(27, 190);
            this.dateTime_Nacimiento.Name = "dateTime_Nacimiento";
            this.dateTime_Nacimiento.Size = new System.Drawing.Size(100, 20);
            this.dateTime_Nacimiento.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(128, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 18);
            this.label6.TabIndex = 43;
            this.label6.Text = "Motivo de cita";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 42;
            this.label5.Text = "Fecha y Hora";
            // 
            // txt_genero
            // 
            this.txt_genero.Location = new System.Drawing.Point(22, 249);
            this.txt_genero.Name = "txt_genero";
            this.txt_genero.Size = new System.Drawing.Size(100, 20);
            this.txt_genero.TabIndex = 41;
            // 
            // N_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1008, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTime_Nacimiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_genero);
            this.Controls.Add(this.Tabla_Mascota);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "N_4";
            this.Text = "N_4";
            this.Load += new System.EventHandler(this.N_4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Mascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalPetData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tabla_Mascota;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_agregar;
        private AnimalPetData animalPetData;
        private System.Windows.Forms.BindingSource citasBindingSource;
        private AnimalPetDataTableAdapters.CitasTableAdapter citasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn citaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mascotaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veterinarioidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechahoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivodelacitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTime_Nacimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_genero;
    }
}