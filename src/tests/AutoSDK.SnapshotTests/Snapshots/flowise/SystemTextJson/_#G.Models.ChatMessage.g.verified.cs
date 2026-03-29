//HintName: G.Models.ChatMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatMessage
    {
        /// <summary>
        /// Example: d290f1ee-6c54-4b01-90e6-d701748f0851
        /// </summary>
        /// <example>d290f1ee-6c54-4b01-90e6-d701748f0851</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Example: apiMessage
        /// </summary>
        /// <example>apiMessage</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatMessageRoleJsonConverter))]
        public global::G.ChatMessageRole? Role { get; set; }

        /// <summary>
        /// Example: d290f1ee-6c54-4b01-90e6-d701748f0852
        /// </summary>
        /// <example>d290f1ee-6c54-4b01-90e6-d701748f0852</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatflowid")]
        public global::System.Guid? Chatflowid { get; set; }

        /// <summary>
        /// Example: Hello, how can I help you today?
        /// </summary>
        /// <example>Hello, how can I help you today?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceDocuments")]
        public global::System.Collections.Generic.IList<global::G.Document>? SourceDocuments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usedTools")]
        public global::System.Collections.Generic.IList<global::G.UsedTool>? UsedTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileAnnotations")]
        public global::System.Collections.Generic.IList<global::G.FileAnnotation>? FileAnnotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentReasoning")]
        public global::System.Collections.Generic.IList<global::G.AgentReasoning>? AgentReasoning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUploads")]
        public global::System.Collections.Generic.IList<global::G.FileUpload>? FileUploads { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public global::System.Collections.Generic.IList<global::G.Action>? Action { get; set; }

        /// <summary>
        /// Example: INTERNAL
        /// </summary>
        /// <example>INTERNAL</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatMessageChatTypeJsonConverter))]
        public global::G.ChatMessageChatType? ChatType { get; set; }

        /// <summary>
        /// Example: chat12345
        /// </summary>
        /// <example>chat12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatId")]
        public string? ChatId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoryType")]
        public string? MemoryType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Example: 2024-08-24T14:15:22Z
        /// </summary>
        /// <example>2024-08-24T14:15:22Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Example: user@example.com
        /// </summary>
        /// <example>user@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("leadEmail")]
        public string? LeadEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessage" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: d290f1ee-6c54-4b01-90e6-d701748f0851
        /// </param>
        /// <param name="role">
        /// Example: apiMessage
        /// </param>
        /// <param name="chatflowid">
        /// Example: d290f1ee-6c54-4b01-90e6-d701748f0852
        /// </param>
        /// <param name="content">
        /// Example: Hello, how can I help you today?
        /// </param>
        /// <param name="sourceDocuments"></param>
        /// <param name="usedTools"></param>
        /// <param name="fileAnnotations"></param>
        /// <param name="agentReasoning"></param>
        /// <param name="fileUploads"></param>
        /// <param name="action"></param>
        /// <param name="chatType">
        /// Example: INTERNAL
        /// </param>
        /// <param name="chatId">
        /// Example: chat12345
        /// </param>
        /// <param name="memoryType"></param>
        /// <param name="sessionId"></param>
        /// <param name="createdDate">
        /// Example: 2024-08-24T14:15:22Z
        /// </param>
        /// <param name="leadEmail">
        /// Example: user@example.com
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatMessage(
            global::System.Guid? id,
            global::G.ChatMessageRole? role,
            global::System.Guid? chatflowid,
            string? content,
            global::System.Collections.Generic.IList<global::G.Document>? sourceDocuments,
            global::System.Collections.Generic.IList<global::G.UsedTool>? usedTools,
            global::System.Collections.Generic.IList<global::G.FileAnnotation>? fileAnnotations,
            global::System.Collections.Generic.IList<global::G.AgentReasoning>? agentReasoning,
            global::System.Collections.Generic.IList<global::G.FileUpload>? fileUploads,
            global::System.Collections.Generic.IList<global::G.Action>? action,
            global::G.ChatMessageChatType? chatType,
            string? chatId,
            string? memoryType,
            string? sessionId,
            global::System.DateTime? createdDate,
            string? leadEmail)
        {
            this.Id = id;
            this.Role = role;
            this.Chatflowid = chatflowid;
            this.Content = content;
            this.SourceDocuments = sourceDocuments;
            this.UsedTools = usedTools;
            this.FileAnnotations = fileAnnotations;
            this.AgentReasoning = agentReasoning;
            this.FileUploads = fileUploads;
            this.Action = action;
            this.ChatType = chatType;
            this.ChatId = chatId;
            this.MemoryType = memoryType;
            this.SessionId = sessionId;
            this.CreatedDate = createdDate;
            this.LeadEmail = leadEmail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessage" /> class.
        /// </summary>
        public ChatMessage()
        {
        }
    }
}