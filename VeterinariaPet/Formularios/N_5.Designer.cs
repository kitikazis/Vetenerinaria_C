namespace VeterinariaPet.Formularios
{
    partial class N_5
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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_raza = new System.Windows.Forms.TextBox();
            this.txt_genero = new System.Windows.Forms.TextBox();
            this.txt_especie = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.animalPetData = new VeterinariaPet.AnimalPetData();
            this.examenesClinicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examenesClinicosTableAdapter = new VeterinariaPet.AnimalPetDataTableAdapters.ExamenesClinicosTableAdapter();
            this.examenidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultadosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamentoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Mascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalPetData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenesClinicosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabla_Mascota
            // 
            this.Tabla_Mascota.AllowUserToOrderColumns = true;
            this.Tabla_Mascota.AutoGenerateColumns = false;
            this.Tabla_Mascota.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tabla_Mascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_Mascota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.examenidDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.resultadosDataGridViewTextBoxColumn,
            this.medicamentoidDataGridViewTextBoxColumn});
            this.Tabla_Mascota.DataSource = this.examenesClinicosBindingSource;
            this.Tabla_Mascota.Location = new System.Drawing.Point(321, 76);
            this.Tabla_Mascota.Name = "Tabla_Mascota";
            this.Tabla_Mascota.Size = new System.Drawing.Size(648, 316);
            this.Tabla_Mascota.TabIndex = 38;
            this.Tabla_Mascota.VirtualMode = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Location = new System.Drawing.Point(321, 451);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 42);
            this.button3.TabIndex = 36;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(514, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 44);
            this.button1.TabIndex = 35;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Green;
            this.btn_agregar.ForeColor = System.Drawing.Color.Black;
            this.btn_agregar.Location = new System.Drawing.Point(777, 453);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(119, 42);
            this.btn_agregar.TabIndex = 34;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre";
            // 
            // txt_raza
            // 
            this.txt_raza.Location = new System.Drawing.Point(51, 265);
            this.txt_raza.Name = "txt_raza";
            this.txt_raza.Size = new System.Drawing.Size(95, 20);
            this.txt_raza.TabIndex = 28;
            // 
            // txt_genero
            // 
            this.txt_genero.Location = new System.Drawing.Point(51, 316);
            this.txt_genero.Name = "txt_genero";
            this.txt_genero.Size = new System.Drawing.Size(95, 20);
            this.txt_genero.TabIndex = 27;
            // 
            // txt_especie
            // 
            this.txt_especie.Location = new System.Drawing.Point(51, 224);
            this.txt_especie.Name = "txt_especie";
            this.txt_especie.Size = new System.Drawing.Size(95, 20);
            this.txt_especie.TabIndex = 26;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(51, 178);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(95, 20);
            this.txt_nombre.TabIndex = 25;
            // 
            // animalPetData
            // 
            this.animalPetData.DataSetName = "AnimalPetData";
            this.animalPetData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examenesClinicosBindingSource
            // 
            this.examenesClinicosBindingSource.DataMember = "ExamenesClinicos";
            this.examenesClinicosBindingSource.DataSource = this.animalPetData;
            // 
            // examenesClinicosTableAdapter
            // 
            this.examenesClinicosTableAdapter.ClearBeforeFill = true;
            // 
            // examenidDataGridViewTextBoxColumn
            // 
            this.examenidDataGridViewTextBoxColumn.DataPropertyName = "examen_id";
            this.examenidDataGridViewTextBoxColumn.HeaderText = "examen_id";
            this.examenidDataGridViewTextBoxColumn.Name = "examenidDataGridViewTextBoxColumn";
            this.examenidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            // 
            // resultadosDataGridViewTextBoxColumn
            // 
            this.resultadosDataGridViewTextBoxColumn.DataPropertyName = "resultados";
            this.resultadosDataGridViewTextBoxColumn.HeaderText = "resultados";
            this.resultadosDataGridViewTextBoxColumn.Name = "resultadosDataGridViewTextBoxColumn";
            // 
            // medicamentoidDataGridViewTextBoxColumn
            // 
            this.medicamentoidDataGridViewTextBoxColumn.DataPropertyName = "medicamento_id";
            this.medicamentoidDataGridViewTextBoxColumn.HeaderText = "medicamento_id";
            this.medicamentoidDataGridViewTextBoxColumn.Name = "medicamentoidDataGridViewTextBoxColumn";
            // 
            // N_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1071, 578);
            this.Controls.Add(this.Tabla_Mascota);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_raza);
            this.Controls.Add(this.txt_genero);
            this.Controls.Add(this.txt_especie);
            this.Controls.Add(this.txt_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "N_5";
            this.Text = "N_5";
            this.Load += new System.EventHandler(this.N_5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Mascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalPetData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenesClinicosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tabla_Mascota;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_raza;
        private System.Windows.Forms.TextBox txt_genero;
        private System.Windows.Forms.TextBox txt_especie;
        private System.Windows.Forms.TextBox txt_nombre;
        private AnimalPetData animalPetData;
        private System.Windows.Forms.BindingSource examenesClinicosBindingSource;
        private AnimalPetDataTableAdapters.ExamenesClinicosTableAdapter examenesClinicosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn examenidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultadosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamentoidDataGridViewTextBoxColumn;
    }
}