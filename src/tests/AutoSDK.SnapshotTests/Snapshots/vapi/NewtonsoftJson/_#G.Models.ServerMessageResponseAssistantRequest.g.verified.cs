//HintName: G.Models.ServerMessageResponseAssistantRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerMessageResponseAssistantRequest
    {
        /// <summary>
        /// This is the destination to transfer the inbound call to. This will immediately transfer without using any assistants.<br/>
        /// If this is sent, `assistantId`, `assistant`, `squadId`, and `squad` are ignored.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("destination")]
        public global::G.OneOf<global::G.TransferDestinationNumber, global::G.TransferDestinationSip>? Destination { get; set; }

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
        /// This is the error if the call shouldn't be accepted. This is spoken to the customer.<br/>
        /// If this is sent, `assistantId`, `assistant`, `squadId`, `squad`, and `destination` are ignored.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageResponseAssistantRequest" /> class.
        /// </summary>
        /// <param name="destination">
        /// This is the destination to transfer the inbound call to. This will immediately transfer without using any assistants.<br/>
        /// If this is sent, `assistantId`, `assistant`, `squadId`, and `squad` are ignored.
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
        /// <param name="error">
        /// This is the error if the call shouldn't be accepted. This is spoken to the customer.<br/>
        /// If this is sent, `assistantId`, `assistant`, `squadId`, `squad`, and `destination` are ignored.
        /// </param>
        public ServerMessageResponseAssistantRequest(
            global::G.OneOf<global::G.TransferDestinationNumber, global::G.TransferDestinationSip>? destination,
            string? assistantId,
            global::G.CreateAssistantDTO? assistant,
            global::G.AssistantOverrides? assistantOverrides,
            string? squadId,
            global::G.CreateSquadDTO? squad,
            global::G.AssistantOverrides? squadOverrides,
            string? workflowId,
            global::G.CreateWorkflowDTO? workflow,
            global::G.WorkflowOverrides? workflowOverrides,
            string? error)
        {
            this.Destination = destination;
            this.AssistantId = assistantId;
            this.Assistant = assistant;
            this.AssistantOverrides = assistantOverrides;
            this.SquadId = squadId;
            this.Squad = squad;
            this.SquadOverrides = squadOverrides;
            this.WorkflowId = workflowId;
            this.Workflow = workflow;
            this.WorkflowOverrides = workflowOverrides;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageResponseAssistantRequest" /> class.
        /// </summary>
        public ServerMessageResponseAssistantRequest()
        {
        }
    }
}