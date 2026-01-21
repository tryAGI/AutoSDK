//HintName: G.Models.ImageUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageUrl
    {
        /// <summary>
        /// URL of an image. Can be either a base64 data URI or a web URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Controls the level of detail in image processing. `"auto"` is the default and lets the system choose, `"low"` is faster but less detailed, and `"high"` preserves maximum detail. You can save tokens and speed up responses by using detail: `"low"`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public global::G.ImageUrlDetail? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// URL of an image. Can be either a base64 data URI or a web URL.
        /// </param>
        /// <param name="detail">
        /// Controls the level of detail in image processing. `"auto"` is the default and lets the system choose, `"low"` is faster but less detailed, and `"high"` preserves maximum detail. You can save tokens and speed up responses by using detail: `"low"`.
        /// </param>
        public ImageUrl(
            string url,
            global::G.ImageUrlDetail? detail)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageUrl" /> class.
        /// </summary>
        public ImageUrl()
        {
        }
    }
}