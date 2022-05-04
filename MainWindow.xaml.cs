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
//CODIGO DE LOS ITEMS DE LA VENTANA
Window x:Name="frmPrincipal" x:Class="CapaPresentacion.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:CapaPresentacion"
        mc:Ignorable="d"
        Title="Sistema Academico UAC" Height="450" Width="800">
    <Grid>
        <Image Source="UAC.jpg" Stretch="Fill"/>

        <Menu HorizontalAlignment="Left" Height="63" Margin="97,37,0,0" VerticalAlignment="Top" Width="685" Background="{x:Null}">
            <Image Source="logo-light.png" Stretch="Fill" Height="53" Width="153"/>
            <Button x:Name="btnAlumno" Content="ALUMNO" HorizontalAlignment="Left" VerticalAlignment="Top" Width="135" Click="btnAlumno_Click" FontWeight="Bold" Background="{x:Null}" Foreground="{DynamicResource {x:Static SystemColors.ControlLightLightBrushKey}}" BorderBrush="{x:Null}"/>
            <Button x:Name="btnDocente" Content="DOCENTE" HorizontalAlignment="Left" VerticalAlignment="Top" Width="135" Click="btnDocente_Click" FontWeight="Bold" Background="{x:Null}" Foreground="{DynamicResource {x:Static SystemColors.ControlLightLightBrushKey}}" BorderBrush="{x:Null}"/>
            <Button x:Name="btnAdministrativo" Content="ADMINISTRATIVO" HorizontalAlignment="Left" VerticalAlignment="Top" Width="135" Click="btnAdministrativo_Click" FontWeight="Bold" Background="{x:Null}" Foreground="{DynamicResource {x:Static SystemColors.ControlLightLightBrushKey}}" BorderBrush="{x:Null}"/>
        </Menu>
        <Rectangle Fill="#FF264078" HorizontalAlignment="Left" Height="37" VerticalAlignment="Top" Width="792"/>
        <TextBlock HorizontalAlignment="Left" Margin="275,10,0,0" TextWrapping="Wrap" Text="Urb. Ingeniería Larapa Grande A-7, San Jerónimo" VerticalAlignment="Top" FontSize="11" Foreground="{DynamicResource {x:Static SystemColors.ControlLightLightBrushKey}}"/>
        <TextBlock HorizontalAlignment="Left" Margin="566,10,0,0" TextWrapping="Wrap" Text="centraldeinformes@uandina.edu.pe" VerticalAlignment="Top" Foreground="{DynamicResource {x:Static SystemColors.HighlightTextBrushKey}}" FontSize="11"/>
        <Label Content="ALCANZA TUS METAS" HorizontalAlignment="Left" Margin="169,140,0,0" VerticalAlignment="Top" Foreground="{DynamicResource {x:Static SystemColors.ControlLightLightBrushKey}}" FontWeight="Bold" FontSize="11"/>
        <Label Content="Sabiduría &#xD;&#xA;que vive en ti" HorizontalAlignment="Left" Margin="169,165,0,0" VerticalAlignment="Top" Foreground="{DynamicResource {x:Static SystemColors.ControlLightLightBrushKey}}" FontWeight="Bold" FontSize="36"/>
        <Label Content="Potenciamos tus habilidades a través de nuestras 20 escuelas &#xD;&#xA;profesionales, Segundas Especialidades, Maestrías y Doctorados." HorizontalAlignment="Left" Margin="169,271,0,0" VerticalAlignment="Top" Width="396" Foreground="{DynamicResource {x:Static SystemColors.ControlLightLightBrushKey}}" FontWeight="Bold"/>

    </Grid>
</Window>
