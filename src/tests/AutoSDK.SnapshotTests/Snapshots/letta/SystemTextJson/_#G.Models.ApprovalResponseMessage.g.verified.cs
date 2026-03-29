//HintName: G.Models.ApprovalResponseMessage.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A message representing a response form the user indicating whether a tool has been approved to run.<br/>
    /// Args:<br/>
    ///     id (str): The ID of the message<br/>
    ///     date (datetime): The date the message was created in ISO format<br/>
    ///     name (Optional[str]): The name of the sender of the message<br/>
    ///     approve: (bool) Whether the tool has been approved<br/>
    ///     approval_request_id: The ID of the approval request<br/>
    ///     reason: (Optional[str]) An optional explanation for the provided approval status
    /// </summary>
    public sealed partial class ApprovalResponseMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The type of the message.<br/>
        /// Default Value: approval_response_message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        public string? MessageType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otid")]
        public string? Otid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender_id")]
        public string? SenderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_id")]
        public string? StepId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_err")]
        public bool? IsErr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seq_id")]
        public int? SeqId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// The list of approval responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approvals")]
        public global::System.Collections.Generic.IList<global::G.ApprovalsVariant1Item2>? Approvals { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApprovalResponseMessage" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        /// <param name="name"></param>
        /// <param name="messageType">
        /// The type of the message.<br/>
        /// Default Value: approval_response_message
        /// </param>
        /// <param name="otid"></param>
        /// <param name="senderId"></param>
        /// <param name="stepId"></param>
        /// <param name="isErr"></param>
        /// <param name="seqId"></param>
        /// <param name="runId"></param>
        /// <param name="approvals">
        /// The list of approval responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApprovalResponseMessage(
            string id,
            global::System.DateTime date,
            string? name,
            string? messageType,
            string? otid,
            string? senderId,
            string? stepId,
            bool? isErr,
            int? seqId,
            string? runId,
            global::System.Collections.Generic.IList<global::G.ApprovalsVariant1Item2>? approvals)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Date = date;
            this.Name = name;
            this.MessageType = messageType;
            this.Otid = otid;
            this.SenderId = senderId;
            this.StepId = stepId;
            this.IsErr = isErr;
            this.SeqId = seqId;
            this.RunId = runId;
            this.Approvals = approvals;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApprovalResponseMessage" /> class.
        /// </summary>
        public ApprovalResponseMessage()
        {
        }
    }
}