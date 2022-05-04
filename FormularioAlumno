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
    /// Lógica de interacción para frmAlumno.xaml
    /// </summary>
    public partial class frmAlumno : Window
    {
        public frmAlumno()
        {
            InitializeComponent();
        }

        //Declarar un objeto
        CapaNegocio.Alumno alumno = new CapaNegocio.Alumno();

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            //Asignar las propiedades al objeto alumno
            alumno.Codigo = txtCodigo.Text.Trim();
            alumno.Apellidos = txtApellidos.Text.Trim();
            alumno.Nombres = txtNombres.Text.Trim();
            alumno.Domicilio = txtDomicilio.Text.Trim();
            alumno.Correo = txtCorreo.Text.Trim();
            //Asignar Lugar de Nacimiento
            if (cbxLugarNac.SelectedIndex >= 1)
            {
                alumno.LugarNac = cbxLugarNac.Text;
            }
            else MessageBox.Show("Seleccione una ciudad correcta");
            alumno.FechaNac = dpFechaNac.DisplayDate;
            alumno.Escuela = txtEscuela.Text.Trim();
            alumno.Seguro = txtSeguro.Text.Trim();

            MessageBox.Show("Los datos del Alumno fueron registrados correctamente.");
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            //Traer los atributos
            MessageBox.Show("Codigo: " + alumno.Codigo + "\nApellidos: " + alumno.Apellidos +
                            "\nNombres: " + alumno.Nombres + "\nDomicilio: " + alumno.Domicilio +
                            "\nCorreo: " + alumno.Correo + "\nLugar de Nacimiento: " + alumno.LugarNac +
                            "\nFecha de Nacimiento: " + alumno.FechaNac.ToString() + "\nEscuela: " + alumno.Escuela +
                            "\nSeguro: " + alumno.Seguro);
        }

        private void btnMetodo1_Click(object sender, RoutedEventArgs e)
        {
            //Llamar al metodo del objeto
            MessageBox.Show(alumno.Estudiar());
        }
    }
}
