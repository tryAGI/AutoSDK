//HintName: G.Models.ImageUrlPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageUrlPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageUrlPublic" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="detail"></param>
        public ImageUrlPublic(
            string url,
            string? detail)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageUrlPublic" /> class.
        /// </summary>
        public ImageUrlPublic()
        {
        }
    }
}