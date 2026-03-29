//HintName: G.Models.ChatMessageFeedback.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatMessageFeedback
    {
        /// <summary>
        /// Unique identifier for the feedback
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Identifier for the chat flow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatflowid")]
        public global::System.Guid? Chatflowid { get; set; }

        /// <summary>
        /// Identifier for the chat
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatId")]
        public string? ChatId { get; set; }

        /// <summary>
        /// Identifier for the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageId")]
        public global::System.Guid? MessageId { get; set; }

        /// <summary>
        /// Rating for the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rating")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatMessageFeedbackRatingJsonConverter))]
        public global::G.ChatMessageFeedbackRating? Rating { get; set; }

        /// <summary>
        /// Feedback content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Date and time when the feedback was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageFeedback" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the feedback
        /// </param>
        /// <param name="chatflowid">
        /// Identifier for the chat flow
        /// </param>
        /// <param name="chatId">
        /// Identifier for the chat
        /// </param>
        /// <param name="messageId">
        /// Identifier for the message
        /// </param>
        /// <param name="rating">
        /// Rating for the message
        /// </param>
        /// <param name="content">
        /// Feedback content
        /// </param>
        /// <param name="createdDate">
        /// Date and time when the feedback was created
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatMessageFeedback(
            global::System.Guid? id,
            global::System.Guid? chatflowid,
            string? chatId,
            global::System.Guid? messageId,
            global::G.ChatMessageFeedbackRating? rating,
            string? content,
            global::System.DateTime? createdDate)
        {
            this.Id = id;
            this.Chatflowid = chatflowid;
            this.ChatId = chatId;
            this.MessageId = messageId;
            this.Rating = rating;
            this.Content = content;
            this.CreatedDate = createdDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageFeedback" /> class.
        /// </summary>
        public ChatMessageFeedback()
        {
        }
    }
}