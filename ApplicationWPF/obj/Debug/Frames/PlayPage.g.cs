#pragma checksum "..\..\..\Frames\PlayPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C52A6F875E8BDDA7E2324F745E208398"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using ApplicationWPF.UserControls;
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


namespace ApplicationWPF.Frames {
    
    
    /// <summary>
    /// PlayPage
    /// </summary>
    public partial class PlayPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Frames\PlayPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ApplicationWPF.UserControls.PlayChoice usrSolo;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Frames\PlayPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ApplicationWPF.UserControls.PlayChoice usrMulti;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Frames\PlayPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ApplicationWPF.UserControls.PlayChoice usrPariSolo;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Frames\PlayPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ApplicationWPF.UserControls.PlayChoice usrPariMulti;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Frames\PlayPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ApplicationWPF.UserControls.ComboBoxTournoi usrCtrlTournoiCombo;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Frames\PlayPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox tournamentDetails;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Frames\PlayPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame ModeChoice;
        
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
            System.Uri resourceLocater = new System.Uri("/ApplicationWPF;component/frames/playpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Frames\PlayPage.xaml"
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
            
            #line 9 "..\..\..\Frames\PlayPage.xaml"
            ((ApplicationWPF.Frames.PlayPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.WindowLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.usrSolo = ((ApplicationWPF.UserControls.PlayChoice)(target));
            return;
            case 3:
            this.usrMulti = ((ApplicationWPF.UserControls.PlayChoice)(target));
            return;
            case 4:
            this.usrPariSolo = ((ApplicationWPF.UserControls.PlayChoice)(target));
            return;
            case 5:
            this.usrPariMulti = ((ApplicationWPF.UserControls.PlayChoice)(target));
            return;
            case 6:
            this.usrCtrlTournoiCombo = ((ApplicationWPF.UserControls.ComboBoxTournoi)(target));
            return;
            case 7:
            this.tournamentDetails = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.ModeChoice = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

