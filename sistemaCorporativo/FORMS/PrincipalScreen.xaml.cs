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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;
using sistemaCorporativo;
using sistemaCorporativo.FORMS.cadAgente;
using sistemaCorporativo.FORMS;
using MahApps.Metro.Actions;
using MahApps.Metro.Converters;
using MahApps.Metro;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;




namespace sistemaCorporativo.FORMS.principalScreen
{
    /// <summary>
    /// Interaction logic for PrincipalScreen.xaml
    /// </summary>
    public partial class PrincipalScreen : MetroWindow
    {
        private string user;
        public PrincipalScreen(string usuario)
        {
            InitializeComponent();
            user = usuario.ToString();
        }

        //String para buscar informações do usuario
        private string SQL_SEARCH = "select id_Agente from login_Agente where nome_User = :user";
        //Criar string com o endereço do banco
        private string oradb = "Data Source=(DESCRIPTION="
               + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
               + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl.itb.com)));"
               + "User Id=matheus_23177;Password=123456;";

        private void AgenteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            CadAgente cadAgente = new CadAgente();
            cadAgente.ShowDialog();
        }
        

        private void OcorrenciaMenuItem_Click(object sender, RoutedEventArgs e)
        {
            CadOcorrencia cadOcorrencia = new CadOcorrencia();
            cadOcorrencia.ShowDialog();
        }
        
            private void DenunciaMenuItem_Click(object sender, RoutedEventArgs e)
        {
            CadDenuncia cadDenuncia = new CadDenuncia();
            cadDenuncia.ShowDialog();
        }

        private void btnPerfil_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            flyoutAgente.IsOpen = true;
			flyoutAgente.IsPinned = false;
        }

       
        private void tgsTema_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
            ThemeManager.ChangeAppTheme(Application.Current, "BaseLight");
            ImageBrush LightImage = new ImageBrush();
            Image image = new Image();
            image.Source = new BitmapImage(
                new Uri(
                   "pack://application:,,,/IMAGES/Wallpaper Oficial SPPDI material LIGHT.png"));
            LightImage.ImageSource = image.Source;
            grdPrincipal.Background = LightImage;
            LightImage.Stretch = Stretch.Fill;
            //Mudar a cor do botao Logoff
            SolidColorBrush solidLight = new SolidColorBrush();
            solidLight.Color = Color.FromArgb(255, 147, 147, 147);
            btnFzrLogoff.Background = solidLight;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tgsTema_IsCheckedChanged(object sender, System.EventArgs e)
        {
            try
            {
            ThemeManager.ChangeAppTheme(Application.Current, "BaseDark");
            ImageBrush DarkImage = new ImageBrush();
            Image imageDark = new Image();
            imageDark.Source = new BitmapImage(
                new Uri(
                   "pack://application:,,,/IMAGES/Wallpaper Oficial SPPDI material.png"));
            DarkImage.ImageSource = imageDark.Source;
            grdPrincipal.Background = DarkImage;
            DarkImage.Stretch = Stretch.Fill;
            //Mudar a cor do botao logoff
            SolidColorBrush solidDark= new SolidColorBrush();
            solidDark.Color = Color.FromArgb(255, 38, 38, 38);
            btnFzrLogoff.Background = solidDark;
            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ViaturaMenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
             CadViatura cadViatura = new CadViatura();
             cadViatura.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void Tile_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
             CadAgente cadAgente = new CadAgente();
             cadAgente.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void Tile_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
            CadViatura cadViatura = new CadViatura();
            cadViatura.ShowDialog();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void Tile_Click_2(object sender, System.Windows.RoutedEventArgs e)
        {
			try{
		     CadOcorrencia cadOcorrencia = new CadOcorrencia();
             cadOcorrencia.ShowDialog();
			}
			catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        	
        }

        private void Tile_Click_3(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
             CadDenuncia cadDenuncia = new CadDenuncia();
             cadDenuncia.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        	
        }

        private void flyoutAgente_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        }

        private void DenunciaAnonMenuItem_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            CadDenunciaAnon cadDenunciaAnon = new CadDenunciaAnon();
            cadDenunciaAnon.ShowDialog();
        	
        }

        private void Tile_Click_4(object sender, System.Windows.RoutedEventArgs e)
        {
        	CadDenunciaAnon cadDenunciaAnon = new CadDenunciaAnon();
            cadDenunciaAnon.ShowDialog();
        }

        private void btnFzrLogoff_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            LogoffSplash logofSplash = new LogoffSplash();
            logofSplash.ShowDialog();
            this.Close();
           
        }

        private void PrincipalScreen1_Loaded(object sender, RoutedEventArgs e)
        {
            OracleConnection Oracon = new OracleConnection(oradb);
            Oracon.Open();

            OracleCommand cmd = new OracleCommand(SQL_SEARCH, Oracon);
            cmd.Parameters.Add("user", user);
            OracleDataReader read = cmd.ExecuteReader();
            read.Read();
        }	  
    }
}
