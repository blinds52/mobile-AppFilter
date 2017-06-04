﻿#pragma checksum "E:\Repos\myGit\GitHub\blinds52\mobile-AppFilter\mobile-AppFilter\mobile-AppFilter\Views\WebViewPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8C800DCE3DECD588A030D8AB506AB650"
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
    partial class WebViewPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_WebView_Source(global::Windows.UI.Xaml.Controls.WebView obj, global::System.Uri value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Uri) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Uri), targetNullValue);
                }
                obj.Source = value;
            }
        };

        private class WebViewPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IWebViewPage_Bindings
        {
            private global::mobile_AppFilter.Views.WebViewPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.WebView obj2;

            private WebViewPage_obj1_BindingsTracking bindingsTracking;

            public WebViewPage_obj1_Bindings()
            {
                this.bindingsTracking = new WebViewPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Windows.UI.Xaml.Controls.WebView)target;
                        break;
                    default:
                        break;
                }
            }

            // IWebViewPage_Bindings

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

            // WebViewPage_obj1_Bindings

            public void SetDataRoot(global::mobile_AppFilter.Views.WebViewPage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::mobile_AppFilter.Views.WebViewPage obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Source(obj.Source, phase);
                    }
                }
            }
            private void Update_Source(global::System.Uri obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_WebView_Source(this.obj2, obj, null);
                }
            }

            private class WebViewPage_obj1_BindingsTracking
            {
                global::System.WeakReference<WebViewPage_obj1_Bindings> WeakRefToBindingObj; 

                public WebViewPage_obj1_BindingsTracking(WebViewPage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<WebViewPage_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    WebViewPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::mobile_AppFilter.Views.WebViewPage obj = sender as global::mobile_AppFilter.Views.WebViewPage;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_Source(obj.Source, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Source":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Source(obj.Source, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::mobile_AppFilter.Views.WebViewPage obj)
                {
                    WebViewPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
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
                    WebViewPage_obj1_Bindings bindings = new WebViewPage_obj1_Bindings();
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

