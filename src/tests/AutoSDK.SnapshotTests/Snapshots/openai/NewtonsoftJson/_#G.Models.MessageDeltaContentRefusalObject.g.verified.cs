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
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refusal")]
        public string? Refusal { get; set; }

        /// <summary>
        /// Always `refusal`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MessageDeltaContentRefusalObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentRefusalObject" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the refusal part in the message.
        /// </param>
        /// <param name="refusal"></param>
        /// <param name="type">
        /// Always `refusal`.
        /// </param>
        public MessageDeltaContentRefusalObject(
            int index,
            string? refusal,
            global::G.MessageDeltaContentRefusalObjectType type)
        {
            this.Index = index;
            this.Refusal = refusal;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentRefusalObject" /> class.
        /// </summary>
        public MessageDeltaContentRefusalObject()
        {
        }
    }
}