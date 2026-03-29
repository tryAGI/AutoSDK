//HintName: G.Models.ImagesContentMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata for all extracted images.
    /// </summary>
    public sealed partial class ImagesContentMetadata
    {
        /// <summary>
        /// Total number of extracted images
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// List of image metadata with presigned URLs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("images", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ImageMetadata> Images { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesContentMetadata" /> class.
        /// </summary>
        /// <param name="totalCount">
        /// Total number of extracted images
        /// </param>
        /// <param name="images">
        /// List of image metadata with presigned URLs
        /// </param>
        public ImagesContentMetadata(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.ImageMetadata> images)
        {
            this.TotalCount = totalCount;
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesContentMetadata" /> class.
        /// </summary>
        public ImagesContentMetadata()
        {
        }
    }
}