﻿#pragma checksum "..\..\Installation.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "274964FD81F183E9D52ED33F1AACB5541066D35E0EAA62B58592426418445119"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DBaInstaller;
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


namespace DBaInstaller {
    
    
    /// <summary>
    /// Installation
    /// </summary>
    public partial class Installation : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\Installation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button continueButton;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Installation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid simpleGrid;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Installation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid PanelGrid;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Installation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_start;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\Installation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_conf;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\Installation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_path;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\Installation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_install;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\Installation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_finish;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\Installation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock status_t;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\Installation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar main_pb;
        
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
            System.Uri resourceLocater = new System.Uri("/DBaInstaller;component/installation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Installation.xaml"
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
            
            #line 11 "..\..\Installation.xaml"
            ((DBaInstaller.Installation)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.continueButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\Installation.xaml"
            this.continueButton.Click += new System.Windows.RoutedEventHandler(this.continueButton_C);
            
            #line default
            #line hidden
            return;
            case 3:
            this.simpleGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.PanelGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.tb_start = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.tb_conf = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.tb_path = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.tb_install = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.tb_finish = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.status_t = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.main_pb = ((System.Windows.Controls.ProgressBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

