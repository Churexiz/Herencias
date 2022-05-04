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
//CODIGO DE LOS ITEMS DE LA VENTANA
Window x:Class="CapaPresentacion.Mantenimiento.frmAlumno"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:CapaPresentacion.Mantenimiento"
        mc:Ignorable="d"
        Title="Datos del Alumno" Height="450" Width="800">
    <Grid>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="7*"/>
        </Grid.ColumnDefinitions>
        <TextBox x:Name="txtNombres" HorizontalAlignment="Left" Height="26" Margin="271,176,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120"/>
        <TextBox x:Name="txtApellidos" HorizontalAlignment="Left" Height="26" Margin="271,145,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120"/>
        <TextBox x:Name="txtDomicilio" HorizontalAlignment="Left" Height="26" Margin="271,207,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120"/>
        <TextBox x:Name="txtCorreo" HorizontalAlignment="Left" Height="26" Margin="271,238,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120"/>
        <TextBox x:Name="txtEscuela" HorizontalAlignment="Left" Height="26" Margin="271,331,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120"/>
        <ComboBox x:Name="cbxLugarNac" HorizontalAlignment="Left" Margin="271,269,0,0" VerticalAlignment="Top" Width="120" Height="26">
            <TextBlock HorizontalAlignment="Left" TextWrapping="Wrap" Text="Arequipa" VerticalAlignment="Top"/>
            <TextBlock HorizontalAlignment="Left" TextWrapping="Wrap" Text="Cusco" VerticalAlignment="Top"/>
            <TextBlock HorizontalAlignment="Left" TextWrapping="Wrap" Text="Lima" VerticalAlignment="Top"/>
            <TextBlock HorizontalAlignment="Left" TextWrapping="Wrap" Text="Madre de Dios" VerticalAlignment="Top"/>
            <TextBlock HorizontalAlignment="Left" TextWrapping="Wrap" Text="Puno" VerticalAlignment="Top"/>
        </ComboBox>
        <DatePicker x:Name="dpFechaNac" HorizontalAlignment="Left" Margin="271,300,0,0" VerticalAlignment="Top" Height="26" Width="145"/>
        <TextBox x:Name="txtCodigo" HorizontalAlignment="Left" Height="26" Margin="271,114,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120"/>
        <Button x:Name="btnGuardar" Content="Guardar" HorizontalAlignment="Left" Margin="475,207,0,0" VerticalAlignment="Top" Width="75" Height="20" Click="btnGuardar_Click" BorderBrush="{x:Null}" Background="#FF1C597C" Foreground="{DynamicResource {x:Static SystemColors.ControlLightLightBrushKey}}" FontWeight="Bold"/>
        <Button x:Name="btnMostrar" Content="Mostrar" HorizontalAlignment="Left" Margin="475,248,0,0" VerticalAlignment="Top" Width="75" Height="20" Click="btnMostrar_Click" BorderBrush="{x:Null}" Background="#FF1C597C" Foreground="{DynamicResource {x:Static SystemColors.ControlLightLightBrushKey}}" FontWeight="Bold"/>
        <Button x:Name="btnMetodo1" Content="Método 1" HorizontalAlignment="Left" Margin="608,207,0,0" VerticalAlignment="Top" Width="75" Height="20" Click="btnMetodo1_Click" BorderBrush="{x:Null}" Background="#FFE65E5E" FontWeight="Bold" Foreground="{DynamicResource {x:Static SystemColors.ControlLightLightBrushKey}}"/>
        <TextBox x:Name="txtSeguro" HorizontalAlignment="Left" Height="26" Margin="271,362,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120"/>
        <Rectangle Fill="#FF264078" HorizontalAlignment="Left" Height="37" VerticalAlignment="Top" Width="792"/>
        <Label Content="SISTEMA ACADÉMICO UAC" HorizontalAlignment="Left" Margin="10,10,0,0" VerticalAlignment="Top" FontWeight="Bold" Background="{x:Null}" Foreground="{DynamicResource {x:Static SystemColors.ControlLightLightBrushKey}}"/>
        <Image Margin="311,42,332,316" Source="/CapaPresentacion;component/UACazul.png" Stretch="Fill"/>
        <Label Content="Código:" HorizontalAlignment="Left" Margin="130,114,0,0" VerticalAlignment="Top" FontWeight="Bold"/>
        <Label Content="Apellidos:" HorizontalAlignment="Left" Margin="130,145,0,0" VerticalAlignment="Top" RenderTransformOrigin="0.5,0.346" FontWeight="Bold"/>
        <Label Content="Nombres:" HorizontalAlignment="Left" Margin="130,176,0,0" VerticalAlignment="Top" FontWeight="Bold"/>
        <Label Content="Domicilio" HorizontalAlignment="Left" Margin="130,207,0,0" VerticalAlignment="Top" FontWeight="Bold"/>
        <Label Content="Correo:" HorizontalAlignment="Left" Margin="130,238,0,0" VerticalAlignment="Top" RenderTransformOrigin="0.694,0.615" FontWeight="Bold"/>
        <Label Content="Lugar de Nacimiento:" HorizontalAlignment="Left" Margin="130,269,0,0" VerticalAlignment="Top" FontWeight="Bold"/>
        <Label Content="Fecha de Nacimiento:" HorizontalAlignment="Left" Margin="130,300,0,0" VerticalAlignment="Top" FontWeight="Bold"/>
        <Label Content="Escuela:" HorizontalAlignment="Left" Margin="130,331,0,0" VerticalAlignment="Top" FontWeight="Bold"/>
        <Label Content="Seguro:" HorizontalAlignment="Left" Margin="130,362,0,0" VerticalAlignment="Top" FontWeight="Bold"/>
    </Grid>
</Window>
