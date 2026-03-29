//HintName: G.ICallsClient.CallControllerCreate.g.cs
#nullable enable

namespace G
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Create Call
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OneOf<global::G.Call, global::G.CallBatchResponse>> CallControllerCreateAsync(

            global::G.CreateCallDTO request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Call
        /// </summary>
        /// <param name="customers">
        /// This is used to issue batch calls to multiple customers.<br/>
        /// Only relevant for `outboundPhoneCall`. To call a single customer, use `customer` instead.
        /// </param>
        /// <param name="name">
        /// This is the name of the call. This is just for your own reference.
        /// </param>
        /// <param name="schedulePlan">
        /// This is the schedule plan of the call.
        /// </param>
        /// <param name="transport">
        /// This is the transport of the call.
        /// </param>
        /// <param name="assistantId">
        /// This is the assistant ID that will be used for the call. To use a transient assistant, use `assistant` instead.<br/>
        /// To start a call with:<br/>
        /// - Assistant, use `assistantId` or `assistant`<br/>
        /// - Squad, use `squadId` or `squad`<br/>
        /// - Workflow, use `workflowId` or `workflow`
        /// </param>
        /// <param name="assistant">
        /// This is the assistant that will be used for the call. To use an existing assistant, use `assistantId` instead.<br/>
        /// To start a call with:<br/>
        /// - Assistant, use `assistant`<br/>
        /// - Squad, use `squad`<br/>
        /// - Workflow, use `workflow`
        /// </param>
        /// <param name="assistantOverrides">
        /// These are the overrides for the `assistant` or `assistantId`'s settings and template variables.
        /// </param>
        /// <param name="squadId">
        /// This is the squad that will be used for the call. To use a transient squad, use `squad` instead.<br/>
        /// To start a call with:<br/>
        /// - Assistant, use `assistant` or `assistantId`<br/>
        /// - Squad, use `squad` or `squadId`<br/>
        /// - Workflow, use `workflow` or `workflowId`
        /// </param>
        /// <param name="squad">
        /// This is a squad that will be used for the call. To use an existing squad, use `squadId` instead.<br/>
        /// To start a call with:<br/>
        /// - Assistant, use `assistant` or `assistantId`<br/>
        /// - Squad, use `squad` or `squadId`<br/>
        /// - Workflow, use `workflow` or `workflowId`
        /// </param>
        /// <param name="squadOverrides">
        /// These are the overrides for the `squad` or `squadId`'s member settings and template variables.<br/>
        /// This will apply to all members of the squad.
        /// </param>
        /// <param name="workflowId">
        /// This is the workflow that will be used for the call. To use a transient workflow, use `workflow` instead.<br/>
        /// To start a call with:<br/>
        /// - Assistant, use `assistant` or `assistantId`<br/>
        /// - Squad, use `squad` or `squadId`<br/>
        /// - Workflow, use `workflow` or `workflowId`
        /// </param>
        /// <param name="workflow">
        /// This is a workflow that will be used for the call. To use an existing workflow, use `workflowId` instead.<br/>
        /// To start a call with:<br/>
        /// - Assistant, use `assistant` or `assistantId`<br/>
        /// - Squad, use `squad` or `squadId`<br/>
        /// - Workflow, use `workflow` or `workflowId`
        /// </param>
        /// <param name="workflowOverrides">
        /// These are the overrides for the `workflow` or `workflowId`'s settings and template variables.
        /// </param>
        /// <param name="phoneNumberId">
        /// This is the phone number that will be used for the call. To use a transient number, use `phoneNumber` instead.<br/>
        /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
        /// </param>
        /// <param name="phoneNumber">
        /// This is the phone number that will be used for the call. To use an existing number, use `phoneNumberId` instead.<br/>
        /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
        /// </param>
        /// <param name="customerId">
        /// This is the customer that will be called. To call a transient customer , use `customer` instead.<br/>
        /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
        /// </param>
        /// <param name="customer">
        /// This is the customer that will be called. To call an existing customer, use `customerId` instead.<br/>
        /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OneOf<global::G.Call, global::G.CallBatchResponse>> CallControllerCreateAsync(
            global::System.Collections.Generic.IList<global::G.CreateCustomerDTO>? customers = default,
            string? name = default,
            global::G.SchedulePlan? schedulePlan = default,
            object? transport = default,
            string? assistantId = default,
            global::G.CreateAssistantDTO? assistant = default,
            global::G.AssistantOverrides? assistantOverrides = default,
            string? squadId = default,
            global::G.CreateSquadDTO? squad = default,
            global::G.AssistantOverrides? squadOverrides = default,
            string? workflowId = default,
            global::G.CreateWorkflowDTO? workflow = default,
            global::G.WorkflowOverrides? workflowOverrides = default,
            string? phoneNumberId = default,
            global::G.ImportTwilioPhoneNumberDTO? phoneNumber = default,
            string? customerId = default,
            global::G.CreateCustomerDTO? customer = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}