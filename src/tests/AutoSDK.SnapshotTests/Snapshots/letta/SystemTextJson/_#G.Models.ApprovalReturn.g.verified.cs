//HintName: G.Models.ApprovalReturn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApprovalReturn
    {
        /// <summary>
        /// The message type to be created.<br/>
        /// Default Value: approval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The ID of the tool call that corresponds to this approval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Whether the tool has been approved
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approve")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Approve { get; set; }

        /// <summary>
        /// An optional explanation for the provided approval status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApprovalReturn" /> class.
        /// </summary>
        /// <param name="toolCallId">
        /// The ID of the tool call that corresponds to this approval
        /// </param>
        /// <param name="approve">
        /// Whether the tool has been approved
        /// </param>
        /// <param name="type">
        /// The message type to be created.<br/>
        /// Default Value: approval
        /// </param>
        /// <param name="reason">
        /// An optional explanation for the provided approval status
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApprovalReturn(
            string toolCallId,
            bool approve,
            string? type,
            string? reason)
        {
            this.Type = type;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Approve = approve;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApprovalReturn" /> class.
        /// </summary>
        public ApprovalReturn()
        {
        }
    }
}