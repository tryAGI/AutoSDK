//HintName: G.Models.MessagesMessageParamContentOneOf1Items9.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesMessageParamContentOneOf1Items9
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf9Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public string Source { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItems> Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("citations")]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf9Citations? Citations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_control")]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf9CacheControl? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1Items9" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="title"></param>
        /// <param name="content"></param>
        /// <param name="type"></param>
        /// <param name="citations"></param>
        /// <param name="cacheControl"></param>
        public MessagesMessageParamContentOneOf1Items9(
            string source,
            string title,
            global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItems> content,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf9Type type,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf9Citations? citations,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf9CacheControl? cacheControl)
        {
            this.Type = type;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Citations = citations;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1Items9" /> class.
        /// </summary>
        public MessagesMessageParamContentOneOf1Items9()
        {
        }
    }
}