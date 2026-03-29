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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The index of the message in the chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Retrieval annotations for the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::System.Collections.Generic.IList<global::G.MessageAnnotation>? Annotations { get; set; }

        /// <summary>
        /// The role of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MessageRole Role { get; set; }

        /// <summary>
        /// Text content of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional arguments passed to the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_kwargs")]
        public global::System.Collections.Generic.Dictionary<string, string>? AdditionalKwargs { get; set; }

        /// <summary>
        /// Default Value: base_component
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessage" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="index">
        /// The index of the message in the chat.
        /// </param>
        /// <param name="role">
        /// The role of the message.
        /// </param>
        /// <param name="annotations">
        /// Retrieval annotations for the message.
        /// </param>
        /// <param name="content">
        /// Text content of the generation
        /// </param>
        /// <param name="additionalKwargs">
        /// Additional arguments passed to the model
        /// </param>
        /// <param name="className">
        /// Default Value: base_component
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatMessage(
            global::System.Guid id,
            int index,
            global::G.MessageRole role,
            global::System.Collections.Generic.IList<global::G.MessageAnnotation>? annotations,
            string? content,
            global::System.Collections.Generic.Dictionary<string, string>? additionalKwargs,
            string? className)
        {
            this.Id = id;
            this.Index = index;
            this.Annotations = annotations;
            this.Role = role;
            this.Content = content;
            this.AdditionalKwargs = additionalKwargs;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessage" /> class.
        /// </summary>
        public ChatMessage()
        {
        }
    }
}