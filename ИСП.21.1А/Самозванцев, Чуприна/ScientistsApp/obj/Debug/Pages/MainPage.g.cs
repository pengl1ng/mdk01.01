﻿#pragma checksum "..\..\..\Pages\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0A4A27318B1976D4B1A52C1D652586B1CC6096FDA7E8670BE4FBA4D9F21BA631"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ScientistsApp.Pages;
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


namespace ScientistsApp.Pages {
    
    
    /// <summary>
    /// MainPage
    /// </summary>
    public partial class MainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tboxSearch;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboxConf;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboxOrg;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDel;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRef;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChangeRep;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChangeSci;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChangeConf;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgScientists;
        
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
            System.Uri resourceLocater = new System.Uri("/ScientistsApp;component/pages/mainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\MainPage.xaml"
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
            this.tboxSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\Pages\MainPage.xaml"
            this.tboxSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tboxSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cboxConf = ((System.Windows.Controls.ComboBox)(target));
            
            #line 33 "..\..\..\Pages\MainPage.xaml"
            this.cboxConf.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboxConf_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cboxOrg = ((System.Windows.Controls.ComboBox)(target));
            
            #line 37 "..\..\..\Pages\MainPage.xaml"
            this.cboxOrg.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboxOrg_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Pages\MainPage.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnDel = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\Pages\MainPage.xaml"
            this.btnDel.Click += new System.Windows.RoutedEventHandler(this.btnDel_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnRef = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\Pages\MainPage.xaml"
            this.btnRef.Click += new System.Windows.RoutedEventHandler(this.btnRef_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnChangeRep = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\Pages\MainPage.xaml"
            this.btnChangeRep.Click += new System.Windows.RoutedEventHandler(this.btnChangeRep_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnChangeSci = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\Pages\MainPage.xaml"
            this.btnChangeSci.Click += new System.Windows.RoutedEventHandler(this.btnChangeSci_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnChangeConf = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\Pages\MainPage.xaml"
            this.btnChangeConf.Click += new System.Windows.RoutedEventHandler(this.btnChangeConf_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.dgScientists = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

