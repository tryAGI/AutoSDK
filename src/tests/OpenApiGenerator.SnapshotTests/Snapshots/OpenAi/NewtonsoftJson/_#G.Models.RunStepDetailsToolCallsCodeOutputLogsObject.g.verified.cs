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
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunStepDetailsToolCallsCodeOutputLogsObjectType Type { get; set; } = default!;

        /// <summary>
        /// The text output from the Code Interpreter tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logs", Required = global::Newtonsoft.Json.Required.Always)]
        public string Logs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}