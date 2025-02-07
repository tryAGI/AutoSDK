//HintName: G.Models.ProjectExtendedResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectExtendedResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_date_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreateDateUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_title_voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultTitleVoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_paragraph_voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultParagraphVoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality_preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProjectExtendedResponseModelQualityPresetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProjectExtendedResponseModelQualityPreset QualityPreset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_conversion_date_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LastConversionDateUnix { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProjectExtendedResponseModelStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProjectExtendedResponseModelState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChapterResponseModel> Chapters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionary_versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PronunciationDictionaryVersionResponseModel> PronunciationDictionaryVersions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_normalization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool VolumeNormalization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genres")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Genres { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CoverImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_audience")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProjectExtendedResponseModelTargetAudienceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProjectExtendedResponseModelTargetAudience TargetAudience { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_publication_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalPublicationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mature_content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool MatureContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isbn_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IsbnNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectExtendedResponseModel" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="createDateUnix"></param>
        /// <param name="defaultTitleVoiceId"></param>
        /// <param name="defaultParagraphVoiceId"></param>
        /// <param name="defaultModelId"></param>
        /// <param name="qualityPreset"></param>
        /// <param name="lastConversionDateUnix"></param>
        /// <param name="canBeDownloaded"></param>
        /// <param name="state"></param>
        /// <param name="chapters"></param>
        /// <param name="pronunciationDictionaryVersions"></param>
        /// <param name="volumeNormalization"></param>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="description"></param>
        /// <param name="genres"></param>
        /// <param name="coverImageUrl"></param>
        /// <param name="targetAudience"></param>
        /// <param name="language"></param>
        /// <param name="contentType"></param>
        /// <param name="originalPublicationDate"></param>
        /// <param name="matureContent"></param>
        /// <param name="isbnNumber"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectExtendedResponseModel(
            string projectId,
            string name,
            int createDateUnix,
            string defaultTitleVoiceId,
            string defaultParagraphVoiceId,
            string defaultModelId,
            global::G.ProjectExtendedResponseModelQualityPreset qualityPreset,
            int lastConversionDateUnix,
            bool canBeDownloaded,
            global::G.ProjectExtendedResponseModelState state,
            global::System.Collections.Generic.IList<global::G.ChapterResponseModel> chapters,
            global::System.Collections.Generic.IList<global::G.PronunciationDictionaryVersionResponseModel> pronunciationDictionaryVersions,
            bool volumeNormalization,
            string title,
            string author,
            string description,
            global::System.Collections.Generic.IList<string> genres,
            string coverImageUrl,
            global::G.ProjectExtendedResponseModelTargetAudience targetAudience,
            string language,
            string contentType,
            string originalPublicationDate,
            bool matureContent,
            string isbnNumber)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreateDateUnix = createDateUnix;
            this.DefaultTitleVoiceId = defaultTitleVoiceId ?? throw new global::System.ArgumentNullException(nameof(defaultTitleVoiceId));
            this.DefaultParagraphVoiceId = defaultParagraphVoiceId ?? throw new global::System.ArgumentNullException(nameof(defaultParagraphVoiceId));
            this.DefaultModelId = defaultModelId ?? throw new global::System.ArgumentNullException(nameof(defaultModelId));
            this.QualityPreset = qualityPreset;
            this.LastConversionDateUnix = lastConversionDateUnix;
            this.CanBeDownloaded = canBeDownloaded;
            this.State = state;
            this.Chapters = chapters ?? throw new global::System.ArgumentNullException(nameof(chapters));
            this.PronunciationDictionaryVersions = pronunciationDictionaryVersions ?? throw new global::System.ArgumentNullException(nameof(pronunciationDictionaryVersions));
            this.VolumeNormalization = volumeNormalization;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Genres = genres ?? throw new global::System.ArgumentNullException(nameof(genres));
            this.CoverImageUrl = coverImageUrl ?? throw new global::System.ArgumentNullException(nameof(coverImageUrl));
            this.TargetAudience = targetAudience;
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.OriginalPublicationDate = originalPublicationDate ?? throw new global::System.ArgumentNullException(nameof(originalPublicationDate));
            this.MatureContent = matureContent;
            this.IsbnNumber = isbnNumber ?? throw new global::System.ArgumentNullException(nameof(isbnNumber));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectExtendedResponseModel" /> class.
        /// </summary>
        public ProjectExtendedResponseModel()
        {
        }
    }
}