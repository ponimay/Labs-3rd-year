﻿#pragma checksum "..\..\..\Pages\poiskFIO.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7C39CDA7255E1BB96E953CBEA30ECEFAC15C2A5D7B40C5267D53196C0E09D6A5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using Лаба_1.Pages;


namespace Лаба_1.Pages {
    
    
    /// <summary>
    /// poiskFIO
    /// </summary>
    public partial class poiskFIO : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Pages\poiskFIO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView filtratsiaLV;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Pages\poiskFIO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button vyborkaPage;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Pages\poiskFIO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBpoisk;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pages\poiskFIO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox monthTB;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Pages\poiskFIO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox taifTB;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Pages\poiskFIO.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button vpered;
        
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
            System.Uri resourceLocater = new System.Uri("/Лаба 1;component/pages/poiskfio.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\poiskFIO.xaml"
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
            this.filtratsiaLV = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.vyborkaPage = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Pages\poiskFIO.xaml"
            this.vyborkaPage.Click += new System.Windows.RoutedEventHandler(this.vyborkaPage_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TBpoisk = ((System.Windows.Controls.TextBox)(target));
            
            #line 53 "..\..\..\Pages\poiskFIO.xaml"
            this.TBpoisk.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBpoisk_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.monthTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 55 "..\..\..\Pages\poiskFIO.xaml"
            this.monthTB.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.monthTB_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.taifTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\..\Pages\poiskFIO.xaml"
            this.taifTB.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.taifTB_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.vpered = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\Pages\poiskFIO.xaml"
            this.vpered.Click += new System.Windows.RoutedEventHandler(this.vpered_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

