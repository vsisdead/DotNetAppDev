﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34014
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSocketClient.DemoService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DemoService.IDemoService", CallbackContract=typeof(WebSocketClient.DemoService.IDemoServiceCallback))]
    public interface IDemoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/StartSendingMessages", ReplyAction="http://tempuri.org/IDemoService/StartSendingMessagesResponse")]
        void StartSendingMessages();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/StartSendingMessages", ReplyAction="http://tempuri.org/IDemoService/StartSendingMessagesResponse")]
        System.Threading.Tasks.Task StartSendingMessagesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDemoServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDemoService/SendMessage")]
        void SendMessage(string aMessage);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDemoServiceChannel : WebSocketClient.DemoService.IDemoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DemoServiceClient : System.ServiceModel.DuplexClientBase<WebSocketClient.DemoService.IDemoService>, WebSocketClient.DemoService.IDemoService {
        
        public DemoServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public DemoServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public DemoServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public DemoServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public DemoServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void StartSendingMessages() {
            base.Channel.StartSendingMessages();
        }
        
        public System.Threading.Tasks.Task StartSendingMessagesAsync() {
            return base.Channel.StartSendingMessagesAsync();
        }
    }
}
