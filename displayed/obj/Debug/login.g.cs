﻿#pragma checksum "..\..\login.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C42C574994CCF0F8CCBA7F5DF378F2BB7CE058ED7E19FA97BD861AA7E4AC1382"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using displayed;


namespace displayed {
    
    
    /// <summary>
    /// login
    /// </summary>
    public partial class login : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label headerLoging;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loginAcount;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ResetPassword;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Signin;
        
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
            System.Uri resourceLocater = new System.Uri("/displayed;component/login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\login.xaml"
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
            this.headerLoging = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.loginAcount = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\login.xaml"
            this.loginAcount.Click += new System.Windows.RoutedEventHandler(this.loginAcount_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ResetPassword = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\login.xaml"
            this.ResetPassword.Click += new System.Windows.RoutedEventHandler(this.ResetPassword_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Signin = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\login.xaml"
            this.Signin.Click += new System.Windows.RoutedEventHandler(this.Signin_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
