﻿#pragma checksum "..\..\..\Pages\PR2Page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D7549A0D7DAD098EA74024C4544D72A6207F495CCD9C1EA5BF53B2CCA9F54D06"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FirstAppChupSamozvan.Pages;
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


namespace FirstAppChupSamozvan.Pages {
    
    
    /// <summary>
    /// PR2Page
    /// </summary>
    public partial class PR2Page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Pages\PR2Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtX;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\PR2Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtY;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\PR2Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtSin;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\PR2Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtCos;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Pages\PR2Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtExp;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Pages\PR2Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstResult;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Pages\PR2Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Pages\PR2Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCalc;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Pages\PR2Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClear;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Pages\PR2Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNext;
        
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
            System.Uri resourceLocater = new System.Uri("/FirstAppChupSamozvan;component/pages/pr2page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PR2Page.xaml"
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
            this.txtX = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtY = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.rbtSin = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.rbtCos = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.rbtExp = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.lstResult = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\Pages\PR2Page.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnCalc = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\Pages\PR2Page.xaml"
            this.btnCalc.Click += new System.Windows.RoutedEventHandler(this.btnCalc_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnClear = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\Pages\PR2Page.xaml"
            this.btnClear.Click += new System.Windows.RoutedEventHandler(this.btnClear_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnNext = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\Pages\PR2Page.xaml"
            this.btnNext.Click += new System.Windows.RoutedEventHandler(this.btnNext_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

