﻿#pragma checksum "..\..\..\PathSelection.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E3D6A37867E53EEB1D496221EDA6E2DA1AB16E93"
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
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
    /// PathSelection
    /// </summary>
    public partial class PathSelection : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\PathSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid simpleGrid;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\PathSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid PanelGrid;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\PathSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_start;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\PathSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_conf;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\PathSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_path;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\PathSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_install;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\PathSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_finish;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\PathSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_Pass;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\PathSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox login_tb;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\PathSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pass_tb;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\PathSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox createLink_cb;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ZRDB Installer;component/pathselection.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PathSelection.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\..\PathSelection.xaml"
            ((DBaInstaller.PathSelection)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 23 "..\..\..\PathSelection.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.continueButton_C);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 31 "..\..\..\PathSelection.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.returnButton_C);
            
            #line default
            #line hidden
            return;
            case 4:
            this.simpleGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.PanelGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.tb_start = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.tb_conf = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.tb_path = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.tb_install = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.tb_finish = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            
            #line 111 "..\..\..\PathSelection.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.selectPathButton_C);
            
            #line default
            #line hidden
            return;
            case 12:
            this.textBox_Pass = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            
            #line 115 "..\..\..\PathSelection.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.generatePassButton_C);
            
            #line default
            #line hidden
            return;
            case 14:
            this.login_tb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.pass_tb = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 16:
            this.createLink_cb = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

