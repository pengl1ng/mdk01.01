﻿#pragma checksum "..\..\..\Pages\LibraryCard.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E54CED74DAECB1E8655F72B1E8D4DD251EA3C9C325036EF217FC0CEBA5A79FB4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LibraryApp1.Pages;
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


namespace LibraryApp1.Pages {
    
    
    /// <summary>
    /// LibraryCard
    /// </summary>
    public partial class LibraryCard : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\Pages\LibraryCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tboxSearch;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\LibraryCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboxConf;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\LibraryCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClearFilters;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Pages\LibraryCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Pages\LibraryCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDel;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pages\LibraryCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRef;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Pages\LibraryCard.xaml"
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
            System.Uri resourceLocater = new System.Uri("/LibraryApp1;component/pages/librarycard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\LibraryCard.xaml"
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
            
            #line 29 "..\..\..\Pages\LibraryCard.xaml"
            this.tboxSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tboxSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cboxConf = ((System.Windows.Controls.ComboBox)(target));
            
            #line 37 "..\..\..\Pages\LibraryCard.xaml"
            this.cboxConf.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboxConf_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnClearFilters = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Pages\LibraryCard.xaml"
            this.btnClearFilters.Click += new System.Windows.RoutedEventHandler(this.btnClearFilters_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Pages\LibraryCard.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnDel = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Pages\LibraryCard.xaml"
            this.btnDel.Click += new System.Windows.RoutedEventHandler(this.btnDel_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnRef = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\Pages\LibraryCard.xaml"
            this.btnRef.Click += new System.Windows.RoutedEventHandler(this.btnRef_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnNext = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\Pages\LibraryCard.xaml"
            this.btnNext.Click += new System.Windows.RoutedEventHandler(this.btnNext_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

