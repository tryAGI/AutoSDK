//HintName: G.Models.URLImageSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class URLImageSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.URLImageSourceType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="URLImageSource" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="url"></param>
        public URLImageSource(
            string url,
            global::G.URLImageSourceType type)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="URLImageSource" /> class.
        /// </summary>
        public URLImageSource()
        {
        }
    }
}