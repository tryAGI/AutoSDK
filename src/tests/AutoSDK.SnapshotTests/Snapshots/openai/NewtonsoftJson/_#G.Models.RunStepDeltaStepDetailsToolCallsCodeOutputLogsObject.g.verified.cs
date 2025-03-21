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
        /// The text output from the Code Interpreter tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logs")]
        public string? Logs { get; set; }

        /// <summary>
        /// Always `logs`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType Type { get; set; }

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
        /// <param name="logs">
        /// The text output from the Code Interpreter tool call.
        /// </param>
        /// <param name="type">
        /// Always `logs`.
        /// </param>
        public RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject(
            int index,
            string? logs,
            global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType type)
        {
            this.Index = index;
            this.Logs = logs;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject" /> class.
        /// </summary>
        public RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject()
        {
        }
    }
}