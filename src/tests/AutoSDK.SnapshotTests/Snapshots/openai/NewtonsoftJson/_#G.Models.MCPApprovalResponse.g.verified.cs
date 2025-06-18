//HintName: G.Models.MCPApprovalResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A response to an MCP approval request.
    /// </summary>
    public sealed partial class MCPApprovalResponse
    {
        /// <summary>
        /// The type of the item. Always `mcp_approval_response`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MCPApprovalResponseType Type { get; set; }

        /// <summary>
        /// The unique ID of the approval response
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The ID of the approval request being answered.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approval_request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApprovalRequestId { get; set; } = default!;

        /// <summary>
        /// Whether the request was approved.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approve", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Approve { get; set; } = default!;

        /// <summary>
        /// Optional reason for the decision.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPApprovalResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the item. Always `mcp_approval_response`.
        /// </param>
        /// <param name="id">
        /// The unique ID of the approval response
        /// </param>
        /// <param name="approvalRequestId">
        /// The ID of the approval request being answered.
        /// </param>
        /// <param name="approve">
        /// Whether the request was approved.
        /// </param>
        /// <param name="reason">
        /// Optional reason for the decision.
        /// </param>
        public MCPApprovalResponse(
            string approvalRequestId,
            bool approve,
            global::G.MCPApprovalResponseType type,
            string? id,
            string? reason)
        {
            this.ApprovalRequestId = approvalRequestId ?? throw new global::System.ArgumentNullException(nameof(approvalRequestId));
            this.Approve = approve;
            this.Type = type;
            this.Id = id;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPApprovalResponse" /> class.
        /// </summary>
        public MCPApprovalResponse()
        {
        }
    }
}