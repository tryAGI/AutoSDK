//HintName: G.Models.UpdateMcpToolRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request object for updating an existing MCP tool.
    /// </summary>
    public sealed partial class UpdateMcpToolRequest
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
        /// Whether the tool is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMcpToolRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `mcp`.<br/>
        /// Default Value: mcp<br/>
        /// Example: mcp
        /// </param>
        /// <param name="enabled">
        /// Whether the tool is enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMcpToolRequest(
            string type,
            bool? enabled)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMcpToolRequest" /> class.
        /// </summary>
        public UpdateMcpToolRequest()
        {
        }
    }
}