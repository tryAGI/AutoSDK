//HintName: G.Models.RunStepDetailsToolCallsCodeOutputLogsObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Text output from the Code Interpreter tool call as part of a run step.
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsCodeOutputLogsObject
    {
        /// <summary>
        /// Always `logs`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter))]
        public global::G.RunStepDetailsToolCallsCodeOutputLogsObjectType Type { get; set; }

        /// <summary>
        /// The text output from the Code Interpreter tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Logs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeOutputLogsObject" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `logs`.
        /// </param>
        /// <param name="logs">
        /// The text output from the Code Interpreter tool call.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RunStepDetailsToolCallsCodeOutputLogsObject(
            string logs,
            global::G.RunStepDetailsToolCallsCodeOutputLogsObjectType type)
        {
            this.Logs = logs ?? throw new global::System.ArgumentNullException(nameof(logs));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeOutputLogsObject" /> class.
        /// </summary>
        public RunStepDetailsToolCallsCodeOutputLogsObject()
        {
        }
    }
}