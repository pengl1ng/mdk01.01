﻿#pragma checksum "..\..\..\Pages\AddEditScientistPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E62E68A26BE49D1055F40E80C2CC9AE9162BFAF24D4477BE45A7202DE5711035"
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
    /// AddEditScientistPage
    /// </summary>
    public partial class AddEditScientistPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Pages\AddEditScientistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tboxScFIO;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\AddEditScientistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tboxScDeg;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\AddEditScientistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tboxScCountry;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\AddEditScientistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tboxScOrg;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Pages\AddEditScientistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Pages\AddEditScientistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGoBack;
        
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
            System.Uri resourceLocater = new System.Uri("/ScientistsApp;component/pages/addeditscientistpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AddEditScientistPage.xaml"
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
            this.tboxScFIO = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tboxScDeg = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tboxScCountry = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tboxScOrg = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Pages\AddEditScientistPage.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnGoBack = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Pages\AddEditScientistPage.xaml"
            this.btnGoBack.Click += new System.Windows.RoutedEventHandler(this.btnGoBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
