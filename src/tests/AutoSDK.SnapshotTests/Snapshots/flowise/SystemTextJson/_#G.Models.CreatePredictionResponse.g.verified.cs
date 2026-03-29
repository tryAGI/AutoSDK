//HintName: G.Models.CreatePredictionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePredictionResponse
    {
        /// <summary>
        /// The AI-generated response text<br/>
        /// Example: Artificial intelligence (AI) is a branch of computer science that focuses on creating systems capable of performing tasks that typically require human intelligence.
        /// </summary>
        /// <example>Artificial intelligence (AI) is a branch of computer science that focuses on creating systems capable of performing tasks that typically require human intelligence.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The result in JSON format if available (for structured outputs)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json")]
        public object? Json { get; set; }

        /// <summary>
        /// The original question/message sent to the flow<br/>
        /// Example: What is artificial intelligence?
        /// </summary>
        /// <example>What is artificial intelligence?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("question")]
        public string? Question { get; set; }

        /// <summary>
        /// Unique identifier for the chat session<br/>
        /// Example: chat-12345
        /// </summary>
        /// <example>chat-12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatId")]
        public string? ChatId { get; set; }

        /// <summary>
        /// Unique identifier for this specific message<br/>
        /// Example: msg-67890
        /// </summary>
        /// <example>msg-67890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatMessageId")]
        public string? ChatMessageId { get; set; }

        /// <summary>
        /// Session identifier for conversation continuity<br/>
        /// Example: user-session-123
        /// </summary>
        /// <example>user-session-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Type of memory used for conversation context<br/>
        /// Example: Buffer Memory
        /// </summary>
        /// <example>Buffer Memory</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoryType")]
        public string? MemoryType { get; set; }

        /// <summary>
        /// Documents retrieved from vector store (if RAG is enabled)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceDocuments")]
        public global::System.Collections.Generic.IList<global::G.Document>? SourceDocuments { get; set; }

        /// <summary>
        /// Tools that were invoked during the response generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usedTools")]
        public global::System.Collections.Generic.IList<global::G.UsedTool>? UsedTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionResponse" /> class.
        /// </summary>
        /// <param name="text">
        /// The AI-generated response text<br/>
        /// Example: Artificial intelligence (AI) is a branch of computer science that focuses on creating systems capable of performing tasks that typically require human intelligence.
        /// </param>
        /// <param name="json">
        /// The result in JSON format if available (for structured outputs)
        /// </param>
        /// <param name="question">
        /// The original question/message sent to the flow<br/>
        /// Example: What is artificial intelligence?
        /// </param>
        /// <param name="chatId">
        /// Unique identifier for the chat session<br/>
        /// Example: chat-12345
        /// </param>
        /// <param name="chatMessageId">
        /// Unique identifier for this specific message<br/>
        /// Example: msg-67890
        /// </param>
        /// <param name="sessionId">
        /// Session identifier for conversation continuity<br/>
        /// Example: user-session-123
        /// </param>
        /// <param name="memoryType">
        /// Type of memory used for conversation context<br/>
        /// Example: Buffer Memory
        /// </param>
        /// <param name="sourceDocuments">
        /// Documents retrieved from vector store (if RAG is enabled)
        /// </param>
        /// <param name="usedTools">
        /// Tools that were invoked during the response generation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePredictionResponse(
            string? text,
            object? json,
            string? question,
            string? chatId,
            string? chatMessageId,
            string? sessionId,
            string? memoryType,
            global::System.Collections.Generic.IList<global::G.Document>? sourceDocuments,
            global::System.Collections.Generic.IList<global::G.UsedTool>? usedTools)
        {
            this.Text = text;
            this.Json = json;
            this.Question = question;
            this.ChatId = chatId;
            this.ChatMessageId = chatMessageId;
            this.SessionId = sessionId;
            this.MemoryType = memoryType;
            this.SourceDocuments = sourceDocuments;
            this.UsedTools = usedTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionResponse" /> class.
        /// </summary>
        public CreatePredictionResponse()
        {
        }
    }
}