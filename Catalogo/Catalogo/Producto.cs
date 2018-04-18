using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Producto
    {
        protected int codigo,cantidad,id;
        protected string nombre;
        protected double costo;

        public Producto(int id,int codigo, int cantidad, string nombre, double costo)
        {
            this.codigo = codigo;
            this.cantidad = cantidad;
            this.nombre = nombre;
            this.costo = costo;
            this.id = id;
        }

        public Producto()
        {

        }

        public int getCodigo()
        {
            return codigo;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public string getNombre()
        {
            return nombre;
        }

        public double getCosto()
        {
            return costo;
        }

        public int getID()
        {
            return id;
        }

        public void setID(int id)
        {
            this.id=id;
        }

        public override string ToString()
        {
            string s = "Id de producto: " + id + " Codigo: " + codigo + " Nombre: " + nombre + " Cantidad: " + cantidad + " Costo: "+costo;
            return s;
        }

    }
}
