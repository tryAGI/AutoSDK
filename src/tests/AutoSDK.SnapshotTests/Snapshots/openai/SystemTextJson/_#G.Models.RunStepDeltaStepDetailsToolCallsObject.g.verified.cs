//HintName: G.Models.RunStepDeltaStepDetailsToolCallsObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details of the tool call.
    /// </summary>
    public sealed partial class RunStepDeltaStepDetailsToolCallsObject
    {
        /// <summary>
        /// Always `tool_calls`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeJsonConverter))]
        public global::G.RunStepDeltaStepDetailsToolCallsObjectType Type { get; set; }

        /// <summary>
        /// An array of tool calls the run step was involved in. These can be associated with one of three types of tools: `code_interpreter`, `file_search`, or `function`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ToolCallsItem>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsObject" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `tool_calls`.
        /// </param>
        /// <param name="toolCalls">
        /// An array of tool calls the run step was involved in. These can be associated with one of three types of tools: `code_interpreter`, `file_search`, or `function`.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RunStepDeltaStepDetailsToolCallsObject(
            global::G.RunStepDeltaStepDetailsToolCallsObjectType type,
            global::System.Collections.Generic.IList<global::G.ToolCallsItem>? toolCalls)
        {
            this.Type = type;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsObject" /> class.
        /// </summary>
        public RunStepDeltaStepDetailsToolCallsObject()
        {
        }
    }
}