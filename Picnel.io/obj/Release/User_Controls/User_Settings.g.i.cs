﻿#pragma checksum "..\..\..\User_Controls\User_Settings.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DF37BDF5B66FF2250298E135DC126248116EEDAC87063E749A1445D05F0336E6"
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

using Picnel.io.User_Controls;
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


namespace Picnel.io.User_Controls {
    
    
    /// <summary>
    /// User_Settings
    /// </summary>
    public partial class User_Settings : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\User_Controls\User_Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ui;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\User_Controls\User_Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logger;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\User_Controls\User_Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button gif_viewer;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\User_Controls\User_Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button image_viewer;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\User_Controls\User_Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid settings_frame;
        
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
            System.Uri resourceLocater = new System.Uri("/Picnel.io;component/user_controls/user_settings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\User_Controls\User_Settings.xaml"
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
            
            #line 8 "..\..\..\User_Controls\User_Settings.xaml"
            ((Picnel.io.User_Controls.User_Settings)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.UserControl_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ui = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.logger = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\User_Controls\User_Settings.xaml"
            this.logger.Click += new System.Windows.RoutedEventHandler(this.logger_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.gif_viewer = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\User_Controls\User_Settings.xaml"
            this.gif_viewer.Click += new System.Windows.RoutedEventHandler(this.gif_viewer_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.image_viewer = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\User_Controls\User_Settings.xaml"
            this.image_viewer.Click += new System.Windows.RoutedEventHandler(this.image_viewer_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.settings_frame = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            
            #line 49 "..\..\..\User_Controls\User_Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Apply_Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 50 "..\..\..\User_Controls\User_Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

