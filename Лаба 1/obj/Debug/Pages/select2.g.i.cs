﻿#pragma checksum "..\..\..\Pages\select2.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C49DDB07845B1A71651E48021681F144C49D643E2B23F848D6708950C303F921"
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
using Лаба_1;


namespace Лаба_1 {
    
    
    /// <summary>
    /// select2
    /// </summary>
    public partial class select2 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Pages\select2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid SpavochnikDG;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\select2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button vvodButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\select2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBpoisk;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\select2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox chislo;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\select2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button vperedBTN;
        
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
            System.Uri resourceLocater = new System.Uri("/Лаба 1;component/pages/select2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\select2.xaml"
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
            this.SpavochnikDG = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.vvodButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Pages\select2.xaml"
            this.vvodButton.Click += new System.Windows.RoutedEventHandler(this.vvodButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TBpoisk = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\Pages\select2.xaml"
            this.TBpoisk.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBpoisk_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.chislo = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\..\Pages\select2.xaml"
            this.chislo.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.chislo_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.vperedBTN = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Pages\select2.xaml"
            this.vperedBTN.Click += new System.Windows.RoutedEventHandler(this.vperedBTN_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

