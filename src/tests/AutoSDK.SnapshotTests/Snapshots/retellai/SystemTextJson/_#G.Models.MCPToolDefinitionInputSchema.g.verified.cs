//HintName: G.Models.MCPToolDefinitionInputSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// JSON schema defining the input parameters for the tool.<br/>
    /// Example: {"type":"object","properties":{"query":{"type":"string","description":"Search query"}},"required":["query"]}
    /// </summary>
    public sealed partial class MCPToolDefinitionInputSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}