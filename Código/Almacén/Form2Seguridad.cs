using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacén
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    TextBoxVisiblity();
                    PrecioXKiloComida.Visible = true;
                    CaducidadComida.Enabled = true;
                    EuroKilo.Visible = true;
                    break;
                case 1:
                    TextBoxVisiblity();
                    MaterialMueble.Visible = true;
                    VolumenMueble.Visible = true;
                    break;
                case 2:
                    TextBoxVisiblity();
                    MarcaCoche.Visible = true;
                    CaballosCoche.Visible = true;
                    break;
                case 3:
                    TextBoxVisiblity();
                    PaginasLibro.Visible = true;
                    TiempoLibro.Visible = true;
                    Horas.Visible = true;
                    break;
                default:
                    MessageBox.Show("Choose a valid Type", "Type not valid");
                    break;

            }            
        }

        public void TextBoxVisiblity()
        {
            MaterialMueble.Visible = false;
            VolumenMueble.Visible = false;
            MarcaCoche.Visible = false;
            CaballosCoche.Visible = false;
            PaginasLibro.Visible = false;
            TiempoLibro.Visible = false;
            PrecioXKiloComida.Visible = false;
            CaducidadComida.Enabled = false;
            Horas.Visible = false;
            EuroKilo.Visible = false;
        }

        public void CalcularPrecioPorKilo()
        {
            double Precio;
            double.TryParse(PrecioObj.Text, out Precio);
            double Kilo;
            double.TryParse(PesoObj.Text, out Kilo);
            if (Precio == 0 || Kilo == 0)
            {
                PrecioXKiloComida.Text = "0";
            }
            else
            {
                double PrecioPorKilo = Precio / Kilo;
                PrecioXKiloComida.Text = PrecioPorKilo.ToString();
            }
            
        }

        private void PrecioObj_TextChanged(object sender, EventArgs e)
        {
            CalcularPrecioPorKilo();
        }

        private void PesoObj_TextChanged(object sender, EventArgs e)
        {
            CalcularPrecioPorKilo();
        }

        private void AñadirItem_Click(object sender, EventArgs e)
        {
            Item item = null;
            int variable1;
            double variable2;
            double Peso;
            double Precio;
            CheckFormat(out Peso, out Precio);

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Comida comida = new Comida(NombreObj.Text, Peso, Precio, CaducidadComida.Value);
                    item = comida;
                    break;
                case 1:
                    variable2 = double.Parse(VolumenMueble.Text);
                    Mueble mueble = new Mueble(NombreObj.Text, Peso, Precio, VolumenMueble.Text, variable2);
                    item = mueble;
                    break;
                case 2:
                    variable1 = int.Parse(CaballosCoche.Text);
                    Coche coche = new Coche(NombreObj.Text, Peso, Precio, variable1, MarcaCoche.Text);
                    item = coche;
                    break;
                case 3:
                    variable1 = int.Parse(PaginasLibro.Text);
                    variable2 = int.Parse(TiempoLibro.Text);
                    Libro libro = new Libro(NombreObj.Text, Peso, Precio, variable1, variable2);
                    item = libro;
                    break;
                default:
                    throw new Exception("Selecciona tipo de Item");                    
            }
            form1.empresa.AddItem(item);
        }

        private void CheckFormat(out double Peso, out double Precio)
        {                        
                string Message = "";
                double Peso1;
                double Precio1;
                if (!double.TryParse(PesoObj.Text, out Peso1))
                {
                    Message += "Formato de Precio incorrecto\r\n";
                }
                if (!double.TryParse(PrecioObj.Text, out Precio1))
                {
                    Message += "Formato de Peso incorrecto\r\n";
                }

                if (Peso1 == 0 || Precio1 == 0 || !String.IsNullOrEmpty(CheckVariables()))
                {
                Message += CheckVariables();
                throw new Exception(Message);
                }
                    

                Peso = Peso1;
                Precio = Precio1;
            
           
        }

        private string CheckVariables()
        {
            double variable1;
            int variable2;
            string Message = "";
            switch (comboBox1.SelectedIndex)
            {
                case 1:
                    if (!double.TryParse(VolumenMueble.Text, out variable1))
                        Message += "Formato de Volumen incorrecto\r\n";
                    break;
                case 2:
                    if (!int.TryParse(CaballosCoche.Text, out variable2))
                        Message += "Formato de Caballos incorrecto\r\n";
                    break;
                case 3:
                    if (!double.TryParse(TiempoLibro.Text, out variable1))
                        Message += "Formato de Tiempo de Lectura incorrecto\r\n";
                    if (!int.TryParse(TiempoLibro.Text, out variable2))
                        Message += "Formato de Páginas incorrecto\r\n";                    
                    break;
            }
            return Message;
        }
    }
}
