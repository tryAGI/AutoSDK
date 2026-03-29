//HintName: G.Models.Conversation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Conversation
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
        [global::Newtonsoft.Json.JsonProperty("replica_id")]
        public string? ReplicaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("persona_id")]
        public string? PersonaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ended_at")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shutdown_reason")]
        public string? ShutdownReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript")]
        public global::System.Collections.Generic.IList<global::G.TranscriptMessage>? Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Conversation" /> class.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="conversationUrl"></param>
        /// <param name="conversationName"></param>
        /// <param name="status"></param>
        /// <param name="replicaId"></param>
        /// <param name="personaId"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="endedAt"></param>
        /// <param name="shutdownReason"></param>
        /// <param name="transcript"></param>
        public Conversation(
            string? conversationId,
            string? conversationUrl,
            string? conversationName,
            string? status,
            string? replicaId,
            string? personaId,
            string? callbackUrl,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.DateTime? endedAt,
            string? shutdownReason,
            global::System.Collections.Generic.IList<global::G.TranscriptMessage>? transcript)
        {
            this.ConversationId = conversationId;
            this.ConversationUrl = conversationUrl;
            this.ConversationName = conversationName;
            this.Status = status;
            this.ReplicaId = replicaId;
            this.PersonaId = personaId;
            this.CallbackUrl = callbackUrl;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.EndedAt = endedAt;
            this.ShutdownReason = shutdownReason;
            this.Transcript = transcript;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Conversation" /> class.
        /// </summary>
        public Conversation()
        {
        }
    }
}