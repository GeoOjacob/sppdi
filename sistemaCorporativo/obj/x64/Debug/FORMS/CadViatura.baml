   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   Z=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5   	    sistemaCorporativo)   #sistemaCorporativo.FORMS.CadViatura   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   N
Behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   	   :d2http://schemas.microsoft.com/expression/blend/2008  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  6F   -   5          � Title$  Cadastro Viatura��5   	   $��379.5��6"   $	��491��61      AccentColorBrush#���   5	   	   $��1q�5
   	    � WindowStartupLocation$ CenterScreen=�5       � 
ResizeMode$ NoResize=�6(    � ShowInTaskbar .  .��5      � .+�5   
   �� $��
10,0,10,10q�6   .@�5      �� $��	Consultar��6   .��5      � .+�5      �� -   5         ��Name$ txtPesquisar��5      *   $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ 	Pesquisar��64   $
��Left=�6a   $��23��6|   $��82.5,22.527,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��312��6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dgvConteudo��5         SelectionMode$ Extended=�64   $
��Left=�6M   $��	10,66,0,0q�6h   $	��Top=�6{   $	��207��6�   $	��447��6�   	   AutoGenerateColumns	 . 6�   �� 5      -   5        
 ��Name$
 btnCancelar1��5        SquareButtonStyle#���  63   $��Cancelar��6_   $
��Left=�6r   $��390.5,295.407,0,0q�6�   $	��Top=�6�   $��115.5��6�   $��46.62��6�   6�   5      5      �� 5      $��	Cadastrar��6   .��5      � $��0,1,0,-1q�6   .+�5      �� $��Fabricante - Modelo��6   $
��Left=�6:   $��10,19.526,0,0q�6U   $	��Top=�6l   �� 5      -   5        $ txtFabricante��5      $
��Left=�65   $��23��6P   $��10,45.486,0,0q�6\   $
 Wrap=�6s   $	��Top=�6�   $	��120��6�   �� 5      $��Placa��6   $
��Left=�6,   $��142,19.526,0,0q�6G   $	��Top=�6_   �� 5      -   5        $ txtPlaca��5      $
��Left=�60   $��23��6K   $��142,45.486,0,0q�6W   $
 Wrap=�6o   $	��Top=�6�   $��84��6�   �� 5      $��Chassi��6   $
��Left=�6-   $��240,19.526,0,0q�6H   $	��Top=�6`   �� 5      -   5        $ 	txtChassi��5      $
��Left=�61   $��23��6L   $��240,45.486,0,0q�6X   $
 Wrap=�6p   $	��Top=�6�   $	��121��6�   �� 5      -   5        $
 btnCadastrar��5      #���  63   $��	Cadastrar��6_   $
��Left=�6s   $��313.857,184.88,0,0q�6�   $	��Top=�6�   $��110.885��6�   $
��41.8��6�   ���	#FF35A3CD J� RenderTransformOrigin$ 0.459,-0.293&�6�   �� 5      -	   5        $
 btnCancelar��5      #���  62   $��Cancelar��6^   $
��Left=�6q   $��193.374,184.88,0,0q�6�   $	��Top=�6�   $��107.626��6�   $
��41.8��6�   5       5!      5"      5$      5%      