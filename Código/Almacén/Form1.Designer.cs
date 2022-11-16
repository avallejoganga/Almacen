namespace Almacén
{
    partial class Form1
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
            this.VentanaAññadirObjeto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpresaTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VentanaQuitarObjeto = new System.Windows.Forms.Button();
            this.AlmacenCBox = new System.Windows.Forms.ComboBox();
            this.ItemsCBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LabNombreItem = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabTiempo = new System.Windows.Forms.Label();
            this.LabVariable2 = new System.Windows.Forms.Label();
            this.LabVariable1 = new System.Windows.Forms.Label();
            this.LabPrecio = new System.Windows.Forms.Label();
            this.LabPeso = new System.Windows.Forms.Label();
            this.LabPag = new System.Windows.Forms.Label();
            this.LabTipo = new System.Windows.Forms.Label();
            this.LabNombre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabMarca = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabCad = new System.Windows.Forms.Label();
            this.LabPrecioKilo = new System.Windows.Forms.Label();
            this.LabCaballo = new System.Windows.Forms.Label();
            this.LabMaterial = new System.Windows.Forms.Label();
            this.LabVolumen = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Save = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VentanaAññadirObjeto
            // 
            this.VentanaAññadirObjeto.Location = new System.Drawing.Point(12, 251);
            this.VentanaAññadirObjeto.Name = "VentanaAññadirObjeto";
            this.VentanaAññadirObjeto.Size = new System.Drawing.Size(101, 23);
            this.VentanaAññadirObjeto.TabIndex = 0;
            this.VentanaAññadirObjeto.Text = "Añadir Objeto";
            this.VentanaAññadirObjeto.UseVisualStyleBackColor = true;
            this.VentanaAññadirObjeto.Click += new System.EventHandler(this.VentanaAññadirObjeto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de la Empresa";
            // 
            // EmpresaTBox
            // 
            this.EmpresaTBox.Location = new System.Drawing.Point(12, 41);
            this.EmpresaTBox.Name = "EmpresaTBox";
            this.EmpresaTBox.Size = new System.Drawing.Size(131, 20);
            this.EmpresaTBox.TabIndex = 2;
            this.EmpresaTBox.TextChanged += new System.EventHandler(this.EmpresaTBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(162, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Almacenes";
            // 
            // VentanaQuitarObjeto
            // 
            this.VentanaQuitarObjeto.Location = new System.Drawing.Point(116, 251);
            this.VentanaQuitarObjeto.Name = "VentanaQuitarObjeto";
            this.VentanaQuitarObjeto.Size = new System.Drawing.Size(101, 23);
            this.VentanaQuitarObjeto.TabIndex = 4;
            this.VentanaQuitarObjeto.Text = "Quitar Objeto";
            this.VentanaQuitarObjeto.UseVisualStyleBackColor = true;
            this.VentanaQuitarObjeto.Click += new System.EventHandler(this.BotonQuitarObjeto_Click);
            // 
            // AlmacenCBox
            // 
            this.AlmacenCBox.FormattingEnabled = true;
            this.AlmacenCBox.Location = new System.Drawing.Point(161, 41);
            this.AlmacenCBox.Name = "AlmacenCBox";
            this.AlmacenCBox.Size = new System.Drawing.Size(121, 21);
            this.AlmacenCBox.TabIndex = 7;
            this.AlmacenCBox.Text = "Seleccione Almacén";
            this.AlmacenCBox.SelectedIndexChanged += new System.EventHandler(this.AlmacenCBox_SelectedIndexChanged);
            // 
            // ItemsCBox
            // 
            this.ItemsCBox.FormattingEnabled = true;
            this.ItemsCBox.Location = new System.Drawing.Point(313, 41);
            this.ItemsCBox.Name = "ItemsCBox";
            this.ItemsCBox.Size = new System.Drawing.Size(121, 21);
            this.ItemsCBox.TabIndex = 8;
            this.ItemsCBox.Text = "Seleccione Objeto";
            this.ItemsCBox.SelectedIndexChanged += new System.EventHandler(this.ItemsCBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(313, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Objetos";
            // 
            // LabNombreItem
            // 
            this.LabNombreItem.AutoSize = true;
            this.LabNombreItem.BackColor = System.Drawing.SystemColors.Control;
            this.LabNombreItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabNombreItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabNombreItem.Location = new System.Drawing.Point(7, 32);
            this.LabNombreItem.Name = "LabNombreItem";
            this.LabNombreItem.Size = new System.Drawing.Size(50, 13);
            this.LabNombreItem.TabIndex = 10;
            this.LabNombreItem.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.LabTiempo);
            this.groupBox1.Controls.Add(this.LabVariable2);
            this.groupBox1.Controls.Add(this.LabVariable1);
            this.groupBox1.Controls.Add(this.LabPrecio);
            this.groupBox1.Controls.Add(this.LabPeso);
            this.groupBox1.Controls.Add(this.LabPag);
            this.groupBox1.Controls.Add(this.LabTipo);
            this.groupBox1.Controls.Add(this.LabNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LabMarca);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LabNombreItem);
            this.groupBox1.Controls.Add(this.LabCad);
            this.groupBox1.Controls.Add(this.LabPrecioKilo);
            this.groupBox1.Controls.Add(this.LabCaballo);
            this.groupBox1.Controls.Add(this.LabMaterial);
            this.groupBox1.Controls.Add(this.LabVolumen);
            this.groupBox1.Location = new System.Drawing.Point(16, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 148);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // LabTiempo
            // 
            this.LabTiempo.AutoSize = true;
            this.LabTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTiempo.Location = new System.Drawing.Point(294, 91);
            this.LabTiempo.Name = "LabTiempo";
            this.LabTiempo.Size = new System.Drawing.Size(113, 13);
            this.LabTiempo.TabIndex = 21;
            this.LabTiempo.Text = "Tiempo de Lectura";
            this.LabTiempo.Visible = false;
            // 
            // LabVariable2
            // 
            this.LabVariable2.AutoSize = true;
            this.LabVariable2.Location = new System.Drawing.Point(297, 108);
            this.LabVariable2.Name = "LabVariable2";
            this.LabVariable2.Size = new System.Drawing.Size(10, 13);
            this.LabVariable2.TabIndex = 19;
            this.LabVariable2.Text = " ";
            // 
            // LabVariable1
            // 
            this.LabVariable1.AutoSize = true;
            this.LabVariable1.Location = new System.Drawing.Point(149, 108);
            this.LabVariable1.Name = "LabVariable1";
            this.LabVariable1.Size = new System.Drawing.Size(10, 13);
            this.LabVariable1.TabIndex = 18;
            this.LabVariable1.Text = " ";
            // 
            // LabPrecio
            // 
            this.LabPrecio.AutoSize = true;
            this.LabPrecio.Location = new System.Drawing.Point(10, 108);
            this.LabPrecio.Name = "LabPrecio";
            this.LabPrecio.Size = new System.Drawing.Size(10, 13);
            this.LabPrecio.TabIndex = 17;
            this.LabPrecio.Text = " ";
            // 
            // LabPeso
            // 
            this.LabPeso.AutoSize = true;
            this.LabPeso.Location = new System.Drawing.Point(297, 49);
            this.LabPeso.Name = "LabPeso";
            this.LabPeso.Size = new System.Drawing.Size(10, 13);
            this.LabPeso.TabIndex = 16;
            this.LabPeso.Text = " ";
            // 
            // LabPag
            // 
            this.LabPag.AutoSize = true;
            this.LabPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPag.Location = new System.Drawing.Point(142, 91);
            this.LabPag.Name = "LabPag";
            this.LabPag.Size = new System.Drawing.Size(117, 13);
            this.LabPag.TabIndex = 20;
            this.LabPag.Text = "Número de Páginas";
            this.LabPag.Visible = false;
            // 
            // LabTipo
            // 
            this.LabTipo.AutoSize = true;
            this.LabTipo.Location = new System.Drawing.Point(149, 49);
            this.LabTipo.Name = "LabTipo";
            this.LabTipo.Size = new System.Drawing.Size(10, 13);
            this.LabTipo.TabIndex = 15;
            this.LabTipo.Text = " ";
            // 
            // LabNombre
            // 
            this.LabNombre.AutoSize = true;
            this.LabNombre.Location = new System.Drawing.Point(10, 49);
            this.LabNombre.Name = "LabNombre";
            this.LabNombre.Size = new System.Drawing.Size(10, 13);
            this.LabNombre.TabIndex = 14;
            this.LabNombre.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(294, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Peso";
            // 
            // LabMarca
            // 
            this.LabMarca.AutoSize = true;
            this.LabMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMarca.Location = new System.Drawing.Point(294, 91);
            this.LabMarca.Name = "LabMarca";
            this.LabMarca.Size = new System.Drawing.Size(42, 13);
            this.LabMarca.TabIndex = 19;
            this.LabMarca.Text = "Marca";
            this.LabMarca.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo";
            // 
            // LabCad
            // 
            this.LabCad.AutoSize = true;
            this.LabCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCad.Location = new System.Drawing.Point(146, 91);
            this.LabCad.Name = "LabCad";
            this.LabCad.Size = new System.Drawing.Size(124, 13);
            this.LabCad.TabIndex = 14;
            this.LabCad.Text = "Fecha de Caducidad";
            this.LabCad.Visible = false;
            // 
            // LabPrecioKilo
            // 
            this.LabPrecioKilo.AutoSize = true;
            this.LabPrecioKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPrecioKilo.Location = new System.Drawing.Point(296, 91);
            this.LabPrecioKilo.Name = "LabPrecioKilo";
            this.LabPrecioKilo.Size = new System.Drawing.Size(90, 13);
            this.LabPrecioKilo.TabIndex = 15;
            this.LabPrecioKilo.Text = "Precio por Kilo";
            this.LabPrecioKilo.Visible = false;
            // 
            // LabCaballo
            // 
            this.LabCaballo.AutoSize = true;
            this.LabCaballo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCaballo.Location = new System.Drawing.Point(146, 91);
            this.LabCaballo.Name = "LabCaballo";
            this.LabCaballo.Size = new System.Drawing.Size(55, 13);
            this.LabCaballo.TabIndex = 18;
            this.LabCaballo.Text = "Caballos";
            this.LabCaballo.Visible = false;
            // 
            // LabMaterial
            // 
            this.LabMaterial.AutoSize = true;
            this.LabMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMaterial.Location = new System.Drawing.Point(149, 91);
            this.LabMaterial.Name = "LabMaterial";
            this.LabMaterial.Size = new System.Drawing.Size(52, 13);
            this.LabMaterial.TabIndex = 16;
            this.LabMaterial.Text = "Material";
            this.LabMaterial.Visible = false;
            // 
            // LabVolumen
            // 
            this.LabVolumen.AutoSize = true;
            this.LabVolumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabVolumen.Location = new System.Drawing.Point(294, 91);
            this.LabVolumen.Name = "LabVolumen";
            this.LabVolumen.Size = new System.Drawing.Size(55, 13);
            this.LabVolumen.TabIndex = 17;
            this.LabVolumen.Text = "Volumen";
            this.LabVolumen.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(333, 251);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(101, 23);
            this.Save.TabIndex = 13;
            this.Save.Text = "Guardar Archivo";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(226, 251);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(101, 23);
            this.Open.TabIndex = 14;
            this.Open.Text = "Abrir Archivo";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 295);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ItemsCBox);
            this.Controls.Add(this.AlmacenCBox);
            this.Controls.Add(this.VentanaQuitarObjeto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmpresaTBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VentanaAññadirObjeto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VentanaAññadirObjeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmpresaTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button VentanaQuitarObjeto;
        private System.Windows.Forms.ComboBox AlmacenCBox;
        private System.Windows.Forms.ComboBox ItemsCBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabNombreItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabTiempo;
        private System.Windows.Forms.Label LabVariable2;
        private System.Windows.Forms.Label LabVariable1;
        private System.Windows.Forms.Label LabPrecio;
        private System.Windows.Forms.Label LabPeso;
        private System.Windows.Forms.Label LabPag;
        private System.Windows.Forms.Label LabTipo;
        private System.Windows.Forms.Label LabNombre;
        private System.Windows.Forms.Label LabMarca;
        private System.Windows.Forms.Label LabCad;
        private System.Windows.Forms.Label LabPrecioKilo;
        private System.Windows.Forms.Label LabCaballo;
        private System.Windows.Forms.Label LabMaterial;
        private System.Windows.Forms.Label LabVolumen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

