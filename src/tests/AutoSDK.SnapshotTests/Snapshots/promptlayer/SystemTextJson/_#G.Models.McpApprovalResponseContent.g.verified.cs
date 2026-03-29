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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.McpApprovalResponseContentTypeJsonConverter))]
        public global::G.McpApprovalResponseContentType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval_request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApprovalRequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approve")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Approve { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpApprovalResponseContent" /> class.
        /// </summary>
        /// <param name="approvalRequestId"></param>
        /// <param name="approve"></param>
        /// <param name="type">
        /// Default Value: mcp_approval_response
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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