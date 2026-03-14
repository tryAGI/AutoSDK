//HintName: G.Models.McpToolVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpToolVariant2
    {
        /// <summary>
        /// This should always be `mcp`.<br/>
        /// Default Value: mcp<br/>
        /// Example: mcp
        /// </summary>
        /// <default>"mcp"</default>
        /// <example>mcp</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "mcp";

        /// <summary>
        /// Unique identifier for a tool server.<br/>
        /// Example: tsr_rag_search
        /// </summary>
        /// <example>tsr_rag_search</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_id")]
        public string? ServerId { get; set; }

        /// <summary>
        /// Optional hints about tool behaviour/metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::G.McpToolAnnotations? Annotations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpToolVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `mcp`.<br/>
        /// Default Value: mcp<br/>
        /// Example: mcp
        /// </param>
        /// <param name="serverId">
        /// Unique identifier for a tool server.<br/>
        /// Example: tsr_rag_search
        /// </param>
        /// <param name="annotations">
        /// Optional hints about tool behaviour/metadata.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpToolVariant2(
            string type,
            string? serverId,
            global::G.McpToolAnnotations? annotations)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ServerId = serverId;
            this.Annotations = annotations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpToolVariant2" /> class.
        /// </summary>
        public McpToolVariant2()
        {
        }
    }
}