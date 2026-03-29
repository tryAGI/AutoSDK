//HintName: G.Models.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2Type? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approve", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Approve { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolCallId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2" /> class.
        /// </summary>
        /// <param name="approve"></param>
        /// <param name="toolCallId"></param>
        /// <param name="type"></param>
        /// <param name="reason"></param>
        public EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2(
            bool approve,
            string toolCallId,
            global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2Type? type,
            string? reason)
        {
            this.Type = type;
            this.Approve = approve;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2" /> class.
        /// </summary>
        public EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2()
        {
        }
    }
}