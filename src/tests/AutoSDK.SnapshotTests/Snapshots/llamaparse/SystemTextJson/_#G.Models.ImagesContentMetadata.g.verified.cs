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
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// List of image metadata with presigned URLs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ImageMetadata> Images { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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