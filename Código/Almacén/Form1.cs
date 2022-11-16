using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Almacén
{
    public partial class Form1 : Form
    {
        internal Empresa empresa;
        public Form1()
        {
            InitializeComponent();
            empresa = new Empresa(EmpresaTBox.Text);
            for (int i = 0; i < empresa.almacenes.Length; i++)
                AlmacenCBox.Items.Add(empresa.almacenes[i].ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void VentanaAññadirObjeto_Click(object sender, EventArgs e)
        {
            Form2 popup = new Form2(this);
            popup.ShowDialog();

            if (popup.DialogResult == DialogResult.OK)
            {
                
            }
        }

        private void AlmacenCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemsCBox.Text = "";
            switch (AlmacenCBox.SelectedIndex)
            {
                case 0:
                    RefreshItemsBox(0);
                    UpdateLabels();
                    LabCad.Visible = true;
                    LabPrecioKilo.Visible = true;
                    break;
                case 1:
                    RefreshItemsBox(1);
                    UpdateLabels();
                    LabMaterial.Visible = true;
                    LabVolumen.Visible = true;
                    break;
                case 2:
                    RefreshItemsBox(2);
                    UpdateLabels();
                    LabCaballo.Visible = true;
                    LabMarca.Visible = true;
                    break;
                case 3:
                    RefreshItemsBox(3);
                    UpdateLabels();
                    LabPag.Visible = true;
                    LabTiempo.Visible = true;
                    break;
                default:
                    UpdateLabels();
                    MessageBox.Show("Select a valid Almacen", "No selected Almacen");
                    break;
            }
        }

        private void RefreshItemsBox(int almacen)
        {
            ItemsCBox.Items.Clear();
            for (int i = 0; i < empresa.almacenes[almacen].items.Length; i++)
                if (empresa.almacenes[almacen].items[i] != null)
                    ItemsCBox.Items.Add(empresa.almacenes[almacen].items[i].ToString());
        }

        private void UpdateLabels()
        {
            LabCaballo.Visible = false;
            LabCad.Visible = false;
            LabMarca.Visible = false;
            LabMaterial.Visible = false;
            LabPrecioKilo.Visible = false;
            LabVolumen.Visible = false;
            LabTiempo.Visible = false;
            LabPag.Visible = false;
            LabNombre.Text = "";
            LabTipo.Text = "";
            LabPrecio.Text = "";
            LabPeso.Text = "";
            LabVariable2.Text = "";
            LabVariable1.Text = "";
        }    
        private void ItemsCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Almacen = AlmacenCBox.SelectedIndex;
            int Objeto = ItemsCBox.SelectedIndex;       

            Item item = empresa.almacenes[Almacen].items[Objeto];
            LabNombre.Text = item.nombre;
            LabTipo.Text = item.tipo;
            LabPeso.Text = item.pesoEnKilos.ToString();
            LabPrecio.Text = item.precio.ToString();
            switch (item.tipo)
            {
                case "Comida":
                    Comida comida = item as Comida;
                    LabVariable1.Text = comida.fechaCaducidad.ToString();
                    LabVariable2.Text = comida.precioPorKilo.ToString();
                    break;
                case "Mueble":
                    Mueble mueble = item as Mueble;
                    LabVariable1.Text = mueble.Material;
                    LabVariable2.Text = mueble.volumen.ToString();
                    break;
                case "Coche":
                    Coche coche = item as Coche;
                    LabVariable1.Text = coche.Caballos.ToString();
                    LabVariable2.Text = coche.Marca.ToString();
                    break;
                case "Libro":
                    Libro libro = item as Libro;
                    LabVariable1.Text = libro.NumeroDePaginas.ToString();
                    LabVariable2.Text = libro.TiempoLectura.ToString();
                    break;
            }
        }

      
        private void BotonQuitarObjeto_Click(object sender, EventArgs e)
        {
            int Almacen = AlmacenCBox.SelectedIndex;
            int Objeto = ItemsCBox.SelectedIndex;
            empresa.RemoveItem(empresa.almacenes[Almacen].items[Objeto]);
            UpdateLabels();
            ItemsCBox.Text = "";
            RefreshItemsBox(AlmacenCBox.SelectedIndex);
        }


        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\Users\avall\Documents\A\Empresas";
            saveFileDialog1.Filter = "(*.txt)| *.txt";
            saveFileDialog1.FileName = empresa.nombre + ".txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                empresa.Save(saveFileDialog1.FileName);
            }            
        }
        private void Open_Click(object sender, EventArgs e)
        {              
            openFileDialog1.InitialDirectory = @"C:\Users\avall\Documents\A\Empresas";
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string NombreEmpresa = openFileDialog1.SafeFileName;
                NombreEmpresa = NombreEmpresa.Substring(0,  NombreEmpresa.Length - 4);
                EmpresaTBox.Text = NombreEmpresa;
                empresa = ReadFile(openFileDialog1.FileName);
            }

        }

        private Empresa ReadFile(string fileName)
        {
            Empresa OpenEmpresa = new Empresa(fileName);            
            using (StreamReader sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {

                    switch (sr.ReadLine())
                    {
                        case "Comida":
                            Comida comida = new Comida(sr.ReadLine(), double.Parse(sr.ReadLine()), double.Parse(sr.ReadLine()), DateTime.Parse(sr.ReadLine()));
                            OpenEmpresa.AddItem(comida);
                            break;
                        case "Mueble":
                            Mueble mueble = new Mueble(sr.ReadLine(), double.Parse(sr.ReadLine()), double.Parse(sr.ReadLine()), sr.ReadLine(), double.Parse(sr.ReadLine()));
                            OpenEmpresa.AddItem(mueble);
                            break;
                        case "Coche":
                            Coche coche = new Coche(sr.ReadLine(), double.Parse(sr.ReadLine()), double.Parse(sr.ReadLine()), int.Parse(sr.ReadLine()), sr.ReadLine());
                            OpenEmpresa.AddItem(coche);
                            break;
                        case "Libro":
                            Libro libro = new Libro(sr.ReadLine(), double.Parse(sr.ReadLine()), double.Parse(sr.ReadLine()), int.Parse(sr.ReadLine()), double.Parse(sr.ReadLine()));
                            OpenEmpresa.AddItem(libro);
                            break;
                    }   

                    //if (sr.ReadLine().Contains("Comida"))
                    //{
                    //    Comida comida = new Comida(sr.ReadLine(), double.Parse(sr.ReadLine()), double.Parse(sr.ReadLine()), DateTime.Parse(sr.ReadLine()));
                    //    OpenEmpresa.AddItem(comida);
                    //}
                    //else if (sr.ReadLine().Contains("Mueble"))
                    //{
                    //    Mueble mueble = new Mueble(sr.ReadLine(), double.Parse(sr.ReadLine()), double.Parse(sr.ReadLine()), sr.ReadLine(), double.Parse(sr.ReadLine()));
                    //    OpenEmpresa.AddItem(mueble);
                    //}
                    //else if (sr.ReadLine().Contains("Mueble"))
                    //{
                    //    Coche coche = new Coche(sr.ReadLine(), double.Parse(sr.ReadLine()), double.Parse(sr.ReadLine()), int.Parse(sr.ReadLine()), sr.ReadLine());
                    //    OpenEmpresa.AddItem(coche);
                    //}
                    //else if (sr.ReadLine().Contains("Mueble"))
                    //{
                    //    Libro libro = new Libro(sr.ReadLine(), double.Parse(sr.ReadLine()), double.Parse(sr.ReadLine()), int.Parse(sr.ReadLine()), double.Parse(sr.ReadLine()));
                    //    OpenEmpresa.AddItem(libro);
                    //}
                }
            }     
            return OpenEmpresa;
        }

        private void EmpresaTBox_TextChanged(object sender, EventArgs e)
        {
            empresa.nombre = EmpresaTBox.Text;
        }       

        
    }
}
