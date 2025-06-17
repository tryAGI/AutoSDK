//HintName: G.Models.EmbedImageUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base64 url of image.
    /// </summary>
    public sealed partial class EmbedImageUrl
    {
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
        /// Initializes a new instance of the <see cref="EmbedImageUrl" /> class.
        /// </summary>
        /// <param name="url"></param>
        public EmbedImageUrl(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedImageUrl" /> class.
        /// </summary>
        public EmbedImageUrl()
        {
        }
    }
}