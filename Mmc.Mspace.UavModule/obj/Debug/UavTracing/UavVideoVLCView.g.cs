﻿#pragma checksum "..\..\..\UavTracing\UavVideoVLCView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C3B0B7DCF4E3AD132F428377A04A26EB88987C9D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GFramework.BlankWindow;
using Mmc.Mspace.UavModule;
using Mmc.Mspace.UavModule.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Mmc.Mspace.UavModule {
    
    
    /// <summary>
    /// UavVideoVLCView
    /// </summary>
    public partial class UavVideoVLCView : GFramework.BlankWindow.BlankWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\UavTracing\UavVideoVLCView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TitleName;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\UavTracing\UavVideoVLCView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\UavTracing\UavVideoVLCView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mmc.Mspace.UavModule.Views.SinggleVideoView VideoView;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\UavTracing\UavVideoVLCView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel AIBtnPanel;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\UavTracing\UavVideoVLCView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Mmc.Mspace.UavModule;component/uavtracing/uavvideovlcview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UavTracing\UavVideoVLCView.xaml"
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
            
            #line 10 "..\..\..\UavTracing\UavVideoVLCView.xaml"
            ((Mmc.Mspace.UavModule.UavVideoVLCView)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TitleName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.VideoView = ((Mmc.Mspace.UavModule.Views.SinggleVideoView)(target));
            return;
            case 5:
            this.AIBtnPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.CheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 29 "..\..\..\UavTracing\UavVideoVLCView.xaml"
            this.CheckBox.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_OnChecked);
            
            #line default
            #line hidden
            
            #line 29 "..\..\..\UavTracing\UavVideoVLCView.xaml"
            this.CheckBox.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBox_OnUnchecked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
