﻿#pragma checksum "..\..\MenuStammdatenVerwalten.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6F358E3554C2E53A8879544E1C76C353"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.34209
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
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


namespace e_Cars {
    
    
    /// <summary>
    /// MenuStammdatenVerwalten
    /// </summary>
    public partial class MenuStammdatenVerwalten : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\MenuStammdatenVerwalten.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonBack;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MenuStammdatenVerwalten.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Auto;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MenuStammdatenVerwalten.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Kunde;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MenuStammdatenVerwalten.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Tankstelle;
        
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
            System.Uri resourceLocater = new System.Uri("/e-Cars;component/menustammdatenverwalten.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MenuStammdatenVerwalten.xaml"
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
            this.ButtonBack = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\MenuStammdatenVerwalten.xaml"
            this.ButtonBack.Click += new System.Windows.RoutedEventHandler(this.ButtonBack_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Button_Auto = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\MenuStammdatenVerwalten.xaml"
            this.Button_Auto.Click += new System.Windows.RoutedEventHandler(this.ButtonAuto_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Button_Kunde = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\MenuStammdatenVerwalten.xaml"
            this.Button_Kunde.Click += new System.Windows.RoutedEventHandler(this.ButtonKunde_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Button_Tankstelle = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\MenuStammdatenVerwalten.xaml"
            this.Button_Tankstelle.Click += new System.Windows.RoutedEventHandler(this.ButtonTankstelle_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

