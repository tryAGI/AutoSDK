//HintName: G.Models.UrlImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UrlImage
    {
        /// <summary>
        /// The source type for the image.<br/>
        /// Default Value: url
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The URL of the image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlImage" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the image.
        /// </param>
        /// <param name="type">
        /// The source type for the image.<br/>
        /// Default Value: url
        /// </param>
        public UrlImage(
            string url,
            string? type)
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlImage" /> class.
        /// </summary>
        public UrlImage()
        {
        }
    }
}