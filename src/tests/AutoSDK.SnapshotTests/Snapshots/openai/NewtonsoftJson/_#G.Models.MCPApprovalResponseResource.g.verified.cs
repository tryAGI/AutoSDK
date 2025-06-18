//HintName: G.Models.MCPApprovalResponseResource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A response to an MCP approval request.
    /// </summary>
    public sealed partial class MCPApprovalResponseResource
    {
        /// <summary>
        /// The type of the item. Always `mcp_approval_response`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MCPApprovalResponseResourceType Type { get; set; }

        /// <summary>
        /// The unique ID of the approval response
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="MCPApprovalResponseResource" /> class.
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
        public MCPApprovalResponseResource(
            string id,
            string approvalRequestId,
            bool approve,
            global::G.MCPApprovalResponseResourceType type,
            string? reason)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ApprovalRequestId = approvalRequestId ?? throw new global::System.ArgumentNullException(nameof(approvalRequestId));
            this.Approve = approve;
            this.Type = type;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPApprovalResponseResource" /> class.
        /// </summary>
        public MCPApprovalResponseResource()
        {
        }
    }
}