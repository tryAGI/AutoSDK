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
        [global::System.Text.Json.Serialization.JsonPropertyName("chapter_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChapterId { get; set; }

        /// <summary>
        /// The name of the chapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The last conversion date of the chapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_conversion_date_unix")]
        public int? LastConversionDateUnix { get; set; }

        /// <summary>
        /// The conversion progress of the chapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversion_progress")]
        public double? ConversionProgress { get; set; }

        /// <summary>
        /// Whether the chapter can be downloaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_be_downloaded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanBeDownloaded { get; set; }

        /// <summary>
        /// The state of the chapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChapterResponseModelStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChapterResponseModelState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statistics")]
        public global::G.ChapterStatisticsResponseModel? Statistics { get; set; }

        /// <summary>
        /// The last conversion error of the chapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_conversion_error")]
        public string? LastConversionError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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