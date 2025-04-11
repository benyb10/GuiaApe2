namespace proyectoAPE2
{
    partial class Matriz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Matriz));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerarMatriz = new System.Windows.Forms.Button();
            this.txtFilas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiarTodo = new System.Windows.Forms.Button();
            this.btnDatos = new System.Windows.Forms.Button();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgwMatriz = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgwMatrizInversa = new System.Windows.Forms.DataGridView();
            this.btnMatrizInversa = new System.Windows.Forms.Button();
            this.btnHelp2 = new System.Windows.Forms.Button();
            this.btnSumaDiagonales = new System.Windows.Forms.Button();
            this.lblResultadoDiagonal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatrizInversa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa la Dimensión de tu Matriz";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnGenerarMatriz);
            this.groupBox1.Controls.Add(this.txtFilas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(26, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NUEVA MATRIZ";
            // 
            // btnGenerarMatriz
            // 
            this.btnGenerarMatriz.BackColor = System.Drawing.Color.Maroon;
            this.btnGenerarMatriz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerarMatriz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarMatriz.ForeColor = System.Drawing.Color.White;
            this.btnGenerarMatriz.Location = new System.Drawing.Point(75, 177);
            this.btnGenerarMatriz.Name = "btnGenerarMatriz";
            this.btnGenerarMatriz.Size = new System.Drawing.Size(209, 38);
            this.btnGenerarMatriz.TabIndex = 5;
            this.btnGenerarMatriz.Text = "Generar Matriz";
            this.btnGenerarMatriz.UseVisualStyleBackColor = false;
            this.btnGenerarMatriz.Click += new System.EventHandler(this.btnGenerarMatriz_Click);
            // 
            // txtFilas
            // 
            this.txtFilas.Location = new System.Drawing.Point(143, 125);
            this.txtFilas.Name = "txtFilas";
            this.txtFilas.Size = new System.Drawing.Size(70, 32);
            this.txtFilas.TabIndex = 3;
            this.txtFilas.TextChanged += new System.EventHandler(this.txtFilas_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tamaño de la matriz cuadrada:";
            // 
            // btnLimpiarTodo
            // 
            this.btnLimpiarTodo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarTodo.Location = new System.Drawing.Point(532, 21);
            this.btnLimpiarTodo.Name = "btnLimpiarTodo";
            this.btnLimpiarTodo.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarTodo.TabIndex = 2;
            this.btnLimpiarTodo.Text = "Limpiar";
            this.btnLimpiarTodo.UseVisualStyleBackColor = true;
            this.btnLimpiarTodo.Click += new System.EventHandler(this.btnLimpiarTodo_Click);
            // 
            // btnDatos
            // 
            this.btnDatos.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatos.Location = new System.Drawing.Point(601, 21);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(75, 23);
            this.btnDatos.TabIndex = 3;
            this.btnDatos.Text = "Datos";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // btnMatriz
            // 
            this.btnMatriz.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatriz.Location = new System.Drawing.Point(669, 21);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(75, 23);
            this.btnMatriz.TabIndex = 4;
            this.btnMatriz.Text = "Matriz";
            this.btnMatriz.UseVisualStyleBackColor = true;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(469, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dgwMatriz
            // 
            this.dgwMatriz.AllowUserToAddRows = false;
            this.dgwMatriz.AllowUserToDeleteRows = false;
            this.dgwMatriz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgwMatriz.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgwMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMatriz.ColumnHeadersVisible = false;
            this.dgwMatriz.Location = new System.Drawing.Point(469, 83);
            this.dgwMatriz.Name = "dgwMatriz";
            this.dgwMatriz.RowHeadersVisible = false;
            this.dgwMatriz.Size = new System.Drawing.Size(350, 188);
            this.dgwMatriz.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(371, 549);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(56, 42);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "<";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(458, 549);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(56, 42);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(433, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 520);
            this.label4.TabIndex = 9;
            this.label4.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n" +
    "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // dgwMatrizInversa
            // 
            this.dgwMatrizInversa.AllowUserToAddRows = false;
            this.dgwMatrizInversa.AllowUserToDeleteRows = false;
            this.dgwMatrizInversa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgwMatrizInversa.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgwMatrizInversa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMatrizInversa.ColumnHeadersVisible = false;
            this.dgwMatrizInversa.Location = new System.Drawing.Point(469, 346);
            this.dgwMatrizInversa.Name = "dgwMatrizInversa";
            this.dgwMatrizInversa.ReadOnly = true;
            this.dgwMatrizInversa.RowHeadersVisible = false;
            this.dgwMatrizInversa.Size = new System.Drawing.Size(350, 184);
            this.dgwMatrizInversa.TabIndex = 0;
            // 
            // btnMatrizInversa
            // 
            this.btnMatrizInversa.BackColor = System.Drawing.Color.Maroon;
            this.btnMatrizInversa.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatrizInversa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMatrizInversa.Location = new System.Drawing.Point(516, 296);
            this.btnMatrizInversa.Name = "btnMatrizInversa";
            this.btnMatrizInversa.Size = new System.Drawing.Size(135, 24);
            this.btnMatrizInversa.TabIndex = 11;
            this.btnMatrizInversa.Text = "MATRIZ INVERSA";
            this.btnMatrizInversa.UseVisualStyleBackColor = false;
            this.btnMatrizInversa.Click += new System.EventHandler(this.btnMatrizInversa_Click);
            // 
            // btnHelp2
            // 
            this.btnHelp2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnHelp2.FlatAppearance.BorderSize = 0;
            this.btnHelp2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnHelp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp2.Location = new System.Drawing.Point(784, 19);
            this.btnHelp2.Name = "btnHelp2";
            this.btnHelp2.Size = new System.Drawing.Size(35, 35);
            this.btnHelp2.TabIndex = 12;
            this.btnHelp2.Text = "?";
            this.btnHelp2.UseVisualStyleBackColor = false;
            this.btnHelp2.Click += new System.EventHandler(this.btnAyuda2_Click);
            // 
            // btnSumaDiagonales
            // 
            this.btnSumaDiagonales.BackColor = System.Drawing.Color.Maroon;
            this.btnSumaDiagonales.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumaDiagonales.ForeColor = System.Drawing.Color.White;
            this.btnSumaDiagonales.Location = new System.Drawing.Point(657, 297);
            this.btnSumaDiagonales.Name = "btnSumaDiagonales";
            this.btnSumaDiagonales.Size = new System.Drawing.Size(134, 23);
            this.btnSumaDiagonales.TabIndex = 15;
            this.btnSumaDiagonales.Text = "Suma Diagonales";
            this.btnSumaDiagonales.UseVisualStyleBackColor = false;
            this.btnSumaDiagonales.Click += new System.EventHandler(this.btnSumaDiagonales_Click);
            // 
            // lblResultadoDiagonal
            // 
            this.lblResultadoDiagonal.AutoSize = true;
            this.lblResultadoDiagonal.Location = new System.Drawing.Point(26, 357);
            this.lblResultadoDiagonal.Name = "lblResultadoDiagonal";
            this.lblResultadoDiagonal.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoDiagonal.TabIndex = 16;
            // 
            // Matriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyectoAPE2.Properties.Resources.Imagen_de_WhatsApp_2025_04_06_a_las_18_54_37_45156aa7;
            this.ClientSize = new System.Drawing.Size(850, 603);
            this.Controls.Add(this.lblResultadoDiagonal);
            this.Controls.Add(this.btnSumaDiagonales);
            this.Controls.Add(this.btnHelp2);
            this.Controls.Add(this.btnMatrizInversa);
            this.Controls.Add(this.dgwMatrizInversa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dgwMatriz);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.btnLimpiarTodo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Matriz";
            this.Text = "Matriz";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatrizInversa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerarMatriz;
        private System.Windows.Forms.TextBox txtFilas;
        private System.Windows.Forms.Button btnLimpiarTodo;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgwMatriz;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgwMatrizInversa;
        private System.Windows.Forms.Button btnMatrizInversa;
        private System.Windows.Forms.Button btnHelp2;
        private System.Windows.Forms.Button btnSumaDiagonales;
        private System.Windows.Forms.Label lblResultadoDiagonal;
    }
}