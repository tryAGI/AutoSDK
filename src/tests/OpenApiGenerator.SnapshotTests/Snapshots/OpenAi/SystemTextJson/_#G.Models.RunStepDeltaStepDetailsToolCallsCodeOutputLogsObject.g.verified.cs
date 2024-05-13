//HintName: G.Models.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Text output from the Code Interpreter tool call as part of a run step.
    /// </summary>
    public sealed partial class RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject
    {
        /// <summary>
        /// The index of the output in the outputs array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Always `logs`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The text output from the Code Interpreter tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs")]
        public string? Logs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}