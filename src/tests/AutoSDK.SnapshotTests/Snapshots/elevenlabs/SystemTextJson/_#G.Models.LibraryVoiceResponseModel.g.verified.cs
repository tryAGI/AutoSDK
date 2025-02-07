//HintName: G.Models.LibraryVoiceResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LibraryVoiceResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicOwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DateUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Accent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Descriptive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_case")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UseCase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LibraryVoiceResponseModelCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LibraryVoiceResponseModelCategory Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviewUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_character_count_1y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UsageCharacterCount1y { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_character_count_7d")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UsageCharacterCount7d { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("play_api_usage_character_count_1y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PlayApiUsageCharacterCount1y { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloned_by_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ClonedByCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("free_users_allowed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FreeUsersAllowed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("live_moderation_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool LiveModerationEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featured")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Featured { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notice_period")]
        public int? NoticePeriod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instagram_username")]
        public string? InstagramUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twitter_username")]
        public string? TwitterUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("youtube_username")]
        public string? YoutubeUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tiktok_username")]
        public string? TiktokUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryVoiceResponseModel" /> class.
        /// </summary>
        /// <param name="publicOwnerId"></param>
        /// <param name="voiceId"></param>
        /// <param name="dateUnix"></param>
        /// <param name="name"></param>
        /// <param name="accent"></param>
        /// <param name="gender"></param>
        /// <param name="age"></param>
        /// <param name="descriptive"></param>
        /// <param name="useCase"></param>
        /// <param name="category"></param>
        /// <param name="language"></param>
        /// <param name="description"></param>
        /// <param name="previewUrl"></param>
        /// <param name="usageCharacterCount1y"></param>
        /// <param name="usageCharacterCount7d"></param>
        /// <param name="playApiUsageCharacterCount1y"></param>
        /// <param name="clonedByCount"></param>
        /// <param name="rate"></param>
        /// <param name="freeUsersAllowed"></param>
        /// <param name="liveModerationEnabled"></param>
        /// <param name="featured"></param>
        /// <param name="noticePeriod"></param>
        /// <param name="instagramUsername"></param>
        /// <param name="twitterUsername"></param>
        /// <param name="youtubeUsername"></param>
        /// <param name="tiktokUsername"></param>
        /// <param name="imageUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LibraryVoiceResponseModel(
            string publicOwnerId,
            string voiceId,
            int dateUnix,
            string name,
            string accent,
            string gender,
            string age,
            string descriptive,
            string useCase,
            global::G.LibraryVoiceResponseModelCategory category,
            string language,
            string description,
            string previewUrl,
            int usageCharacterCount1y,
            int usageCharacterCount7d,
            int playApiUsageCharacterCount1y,
            int clonedByCount,
            double rate,
            bool freeUsersAllowed,
            bool liveModerationEnabled,
            bool featured,
            int? noticePeriod,
            string? instagramUsername,
            string? twitterUsername,
            string? youtubeUsername,
            string? tiktokUsername,
            string? imageUrl)
        {
            this.PublicOwnerId = publicOwnerId ?? throw new global::System.ArgumentNullException(nameof(publicOwnerId));
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.DateUnix = dateUnix;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Accent = accent ?? throw new global::System.ArgumentNullException(nameof(accent));
            this.Gender = gender ?? throw new global::System.ArgumentNullException(nameof(gender));
            this.Age = age ?? throw new global::System.ArgumentNullException(nameof(age));
            this.Descriptive = descriptive ?? throw new global::System.ArgumentNullException(nameof(descriptive));
            this.UseCase = useCase ?? throw new global::System.ArgumentNullException(nameof(useCase));
            this.Category = category;
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.PreviewUrl = previewUrl ?? throw new global::System.ArgumentNullException(nameof(previewUrl));
            this.UsageCharacterCount1y = usageCharacterCount1y;
            this.UsageCharacterCount7d = usageCharacterCount7d;
            this.PlayApiUsageCharacterCount1y = playApiUsageCharacterCount1y;
            this.ClonedByCount = clonedByCount;
            this.Rate = rate;
            this.FreeUsersAllowed = freeUsersAllowed;
            this.LiveModerationEnabled = liveModerationEnabled;
            this.Featured = featured;
            this.NoticePeriod = noticePeriod;
            this.InstagramUsername = instagramUsername;
            this.TwitterUsername = twitterUsername;
            this.YoutubeUsername = youtubeUsername;
            this.TiktokUsername = tiktokUsername;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryVoiceResponseModel" /> class.
        /// </summary>
        public LibraryVoiceResponseModel()
        {
        }
    }
}