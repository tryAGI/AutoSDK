//HintName: G.Models.CreateConversationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConversationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_url")]
        public string? ConversationUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_name")]
        public string? ConversationName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meeting_token")]
        public string? MeetingToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationResponse" /> class.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="conversationUrl"></param>
        /// <param name="conversationName"></param>
        /// <param name="status"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="meetingToken"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConversationResponse(
            string? conversationId,
            string? conversationUrl,
            string? conversationName,
            string? status,
            string? callbackUrl,
            string? meetingToken,
            global::System.DateTime? createdAt)
        {
            this.ConversationId = conversationId;
            this.ConversationUrl = conversationUrl;
            this.ConversationName = conversationName;
            this.Status = status;
            this.CallbackUrl = callbackUrl;
            this.MeetingToken = meetingToken;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationResponse" /> class.
        /// </summary>
        public CreateConversationResponse()
        {
        }
    }
}