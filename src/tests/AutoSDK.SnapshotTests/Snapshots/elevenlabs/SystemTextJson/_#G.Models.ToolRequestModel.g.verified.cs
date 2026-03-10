//HintName: G.Models.ToolRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolRequestModel
    {
        /// <summary>
        /// Configuration for the tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolConfigJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ToolConfig ToolConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRequestModel" /> class.
        /// </summary>
        /// <param name="toolConfig">
        /// Configuration for the tool
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolRequestModel(
            global::G.ToolConfig toolConfig)
        {
            this.ToolConfig = toolConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRequestModel" /> class.
        /// </summary>
        public ToolRequestModel()
        {
        }
    }
}