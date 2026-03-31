//HintName: G.Models.ChatResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChatResponseMatche2> Matches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DocumentIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public string? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatResponseChatMode2JsonConverter))]
        public global::G.ChatResponseChatMode2? ChatMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoId")]
        public string? VideoId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatResponse2" /> class.
        /// </summary>
        /// <param name="matches"></param>
        /// <param name="documentIds"></param>
        /// <param name="result"></param>
        /// <param name="chatMode"></param>
        /// <param name="videoId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatResponse2(
            global::System.Collections.Generic.IList<global::G.ChatResponseMatche2> matches,
            global::System.Collections.Generic.IList<string> documentIds,
            string? result,
            global::G.ChatResponseChatMode2? chatMode,
            string? videoId)
        {
            this.Matches = matches ?? throw new global::System.ArgumentNullException(nameof(matches));
            this.DocumentIds = documentIds ?? throw new global::System.ArgumentNullException(nameof(documentIds));
            this.Result = result;
            this.ChatMode = chatMode;
            this.VideoId = videoId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatResponse2" /> class.
        /// </summary>
        public ChatResponse2()
        {
        }
    }
}