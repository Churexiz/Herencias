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
//CODIGO DE LOS ITEMS DE LA VENTANA
<Window x:Class="CapaPresentacion.Mantenimiento.frmAdministrativo"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:CapaPresentacion.Mantenimiento"
        mc:Ignorable="d"
        Title="frmAdministrativo" Height="450" Width="800">
    <Grid>
        <TextBox x:Name="txtNombres" HorizontalAlignment="Left" Height="26" Margin="256,191,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120"/>
        <TextBox x:Name="txtApellidos" HorizontalAlignment="Left" Height="26" Margin="256,160,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120"/>
        <TextBox x:Name="txtDomicilio" HorizontalAlignment="Left" Height="26" Margin="256,222,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120"/>
        <TextBox x:Name="txtCorreo" HorizontalAlignment="Left" Height="26" Margin="256,253,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120"/>
        <ComboBox x:Name="cbxLugarNac" HorizontalAlignment="Left" Margin="256,284,0,0" VerticalAlignment="Top" Width="120" Height="26">
            <TextBlock HorizontalAlignment="Left" TextWrapping="Wrap" Text="Arequipa" VerticalAlignment="Top"/>
            <TextBlock HorizontalAlignment="Left" TextWrapping="Wrap" Text="Cusco" VerticalAlignment="Top"/>
            <TextBlock HorizontalAlignment="Left" TextWrapping="Wrap" Text="Lima" VerticalAlignment="Top"/>
            <TextBlock HorizontalAlignment="Left" TextWrapping="Wrap" Text="Madre de Dios" VerticalAlignment="Top"/>
            <TextBlock HorizontalAlignment="Left" TextWrapping="Wrap" Text="Puno" VerticalAlignment="Top"/>
        </ComboBox>
        <DatePicker x:Name="dpFechaNac" HorizontalAlignment="Left" Margin="256,315,0,0" VerticalAlignment="Top" Height="26" Width="145"/>
        <TextBox x:Name="txtCodigo" HorizontalAlignment="Left" Height="26" Margin="256,129,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120"/>
        <Button x:Name="btnGuardar" Content="Guardar" HorizontalAlignment="Left" Margin="463,218,0,0" VerticalAlignment="Top" Width="75" Height="20" Click="btnGuardar_Click" Background="#FF1C597C" BorderBrush="{x:Null}" Foreground="{DynamicResource {x:Static SystemColors.ControlLightLightBrushKey}}" FontWeight="Bold"/>
        <Button x:Name="btnMostrar" Content="Mostrar" HorizontalAlignment="Left" Margin="463,253,0,0" VerticalAlignment="Top" Width="75" Height="20" Click="btnMostrar_Click" Background="#FF1C597C" BorderBrush="{x:Null}" Foreground="{DynamicResource {x:Static SystemColors.ControlLightLightBrushKey}}" FontWeight="Bold"/>
        <Button x:Name="btnMetodo1" Content="Método 1" HorizontalAlignment="Left" Margin="582,218,0,0" VerticalAlignment="Top" Width="75" Height="20" Click="btnMetodo1_Click" BorderBrush="{x:Null}" Foreground="{DynamicResource {x:Static SystemColors.ControlLightLightBrushKey}}" Background="#FFE65E5E" FontWeight="Bold"/>
        <TextBox x:Name="txtFuncion" HorizontalAlignment="Left" Height="26" Margin="256,346,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120"/>
        <Label Content="Código:" HorizontalAlignment="Left" Margin="115,129,0,0" VerticalAlignment="Top" FontWeight="Bold"/>
        <Label Content="Apellidos:" HorizontalAlignment="Left" Margin="115,160,0,0" VerticalAlignment="Top" RenderTransformOrigin="0.5,0.346" FontWeight="Bold"/>
        <Label Content="Nombres:" HorizontalAlignment="Left" Margin="115,191,0,0" VerticalAlignment="Top" FontWeight="Bold"/>
        <Label Content="Domicilio" HorizontalAlignment="Left" Margin="115,222,0,0" VerticalAlignment="Top" FontWeight="Bold"/>
        <Label Content="Correo:" HorizontalAlignment="Left" Margin="115,253,0,0" VerticalAlignment="Top" RenderTransformOrigin="0.694,0.615" FontWeight="Bold"/>
        <Label Content="Lugar de Nacimiento:" HorizontalAlignment="Left" Margin="115,284,0,0" VerticalAlignment="Top" FontWeight="Bold"/>
        <Label Content="Fecha de Nacimiento:" HorizontalAlignment="Left" Margin="115,315,0,0" VerticalAlignment="Top" FontWeight="Bold"/>
        <Label Content="Función:" HorizontalAlignment="Left" Margin="115,346,0,0" VerticalAlignment="Top" FontWeight="Bold"/>
        <Rectangle Fill="#FF264078" HorizontalAlignment="Left" Height="37" VerticalAlignment="Top" Width="792"/>
        <Label Content="SISTEMA ACADÉMICO UAC" HorizontalAlignment="Left" Margin="10,10,0,0" VerticalAlignment="Top" FontWeight="Bold" Background="{x:Null}" Foreground="{DynamicResource {x:Static SystemColors.ControlLightLightBrushKey}}"/>
        <Image Margin="311,42,332,316" Source="/CapaPresentacion;component/UACazul.png" Stretch="Fill"/>

    </Grid>
</Window>
