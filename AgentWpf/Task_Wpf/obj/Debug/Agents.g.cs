#pragma checksum "..\..\Agents.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "87B42F3AAFD838F7034D9DB54514D9E636AECF83C073ECA4A645F50136CAC5C1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using Task_Wpf;


namespace Task_Wpf {
    
    
    /// <summary>
    /// Agents
    /// </summary>
    public partial class Agents : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 76 "..\..\Agents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox poisk;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\Agents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Filter;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\Agents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Type;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\Agents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid agentTable;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\Agents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock full;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\Agents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\Agents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Paging;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\Agents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button forward;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\Agents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updateButton;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\Agents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Task_Wpf;component/agents.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Agents.xaml"
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
            this.poisk = ((System.Windows.Controls.TextBox)(target));
            
            #line 76 "..\..\Agents.xaml"
            this.poisk.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.poisk_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Filter = ((System.Windows.Controls.ComboBox)(target));
            
            #line 77 "..\..\Agents.xaml"
            this.Filter.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Filter_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Type = ((System.Windows.Controls.ComboBox)(target));
            
            #line 94 "..\..\Agents.xaml"
            this.Type.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Type_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.agentTable = ((System.Windows.Controls.DataGrid)(target));
            
            #line 103 "..\..\Agents.xaml"
            this.agentTable.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.agentTable_LoadingRow);
            
            #line default
            #line hidden
            
            #line 103 "..\..\Agents.xaml"
            this.agentTable.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.agentTable_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.full = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 125 "..\..\Agents.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Paging = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.forward = ((System.Windows.Controls.Button)(target));
            
            #line 127 "..\..\Agents.xaml"
            this.forward.Click += new System.Windows.RoutedEventHandler(this.forward_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.updateButton = ((System.Windows.Controls.Button)(target));
            
            #line 139 "..\..\Agents.xaml"
            this.updateButton.Click += new System.Windows.RoutedEventHandler(this.updateButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.addButton = ((System.Windows.Controls.Button)(target));
            
            #line 140 "..\..\Agents.xaml"
            this.addButton.Click += new System.Windows.RoutedEventHandler(this.addButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

