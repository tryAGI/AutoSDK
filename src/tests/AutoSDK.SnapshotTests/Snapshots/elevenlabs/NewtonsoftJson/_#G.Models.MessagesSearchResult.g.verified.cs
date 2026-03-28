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
        [global::Newtonsoft.Json.JsonProperty("conversation_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConversationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int TranscriptIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_text", Required = global::Newtonsoft.Json.Required.Always)]
        public string ChunkText { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public double Score { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_start_time_unix_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public int ConversationStartTimeUnixSecs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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