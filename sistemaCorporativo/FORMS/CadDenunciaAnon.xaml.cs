﻿using System;
using System.Collections.Generic;
using System.Text;
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

namespace sistemaCorporativo
{
	/// <summary>
	/// Interaction logic for CadDenunciaAnon.xaml
	/// </summary>
	public partial class CadDenunciaAnon : MetroWindow
	{
		public CadDenunciaAnon()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

		private void btnCancelar_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			this.Close();
		}
	}
}