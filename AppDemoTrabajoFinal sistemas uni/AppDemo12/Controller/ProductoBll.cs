using AppDemo12.Entity;
using AppDemo12.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDemo12.Controller
{
    public class ProductoBll
    {
        //variable de la clase productodaomemory
        ProductoDaoMemory dao;
       // en el constructor creamos el objeto
       public ProductoBll()
        {
            dao = new ProductoDaoMemory();
        }

        //metodos de negocio
        public void ProductoAdicionar(Producto p)
        {
            dao.create(p);
        }
        public void ProductoActualizar(Producto p)
        {
            dao.update(p);
        }
        public void ProductoEliminar(Producto p)
        {
            dao.delete(p);
        }

        public Producto ProductoBuscarFecha(object fecha)
        {
            return dao.findForfecha(fecha);
        }
        public Producto productoBuscarCategoria(object categoria)
        {
            return dao.findForCategoria(categoria);
        }
        public Producto productoBuscarProveedor(object proveedor)
        {
            return dao.findForProveedor(proveedor);
        }
        public Producto[] ProductoListar()
        {
            return dao.readAll();
        }


    }
}
