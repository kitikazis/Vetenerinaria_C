namespace VeterinariaPet.Formularios.Reportes
{
    partial class Compras
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_raza = new System.Windows.Forms.TextBox();
            this.txt_especie = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.animalPetData = new VeterinariaPet.AnimalPetData();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioTableAdapter = new VeterinariaPet.AnimalPetDataTableAdapters.InventarioTableAdapter();
            this.inventarioidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciounitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaentradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosaludidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Mascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalPetData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabla_Mascota
            // 
            this.Tabla_Mascota.AllowUserToOrderColumns = true;
            this.Tabla_Mascota.AutoGenerateColumns = false;
            this.Tabla_Mascota.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tabla_Mascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_Mascota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventarioidDataGridViewTextBoxColumn,
            this.productoidDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.preciounitarioDataGridViewTextBoxColumn,
            this.fechaentradaDataGridViewTextBoxColumn,
            this.proveedoridDataGridViewTextBoxColumn,
            this.productosaludidDataGridViewTextBoxColumn});
            this.Tabla_Mascota.DataSource = this.inventarioBindingSource;
            this.Tabla_Mascota.Location = new System.Drawing.Point(307, 39);
            this.Tabla_Mascota.Name = "Tabla_Mascota";
            this.Tabla_Mascota.Size = new System.Drawing.Size(745, 316);
            this.Tabla_Mascota.TabIndex = 38;
            this.Tabla_Mascota.VirtualMode = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Location = new System.Drawing.Point(353, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 42);
            this.button3.TabIndex = 36;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(546, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 44);
            this.button1.TabIndex = 35;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Green;
            this.btn_agregar.ForeColor = System.Drawing.Color.Black;
            this.btn_agregar.Location = new System.Drawing.Point(809, 408);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(125, 42);
            this.btn_agregar.TabIndex = 34;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Fecha entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Precio unitario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Cantidad";
            // 
            // txt_raza
            // 
            this.txt_raza.Location = new System.Drawing.Point(51, 233);
            this.txt_raza.Name = "txt_raza";
            this.txt_raza.Size = new System.Drawing.Size(101, 20);
            this.txt_raza.TabIndex = 28;
            // 
            // txt_especie
            // 
            this.txt_especie.Location = new System.Drawing.Point(51, 192);
            this.txt_especie.Name = "txt_especie";
            this.txt_especie.Size = new System.Drawing.Size(101, 20);
            this.txt_especie.TabIndex = 26;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(51, 146);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(101, 20);
            this.txt_nombre.TabIndex = 25;
            // 
            // animalPetData
            // 
            this.animalPetData.DataSetName = "AnimalPetData";
            this.animalPetData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "Inventario";
            this.inventarioBindingSource.DataSource = this.animalPetData;
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // inventarioidDataGridViewTextBoxColumn
            // 
            this.inventarioidDataGridViewTextBoxColumn.DataPropertyName = "inventario_id";
            this.inventarioidDataGridViewTextBoxColumn.HeaderText = "inventario_id";
            this.inventarioidDataGridViewTextBoxColumn.Name = "inventarioidDataGridViewTextBoxColumn";
            this.inventarioidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoidDataGridViewTextBoxColumn
            // 
            this.productoidDataGridViewTextBoxColumn.DataPropertyName = "producto_id";
            this.productoidDataGridViewTextBoxColumn.HeaderText = "producto_id";
            this.productoidDataGridViewTextBoxColumn.Name = "productoidDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // preciounitarioDataGridViewTextBoxColumn
            // 
            this.preciounitarioDataGridViewTextBoxColumn.DataPropertyName = "precio_unitario";
            this.preciounitarioDataGridViewTextBoxColumn.HeaderText = "precio_unitario";
            this.preciounitarioDataGridViewTextBoxColumn.Name = "preciounitarioDataGridViewTextBoxColumn";
            // 
            // fechaentradaDataGridViewTextBoxColumn
            // 
            this.fechaentradaDataGridViewTextBoxColumn.DataPropertyName = "fecha_entrada";
            this.fechaentradaDataGridViewTextBoxColumn.HeaderText = "fecha_entrada";
            this.fechaentradaDataGridViewTextBoxColumn.Name = "fechaentradaDataGridViewTextBoxColumn";
            // 
            // proveedoridDataGridViewTextBoxColumn
            // 
            this.proveedoridDataGridViewTextBoxColumn.DataPropertyName = "proveedor_id";
            this.proveedoridDataGridViewTextBoxColumn.HeaderText = "proveedor_id";
            this.proveedoridDataGridViewTextBoxColumn.Name = "proveedoridDataGridViewTextBoxColumn";
            // 
            // productosaludidDataGridViewTextBoxColumn
            // 
            this.productosaludidDataGridViewTextBoxColumn.DataPropertyName = "producto_salud_id";
            this.productosaludidDataGridViewTextBoxColumn.HeaderText = "producto_salud_id";
            this.productosaludidDataGridViewTextBoxColumn.Name = "productosaludidDataGridViewTextBoxColumn";
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1119, 543);
            this.Controls.Add(this.Tabla_Mascota);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_raza);
            this.Controls.Add(this.txt_especie);
            this.Controls.Add(this.txt_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Mascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalPetData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tabla_Mascota;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_raza;
        private System.Windows.Forms.TextBox txt_especie;
        private System.Windows.Forms.TextBox txt_nombre;
        private AnimalPetData animalPetData;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private AnimalPetDataTableAdapters.InventarioTableAdapter inventarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventarioidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciounitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaentradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productosaludidDataGridViewTextBoxColumn;
    }
}