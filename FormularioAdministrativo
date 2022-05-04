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
    /// Lógica de interacción para frmAdministrativo.xaml
    /// </summary>
    public partial class frmAdministrativo : Window
    {
        public frmAdministrativo()
        {
            InitializeComponent();
        }

        //Declarar un objeto
        CapaNegocio.Administrativo administrativo = new CapaNegocio.Administrativo();

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            //Asignar las propiedades al objeto administrativo
            administrativo.Codigo = txtCodigo.Text.Trim();
            administrativo.Apellidos = txtApellidos.Text.Trim();
            administrativo.Nombres = txtNombres.Text.Trim();
            administrativo.Domicilio = txtDomicilio.Text.Trim();
            administrativo.Correo = txtCorreo.Text.Trim();
            //Asignar Lugar de Nacimiento
            if (cbxLugarNac.SelectedIndex >= 1)
            {
                administrativo.LugarNac = cbxLugarNac.Text;
            }
            else MessageBox.Show("Seleccione una ciudad correcta");
            administrativo.FechaNac = dpFechaNac.DisplayDate;
            administrativo.Funcion = txtFuncion.Text.Trim();

            MessageBox.Show("Los datos del Administrativo fueron registrados correctamente.");
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            //Traer los atributos
            MessageBox.Show("Codigo: " + administrativo.Codigo + "\nApellidos: " + administrativo.Apellidos +
                            "\nNombres: " + administrativo.Nombres + "\nDomicilio: " + administrativo.Domicilio +
                            "\nCorreo: " + administrativo.Correo + "\nLugar de Nacimiento: " + administrativo.LugarNac +
                            "\nFecha de Nacimiento: " + administrativo.FechaNac.ToString() + "\nFuncion: " + administrativo.Funcion);
        }

        private void btnMetodo1_Click(object sender, RoutedEventArgs e)
        {
            //Llamar al metodo del objeto
            MessageBox.Show(administrativo.Informar());
        }
    }
}
