﻿//HintName: G.Models.Clip.g.cs

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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A URL to the clip.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// A URL that you can use in an iframe to embed the clip (see [Embedding Video and Clips](https://dev.twitch.tv/docs/embed/video-and-clips)).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmbedUrl { get; set; }

        /// <summary>
        /// An ID that identifies the broadcaster that the video was clipped from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterId { get; set; }

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterName { get; set; }

        /// <summary>
        /// An ID that identifies the user that created the clip.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatorId { get; set; }

        /// <summary>
        /// The user’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatorName { get; set; }

        /// <summary>
        /// An ID that identifies the video that the clip came from. This field contains an empty string if the video is not available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoId { get; set; }

        /// <summary>
        /// The ID of the game that was being played when the clip was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("game_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GameId { get; set; }

        /// <summary>
        /// The ISO 639-1 two-letter language code that the broadcaster broadcasts in. For example, _en_ for English. The value is _other_ if the broadcaster uses a language that Twitch doesn’t support.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// The title of the clip.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The number of times the clip has been viewed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("view_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ViewCount { get; set; }

        /// <summary>
        /// The date and time of when the clip was created. The date and time is in RFC3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// A URL to a thumbnail image of the clip.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ThumbnailUrl { get; set; }

        /// <summary>
        /// The length of the clip, in seconds. Precision is 0.1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Duration { get; set; }

        /// <summary>
        /// The zero-based offset, in seconds, to where the clip starts in the video (VOD). Is **null** if the video is not available or hasn’t been created yet from the live stream (see `video_id`).  <br/>
        ///   <br/>
        /// Note that there’s a delay between when a clip is created during a broadcast and when the offset is set. During the delay period, `vod_offset` is **null**. The delay is indeterminant but is typically minutes long.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vod_offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? VodOffset { get; set; }

        /// <summary>
        /// A Boolean value that indicates if the clip is featured or not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_featured")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFeatured { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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