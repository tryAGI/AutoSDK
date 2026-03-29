//HintName: G.Models.ChatContentText.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Text content part
    /// </summary>
    public sealed partial class ChatContentText
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ChatContentTextType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Cache control for the content part
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_control")]
        public global::G.ChatContentCacheControl? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentText" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type"></param>
        /// <param name="cacheControl">
        /// Cache control for the content part
        /// </param>
        public ChatContentText(
            string text,
            global::G.ChatContentTextType type,
            global::G.ChatContentCacheControl? cacheControl)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentText" /> class.
        /// </summary>
        public ChatContentText()
        {
        }
    }
}