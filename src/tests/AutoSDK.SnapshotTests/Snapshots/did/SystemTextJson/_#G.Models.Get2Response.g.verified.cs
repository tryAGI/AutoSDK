//HintName: G.Models.Get2Response.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class Get2Response
    {
        /// <summary>
        /// The id of the expressive video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The id of the owner of the expressive video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// The name of the video<br/>
        /// Example: my_expressive_video
        /// </summary>
        /// <example>my_expressive_video</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The thumbnail url of the video<br/>
        /// Example: https://example.com/thumbnail.png
        /// </summary>
        /// <example>https://example.com/thumbnail.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Get2ResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Get2ResponseStatus Status { get; set; }

        /// <summary>
        /// The date the video was created<br/>
        /// Example: 2021-01-01T00:00:00.000Z
        /// </summary>
        /// <example>2021-01-01T00:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The id of the avatar of the video<br/>
        /// Example: public_dan@abcefg
        /// </summary>
        /// <example>public_dan@abcefg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AvatarId { get; set; }

        /// <summary>
        /// The chosen sentiment id of the video<br/>
        /// Example: snt_IIjpTS
        /// </summary>
        /// <example>snt_IIjpTS</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment_id")]
        public string? SentimentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_data")]
        public string? UserData { get; set; }

        /// <summary>
        /// The result url of the video. Cannot be provided together with config.result_format.<br/>
        /// Example: https://example.com/result.mp4
        /// </summary>
        /// <example>https://example.com/result.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_url")]
        public string? ResultUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// The id of the user who created the expressive video<br/>
        /// Example: user_id
        /// </summary>
        /// <example>user_id</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::G.Get2ResponseError? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitles_url")]
        public string? SubtitlesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Get2Response" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Get2Response(
            string id,
            string ownerId,
            global::G.Get2ResponseStatus status,
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
            global::G.Get2ResponseError? error,
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
        /// Initializes a new instance of the <see cref="Get2Response" /> class.
        /// </summary>
        public Get2Response()
        {
        }
    }
}