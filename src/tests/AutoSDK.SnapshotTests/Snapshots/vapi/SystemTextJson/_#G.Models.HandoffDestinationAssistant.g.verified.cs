//HintName: G.Models.HandoffDestinationAssistant.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HandoffDestinationAssistant
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.HandoffDestinationAssistantTypeJsonConverter))]
        public global::G.HandoffDestinationAssistantType Type { get; set; }

        /// <summary>
        /// This is the plan for manipulating the message context before handing off the call to the next assistant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextEngineeringPlan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.ContextEngineeringPlanLastNMessages, global::G.ContextEngineeringPlanNone, global::G.ContextEngineeringPlanAll, global::G.ContextEngineeringPlanUserAndAssistantMessages>))]
        public global::G.OneOf<global::G.ContextEngineeringPlanLastNMessages, global::G.ContextEngineeringPlanNone, global::G.ContextEngineeringPlanAll, global::G.ContextEngineeringPlanUserAndAssistantMessages>? ContextEngineeringPlan { get; set; }

        /// <summary>
        /// This is the assistant to transfer the call to. You must provide either assistantName or assistantId.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantName")]
        public string? AssistantName { get; set; }

        /// <summary>
        /// This is the assistant id to transfer the call to. You must provide either assistantName or assistantId.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// This is a transient assistant to transfer the call to. You may provide a transient assistant in the response  `handoff-destination-request` in a dynamic handoff.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant")]
        public global::G.CreateAssistantDTO? Assistant { get; set; }

        /// <summary>
        /// This is the variable extraction plan for the handoff tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variableExtractionPlan")]
        public global::G.VariableExtractionPlan? VariableExtractionPlan { get; set; }

        /// <summary>
        /// These are the assistant overrides to apply to the destination assistant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantOverrides")]
        public global::G.AssistantOverrides? AssistantOverrides { get; set; }

        /// <summary>
        /// This is the description of the destination, used by the AI to choose when and how to transfer the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HandoffDestinationAssistant" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="contextEngineeringPlan">
        /// This is the plan for manipulating the message context before handing off the call to the next assistant.
        /// </param>
        /// <param name="assistantName">
        /// This is the assistant to transfer the call to. You must provide either assistantName or assistantId.
        /// </param>
        /// <param name="assistantId">
        /// This is the assistant id to transfer the call to. You must provide either assistantName or assistantId.
        /// </param>
        /// <param name="assistant">
        /// This is a transient assistant to transfer the call to. You may provide a transient assistant in the response  `handoff-destination-request` in a dynamic handoff.
        /// </param>
        /// <param name="variableExtractionPlan">
        /// This is the variable extraction plan for the handoff tool.
        /// </param>
        /// <param name="assistantOverrides">
        /// These are the assistant overrides to apply to the destination assistant.
        /// </param>
        /// <param name="description">
        /// This is the description of the destination, used by the AI to choose when and how to transfer the call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HandoffDestinationAssistant(
            global::G.HandoffDestinationAssistantType type,
            global::G.OneOf<global::G.ContextEngineeringPlanLastNMessages, global::G.ContextEngineeringPlanNone, global::G.ContextEngineeringPlanAll, global::G.ContextEngineeringPlanUserAndAssistantMessages>? contextEngineeringPlan,
            string? assistantName,
            string? assistantId,
            global::G.CreateAssistantDTO? assistant,
            global::G.VariableExtractionPlan? variableExtractionPlan,
            global::G.AssistantOverrides? assistantOverrides,
            string? description)
        {
            this.Type = type;
            this.ContextEngineeringPlan = contextEngineeringPlan;
            this.AssistantName = assistantName;
            this.AssistantId = assistantId;
            this.Assistant = assistant;
            this.VariableExtractionPlan = variableExtractionPlan;
            this.AssistantOverrides = assistantOverrides;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HandoffDestinationAssistant" /> class.
        /// </summary>
        public HandoffDestinationAssistant()
        {
        }
    }
}