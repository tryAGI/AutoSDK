//HintName: G.Models.McpListToolsContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// MCP list tools response block.
    /// </summary>
    public sealed partial class McpListToolsContent
    {
        /// <summary>
        /// Default Value: mcp_list_tools
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.McpListToolsContentType? Type { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_label")]
        public string? ServerLabel { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<object>? Tools { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.AnyOf<string, object, object>? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpListToolsContent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: mcp_list_tools
        /// </param>
        /// <param name="id">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="serverLabel"></param>
        /// <param name="tools">
        /// Default Value: []
        /// </param>
        /// <param name="error">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public McpListToolsContent(
            global::G.McpListToolsContentType? type,
            string? id,
            string? serverLabel,
            global::System.Collections.Generic.IList<object>? tools,
            global::G.AnyOf<string, object, object>? error)
        {
            this.Type = type;
            this.Id = id;
            this.ServerLabel = serverLabel;
            this.Tools = tools;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpListToolsContent" /> class.
        /// </summary>
        public McpListToolsContent()
        {
        }
    }
}