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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2TypeJsonConverter))]
        public global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2Type? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approve")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Approve { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2" /> class.
        /// </summary>
        /// <param name="approve"></param>
        /// <param name="toolCallId"></param>
        /// <param name="type"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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