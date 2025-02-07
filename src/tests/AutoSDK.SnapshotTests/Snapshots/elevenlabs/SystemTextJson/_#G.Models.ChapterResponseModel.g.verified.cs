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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapter_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChapterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_conversion_date_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LastConversionDateUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_block_conversion_unix_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LastBlockConversionUnixMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversion_progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ConversionProgress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_be_downloaded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanBeDownloaded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChapterResponseModelStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChapterResponseModelState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statistics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChapterStatisticsResponseModel Statistics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterResponseModel" /> class.
        /// </summary>
        /// <param name="chapterId"></param>
        /// <param name="name"></param>
        /// <param name="lastConversionDateUnix"></param>
        /// <param name="lastBlockConversionUnixMs"></param>
        /// <param name="conversionProgress"></param>
        /// <param name="canBeDownloaded"></param>
        /// <param name="state"></param>
        /// <param name="statistics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChapterResponseModel(
            string chapterId,
            string name,
            int lastConversionDateUnix,
            int lastBlockConversionUnixMs,
            double conversionProgress,
            bool canBeDownloaded,
            global::G.ChapterResponseModelState state,
            global::G.ChapterStatisticsResponseModel statistics)
        {
            this.ChapterId = chapterId ?? throw new global::System.ArgumentNullException(nameof(chapterId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.LastConversionDateUnix = lastConversionDateUnix;
            this.LastBlockConversionUnixMs = lastBlockConversionUnixMs;
            this.ConversionProgress = conversionProgress;
            this.CanBeDownloaded = canBeDownloaded;
            this.State = state;
            this.Statistics = statistics ?? throw new global::System.ArgumentNullException(nameof(statistics));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterResponseModel" /> class.
        /// </summary>
        public ChapterResponseModel()
        {
        }
    }
}