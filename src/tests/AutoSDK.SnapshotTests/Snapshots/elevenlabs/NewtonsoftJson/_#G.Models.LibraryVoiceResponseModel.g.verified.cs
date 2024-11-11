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
        [global::Newtonsoft.Json.JsonProperty("public_owner_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PublicOwnerId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("date_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int DateUnix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accent", Required = global::Newtonsoft.Json.Required.Always)]
        public string Accent { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gender", Required = global::Newtonsoft.Json.Required.Always)]
        public string Gender { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("age", Required = global::Newtonsoft.Json.Required.Always)]
        public string Age { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("descriptive", Required = global::Newtonsoft.Json.Required.Always)]
        public string Descriptive { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_case", Required = global::Newtonsoft.Json.Required.Always)]
        public string UseCase { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("category", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LibraryVoiceResponseModelCategory Category { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PreviewUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_character_count_1y", Required = global::Newtonsoft.Json.Required.Always)]
        public int UsageCharacterCount1y { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_character_count_7d", Required = global::Newtonsoft.Json.Required.Always)]
        public int UsageCharacterCount7d { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("play_api_usage_character_count_1y", Required = global::Newtonsoft.Json.Required.Always)]
        public int PlayApiUsageCharacterCount1y { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cloned_by_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ClonedByCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rate", Required = global::Newtonsoft.Json.Required.Always)]
        public double Rate { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("featured", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Featured { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("notice_period")]
        public int? NoticePeriod { get; set; }

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.LibraryVoiceResponseModel? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.LibraryVoiceResponseModel>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.LibraryVoiceResponseModel?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.LibraryVoiceResponseModel?>(serializer.Deserialize<global::G.LibraryVoiceResponseModel>(jsonReader));
        }

    }
}