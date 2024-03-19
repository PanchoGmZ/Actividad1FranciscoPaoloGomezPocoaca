using Computadora.DAL;
using Computadora.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.BSS
{
    public class ComputadoraBss
    {
        ComputadoraDAL dal = new ComputadoraDAL();
        public DataTable ListarComputadoraBss()
        {
            return dal.ListarComputadorasDal();
        }
        public void InsertarComputadoraBss (ComputadorasPC computadoras) 
        {
            dal.InsertarComputadoraDal(computadoras);
        }
        public ComputadorasPC ObtenerComputadorabss(int id)
        {
            return dal.ObtenerComputadoraId(id);
        }
        public void EditarComputadoraBss(ComputadorasPC computadora)
        {
            dal.EditarComputadoraDal(computadora);
        }
        public void EliminarComputadoraBss(int id)
        {
            dal.EliminarComputadoraDal(id);
        }
    }
}
