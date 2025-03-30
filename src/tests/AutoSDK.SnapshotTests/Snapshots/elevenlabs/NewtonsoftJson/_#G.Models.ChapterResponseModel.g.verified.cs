//HintName: G.Models.ChapterResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChapterResponseModel
    {
        /// <summary>
        /// The ID of the chapter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chapter_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ChapterId { get; set; } = default!;

        /// <summary>
        /// The name of the chapter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The last conversion date of the chapter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_conversion_date_unix")]
        public int? LastConversionDateUnix { get; set; }

        /// <summary>
        /// The conversion progress of the chapter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversion_progress")]
        public double? ConversionProgress { get; set; }

        /// <summary>
        /// Whether the chapter can be downloaded.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_be_downloaded", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanBeDownloaded { get; set; } = default!;

        /// <summary>
        /// The state of the chapter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChapterResponseModelState State { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statistics")]
        public global::G.ChapterStatisticsResponseModel? Statistics { get; set; }

        /// <summary>
        /// The last conversion error of the chapter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_conversion_error")]
        public string? LastConversionError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterResponseModel" /> class.
        /// </summary>
        /// <param name="chapterId">
        /// The ID of the chapter.
        /// </param>
        /// <param name="name">
        /// The name of the chapter.
        /// </param>
        /// <param name="lastConversionDateUnix">
        /// The last conversion date of the chapter.
        /// </param>
        /// <param name="conversionProgress">
        /// The conversion progress of the chapter.
        /// </param>
        /// <param name="canBeDownloaded">
        /// Whether the chapter can be downloaded.
        /// </param>
        /// <param name="state">
        /// The state of the chapter.
        /// </param>
        /// <param name="statistics"></param>
        /// <param name="lastConversionError">
        /// The last conversion error of the chapter.
        /// </param>
        public ChapterResponseModel(
            string chapterId,
            string name,
            bool canBeDownloaded,
            global::G.ChapterResponseModelState state,
            int? lastConversionDateUnix,
            double? conversionProgress,
            global::G.ChapterStatisticsResponseModel? statistics,
            string? lastConversionError)
        {
            this.ChapterId = chapterId ?? throw new global::System.ArgumentNullException(nameof(chapterId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CanBeDownloaded = canBeDownloaded;
            this.State = state;
            this.LastConversionDateUnix = lastConversionDateUnix;
            this.ConversionProgress = conversionProgress;
            this.Statistics = statistics;
            this.LastConversionError = lastConversionError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterResponseModel" /> class.
        /// </summary>
        public ChapterResponseModel()
        {
        }
    }
}