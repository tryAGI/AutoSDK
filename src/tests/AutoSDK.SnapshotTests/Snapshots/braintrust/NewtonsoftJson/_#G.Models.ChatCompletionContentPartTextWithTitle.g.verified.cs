//HintName: G.Models.ChatCompletionContentPartTextWithTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionContentPartTextWithTitle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ChatCompletionContentPartTextWithTitleType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_control")]
        public global::G.ChatCompletionContentPartTextWithTitleCacheControl? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartTextWithTitle" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type"></param>
        /// <param name="cacheControl"></param>
        public ChatCompletionContentPartTextWithTitle(
            string? text,
            global::G.ChatCompletionContentPartTextWithTitleType type,
            global::G.ChatCompletionContentPartTextWithTitleCacheControl? cacheControl)
        {
            this.Text = text;
            this.Type = type;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartTextWithTitle" /> class.
        /// </summary>
        public ChatCompletionContentPartTextWithTitle()
        {
        }
    }
}