//HintName: G.Models.McpCallContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// MCP tool call block.
    /// </summary>
    public sealed partial class McpCallContent
    {
        /// <summary>
        /// Default Value: mcp_call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.McpCallContentTypeJsonConverter))]
        public global::G.McpCallContentType? Type { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_label")]
        public string? ServerLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public string? Output { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.AnyOf<string, object, object>? Error { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approval_request_id")]
        public string? ApprovalRequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpCallContent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: mcp_call
        /// </param>
        /// <param name="id">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="name"></param>
        /// <param name="serverLabel"></param>
        /// <param name="arguments"></param>
        /// <param name="output">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="error">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="approvalRequestId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public McpCallContent(
            global::G.McpCallContentType? type,
            string? id,
            string? name,
            string? serverLabel,
            string? arguments,
            string? output,
            global::G.AnyOf<string, object, object>? error,
            string? approvalRequestId)
        {
            this.Type = type;
            this.Id = id;
            this.Name = name;
            this.ServerLabel = serverLabel;
            this.Arguments = arguments;
            this.Output = output;
            this.Error = error;
            this.ApprovalRequestId = approvalRequestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpCallContent" /> class.
        /// </summary>
        public McpCallContent()
        {
        }
    }
}