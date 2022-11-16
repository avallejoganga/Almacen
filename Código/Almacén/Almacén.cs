using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacén
{
    internal class Almacen
    {
        public Item[] items;
        private string tipoAlmacén;
        private string nombreAlmacén;

        public Almacen(string tipoAlmacén, string nombreAlmacén)
        {
            this.tipoAlmacén = tipoAlmacén;
            this.nombreAlmacén = nombreAlmacén;
            items = new Item[5];
        }

        public string GetContenidoAlmacén()
        {
            string contenido = "";
            for (int i = 0; i < items.Length; i++)
            {
                try
                {
                    switch (items[i].tipo)
                    {
                        case "Comida":
                            Comida comida = items[i] as Comida;
                            contenido += comida.GetItemInfo();
                            break;
                        case "Mueble":
                            Mueble mueble = items[i] as Mueble;
                            contenido += mueble.GetItemInfo();
                            break;
                        case "Coche":
                            Coche coche = items[i] as Coche;
                            contenido += coche.GetItemInfo();
                            break;
                        case "Libro":
                            Libro libro = items[i] as Libro;
                            contenido += libro.GetItemInfo();
                            break;
                        default:
                            break;
                    }
                    contenido += "\r\n";
                }
                catch
                {

                }
                
            }
            return contenido;
        }

        public void SetContenidoAlmacén()
        {
           
        }

        public void AddItemToAlmacén(Item item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (!items.Contains(item))
                {
                    if (items[i] == null)
                    {
                        items[i] = item;
                    }
                }               
            }
        }

        public void removeItemFromAlmacen(Item item)
        {
            if (items.Contains(item))
            {
                items = items.Where(x => x != item).ToArray();
            }
        }

        public string getTipoAlmacen()
        {
            return tipoAlmacén;
        }

        public string getNombreAlmacen()
        {
            return nombreAlmacén;
        }

        public override string ToString()
        {
            return nombreAlmacén;
        }

        public string CosasAlmacén()
        {
            string message = "";
            for(int i = 0; i < items.Length; i++)
                message += items[i].ToString() + "\r\n";
            return message;
        }
    }
    
    internal class AlmacenComida : Almacen
    {
        public Comida[] comida;
        
        public AlmacenComida(string nombreAlmacén) : base("Comida", nombreAlmacén)
        {
            comida = new Comida[5];
        }


    }
   
    internal class AlmacenMuebles : Almacen
    {
        public AlmacenMuebles(string nombreAlmacén) : base("Muebles", nombreAlmacén)
        {

        }
    }
    
    internal class AlmacenCoches : Almacen
    {
        public AlmacenCoches(string nombreAlmacén) : base("Coches", nombreAlmacén)
        {

        }
    }
   
    internal class AlmacenLibros : Almacen
    {
        public AlmacenLibros(string nombreAlmacén) : base("Libros", nombreAlmacén)
        {

        }
    }
}
