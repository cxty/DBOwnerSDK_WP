﻿#pragma checksum "E:\workplace\website\dbowner\DBOwner_SDK_WP_Demo\Demo\WP8DBOwnerSDK\WP8DBOwnerSDK\ViewModel\UsersIstimeoutView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "28B5805A14ED4558AB5C741D81035295"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace WP8DBOwnerSDK.ViewModel {
    
    
    public partial class UsersIstimeoutView : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock methodTitle;
        
        internal System.Windows.Controls.HyperlinkButton clickBack;
        
        internal System.Windows.Controls.TextBlock methodName;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.StackPanel chooseMethods;
        
        internal System.Windows.Controls.TextBlock chooseMethod;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/WP8DBOwnerSDK;component/ViewModel/UsersIstimeoutView.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.methodTitle = ((System.Windows.Controls.TextBlock)(this.FindName("methodTitle")));
            this.clickBack = ((System.Windows.Controls.HyperlinkButton)(this.FindName("clickBack")));
            this.methodName = ((System.Windows.Controls.TextBlock)(this.FindName("methodName")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.chooseMethods = ((System.Windows.Controls.StackPanel)(this.FindName("chooseMethods")));
            this.chooseMethod = ((System.Windows.Controls.TextBlock)(this.FindName("chooseMethod")));
        }
    }
}
