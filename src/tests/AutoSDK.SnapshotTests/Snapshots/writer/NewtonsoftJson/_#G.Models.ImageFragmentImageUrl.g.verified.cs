//HintName: G.Models.ImageFragmentImageUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The image URL object containing the location of the image.
    /// </summary>
    public sealed partial class ImageFragmentImageUrl
    {
        /// <summary>
        /// The URL pointing to the image file. Supports common image formats like JPEG, PNG, GIF, etc.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageFragmentImageUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL pointing to the image file. Supports common image formats like JPEG, PNG, GIF, etc.
        /// </param>
        public ImageFragmentImageUrl(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageFragmentImageUrl" /> class.
        /// </summary>
        public ImageFragmentImageUrl()
        {
        }
    }
}