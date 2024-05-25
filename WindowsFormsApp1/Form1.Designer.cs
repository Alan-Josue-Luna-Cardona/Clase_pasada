namespace WindowsFormsApp1
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
            this.prueba = new System.Windows.Forms.Button();
            this.dataGridViewPersonajes = new System.Windows.Forms.DataGridView();
            this.cargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.crear = new System.Windows.Forms.Button();
            this.nivelpoder = new System.Windows.Forms.NumericUpDown();
            this.comboBox1raza = new System.Windows.Forms.ComboBox();
            this.buttonbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivelpoder)).BeginInit();
            this.SuspendLayout();
            // 
            // prueba
            // 
            this.prueba.Location = new System.Drawing.Point(860, 423);
            this.prueba.Name = "prueba";
            this.prueba.Size = new System.Drawing.Size(133, 80);
            this.prueba.TabIndex = 0;
            this.prueba.Text = "Prueba de Conexion";
            this.prueba.UseVisualStyleBackColor = true;
            this.prueba.Click += new System.EventHandler(this.prueba_Click);
            // 
            // dataGridViewPersonajes
            // 
            this.dataGridViewPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonajes.Location = new System.Drawing.Point(26, 325);
            this.dataGridViewPersonajes.Name = "dataGridViewPersonajes";
            this.dataGridViewPersonajes.RowHeadersWidth = 51;
            this.dataGridViewPersonajes.RowTemplate.Height = 24;
            this.dataGridViewPersonajes.Size = new System.Drawing.Size(696, 203);
            this.dataGridViewPersonajes.TabIndex = 1;
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(745, 358);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(132, 39);
            this.cargar.TabIndex = 2;
            this.cargar.Text = "cargar datos";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "raza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "power";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(158, 20);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 22);
            this.id.TabIndex = 7;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            this.id.Leave += new System.EventHandler(this.id_Leave);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(158, 70);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 22);
            this.nombre.TabIndex = 8;
            // 
            // crear
            // 
            this.crear.Location = new System.Drawing.Point(62, 244);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(118, 58);
            this.crear.TabIndex = 11;
            this.crear.Text = "crear";
            this.crear.UseVisualStyleBackColor = true;
            this.crear.Click += new System.EventHandler(this.crear_Click);
            // 
            // nivelpoder
            // 
            this.nivelpoder.Location = new System.Drawing.Point(158, 179);
            this.nivelpoder.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nivelpoder.Name = "nivelpoder";
            this.nivelpoder.Size = new System.Drawing.Size(100, 22);
            this.nivelpoder.TabIndex = 12;
            // 
            // comboBox1raza
            // 
            this.comboBox1raza.FormattingEnabled = true;
            this.comboBox1raza.Location = new System.Drawing.Point(158, 128);
            this.comboBox1raza.Name = "comboBox1raza";
            this.comboBox1raza.Size = new System.Drawing.Size(100, 24);
            this.comboBox1raza.TabIndex = 13;
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Location = new System.Drawing.Point(398, 63);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(100, 65);
            this.buttonbuscar.TabIndex = 14;
            this.buttonbuscar.Text = "buscar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 560);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.comboBox1raza);
            this.Controls.Add(this.nivelpoder);
            this.Controls.Add(this.crear);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cargar);
            this.Controls.Add(this.dataGridViewPersonajes);
            this.Controls.Add(this.prueba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivelpoder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prueba;
        private System.Windows.Forms.DataGridView dataGridViewPersonajes;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button crear;
        private System.Windows.Forms.NumericUpDown nivelpoder;
        private System.Windows.Forms.ComboBox comboBox1raza;
        private System.Windows.Forms.Button buttonbuscar;
    }
}

