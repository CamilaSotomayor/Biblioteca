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
    /// Descripción breve de Libro
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Libro : System.Web.Services.WebService
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        private static MySqlConnection conexion = new MySqlConnection(cadena);

        [WebMethod]
        public DataSet Listar()
        {
            string consulta = "spListarLibro";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data;
        }

        [WebMethod(Description = "Agregar un libro")]
        public String Agregar(string codLibro, string titulo, string editorial)
        {
            try
            {
                string consulta = "spAgregarLibro(@codLibro,@titulo,@editorial)";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@codLibro", codLibro);
                comando.Parameters.AddWithValue("@titulo", titulo);
                comando.Parameters.AddWithValue("@editorial", editorial);
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

        [WebMethod(Description = "Eliminar un libro")]
        public String Eliminar(string codLibro)
        {
            try
            {
                string consulta = "spEliminarLibro(@codLibro)";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@codLibro", codLibro);
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

        [WebMethod(Description = "Actualizar un libro")]
        public String Actualizar(string codLibro, string titulo, string editorial)
        {
            try
            {
                string consulta = "spActualizarLibro(@codLibro,@titulo,@editorial)";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@codLibro", codLibro);
                comando.Parameters.AddWithValue("@titulo", titulo);
                comando.Parameters.AddWithValue("@editorial", editorial);
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

        [WebMethod(Description = "Buscar un libro")]
        public DataSet Buscar(string parametro, string texto)
        {
            if (parametro == "codLibro")
            {
                    string consulta = "spBuscarCodLibro(@Texto)";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@Texto", texto);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataSet data = new DataSet();
                    adapter.Fill(data);
                    return data;
               
            }
            else if (parametro == "titulo")
            {
                string consulta = "spBuscarTitulo(@TEXTO)";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@TEXTO", texto);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
            else if (parametro == "editorial")
            {
                string consulta = "spBuscarEditorial(@TEXTO)";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@TEXTO", texto);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
            else
            {
                string consulta = "spListarLibro";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }

    }    
}
