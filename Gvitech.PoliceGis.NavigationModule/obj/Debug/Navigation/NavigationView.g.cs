﻿#pragma checksum "..\..\..\Navigation\NavigationView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B1CF6E9ABC8275A24E1AAF259B978074ADCA9BF4111314F82CF1BE8F82FA9CD0"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Mmc.Mspace.NavigationModule.Converter;
using Mmc.Mspace.NavigationModule.Navigation;
using Mmc.Mspace.Services.Controls;
using Mmc.Mspace.Services.PoliceEventService;
using Mmc.Mspace.Theme.Controls;
using Mmc.Wpf.Toolkit.Attached;
using Mmc.Wpf.Toolkit.Controls;
using Mmc.Wpf.Toolkit.Controls.Panels;
using Mmc.Wpf.Toolkit.Controls.Progress;
using Mmc.Wpf.Toolkit.Converters;
using Mmc.Wpf.Toolkit.MarkupExtensions;
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
using System.Windows.Interactivity;
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


namespace Mmc.Mspace.NavigationModule.Navigation {
    
    
    /// <summary>
    /// NavigationView
    /// </summary>
    public partial class NavigationView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 63 "..\..\..\Navigation\NavigationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cb1;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Navigation\NavigationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mmc.Mspace.Theme.Controls.Buttons bs1;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\Navigation\NavigationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb1;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Navigation\NavigationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb2;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Navigation\NavigationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mmc.Mspace.Theme.Controls.Buttons btns;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\..\Navigation\NavigationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox Results;
        
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
            System.Uri resourceLocater = new System.Uri("/Mmc.Mspace.NavigationModule;component/navigation/navigationview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Navigation\NavigationView.xaml"
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
            this.cb1 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 2:
            this.bs1 = ((Mmc.Mspace.Theme.Controls.Buttons)(target));
            return;
            case 3:
            this.tb1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.tb2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.btns = ((Mmc.Mspace.Theme.Controls.Buttons)(target));
            return;
            case 6:
            this.Results = ((System.Windows.Controls.ListBox)(target));
            
            #line 153 "..\..\..\Navigation\NavigationView.xaml"
            this.Results.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Results_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

