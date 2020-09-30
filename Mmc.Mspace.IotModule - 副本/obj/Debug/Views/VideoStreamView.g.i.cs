﻿#pragma checksum "..\..\..\Views\VideoStreamView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87EBFD10F9DD99ADC46B35502A9C6AD1412EC035"
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
using WebEye.Controls.Wpf.StreamPlayerControl;


namespace Mmc.Mspace.IotModule.Views {
    
    
    /// <summary>
    /// VideoStreamView
    /// </summary>
    public partial class VideoStreamView : GFramework.BlankWindow.BlankWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Views\VideoStreamView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TitleName;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Views\VideoStreamView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Views\VideoStreamView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WebEye.Controls.Wpf.StreamPlayerControl.StreamPlayerControl _streamPlayerControl;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Views\VideoStreamView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _urlTextBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Views\VideoStreamView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _statusLabel;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Views\VideoStreamView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mmc.Mspace.Theme.Controls.Buttons _playButton;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Views\VideoStreamView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mmc.Mspace.Theme.Controls.Buttons _stopButton;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Views\VideoStreamView.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Mmc.Mspace.IotModule;component/views/videostreamview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\VideoStreamView.xaml"
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
            this.TitleName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this._streamPlayerControl = ((WebEye.Controls.Wpf.StreamPlayerControl.StreamPlayerControl)(target));
            
            #line 26 "..\..\..\Views\VideoStreamView.xaml"
            this._streamPlayerControl.StreamFailed += new WebEye.Controls.Wpf.StreamPlayerControl.StreamPlayerControl.StreamFailedEventHandler(this.HandlePlayerEvent);
            
            #line default
            #line hidden
            
            #line 27 "..\..\..\Views\VideoStreamView.xaml"
            this._streamPlayerControl.StreamStarted += new System.Windows.RoutedEventHandler(this.HandlePlayerEvent);
            
            #line default
            #line hidden
            
            #line 28 "..\..\..\Views\VideoStreamView.xaml"
            this._streamPlayerControl.StreamStopped += new System.Windows.RoutedEventHandler(this.HandlePlayerEvent);
            
            #line default
            #line hidden
            return;
            case 4:
            this._urlTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this._statusLabel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this._playButton = ((Mmc.Mspace.Theme.Controls.Buttons)(target));
            
            #line 41 "..\..\..\Views\VideoStreamView.xaml"
            this._playButton.Click += new System.Windows.RoutedEventHandler(this.HandlePlayButtonClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this._stopButton = ((Mmc.Mspace.Theme.Controls.Buttons)(target));
            
            #line 42 "..\..\..\Views\VideoStreamView.xaml"
            this._stopButton.Click += new System.Windows.RoutedEventHandler(this.HandleStopButtonClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this._imageButton = ((Mmc.Mspace.Theme.Controls.Buttons)(target));
            
            #line 43 "..\..\..\Views\VideoStreamView.xaml"
            this._imageButton.Click += new System.Windows.RoutedEventHandler(this.HandleImageButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

