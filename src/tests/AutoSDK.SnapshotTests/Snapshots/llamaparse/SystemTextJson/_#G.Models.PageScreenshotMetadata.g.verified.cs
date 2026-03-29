//HintName: G.Models.PageScreenshotMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PageScreenshotMetadata
    {
        /// <summary>
        /// The index of the page for which the screenshot is taken (0-indexed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageIndex { get; set; }

        /// <summary>
        /// The ID of the file that the page screenshot was taken from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid FileId { get; set; }

        /// <summary>
        /// The size of the image in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ImageSize { get; set; }

        /// <summary>
        /// Metadata for the screenshot
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PageScreenshotMetadata" /> class.
        /// </summary>
        /// <param name="pageIndex">
        /// The index of the page for which the screenshot is taken (0-indexed)
        /// </param>
        /// <param name="fileId">
        /// The ID of the file that the page screenshot was taken from
        /// </param>
        /// <param name="imageSize">
        /// The size of the image in bytes
        /// </param>
        /// <param name="metadata">
        /// Metadata for the screenshot
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PageScreenshotMetadata(
            int pageIndex,
            global::System.Guid fileId,
            long imageSize,
            object? metadata)
        {
            this.PageIndex = pageIndex;
            this.FileId = fileId;
            this.ImageSize = imageSize;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageScreenshotMetadata" /> class.
        /// </summary>
        public PageScreenshotMetadata()
        {
        }
    }
}