namespace TP_DDS
{
    partial class Baja
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
            this.btnBaja = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaInscripciones = new System.Windows.Forms.DataGridView();
            this.disenio_tpDataSet = new TPDisenio2014.disenio_tpDataSet();
            this.partidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partidosTableAdapter = new TPDisenio2014.disenio_tpDataSetTableAdapters.PartidosTableAdapter();
            this.diseniotpDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disenio_tpDataSet1 = new TPDisenio2014.disenio_tpDataSet1();
            this.inscripcionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inscripcionesTableAdapter = new TPDisenio2014.disenio_tpDataSet1TableAdapters.InscripcionesTableAdapter();
            this.iduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpartidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaInscripciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disenio_tpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseniotpDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disenio_tpDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscripcionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(26, 251);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(157, 33);
            this.btnBaja.TabIndex = 0;
            this.btnBaja.Text = "Dar de Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inscripciones";
            // 
            // tablaInscripciones
            // 
            this.tablaInscripciones.AllowUserToAddRows = false;
            this.tablaInscripciones.AllowUserToDeleteRows = false;
            this.tablaInscripciones.AllowUserToResizeRows = false;
            this.tablaInscripciones.AutoGenerateColumns = false;
            this.tablaInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaInscripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iduserDataGridViewTextBoxColumn,
            this.idpartidoDataGridViewTextBoxColumn});
            this.tablaInscripciones.DataSource = this.inscripcionesBindingSource;
            this.tablaInscripciones.Location = new System.Drawing.Point(26, 61);
            this.tablaInscripciones.Name = "tablaInscripciones";
            this.tablaInscripciones.ReadOnly = true;
            this.tablaInscripciones.Size = new System.Drawing.Size(245, 150);
            this.tablaInscripciones.TabIndex = 6;
            this.tablaInscripciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // disenio_tpDataSet
            // 
            this.disenio_tpDataSet.DataSetName = "disenio_tpDataSet";
            this.disenio_tpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partidosBindingSource
            // 
            this.partidosBindingSource.DataMember = "Partidos";
            this.partidosBindingSource.DataSource = this.disenio_tpDataSet;
            // 
            // partidosTableAdapter
            // 
            this.partidosTableAdapter.ClearBeforeFill = true;
            // 
            // diseniotpDataSetBindingSource
            // 
            this.diseniotpDataSetBindingSource.DataSource = this.disenio_tpDataSet;
            this.diseniotpDataSetBindingSource.Position = 0;
            // 
            // disenio_tpDataSet1
            // 
            this.disenio_tpDataSet1.DataSetName = "disenio_tpDataSet1";
            this.disenio_tpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inscripcionesBindingSource
            // 
            this.inscripcionesBindingSource.DataMember = "Inscripciones";
            this.inscripcionesBindingSource.DataSource = this.disenio_tpDataSet1;
            // 
            // inscripcionesTableAdapter
            // 
            this.inscripcionesTableAdapter.ClearBeforeFill = true;
            // 
            // iduserDataGridViewTextBoxColumn
            // 
            this.iduserDataGridViewTextBoxColumn.DataPropertyName = "id_user";
            this.iduserDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.iduserDataGridViewTextBoxColumn.Name = "iduserDataGridViewTextBoxColumn";
            this.iduserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idpartidoDataGridViewTextBoxColumn
            // 
            this.idpartidoDataGridViewTextBoxColumn.DataPropertyName = "id_partido";
            this.idpartidoDataGridViewTextBoxColumn.HeaderText = "Fecha del Partido";
            this.idpartidoDataGridViewTextBoxColumn.Name = "idpartidoDataGridViewTextBoxColumn";
            this.idpartidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.tablaInscripciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBaja);
            this.Name = "Baja";
            this.Text = "Baja";
            this.Load += new System.EventHandler(this.Baja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaInscripciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disenio_tpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseniotpDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disenio_tpDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscripcionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaInscripciones;
        private TPDisenio2014.disenio_tpDataSet disenio_tpDataSet;
        private System.Windows.Forms.BindingSource partidosBindingSource;
        private TPDisenio2014.disenio_tpDataSetTableAdapters.PartidosTableAdapter partidosTableAdapter;
        private System.Windows.Forms.BindingSource diseniotpDataSetBindingSource;
        private TPDisenio2014.disenio_tpDataSet1 disenio_tpDataSet1;
        private System.Windows.Forms.BindingSource inscripcionesBindingSource;
        private TPDisenio2014.disenio_tpDataSet1TableAdapters.InscripcionesTableAdapter inscripcionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpartidoDataGridViewTextBoxColumn;
    }
}