//HintName: G.Models.Tool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool the model may call.
    /// </summary>
    public sealed partial class Tool
    {
        /// <summary>
        /// The type of tool.<br/>
        /// Default Value: function
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ToolType? Type { get; set; } = global::G.ToolType.Function;

        /// <summary>
        /// A function that the model may call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function")]
        public global::G.ToolFunction? Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}