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
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// Always `logs`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType Type { get; set; }

        /// <summary>
        /// The text output from the Code Interpreter tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logs")]
        public string? Logs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the output in the outputs array.
        /// </param>
        /// <param name="type">
        /// Always `logs`.
        /// </param>
        /// <param name="logs">
        /// The text output from the Code Interpreter tool call.
        /// </param>
        public RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject(
            int index,
            global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType type,
            string? logs)
        {
            this.Index = index;
            this.Type = type;
            this.Logs = logs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject" /> class.
        /// </summary>
        public RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject()
        {
        }
    }
}