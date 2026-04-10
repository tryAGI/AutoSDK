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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The index of the message in the chat.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// Retrieval annotations for the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotations")]
        public global::System.Collections.Generic.IList<global::G.MessageAnnotation>? Annotations { get; set; }

        /// <summary>
        /// The role of the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MessageRoleJsonConverter))]
        public global::G.MessageRole Role { get; set; } = default!;

        /// <summary>
        /// Text content of the generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional arguments passed to the model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additional_kwargs")]
        public global::System.Collections.Generic.Dictionary<string, string>? AdditionalKwargs { get; set; }

        /// <summary>
        /// Default Value: base_component
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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