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
        /// The ID of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// The name of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The creation date of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("create_date_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreateDateUnix { get; set; } = default!;

        /// <summary>
        /// The default title voice ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_title_voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DefaultTitleVoiceId { get; set; } = default!;

        /// <summary>
        /// The default paragraph voice ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_paragraph_voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DefaultParagraphVoiceId { get; set; } = default!;

        /// <summary>
        /// The default model ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DefaultModelId { get; set; } = default!;

        /// <summary>
        /// The last conversion date of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_conversion_date_unix")]
        public int? LastConversionDateUnix { get; set; }

        /// <summary>
        /// Whether the project can be downloaded.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_be_downloaded", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanBeDownloaded { get; set; } = default!;

        /// <summary>
        /// The title of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The author of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author")]
        public string? Author { get; set; }

        /// <summary>
        /// The description of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// List of genres of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("genres")]
        public global::System.Collections.Generic.IList<string>? Genres { get; set; }

        /// <summary>
        /// The cover image URL of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cover_image_url")]
        public string? CoverImageUrl { get; set; }

        /// <summary>
        /// The target audience of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_audience")]
        public global::G.ProjectExtendedResponseModelTargetAudience? TargetAudience { get; set; }

        /// <summary>
        /// Two-letter language code (ISO 639-1) of the language of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The content type of the project, e.g. 'Novel' or 'Short Story'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// The original publication date of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_publication_date")]
        public string? OriginalPublicationDate { get; set; }

        /// <summary>
        /// Whether the project contains mature content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mature_content")]
        public bool? MatureContent { get; set; }

        /// <summary>
        /// The ISBN number of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isbn_number")]
        public string? IsbnNumber { get; set; }

        /// <summary>
        /// Whether the project uses volume normalization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("volume_normalization", Required = global::Newtonsoft.Json.Required.Always)]
        public bool VolumeNormalization { get; set; } = default!;

        /// <summary>
        /// The state of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProjectExtendedResponseModelState State { get; set; } = default!;

        /// <summary>
        /// The access level of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access_level", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProjectExtendedResponseModelAccessLevel AccessLevel { get; set; } = default!;

        /// <summary>
        /// Whether the project is fiction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fiction")]
        public global::G.ProjectExtendedResponseModelFiction? Fiction { get; set; }

        /// <summary>
        /// Whether quality check is enabled for this project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quality_check_on", Required = global::Newtonsoft.Json.Required.Always)]
        public bool QualityCheckOn { get; set; } = default!;

        /// <summary>
        /// Whether quality check is enabled on the project when bulk converting.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quality_check_on_when_bulk_convert", Required = global::Newtonsoft.Json.Required.Always)]
        public bool QualityCheckOnWhenBulkConvert { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creation_meta")]
        public global::G.ProjectCreationMetaResponseModel? CreationMeta { get; set; }

        /// <summary>
        /// The source type of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_type")]
        public global::G.ProjectExtendedResponseModelSourceType? SourceType { get; set; }

        /// <summary>
        /// Whether chapters are enabled for the project.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chapters_enabled")]
        public bool? ChaptersEnabled { get; set; }

        /// <summary>
        /// The quality preset level of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quality_preset", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProjectExtendedResponseModelQualityPreset QualityPreset { get; set; } = default!;

        /// <summary>
        /// List of chapters of the project and their metadata.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chapters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChapterResponseModel> Chapters { get; set; } = default!;

        /// <summary>
        /// List of pronunciation dictionary versions of the project and their metadata.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pronunciation_dictionary_versions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PronunciationDictionaryVersionResponseModel> PronunciationDictionaryVersions { get; set; } = default!;

        /// <summary>
        /// Whether text normalization is applied to the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apply_text_normalization", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProjectExtendedResponseModelApplyTextNormalization ApplyTextNormalization { get; set; } = default!;

        /// <summary>
        /// Experimental features of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experimental", Required = global::Newtonsoft.Json.Required.Always)]
        public object Experimental { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectExtendedResponseModel" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project.
        /// </param>
        /// <param name="name">
        /// The name of the project.
        /// </param>
        /// <param name="createDateUnix">
        /// The creation date of the project.
        /// </param>
        /// <param name="defaultTitleVoiceId">
        /// The default title voice ID.
        /// </param>
        /// <param name="defaultParagraphVoiceId">
        /// The default paragraph voice ID.
        /// </param>
        /// <param name="defaultModelId">
        /// The default model ID.
        /// </param>
        /// <param name="lastConversionDateUnix">
        /// The last conversion date of the project.
        /// </param>
        /// <param name="canBeDownloaded">
        /// Whether the project can be downloaded.
        /// </param>
        /// <param name="title">
        /// The title of the project.
        /// </param>
        /// <param name="author">
        /// The author of the project.
        /// </param>
        /// <param name="description">
        /// The description of the project.
        /// </param>
        /// <param name="genres">
        /// List of genres of the project.
        /// </param>
        /// <param name="coverImageUrl">
        /// The cover image URL of the project.
        /// </param>
        /// <param name="targetAudience">
        /// The target audience of the project.
        /// </param>
        /// <param name="language">
        /// Two-letter language code (ISO 639-1) of the language of the project.
        /// </param>
        /// <param name="contentType">
        /// The content type of the project, e.g. 'Novel' or 'Short Story'
        /// </param>
        /// <param name="originalPublicationDate">
        /// The original publication date of the project.
        /// </param>
        /// <param name="matureContent">
        /// Whether the project contains mature content.
        /// </param>
        /// <param name="isbnNumber">
        /// The ISBN number of the project.
        /// </param>
        /// <param name="volumeNormalization">
        /// Whether the project uses volume normalization.
        /// </param>
        /// <param name="state">
        /// The state of the project.
        /// </param>
        /// <param name="accessLevel">
        /// The access level of the project.
        /// </param>
        /// <param name="fiction">
        /// Whether the project is fiction.
        /// </param>
        /// <param name="qualityCheckOn">
        /// Whether quality check is enabled for this project.
        /// </param>
        /// <param name="qualityCheckOnWhenBulkConvert">
        /// Whether quality check is enabled on the project when bulk converting.
        /// </param>
        /// <param name="creationMeta"></param>
        /// <param name="sourceType">
        /// The source type of the project.
        /// </param>
        /// <param name="chaptersEnabled">
        /// Whether chapters are enabled for the project.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="qualityPreset">
        /// The quality preset level of the project.
        /// </param>
        /// <param name="chapters">
        /// List of chapters of the project and their metadata.
        /// </param>
        /// <param name="pronunciationDictionaryVersions">
        /// List of pronunciation dictionary versions of the project and their metadata.
        /// </param>
        /// <param name="applyTextNormalization">
        /// Whether text normalization is applied to the project.
        /// </param>
        /// <param name="experimental">
        /// Experimental features of the project.
        /// </param>
        public ProjectExtendedResponseModel(
            string projectId,
            string name,
            int createDateUnix,
            string defaultTitleVoiceId,
            string defaultParagraphVoiceId,
            string defaultModelId,
            bool canBeDownloaded,
            bool volumeNormalization,
            global::G.ProjectExtendedResponseModelState state,
            global::G.ProjectExtendedResponseModelAccessLevel accessLevel,
            bool qualityCheckOn,
            bool qualityCheckOnWhenBulkConvert,
            global::G.ProjectExtendedResponseModelQualityPreset qualityPreset,
            global::System.Collections.Generic.IList<global::G.ChapterResponseModel> chapters,
            global::System.Collections.Generic.IList<global::G.PronunciationDictionaryVersionResponseModel> pronunciationDictionaryVersions,
            global::G.ProjectExtendedResponseModelApplyTextNormalization applyTextNormalization,
            object experimental,
            int? lastConversionDateUnix,
            string? title,
            string? author,
            string? description,
            global::System.Collections.Generic.IList<string>? genres,
            string? coverImageUrl,
            global::G.ProjectExtendedResponseModelTargetAudience? targetAudience,
            string? language,
            string? contentType,
            string? originalPublicationDate,
            bool? matureContent,
            string? isbnNumber,
            global::G.ProjectExtendedResponseModelFiction? fiction,
            global::G.ProjectCreationMetaResponseModel? creationMeta,
            global::G.ProjectExtendedResponseModelSourceType? sourceType,
            bool? chaptersEnabled)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreateDateUnix = createDateUnix;
            this.DefaultTitleVoiceId = defaultTitleVoiceId ?? throw new global::System.ArgumentNullException(nameof(defaultTitleVoiceId));
            this.DefaultParagraphVoiceId = defaultParagraphVoiceId ?? throw new global::System.ArgumentNullException(nameof(defaultParagraphVoiceId));
            this.DefaultModelId = defaultModelId ?? throw new global::System.ArgumentNullException(nameof(defaultModelId));
            this.CanBeDownloaded = canBeDownloaded;
            this.VolumeNormalization = volumeNormalization;
            this.State = state;
            this.AccessLevel = accessLevel;
            this.QualityCheckOn = qualityCheckOn;
            this.QualityCheckOnWhenBulkConvert = qualityCheckOnWhenBulkConvert;
            this.QualityPreset = qualityPreset;
            this.Chapters = chapters ?? throw new global::System.ArgumentNullException(nameof(chapters));
            this.PronunciationDictionaryVersions = pronunciationDictionaryVersions ?? throw new global::System.ArgumentNullException(nameof(pronunciationDictionaryVersions));
            this.ApplyTextNormalization = applyTextNormalization;
            this.Experimental = experimental ?? throw new global::System.ArgumentNullException(nameof(experimental));
            this.LastConversionDateUnix = lastConversionDateUnix;
            this.Title = title;
            this.Author = author;
            this.Description = description;
            this.Genres = genres;
            this.CoverImageUrl = coverImageUrl;
            this.TargetAudience = targetAudience;
            this.Language = language;
            this.ContentType = contentType;
            this.OriginalPublicationDate = originalPublicationDate;
            this.MatureContent = matureContent;
            this.IsbnNumber = isbnNumber;
            this.Fiction = fiction;
            this.CreationMeta = creationMeta;
            this.SourceType = sourceType;
            this.ChaptersEnabled = chaptersEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectExtendedResponseModel" /> class.
        /// </summary>
        public ProjectExtendedResponseModel()
        {
        }
    }
}