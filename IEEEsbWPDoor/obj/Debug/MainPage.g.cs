﻿

#pragma checksum "C:\Users\Gregorio\Documents\Repositorios\IEEEsbWPDoor\IEEEsbWPDoor\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1672C1572C842BE43B77CE94158622FD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IEEEsbWPDoor
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 161 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.PairButton_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 166 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.UnpairButton_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 131 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.ComboBox_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 132 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.CheckProfiles_Click;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 137 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.PickSTL_Click;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 143 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.SendSTL_Click;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 114 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.PrinterButton_Click;
                 #line default
                 #line hidden
                break;
            case 8:
                #line 92 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.CreditButton_Click;
                 #line default
                 #line hidden
                break;
            case 9:
                #line 75 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Open_Click;
                 #line default
                 #line hidden
                break;
            case 10:
                #line 177 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.AppBarButton_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

