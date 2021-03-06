﻿#pragma checksum "E:\Repos\myGit\GitHub\blinds52\mobile-AppFilter\mobile-AppFilter\mobile-AppFilter\Views\SettingsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "41261C6A39C4847685E0467B2F1D4CC1"
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
    partial class SettingsPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_ToggleSwitch_IsOn(global::Windows.UI.Xaml.Controls.ToggleSwitch obj, global::System.Boolean value)
            {
                obj.IsOn = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private class SettingsPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISettingsPage_Bindings
        {
            private global::mobile_AppFilter.Views.SettingsPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;
            private global::Windows.UI.Xaml.Controls.ToggleSwitch obj4;

            private SettingsPage_obj1_BindingsTracking bindingsTracking;

            public SettingsPage_obj1_Bindings()
            {
                this.bindingsTracking = new SettingsPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 4:
                        this.obj4 = (global::Windows.UI.Xaml.Controls.ToggleSwitch)target;
                        break;
                    default:
                        break;
                }
            }

            // ISettingsPage_Bindings

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
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::mobile_AppFilter.Views.SettingsPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::mobile_AppFilter.Views.SettingsPage obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_AppDescription(obj.AppDescription, phase);
                        this.Update_IsLightThemeEnabled(obj.IsLightThemeEnabled, phase);
                    }
                }
            }
            private void Update_AppDescription(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj, null);
                }
            }
            private void Update_IsLightThemeEnabled(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ToggleSwitch_IsOn(this.obj4, obj);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
            private class SettingsPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<SettingsPage_obj1_Bindings> WeakRefToBindingObj; 

                public SettingsPage_obj1_BindingsTracking(SettingsPage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<SettingsPage_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    SettingsPage_obj1_Bindings bindings;
                    if (WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::mobile_AppFilter.Views.SettingsPage obj = sender as global::mobile_AppFilter.Views.SettingsPage;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_AppDescription(obj.AppDescription, DATA_CHANGED);
                                bindings.Update_IsLightThemeEnabled(obj.IsLightThemeEnabled, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "AppDescription":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AppDescription(obj.AppDescription, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsLightThemeEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_IsLightThemeEnabled(obj.IsLightThemeEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::mobile_AppFilter.Views.SettingsPage obj)
                {
                    SettingsPage_obj1_Bindings bindings;
                    if (WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
                        }
                    }
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
                    this.TitlePage = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    global::Windows.UI.Xaml.Controls.ToggleSwitch element4 = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    #line 30 "..\..\..\Views\SettingsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)element4).Toggled += this.ThemeToggle_Toggled;
                    #line default
                }
                break;
            case 5:
                {
                    this.WindowStates = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 6:
                {
                    this.WideState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 7:
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
                    SettingsPage_obj1_Bindings bindings = new SettingsPage_obj1_Bindings();
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

