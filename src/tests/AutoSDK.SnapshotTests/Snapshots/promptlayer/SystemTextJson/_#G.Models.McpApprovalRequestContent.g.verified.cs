//HintName: G.Models.McpApprovalRequestContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// MCP tool approval request block.
    /// </summary>
    public sealed partial class McpApprovalRequestContent
    {
        /// <summary>
        /// Default Value: mcp_approval_request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.McpApprovalRequestContentTypeJsonConverter))]
        public global::G.McpApprovalRequestContentType? Type { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        public string? ServerLabel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpApprovalRequestContent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: mcp_approval_request
        /// </param>
        /// <param name="id">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="name"></param>
        /// <param name="arguments"></param>
        /// <param name="serverLabel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpApprovalRequestContent(
            global::G.McpApprovalRequestContentType? type,
            string? id,
            string? name,
            string? arguments,
            string? serverLabel)
        {
            this.Type = type;
            this.Id = id;
            this.Name = name;
            this.Arguments = arguments;
            this.ServerLabel = serverLabel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpApprovalRequestContent" /> class.
        /// </summary>
        public McpApprovalRequestContent()
        {
        }
    }
}