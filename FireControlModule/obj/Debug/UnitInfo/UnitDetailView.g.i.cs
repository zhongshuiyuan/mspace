﻿#pragma checksum "..\..\..\UnitInfo\UnitDetailView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "480D2A3BC9FD75486EF0E0D0C8422A2F738469ED5223838D17613CC7971384C4"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using FireControlModule;
using Mmc.Mspace.Services.Controls;
using Mmc.Mspace.Services.PoliceEventService;
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


namespace FireControlModule {
    
    
    /// <summary>
    /// UnitDetailView
    /// </summary>
    public partial class UnitDetailView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 73 "..\..\..\UnitInfo\UnitDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mmc.Wpf.Toolkit.Controls.SimpleIconButton buildDetialBtn;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\UnitInfo\UnitDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mmc.Wpf.Toolkit.Controls.SimpleIconButton unitBaseBtn;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\UnitInfo\UnitDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mmc.Wpf.Toolkit.Controls.SimpleIconButton UnitProblemBtn;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\UnitInfo\UnitDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mmc.Wpf.Toolkit.Controls.SimpleIconButton UnitVideoBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/FireControlModule;component/unitinfo/unitdetailview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UnitInfo\UnitDetailView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 16 "..\..\..\UnitInfo\UnitDetailView.xaml"
            ((FireControlModule.UnitDetailView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 20 "..\..\..\UnitInfo\UnitDetailView.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.UIElement_OnPreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buildDetialBtn = ((Mmc.Wpf.Toolkit.Controls.SimpleIconButton)(target));
            return;
            case 4:
            this.unitBaseBtn = ((Mmc.Wpf.Toolkit.Controls.SimpleIconButton)(target));
            return;
            case 5:
            this.UnitProblemBtn = ((Mmc.Wpf.Toolkit.Controls.SimpleIconButton)(target));
            return;
            case 6:
            this.UnitVideoBtn = ((Mmc.Wpf.Toolkit.Controls.SimpleIconButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

