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
        [global::Newtonsoft.Json.JsonProperty("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_url")]
        public string? ConversationUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_name")]
        public string? ConversationName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meeting_token")]
        public string? MeetingToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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