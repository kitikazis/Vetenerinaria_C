namespace VeterinariaPet
{
    partial class N_1
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Tabla_Mascota = new System.Windows.Forms.DataGridView();
            this.mascotaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueñoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueñosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalPetDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalPetData = new VeterinariaPet.AnimalPetData();
            this.mascotasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mascotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mascotasTableAdapter = new VeterinariaPet.AnimalPetDataTableAdapters.MascotasTableAdapter();
            this.obtenerTodasLasMascotasTableAdapter1 = new VeterinariaPet.AnimalPetDataTableAdapters.ObtenerTodasLasMascotasTableAdapter();
            this.obtenerTodasLasMascotasTableAdapter2 = new VeterinariaPet.AnimalPetDataTableAdapters.ObtenerTodasLasMascotasTableAdapter();
            this.mascotasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mascotasBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.logisticaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logisticaTableAdapter = new VeterinariaPet.AnimalPetDataTableAdapters.LogisticaTableAdapter();
            this.dueñosTableAdapter = new VeterinariaPet.AnimalPetDataTableAdapters.DueñosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Mascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dueñosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalPetDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalPetData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(17, 118);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Green;
            this.btn_agregar.ForeColor = System.Drawing.Color.Black;
            this.btn_agregar.Location = new System.Drawing.Point(743, 393);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(124, 42);
            this.btn_agregar.TabIndex = 18;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(480, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 44);
            this.button1.TabIndex = 19;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Location = new System.Drawing.Point(287, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 42);
            this.button3.TabIndex = 21;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = false;
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
            this.dueñoidDataGridViewTextBoxColumn});
            this.Tabla_Mascota.DataSource = this.dueñosBindingSource;
            this.Tabla_Mascota.Location = new System.Drawing.Point(259, 37);
            this.Tabla_Mascota.Name = "Tabla_Mascota";
            this.Tabla_Mascota.Size = new System.Drawing.Size(368, 306);
            this.Tabla_Mascota.TabIndex = 24;
            this.Tabla_Mascota.VirtualMode = true;
            this.Tabla_Mascota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabla_Mascota_CellContentClick);
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
            // dueñoidDataGridViewTextBoxColumn
            // 
            this.dueñoidDataGridViewTextBoxColumn.DataPropertyName = "dueño_id";
            this.dueñoidDataGridViewTextBoxColumn.HeaderText = "dueño_id";
            this.dueñoidDataGridViewTextBoxColumn.Name = "dueñoidDataGridViewTextBoxColumn";
            this.dueñoidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dueñosBindingSource
            // 
            this.dueñosBindingSource.DataMember = "Dueños";
            this.dueñosBindingSource.DataSource = this.animalPetDataBindingSource;
            // 
            // animalPetDataBindingSource
            // 
            this.animalPetDataBindingSource.DataSource = this.animalPetData;
            this.animalPetDataBindingSource.Position = 0;
            // 
            // animalPetData
            // 
            this.animalPetData.DataSetName = "AnimalPetData";
            this.animalPetData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mascotasBindingSource1
            // 
            this.mascotasBindingSource1.DataMember = "Mascotas";
            this.mascotasBindingSource1.DataSource = this.animalPetDataBindingSource;
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
            // obtenerTodasLasMascotasTableAdapter1
            // 
            this.obtenerTodasLasMascotasTableAdapter1.ClearBeforeFill = true;
            // 
            // obtenerTodasLasMascotasTableAdapter2
            // 
            this.obtenerTodasLasMascotasTableAdapter2.ClearBeforeFill = true;
            // 
            // mascotasBindingSource2
            // 
            this.mascotasBindingSource2.DataMember = "Mascotas";
            this.mascotasBindingSource2.DataSource = this.animalPetDataBindingSource;
            // 
            // mascotasBindingSource3
            // 
            this.mascotasBindingSource3.DataMember = "Mascotas";
            this.mascotasBindingSource3.DataSource = this.animalPetDataBindingSource;
            // 
            // logisticaBindingSource
            // 
            this.logisticaBindingSource.DataMember = "Logistica";
            this.logisticaBindingSource.DataSource = this.animalPetDataBindingSource;
            // 
            // logisticaTableAdapter
            // 
            this.logisticaTableAdapter.ClearBeforeFill = true;
            // 
            // dueñosTableAdapter
            // 
            this.dueñosTableAdapter.ClearBeforeFill = true;
            // 
            // N_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1088, 633);
            this.Controls.Add(this.Tabla_Mascota);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "N_1";
            this.Text = "N_1";
            this.Load += new System.EventHandler(this.N_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Mascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dueñosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalPetDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalPetData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView Tabla_Mascota;
        private System.Windows.Forms.BindingSource animalPetDataBindingSource;
        private AnimalPetData animalPetData;
        private System.Windows.Forms.BindingSource mascotasBindingSource;
        private AnimalPetDataTableAdapters.MascotasTableAdapter mascotasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mascotaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueñoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mascotasBindingSource1;
        private AnimalPetDataTableAdapters.ObtenerTodasLasMascotasTableAdapter obtenerTodasLasMascotasTableAdapter1;
        private AnimalPetDataTableAdapters.ObtenerTodasLasMascotasTableAdapter obtenerTodasLasMascotasTableAdapter2;
        private System.Windows.Forms.BindingSource mascotasBindingSource2;
        private System.Windows.Forms.BindingSource logisticaBindingSource;
        private AnimalPetDataTableAdapters.LogisticaTableAdapter logisticaTableAdapter;
        private System.Windows.Forms.BindingSource mascotasBindingSource3;
        private System.Windows.Forms.BindingSource dueñosBindingSource;
        private AnimalPetDataTableAdapters.DueñosTableAdapter dueñosTableAdapter;
    }
}