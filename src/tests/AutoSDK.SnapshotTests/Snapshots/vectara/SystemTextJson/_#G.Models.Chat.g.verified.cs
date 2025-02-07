//HintName: G.Models.Chat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Chat
    {
        /// <summary>
        /// ID of the chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The first query of the chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_query")]
        public string? FirstQuery { get; set; }

        /// <summary>
        /// The first answer of the chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_answer")]
        public string? FirstAnswer { get; set; }

        /// <summary>
        /// Indicates whether this chat is enabled and can have further turns.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Specifies when this chat was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Chat" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the chat.
        /// </param>
        /// <param name="firstQuery">
        /// The first query of the chat.
        /// </param>
        /// <param name="firstAnswer">
        /// The first answer of the chat.
        /// </param>
        /// <param name="enabled">
        /// Indicates whether this chat is enabled and can have further turns.<br/>
        /// Example: true
        /// </param>
        /// <param name="createdAt">
        /// Specifies when this chat was created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Chat(
            string? id,
            string? firstQuery,
            string? firstAnswer,
            bool? enabled,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.FirstQuery = firstQuery;
            this.FirstAnswer = firstAnswer;
            this.Enabled = enabled;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chat" /> class.
        /// </summary>
        public Chat()
        {
        }
    }
}