//HintName: G.Models.MessageDeltaContentTextObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The text content that is part of a message.
    /// </summary>
    public sealed partial class MessageDeltaContentTextObject
    {
        /// <summary>
        /// The index of the content part in the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::G.MessageDeltaContentTextObjectText? Text { get; set; }

        /// <summary>
        /// Always `text`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageDeltaContentTextObjectTypeJsonConverter))]
        public global::G.MessageDeltaContentTextObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextObject" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the content part in the message.
        /// </param>
        /// <param name="text"></param>
        /// <param name="type">
        /// Always `text`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageDeltaContentTextObject(
            int index,
            global::G.MessageDeltaContentTextObjectText? text,
            global::G.MessageDeltaContentTextObjectType type)
        {
            this.Index = index;
            this.Text = text;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextObject" /> class.
        /// </summary>
        public MessageDeltaContentTextObject()
        {
        }
    }
}