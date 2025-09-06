namespace PROYECTO_GESTOR_DE_ARCHIVOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btnabrirexistente = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Btnmodificar = new System.Windows.Forms.Button();
            this.Btnagregaralfinal = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btnconfirmar = new System.Windows.Forms.Button();
            this.Btnagregaralprincipio = new System.Windows.Forms.Button();
            this.Btneliminarseleccionado = new System.Windows.Forms.Button();
            this.Btneliminarultimo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btneliminarcolumna = new System.Windows.Forms.Button();
            this.Btnagregarcolumna = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btnagregendeterminadolista = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btnagregaralfinallista = new System.Windows.Forms.Button();
            this.Btnagregariniciolista = new System.Windows.Forms.Button();
            this.Btnaliminarseleccionadolista = new System.Windows.Forms.Button();
            this.Btncreararchivo = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Btnconfirmarcrear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btnabrirexistente
            // 
            this.Btnabrirexistente.Location = new System.Drawing.Point(12, 18);
            this.Btnabrirexistente.Name = "Btnabrirexistente";
            this.Btnabrirexistente.Size = new System.Drawing.Size(95, 42);
            this.Btnabrirexistente.TabIndex = 1;
            this.Btnabrirexistente.Text = "ABRIR ARCHIVO";
            this.Btnabrirexistente.UseVisualStyleBackColor = true;
            this.Btnabrirexistente.Click += new System.EventHandler(this.Btnabrirexistente_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Btnmodificar
            // 
            this.Btnmodificar.Location = new System.Drawing.Point(12, 80);
            this.Btnmodificar.Name = "Btnmodificar";
            this.Btnmodificar.Size = new System.Drawing.Size(95, 42);
            this.Btnmodificar.TabIndex = 2;
            this.Btnmodificar.Text = "EDITAR ARCHIVO";
            this.Btnmodificar.UseVisualStyleBackColor = true;
            this.Btnmodificar.Visible = false;
            this.Btnmodificar.Click += new System.EventHandler(this.Btnmodificar_Click);
            // 
            // Btnagregaralfinal
            // 
            this.Btnagregaralfinal.Location = new System.Drawing.Point(13, 12);
            this.Btnagregaralfinal.Name = "Btnagregaralfinal";
            this.Btnagregaralfinal.Size = new System.Drawing.Size(120, 58);
            this.Btnagregaralfinal.TabIndex = 3;
            this.Btnagregaralfinal.Text = "AGREGAR AL FINAL";
            this.Btnagregaralfinal.UseVisualStyleBackColor = true;
            this.Btnagregaralfinal.Click += new System.EventHandler(this.Btnagregaralfinal_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(316, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // Btnconfirmar
            // 
            this.Btnconfirmar.Location = new System.Drawing.Point(316, 12);
            this.Btnconfirmar.Name = "Btnconfirmar";
            this.Btnconfirmar.Size = new System.Drawing.Size(105, 42);
            this.Btnconfirmar.TabIndex = 5;
            this.Btnconfirmar.Text = "CONFIRMAR";
            this.Btnconfirmar.UseVisualStyleBackColor = true;
            this.Btnconfirmar.Visible = false;
            this.Btnconfirmar.Click += new System.EventHandler(this.Btnconfirmar_Click);
            // 
            // Btnagregaralprincipio
            // 
            this.Btnagregaralprincipio.Location = new System.Drawing.Point(13, 76);
            this.Btnagregaralprincipio.Name = "Btnagregaralprincipio";
            this.Btnagregaralprincipio.Size = new System.Drawing.Size(120, 58);
            this.Btnagregaralprincipio.TabIndex = 6;
            this.Btnagregaralprincipio.Text = "AGREGAR AL PRINCIPIO";
            this.Btnagregaralprincipio.UseVisualStyleBackColor = true;
            this.Btnagregaralprincipio.Click += new System.EventHandler(this.Btnagregaralprincipio_Click);
            // 
            // Btneliminarseleccionado
            // 
            this.Btneliminarseleccionado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btneliminarseleccionado.Location = new System.Drawing.Point(13, 140);
            this.Btneliminarseleccionado.Name = "Btneliminarseleccionado";
            this.Btneliminarseleccionado.Size = new System.Drawing.Size(120, 58);
            this.Btneliminarseleccionado.TabIndex = 7;
            this.Btneliminarseleccionado.Text = "ELIMINAR SELECCIONADO";
            this.Btneliminarseleccionado.UseVisualStyleBackColor = false;
            this.Btneliminarseleccionado.Click += new System.EventHandler(this.Btneliminarseleccionado_Click);
            // 
            // Btneliminarultimo
            // 
            this.Btneliminarultimo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btneliminarultimo.Location = new System.Drawing.Point(12, 204);
            this.Btneliminarultimo.Name = "Btneliminarultimo";
            this.Btneliminarultimo.Size = new System.Drawing.Size(120, 56);
            this.Btneliminarultimo.TabIndex = 8;
            this.Btneliminarultimo.Text = "ELIMINAR ULTIMO";
            this.Btneliminarultimo.UseVisualStyleBackColor = false;
            this.Btneliminarultimo.Click += new System.EventHandler(this.Btneliminarultimo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Btneliminarcolumna);
            this.panel1.Controls.Add(this.Btnagregarcolumna);
            this.panel1.Controls.Add(this.Btneliminarultimo);
            this.panel1.Controls.Add(this.Btneliminarseleccionado);
            this.panel1.Controls.Add(this.Btnagregaralfinal);
            this.panel1.Controls.Add(this.Btnagregaralprincipio);
            this.panel1.Location = new System.Drawing.Point(134, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 412);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // Btneliminarcolumna
            // 
            this.Btneliminarcolumna.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btneliminarcolumna.Location = new System.Drawing.Point(12, 341);
            this.Btneliminarcolumna.Name = "Btneliminarcolumna";
            this.Btneliminarcolumna.Size = new System.Drawing.Size(120, 56);
            this.Btneliminarcolumna.TabIndex = 10;
            this.Btneliminarcolumna.Text = "ELIMINAR COLUMNA";
            this.Btneliminarcolumna.UseVisualStyleBackColor = false;
            this.Btneliminarcolumna.Click += new System.EventHandler(this.Btneliminarcolumna_Click);
            // 
            // Btnagregarcolumna
            // 
            this.Btnagregarcolumna.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btnagregarcolumna.Location = new System.Drawing.Point(12, 266);
            this.Btnagregarcolumna.Name = "Btnagregarcolumna";
            this.Btnagregarcolumna.Size = new System.Drawing.Size(120, 56);
            this.Btnagregarcolumna.TabIndex = 9;
            this.Btnagregarcolumna.Text = "AGREGAR COLUMNA";
            this.Btnagregarcolumna.UseVisualStyleBackColor = false;
            this.Btnagregarcolumna.Click += new System.EventHandler(this.Btnagregarcolumna_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(468, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(837, 581);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // Btnagregendeterminadolista
            // 
            this.Btnagregendeterminadolista.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btnagregendeterminadolista.Location = new System.Drawing.Point(18, 137);
            this.Btnagregendeterminadolista.Name = "Btnagregendeterminadolista";
            this.Btnagregendeterminadolista.Size = new System.Drawing.Size(120, 58);
            this.Btnagregendeterminadolista.TabIndex = 11;
            this.Btnagregendeterminadolista.Text = "AGREGAR EN SELECCION";
            this.Btnagregendeterminadolista.UseVisualStyleBackColor = false;
            this.Btnagregendeterminadolista.Click += new System.EventHandler(this.Btnagregendeterminado_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.Btnagregaralfinallista);
            this.panel2.Controls.Add(this.Btnagregariniciolista);
            this.panel2.Controls.Add(this.Btnaliminarseleccionadolista);
            this.panel2.Controls.Add(this.Btnagregendeterminadolista);
            this.panel2.Location = new System.Drawing.Point(295, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 412);
            this.panel2.TabIndex = 12;
            this.panel2.Visible = false;
            // 
            // Btnagregaralfinallista
            // 
            this.Btnagregaralfinallista.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btnagregaralfinallista.Location = new System.Drawing.Point(18, 73);
            this.Btnagregaralfinallista.Name = "Btnagregaralfinallista";
            this.Btnagregaralfinallista.Size = new System.Drawing.Size(120, 58);
            this.Btnagregaralfinallista.TabIndex = 14;
            this.Btnagregaralfinallista.Text = "AGREGAR AL FINAL";
            this.Btnagregaralfinallista.UseVisualStyleBackColor = false;
            // 
            // Btnagregariniciolista
            // 
            this.Btnagregariniciolista.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btnagregariniciolista.Location = new System.Drawing.Point(18, 10);
            this.Btnagregariniciolista.Name = "Btnagregariniciolista";
            this.Btnagregariniciolista.Size = new System.Drawing.Size(120, 58);
            this.Btnagregariniciolista.TabIndex = 13;
            this.Btnagregariniciolista.Text = "AGREGAR AL INICIO";
            this.Btnagregariniciolista.UseVisualStyleBackColor = false;
            this.Btnagregariniciolista.Click += new System.EventHandler(this.Btnagregariniciolista_Click);
            // 
            // Btnaliminarseleccionadolista
            // 
            this.Btnaliminarseleccionadolista.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btnaliminarseleccionadolista.Location = new System.Drawing.Point(18, 201);
            this.Btnaliminarseleccionadolista.Name = "Btnaliminarseleccionadolista";
            this.Btnaliminarseleccionadolista.Size = new System.Drawing.Size(120, 58);
            this.Btnaliminarseleccionadolista.TabIndex = 12;
            this.Btnaliminarseleccionadolista.Text = "ELIMINAR SELECCIONADO";
            this.Btnaliminarseleccionadolista.UseVisualStyleBackColor = false;
            // 
            // Btncreararchivo
            // 
            this.Btncreararchivo.Location = new System.Drawing.Point(12, 187);
            this.Btncreararchivo.Name = "Btncreararchivo";
            this.Btncreararchivo.Size = new System.Drawing.Size(95, 58);
            this.Btncreararchivo.TabIndex = 13;
            this.Btncreararchivo.Text = "CREAR ARCHIVO NUEVO";
            this.Btncreararchivo.UseVisualStyleBackColor = true;
            this.Btncreararchivo.Click += new System.EventHandler(this.Btncreararchivo_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 254);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(95, 22);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Visible = false;
            // 
            // Btnconfirmarcrear
            // 
            this.Btnconfirmarcrear.Location = new System.Drawing.Point(2, 299);
            this.Btnconfirmarcrear.Name = "Btnconfirmarcrear";
            this.Btnconfirmarcrear.Size = new System.Drawing.Size(105, 42);
            this.Btnconfirmarcrear.TabIndex = 16;
            this.Btnconfirmarcrear.Text = "CONFIRMAR";
            this.Btnconfirmarcrear.UseVisualStyleBackColor = true;
            this.Btnconfirmarcrear.Visible = false;
            this.Btnconfirmarcrear.Click += new System.EventHandler(this.Btnconfirmarcrear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1317, 638);
            this.Controls.Add(this.Btnconfirmarcrear);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Btncreararchivo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btnconfirmar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btnmodificar);
            this.Controls.Add(this.Btnabrirexistente);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btnabrirexistente;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Btnmodificar;
        private System.Windows.Forms.Button Btnagregaralfinal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btnconfirmar;
        private System.Windows.Forms.Button Btnagregaralprincipio;
        private System.Windows.Forms.Button Btneliminarseleccionado;
        private System.Windows.Forms.Button Btneliminarultimo;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btnagregarcolumna;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btneliminarcolumna;
        private System.Windows.Forms.Button Btnagregendeterminadolista;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btnaliminarseleccionadolista;
        private System.Windows.Forms.Button Btnagregaralfinallista;
        private System.Windows.Forms.Button Btnagregariniciolista;
        private System.Windows.Forms.Button Btncreararchivo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Btnconfirmarcrear;
    }
}

