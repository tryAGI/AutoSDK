//HintName: G.Models.ChapterWithContentResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"can_be_downloaded":true,"chapter_id":"aw1NgEzBg83R7vgmiJt6","content":{"blocks":[]},"conversion_progress":0.5,"last_conversion_date_unix":1714204800,"name":"Chapter 1","state":"default","statistics":{"characters_converted":200,"characters_unconverted":100,"paragraphs_converted":5,"paragraphs_unconverted":3}}
    /// </summary>
    public sealed partial class ChapterWithContentResponseModel
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChapterWithContentResponseModelStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChapterWithContentResponseModelState State { get; set; }

        /// <summary>
        /// Whether the chapter has a video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_video")]
        public bool? HasVideo { get; set; }

        /// <summary>
        /// Whether the chapter has any visual content (video, image, or text clips).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_visual_content")]
        public bool? HasVisualContent { get; set; }

        /// <summary>
        /// List of voice ids used by the chapter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_ids")]
        public global::System.Collections.Generic.IList<string>? VoiceIds { get; set; }

        /// <summary>
        /// The statistics of the chapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statistics")]
        public global::G.ChapterStatisticsResponseModel? Statistics { get; set; }

        /// <summary>
        /// The last conversion error of the chapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_conversion_error")]
        public string? LastConversionError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChapterContentResponseModel Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterWithContentResponseModel" /> class.
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
        /// <param name="hasVideo">
        /// Whether the chapter has a video.
        /// </param>
        /// <param name="hasVisualContent">
        /// Whether the chapter has any visual content (video, image, or text clips).
        /// </param>
        /// <param name="voiceIds">
        /// List of voice ids used by the chapter
        /// </param>
        /// <param name="statistics">
        /// The statistics of the chapter.
        /// </param>
        /// <param name="lastConversionError">
        /// The last conversion error of the chapter.
        /// </param>
        /// <param name="content"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChapterWithContentResponseModel(
            string chapterId,
            string name,
            bool canBeDownloaded,
            global::G.ChapterWithContentResponseModelState state,
            global::G.ChapterContentResponseModel content,
            int? lastConversionDateUnix,
            double? conversionProgress,
            bool? hasVideo,
            bool? hasVisualContent,
            global::System.Collections.Generic.IList<string>? voiceIds,
            global::G.ChapterStatisticsResponseModel? statistics,
            string? lastConversionError)
        {
            this.ChapterId = chapterId ?? throw new global::System.ArgumentNullException(nameof(chapterId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CanBeDownloaded = canBeDownloaded;
            this.State = state;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.LastConversionDateUnix = lastConversionDateUnix;
            this.ConversionProgress = conversionProgress;
            this.HasVideo = hasVideo;
            this.HasVisualContent = hasVisualContent;
            this.VoiceIds = voiceIds;
            this.Statistics = statistics;
            this.LastConversionError = lastConversionError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterWithContentResponseModel" /> class.
        /// </summary>
        public ChapterWithContentResponseModel()
        {
        }
    }
}