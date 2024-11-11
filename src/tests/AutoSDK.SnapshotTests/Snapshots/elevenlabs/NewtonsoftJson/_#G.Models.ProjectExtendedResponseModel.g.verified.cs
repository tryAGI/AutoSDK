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
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("create_date_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreateDateUnix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_title_voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DefaultTitleVoiceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_paragraph_voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DefaultParagraphVoiceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DefaultModelId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quality_preset", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProjectExtendedResponseModelQualityPreset QualityPreset { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_conversion_date_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int LastConversionDateUnix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_be_downloaded", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanBeDownloaded { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProjectExtendedResponseModelState State { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chapters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChapterResponseModel> Chapters { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pronunciation_dictionary_versions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PronunciationDictionaryVersionResponseModel> PronunciationDictionaryVersions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("volume_normalization", Required = global::Newtonsoft.Json.Required.Always)]
        public bool VolumeNormalization { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author", Required = global::Newtonsoft.Json.Required.Always)]
        public string Author { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("genres", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Genres { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cover_image_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CoverImageUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_audience", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProjectExtendedResponseModelTargetAudience TargetAudience { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContentType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_publication_date", Required = global::Newtonsoft.Json.Required.Always)]
        public string OriginalPublicationDate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mature_content", Required = global::Newtonsoft.Json.Required.Always)]
        public bool MatureContent { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isbn_number", Required = global::Newtonsoft.Json.Required.Always)]
        public string IsbnNumber { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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