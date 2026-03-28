//HintName: G.Models.MessagesSearchResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// transcript_index: index of the message in the conversation transcript<br/>
    /// chunk_text: text of the transcript; transcript messages if very long could have several chunks.<br/>
    /// score: similarity score of the message to the search query
    /// </summary>
    public sealed partial class MessagesSearchResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TranscriptIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChunkText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_start_time_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConversationStartTimeUnixSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesSearchResult" /> class.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="agentId"></param>
        /// <param name="transcriptIndex"></param>
        /// <param name="chunkText"></param>
        /// <param name="score"></param>
        /// <param name="conversationStartTimeUnixSecs"></param>
        /// <param name="agentName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesSearchResult(
            string conversationId,
            string agentId,
            int transcriptIndex,
            string chunkText,
            double score,
            int conversationStartTimeUnixSecs,
            string? agentName)
        {
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentName = agentName;
            this.TranscriptIndex = transcriptIndex;
            this.ChunkText = chunkText ?? throw new global::System.ArgumentNullException(nameof(chunkText));
            this.Score = score;
            this.ConversationStartTimeUnixSecs = conversationStartTimeUnixSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesSearchResult" /> class.
        /// </summary>
        public MessagesSearchResult()
        {
        }
    }
}