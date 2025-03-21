//HintName: G.Models.MessageDeltaContentRefusalObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The refusal content that is part of a message.
    /// </summary>
    public sealed partial class MessageDeltaContentRefusalObject
    {
        /// <summary>
        /// The index of the refusal part in the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Always `refusal`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageDeltaContentRefusalObjectTypeJsonConverter))]
        public global::G.MessageDeltaContentRefusalObjectType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refusal")]
        public string? Refusal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentRefusalObject" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the refusal part in the message.
        /// </param>
        /// <param name="type">
        /// Always `refusal`.
        /// </param>
        /// <param name="refusal"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageDeltaContentRefusalObject(
            int index,
            global::G.MessageDeltaContentRefusalObjectType type,
            string? refusal)
        {
            this.Index = index;
            this.Type = type;
            this.Refusal = refusal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentRefusalObject" /> class.
        /// </summary>
        public MessageDeltaContentRefusalObject()
        {
        }
    }
}