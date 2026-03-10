//HintName: G.Models.SIPTrunkOutboundCallResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SIPTrunkOutboundCallResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sip_call_id")]
        public string? SipCallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPTrunkOutboundCallResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        /// <param name="conversationId"></param>
        /// <param name="sipCallId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SIPTrunkOutboundCallResponse(
            bool success,
            string message,
            string? conversationId,
            string? sipCallId)
        {
            this.Success = success;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.ConversationId = conversationId;
            this.SipCallId = sipCallId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPTrunkOutboundCallResponse" /> class.
        /// </summary>
        public SIPTrunkOutboundCallResponse()
        {
        }
    }
}