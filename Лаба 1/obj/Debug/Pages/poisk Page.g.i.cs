﻿#pragma checksum "..\..\..\Pages\poisk Page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E6A6196057B6A1816F6C8EE725D6C419606598B9E0D64E1D473548F4D33F8928"
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
    /// poisk_Page
    /// </summary>
    public partial class poisk_Page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Pages\poisk Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView poiskLV;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Pages\poisk Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonBackinPoisk;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Pages\poisk Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox poiskTB;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Pages\poisk Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button vperedBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Лаба 1;component/pages/poisk%20page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\poisk Page.xaml"
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
            this.poiskLV = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.ButtonBackinPoisk = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Pages\poisk Page.xaml"
            this.ButtonBackinPoisk.Click += new System.Windows.RoutedEventHandler(this.ButtonBackinPoisk_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.poiskTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 51 "..\..\..\Pages\poisk Page.xaml"
            this.poiskTB.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.poiskTB_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.vperedBtn = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Pages\poisk Page.xaml"
            this.vperedBtn.Click += new System.Windows.RoutedEventHandler(this.vperedBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

