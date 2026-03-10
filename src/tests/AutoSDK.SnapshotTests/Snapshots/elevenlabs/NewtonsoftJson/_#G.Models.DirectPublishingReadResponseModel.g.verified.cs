//HintName: G.Models.DirectPublishingReadResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DirectPublishingReadResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("read_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReadId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAtUnix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int UpdatedAtUnix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("word_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int WordCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("char_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int CharCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chapters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ReadMetadataChapterDBModel> Chapters { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author")]
        public string? Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("article_image_url")]
        public string? ArticleImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_mode")]
        public global::G.DirectPublishingReadResponseModelDisplayMode2? DisplayMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("genre")]
        public global::System.Collections.Generic.IList<global::G.DirectPublishingReadResponseModelGenreVariant1Item>? Genre { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fiction")]
        public string? Fiction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_file_type")]
        public string? OriginalFileType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_audience")]
        public global::G.DirectPublishingReadResponseModelTargetAudience2? TargetAudience { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mature_content")]
        public bool? MatureContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("origin")]
        public string? Origin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publication_date")]
        public string? PublicationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isbn")]
        public string? Isbn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ean")]
        public string? Ean { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("legal_terms")]
        public global::G.ReadLegalTerms? LegalTerms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_guidelines_terms")]
        public global::G.ReadLegalTerms? ContentGuidelinesTerms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_from_project_unix")]
        public int? LastUpdatedFromProjectUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publishing_project_id")]
        public string? PublishingProjectId { get; set; }

        /// <summary>
        /// Default Value: published
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publishing_state")]
        public string? PublishingState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publisher_profile_id")]
        public string? PublisherProfileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quality_score")]
        public int? QualityScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publisher")]
        public string? Publisher { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("copyright")]
        public string? Copyright { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subtitle")]
        public string? Subtitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("distribution_territories")]
        public global::System.Collections.Generic.IList<string>? DistributionTerritories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edition")]
        public string? Edition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contributors")]
        public global::System.Collections.Generic.IList<global::G.Contributor>? Contributors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payout_type")]
        public global::G.DirectPublishingReadResponseModelPayoutType2? PayoutType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("list_price")]
        public double? ListPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_audio_project_export_id")]
        public string? OriginalAudioProjectExportId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_audio_document_id")]
        public string? OriginalAudioDocumentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("series_id")]
        public string? SeriesId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("volume")]
        public int? Volume { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("published_at_unix")]
        public int? PublishedAtUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("read_slug")]
        public string? ReadSlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview_audio_object")]
        public global::G.PreviewAudioDBModel? PreviewAudioObject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample_config")]
        public global::G.SampleConfigDBModel? SampleConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review")]
        public global::G.ReviewResponseModel? Review { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_use_assistant")]
        public bool? CanUseAssistant { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectPublishingReadResponseModel" /> class.
        /// </summary>
        /// <param name="readId"></param>
        /// <param name="createdAtUnix"></param>
        /// <param name="updatedAtUnix"></param>
        /// <param name="wordCount"></param>
        /// <param name="charCount"></param>
        /// <param name="chapters"></param>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="description"></param>
        /// <param name="articleImageUrl"></param>
        /// <param name="language"></param>
        /// <param name="displayMode"></param>
        /// <param name="genre"></param>
        /// <param name="fiction"></param>
        /// <param name="contentType"></param>
        /// <param name="originalFileType"></param>
        /// <param name="targetAudience"></param>
        /// <param name="matureContent"></param>
        /// <param name="origin"></param>
        /// <param name="publicationDate"></param>
        /// <param name="isbn"></param>
        /// <param name="ean"></param>
        /// <param name="legalTerms"></param>
        /// <param name="contentGuidelinesTerms"></param>
        /// <param name="lastUpdatedFromProjectUnix"></param>
        /// <param name="publishingProjectId"></param>
        /// <param name="publishingState">
        /// Default Value: published
        /// </param>
        /// <param name="publisherProfileId"></param>
        /// <param name="qualityScore"></param>
        /// <param name="publisher"></param>
        /// <param name="copyright"></param>
        /// <param name="subtitle"></param>
        /// <param name="distributionTerritories"></param>
        /// <param name="edition"></param>
        /// <param name="contributors"></param>
        /// <param name="payoutType"></param>
        /// <param name="listPrice"></param>
        /// <param name="currency"></param>
        /// <param name="originalAudioProjectExportId"></param>
        /// <param name="originalAudioDocumentId"></param>
        /// <param name="seriesId"></param>
        /// <param name="volume"></param>
        /// <param name="publishedAtUnix"></param>
        /// <param name="readSlug"></param>
        /// <param name="previewAudioObject"></param>
        /// <param name="sampleConfig"></param>
        /// <param name="review"></param>
        /// <param name="voiceId"></param>
        /// <param name="canUseAssistant">
        /// Default Value: true
        /// </param>
        public DirectPublishingReadResponseModel(
            string readId,
            int createdAtUnix,
            int updatedAtUnix,
            int wordCount,
            int charCount,
            global::System.Collections.Generic.IList<global::G.ReadMetadataChapterDBModel> chapters,
            string? title,
            string? author,
            string? description,
            string? articleImageUrl,
            string? language,
            global::G.DirectPublishingReadResponseModelDisplayMode2? displayMode,
            global::System.Collections.Generic.IList<global::G.DirectPublishingReadResponseModelGenreVariant1Item>? genre,
            string? fiction,
            string? contentType,
            string? originalFileType,
            global::G.DirectPublishingReadResponseModelTargetAudience2? targetAudience,
            bool? matureContent,
            string? origin,
            string? publicationDate,
            string? isbn,
            string? ean,
            global::G.ReadLegalTerms? legalTerms,
            global::G.ReadLegalTerms? contentGuidelinesTerms,
            int? lastUpdatedFromProjectUnix,
            string? publishingProjectId,
            string? publishingState,
            string? publisherProfileId,
            int? qualityScore,
            string? publisher,
            string? copyright,
            string? subtitle,
            global::System.Collections.Generic.IList<string>? distributionTerritories,
            string? edition,
            global::System.Collections.Generic.IList<global::G.Contributor>? contributors,
            global::G.DirectPublishingReadResponseModelPayoutType2? payoutType,
            double? listPrice,
            string? currency,
            string? originalAudioProjectExportId,
            string? originalAudioDocumentId,
            string? seriesId,
            int? volume,
            int? publishedAtUnix,
            string? readSlug,
            global::G.PreviewAudioDBModel? previewAudioObject,
            global::G.SampleConfigDBModel? sampleConfig,
            global::G.ReviewResponseModel? review,
            string? voiceId,
            bool? canUseAssistant)
        {
            this.ReadId = readId ?? throw new global::System.ArgumentNullException(nameof(readId));
            this.CreatedAtUnix = createdAtUnix;
            this.UpdatedAtUnix = updatedAtUnix;
            this.WordCount = wordCount;
            this.CharCount = charCount;
            this.Chapters = chapters ?? throw new global::System.ArgumentNullException(nameof(chapters));
            this.Title = title;
            this.Author = author;
            this.Description = description;
            this.ArticleImageUrl = articleImageUrl;
            this.Language = language;
            this.DisplayMode = displayMode;
            this.Genre = genre;
            this.Fiction = fiction;
            this.ContentType = contentType;
            this.OriginalFileType = originalFileType;
            this.TargetAudience = targetAudience;
            this.MatureContent = matureContent;
            this.Origin = origin;
            this.PublicationDate = publicationDate;
            this.Isbn = isbn;
            this.Ean = ean;
            this.LegalTerms = legalTerms;
            this.ContentGuidelinesTerms = contentGuidelinesTerms;
            this.LastUpdatedFromProjectUnix = lastUpdatedFromProjectUnix;
            this.PublishingProjectId = publishingProjectId;
            this.PublishingState = publishingState;
            this.PublisherProfileId = publisherProfileId;
            this.QualityScore = qualityScore;
            this.Publisher = publisher;
            this.Copyright = copyright;
            this.Subtitle = subtitle;
            this.DistributionTerritories = distributionTerritories;
            this.Edition = edition;
            this.Contributors = contributors;
            this.PayoutType = payoutType;
            this.ListPrice = listPrice;
            this.Currency = currency;
            this.OriginalAudioProjectExportId = originalAudioProjectExportId;
            this.OriginalAudioDocumentId = originalAudioDocumentId;
            this.SeriesId = seriesId;
            this.Volume = volume;
            this.PublishedAtUnix = publishedAtUnix;
            this.ReadSlug = readSlug;
            this.PreviewAudioObject = previewAudioObject;
            this.SampleConfig = sampleConfig;
            this.Review = review;
            this.VoiceId = voiceId;
            this.CanUseAssistant = canUseAssistant;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectPublishingReadResponseModel" /> class.
        /// </summary>
        public DirectPublishingReadResponseModel()
        {
        }
    }
}