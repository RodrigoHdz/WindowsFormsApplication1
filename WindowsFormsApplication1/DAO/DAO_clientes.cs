
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
    class DAO_clientes
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
            Cat_clientes objetoTablaCliente = (Cat_clientes)elObjeto;

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
            instruccionSQL = "INSERT INTO cat_clientes (razon_social, rfc, calle, num_exterior, num_interior, referencia, colonia, codigopostal, municipio, estado, telefono, correo) VALUES (" + pcs(objetoTablaCliente.Razon_social) + "," + pcs(objetoTablaCliente.Rfc) + "," + pcs(objetoTablaCliente.Calle) + "," + pcs(objetoTablaCliente.Num_exterior) + "," + pcs(objetoTablaCliente.Num_interior) + "," + pcs(objetoTablaCliente.Referencia) + "," + pcs(objetoTablaCliente.Colonia) + "," + pcs(objetoTablaCliente.Codigopostal) + "," + pcs(objetoTablaCliente.Municipio) + "," + pcs(objetoTablaCliente.Estado) + "," + pcs(objetoTablaCliente.Telefono) + "," + pcs(objetoTablaCliente.Correo) + " ) ";

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
