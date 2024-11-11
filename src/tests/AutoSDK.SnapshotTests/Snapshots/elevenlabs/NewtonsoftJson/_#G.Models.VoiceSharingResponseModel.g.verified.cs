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
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VoiceSharingResponseModelStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("history_item_sample_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string HistoryItemSampleId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("date_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int DateUnix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("whitelisted_emails", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> WhitelistedEmails { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_owner_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PublicOwnerId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OriginalVoiceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("financial_rewards_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool FinancialRewardsEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("free_users_allowed", Required = global::Newtonsoft.Json.Required.Always)]
        public bool FreeUsersAllowed { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("live_moderation_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool LiveModerationEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rate", Required = global::Newtonsoft.Json.Required.Always)]
        public double Rate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("notice_period", Required = global::Newtonsoft.Json.Required.Always)]
        public int NoticePeriod { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disable_at_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int DisableAtUnix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_mixing_allowed", Required = global::Newtonsoft.Json.Required.Always)]
        public bool VoiceMixingAllowed { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("featured", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Featured { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("category", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VoiceSharingResponseModelCategory Category { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reader_app_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ReaderAppEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ImageUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ban_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public string BanReason { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("liked_by_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int LikedByCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cloned_by_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ClonedByCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Labels { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VoiceSharingResponseModelReviewStatus ReviewStatus { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_message", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReviewMessage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled_in_library", Required = global::Newtonsoft.Json.Required.Always)]
        public bool EnabledInLibrary { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instagram_username")]
        public string? InstagramUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("twitter_username")]
        public string? TwitterUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("youtube_username")]
        public string? YoutubeUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tiktok_username")]
        public string? TiktokUsername { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
    }
}