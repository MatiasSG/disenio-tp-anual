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
            this.inscripcionesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.disenio_tpDataSet2 = new TPDisenio2014.disenio_tpDataSet2();
            this.inscripcionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disenio_tpDataSet1 = new TPDisenio2014.disenio_tpDataSet1();
            this.disenio_tpDataSet = new TPDisenio2014.disenio_tpDataSet();
            this.partidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partidosTableAdapter = new TPDisenio2014.disenio_tpDataSetTableAdapters.PartidosTableAdapter();
            this.diseniotpDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inscripcionesTableAdapter = new TPDisenio2014.disenio_tpDataSet1TableAdapters.InscripcionesTableAdapter();
            this.inscripcionesTableAdapter1 = new TPDisenio2014.disenio_tpDataSet2TableAdapters.InscripcionesTableAdapter();
            this.disenio_tpDataSet3 = new TPDisenio2014.disenio_tpDataSet3();
            this.selectInscripcionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectInscripcionesTableAdapter = new TPDisenio2014.disenio_tpDataSet3TableAdapters.selectInscripcionesTableAdapter();
            this.disenio_tpDataSet4 = new TPDisenio2014.disenio_tpDataSet4();
            this.selectInscripcionesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.selectInscripcionesTableAdapter1 = new TPDisenio2014.disenio_tpDataSet4TableAdapters.selectInscripcionesTableAdapter();
            this.disenio_tpDataSet5 = new TPDisenio2014.disenio_tpDataSet5();
            this.selectInscripcionesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.selectInscripcionesTableAdapter2 = new TPDisenio2014.disenio_tpDataSet5TableAdapters.selectInscripcionesTableAdapter();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPartidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePartidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaJugadores = new System.Windows.Forms.DataGridView();
            this.disenio_tpDataSet6 = new TPDisenio2014.disenio_tpDataSet6();
            this.selectJugadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectJugadoresTableAdapter = new TPDisenio2014.disenio_tpDataSet6TableAdapters.selectJugadoresTableAdapter();
            this.usuarioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaInscripciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscripcionesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disenio_tpDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscripcionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disenio_tpDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disenio_tpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseniotpDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disenio_tpDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectInscripcionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disenio_tpDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectInscripcionesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disenio_tpDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectInscripcionesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disenio_tpDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectJugadoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaja
            // 
            this.btnBaja.Enabled = false;
            this.btnBaja.Location = new System.Drawing.Point(26, 399);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(157, 33);
            this.btnBaja.TabIndex = 0;
            this.btnBaja.Text = "Baja Partido";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 399);
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
            this.usuarioDataGridViewTextBoxColumn,
            this.fechaPartidoDataGridViewTextBoxColumn,
            this.nombrePartidoDataGridViewTextBoxColumn});
            this.tablaInscripciones.DataSource = this.selectInscripcionesBindingSource2;
            this.tablaInscripciones.Location = new System.Drawing.Point(26, 61);
            this.tablaInscripciones.Name = "tablaInscripciones";
            this.tablaInscripciones.ReadOnly = true;
            this.tablaInscripciones.Size = new System.Drawing.Size(345, 141);
            this.tablaInscripciones.TabIndex = 6;
            this.tablaInscripciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // inscripcionesBindingSource1
            // 
            this.inscripcionesBindingSource1.DataMember = "Inscripciones";
            this.inscripcionesBindingSource1.DataSource = this.disenio_tpDataSet2;
            // 
            // disenio_tpDataSet2
            // 
            this.disenio_tpDataSet2.DataSetName = "disenio_tpDataSet2";
            this.disenio_tpDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inscripcionesBindingSource
            // 
            this.inscripcionesBindingSource.DataMember = "Inscripciones";
            this.inscripcionesBindingSource.DataSource = this.disenio_tpDataSet1;
            // 
            // disenio_tpDataSet1
            // 
            this.disenio_tpDataSet1.DataSetName = "disenio_tpDataSet1";
            this.disenio_tpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // inscripcionesTableAdapter
            // 
            this.inscripcionesTableAdapter.ClearBeforeFill = true;
            // 
            // inscripcionesTableAdapter1
            // 
            this.inscripcionesTableAdapter1.ClearBeforeFill = true;
            // 
            // disenio_tpDataSet3
            // 
            this.disenio_tpDataSet3.DataSetName = "disenio_tpDataSet3";
            this.disenio_tpDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectInscripcionesBindingSource
            // 
            this.selectInscripcionesBindingSource.DataMember = "selectInscripciones";
            this.selectInscripcionesBindingSource.DataSource = this.disenio_tpDataSet3;
            // 
            // selectInscripcionesTableAdapter
            // 
            this.selectInscripcionesTableAdapter.ClearBeforeFill = true;
            // 
            // disenio_tpDataSet4
            // 
            this.disenio_tpDataSet4.DataSetName = "disenio_tpDataSet4";
            this.disenio_tpDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectInscripcionesBindingSource1
            // 
            this.selectInscripcionesBindingSource1.DataMember = "selectInscripciones";
            this.selectInscripcionesBindingSource1.DataSource = this.disenio_tpDataSet4;
            // 
            // selectInscripcionesTableAdapter1
            // 
            this.selectInscripcionesTableAdapter1.ClearBeforeFill = true;
            // 
            // disenio_tpDataSet5
            // 
            this.disenio_tpDataSet5.DataSetName = "disenio_tpDataSet5";
            this.disenio_tpDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectInscripcionesBindingSource2
            // 
            this.selectInscripcionesBindingSource2.DataMember = "selectInscripciones";
            this.selectInscripcionesBindingSource2.DataSource = this.disenio_tpDataSet5;
            // 
            // selectInscripcionesTableAdapter2
            // 
            this.selectInscripcionesTableAdapter2.ClearBeforeFill = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaPartidoDataGridViewTextBoxColumn
            // 
            this.fechaPartidoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Partido";
            this.fechaPartidoDataGridViewTextBoxColumn.HeaderText = "Fecha_Partido";
            this.fechaPartidoDataGridViewTextBoxColumn.Name = "fechaPartidoDataGridViewTextBoxColumn";
            this.fechaPartidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrePartidoDataGridViewTextBoxColumn
            // 
            this.nombrePartidoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Partido";
            this.nombrePartidoDataGridViewTextBoxColumn.HeaderText = "Nombre_Partido";
            this.nombrePartidoDataGridViewTextBoxColumn.Name = "nombrePartidoDataGridViewTextBoxColumn";
            this.nombrePartidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tablaJugadores
            // 
            this.tablaJugadores.AllowUserToAddRows = false;
            this.tablaJugadores.AllowUserToDeleteRows = false;
            this.tablaJugadores.AutoGenerateColumns = false;
            this.tablaJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaJugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuarioDataGridViewTextBoxColumn1,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn});
            this.tablaJugadores.DataSource = this.selectJugadoresBindingSource;
            this.tablaJugadores.Enabled = false;
            this.tablaJugadores.Location = new System.Drawing.Point(26, 248);
            this.tablaJugadores.Name = "tablaJugadores";
            this.tablaJugadores.ReadOnly = true;
            this.tablaJugadores.Size = new System.Drawing.Size(342, 128);
            this.tablaJugadores.TabIndex = 7;
            // 
            // disenio_tpDataSet6
            // 
            this.disenio_tpDataSet6.DataSetName = "disenio_tpDataSet6";
            this.disenio_tpDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectJugadoresBindingSource
            // 
            this.selectJugadoresBindingSource.DataMember = "selectJugadores";
            this.selectJugadoresBindingSource.DataSource = this.disenio_tpDataSet6;
            // 
            // selectJugadoresTableAdapter
            // 
            this.selectJugadoresTableAdapter.ClearBeforeFill = true;
            // 
            // usuarioDataGridViewTextBoxColumn1
            // 
            this.usuarioDataGridViewTextBoxColumn1.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn1.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn1.Name = "usuarioDataGridViewTextBoxColumn1";
            this.usuarioDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Jugadores:";
            // 
            // Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 445);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tablaJugadores);
            this.Controls.Add(this.tablaInscripciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBaja);
            this.Name = "Baja";
            this.Text = "Baja";
            this.Load += new System.EventHandler(this.Baja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaInscripciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscripcionesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disenio_tpDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscripcionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disenio_tpDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disenio_tpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseniotpDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disenio_tpDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectInscripcionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disenio_tpDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectInscripcionesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disenio_tpDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectInscripcionesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaJugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disenio_tpDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectJugadoresBindingSource)).EndInit();
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
        private TPDisenio2014.disenio_tpDataSet2 disenio_tpDataSet2;
        private System.Windows.Forms.BindingSource inscripcionesBindingSource1;
        private TPDisenio2014.disenio_tpDataSet2TableAdapters.InscripcionesTableAdapter inscripcionesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPartidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePartidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource selectInscripcionesBindingSource2;
        private TPDisenio2014.disenio_tpDataSet5 disenio_tpDataSet5;
        private TPDisenio2014.disenio_tpDataSet3 disenio_tpDataSet3;
        private System.Windows.Forms.BindingSource selectInscripcionesBindingSource;
        private TPDisenio2014.disenio_tpDataSet3TableAdapters.selectInscripcionesTableAdapter selectInscripcionesTableAdapter;
        private TPDisenio2014.disenio_tpDataSet4 disenio_tpDataSet4;
        private System.Windows.Forms.BindingSource selectInscripcionesBindingSource1;
        private TPDisenio2014.disenio_tpDataSet4TableAdapters.selectInscripcionesTableAdapter selectInscripcionesTableAdapter1;
        private TPDisenio2014.disenio_tpDataSet5TableAdapters.selectInscripcionesTableAdapter selectInscripcionesTableAdapter2;
        private System.Windows.Forms.DataGridView tablaJugadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource selectJugadoresBindingSource;
        private TPDisenio2014.disenio_tpDataSet6 disenio_tpDataSet6;
        private TPDisenio2014.disenio_tpDataSet6TableAdapters.selectJugadoresTableAdapter selectJugadoresTableAdapter;
        private System.Windows.Forms.Label label2;
    }
}