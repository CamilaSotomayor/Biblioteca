using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace InvestigacionFormativa
{
    /// <summary>
    /// Descripción breve de Autor
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Autor : System.Web.Services.WebService
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        private static MySqlConnection conexion = new MySqlConnection(cadena);

        [WebMethod(Description = "Listar autores")]
        public DataSet Listar()
        {
            string consulta = "spListarAutor";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data;
        }

        [WebMethod(Description = "Agregar un autor")]
        public String Agregar(string codAutor, string apellidos, string nombres, string nacionalidad)
        {
            try
            {
                string consulta = "spAgregarAutor(@codAutor,@apellidos,@nombres,@nacionalidad)";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@codAutor", codAutor);
                comando.Parameters.AddWithValue("@apellidos", apellidos);
                comando.Parameters.AddWithValue("@nombres", nombres);
                comando.Parameters.AddWithValue("@nacionalidad", nacionalidad);
                conexion.Open();
                var result = comando.ExecuteScalar();
                conexion.Close();
                return Convert.ToString(result);
            }
            catch (Exception)
            {
                return "Error";
            }

        }

        [WebMethod(Description = "Eliminar un autor")]
        public String Eliminar(string codAutor)
        {
            try
            {
                string consulta = "spEliminarAutor(@codAutor)";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@codAutor", codAutor);
                conexion.Open();
                var result = comando.ExecuteScalar();
                conexion.Close();
                return Convert.ToString(result);
            }
            catch (Exception)
            {
                return "Error";
            }

        }

        [WebMethod(Description = "Actualizar un autor")]
        public String Actualizar(string codAutor, string apellidos, string nombres, string nacionalidad)
        {
            try
            {
                string consulta = "spActualizarAutor(@codAutor,@apellidos,@nombres,@nacionalidad";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@codAutor", codAutor);
                comando.Parameters.AddWithValue("@apellidos", apellidos);
                comando.Parameters.AddWithValue("@nombres", nombres);
                comando.Parameters.AddWithValue("@nacionalidad", nacionalidad);
                conexion.Open();
                var result = comando.ExecuteScalar();
                conexion.Close();
                return Convert.ToString(result);
            }
            catch (Exception)
            {
                return "Error";
            }

        }

        [WebMethod(Description = "Buscar un autor")]
        public DataSet Buscar(string parametro, string texto)
        {
            if (parametro == "CodAutor")
            {
                string consulta = "spBuscarCodAutor(@Texto)";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Texto", texto);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;

            }
            else if (parametro == "Apellidos")
            {
                string consulta = "spBuscarApellidos(@TEXTO);";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@TEXTO", texto);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
            else if (parametro == "Nombres")
            {
                string consulta = "spBuscarNombres(@TEXTO)";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@TEXTO", texto);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
            else if (parametro == "Nacionalidad")
            {
                string consulta = "spBuscarNacionalidad(@TEXTO)";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@TEXTO", texto);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
            else
            {
                string consulta = "spListarAutor";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }
    }
}
