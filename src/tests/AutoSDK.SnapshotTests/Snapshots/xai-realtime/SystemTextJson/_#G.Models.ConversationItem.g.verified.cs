//HintName: G.Models.ConversationItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A conversation item (message or function output).
    /// </summary>
    public sealed partial class ConversationItem
    {
        /// <summary>
        /// Item type: message or function_call_output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Item ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Role: user or assistant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Item status (e.g. completed, in_progress).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Content parts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::G.ContentPart>? Content { get; set; }

        /// <summary>
        /// Function call ID (for function_call_output items).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// Function output JSON string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItem" /> class.
        /// </summary>
        /// <param name="type">
        /// Item type: message or function_call_output.
        /// </param>
        /// <param name="id">
        /// Item ID.
        /// </param>
        /// <param name="role">
        /// Role: user or assistant.
        /// </param>
        /// <param name="status">
        /// Item status (e.g. completed, in_progress).
        /// </param>
        /// <param name="content">
        /// Content parts.
        /// </param>
        /// <param name="callId">
        /// Function call ID (for function_call_output items).
        /// </param>
        /// <param name="output">
        /// Function output JSON string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationItem(
            string? type,
            string? id,
            string? role,
            string? status,
            global::System.Collections.Generic.IList<global::G.ContentPart>? content,
            string? callId,
            string? output)
        {
            this.Type = type;
            this.Id = id;
            this.Role = role;
            this.Status = status;
            this.Content = content;
            this.CallId = callId;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItem" /> class.
        /// </summary>
        public ConversationItem()
        {
        }
    }
}