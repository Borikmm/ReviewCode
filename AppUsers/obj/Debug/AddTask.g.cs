// Updated by XamlIntelliSenseFileGenerator 04.06.2024 11:41:01
#pragma checksum "..\..\AddTask.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FE26FCA0BE36DDEC2668B4F1B8EA717D8DABF88E149EF6142237A4E102250468"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AppUsers;
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


namespace AppUsers
{


    /// <summary>
    /// AddTask
    /// </summary>
    public partial class AddTask : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 30 "..\..\AddTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSave;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AppUsers;component/addtask.xaml", System.UriKind.Relative);

#line 1 "..\..\AddTask.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Groups = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 2:
                    this.nameSubject = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 3:
                    this.nameTeacher = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 4:
                    this.Hours = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.BtnSave = ((System.Windows.Controls.Button)(target));

#line 30 "..\..\AddTask.xaml"
                    this.BtnSave.Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBlock one;
        internal System.Windows.Controls.TextBlock two;
        internal System.Windows.Controls.TextBlock three;
        internal System.Windows.Controls.TextBlock forr;
        internal System.Windows.Controls.TextBox one_input;
        internal System.Windows.Controls.TextBox two_input;
        internal System.Windows.Controls.TextBox three_input;
        internal System.Windows.Controls.TextBox for_input;
    }
}

