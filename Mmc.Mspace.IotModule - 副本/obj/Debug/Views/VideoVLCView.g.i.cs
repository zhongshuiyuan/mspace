﻿#pragma checksum "..\..\..\Views\VideoVLCView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5DAB5ABA5A105DCB08A328352CEDE5E5E93188B2"
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
using Mmc.Mspace.IotModule.Views;
using Mmc.Mspace.Theme.Controls;
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


namespace Mmc.Mspace.IotModule.Views {
    
    
    /// <summary>
    /// VideoVLCView
    /// </summary>
    public partial class VideoVLCView : GFramework.BlankWindow.BlankWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Views\VideoVLCView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TitleName;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\VideoVLCView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Views\VideoVLCView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mmc.Mspace.IotModule.Views.SinggleVideoView _streamPlayControl;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Views\VideoVLCView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _urlTextBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Views\VideoVLCView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _statusLabel;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Views\VideoVLCView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mmc.Mspace.Theme.Controls.Buttons _playButton;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Views\VideoVLCView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mmc.Mspace.Theme.Controls.Buttons _stopButton;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Views\VideoVLCView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mmc.Mspace.Theme.Controls.Buttons _imageButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Mmc.Mspace.IotModule;component/views/videovlcview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\VideoVLCView.xaml"
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
            
            #line 11 "..\..\..\Views\VideoVLCView.xaml"
            ((Mmc.Mspace.IotModule.Views.VideoVLCView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.windowLoaded);
            
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
            this._streamPlayControl = ((Mmc.Mspace.IotModule.Views.SinggleVideoView)(target));
            return;
            case 5:
            this._urlTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this._statusLabel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this._playButton = ((Mmc.Mspace.Theme.Controls.Buttons)(target));
            
            #line 41 "..\..\..\Views\VideoVLCView.xaml"
            this._playButton.Click += new System.Windows.RoutedEventHandler(this.HandlePlayButtonClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this._stopButton = ((Mmc.Mspace.Theme.Controls.Buttons)(target));
            
            #line 42 "..\..\..\Views\VideoVLCView.xaml"
            this._stopButton.Click += new System.Windows.RoutedEventHandler(this.HandleStopButtonClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this._imageButton = ((Mmc.Mspace.Theme.Controls.Buttons)(target));
            
            #line 43 "..\..\..\Views\VideoVLCView.xaml"
            this._imageButton.Click += new System.Windows.RoutedEventHandler(this.HandleImageButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

