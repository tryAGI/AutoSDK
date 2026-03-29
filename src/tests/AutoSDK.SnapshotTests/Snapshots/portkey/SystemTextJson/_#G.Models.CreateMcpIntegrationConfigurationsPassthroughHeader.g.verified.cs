//HintName: G.Models.CreateMcpIntegrationConfigurationsPassthroughHeader.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Headers to pass through from the incoming request to the MCP server.<br/>
    /// Example: {"x-user-id":{"type":"string","example":"abc123"},"x-request-id":{"type":"string","example":"req-0001"}}
    /// </summary>
    public sealed partial class CreateMcpIntegrationConfigurationsPassthroughHeader
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}