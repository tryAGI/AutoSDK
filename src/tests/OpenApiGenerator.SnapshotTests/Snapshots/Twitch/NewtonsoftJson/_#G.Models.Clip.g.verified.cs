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
        /// The zero-based offset, in seconds, to where the clip starts in the video (VOD). Is **null** if the video is not available or hasn’t been created yet from the live stream (see `video_id`).  
        ///   
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
    }
}