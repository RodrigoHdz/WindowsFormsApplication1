using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WindowsFormsApplication1.BO;
using MySql.Data;
using MySql.Data.MySqlClient;
using WindowsFormsApplication1.DB;
using System.Data;

namespace WindowsFormsApplication1.DAO
{
    class DAO_proveedores
    {
        //Propiedades
        public ConexionMYSQL oBasedeDatos = new ConexionMYSQL();
        DataSet dsClientes = null;
        string instruccionSQL;
        MySqlCommand comandoMySQL;
        MySqlDataAdapter datAdapterMySQL;

        //Metodo para insertar un nuevo registro en la base de datos
        public int agregarNuevoRegistro(object elObjeto)
        {
            //convertimos nuestro objeto generico a uno de la clase
            Cat_proveedores objetoTablaProveedores = (Cat_proveedores)elObjeto;

            //preparamos el comando de MySQL
            comandoMySQL = new MySqlCommand();

            //preparar el dataset
            dsClientes = new DataSet();

            //preparar el DataAdapter
            datAdapterMySQL = new MySqlDataAdapter();

            //establecerla conexion
            comandoMySQL.Connection = oBasedeDatos.miConectorNET;
            oBasedeDatos.establecerConexionNET();

            //ARMAR la instruccion MYQ¡SQL: insert
            instruccionSQL = "INSERT INTO cat_proveedores (razon_social, rfc, calle, num_exterior, num_interior, referencia, colonia, codigopostal, municipio, estado, telefono, correo) VALUES (" + pcs(objetoTablaProveedores.Razon_social) + "," + pcs(objetoTablaProveedores.Rfc) + "," + pcs(objetoTablaProveedores.Calle) + "," + pcs(objetoTablaProveedores.Num_exterior) + "," + pcs(objetoTablaProveedores.Num_interior) + "," + pcs(objetoTablaProveedores.Referencia) + "," + pcs(objetoTablaProveedores.Colonia) + "," + pcs(objetoTablaProveedores.Codigopostal) + "," + pcs(objetoTablaProveedores.Municipio) + "," + pcs(objetoTablaProveedores.Estado) + "," + pcs(objetoTablaProveedores.Telefono) + "," + pcs(objetoTablaProveedores.Correo) + " ) ";

            comandoMySQL.CommandText = instruccionSQL;
            int resultadodelComando = comandoMySQL.ExecuteNonQuery();

            if (resultadodelComando <= 0)
            {
                return 0; //hay un error
            }

            return 1;
        }

        public String pcs(string Valor)
        {
            return "'" + Valor + "'";
        }
    }
}
