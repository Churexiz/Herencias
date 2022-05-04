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

namespace CapaPresentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAlumno_Click(object sender, RoutedEventArgs e)
        {
            //Llamar al formulario del alumno
            Mantenimiento.frmAlumno frm = new Mantenimiento.frmAlumno();
            //Mostrar el formulario
            frm.Show();
        }

        private void btnDocente_Click(object sender, RoutedEventArgs e)
        {
            //Llamar al formulario del docente
            Mantenimiento.frmDocente frm = new Mantenimiento.frmDocente();
            //Mostrar el formulario
            frm.Show();
        }

        private void btnAdministrativo_Click(object sender, RoutedEventArgs e)
        {
            //Llamar al formulario administrativo
            Mantenimiento.frmAdministrativo frm = new Mantenimiento.frmAdministrativo();
            //Mostrar el formulario
            frm.Show();
        }
    }
}
