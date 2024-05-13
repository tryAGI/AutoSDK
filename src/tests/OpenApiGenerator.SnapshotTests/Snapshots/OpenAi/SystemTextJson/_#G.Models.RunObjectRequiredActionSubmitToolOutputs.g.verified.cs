//HintName: G.Models.RunObjectRequiredActionSubmitToolOutputs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details on the tool outputs needed for this run to continue.
    /// </summary>
    public sealed partial class RunObjectRequiredActionSubmitToolOutputs
    {
        /// <summary>
        /// A list of the relevant tool calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<RunToolCallObject> ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}