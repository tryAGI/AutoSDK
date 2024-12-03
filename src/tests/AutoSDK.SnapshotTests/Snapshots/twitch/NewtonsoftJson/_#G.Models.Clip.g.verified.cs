//HintName: G.Models.Clip.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Clip
    {
        /// <summary>
        /// An ID that uniquely identifies the clip.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// A URL to the clip.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// A URL that you can use in an iframe to embed the clip (see [Embedding Video and Clips](https://dev.twitch.tv/docs/embed/video-and-clips)).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embed_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string EmbedUrl { get; set; } = default!;

        /// <summary>
        /// An ID that identifies the broadcaster that the video was clipped from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterId { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterName { get; set; } = default!;

        /// <summary>
        /// An ID that identifies the user that created the clip.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatorId { get; set; } = default!;

        /// <summary>
        /// The user’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatorName { get; set; } = default!;

        /// <summary>
        /// An ID that identifies the video that the clip came from. This field contains an empty string if the video is not available.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VideoId { get; set; } = default!;

        /// <summary>
        /// The ID of the game that was being played when the clip was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("game_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string GameId { get; set; } = default!;

        /// <summary>
        /// The ISO 639-1 two-letter language code that the broadcaster broadcasts in. For example, _en_ for English. The value is _other_ if the broadcaster uses a language that Twitch doesn’t support.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// The title of the clip.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// The number of times the clip has been viewed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("view_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ViewCount { get; set; } = default!;

        /// <summary>
        /// The date and time of when the clip was created. The date and time is in RFC3339 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// A URL to a thumbnail image of the clip.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ThumbnailUrl { get; set; } = default!;

        /// <summary>
        /// The length of the clip, in seconds. Precision is 0.1.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration", Required = global::Newtonsoft.Json.Required.Always)]
        public float Duration { get; set; } = default!;

        /// <summary>
        /// The zero-based offset, in seconds, to where the clip starts in the video (VOD). Is **null** if the video is not available or hasn’t been created yet from the live stream (see `video_id`).  <br/>
        ///   <br/>
        /// Note that there’s a delay between when a clip is created during a broadcast and when the offset is set. During the delay period, `vod_offset` is **null**. The delay is indeterminant but is typically minutes long.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vod_offset", Required = global::Newtonsoft.Json.Required.Always)]
        public int? VodOffset { get; set; } = default!;

        /// <summary>
        /// A Boolean value that indicates if the clip is featured or not.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_featured", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsFeatured { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Clip" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID that uniquely identifies the clip.
        /// </param>
        /// <param name="url">
        /// A URL to the clip.
        /// </param>
        /// <param name="embedUrl">
        /// A URL that you can use in an iframe to embed the clip (see [Embedding Video and Clips](https://dev.twitch.tv/docs/embed/video-and-clips)).
        /// </param>
        /// <param name="broadcasterId">
        /// An ID that identifies the broadcaster that the video was clipped from.
        /// </param>
        /// <param name="broadcasterName">
        /// The broadcaster’s display name.
        /// </param>
        /// <param name="creatorId">
        /// An ID that identifies the user that created the clip.
        /// </param>
        /// <param name="creatorName">
        /// The user’s display name.
        /// </param>
        /// <param name="videoId">
        /// An ID that identifies the video that the clip came from. This field contains an empty string if the video is not available.
        /// </param>
        /// <param name="gameId">
        /// The ID of the game that was being played when the clip was created.
        /// </param>
        /// <param name="language">
        /// The ISO 639-1 two-letter language code that the broadcaster broadcasts in. For example, _en_ for English. The value is _other_ if the broadcaster uses a language that Twitch doesn’t support.
        /// </param>
        /// <param name="title">
        /// The title of the clip.
        /// </param>
        /// <param name="viewCount">
        /// The number of times the clip has been viewed.
        /// </param>
        /// <param name="createdAt">
        /// The date and time of when the clip was created. The date and time is in RFC3339 format.
        /// </param>
        /// <param name="thumbnailUrl">
        /// A URL to a thumbnail image of the clip.
        /// </param>
        /// <param name="duration">
        /// The length of the clip, in seconds. Precision is 0.1.
        /// </param>
        /// <param name="vodOffset">
        /// The zero-based offset, in seconds, to where the clip starts in the video (VOD). Is **null** if the video is not available or hasn’t been created yet from the live stream (see `video_id`).  <br/>
        ///   <br/>
        /// Note that there’s a delay between when a clip is created during a broadcast and when the offset is set. During the delay period, `vod_offset` is **null**. The delay is indeterminant but is typically minutes long.
        /// </param>
        /// <param name="isFeatured">
        /// A Boolean value that indicates if the clip is featured or not.
        /// </param>
        public Clip(
            string id,
            string url,
            string embedUrl,
            string broadcasterId,
            string broadcasterName,
            string creatorId,
            string creatorName,
            string videoId,
            string gameId,
            string language,
            string title,
            int viewCount,
            global::System.DateTime createdAt,
            string thumbnailUrl,
            float duration,
            int? vodOffset,
            bool isFeatured)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.EmbedUrl = embedUrl ?? throw new global::System.ArgumentNullException(nameof(embedUrl));
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.BroadcasterName = broadcasterName ?? throw new global::System.ArgumentNullException(nameof(broadcasterName));
            this.CreatorId = creatorId ?? throw new global::System.ArgumentNullException(nameof(creatorId));
            this.CreatorName = creatorName ?? throw new global::System.ArgumentNullException(nameof(creatorName));
            this.VideoId = videoId ?? throw new global::System.ArgumentNullException(nameof(videoId));
            this.GameId = gameId ?? throw new global::System.ArgumentNullException(nameof(gameId));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.ViewCount = viewCount;
            this.CreatedAt = createdAt;
            this.ThumbnailUrl = thumbnailUrl ?? throw new global::System.ArgumentNullException(nameof(thumbnailUrl));
            this.Duration = duration;
            this.VodOffset = vodOffset;
            this.IsFeatured = isFeatured;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Clip" /> class.
        /// </summary>
        public Clip()
        {
        }
    }
}