﻿//HintName: G.Models.LibraryVoiceResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LibraryVoiceResponseModel
    {
        /// <summary>
        /// The public owner id of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_owner_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PublicOwnerId { get; set; } = default!;

        /// <summary>
        /// The id of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// The date the voice was added to the library in Unix time.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("date_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int DateUnix { get; set; } = default!;

        /// <summary>
        /// The name of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The accent of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accent", Required = global::Newtonsoft.Json.Required.Always)]
        public string Accent { get; set; } = default!;

        /// <summary>
        /// The gender of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gender", Required = global::Newtonsoft.Json.Required.Always)]
        public string Gender { get; set; } = default!;

        /// <summary>
        /// The age of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("age", Required = global::Newtonsoft.Json.Required.Always)]
        public string Age { get; set; } = default!;

        /// <summary>
        /// The descriptive of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("descriptive", Required = global::Newtonsoft.Json.Required.Always)]
        public string Descriptive { get; set; } = default!;

        /// <summary>
        /// The use case of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_case", Required = global::Newtonsoft.Json.Required.Always)]
        public string UseCase { get; set; } = default!;

        /// <summary>
        /// The category of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("category", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LibraryVoiceResponseModelCategory Category { get; set; } = default!;

        /// <summary>
        /// The language of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The locale of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// The description of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The preview URL of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview_url")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// The usage character count of the voice in the last year.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_character_count_1y", Required = global::Newtonsoft.Json.Required.Always)]
        public int UsageCharacterCount1y { get; set; } = default!;

        /// <summary>
        /// The usage character count of the voice in the last 7 days.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_character_count_7d", Required = global::Newtonsoft.Json.Required.Always)]
        public int UsageCharacterCount7d { get; set; } = default!;

        /// <summary>
        /// The play API usage character count of the voice in the last year.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("play_api_usage_character_count_1y", Required = global::Newtonsoft.Json.Required.Always)]
        public int PlayApiUsageCharacterCount1y { get; set; } = default!;

        /// <summary>
        /// The number of times the voice has been cloned.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cloned_by_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ClonedByCount { get; set; } = default!;

        /// <summary>
        /// The rate multiplier of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rate")]
        public double? Rate { get; set; }

        /// <summary>
        /// The rate of the voice in USD per 1000 credits. null if default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fiat_rate")]
        public double? FiatRate { get; set; }

        /// <summary>
        /// Whether free users are allowed to use the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("free_users_allowed", Required = global::Newtonsoft.Json.Required.Always)]
        public bool FreeUsersAllowed { get; set; } = default!;

        /// <summary>
        /// Whether live moderation is enabled for the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("live_moderation_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool LiveModerationEnabled { get; set; } = default!;

        /// <summary>
        /// Whether the voice is featured.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("featured", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Featured { get; set; } = default!;

        /// <summary>
        /// The verified languages of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verified_languages")]
        public global::System.Collections.Generic.IList<global::G.VerifiedVoiceLanguageResponseModel>? VerifiedLanguages { get; set; }

        /// <summary>
        /// The notice period of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("notice_period")]
        public int? NoticePeriod { get; set; }

        /// <summary>
        /// The Instagram username of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instagram_username")]
        public string? InstagramUsername { get; set; }

        /// <summary>
        /// The Twitter username of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("twitter_username")]
        public string? TwitterUsername { get; set; }

        /// <summary>
        /// The YouTube username of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("youtube_username")]
        public string? YoutubeUsername { get; set; }

        /// <summary>
        /// The TikTok username of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tiktok_username")]
        public string? TiktokUsername { get; set; }

        /// <summary>
        /// The image URL of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Whether the voice was added by the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_added_by_user")]
        public bool? IsAddedByUser { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryVoiceResponseModel" /> class.
        /// </summary>
        /// <param name="publicOwnerId">
        /// The public owner id of the voice.
        /// </param>
        /// <param name="voiceId">
        /// The id of the voice.
        /// </param>
        /// <param name="dateUnix">
        /// The date the voice was added to the library in Unix time.
        /// </param>
        /// <param name="name">
        /// The name of the voice.
        /// </param>
        /// <param name="accent">
        /// The accent of the voice.
        /// </param>
        /// <param name="gender">
        /// The gender of the voice.
        /// </param>
        /// <param name="age">
        /// The age of the voice.
        /// </param>
        /// <param name="descriptive">
        /// The descriptive of the voice.
        /// </param>
        /// <param name="useCase">
        /// The use case of the voice.
        /// </param>
        /// <param name="category">
        /// The category of the voice.
        /// </param>
        /// <param name="language">
        /// The language of the voice.
        /// </param>
        /// <param name="locale">
        /// The locale of the voice.
        /// </param>
        /// <param name="description">
        /// The description of the voice.
        /// </param>
        /// <param name="previewUrl">
        /// The preview URL of the voice.
        /// </param>
        /// <param name="usageCharacterCount1y">
        /// The usage character count of the voice in the last year.
        /// </param>
        /// <param name="usageCharacterCount7d">
        /// The usage character count of the voice in the last 7 days.
        /// </param>
        /// <param name="playApiUsageCharacterCount1y">
        /// The play API usage character count of the voice in the last year.
        /// </param>
        /// <param name="clonedByCount">
        /// The number of times the voice has been cloned.
        /// </param>
        /// <param name="rate">
        /// The rate multiplier of the voice.
        /// </param>
        /// <param name="fiatRate">
        /// The rate of the voice in USD per 1000 credits. null if default
        /// </param>
        /// <param name="freeUsersAllowed">
        /// Whether free users are allowed to use the voice.
        /// </param>
        /// <param name="liveModerationEnabled">
        /// Whether live moderation is enabled for the voice.
        /// </param>
        /// <param name="featured">
        /// Whether the voice is featured.
        /// </param>
        /// <param name="verifiedLanguages">
        /// The verified languages of the voice.
        /// </param>
        /// <param name="noticePeriod">
        /// The notice period of the voice.
        /// </param>
        /// <param name="instagramUsername">
        /// The Instagram username of the voice.
        /// </param>
        /// <param name="twitterUsername">
        /// The Twitter username of the voice.
        /// </param>
        /// <param name="youtubeUsername">
        /// The YouTube username of the voice.
        /// </param>
        /// <param name="tiktokUsername">
        /// The TikTok username of the voice.
        /// </param>
        /// <param name="imageUrl">
        /// The image URL of the voice.
        /// </param>
        /// <param name="isAddedByUser">
        /// Whether the voice was added by the user.
        /// </param>
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
            int usageCharacterCount1y,
            int usageCharacterCount7d,
            int playApiUsageCharacterCount1y,
            int clonedByCount,
            bool freeUsersAllowed,
            bool liveModerationEnabled,
            bool featured,
            string? language,
            string? locale,
            string? description,
            string? previewUrl,
            double? rate,
            double? fiatRate,
            global::System.Collections.Generic.IList<global::G.VerifiedVoiceLanguageResponseModel>? verifiedLanguages,
            int? noticePeriod,
            string? instagramUsername,
            string? twitterUsername,
            string? youtubeUsername,
            string? tiktokUsername,
            string? imageUrl,
            bool? isAddedByUser)
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
            this.UsageCharacterCount1y = usageCharacterCount1y;
            this.UsageCharacterCount7d = usageCharacterCount7d;
            this.PlayApiUsageCharacterCount1y = playApiUsageCharacterCount1y;
            this.ClonedByCount = clonedByCount;
            this.FreeUsersAllowed = freeUsersAllowed;
            this.LiveModerationEnabled = liveModerationEnabled;
            this.Featured = featured;
            this.Language = language;
            this.Locale = locale;
            this.Description = description;
            this.PreviewUrl = previewUrl;
            this.Rate = rate;
            this.FiatRate = fiatRate;
            this.VerifiedLanguages = verifiedLanguages;
            this.NoticePeriod = noticePeriod;
            this.InstagramUsername = instagramUsername;
            this.TwitterUsername = twitterUsername;
            this.YoutubeUsername = youtubeUsername;
            this.TiktokUsername = tiktokUsername;
            this.ImageUrl = imageUrl;
            this.IsAddedByUser = isAddedByUser;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryVoiceResponseModel" /> class.
        /// </summary>
        public LibraryVoiceResponseModel()
        {
        }
    }
}