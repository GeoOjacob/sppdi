   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   Z=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5   	    sistemaCorporativo$   sistemaCorporativo.LoginScreen   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   N
Behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   	   :d2http://schemas.microsoft.com/expression/blend/2008  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  6F   -   5        (   "MahApps.Metro.Controls.MetroWindow   Name$  loginScreen��5   �    � Title$ Acesso Restrito��5   	   $	��448��6!   $��326.5��6.    � WindowStartupLocation$ CenterScreen=�6<    � 
ResizeMode$ NoResize=�5	       � Icon$9 3/sistemaCorporativo;component/IMAGES/Login_Icon.png��6   .��5      � -   5         �Name$
 Back��5      $��0,0,-6,1q�6    � RowDefinitions 5   
   �� 5      $	��33* �6   �� 5      $
��153* �6   �� 5      $	��19* �6   �� 5      $	��68* �6   �� 5      $
��117* �6    � ColumnDefinitions 5   
   �� 5      $
��289* �6   �� 5      $	��35* �6   .+�5   
   �� $��10,0,-291.85,0q�6   $��394.5��6(   $	��Top=�67   $
��Left=�6O   $��608.35��6j   $E��?/sistemaCorporativo;component/IMAGES/Icon_Login FLAT DESIGN.png��6y   $��2��6�   $��5��6�   �� 5   
   -   5         ��Name$ 	txtAgente��5      $��26��6%   $��85,0,0,0q�61   	 �� TextWrapping$
	 Wrap=�6C   *   $MahApps.Metro.Controls.TextBoxHelper
   ClearTextButton
 .    	Watermark$ Agente��6�   $	��Top=�6�   $��3��6�   G� 5   
   -   5         G�Name$ txtSenha��5      $��	85,37,0,0q�6(   $ Senha��6;   .   (MahApps.Metro.Controls.PasswordBoxHelper   CapsLockIcon$ Capslock Ativado��6d   $	��Top=�6�   $��3��6�   $��26��6�   �� 5   
   -   5         ��Name$ 
btnAcessar��5         SquareButtonStyle#���   6%   $��Acessar��6Q   $��199.676,19,0,0q�6c   $	��Top=�6{   $
��36.3��6�   $��4��6�    J� RenderTransformOrigin$ 	0.502,0.5&�6�   5      5      