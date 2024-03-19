using Computadora.Modelos;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.DAL
{
    public class ComputadoraDAL
    {
        public DataTable ListarComputadorasDal ()
        {
            string consulta = "select * from computadora";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarComputadoraDal (ComputadorasPC computadoras) 
        { 
            string consulta = "insert into computadora values ('"+computadoras.Nombre+"',"+
                                                               "'"+computadoras.Descripcion+"',"+
                                                               ""+computadoras.Precio+","+
                                                               "'"+computadoras.FechaFabricacion+
                                        "')";
            conexion.Ejecutar(consulta);
        }
        public ComputadorasPC ObtenerComputadoraId (int id)
        {
            string consulta = "select * from computadora where computadora=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            ComputadorasPC computadoras = new ComputadorasPC();
            if (tabla.Rows.Count > 0)
            {
                computadoras.IdPC = Convert.ToInt32(tabla.Rows[0]["idpc"]);
                computadoras.Nombre = tabla.Rows[0]["nombre"].ToString();
                computadoras.Descripcion = tabla.Rows[0]["descripcion"].ToString();
                computadoras.Precio = Convert.ToDecimal(tabla.Rows[0]["precio"].ToString);
                computadoras.FechaFabricacion = Convert.ToDateTime(tabla.Rows[0]["fechafab"].ToString);
            }
            return computadoras;
        }
        public void EditarComputadoraDal(ComputadorasPC computadora)
        {
            string consulta = "update computadora set nombre='" + computadora.Nombre + "'," +
                                                           "descripcion='" + computadora.Descripcion + "'," +
                                                           "precio=" + computadora.Precio + "," +
                                                           "fechafab='" + computadora.FechaFabricacion + "'," +                                                         
                                                           "where idpc=" + computadora.IdPC;
            conexion.Ejecutar(consulta);

        }
        public void EliminarComputadoraDal(int id)
        {
            string consulta = "delete from computadora where idpc=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
