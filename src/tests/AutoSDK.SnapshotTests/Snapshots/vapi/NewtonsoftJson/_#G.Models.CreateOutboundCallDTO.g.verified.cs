//HintName: G.Models.CreateOutboundCallDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOutboundCallDTO
    {
        /// <summary>
        /// This is used to issue batch calls to multiple customers.<br/>
        /// Only relevant for `outboundPhoneCall`. To call a single customer, use `customer` instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customers")]
        public global::System.Collections.Generic.IList<global::G.CreateCustomerDTO>? Customers { get; set; }

        /// <summary>
        /// This is the name of the call. This is just for your own reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the schedule plan of the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schedulePlan")]
        public global::G.SchedulePlan? SchedulePlan { get; set; }

        /// <summary>
        /// This is the transport of the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transport")]
        public object? Transport { get; set; }

        /// <summary>
        /// This is the assistant ID that will be used for the call. To use a transient assistant, use `assistant` instead.<br/>
        /// To start a call with:<br/>
        /// - Assistant, use `assistantId` or `assistant`<br/>
        /// - Squad, use `squadId` or `squad`<br/>
        /// - Workflow, use `workflowId` or `workflow`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// This is the assistant that will be used for the call. To use an existing assistant, use `assistantId` instead.<br/>
        /// To start a call with:<br/>
        /// - Assistant, use `assistant`<br/>
        /// - Squad, use `squad`<br/>
        /// - Workflow, use `workflow`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistant")]
        public global::G.CreateAssistantDTO? Assistant { get; set; }

        /// <summary>
        /// These are the overrides for the `assistant` or `assistantId`'s settings and template variables.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantOverrides")]
        public global::G.AssistantOverrides? AssistantOverrides { get; set; }

        /// <summary>
        /// This is the squad that will be used for the call. To use a transient squad, use `squad` instead.<br/>
        /// To start a call with:<br/>
        /// - Assistant, use `assistant` or `assistantId`<br/>
        /// - Squad, use `squad` or `squadId`<br/>
        /// - Workflow, use `workflow` or `workflowId`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("squadId")]
        public string? SquadId { get; set; }

        /// <summary>
        /// This is a squad that will be used for the call. To use an existing squad, use `squadId` instead.<br/>
        /// To start a call with:<br/>
        /// - Assistant, use `assistant` or `assistantId`<br/>
        /// - Squad, use `squad` or `squadId`<br/>
        /// - Workflow, use `workflow` or `workflowId`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("squad")]
        public global::G.CreateSquadDTO? Squad { get; set; }

        /// <summary>
        /// These are the overrides for the `squad` or `squadId`'s member settings and template variables.<br/>
        /// This will apply to all members of the squad.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("squadOverrides")]
        public global::G.AssistantOverrides? SquadOverrides { get; set; }

        /// <summary>
        /// This is the workflow that will be used for the call. To use a transient workflow, use `workflow` instead.<br/>
        /// To start a call with:<br/>
        /// - Assistant, use `assistant` or `assistantId`<br/>
        /// - Squad, use `squad` or `squadId`<br/>
        /// - Workflow, use `workflow` or `workflowId`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflowId")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// This is a workflow that will be used for the call. To use an existing workflow, use `workflowId` instead.<br/>
        /// To start a call with:<br/>
        /// - Assistant, use `assistant` or `assistantId`<br/>
        /// - Squad, use `squad` or `squadId`<br/>
        /// - Workflow, use `workflow` or `workflowId`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow")]
        public global::G.CreateWorkflowDTO? Workflow { get; set; }

        /// <summary>
        /// These are the overrides for the `workflow` or `workflowId`'s settings and template variables.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflowOverrides")]
        public global::G.WorkflowOverrides? WorkflowOverrides { get; set; }

        /// <summary>
        /// This is the phone number that will be used for the call. To use a transient number, use `phoneNumber` instead.<br/>
        /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneNumberId")]
        public string? PhoneNumberId { get; set; }

        /// <summary>
        /// This is the phone number that will be used for the call. To use an existing number, use `phoneNumberId` instead.<br/>
        /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneNumber")]
        public global::G.ImportTwilioPhoneNumberDTO? PhoneNumber { get; set; }

        /// <summary>
        /// This is the customer that will be called. To call a transient customer , use `customer` instead.<br/>
        /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customerId")]
        public string? CustomerId { get; set; }

        /// <summary>
        /// This is the customer that will be called. To call an existing customer, use `customerId` instead.<br/>
        /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customer")]
        public global::G.CreateCustomerDTO? Customer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOutboundCallDTO" /> class.
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
        public CreateOutboundCallDTO(
            global::System.Collections.Generic.IList<global::G.CreateCustomerDTO>? customers,
            string? name,
            global::G.SchedulePlan? schedulePlan,
            object? transport,
            string? assistantId,
            global::G.CreateAssistantDTO? assistant,
            global::G.AssistantOverrides? assistantOverrides,
            string? squadId,
            global::G.CreateSquadDTO? squad,
            global::G.AssistantOverrides? squadOverrides,
            string? workflowId,
            global::G.CreateWorkflowDTO? workflow,
            global::G.WorkflowOverrides? workflowOverrides,
            string? phoneNumberId,
            global::G.ImportTwilioPhoneNumberDTO? phoneNumber,
            string? customerId,
            global::G.CreateCustomerDTO? customer)
        {
            this.Customers = customers;
            this.Name = name;
            this.SchedulePlan = schedulePlan;
            this.Transport = transport;
            this.AssistantId = assistantId;
            this.Assistant = assistant;
            this.AssistantOverrides = assistantOverrides;
            this.SquadId = squadId;
            this.Squad = squad;
            this.SquadOverrides = squadOverrides;
            this.WorkflowId = workflowId;
            this.Workflow = workflow;
            this.WorkflowOverrides = workflowOverrides;
            this.PhoneNumberId = phoneNumberId;
            this.PhoneNumber = phoneNumber;
            this.CustomerId = customerId;
            this.Customer = customer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOutboundCallDTO" /> class.
        /// </summary>
        public CreateOutboundCallDTO()
        {
        }
    }
}