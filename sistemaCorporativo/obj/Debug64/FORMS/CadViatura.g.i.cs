﻿#pragma checksum "..\..\..\FORMS\CadViatura.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "38C4DFB8A88481828D9D39897A1B25AA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Behaviours;
using MahApps.Metro.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace sistemaCorporativo.FORMS {
    
    
    /// <summary>
    /// CadViatura
    /// </summary>
    public partial class CadViatura : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\FORMS\CadViatura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPesquisar;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\FORMS\CadViatura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgvConteudo;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\FORMS\CadViatura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar1;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\FORMS\CadViatura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFabricante;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\FORMS\CadViatura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPlaca;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\FORMS\CadViatura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtChassi;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\FORMS\CadViatura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCadastrar;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\FORMS\CadViatura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/sistemaCorporativo;component/forms/cadviatura.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FORMS\CadViatura.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\..\FORMS\CadViatura.xaml"
            ((sistemaCorporativo.FORMS.CadViatura)(target)).Loaded += new System.Windows.RoutedEventHandler(this.MetroWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtPesquisar = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.dgvConteudo = ((System.Windows.Controls.DataGrid)(target));
            
            #line 18 "..\..\..\FORMS\CadViatura.xaml"
            this.dgvConteudo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgv_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnCancelar1 = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\FORMS\CadViatura.xaml"
            this.btnCancelar1.Click += new System.Windows.RoutedEventHandler(this.btnCancelar1_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtFabricante = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtPlaca = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtChassi = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnCadastrar = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.btnCancelar = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

