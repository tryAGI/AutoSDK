//HintName: G.Models.Call.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Call
    {
        /// <summary>
        /// This is the type of call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CallType? Type { get; set; }

        /// <summary>
        /// These are the costs of individual components of the call in USD.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("costs")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.TransportCost, global::G.TranscriberCost, global::G.ModelCost, global::G.VoiceCost, global::G.VapiCost, global::G.VoicemailDetectionCost, global::G.AnalysisCost, global::G.KnowledgeBaseCost>>? Costs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.UserMessage, global::G.SystemMessage, global::G.BotMessage, global::G.ToolCallMessage, global::G.ToolCallResultMessage>>? Messages { get; set; }

        /// <summary>
        /// This is the provider of the call.<br/>
        /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneCallProvider")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.CallPhoneCallProvider? PhoneCallProvider { get; set; }

        /// <summary>
        /// This is the transport of the phone call.<br/>
        /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneCallTransport")]
        public global::G.CallPhoneCallTransport? PhoneCallTransport { get; set; }

        /// <summary>
        /// This is the status of the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.CallStatus? Status { get; set; }

        /// <summary>
        /// This is the explanation for how the call ended.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endedReason")]
        public global::G.CallEndedReason? EndedReason { get; set; }

        /// <summary>
        /// This is the message that adds more context to the ended reason. It can be used to provide potential error messages or warnings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endedMessage")]
        public string? EndedMessage { get; set; }

        /// <summary>
        /// This is the destination where the call ended up being transferred to. If the call was not transferred, this will be empty.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("destination")]
        public global::G.OneOf<global::G.TransferDestinationNumber, global::G.TransferDestinationSip>? Destination { get; set; }

        /// <summary>
        /// This is the unique identifier for the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the org that this call belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orgId", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgId { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the call was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the call was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the call was started.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startedAt")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the call was ended.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endedAt")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// This is the cost of the call in USD.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// This is the cost of the call in USD.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("costBreakdown")]
        public global::G.CostBreakdown? CostBreakdown { get; set; }

        /// <summary>
        /// This is a copy of assistant artifact plan. This isn't actually stored on the call but rather just returned in POST /call/web to enable artifact creation client side.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("artifactPlan")]
        public global::G.ArtifactPlan? ArtifactPlan { get; set; }

        /// <summary>
        /// This is the analysis of the call. Configure in `assistant.analysisPlan`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("analysis")]
        public global::G.Analysis? Analysis { get; set; }

        /// <summary>
        /// This is to real-time monitor the call. Configure in `assistant.monitorPlan`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("monitor")]
        public global::G.Monitor? Monitor { get; set; }

        /// <summary>
        /// These are the artifacts created from the call. Configure in `assistant.artifactPlan`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("artifact")]
        public global::G.Artifact? Artifact { get; set; }

        /// <summary>
        /// This is the compliance of the call. Configure in `assistant.compliancePlan`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compliance")]
        public global::G.Compliance? Compliance { get; set; }

        /// <summary>
        /// The ID of the call as provided by the phone number service. callSid in Twilio. conversationUuid in Vonage. callControlId in Telnyx.<br/>
        /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneCallProviderId")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? PhoneCallProviderId { get; set; }

        /// <summary>
        /// This is the campaign ID that the call belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("campaignId")]
        public string? CampaignId { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Call" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the call.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the org that this call belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the call was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the call was last updated.
        /// </param>
        /// <param name="type">
        /// This is the type of call.
        /// </param>
        /// <param name="costs">
        /// These are the costs of individual components of the call in USD.
        /// </param>
        /// <param name="messages"></param>
        /// <param name="phoneCallTransport">
        /// This is the transport of the phone call.<br/>
        /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
        /// </param>
        /// <param name="status">
        /// This is the status of the call.
        /// </param>
        /// <param name="endedReason">
        /// This is the explanation for how the call ended.
        /// </param>
        /// <param name="endedMessage">
        /// This is the message that adds more context to the ended reason. It can be used to provide potential error messages or warnings.
        /// </param>
        /// <param name="destination">
        /// This is the destination where the call ended up being transferred to. If the call was not transferred, this will be empty.
        /// </param>
        /// <param name="startedAt">
        /// This is the ISO 8601 date-time string of when the call was started.
        /// </param>
        /// <param name="endedAt">
        /// This is the ISO 8601 date-time string of when the call was ended.
        /// </param>
        /// <param name="cost">
        /// This is the cost of the call in USD.
        /// </param>
        /// <param name="costBreakdown">
        /// This is the cost of the call in USD.
        /// </param>
        /// <param name="artifactPlan">
        /// This is a copy of assistant artifact plan. This isn't actually stored on the call but rather just returned in POST /call/web to enable artifact creation client side.
        /// </param>
        /// <param name="analysis">
        /// This is the analysis of the call. Configure in `assistant.analysisPlan`.
        /// </param>
        /// <param name="monitor">
        /// This is to real-time monitor the call. Configure in `assistant.monitorPlan`.
        /// </param>
        /// <param name="artifact">
        /// These are the artifacts created from the call. Configure in `assistant.artifactPlan`.
        /// </param>
        /// <param name="compliance">
        /// This is the compliance of the call. Configure in `assistant.compliancePlan`.
        /// </param>
        /// <param name="campaignId">
        /// This is the campaign ID that the call belongs to.
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
        /// <param name="name">
        /// This is the name of the call. This is just for your own reference.
        /// </param>
        /// <param name="schedulePlan">
        /// This is the schedule plan of the call.
        /// </param>
        /// <param name="transport">
        /// This is the transport of the call.
        /// </param>
        public Call(
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.CallType? type,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.TransportCost, global::G.TranscriberCost, global::G.ModelCost, global::G.VoiceCost, global::G.VapiCost, global::G.VoicemailDetectionCost, global::G.AnalysisCost, global::G.KnowledgeBaseCost>>? costs,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.UserMessage, global::G.SystemMessage, global::G.BotMessage, global::G.ToolCallMessage, global::G.ToolCallResultMessage>>? messages,
            global::G.CallPhoneCallTransport? phoneCallTransport,
            global::G.CallStatus? status,
            global::G.CallEndedReason? endedReason,
            string? endedMessage,
            global::G.OneOf<global::G.TransferDestinationNumber, global::G.TransferDestinationSip>? destination,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt,
            double? cost,
            global::G.CostBreakdown? costBreakdown,
            global::G.ArtifactPlan? artifactPlan,
            global::G.Analysis? analysis,
            global::G.Monitor? monitor,
            global::G.Artifact? artifact,
            global::G.Compliance? compliance,
            string? campaignId,
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
            global::G.CreateCustomerDTO? customer,
            string? name,
            global::G.SchedulePlan? schedulePlan,
            object? transport)
        {
            this.Type = type;
            this.Costs = costs;
            this.Messages = messages;
            this.PhoneCallTransport = phoneCallTransport;
            this.Status = status;
            this.EndedReason = endedReason;
            this.EndedMessage = endedMessage;
            this.Destination = destination;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
            this.Cost = cost;
            this.CostBreakdown = costBreakdown;
            this.ArtifactPlan = artifactPlan;
            this.Analysis = analysis;
            this.Monitor = monitor;
            this.Artifact = artifact;
            this.Compliance = compliance;
            this.CampaignId = campaignId;
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
            this.Name = name;
            this.SchedulePlan = schedulePlan;
            this.Transport = transport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Call" /> class.
        /// </summary>
        public Call()
        {
        }
    }
}