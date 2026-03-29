//HintName: G.Models.DubbedAssetComplete.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Dubbed asset complete - full data.
    /// </summary>
    public sealed partial class DubbedAssetComplete
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Title of the video (used on the video's share page).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Description of the video (used on the video's share page).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DubbingOutputLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DubbingOutputLanguage Language { get; set; }

        /// <summary>
        /// The status of the dubbed video.<br/>
        /// Default Value: complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DubbedAssetCompleteStatusJsonConverter))]
        public global::G.DubbedAssetCompleteStatus? Status { get; set; }

        /// <summary>
        /// UNIX timestamp representing the time video was created.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// UNIX timestamp representing the time video was last updated.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUpdatedAt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? LastUpdatedAt { get; set; }

        /// <summary>
        /// Describes the visibility settings of the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DubbedAssetCompleteVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DubbedAssetCompleteVisibility Visibility { get; set; }

        /// <summary>
        /// A time-limited URL which may be used to download the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Download { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DubbedAssetThumbnail Thumbnail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("captions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DubbedAssetCaptions Captions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbedAssetComplete" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title">
        /// Title of the video (used on the video's share page).
        /// </param>
        /// <param name="description">
        /// Description of the video (used on the video's share page).
        /// </param>
        /// <param name="language"></param>
        /// <param name="visibility">
        /// Describes the visibility settings of the video.
        /// </param>
        /// <param name="download">
        /// A time-limited URL which may be used to download the video.
        /// </param>
        /// <param name="thumbnail"></param>
        /// <param name="captions"></param>
        /// <param name="status">
        /// The status of the dubbed video.<br/>
        /// Default Value: complete
        /// </param>
        /// <param name="createdAt">
        /// UNIX timestamp representing the time video was created.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="lastUpdatedAt">
        /// UNIX timestamp representing the time video was last updated.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbedAssetComplete(
            global::System.Guid id,
            string title,
            string description,
            global::G.DubbingOutputLanguage language,
            global::G.DubbedAssetCompleteVisibility visibility,
            string download,
            global::G.DubbedAssetThumbnail thumbnail,
            global::G.DubbedAssetCaptions captions,
            global::G.DubbedAssetCompleteStatus? status,
            global::System.DateTimeOffset? createdAt,
            global::System.DateTimeOffset? lastUpdatedAt)
        {
            this.Id = id;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Language = language;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.Visibility = visibility;
            this.Download = download ?? throw new global::System.ArgumentNullException(nameof(download));
            this.Thumbnail = thumbnail ?? throw new global::System.ArgumentNullException(nameof(thumbnail));
            this.Captions = captions ?? throw new global::System.ArgumentNullException(nameof(captions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbedAssetComplete" /> class.
        /// </summary>
        public DubbedAssetComplete()
        {
        }
    }
}