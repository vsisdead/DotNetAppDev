﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.18034
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// Этот исходный код был создан с помощью wsdl, версия=4.0.30319.17929.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="SimpleWebServiveSoap", Namespace="http://tempuri.org/")]
public partial class SimpleWebServive : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback SqrtWebMethodOperationCompleted;
    
    /// <remarks/>
    public SimpleWebServive() {
        this.Url = "http://localhost:19753/SimpleMathService.asmx";
    }
    
    /// <remarks/>
    public event SqrtWebMethodCompletedEventHandler SqrtWebMethodCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SqrtWebMethod", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public string SqrtWebMethod(int anInt) {
        object[] results = this.Invoke("SqrtWebMethod", new object[] {
                    anInt});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginSqrtWebMethod(int anInt, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("SqrtWebMethod", new object[] {
                    anInt}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndSqrtWebMethod(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void SqrtWebMethodAsync(int anInt) {
        this.SqrtWebMethodAsync(anInt, null);
    }
    
    /// <remarks/>
    public void SqrtWebMethodAsync(int anInt, object userState) {
        if ((this.SqrtWebMethodOperationCompleted == null)) {
            this.SqrtWebMethodOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSqrtWebMethodOperationCompleted);
        }
        this.InvokeAsync("SqrtWebMethod", new object[] {
                    anInt}, this.SqrtWebMethodOperationCompleted, userState);
    }
    
    private void OnSqrtWebMethodOperationCompleted(object arg) {
        if ((this.SqrtWebMethodCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.SqrtWebMethodCompleted(this, new SqrtWebMethodCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void SqrtWebMethodCompletedEventHandler(object sender, SqrtWebMethodCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class SqrtWebMethodCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal SqrtWebMethodCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public string Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}
