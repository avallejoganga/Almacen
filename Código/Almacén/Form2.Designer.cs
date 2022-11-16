namespace Almacén
{
    partial class Form2
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
            this.AddItem = new System.Windows.Forms.Button();
            this.AñadirItem = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NombreObj = new System.Windows.Forms.TextBox();
            this.PrecioObj = new System.Windows.Forms.TextBox();
            this.PesoObj = new System.Windows.Forms.TextBox();
            this.MaterialMueble = new System.Windows.Forms.TextBox();
            this.VolumenMueble = new System.Windows.Forms.TextBox();
            this.CaballosCoche = new System.Windows.Forms.TextBox();
            this.MarcaCoche = new System.Windows.Forms.TextBox();
            this.CaducidadComida = new System.Windows.Forms.DateTimePicker();
            this.PaginasLibro = new System.Windows.Forms.TextBox();
            this.TiempoLibro = new System.Windows.Forms.TextBox();
            this.PrecioXKiloComida = new System.Windows.Forms.TextBox();
            this.EuroKilo = new System.Windows.Forms.Label();
            this.Horas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddItem
            // 
            this.AddItem.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddItem.Location = new System.Drawing.Point(302, 107);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(100, 23);
            this.AddItem.TabIndex = 0;
            this.AddItem.Text = "Salir";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.Salir_Click);
            // 
            // AñadirItem
            // 
            this.AñadirItem.Location = new System.Drawing.Point(169, 107);
            this.AñadirItem.Name = "AñadirItem";
            this.AñadirItem.Size = new System.Drawing.Size(100, 23);
            this.AñadirItem.TabIndex = 1;
            this.AñadirItem.Text = "Añadir";
            this.AñadirItem.UseVisualStyleBackColor = true;
            this.AñadirItem.Click += new System.EventHandler(this.AñadirItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Comida",
            "Mueble",
            "Coche",
            "Libro"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Tipo de Objeto";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NombreObj
            // 
            this.NombreObj.Location = new System.Drawing.Point(169, 13);
            this.NombreObj.Name = "NombreObj";
            this.NombreObj.Size = new System.Drawing.Size(100, 20);
            this.NombreObj.TabIndex = 3;
            this.NombreObj.Text = "Nombre";
            // 
            // PrecioObj
            // 
            this.PrecioObj.Location = new System.Drawing.Point(169, 39);
            this.PrecioObj.Name = "PrecioObj";
            this.PrecioObj.Size = new System.Drawing.Size(100, 20);
            this.PrecioObj.TabIndex = 4;
            this.PrecioObj.Text = "Precio";
            this.PrecioObj.TextChanged += new System.EventHandler(this.PrecioObj_TextChanged);
            // 
            // PesoObj
            // 
            this.PesoObj.Location = new System.Drawing.Point(169, 65);
            this.PesoObj.Name = "PesoObj";
            this.PesoObj.Size = new System.Drawing.Size(100, 20);
            this.PesoObj.TabIndex = 5;
            this.PesoObj.Text = "Peso";
            this.PesoObj.TextChanged += new System.EventHandler(this.PesoObj_TextChanged);
            // 
            // MaterialMueble
            // 
            this.MaterialMueble.Location = new System.Drawing.Point(302, 12);
            this.MaterialMueble.Name = "MaterialMueble";
            this.MaterialMueble.Size = new System.Drawing.Size(100, 20);
            this.MaterialMueble.TabIndex = 6;
            this.MaterialMueble.Text = "Material";
            this.MaterialMueble.Visible = false;
            // 
            // VolumenMueble
            // 
            this.VolumenMueble.Location = new System.Drawing.Point(302, 38);
            this.VolumenMueble.Name = "VolumenMueble";
            this.VolumenMueble.Size = new System.Drawing.Size(100, 20);
            this.VolumenMueble.TabIndex = 7;
            this.VolumenMueble.Text = "Volumen";
            this.VolumenMueble.Visible = false;
            // 
            // CaballosCoche
            // 
            this.CaballosCoche.Location = new System.Drawing.Point(302, 12);
            this.CaballosCoche.Name = "CaballosCoche";
            this.CaballosCoche.Size = new System.Drawing.Size(100, 20);
            this.CaballosCoche.TabIndex = 8;
            this.CaballosCoche.Text = "Caballos";
            this.CaballosCoche.Visible = false;
            // 
            // MarcaCoche
            // 
            this.MarcaCoche.Location = new System.Drawing.Point(302, 38);
            this.MarcaCoche.Name = "MarcaCoche";
            this.MarcaCoche.Size = new System.Drawing.Size(100, 20);
            this.MarcaCoche.TabIndex = 9;
            this.MarcaCoche.Text = "Marca ";
            this.MarcaCoche.Visible = false;
            // 
            // CaducidadComida
            // 
            this.CaducidadComida.Enabled = false;
            this.CaducidadComida.Location = new System.Drawing.Point(302, 64);
            this.CaducidadComida.Name = "CaducidadComida";
            this.CaducidadComida.Size = new System.Drawing.Size(100, 20);
            this.CaducidadComida.TabIndex = 10;
            // 
            // PaginasLibro
            // 
            this.PaginasLibro.Location = new System.Drawing.Point(302, 12);
            this.PaginasLibro.Name = "PaginasLibro";
            this.PaginasLibro.Size = new System.Drawing.Size(100, 20);
            this.PaginasLibro.TabIndex = 11;
            this.PaginasLibro.Text = "Número de Páginas";
            this.PaginasLibro.Visible = false;
            // 
            // TiempoLibro
            // 
            this.TiempoLibro.Location = new System.Drawing.Point(302, 38);
            this.TiempoLibro.Name = "TiempoLibro";
            this.TiempoLibro.Size = new System.Drawing.Size(100, 20);
            this.TiempoLibro.TabIndex = 12;
            this.TiempoLibro.Text = "Tiempo de Lectura";
            this.TiempoLibro.Visible = false;
            // 
            // PrecioXKiloComida
            // 
            this.PrecioXKiloComida.Enabled = false;
            this.PrecioXKiloComida.Location = new System.Drawing.Point(302, 12);
            this.PrecioXKiloComida.Name = "PrecioXKiloComida";
            this.PrecioXKiloComida.Size = new System.Drawing.Size(100, 20);
            this.PrecioXKiloComida.TabIndex = 13;
            this.PrecioXKiloComida.Text = "PrecioPorKilo";
            this.PrecioXKiloComida.Visible = false;
            // 
            // EuroKilo
            // 
            this.EuroKilo.AutoSize = true;
            this.EuroKilo.Location = new System.Drawing.Point(408, 15);
            this.EuroKilo.Name = "EuroKilo";
            this.EuroKilo.Size = new System.Drawing.Size(35, 13);
            this.EuroKilo.TabIndex = 14;
            this.EuroKilo.Text = "€/Kilo";
            this.EuroKilo.Visible = false;
            // 
            // Horas
            // 
            this.Horas.AutoSize = true;
            this.Horas.Location = new System.Drawing.Point(408, 41);
            this.Horas.Name = "Horas";
            this.Horas.Size = new System.Drawing.Size(35, 13);
            this.Horas.TabIndex = 15;
            this.Horas.Text = "Horas";
            this.Horas.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 136);
            this.Controls.Add(this.Horas);
            this.Controls.Add(this.EuroKilo);
            this.Controls.Add(this.PrecioXKiloComida);
            this.Controls.Add(this.TiempoLibro);
            this.Controls.Add(this.PaginasLibro);
            this.Controls.Add(this.CaducidadComida);
            this.Controls.Add(this.MarcaCoche);
            this.Controls.Add(this.CaballosCoche);
            this.Controls.Add(this.VolumenMueble);
            this.Controls.Add(this.MaterialMueble);
            this.Controls.Add(this.PesoObj);
            this.Controls.Add(this.PrecioObj);
            this.Controls.Add(this.NombreObj);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AñadirItem);
            this.Controls.Add(this.AddItem);
            this.Name = "Form2";
            this.Text = "Add Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Button AñadirItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox NombreObj;
        private System.Windows.Forms.TextBox PrecioObj;
        private System.Windows.Forms.TextBox PesoObj;
        private System.Windows.Forms.TextBox MaterialMueble;
        private System.Windows.Forms.TextBox VolumenMueble;
        private System.Windows.Forms.TextBox CaballosCoche;
        private System.Windows.Forms.TextBox MarcaCoche;
        private System.Windows.Forms.DateTimePicker CaducidadComida;
        private System.Windows.Forms.TextBox PaginasLibro;
        private System.Windows.Forms.TextBox TiempoLibro;
        private System.Windows.Forms.TextBox PrecioXKiloComida;
        private System.Windows.Forms.Label EuroKilo;
        private System.Windows.Forms.Label Horas;
    }
}