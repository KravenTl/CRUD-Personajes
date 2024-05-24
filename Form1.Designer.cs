namespace P18
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPrueba = new System.Windows.Forms.Button();
            this.dataGridViewPersonajes = new System.Windows.Forms.DataGridView();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelRaza = new System.Windows.Forms.Label();
            this.labelNiveldePoder = new System.Windows.Forms.Label();
            this.numericUpDownNiveldePoder = new System.Windows.Forms.NumericUpDown();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxRaza = new System.Windows.Forms.TextBox();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.comboBoxRaza = new System.Windows.Forms.ComboBox();
            this.labelHistoria = new System.Windows.Forms.Label();
            this.textBoxHistoria = new System.Windows.Forms.TextBox();
            this.dateTimePickerFecha_Creacion = new System.Windows.Forms.DateTimePicker();
            this.labelFecha_creacion = new System.Windows.Forms.Label();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.dateTimePickerBuscarEntreFechas = new System.Windows.Forms.DateTimePicker();
            this.button1BuscarPorFecha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNiveldePoder)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrueba
            // 
            this.buttonPrueba.Location = new System.Drawing.Point(39, 281);
            this.buttonPrueba.Name = "buttonPrueba";
            this.buttonPrueba.Size = new System.Drawing.Size(75, 28);
            this.buttonPrueba.TabIndex = 0;
            this.buttonPrueba.Text = "Prueba";
            this.buttonPrueba.UseVisualStyleBackColor = true;
            this.buttonPrueba.Click += new System.EventHandler(this.buttonPrueba_Click);
            // 
            // dataGridViewPersonajes
            // 
            this.dataGridViewPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonajes.Location = new System.Drawing.Point(39, 328);
            this.dataGridViewPersonajes.Name = "dataGridViewPersonajes";
            this.dataGridViewPersonajes.RowHeadersWidth = 51;
            this.dataGridViewPersonajes.RowTemplate.Height = 24;
            this.dataGridViewPersonajes.Size = new System.Drawing.Size(1018, 190);
            this.dataGridViewPersonajes.TabIndex = 1;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(120, 281);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(78, 28);
            this.buttonCargar.TabIndex = 2;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(10, 46);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(56, 16);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre";
            // 
            // labelRaza
            // 
            this.labelRaza.AutoSize = true;
            this.labelRaza.Location = new System.Drawing.Point(10, 91);
            this.labelRaza.Name = "labelRaza";
            this.labelRaza.Size = new System.Drawing.Size(39, 16);
            this.labelRaza.TabIndex = 4;
            this.labelRaza.Text = "Raza";
            this.labelRaza.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelNiveldePoder
            // 
            this.labelNiveldePoder.AutoSize = true;
            this.labelNiveldePoder.Location = new System.Drawing.Point(10, 127);
            this.labelNiveldePoder.Name = "labelNiveldePoder";
            this.labelNiveldePoder.Size = new System.Drawing.Size(97, 16);
            this.labelNiveldePoder.TabIndex = 5;
            this.labelNiveldePoder.Text = "Nivel de Poder";
            // 
            // numericUpDownNiveldePoder
            // 
            this.numericUpDownNiveldePoder.Location = new System.Drawing.Point(150, 127);
            this.numericUpDownNiveldePoder.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownNiveldePoder.Name = "numericUpDownNiveldePoder";
            this.numericUpDownNiveldePoder.Size = new System.Drawing.Size(346, 22);
            this.numericUpDownNiveldePoder.TabIndex = 6;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(10, 12);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(20, 16);
            this.labelID.TabIndex = 7;
            this.labelID.Text = "ID";
            this.labelID.Click += new System.EventHandler(this.labelID_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(150, 12);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(346, 22);
            this.textBoxID.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(150, 46);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(346, 22);
            this.textBoxNombre.TabIndex = 9;
            // 
            // textBoxRaza
            // 
            this.textBoxRaza.Location = new System.Drawing.Point(150, 85);
            this.textBoxRaza.Name = "textBoxRaza";
            this.textBoxRaza.Size = new System.Drawing.Size(346, 22);
            this.textBoxRaza.TabIndex = 10;
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Location = new System.Drawing.Point(294, 281);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(75, 28);
            this.buttonInsertar.TabIndex = 11;
            this.buttonInsertar.Text = "Crear";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(204, 281);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(84, 28);
            this.buttonBuscar.TabIndex = 12;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // comboBoxRaza
            // 
            this.comboBoxRaza.FormattingEnabled = true;
            this.comboBoxRaza.Location = new System.Drawing.Point(502, 83);
            this.comboBoxRaza.Name = "comboBoxRaza";
            this.comboBoxRaza.Size = new System.Drawing.Size(271, 24);
            this.comboBoxRaza.TabIndex = 13;
            // 
            // labelHistoria
            // 
            this.labelHistoria.AutoSize = true;
            this.labelHistoria.Location = new System.Drawing.Point(10, 175);
            this.labelHistoria.Name = "labelHistoria";
            this.labelHistoria.Size = new System.Drawing.Size(53, 16);
            this.labelHistoria.TabIndex = 14;
            this.labelHistoria.Text = "Historia";
            // 
            // textBoxHistoria
            // 
            this.textBoxHistoria.Location = new System.Drawing.Point(150, 172);
            this.textBoxHistoria.Name = "textBoxHistoria";
            this.textBoxHistoria.Size = new System.Drawing.Size(346, 22);
            this.textBoxHistoria.TabIndex = 15;
            // 
            // dateTimePickerFecha_Creacion
            // 
            this.dateTimePickerFecha_Creacion.Location = new System.Drawing.Point(150, 216);
            this.dateTimePickerFecha_Creacion.Name = "dateTimePickerFecha_Creacion";
            this.dateTimePickerFecha_Creacion.Size = new System.Drawing.Size(253, 22);
            this.dateTimePickerFecha_Creacion.TabIndex = 16;
            // 
            // labelFecha_creacion
            // 
            this.labelFecha_creacion.AutoSize = true;
            this.labelFecha_creacion.Location = new System.Drawing.Point(10, 216);
            this.labelFecha_creacion.Name = "labelFecha_creacion";
            this.labelFecha_creacion.Size = new System.Drawing.Size(119, 16);
            this.labelFecha_creacion.TabIndex = 17;
            this.labelFecha_creacion.Text = "Fecha de creacion";
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(376, 281);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(80, 28);
            this.buttonActualizar.TabIndex = 18;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(462, 281);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(80, 28);
            this.buttonEliminar.TabIndex = 19;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // dateTimePickerBuscarEntreFechas
            // 
            this.dateTimePickerBuscarEntreFechas.Location = new System.Drawing.Point(462, 216);
            this.dateTimePickerBuscarEntreFechas.Name = "dateTimePickerBuscarEntreFechas";
            this.dateTimePickerBuscarEntreFechas.Size = new System.Drawing.Size(271, 22);
            this.dateTimePickerBuscarEntreFechas.TabIndex = 20;
            // 
            // button1BuscarPorFecha
            // 
            this.button1BuscarPorFecha.Location = new System.Drawing.Point(769, 216);
            this.button1BuscarPorFecha.Name = "button1BuscarPorFecha";
            this.button1BuscarPorFecha.Size = new System.Drawing.Size(146, 28);
            this.button1BuscarPorFecha.TabIndex = 21;
            this.button1BuscarPorFecha.Text = "Buscar por fecha";
            this.button1BuscarPorFecha.UseVisualStyleBackColor = true;
            this.button1BuscarPorFecha.Click += new System.EventHandler(this.button1BuscarPorFecha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 530);
            this.Controls.Add(this.button1BuscarPorFecha);
            this.Controls.Add(this.dateTimePickerBuscarEntreFechas);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.labelFecha_creacion);
            this.Controls.Add(this.dateTimePickerFecha_Creacion);
            this.Controls.Add(this.textBoxHistoria);
            this.Controls.Add(this.labelHistoria);
            this.Controls.Add(this.comboBoxRaza);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonInsertar);
            this.Controls.Add(this.textBoxRaza);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.numericUpDownNiveldePoder);
            this.Controls.Add(this.labelNiveldePoder);
            this.Controls.Add(this.labelRaza);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.dataGridViewPersonajes);
            this.Controls.Add(this.buttonPrueba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNiveldePoder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrueba;
        private System.Windows.Forms.DataGridView dataGridViewPersonajes;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelRaza;
        private System.Windows.Forms.Label labelNiveldePoder;
        private System.Windows.Forms.NumericUpDown numericUpDownNiveldePoder;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxRaza;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ComboBox comboBoxRaza;
        private System.Windows.Forms.Label labelHistoria;
        private System.Windows.Forms.TextBox textBoxHistoria;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha_Creacion;
        private System.Windows.Forms.Label labelFecha_creacion;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.DateTimePicker dateTimePickerBuscarEntreFechas;
        private System.Windows.Forms.Button button1BuscarPorFecha;
    }
}

