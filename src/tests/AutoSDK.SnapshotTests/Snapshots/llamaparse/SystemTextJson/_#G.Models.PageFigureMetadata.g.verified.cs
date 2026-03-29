//HintName: G.Models.PageFigureMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PageFigureMetadata
    {
        /// <summary>
        /// The name of the figure
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("figure_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FigureName { get; set; }

        /// <summary>
        /// The ID of the file that the figure was taken from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid FileId { get; set; }

        /// <summary>
        /// The index of the page for which the figure is taken (0-indexed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageIndex { get; set; }

        /// <summary>
        /// The size of the figure in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("figure_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long FigureSize { get; set; }

        /// <summary>
        /// Whether the figure is likely to be noise<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_likely_noise")]
        public bool? IsLikelyNoise { get; set; }

        /// <summary>
        /// The confidence of the figure
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// Metadata for the figure
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PageFigureMetadata" /> class.
        /// </summary>
        /// <param name="figureName">
        /// The name of the figure
        /// </param>
        /// <param name="fileId">
        /// The ID of the file that the figure was taken from
        /// </param>
        /// <param name="pageIndex">
        /// The index of the page for which the figure is taken (0-indexed)
        /// </param>
        /// <param name="figureSize">
        /// The size of the figure in bytes
        /// </param>
        /// <param name="confidence">
        /// The confidence of the figure
        /// </param>
        /// <param name="isLikelyNoise">
        /// Whether the figure is likely to be noise<br/>
        /// Default Value: false
        /// </param>
        /// <param name="metadata">
        /// Metadata for the figure
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PageFigureMetadata(
            string figureName,
            global::System.Guid fileId,
            int pageIndex,
            long figureSize,
            double confidence,
            bool? isLikelyNoise,
            object? metadata)
        {
            this.FigureName = figureName ?? throw new global::System.ArgumentNullException(nameof(figureName));
            this.FileId = fileId;
            this.PageIndex = pageIndex;
            this.FigureSize = figureSize;
            this.IsLikelyNoise = isLikelyNoise;
            this.Confidence = confidence;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageFigureMetadata" /> class.
        /// </summary>
        public PageFigureMetadata()
        {
        }
    }
}