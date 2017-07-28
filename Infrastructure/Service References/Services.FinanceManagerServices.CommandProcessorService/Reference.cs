﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infrastructure.Services.FinanceManagerServices.CommandProcessorService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Services.FinanceManagerServices.CommandProcessorService.FinanceManagerCommandProc" +
        "essor")]
    public interface FinanceManagerCommandProcessor {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FinanceManagerCommandProcessor/Submit", ReplyAction="http://tempuri.org/FinanceManagerCommandProcessor/SubmitResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValueObjects.Wcf.MyValidator), Action="http://tempuri.org/FinanceManagerCommandProcessor/SubmitMyValidatorFault", Name="MyValidator", Namespace="http://schemas.datacontract.org/2004/07/ValueObjects.Wcf")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValueObjects.Wcf.MyConcurrencyIndicator), Action="http://tempuri.org/FinanceManagerCommandProcessor/SubmitMyConcurrencyIndicatorFau" +
            "lt", Name="MyConcurrencyIndicator", Namespace="http://schemas.datacontract.org/2004/07/ValueObjects.Wcf")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FinanceManager.Contract.Queries.FindFinancialTransactionsByDateQuery))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FinanceManager.Contract.Queries.FindFinancialAccountsBySearchTextQuery))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FinanceManager.Contract.Queries.GetAllFinancialAccountsQuery))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FinanceManager.Contract.Queries.GetFinancialAccountBalanceQuery))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FinanceManager.Contract.Queries.GetFinancialTransactionByIdQuery))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FinanceManager.Contract.Queries.GetFinancialTransactionsByAccountIdQuery))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FinanceManager.Contract.Queries.GetFinancialAccountByIdQuery))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FinanceManager.Contract.Events.FinancialTransactionChangedEvent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FinanceManager.Contract.Events.FinancialAccountChangedEvent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FinanceManager.Contract.Events.FinancialTransactionRemovedEvent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FinanceManager.Contract.Events.FinancialTransactionAddedEvent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FinanceManager.Contract.Events.FinancialAccountAddedEvent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FinanceManager.Contract.Events.FinancialAccountRemovedEvent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FinanceManager.Contract.Dto.FinancialAccountDto))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FinanceManager.Contract.Dto.FinancialTransactionDto))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ValueObjects.Finance.Money))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ValueObjects.Finance.TransactionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FinanceManager.Contract.Commands.AddFinancialTransactionCommand))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FinanceManager.Contract.Commands.AddFinancialAccountCommand))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FinanceManager.Contract.Commands.RemoveFinancialTransactionCommand))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FinanceManager.Contract.Commands.RemoveFinancialAccountCommand))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FinanceManager.Contract.Commands.UpdateFinancialTransactionCommand))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FinanceManager.Contract.Commands.UpdateFinancialAccountCommand))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ValueObjects.Wcf.MyValidator))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ValueObjects.Wcf.MyValidationFailure[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ValueObjects.Wcf.MyValidationFailure))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ValueObjects.Wcf.MyConcurrencyIndicator))]
        void Submit(object command);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FinanceManagerCommandProcessor/Submit", ReplyAction="http://tempuri.org/FinanceManagerCommandProcessor/SubmitResponse")]
        System.Threading.Tasks.Task SubmitAsync(object command);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FinanceManagerCommandProcessorChannel : Infrastructure.Services.FinanceManagerServices.CommandProcessorService.FinanceManagerCommandProcessor, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FinanceManagerCommandProcessorClient : System.ServiceModel.ClientBase<Infrastructure.Services.FinanceManagerServices.CommandProcessorService.FinanceManagerCommandProcessor>, Infrastructure.Services.FinanceManagerServices.CommandProcessorService.FinanceManagerCommandProcessor {
        
        public FinanceManagerCommandProcessorClient() {
        }
        
        public FinanceManagerCommandProcessorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FinanceManagerCommandProcessorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FinanceManagerCommandProcessorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FinanceManagerCommandProcessorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Submit(object command) {
            base.Channel.Submit(command);
        }
        
        public System.Threading.Tasks.Task SubmitAsync(object command) {
            return base.Channel.SubmitAsync(command);
        }
    }
}