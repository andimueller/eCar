﻿#pragma checksum "..\..\..\..\UI\Cars\CarNew.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7A3E7A564F7650578B52EF9280BC8639"
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
using e_Cars.UI.Cars;


namespace e_Cars.UI.Cars {
    
    
    /// <summary>
    /// CarNew
    /// </summary>
    public partial class CarNew : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\UI\Cars\CarNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonZurueck;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\UI\Cars\CarNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelSeriennummer;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\UI\Cars\CarNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxSeriennummer;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\UI\Cars\CarNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatepickerWartungstermin;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\UI\Cars\CarNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelKilometerstand;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\UI\Cars\CarNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxKilometerstand;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\UI\Cars\CarNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelTankvorgaenge;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\UI\Cars\CarNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxTankvorgaenge;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\UI\Cars\CarNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAnlegen;
        
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
            System.Uri resourceLocater = new System.Uri("/e-Cars;component/ui/cars/carnew.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\Cars\CarNew.xaml"
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
            this.ButtonZurueck = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\UI\Cars\CarNew.xaml"
            this.ButtonZurueck.Click += new System.Windows.RoutedEventHandler(this.ButtonZurueck_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LabelSeriennummer = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.TextBoxSeriennummer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.DatepickerWartungstermin = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.LabelKilometerstand = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.TextBoxKilometerstand = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\..\UI\Cars\CarNew.xaml"
            this.TextBoxKilometerstand.AddHandler(System.Windows.DataObject.PastingEvent, new System.Windows.DataObjectPastingEventHandler(this.TextBoxPasting));
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\..\UI\Cars\CarNew.xaml"
            this.TextBoxKilometerstand.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Event_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LabelTankvorgaenge = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.TextBoxTankvorgaenge = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\..\..\UI\Cars\CarNew.xaml"
            this.TextBoxTankvorgaenge.AddHandler(System.Windows.DataObject.PastingEvent, new System.Windows.DataObjectPastingEventHandler(this.TextBoxPasting));
            
            #line default
            #line hidden
            
            #line 42 "..\..\..\..\UI\Cars\CarNew.xaml"
            this.TextBoxTankvorgaenge.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Event_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ButtonAnlegen = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\UI\Cars\CarNew.xaml"
            this.ButtonAnlegen.Click += new System.Windows.RoutedEventHandler(this.ButtonAnlegen_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

