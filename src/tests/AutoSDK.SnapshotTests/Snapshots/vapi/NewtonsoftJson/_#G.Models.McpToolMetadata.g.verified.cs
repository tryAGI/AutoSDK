//HintName: G.Models.McpToolMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpToolMetadata
    {
        /// <summary>
        /// This is the protocol used for MCP communication. Defaults to Streamable HTTP.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("protocol")]
        public global::G.McpToolMetadataProtocol? Protocol { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpToolMetadata" /> class.
        /// </summary>
        /// <param name="protocol">
        /// This is the protocol used for MCP communication. Defaults to Streamable HTTP.
        /// </param>
        public McpToolMetadata(
            global::G.McpToolMetadataProtocol? protocol)
        {
            this.Protocol = protocol;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpToolMetadata" /> class.
        /// </summary>
        public McpToolMetadata()
        {
        }
    }
}