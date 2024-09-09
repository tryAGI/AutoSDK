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
        [global::Newtonsoft.Json.JsonProperty("tool_calls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RunToolCallObject> ToolCalls { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}