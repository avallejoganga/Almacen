using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Almacén
{
    [Serializable]
    internal class Empresa
    {
        public string nombre;
        public Almacen[] almacenes = new Almacen[4];

        public Empresa(string nombre)
        {
            this.nombre = nombre;
            almacenes[0] = new AlmacenComida("Almacén de comida");
            almacenes[1] = new AlmacenMuebles("Almacén de muebles");
            almacenes[2] = new AlmacenCoches("Almacén de coches");
            almacenes[3] = new AlmacenLibros("Almacén de libros");
        }

        public void AddItem(Item item)
        {
            switch (item.tipo)
            {
                case "Comida":
                    Comida comida = item as Comida;
                    almacenes[0].AddItemToAlmacén(comida);
                    break;
                case "Mueble":
                    almacenes[1].AddItemToAlmacén(item);
                    break;
                case "Coche":
                    almacenes[2].AddItemToAlmacén(item);
                    break;
                case "Libro":
                    almacenes[3].AddItemToAlmacén(item);
                    break;
                default:
                    MessageBox.Show("Item type is not valid", "Invalid Item");
                    break;
            }           

        }      
        
        public void RemoveItem(Item item)
        {
            switch (item.tipo)
            {
                case "Comida":
                    if (almacenes[0].items.Contains(item))
                        almacenes[0].removeItemFromAlmacen(item);
                    break;
                case "Mueble":
                    if (almacenes[1].items.Contains(item))
                        almacenes[1].removeItemFromAlmacen(item);
                    break;
                case "Coche":
                    if (almacenes[2].items.Contains(item))
                        almacenes[2].removeItemFromAlmacen(item);
                    break;
                case "Libro":
                    if (almacenes[3].items.Contains(item))
                        almacenes[3].removeItemFromAlmacen(item);
                    break;
            }
        }

        public void Save(string fileName)
        {
            using (StreamWriter wr = new StreamWriter(fileName))
            {
                for (int i = 0; i < almacenes.Length; i++)
                {                    
                    wr.WriteLine(almacenes[i].getNombreAlmacen());           
                    wr.WriteLine(almacenes[i].GetContenidoAlmacén());
                    wr.WriteLine();     
                }
            }
        }

        public void Open(string filename)
        {

            using (StreamReader sr = new StreamReader(filename))
            {
                
            }
        }

        public void Contenido()
        {
            for (int i = 0; i < almacenes.Length; i++)
            {
                MessageBox.Show(almacenes[i].GetContenidoAlmacén());
            }
        }
    }
}
