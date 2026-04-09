//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf0TypeJsonConverter))]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf0Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("citations")]
        public global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItems>? Citations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_control")]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf0CacheControl? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items0" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type"></param>
        /// <param name="citations"></param>
        /// <param name="cacheControl"></param>
        public MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items0(
            string text,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf0Type type,
            global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItems>? citations,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf0CacheControl? cacheControl)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Citations = citations;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items0" /> class.
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1Items0()
        {
        }
    }
}