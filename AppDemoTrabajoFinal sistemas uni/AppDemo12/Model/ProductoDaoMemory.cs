using AppDemo12.Entity;
using AppDemo12.Service;
using AppDemo12.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDemo12.Model
{
    public class ProductoDaoMemory : ICrudDao<Producto>
    {
        //variable de tipo array de objetos
        Producto[] lista;
        static int cont=0, n=0;//varialbles
        
        //constructor
        public ProductoDaoMemory()
        {
            lista = new Producto[Constante.MAXIMO]; // CREA OBJETO AREREGLO lista
        }

        //metodos de persistencia en memoria
        public void create(Producto o)
        {
            cont++;
            o.ID = cont; //genera id de producto
            lista[n] = o; // guarda objeto producto en el arreglo lista.
            n++;
        }

        public void delete(Producto o)
        {
            for (int i = 0; i < n; i++)
            {
                if (lista[i].ID==o.ID)
                {
                    for (int j = i; j < n; j++)
                    {
                        lista[j] = lista[j + 1];
                    }
                    n--;
                    break;
                }
            }
        }

        public Producto findForId(object o)
        {
            foreach (var item in lista)
            {
                if (item.ID ==  Convert.ToInt32( o.ToString()))
                {
                    return item;
                }

            }
            return null;
        }

        public Producto findForfecha(object o)
        {
            foreach (var item in lista)
            {
                if (item.Fecha == o.ToString())
                {
                    return item;
                }
                 
            }
            return null;
        }


        public Producto findForCategoria(object o)
        {
            foreach (var item in lista)
            {
                if (item.Categoria == o.ToString())
                {
                    return item;
                }
                
            }
            return null;
        }

        public Producto findForProveedor(object o)
        {
            foreach (var item in lista)
            {
                if (item.Proveedor == o.ToString())
                {
                    return item;
                }
               
            }
            return null;
        }



        public Producto[] readAll()
        {
            return lista;
        }

        public void update(Producto o)
        {
            int index = 0;
            foreach (var item in lista)
            {
                if (item.ID==o.ID)
                {
                    lista[index] = o; //actualiza 
                    break;
                }
                index++;
            }
        }
    }
}
