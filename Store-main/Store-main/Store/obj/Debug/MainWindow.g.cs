﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E5F77EEE090D07F329FD0193BBBB602CC17CE08BE259ABF7C3E0CF073A349898"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Store;
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


namespace Store {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 17 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnPrint;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtSearch;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAdd;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClear;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RbUp;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RbDown;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbFiltr;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DtgListProduct;
        
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
            System.Uri resourceLocater = new System.Uri("/Store;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.BtnPrint = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\MainWindow.xaml"
            this.BtnPrint.Click += new System.Windows.RoutedEventHandler(this.BtnPrint_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TxtSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\MainWindow.xaml"
            this.TxtSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\MainWindow.xaml"
            this.BtnAdd.Click += new System.Windows.RoutedEventHandler(this.BtnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnClear = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\MainWindow.xaml"
            this.BtnClear.Click += new System.Windows.RoutedEventHandler(this.BtnClear_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RbUp = ((System.Windows.Controls.RadioButton)(target));
            
            #line 51 "..\..\MainWindow.xaml"
            this.RbUp.Checked += new System.Windows.RoutedEventHandler(this.RbUp_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RbDown = ((System.Windows.Controls.RadioButton)(target));
            
            #line 55 "..\..\MainWindow.xaml"
            this.RbDown.Checked += new System.Windows.RoutedEventHandler(this.RbDown_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CmbFiltr = ((System.Windows.Controls.ComboBox)(target));
            
            #line 62 "..\..\MainWindow.xaml"
            this.CmbFiltr.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbFiltr_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DtgListProduct = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 9:
            
            #line 101 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnEdit_Click);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 107 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnDelete_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

