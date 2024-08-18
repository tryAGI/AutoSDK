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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.MessageDeltaContentRefusalObjectTypeJsonConverter))]
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
    }
}