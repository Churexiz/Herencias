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
//CODIGO DE LOS ITEMS DE LA VENTANA
<Window x:Class="CapaPresentacion.Mantenimiento.frmDocente"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:CapaPresentacion.Mantenimiento"
        mc:Ignorable="d"
        Title="frmDocente" Height="450" Width="800">
    <Grid>
        <TextBox x:Name="txtNombres" HorizontalAlignment="Left" Height="26" Margin="254,193,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120"/>
        <TextBox x:Name="txtApellidos" HorizontalAlignment="Left" Height="26" Margin="254,162,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120"/>
        <TextBox x:Name="txtDomicilio" HorizontalAlignment="Left" Height="26" Margin="254,224,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120"/>
        <TextBox x:Name="txtCorreo" HorizontalAlignment="Left" Height="26" Margin="254,255,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120"/>
        <ComboBox x:Name="cbxLugarNac" HorizontalAlignment="Left" Margin="254,286,0,0" VerticalAlignment="Top" Width="120" Height="26">
            <TextBlock HorizontalAlignment="Left" TextWrapping="Wrap" Text="Arequipa" VerticalAlignment="Top"/>
            <TextBlock HorizontalAlignment="Left" TextWrapping="Wrap" Text="Cusco" VerticalAlignment="Top"/>
            <TextBlock HorizontalAlignment="Left" TextWrapping="Wrap" Text="Lima" VerticalAlignment="Top"/>
            <TextBlock HorizontalAlignment="Left" TextWrapping="Wrap" Text="Madre de Dios" VerticalAlignment="Top"/>
            <TextBlock HorizontalAlignment="Left" TextWrapping="Wrap" Text="Puno" VerticalAlignment="Top"/>
        </ComboBox>
        <DatePicker x:Name="dpFechaNac" HorizontalAlignment="Left" Margin="254,317,0,0" VerticalAlignment="Top" Height="26" Width="145"/>
        <TextBox x:Name="txtCodigo" HorizontalAlignment="Left" Height="26" Margin="254,131,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120"/>
        <Button x:Name="btnGuardar" Content="Guardar" HorizontalAlignment="Left" Margin="479,209,0,0" VerticalAlignment="Top" Width="75" Height="20" Click="btnGuardar_Click" Background="#FF1C597C" FontWeight="Bold" BorderBrush="{x:Null}" Foreground="{DynamicResource {x:Static SystemColors.ControlLightLightBrushKey}}"/>
        <Button x:Name="btnMostrar" Content="Mostrar" HorizontalAlignment="Left" Margin="479,254,0,0" VerticalAlignment="Top" Width="75" Height="20" Click="btnMostrar_Click" Background="#FF1C597C" FontWeight="Bold" BorderBrush="{x:Null}" Foreground="{DynamicResource {x:Static SystemColors.ControlLightLightBrushKey}}"/>
        <Button x:Name="btnMetodo1" Content="Método 1" HorizontalAlignment="Left" Margin="608,209,0,0" VerticalAlignment="Top" Width="75" Height="20" Click="btnMetodo1_Click" BorderBrush="{x:Null}" Background="#FFE65E5E" Foreground="{DynamicResource {x:Static SystemColors.ControlLightLightBrushKey}}" FontWeight="Bold"/>
        <TextBox x:Name="txtProfesion" HorizontalAlignment="Left" Height="26" Margin="254,348,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120"/>
        <Label Content="Código:" HorizontalAlignment="Left" Margin="118,131,0,0" VerticalAlignment="Top" FontWeight="Bold"/>
        <Label Content="Apellidos:" HorizontalAlignment="Left" Margin="118,162,0,0" VerticalAlignment="Top" RenderTransformOrigin="0.5,0.346" FontWeight="Bold"/>
        <Label Content="Nombres:" HorizontalAlignment="Left" Margin="118,193,0,0" VerticalAlignment="Top" FontWeight="Bold"/>
        <Label Content="Domicilio" HorizontalAlignment="Left" Margin="118,224,0,0" VerticalAlignment="Top" FontWeight="Bold"/>
        <Label Content="Correo:" HorizontalAlignment="Left" Margin="118,255,0,0" VerticalAlignment="Top" RenderTransformOrigin="0.694,0.615" FontWeight="Bold"/>
        <Label Content="Lugar de Nacimiento:" HorizontalAlignment="Left" Margin="118,286,0,0" VerticalAlignment="Top" FontWeight="Bold"/>
        <Label Content="Fecha de Nacimiento:" HorizontalAlignment="Left" Margin="118,317,0,0" VerticalAlignment="Top" FontWeight="Bold"/>
        <Label Content="Profesión:" HorizontalAlignment="Left" Margin="118,348,0,0" VerticalAlignment="Top" FontWeight="Bold"/>
        <Rectangle Fill="#FF264078" HorizontalAlignment="Left" Height="37" VerticalAlignment="Top" Width="792"/>
        <Label Content="SISTEMA ACADÉMICO UAC" HorizontalAlignment="Left" Margin="10,10,0,0" VerticalAlignment="Top" FontWeight="Bold" Background="{x:Null}" Foreground="{DynamicResource {x:Static SystemColors.ControlLightLightBrushKey}}"/>
        <Image Margin="311,42,332,316" Source="/CapaPresentacion;component/UACazul.png" Stretch="Fill"/>

    </Grid>
</Window>
