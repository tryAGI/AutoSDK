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
        [global::Newtonsoft.Json.JsonProperty("figure_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FigureName { get; set; } = default!;

        /// <summary>
        /// The ID of the file that the figure was taken from
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid FileId { get; set; } = default!;

        /// <summary>
        /// The index of the page for which the figure is taken (0-indexed)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int PageIndex { get; set; } = default!;

        /// <summary>
        /// The size of the figure in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("figure_size", Required = global::Newtonsoft.Json.Required.Always)]
        public long FigureSize { get; set; } = default!;

        /// <summary>
        /// Whether the figure is likely to be noise<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_likely_noise")]
        public bool? IsLikelyNoise { get; set; }

        /// <summary>
        /// The confidence of the figure
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence", Required = global::Newtonsoft.Json.Required.Always)]
        public double Confidence { get; set; } = default!;

        /// <summary>
        /// Metadata for the figure
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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