﻿#pragma checksum "E:\Repos\myGit\GitHub\blinds52\mobile-AppFilter\mobile-AppFilter\mobile-AppFilter\Views\MasterDetailDetailPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BA9F1654E17A02ED3B4D8D3713024E20"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mobile_AppFilter.Views
{
    partial class MasterDetailDetailPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private static class XamlBindingSetters
        {
            public static void Set_mobile_AppFilter_Views_MasterDetailDetailControl_MasterMenuItem(global::mobile_AppFilter.Views.MasterDetailDetailControl obj, global::mobile_AppFilter.Models.SampleModel value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::mobile_AppFilter.Models.SampleModel) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::mobile_AppFilter.Models.SampleModel), targetNullValue);
                }
                obj.MasterMenuItem = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private class MasterDetailDetailPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMasterDetailDetailPage_Bindings
        {
            private global::mobile_AppFilter.Views.MasterDetailDetailPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::mobile_AppFilter.Views.MasterDetailDetailControl obj3;

            public MasterDetailDetailPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3:
                        this.obj3 = (global::mobile_AppFilter.Views.MasterDetailDetailControl)target;
                        break;
                    default:
                        break;
                }
            }

            // IMasterDetailDetailPage_Bindings

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

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::mobile_AppFilter.Views.MasterDetailDetailPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::mobile_AppFilter.Views.MasterDetailDetailPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Item(obj.Item, phase);
                    }
                }
            }
            private void Update_Item(global::mobile_AppFilter.Models.SampleModel obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_mobile_AppFilter_Views_MasterDetailDetailControl_MasterMenuItem(this.obj3, obj, null);
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
            case 2:
                {
                    this.ContentArea = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.WindowStates = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                    #line 22 "..\..\..\Views\MasterDetailDetailPage.xaml"
                    ((global::Windows.UI.Xaml.VisualStateGroup)this.WindowStates).CurrentStateChanged += this.WindowStates_CurrentStateChanged;
                    #line default
                }
                break;
            case 5:
                {
                    this.WideState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6:
                {
                    this.NarrowState = (global::Windows.UI.Xaml.VisualState)(target);
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
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MasterDetailDetailPage_obj1_Bindings bindings = new MasterDetailDetailPage_obj1_Bindings();
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

