﻿#pragma checksum "..\..\..\VideoControl\VideoControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C1AA78C0DB2E2F6CB2E2119E7098B3D908ADAE8B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Mmc.Windows.Framework.Attached;
using Mmc.Windows.Framework.Commands;
using Mmc.Windows.Framework.Controls;
using Mmc.Windows.Framework.Controls.Panels;
using Mmc.Windows.Framework.Controls.Progress;
using Mmc.Windows.Framework.Converters;
using Mmc.Windows.Framework.MarkupExtensions;
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


namespace Mmc.Mspace.ToolModule.VideoControl {
    
    
    /// <summary>
    /// VideoControl
    /// </summary>
    public partial class VideoControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\VideoControl\VideoControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement mediaCtrl;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\VideoControl\VideoControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPlay;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\VideoControl\VideoControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStop;
        
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
            System.Uri resourceLocater = new System.Uri("/Mmc.Mspace.ToolModule;component/videocontrol/videocontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\VideoControl\VideoControl.xaml"
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
            this.mediaCtrl = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 2:
            this.btnPlay = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\VideoControl\VideoControl.xaml"
            this.btnPlay.Click += new System.Windows.RoutedEventHandler(this.btnPlay_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnStop = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\VideoControl\VideoControl.xaml"
            this.btnStop.Click += new System.Windows.RoutedEventHandler(this.btnStop_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
