//HintName: G.Models.VoiceSharingResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"category":"professional","cloned_by_count":50,"date_unix":1714204800,"description":"A female voice with a soft and friendly tone.","disable_at_unix":1714204800,"enabled_in_library":true,"featured":true,"financial_rewards_enabled":true,"free_users_allowed":true,"history_item_sample_id":"DCwhRBWXzGAHq8TQ4Fs18","labels":{"accent":"American","gender":"female"},"liked_by_count":100,"live_moderation_enabled":true,"moderation_check":{"captcha_checks":[0.95,0.98],"captcha_ids":["captcha1","captcha2"],"date_checked_unix":1714204800,"description_check":true,"description_value":"A female voice with a soft and friendly tone.","name_check":true,"name_value":"Rachel","sample_checks":[0.95,0.98],"sample_ids":["sample1","sample2"]},"name":"Rachel","notice_period":30,"original_voice_id":"DCwhRBWXzGAHq8TQ4Fs18","public_owner_id":"DCwhRBWXzGAHq8TQ4Fs18","rate":0.05,"reader_app_enabled":true,"reader_restricted_on":[{"resource_id":"FCwhRBWXzGAHq8TQ4Fs18","resource_type":"read"}],"review_status":"allowed","status":"enabled","voice_mixing_allowed":false,"whitelisted_emails":["example@example.com"]}
    /// </summary>
    public sealed partial class VoiceSharingResponseModel
    {
        /// <summary>
        /// The status of the voice sharing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VoiceSharingResponseModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VoiceSharingResponseModelStatus Status { get; set; }

        /// <summary>
        /// The sample ID of the history item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history_item_sample_id")]
        public string? HistoryItemSampleId { get; set; }

        /// <summary>
        /// The date of the voice sharing in Unix time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DateUnix { get; set; }

        /// <summary>
        /// A list of whitelisted emails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whitelisted_emails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> WhitelistedEmails { get; set; }

        /// <summary>
        /// The ID of the public owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicOwnerId { get; set; }

        /// <summary>
        /// The ID of the original voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalVoiceId { get; set; }

        /// <summary>
        /// Whether financial rewards are enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("financial_rewards_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FinancialRewardsEnabled { get; set; }

        /// <summary>
        /// Whether free users are allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("free_users_allowed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FreeUsersAllowed { get; set; }

        /// <summary>
        /// Whether live moderation is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("live_moderation_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool LiveModerationEnabled { get; set; }

        /// <summary>
        /// The rate of the voice sharing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        public double? Rate { get; set; }

        /// <summary>
        /// The rate of the voice sharing in USD per 1000 credits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fiat_rate")]
        public double? FiatRate { get; set; }

        /// <summary>
        /// The notice period of the voice sharing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notice_period")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NoticePeriod { get; set; }

        /// <summary>
        /// The date of the voice sharing in Unix time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_at_unix")]
        public int? DisableAtUnix { get; set; }

        /// <summary>
        /// Whether voice mixing is allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_mixing_allowed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool VoiceMixingAllowed { get; set; }

        /// <summary>
        /// Whether the voice is featured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featured")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Featured { get; set; }

        /// <summary>
        /// The category of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VoiceSharingResponseModelCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VoiceSharingResponseModelCategory Category { get; set; }

        /// <summary>
        /// Whether the reader app is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reader_app_enabled")]
        public bool? ReaderAppEnabled { get; set; }

        /// <summary>
        /// The image URL of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// The ban reason of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ban_reason")]
        public string? BanReason { get; set; }

        /// <summary>
        /// The number of likes on the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("liked_by_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LikedByCount { get; set; }

        /// <summary>
        /// The number of clones on the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloned_by_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ClonedByCount { get; set; }

        /// <summary>
        /// The name of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The description of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The labels of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The review status of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VoiceSharingResponseModelReviewStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VoiceSharingResponseModelReviewStatus ReviewStatus { get; set; }

        /// <summary>
        /// The review message of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_message")]
        public string? ReviewMessage { get; set; }

        /// <summary>
        /// Whether the voice is enabled in the library.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_in_library")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnabledInLibrary { get; set; }

        /// <summary>
        /// The Instagram username of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instagram_username")]
        public string? InstagramUsername { get; set; }

        /// <summary>
        /// The Twitter/X username of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twitter_username")]
        public string? TwitterUsername { get; set; }

        /// <summary>
        /// The YouTube username of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("youtube_username")]
        public string? YoutubeUsername { get; set; }

        /// <summary>
        /// The TikTok username of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tiktok_username")]
        public string? TiktokUsername { get; set; }

        /// <summary>
        /// The moderation check of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation_check")]
        public global::G.VoiceSharingModerationCheckResponseModel? ModerationCheck { get; set; }

        /// <summary>
        /// The reader restricted on of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reader_restricted_on")]
        public global::System.Collections.Generic.IList<global::G.ReaderResourceResponseModel>? ReaderRestrictedOn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSharingResponseModel" /> class.
        /// </summary>
        /// <param name="status">
        /// The status of the voice sharing.
        /// </param>
        /// <param name="historyItemSampleId">
        /// The sample ID of the history item.
        /// </param>
        /// <param name="dateUnix">
        /// The date of the voice sharing in Unix time.
        /// </param>
        /// <param name="whitelistedEmails">
        /// A list of whitelisted emails.
        /// </param>
        /// <param name="publicOwnerId">
        /// The ID of the public owner.
        /// </param>
        /// <param name="originalVoiceId">
        /// The ID of the original voice.
        /// </param>
        /// <param name="financialRewardsEnabled">
        /// Whether financial rewards are enabled.
        /// </param>
        /// <param name="freeUsersAllowed">
        /// Whether free users are allowed.
        /// </param>
        /// <param name="liveModerationEnabled">
        /// Whether live moderation is enabled.
        /// </param>
        /// <param name="rate">
        /// The rate of the voice sharing.
        /// </param>
        /// <param name="fiatRate">
        /// The rate of the voice sharing in USD per 1000 credits.
        /// </param>
        /// <param name="noticePeriod">
        /// The notice period of the voice sharing.
        /// </param>
        /// <param name="disableAtUnix">
        /// The date of the voice sharing in Unix time.
        /// </param>
        /// <param name="voiceMixingAllowed">
        /// Whether voice mixing is allowed.
        /// </param>
        /// <param name="featured">
        /// Whether the voice is featured.
        /// </param>
        /// <param name="category">
        /// The category of the voice.
        /// </param>
        /// <param name="readerAppEnabled">
        /// Whether the reader app is enabled.
        /// </param>
        /// <param name="imageUrl">
        /// The image URL of the voice.
        /// </param>
        /// <param name="banReason">
        /// The ban reason of the voice.
        /// </param>
        /// <param name="likedByCount">
        /// The number of likes on the voice.
        /// </param>
        /// <param name="clonedByCount">
        /// The number of clones on the voice.
        /// </param>
        /// <param name="name">
        /// The name of the voice.
        /// </param>
        /// <param name="description">
        /// The description of the voice.
        /// </param>
        /// <param name="labels">
        /// The labels of the voice.
        /// </param>
        /// <param name="reviewStatus">
        /// The review status of the voice.
        /// </param>
        /// <param name="reviewMessage">
        /// The review message of the voice.
        /// </param>
        /// <param name="enabledInLibrary">
        /// Whether the voice is enabled in the library.
        /// </param>
        /// <param name="instagramUsername">
        /// The Instagram username of the voice.
        /// </param>
        /// <param name="twitterUsername">
        /// The Twitter/X username of the voice.
        /// </param>
        /// <param name="youtubeUsername">
        /// The YouTube username of the voice.
        /// </param>
        /// <param name="tiktokUsername">
        /// The TikTok username of the voice.
        /// </param>
        /// <param name="moderationCheck">
        /// The moderation check of the voice.
        /// </param>
        /// <param name="readerRestrictedOn">
        /// The reader restricted on of the voice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceSharingResponseModel(
            global::G.VoiceSharingResponseModelStatus status,
            int dateUnix,
            global::System.Collections.Generic.IList<string> whitelistedEmails,
            string publicOwnerId,
            string originalVoiceId,
            bool financialRewardsEnabled,
            bool freeUsersAllowed,
            bool liveModerationEnabled,
            int noticePeriod,
            bool voiceMixingAllowed,
            bool featured,
            global::G.VoiceSharingResponseModelCategory category,
            int likedByCount,
            int clonedByCount,
            string name,
            global::System.Collections.Generic.Dictionary<string, string> labels,
            global::G.VoiceSharingResponseModelReviewStatus reviewStatus,
            bool enabledInLibrary,
            string? historyItemSampleId,
            double? rate,
            double? fiatRate,
            int? disableAtUnix,
            bool? readerAppEnabled,
            string? imageUrl,
            string? banReason,
            string? description,
            string? reviewMessage,
            string? instagramUsername,
            string? twitterUsername,
            string? youtubeUsername,
            string? tiktokUsername,
            global::G.VoiceSharingModerationCheckResponseModel? moderationCheck,
            global::System.Collections.Generic.IList<global::G.ReaderResourceResponseModel>? readerRestrictedOn)
        {
            this.Status = status;
            this.DateUnix = dateUnix;
            this.WhitelistedEmails = whitelistedEmails ?? throw new global::System.ArgumentNullException(nameof(whitelistedEmails));
            this.PublicOwnerId = publicOwnerId ?? throw new global::System.ArgumentNullException(nameof(publicOwnerId));
            this.OriginalVoiceId = originalVoiceId ?? throw new global::System.ArgumentNullException(nameof(originalVoiceId));
            this.FinancialRewardsEnabled = financialRewardsEnabled;
            this.FreeUsersAllowed = freeUsersAllowed;
            this.LiveModerationEnabled = liveModerationEnabled;
            this.NoticePeriod = noticePeriod;
            this.VoiceMixingAllowed = voiceMixingAllowed;
            this.Featured = featured;
            this.Category = category;
            this.LikedByCount = likedByCount;
            this.ClonedByCount = clonedByCount;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.ReviewStatus = reviewStatus;
            this.EnabledInLibrary = enabledInLibrary;
            this.HistoryItemSampleId = historyItemSampleId;
            this.Rate = rate;
            this.FiatRate = fiatRate;
            this.DisableAtUnix = disableAtUnix;
            this.ReaderAppEnabled = readerAppEnabled;
            this.ImageUrl = imageUrl;
            this.BanReason = banReason;
            this.Description = description;
            this.ReviewMessage = reviewMessage;
            this.InstagramUsername = instagramUsername;
            this.TwitterUsername = twitterUsername;
            this.YoutubeUsername = youtubeUsername;
            this.TiktokUsername = tiktokUsername;
            this.ModerationCheck = moderationCheck;
            this.ReaderRestrictedOn = readerRestrictedOn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSharingResponseModel" /> class.
        /// </summary>
        public VoiceSharingResponseModel()
        {
        }
    }
}