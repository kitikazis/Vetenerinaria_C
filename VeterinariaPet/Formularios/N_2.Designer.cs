namespace VeterinariaPet.Formularios
{
    partial class N_2
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_raza = new System.Windows.Forms.TextBox();
            this.txt_genero = new System.Windows.Forms.TextBox();
            this.txt_especie = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.animalPetData = new VeterinariaPet.AnimalPetData();
            this.animalPetDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mascotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mascotasTableAdapter = new VeterinariaPet.AnimalPetDataTableAdapters.MascotasTableAdapter();
            this.mascotaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadenacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.géneroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueñoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Mascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalPetData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalPetDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabla_Mascota
            // 
            this.Tabla_Mascota.AllowUserToOrderColumns = true;
            this.Tabla_Mascota.AutoGenerateColumns = false;
            this.Tabla_Mascota.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tabla_Mascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_Mascota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mascotaidDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.especieDataGridViewTextBoxColumn,
            this.razaDataGridViewTextBoxColumn,
            this.fechadenacimientoDataGridViewTextBoxColumn,
            this.géneroDataGridViewTextBoxColumn,
            this.dueñoidDataGridViewTextBoxColumn});
            this.Tabla_Mascota.DataSource = this.mascotasBindingSource;
            this.Tabla_Mascota.Location = new System.Drawing.Point(341, 31);
            this.Tabla_Mascota.Name = "Tabla_Mascota";
            this.Tabla_Mascota.Size = new System.Drawing.Size(744, 316);
            this.Tabla_Mascota.TabIndex = 38;
            this.Tabla_Mascota.VirtualMode = true;
            // 
            // dateTime_Nacimiento
            // 
            this.dateTime_Nacimiento.Location = new System.Drawing.Point(51, 277);
            this.dateTime_Nacimiento.Name = "dateTime_Nacimiento";
            this.dateTime_Nacimiento.Size = new System.Drawing.Size(100, 20);
            this.dateTime_Nacimiento.TabIndex = 37;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Location = new System.Drawing.Point(321, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 42);
            this.button3.TabIndex = 36;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(514, 425);
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
            this.btn_agregar.Location = new System.Drawing.Point(777, 427);
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
            this.label6.Location = new System.Drawing.Point(157, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "Genero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(157, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Raza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Especie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre";
            // 
            // txt_raza
            // 
            this.txt_raza.Location = new System.Drawing.Point(51, 239);
            this.txt_raza.Name = "txt_raza";
            this.txt_raza.Size = new System.Drawing.Size(100, 20);
            this.txt_raza.TabIndex = 28;
            // 
            // txt_genero
            // 
            this.txt_genero.Location = new System.Drawing.Point(51, 327);
            this.txt_genero.Name = "txt_genero";
            this.txt_genero.Size = new System.Drawing.Size(100, 20);
            this.txt_genero.TabIndex = 27;
            // 
            // txt_especie
            // 
            this.txt_especie.Location = new System.Drawing.Point(51, 198);
            this.txt_especie.Name = "txt_especie";
            this.txt_especie.Size = new System.Drawing.Size(100, 20);
            this.txt_especie.TabIndex = 26;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(51, 152);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 25;
            // 
            // animalPetData
            // 
            this.animalPetData.DataSetName = "AnimalPetData";
            this.animalPetData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalPetDataBindingSource
            // 
            this.animalPetDataBindingSource.DataSource = this.animalPetData;
            this.animalPetDataBindingSource.Position = 0;
            // 
            // mascotasBindingSource
            // 
            this.mascotasBindingSource.DataMember = "Mascotas";
            this.mascotasBindingSource.DataSource = this.animalPetDataBindingSource;
            // 
            // mascotasTableAdapter
            // 
            this.mascotasTableAdapter.ClearBeforeFill = true;
            // 
            // mascotaidDataGridViewTextBoxColumn
            // 
            this.mascotaidDataGridViewTextBoxColumn.DataPropertyName = "mascota_id";
            this.mascotaidDataGridViewTextBoxColumn.HeaderText = "mascota_id";
            this.mascotaidDataGridViewTextBoxColumn.Name = "mascotaidDataGridViewTextBoxColumn";
            this.mascotaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // especieDataGridViewTextBoxColumn
            // 
            this.especieDataGridViewTextBoxColumn.DataPropertyName = "especie";
            this.especieDataGridViewTextBoxColumn.HeaderText = "especie";
            this.especieDataGridViewTextBoxColumn.Name = "especieDataGridViewTextBoxColumn";
            // 
            // razaDataGridViewTextBoxColumn
            // 
            this.razaDataGridViewTextBoxColumn.DataPropertyName = "raza";
            this.razaDataGridViewTextBoxColumn.HeaderText = "raza";
            this.razaDataGridViewTextBoxColumn.Name = "razaDataGridViewTextBoxColumn";
            // 
            // fechadenacimientoDataGridViewTextBoxColumn
            // 
            this.fechadenacimientoDataGridViewTextBoxColumn.DataPropertyName = "fecha_de_nacimiento";
            this.fechadenacimientoDataGridViewTextBoxColumn.HeaderText = "fecha_de_nacimiento";
            this.fechadenacimientoDataGridViewTextBoxColumn.Name = "fechadenacimientoDataGridViewTextBoxColumn";
            // 
            // géneroDataGridViewTextBoxColumn
            // 
            this.géneroDataGridViewTextBoxColumn.DataPropertyName = "género";
            this.géneroDataGridViewTextBoxColumn.HeaderText = "género";
            this.géneroDataGridViewTextBoxColumn.Name = "géneroDataGridViewTextBoxColumn";
            // 
            // dueñoidDataGridViewTextBoxColumn
            // 
            this.dueñoidDataGridViewTextBoxColumn.DataPropertyName = "dueño_id";
            this.dueñoidDataGridViewTextBoxColumn.HeaderText = "dueño_id";
            this.dueñoidDataGridViewTextBoxColumn.Name = "dueñoidDataGridViewTextBoxColumn";
            // 
            // N_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1150, 567);
            this.Controls.Add(this.Tabla_Mascota);
            this.Controls.Add(this.dateTime_Nacimiento);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_raza);
            this.Controls.Add(this.txt_genero);
            this.Controls.Add(this.txt_especie);
            this.Controls.Add(this.txt_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "N_2";
            this.Text = "N_2";
            this.Load += new System.EventHandler(this.N_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Mascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalPetData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalPetDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_raza;
        private System.Windows.Forms.TextBox txt_genero;
        private System.Windows.Forms.TextBox txt_especie;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.BindingSource animalPetDataBindingSource;
        private AnimalPetData animalPetData;
        private System.Windows.Forms.BindingSource mascotasBindingSource;
        private AnimalPetDataTableAdapters.MascotasTableAdapter mascotasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mascotaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadenacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn géneroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueñoidDataGridViewTextBoxColumn;
    }
}