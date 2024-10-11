//HintName: G.Models.ToolCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The tool the model wants to call.
    /// </summary>
    public sealed partial class ToolCall
    {
        /// <summary>
        /// The function the model wants to call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function")]
        public global::G.ToolCallFunction? Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}