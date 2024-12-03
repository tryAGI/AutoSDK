//HintName: G.Models.MessageRequestContentTextObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The text content that is part of a message.
    /// </summary>
    public sealed partial class MessageRequestContentTextObject
    {
        /// <summary>
        /// Always `text`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MessageRequestContentTextObjectType Type { get; set; }

        /// <summary>
        /// Text content to be sent to the model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageRequestContentTextObject" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `text`.
        /// </param>
        /// <param name="text">
        /// Text content to be sent to the model
        /// </param>
        public MessageRequestContentTextObject(
            string text,
            global::G.MessageRequestContentTextObjectType type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageRequestContentTextObject" /> class.
        /// </summary>
        public MessageRequestContentTextObject()
        {
        }
    }
}