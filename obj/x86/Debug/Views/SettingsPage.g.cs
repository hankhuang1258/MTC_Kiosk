﻿#pragma checksum "C:\Cognitive-Samples-IntelligentKiosk-master\Cognitive-Samples-IntelligentKiosk-master\Kiosk\Views\SettingsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9B8FD511FDAB49C0B6355005D96D3600"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligentKioskSample.Views
{
    partial class SettingsPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.commandBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 88 "..\..\..\Views\SettingsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.ResetMallKioskSettingsButtonClick;
                    #line default
                }
                break;
            case 3:
                {
                    this.cameraSourceComboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 76 "..\..\..\Views\SettingsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cameraSourceComboBox).SelectionChanged += this.OnCameraSourceSelectionChanged;
                    #line default
                }
                break;
            case 4:
                {
                    this.MinDetectableFaceSizeSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 45 "..\..\..\Views\SettingsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.OnGenerateNewKeyClicked;
                    #line default
                }
                break;
            case 6:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element6 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 19 "..\..\..\Views\SettingsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element6).Click += this.OnResetSettingsClick;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

