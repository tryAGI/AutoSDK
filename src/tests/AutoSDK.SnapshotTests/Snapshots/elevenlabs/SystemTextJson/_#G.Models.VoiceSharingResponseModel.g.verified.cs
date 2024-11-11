//HintName: G.Models.VoiceSharingResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceSharingResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VoiceSharingResponseModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VoiceSharingResponseModelStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history_item_sample_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HistoryItemSampleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DateUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whitelisted_emails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> WhitelistedEmails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicOwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalVoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("financial_rewards_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FinancialRewardsEnabled { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notice_period")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NoticePeriod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DisableAtUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_mixing_allowed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool VoiceMixingAllowed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featured")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Featured { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VoiceSharingResponseModelCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VoiceSharingResponseModelCategory Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reader_app_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ReaderAppEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ban_reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BanReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("liked_by_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LikedByCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloned_by_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ClonedByCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VoiceSharingResponseModelReviewStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VoiceSharingResponseModelReviewStatus ReviewStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReviewMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_in_library")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnabledInLibrary { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSharingResponseModel" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="historyItemSampleId"></param>
        /// <param name="dateUnix"></param>
        /// <param name="whitelistedEmails"></param>
        /// <param name="publicOwnerId"></param>
        /// <param name="originalVoiceId"></param>
        /// <param name="financialRewardsEnabled"></param>
        /// <param name="freeUsersAllowed"></param>
        /// <param name="liveModerationEnabled"></param>
        /// <param name="rate"></param>
        /// <param name="noticePeriod"></param>
        /// <param name="disableAtUnix"></param>
        /// <param name="voiceMixingAllowed"></param>
        /// <param name="featured"></param>
        /// <param name="category"></param>
        /// <param name="readerAppEnabled"></param>
        /// <param name="imageUrl"></param>
        /// <param name="banReason"></param>
        /// <param name="likedByCount"></param>
        /// <param name="clonedByCount"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="labels"></param>
        /// <param name="reviewStatus"></param>
        /// <param name="reviewMessage"></param>
        /// <param name="enabledInLibrary"></param>
        /// <param name="instagramUsername"></param>
        /// <param name="twitterUsername"></param>
        /// <param name="youtubeUsername"></param>
        /// <param name="tiktokUsername"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public VoiceSharingResponseModel(
            global::G.VoiceSharingResponseModelStatus status,
            string historyItemSampleId,
            int dateUnix,
            global::System.Collections.Generic.IList<string> whitelistedEmails,
            string publicOwnerId,
            string originalVoiceId,
            bool financialRewardsEnabled,
            bool freeUsersAllowed,
            bool liveModerationEnabled,
            double rate,
            int noticePeriod,
            int disableAtUnix,
            bool voiceMixingAllowed,
            bool featured,
            global::G.VoiceSharingResponseModelCategory category,
            bool readerAppEnabled,
            string imageUrl,
            string banReason,
            int likedByCount,
            int clonedByCount,
            string name,
            string description,
            global::System.Collections.Generic.Dictionary<string, string> labels,
            global::G.VoiceSharingResponseModelReviewStatus reviewStatus,
            string reviewMessage,
            bool enabledInLibrary,
            string? instagramUsername,
            string? twitterUsername,
            string? youtubeUsername,
            string? tiktokUsername)
        {
            this.Status = status;
            this.HistoryItemSampleId = historyItemSampleId ?? throw new global::System.ArgumentNullException(nameof(historyItemSampleId));
            this.DateUnix = dateUnix;
            this.WhitelistedEmails = whitelistedEmails ?? throw new global::System.ArgumentNullException(nameof(whitelistedEmails));
            this.PublicOwnerId = publicOwnerId ?? throw new global::System.ArgumentNullException(nameof(publicOwnerId));
            this.OriginalVoiceId = originalVoiceId ?? throw new global::System.ArgumentNullException(nameof(originalVoiceId));
            this.FinancialRewardsEnabled = financialRewardsEnabled;
            this.FreeUsersAllowed = freeUsersAllowed;
            this.LiveModerationEnabled = liveModerationEnabled;
            this.Rate = rate;
            this.NoticePeriod = noticePeriod;
            this.DisableAtUnix = disableAtUnix;
            this.VoiceMixingAllowed = voiceMixingAllowed;
            this.Featured = featured;
            this.Category = category;
            this.ReaderAppEnabled = readerAppEnabled;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.BanReason = banReason ?? throw new global::System.ArgumentNullException(nameof(banReason));
            this.LikedByCount = likedByCount;
            this.ClonedByCount = clonedByCount;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.ReviewStatus = reviewStatus;
            this.ReviewMessage = reviewMessage ?? throw new global::System.ArgumentNullException(nameof(reviewMessage));
            this.EnabledInLibrary = enabledInLibrary;
            this.InstagramUsername = instagramUsername;
            this.TwitterUsername = twitterUsername;
            this.YoutubeUsername = youtubeUsername;
            this.TiktokUsername = tiktokUsername;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSharingResponseModel" /> class.
        /// </summary>
        public VoiceSharingResponseModel()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.VoiceSharingResponseModel? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.VoiceSharingResponseModel),
                jsonSerializerContext) as global::G.VoiceSharingResponseModel;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.VoiceSharingResponseModel? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.VoiceSharingResponseModel>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.VoiceSharingResponseModel?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.VoiceSharingResponseModel),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.VoiceSharingResponseModel;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.VoiceSharingResponseModel?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.VoiceSharingResponseModel?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}