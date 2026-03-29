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
        [global::System.Text.Json.Serialization.JsonPropertyName("replica_id")]
        public string? ReplicaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("persona_id")]
        public string? PersonaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shutdown_reason")]
        public string? ShutdownReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public global::System.Collections.Generic.IList<global::G.TranscriptMessage>? Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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