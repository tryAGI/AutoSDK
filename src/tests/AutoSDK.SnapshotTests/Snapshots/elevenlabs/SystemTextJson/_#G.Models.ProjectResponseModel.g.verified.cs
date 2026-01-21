//HintName: G.Models.ProjectResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"access_level":"viewer","author":"John Doe","can_be_downloaded":true,"content_type":"Novel","cover_image_url":"https://example.com/cover.jpg","create_date_unix":1714204800,"creation_meta":{"creation_progress":0.5,"status":"pending","type":"blank"},"default_model_id":"eleven_multilingual_v2","default_paragraph_voice_id":"JBFqnCBsd6RMkjVDRZzb","default_title_voice_id":"JBFqnCBsd6RMkjVDRZzb","description":"This is a description of my project.","fiction":"fiction","genres":["Novel","Short Story"],"isbn_number":"978-90-274-3964-2","language":"en","last_conversion_date_unix":1714204800,"mature_content":false,"name":"My Project","original_publication_date":"2025-01-01","project_id":"aw1NgEzBg83R7vgmiJt6","quality_check_on":false,"quality_check_on_when_bulk_convert":false,"state":"default","target_audience":"Young Adults","title":"My Project","volume_normalization":true}
    /// </summary>
    public sealed partial class ProjectResponseModel
    {
        /// <summary>
        /// The ID of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The name of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The creation date of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_date_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreateDateUnix { get; set; }

        /// <summary>
        /// The default title voice ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_title_voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultTitleVoiceId { get; set; }

        /// <summary>
        /// The default paragraph voice ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_paragraph_voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultParagraphVoiceId { get; set; }

        /// <summary>
        /// The default model ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultModelId { get; set; }

        /// <summary>
        /// The last conversion date of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_conversion_date_unix")]
        public int? LastConversionDateUnix { get; set; }

        /// <summary>
        /// Whether the project can be downloaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_be_downloaded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanBeDownloaded { get; set; }

        /// <summary>
        /// The title of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The author of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public string? Author { get; set; }

        /// <summary>
        /// The description of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// List of genres of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genres")]
        public global::System.Collections.Generic.IList<string>? Genres { get; set; }

        /// <summary>
        /// The cover image URL of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_image_url")]
        public string? CoverImageUrl { get; set; }

        /// <summary>
        /// The target audience of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_audience")]
        public global::G.ProjectResponseModelTargetAudience2? TargetAudience { get; set; }

        /// <summary>
        /// Two-letter language code (ISO 639-1) of the language of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The content type of the project, e.g. 'Novel' or 'Short Story'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// The original publication date of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_publication_date")]
        public string? OriginalPublicationDate { get; set; }

        /// <summary>
        /// Whether the project contains mature content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mature_content")]
        public bool? MatureContent { get; set; }

        /// <summary>
        /// The ISBN number of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isbn_number")]
        public string? IsbnNumber { get; set; }

        /// <summary>
        /// Whether the project uses volume normalization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_normalization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool VolumeNormalization { get; set; }

        /// <summary>
        /// The state of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProjectResponseModelStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProjectResponseModelState State { get; set; }

        /// <summary>
        /// The access level of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProjectResponseModelAccessLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProjectResponseModelAccessLevel AccessLevel { get; set; }

        /// <summary>
        /// Whether the project is fiction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fiction")]
        public global::G.ProjectResponseModelFiction2? Fiction { get; set; }

        /// <summary>
        /// Whether quality check is enabled for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality_check_on")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool QualityCheckOn { get; set; }

        /// <summary>
        /// Whether quality check is enabled on the project when bulk converting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality_check_on_when_bulk_convert")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool QualityCheckOnWhenBulkConvert { get; set; }

        /// <summary>
        /// The creation meta of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_meta")]
        public global::G.ProjectCreationMetaResponseModel? CreationMeta { get; set; }

        /// <summary>
        /// The source type of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        public global::G.ProjectResponseModelSourceType2? SourceType { get; set; }

        /// <summary>
        /// Whether chapters are enabled for the project.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapters_enabled")]
        public bool? ChaptersEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectResponseModel" /> class.
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
        /// <param name="creationMeta">
        /// The creation meta of the project.
        /// </param>
        /// <param name="sourceType">
        /// The source type of the project.
        /// </param>
        /// <param name="chaptersEnabled">
        /// Whether chapters are enabled for the project.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectResponseModel(
            string projectId,
            string name,
            int createDateUnix,
            string defaultTitleVoiceId,
            string defaultParagraphVoiceId,
            string defaultModelId,
            bool canBeDownloaded,
            bool volumeNormalization,
            global::G.ProjectResponseModelState state,
            global::G.ProjectResponseModelAccessLevel accessLevel,
            bool qualityCheckOn,
            bool qualityCheckOnWhenBulkConvert,
            int? lastConversionDateUnix,
            string? title,
            string? author,
            string? description,
            global::System.Collections.Generic.IList<string>? genres,
            string? coverImageUrl,
            global::G.ProjectResponseModelTargetAudience2? targetAudience,
            string? language,
            string? contentType,
            string? originalPublicationDate,
            bool? matureContent,
            string? isbnNumber,
            global::G.ProjectResponseModelFiction2? fiction,
            global::G.ProjectCreationMetaResponseModel? creationMeta,
            global::G.ProjectResponseModelSourceType2? sourceType,
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
        /// Initializes a new instance of the <see cref="ProjectResponseModel" /> class.
        /// </summary>
        public ProjectResponseModel()
        {
        }
    }
}