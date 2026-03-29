//HintName: G.Models.BaseMessagesResultContentItemsOneOf6ContentOneOf1Content.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf6ContentOneOf1Content
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentCitations, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentCitations, object> Citations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentTypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf6ContentOneOf1Content" /> class.
        /// </summary>
        /// <param name="citations"></param>
        /// <param name="source"></param>
        /// <param name="title"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseMessagesResultContentItemsOneOf6ContentOneOf1Content(
            global::G.OneOf<global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentCitations, object> citations,
            global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource source,
            string? title,
            global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentType type)
        {
            this.Citations = citations;
            this.Source = source;
            this.Title = title;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf6ContentOneOf1Content" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf6ContentOneOf1Content()
        {
        }
    }
}