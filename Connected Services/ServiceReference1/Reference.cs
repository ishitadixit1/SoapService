﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.InterfaceSimplifier")]
    public interface InterfaceSimplifier
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceSimplifier/SetNumbers", ReplyAction="http://tempuri.org/InterfaceSimplifier/SetNumbersResponse")]
        void SetNumbers(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceSimplifier/SetNumbers", ReplyAction="http://tempuri.org/InterfaceSimplifier/SetNumbersResponse")]
        System.Threading.Tasks.Task SetNumbersAsync(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceSimplifier/DoAddition", ReplyAction="http://tempuri.org/InterfaceSimplifier/DoAdditionResponse")]
        double DoAddition(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceSimplifier/DoAddition", ReplyAction="http://tempuri.org/InterfaceSimplifier/DoAdditionResponse")]
        System.Threading.Tasks.Task<double> DoAdditionAsync(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceSimplifier/DoSubtraction", ReplyAction="http://tempuri.org/InterfaceSimplifier/DoSubtractionResponse")]
        double DoSubtraction(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceSimplifier/DoSubtraction", ReplyAction="http://tempuri.org/InterfaceSimplifier/DoSubtractionResponse")]
        System.Threading.Tasks.Task<double> DoSubtractionAsync(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceSimplifier/DoMultiplication", ReplyAction="http://tempuri.org/InterfaceSimplifier/DoMultiplicationResponse")]
        double DoMultiplication(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceSimplifier/DoMultiplication", ReplyAction="http://tempuri.org/InterfaceSimplifier/DoMultiplicationResponse")]
        System.Threading.Tasks.Task<double> DoMultiplicationAsync(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceSimplifier/DoDivision", ReplyAction="http://tempuri.org/InterfaceSimplifier/DoDivisionResponse")]
        double DoDivision(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceSimplifier/DoDivision", ReplyAction="http://tempuri.org/InterfaceSimplifier/DoDivisionResponse")]
        System.Threading.Tasks.Task<double> DoDivisionAsync(double number1, double number2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface InterfaceSimplifierChannel : ServiceReference1.InterfaceSimplifier, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class InterfaceSimplifierClient : System.ServiceModel.ClientBase<ServiceReference1.InterfaceSimplifier>, ServiceReference1.InterfaceSimplifier
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public InterfaceSimplifierClient() : 
                base(InterfaceSimplifierClient.GetDefaultBinding(), InterfaceSimplifierClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_InterfaceSimplifier.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InterfaceSimplifierClient(EndpointConfiguration endpointConfiguration) : 
                base(InterfaceSimplifierClient.GetBindingForEndpoint(endpointConfiguration), InterfaceSimplifierClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InterfaceSimplifierClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(InterfaceSimplifierClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InterfaceSimplifierClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(InterfaceSimplifierClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InterfaceSimplifierClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public void SetNumbers(double number1, double number2)
        {
            base.Channel.SetNumbers(number1, number2);
        }
        
        public System.Threading.Tasks.Task SetNumbersAsync(double number1, double number2)
        {
            return base.Channel.SetNumbersAsync(number1, number2);
        }
        
        public double DoAddition(double number1, double number2)
        {
            return base.Channel.DoAddition(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> DoAdditionAsync(double number1, double number2)
        {
            return base.Channel.DoAdditionAsync(number1, number2);
        }
        
        public double DoSubtraction(double number1, double number2)
        {
            return base.Channel.DoSubtraction(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> DoSubtractionAsync(double number1, double number2)
        {
            return base.Channel.DoSubtractionAsync(number1, number2);
        }
        
        public double DoMultiplication(double number1, double number2)
        {
            return base.Channel.DoMultiplication(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> DoMultiplicationAsync(double number1, double number2)
        {
            return base.Channel.DoMultiplicationAsync(number1, number2);
        }
        
        public double DoDivision(double number1, double number2)
        {
            return base.Channel.DoDivision(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> DoDivisionAsync(double number1, double number2)
        {
            return base.Channel.DoDivisionAsync(number1, number2);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_InterfaceSimplifier))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_InterfaceSimplifier))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:7005/Simplifier.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return InterfaceSimplifierClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_InterfaceSimplifier);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return InterfaceSimplifierClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_InterfaceSimplifier);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_InterfaceSimplifier,
        }
    }
}