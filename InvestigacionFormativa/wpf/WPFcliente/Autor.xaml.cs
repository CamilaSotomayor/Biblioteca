using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFcliente
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class Autor : Window
    {
        private srAutor.AutorSoapClient servicio;
        public Autor()
        {
            InitializeComponent();
     
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            servicio = new srAutor.AutorSoapClient();
            dgvAutor.DataContext = servicio.Listar();
        }
        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            string codautor = txtCodAutor.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string nacionalidad = txtNacionalidad.Text.Trim();
            servicio = new srAutor.AutorSoapClient();
            string mensaje = servicio.Agregar(codautor,apellidos,nombres,nacionalidad);
            MessageBox.Show(mensaje);
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            string codautor = txtCodAutor.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string nacionalidad = txtNacionalidad.Text.Trim();
            servicio = new srAutor.AutorSoapClient();
            string mensaje = servicio.Actualizar(codautor, apellidos, nombres, nacionalidad);
            MessageBox.Show(mensaje);
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            string codautor = txtCodAutor.Text.Trim();
            servicio = new srAutor.AutorSoapClient();
            string mensaje = servicio.Eliminar(codautor);
            MessageBox.Show(mensaje);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
