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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The ID of the tool call that corresponds to this approval
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolCallId { get; set; } = default!;

        /// <summary>
        /// Whether the tool has been approved
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approve", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Approve { get; set; } = default!;

        /// <summary>
        /// An optional explanation for the provided approval status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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