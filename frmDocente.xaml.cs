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
using System.Windows.Shapes;

namespace CapaPresentacion.Mantenimiento
{
    /// <summary>
    /// Lógica de interacción para frmDocente.xaml
    /// </summary>
    public partial class frmDocente : Window
    {
        public frmDocente()
        {
            InitializeComponent();
        }

        //Declarar un objeto
        CapaNegocio.Docente docente = new CapaNegocio.Docente();

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            //Asignar las propiedades al objeto Docente
            docente.Codigo = txtCodigo.Text.Trim();
            docente.Apellidos = txtApellidos.Text.Trim();
            docente.Nombres = txtNombres.Text.Trim();
            docente.Domicilio = txtDomicilio.Text.Trim();
            docente.Correo = txtCorreo.Text.Trim();
            //Asignar Lugar de Nacimiento
            if (cbxLugarNac.SelectedIndex >= 1)
            {
                docente.LugarNac = cbxLugarNac.Text;
            }
            else MessageBox.Show("Seleccione una ciudad correcta");

            docente.FechaNac = dpFechaNac.DisplayDate;
            docente.Profesion = txtProfesion.Text.Trim();

            MessageBox.Show("Los datos del Docente fueron registrados correctamente.");
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            //Traer los atributos
            MessageBox.Show("Codigo: " + docente.Codigo + "\nApellidos: " + docente.Apellidos +
                            "\nNombres: " +docente.Nombres + "\nDomicilio: " + docente.Domicilio +
                            "\nCorreo: " + docente.Correo + "\nLugar de Nacimiento: " + docente.LugarNac +
                            "\nFecha de Nacimiento: " + docente.FechaNac.ToString() + 
                            "\nProfesion: " + docente.Profesion);
        }

        private void btnMetodo1_Click(object sender, RoutedEventArgs e)
        {
            //Llamar al metodo del objeto
            MessageBox.Show(docente.Enseñar());
        }
    }
}
