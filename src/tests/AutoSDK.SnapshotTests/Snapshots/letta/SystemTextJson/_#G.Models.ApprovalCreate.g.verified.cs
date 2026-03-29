//HintName: G.Models.ApprovalCreate.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Input to approve or deny a tool call request
    /// </summary>
    public sealed partial class ApprovalCreate
    {
        /// <summary>
        /// The message type to be created.<br/>
        /// Default Value: approval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The list of approval responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approvals")]
        public global::System.Collections.Generic.IList<global::G.ApprovalsVariant1Item>? Approvals { get; set; }

        /// <summary>
        /// Whether the tool has been approved
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approve")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? Approve { get; set; }

        /// <summary>
        /// The message ID of the approval request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval_request_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ApprovalRequestId { get; set; }

        /// <summary>
        /// An optional explanation for the provided approval status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Reason { get; set; }

        /// <summary>
        /// The multi-agent group that the message was sent in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApprovalCreate" /> class.
        /// </summary>
        /// <param name="type">
        /// The message type to be created.<br/>
        /// Default Value: approval
        /// </param>
        /// <param name="approvals">
        /// The list of approval responses
        /// </param>
        /// <param name="groupId">
        /// The multi-agent group that the message was sent in
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApprovalCreate(
            string? type,
            global::System.Collections.Generic.IList<global::G.ApprovalsVariant1Item>? approvals,
            string? groupId)
        {
            this.Type = type;
            this.Approvals = approvals;
            this.GroupId = groupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApprovalCreate" /> class.
        /// </summary>
        public ApprovalCreate()
        {
        }
    }
}