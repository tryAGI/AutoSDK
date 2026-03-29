//HintName: G.Models.CreateWebCallDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWebCallDTO
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roomDeleteOnUserLeaveEnabled")]
        public bool? RoomDeleteOnUserLeaveEnabled { get; set; }

        /// <summary>
        /// This is the assistant ID that will be used for the call. To use a transient assistant, use `assistant` instead.<br/>
        /// To start a call with:<br/>
        /// - Assistant, use `assistantId` or `assistant`<br/>
        /// - Squad, use `squadId` or `squad`<br/>
        /// - Workflow, use `workflowId` or `workflow`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// This is the assistant that will be used for the call. To use an existing assistant, use `assistantId` instead.<br/>
        /// To start a call with:<br/>
        /// - Assistant, use `assistant`<br/>
        /// - Squad, use `squad`<br/>
        /// - Workflow, use `workflow`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant")]
        public global::G.CreateAssistantDTO? Assistant { get; set; }

        /// <summary>
        /// These are the overrides for the `assistant` or `assistantId`'s settings and template variables.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantOverrides")]
        public global::G.AssistantOverrides? AssistantOverrides { get; set; }

        /// <summary>
        /// This is the squad that will be used for the call. To use a transient squad, use `squad` instead.<br/>
        /// To start a call with:<br/>
        /// - Assistant, use `assistant` or `assistantId`<br/>
        /// - Squad, use `squad` or `squadId`<br/>
        /// - Workflow, use `workflow` or `workflowId`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squadId")]
        public string? SquadId { get; set; }

        /// <summary>
        /// This is a squad that will be used for the call. To use an existing squad, use `squadId` instead.<br/>
        /// To start a call with:<br/>
        /// - Assistant, use `assistant` or `assistantId`<br/>
        /// - Squad, use `squad` or `squadId`<br/>
        /// - Workflow, use `workflow` or `workflowId`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squad")]
        public global::G.CreateSquadDTO? Squad { get; set; }

        /// <summary>
        /// These are the overrides for the `squad` or `squadId`'s member settings and template variables.<br/>
        /// This will apply to all members of the squad.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squadOverrides")]
        public global::G.AssistantOverrides? SquadOverrides { get; set; }

        /// <summary>
        /// This is the workflow that will be used for the call. To use a transient workflow, use `workflow` instead.<br/>
        /// To start a call with:<br/>
        /// - Assistant, use `assistant` or `assistantId`<br/>
        /// - Squad, use `squad` or `squadId`<br/>
        /// - Workflow, use `workflow` or `workflowId`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowId")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// This is a workflow that will be used for the call. To use an existing workflow, use `workflowId` instead.<br/>
        /// To start a call with:<br/>
        /// - Assistant, use `assistant` or `assistantId`<br/>
        /// - Squad, use `squad` or `squadId`<br/>
        /// - Workflow, use `workflow` or `workflowId`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        public global::G.CreateWorkflowDTO? Workflow { get; set; }

        /// <summary>
        /// These are the overrides for the `workflow` or `workflowId`'s settings and template variables.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowOverrides")]
        public global::G.WorkflowOverrides? WorkflowOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebCallDTO" /> class.
        /// </summary>
        /// <param name="roomDeleteOnUserLeaveEnabled">
        /// Default Value: true
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWebCallDTO(
            bool? roomDeleteOnUserLeaveEnabled,
            string? assistantId,
            global::G.CreateAssistantDTO? assistant,
            global::G.AssistantOverrides? assistantOverrides,
            string? squadId,
            global::G.CreateSquadDTO? squad,
            global::G.AssistantOverrides? squadOverrides,
            string? workflowId,
            global::G.CreateWorkflowDTO? workflow,
            global::G.WorkflowOverrides? workflowOverrides)
        {
            this.RoomDeleteOnUserLeaveEnabled = roomDeleteOnUserLeaveEnabled;
            this.AssistantId = assistantId;
            this.Assistant = assistant;
            this.AssistantOverrides = assistantOverrides;
            this.SquadId = squadId;
            this.Squad = squad;
            this.SquadOverrides = squadOverrides;
            this.WorkflowId = workflowId;
            this.Workflow = workflow;
            this.WorkflowOverrides = workflowOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebCallDTO" /> class.
        /// </summary>
        public CreateWebCallDTO()
        {
        }
    }
}