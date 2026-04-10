//HintName: G.Models.McpApprovalResponseContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// MCP tool approval response block.
    /// </summary>
    public sealed partial class McpApprovalResponseContent
    {
        /// <summary>
        /// Default Value: mcp_approval_response
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.McpApprovalResponseContentTypeJsonConverter))]
        public global::G.McpApprovalResponseContentType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approval_request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApprovalRequestId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approve", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Approve { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpApprovalResponseContent" /> class.
        /// </summary>
        /// <param name="approvalRequestId"></param>
        /// <param name="approve"></param>
        /// <param name="type">
        /// Default Value: mcp_approval_response
        /// </param>
        public McpApprovalResponseContent(
            string approvalRequestId,
            bool approve,
            global::G.McpApprovalResponseContentType? type)
        {
            this.Type = type;
            this.ApprovalRequestId = approvalRequestId ?? throw new global::System.ArgumentNullException(nameof(approvalRequestId));
            this.Approve = approve;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpApprovalResponseContent" /> class.
        /// </summary>
        public McpApprovalResponseContent()
        {
        }
    }
}