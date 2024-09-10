//HintName: G.Models.RunStepDetailsToolCallsObject.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Details of the tool call.
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsObject
    {
        /// <summary>
        /// Always `tool_calls`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RunStepDetailsToolCallsObjectType Type { get; set; }

        /// <summary>
        /// An array of tool calls the run step was involved in. These can be associated with one of three types of tools: `code_interpreter`, `file_search`, or `function`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.RunStepDetailsToolCallsCodeObject, global::G.RunStepDetailsToolCallsFileSearchObject, global::G.RunStepDetailsToolCallsFunctionObject>> ToolCalls { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}