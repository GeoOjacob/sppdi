﻿using System;
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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;
using sistemaCorporativo.FORMS.principalScreen;
using sistemaCorporativo.FORMS;
using System.Threading;
using MahApps.Metro;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;



namespace sistemaCorporativo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginScreen : MetroWindow
    {


        public LoginScreen()
        {
            InitializeComponent();
        }


        //Criar string com o endereço do banco
        private string oradb = "Data Source=(DESCRIPTION="
               + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
               + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl.itb.com)));"
               + "User Id=matheus_23177;Password=123456;";
        //Criar strings para usuario e senha

        Boolean resultado = false;
        int total;
        int tentativas = 0;



        private void btnAcessar_Click(object sender, RoutedEventArgs e)
        {

            OracleConnection Oracon = new OracleConnection(oradb);
            Oracon.Open();

            String senhaUser = txtSenha.Password;
            String nomeUser = txtAgente.Text;

            try
            {
                //Executar comandos SQL - TESTANDOO

                if (this.tentativas < 3)
                {
                    //Criar string com o comando para autenticar 
                    string SQL_AUTENTICAR_AGENTE = "SELECT count(f.NOME_USER) as total FROM LOGIN_AGENTE f, CARGO c where f.CARGO_ID_CARGO = c.ID_CARGO and f.SENHA_USER ='" + senhaUser + "' and f.NOME_USER ='" + nomeUser + "' and f.status = 1";

                    //Criar conexão com o banco de dados pelo endereço
                   

                    //Executando Comando
                   
                    OracleCommand cmdSelect = new OracleCommand(SQL_AUTENTICAR_AGENTE, Oracon);
                    OracleDataReader dr = cmdSelect.ExecuteReader();
                    dr.Read();
                    total = Convert.ToInt32(dr[0].ToString());
                    

                    if (total == 1)
                    {
                        resultado = true;
                    }
                    if (resultado == true)
                    {
                        
                        PrincipalScreen start = new PrincipalScreen(txtAgente.Text);
                        start.Show();
                        this.Close();
                        
                    }
                    else
                    {
                        txtAgente.Text = "";
                        txtSenha.Password = "";
                        txtAgente.Focus();
                        this.tentativas++;
                    }
                }

                else
                {
                    MessageBox.Show("O sistema será fechado, excesso de tentativas de Login!", "Aviso");
                    Application.Current.Shutdown();
                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void loginScreen_Loaded(object sender, RoutedEventArgs e)
        {
            txtAgente.Focus();
        }

        private void loginScreen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnAcessar_Click(sender, e);
            }
        }



    }

}
