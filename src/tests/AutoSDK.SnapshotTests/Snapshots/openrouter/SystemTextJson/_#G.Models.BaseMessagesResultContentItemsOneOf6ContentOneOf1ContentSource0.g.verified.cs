//HintName: G.Models.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0MediaTypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0MediaType MediaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0TypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="mediaType"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0(
            string data,
            global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0MediaType mediaType,
            global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0Type type)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.MediaType = mediaType;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0()
        {
        }
    }
}