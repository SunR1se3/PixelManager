#pragma checksum "..\..\AdminLogged.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6892371DA5D992C2D418B5B39AA74751886782C7AAA3BCB333CF921DA344EE91"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PixelManager;
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


namespace PixelManager {
    
    
    /// <summary>
    /// AdminLogged
    /// </summary>
    public partial class AdminLogged : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 61 "..\..\AdminLogged.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CB_ChangePage;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\AdminLogged.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CB_DisableService;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\AdminLogged.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BT_DisableService;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\AdminLogged.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WebBrowser Browser;
        
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
            System.Uri resourceLocater = new System.Uri("/PixelManager;component/adminlogged.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminLogged.xaml"
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
            this.CB_ChangePage = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.CB_DisableService = ((System.Windows.Controls.ComboBox)(target));
            
            #line 64 "..\..\AdminLogged.xaml"
            this.CB_DisableService.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CB_DisableService_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BT_DisableService = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\AdminLogged.xaml"
            this.BT_DisableService.Click += new System.Windows.RoutedEventHandler(this.BT_SwitchEnableService_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Browser = ((System.Windows.Controls.WebBrowser)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

