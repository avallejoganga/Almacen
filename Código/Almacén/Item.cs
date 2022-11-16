
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacén
{
    internal class Item 
    {
        public string tipo { get; }
        public string nombre;
        public double pesoEnKilos;
        public double precio;

        public Item(string tipo, string nombre, double pesoEnKilos, double precio)
        {
            this.tipo = tipo;
            this.nombre = nombre;
            this.pesoEnKilos = pesoEnKilos;
            this.precio = precio;
        }

        public override string ToString()
        {
            return nombre + "\r\n";
        }

        public virtual string GetItemInfo()
        {
            string info = "";
            info +=  tipo + "\r\n";
            info +=  nombre + "\r\n";
            info +=  pesoEnKilos.ToString() + "\r\n";
            info +=  precio.ToString() +"\r\n";
            return info;

        }
    }

    internal class Comida : Item
    {
        public DateTime fechaCaducidad;
        public double precioPorKilo;
        public Comida(string nombre, double pesoEnKilos, double precio, DateTime fechaCaducidad) : 
                         base("Comida", nombre, pesoEnKilos, precio)
        {
            this.fechaCaducidad = fechaCaducidad;
            CalcularPrecioPorKilo();
        }

        private void CalcularPrecioPorKilo()
        {
            if(base.pesoEnKilos != 0 )
                precioPorKilo = base.precio / base.pesoEnKilos;
        }

        public override string GetItemInfo()
        {
            string info = "";
            info += base.GetItemInfo();
            info += fechaCaducidad.ToString() + "\r\n";
            info += precioPorKilo.ToString() +"\r\n";
            return info;
        }
    }

    internal class Mueble : Item
    {
        public string Material;
        public double volumen;
        public Mueble( string nombre, double pesoEnKilos, double precio, string Material, double volumen) :
                         base("Mueble", nombre, pesoEnKilos, precio)
        {
            this.Material = Material;
            this.volumen = volumen;
        }
        public override string GetItemInfo()
        {
            string info = "";
            info += base.GetItemInfo();
            info += Material + "\r\n";
            info += volumen.ToString() + "\r\n";
            return info;
        }
    }

    internal class Coche : Item
    {
        public int Caballos;
        public string Marca;
        public Coche(string nombre, double pesoEnKilos, double precio, int caballos, string marca) : 
                        base("Coche", nombre, pesoEnKilos, precio)
        {
            this.Caballos = caballos;
            this.Marca = marca;
        }
        public override string GetItemInfo()
        {
            string info = "";
            info += base.GetItemInfo();
            info += Caballos.ToString() + "\r\n";
            info += Marca + "\r\n";
            return info;
        }
    }

    internal class Libro : Item
    {
        public int NumeroDePaginas;
        public double TiempoLectura;
        public Libro(string nombre, double pesoEnKilos, double precio, int numeroDePaginas, double tiempoLectura) : 
                         base("Libro", nombre, pesoEnKilos, precio)
        {
            this.NumeroDePaginas = numeroDePaginas;
            this.TiempoLectura = tiempoLectura;
        }

        public override string GetItemInfo()
        {
            string info = "";
            info += base.GetItemInfo();
            info += NumeroDePaginas.ToString() + "\r\n";
            info += TiempoLectura.ToString() + "\r\n";
            return info;
        }
    }
}
