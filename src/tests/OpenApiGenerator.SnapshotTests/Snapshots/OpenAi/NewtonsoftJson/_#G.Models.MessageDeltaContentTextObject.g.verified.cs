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
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// Always `text`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageDeltaContentTextObjectType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public global::G.MessageDeltaContentTextObjectText? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}