//HintName: G.Models.PickExpressiveVideoExpressivePublicAllowedAttributes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickExpressiveVideoExpressivePublicAllowedAttributes
    {
        /// <summary>
        /// The id of the expressive video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The id of the owner of the expressive video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnerId { get; set; } = default!;

        /// <summary>
        /// The name of the video<br/>
        /// Example: my_expressive_video
        /// </summary>
        /// <example>my_expressive_video</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The thumbnail url of the video<br/>
        /// Example: https://example.com/thumbnail.png
        /// </summary>
        /// <example>https://example.com/thumbnail.png</example>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PickExpressiveVideoExpressivePublicAllowedAttributesStatusJsonConverter))]
        public global::G.PickExpressiveVideoExpressivePublicAllowedAttributesStatus Status { get; set; } = default!;

        /// <summary>
        /// The date the video was created<br/>
        /// Example: 2021-01-01T00:00:00.000Z
        /// </summary>
        /// <example>2021-01-01T00:00:00.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// The id of the avatar of the video<br/>
        /// Example: public_dan@abcefg
        /// </summary>
        /// <example>public_dan@abcefg</example>
        [global::Newtonsoft.Json.JsonProperty("avatar_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AvatarId { get; set; } = default!;

        /// <summary>
        /// The chosen sentiment id of the video<br/>
        /// Example: snt_IIjpTS
        /// </summary>
        /// <example>snt_IIjpTS</example>
        [global::Newtonsoft.Json.JsonProperty("sentiment_id")]
        public string? SentimentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_data")]
        public string? UserData { get; set; }

        /// <summary>
        /// The result url of the video. Cannot be provided together with config.result_format.<br/>
        /// Example: https://example.com/result.mp4
        /// </summary>
        /// <example>https://example.com/result.mp4</example>
        [global::Newtonsoft.Json.JsonProperty("result_url")]
        public string? ResultUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// The id of the user who created the expressive video<br/>
        /// Example: user_id
        /// </summary>
        /// <example>user_id</example>
        [global::Newtonsoft.Json.JsonProperty("created_by", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedBy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.PickExpressiveVideoExpressivePublicAllowedAttributesError? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subtitles_url")]
        public string? SubtitlesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickExpressiveVideoExpressivePublicAllowedAttributes" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the expressive video
        /// </param>
        /// <param name="ownerId">
        /// The id of the owner of the expressive video
        /// </param>
        /// <param name="status"></param>
        /// <param name="createdAt">
        /// The date the video was created<br/>
        /// Example: 2021-01-01T00:00:00.000Z
        /// </param>
        /// <param name="avatarId">
        /// The id of the avatar of the video<br/>
        /// Example: public_dan@abcefg
        /// </param>
        /// <param name="createdBy">
        /// The id of the user who created the expressive video<br/>
        /// Example: user_id
        /// </param>
        /// <param name="name">
        /// The name of the video<br/>
        /// Example: my_expressive_video
        /// </param>
        /// <param name="thumbnailUrl">
        /// The thumbnail url of the video<br/>
        /// Example: https://example.com/thumbnail.png
        /// </param>
        /// <param name="sentimentId">
        /// The chosen sentiment id of the video<br/>
        /// Example: snt_IIjpTS
        /// </param>
        /// <param name="userData"></param>
        /// <param name="resultUrl">
        /// The result url of the video. Cannot be provided together with config.result_format.<br/>
        /// Example: https://example.com/result.mp4
        /// </param>
        /// <param name="webhook"></param>
        /// <param name="completedAt"></param>
        /// <param name="error"></param>
        /// <param name="subtitlesUrl"></param>
        /// <param name="duration"></param>
        public PickExpressiveVideoExpressivePublicAllowedAttributes(
            string id,
            string ownerId,
            global::G.PickExpressiveVideoExpressivePublicAllowedAttributesStatus status,
            string createdAt,
            string avatarId,
            string createdBy,
            string? name,
            string? thumbnailUrl,
            string? sentimentId,
            string? userData,
            string? resultUrl,
            string? webhook,
            string? completedAt,
            global::G.PickExpressiveVideoExpressivePublicAllowedAttributesError? error,
            string? subtitlesUrl,
            double? duration)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.Name = name;
            this.ThumbnailUrl = thumbnailUrl;
            this.Status = status;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.AvatarId = avatarId ?? throw new global::System.ArgumentNullException(nameof(avatarId));
            this.SentimentId = sentimentId;
            this.UserData = userData;
            this.ResultUrl = resultUrl;
            this.Webhook = webhook;
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.CompletedAt = completedAt;
            this.Error = error;
            this.SubtitlesUrl = subtitlesUrl;
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickExpressiveVideoExpressivePublicAllowedAttributes" /> class.
        /// </summary>
        public PickExpressiveVideoExpressivePublicAllowedAttributes()
        {
        }
    }
}