﻿#pragma checksum "..\..\..\..\..\MVVM\View\SettingsView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4B5064EAAD9AF36D91D6FD8E5209D8F9835D4308"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SPZ_Project.MVVM.View;
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


namespace SPZ_Project.MVVM.View {
    
    
    /// <summary>
    /// SettingsView
    /// </summary>
    public partial class SettingsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 51 "..\..\..\..\..\MVVM\View\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox LangComboBox;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\..\MVVM\View\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button IsWFRInstalledButton;
        
        #line default
        #line hidden
        
        
        #line 780 "..\..\..\..\..\MVVM\View\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenDocButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SPZ-Project;component/mvvm/view/settingsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\MVVM\View\SettingsView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LangComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 51 "..\..\..\..\..\MVVM\View\SettingsView.xaml"
            this.LangComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.IsWFRInstalledButton = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\..\..\MVVM\View\SettingsView.xaml"
            this.IsWFRInstalledButton.Click += new System.Windows.RoutedEventHandler(this.IsWFRInstalledButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.OpenDocButton = ((System.Windows.Controls.Button)(target));
            
            #line 780 "..\..\..\..\..\MVVM\View\SettingsView.xaml"
            this.OpenDocButton.Click += new System.Windows.RoutedEventHandler(this.OpenDocButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

