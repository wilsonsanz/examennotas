
namespace examennotas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnmos = new System.Windows.Forms.Button();
            this.btnota = new System.Windows.Forms.Button();
            this.elimi = new System.Windows.Forms.Button();
            this.btnbaja = new System.Windows.Forms.Button();
            this.btnapro = new System.Windows.Forms.Button();
            this.listalum = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnmh = new System.Windows.Forms.Button();
            this.modifi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calificacion";
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(180, 64);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(134, 20);
            this.dni.TabIndex = 4;
            this.dni.TextChanged += new System.EventHandler(this.dni_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(181, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(180, 196);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(133, 20);
            this.textBox4.TabIndex = 7;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(58, 257);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(123, 40);
            this.btnagregar.TabIndex = 8;
            this.btnagregar.Text = "Agregar Estudiante";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnmos
            // 
            this.btnmos.Location = new System.Drawing.Point(227, 257);
            this.btnmos.Name = "btnmos";
            this.btnmos.Size = new System.Drawing.Size(123, 40);
            this.btnmos.TabIndex = 9;
            this.btnmos.Text = "Mostrar Alumnos";
            this.btnmos.UseVisualStyleBackColor = true;
            this.btnmos.Click += new System.EventHandler(this.btnmos_Click);
            // 
            // btnota
            // 
            this.btnota.Location = new System.Drawing.Point(382, 261);
            this.btnota.Name = "btnota";
            this.btnota.Size = new System.Drawing.Size(123, 40);
            this.btnota.TabIndex = 10;
            this.btnota.Text = "Consultar Nota";
            this.btnota.UseVisualStyleBackColor = true;
            this.btnota.Click += new System.EventHandler(this.btnota_Click);
            // 
            // elimi
            // 
            this.elimi.Location = new System.Drawing.Point(571, 257);
            this.elimi.Name = "elimi";
            this.elimi.Size = new System.Drawing.Size(123, 40);
            this.elimi.TabIndex = 11;
            this.elimi.Text = "Eliminar Alumno";
            this.elimi.UseVisualStyleBackColor = true;
            this.elimi.Click += new System.EventHandler(this.elimi_Click);
            // 
            // btnbaja
            // 
            this.btnbaja.Location = new System.Drawing.Point(571, 188);
            this.btnbaja.Name = "btnbaja";
            this.btnbaja.Size = new System.Drawing.Size(123, 40);
            this.btnbaja.TabIndex = 12;
            this.btnbaja.Text = "Alumnos Baja nota";
            this.btnbaja.UseVisualStyleBackColor = true;
            this.btnbaja.Click += new System.EventHandler(this.btnbaja_Click);
            // 
            // btnapro
            // 
            this.btnapro.Location = new System.Drawing.Point(382, 188);
            this.btnapro.Name = "btnapro";
            this.btnapro.Size = new System.Drawing.Size(123, 40);
            this.btnapro.TabIndex = 13;
            this.btnapro.Text = "Alumnos Aprobados";
            this.btnapro.UseVisualStyleBackColor = true;
            this.btnapro.Click += new System.EventHandler(this.button2_Click);
            // 
            // listalum
            // 
            this.listalum.FormattingEnabled = true;
            this.listalum.Location = new System.Drawing.Point(44, 318);
            this.listalum.Name = "listalum";
            this.listalum.Size = new System.Drawing.Size(672, 108);
            this.listalum.TabIndex = 14;
            this.listalum.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(324, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Notas de Alumnos";
            // 
            // btnmh
            // 
            this.btnmh.Image = global::examennotas.Properties.Resources.Milky_Way_galaxy_stars_1080x1920_iPhone_6_Plus_wallpaper;
            this.btnmh.Location = new System.Drawing.Point(571, 117);
            this.btnmh.Name = "btnmh";
            this.btnmh.Size = new System.Drawing.Size(123, 40);
            this.btnmh.TabIndex = 16;
            this.btnmh.Text = "Alumnos MH";
            this.btnmh.UseVisualStyleBackColor = true;
            this.btnmh.Click += new System.EventHandler(this.button3_Click);
            // 
            // modifi
            // 
            this.modifi.ForeColor = System.Drawing.Color.White;
            this.modifi.Image = global::examennotas.Properties.Resources.paint;
            this.modifi.Location = new System.Drawing.Point(382, 117);
            this.modifi.Name = "modifi";
            this.modifi.Size = new System.Drawing.Size(123, 40);
            this.modifi.TabIndex = 15;
            this.modifi.Text = "Modificar Nota";
            this.modifi.UseVisualStyleBackColor = true;
            this.modifi.Click += new System.EventHandler(this.modifi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::examennotas.Properties.Resources.Milky_Way_galaxy_stars_1080x1920_iPhone_6_Plus_wallpaper;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnmh);
            this.Controls.Add(this.modifi);
            this.Controls.Add(this.listalum);
            this.Controls.Add(this.btnapro);
            this.Controls.Add(this.btnbaja);
            this.Controls.Add(this.elimi);
            this.Controls.Add(this.btnota);
            this.Controls.Add(this.btnmos);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DNI:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnmos;
        private System.Windows.Forms.Button btnota;
        private System.Windows.Forms.Button elimi;
        private System.Windows.Forms.Button btnbaja;
        private System.Windows.Forms.Button btnapro;
        private System.Windows.Forms.ListBox listalum;
        private System.Windows.Forms.Button modifi;
        private System.Windows.Forms.Button btnmh;
        private System.Windows.Forms.Label label5;
    }
}

