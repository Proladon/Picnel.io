﻿#pragma checksum "..\..\..\User_Control\Folder_Control.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "81618BA09CEEE95B3B5BC949E0B91EC0951091D7B1F15B577872929DE6781186"
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

using Image_Classifier.User_Control;
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


namespace Image_Classifier.User_Control {
    
    
    /// <summary>
    /// Folder_Control
    /// </summary>
    public partial class Folder_Control : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\User_Control\Folder_Control.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label folderPath;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\User_Control\Folder_Control.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label colorTag;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\User_Control\Folder_Control.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label akaLabel;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\User_Control\Folder_Control.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button moveTo_Btn;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\User_Control\Folder_Control.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button copyTo_Btn;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\User_Control\Folder_Control.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delete_Btn;
        
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
            System.Uri resourceLocater = new System.Uri("/Image_Classifier;component/user_control/folder_control.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\User_Control\Folder_Control.xaml"
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
            this.folderPath = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.colorTag = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.akaLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.moveTo_Btn = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.copyTo_Btn = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.delete_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\User_Control\Folder_Control.xaml"
            this.delete_Btn.Click += new System.Windows.RoutedEventHandler(this.delete_Btn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

