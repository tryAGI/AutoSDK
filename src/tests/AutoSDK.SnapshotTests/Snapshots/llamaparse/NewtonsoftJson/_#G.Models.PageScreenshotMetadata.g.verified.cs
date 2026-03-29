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
        [global::Newtonsoft.Json.JsonProperty("page_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int PageIndex { get; set; } = default!;

        /// <summary>
        /// The ID of the file that the page screenshot was taken from
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid FileId { get; set; } = default!;

        /// <summary>
        /// The size of the image in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_size", Required = global::Newtonsoft.Json.Required.Always)]
        public long ImageSize { get; set; } = default!;

        /// <summary>
        /// Metadata for the screenshot
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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