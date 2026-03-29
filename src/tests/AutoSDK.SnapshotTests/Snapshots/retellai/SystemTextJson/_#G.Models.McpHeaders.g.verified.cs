//HintName: G.Models.McpHeaders.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Headers to add to the MCP connection request.<br/>
    /// Example: {"Authorization":"Bearer 1234567890"}
    /// </summary>
    public sealed partial class McpHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}