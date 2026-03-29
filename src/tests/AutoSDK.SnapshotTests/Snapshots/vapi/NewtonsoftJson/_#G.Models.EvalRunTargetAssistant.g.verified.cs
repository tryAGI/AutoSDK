//HintName: G.Models.EvalRunTargetAssistant.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalRunTargetAssistant
    {
        /// <summary>
        /// This is the transient assistant that will be run against the eval
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistant")]
        public global::G.CreateAssistantDTO? Assistant { get; set; }

        /// <summary>
        /// This is the overrides that will be applied to the assistant.<br/>
        /// Example: {
        /// </summary>
        /// <example>{</example>
        [global::Newtonsoft.Json.JsonProperty("assistantOverrides")]
        public global::G.AssistantOverrides? AssistantOverrides { get; set; }

        /// <summary>
        /// This is the type of the target.<br/>
        /// Currently it is fixed to `assistant`.<br/>
        /// Example: assistant
        /// </summary>
        /// <example>assistant</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.EvalRunTargetAssistantType Type { get; set; }

        /// <summary>
        /// This is the id of the assistant that will be run against the eval<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174000</example>
        [global::Newtonsoft.Json.JsonProperty("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunTargetAssistant" /> class.
        /// </summary>
        /// <param name="assistant">
        /// This is the transient assistant that will be run against the eval
        /// </param>
        /// <param name="assistantOverrides">
        /// This is the overrides that will be applied to the assistant.<br/>
        /// Example: {
        /// </param>
        /// <param name="type">
        /// This is the type of the target.<br/>
        /// Currently it is fixed to `assistant`.<br/>
        /// Example: assistant
        /// </param>
        /// <param name="assistantId">
        /// This is the id of the assistant that will be run against the eval<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        public EvalRunTargetAssistant(
            global::G.CreateAssistantDTO? assistant,
            global::G.AssistantOverrides? assistantOverrides,
            global::G.EvalRunTargetAssistantType type,
            string? assistantId)
        {
            this.Assistant = assistant;
            this.AssistantOverrides = assistantOverrides;
            this.Type = type;
            this.AssistantId = assistantId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunTargetAssistant" /> class.
        /// </summary>
        public EvalRunTargetAssistant()
        {
        }
    }
}