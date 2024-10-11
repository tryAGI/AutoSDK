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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolTypeJsonConverter))]
        public global::G.ToolType? Type { get; set; } = global::G.ToolType.Function;

        /// <summary>
        /// A function that the model may call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        public global::G.ToolFunction? Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}