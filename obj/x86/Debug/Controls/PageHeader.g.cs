﻿#pragma checksum "C:\Cognitive-Samples-IntelligentKiosk-master\Cognitive-Samples-IntelligentKiosk-master\Kiosk\Controls\PageHeader.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5F6D934FDB3FC7C660FD1E205A4FEED2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligentKioskSample.Controls
{
    partial class PageHeader : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Panel_Background(global::Windows.UI.Xaml.Controls.Panel obj, global::Windows.UI.Xaml.Media.Brush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.Brush) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Brush), targetNullValue);
                }
                obj.Background = value;
            }
            public static void Set_Windows_UI_Xaml_FrameworkElement_VerticalAlignment(global::Windows.UI.Xaml.FrameworkElement obj, global::Windows.UI.Xaml.VerticalAlignment value)
            {
                obj.VerticalAlignment = value;
            }
            public static void Set_Windows_UI_Xaml_FrameworkElement_HorizontalAlignment(global::Windows.UI.Xaml.FrameworkElement obj, global::Windows.UI.Xaml.HorizontalAlignment value)
            {
                obj.HorizontalAlignment = value;
            }
            public static void Set_Windows_UI_Xaml_FrameworkElement_Margin(global::Windows.UI.Xaml.FrameworkElement obj, global::Windows.UI.Xaml.Thickness value)
            {
                obj.Margin = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ContentPresenter_Content(global::Windows.UI.Xaml.Controls.ContentPresenter obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Content = value;
            }
        };

        private class PageHeader_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPageHeader_Bindings
        {
            private global::IntelligentKioskSample.Controls.PageHeader dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Grid obj2;
            private global::Windows.UI.Xaml.Controls.ContentPresenter obj4;

            public PageHeader_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Windows.UI.Xaml.Controls.Grid)target;
                        break;
                    case 4:
                        this.obj4 = (global::Windows.UI.Xaml.Controls.ContentPresenter)target;
                        break;
                    default:
                        break;
                }
            }

            // IPageHeader_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // PageHeader_obj1_Bindings

            public void SetDataRoot(global::IntelligentKioskSample.Controls.PageHeader newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::IntelligentKioskSample.Controls.PageHeader obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Background(obj.Background, phase);
                        this.Update_VerticalContentAlignment(obj.VerticalContentAlignment, phase);
                        this.Update_HorizontalContentAlignment(obj.HorizontalContentAlignment, phase);
                        this.Update_Padding(obj.Padding, phase);
                        this.Update_HeaderContent(obj.HeaderContent, phase);
                    }
                }
            }
            private void Update_Background(global::Windows.UI.Xaml.Media.Brush obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Panel_Background(this.obj2, obj, null);
                }
            }
            private void Update_VerticalContentAlignment(global::Windows.UI.Xaml.VerticalAlignment obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_VerticalAlignment(this.obj4, obj);
                }
            }
            private void Update_HorizontalContentAlignment(global::Windows.UI.Xaml.HorizontalAlignment obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_HorizontalAlignment(this.obj4, obj);
                }
            }
            private void Update_Padding(global::Windows.UI.Xaml.Thickness obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Margin(this.obj4, obj);
                }
            }
            private void Update_HeaderContent(global::Windows.UI.Xaml.UIElement obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ContentPresenter_Content(this.obj4, obj, null);
                }
            }
        }
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
                    this.Root = (global::Windows.UI.Xaml.Controls.UserControl)(target);
                }
                break;
            case 2:
                {
                    this.grid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.titleBar = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.content = (global::Windows.UI.Xaml.Controls.ContentPresenter)(target);
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
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    PageHeader_obj1_Bindings bindings = new PageHeader_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

