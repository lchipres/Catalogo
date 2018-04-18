using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Catal : Producto
    {
        Producto[] p = new Producto[15];
        int cuantosBan = 0;

        public void agregarP(Producto p)
        {
            if (cuantosBan > 14)
            {
                cuantosBan = 0;
            }
            this.p[cuantosBan] = p;
            cuantosBan++;
        }

        public void insertarP(Producto p,int pos)
        {
            if (cuantosBan > 14)
            {
                cuantosBan = 0;
            }
            this.p[pos - 1] = p;
            cuantosBan++;   
        }

        public int getCuantos()
        {
            return cuantosBan;
        }

        public override string ToString()
        {
            string s = "";
            foreach (Producto element in p)
            {
                s += element+Environment.NewLine;
            }
            return s;
        }

        public string buscarP(int posicion)
        {
            string s = "";
            Producto pBus;
            pBus = p[posicion];
            s = pBus+Environment.NewLine;
            return s;
        }

        public void eliminarP(int posicion)
        {
            p[posicion] = null;
        }
    }
}
