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
    class DAO_sucursales
    {
        //Propiedades
        public ConexionMYSQL oBasedeDatos = new ConexionMYSQL();
        DataSet dsSucursales = null;
        string instruccionSQL;
        MySqlCommand comandoMySQL;
        MySqlDataAdapter datAdapterMySQL;

        //Metodo para insertar un nuevo registro en la base de datos
        public int agregarNuevoRegistro(object elObjeto)
        {
            //convertimos nuestro objeto generico a uno de la clase
            Cat_sucursales objetoTablaSucursales = (Cat_sucursales)elObjeto;

            //preparamos el comando de MySQL
            comandoMySQL = new MySqlCommand();

            //preparar el dataset
            dsSucursales = new DataSet();

            //preparar el DataAdapter
            datAdapterMySQL = new MySqlDataAdapter();

            //establecerla conexion
            comandoMySQL.Connection = oBasedeDatos.miConectorNET;
            oBasedeDatos.establecerConexionNET();

            //ARMAR la instruccion MYQ¡SQL: insert
            instruccionSQL = "INSERT INTO cat_sucursales (codigo, nombre_sucursal, direccion, responsable) VALUES (" + pcs(objetoTablaSucursales.Codigo) + "," + pcs(objetoTablaSucursales.Nombre_sucursal) + "," + pcs(objetoTablaSucursales.Direccion) + "," + pcs(objetoTablaSucursales.Responsable) + " ) ";

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
