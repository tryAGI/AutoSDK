//HintName: G.Models.Video.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Video
    {
        /// <summary>
        /// An ID that identifies the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The ID of the stream that the video originated from if the video's type is "archive;" otherwise, **null**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string? StreamId { get; set; } = default!;

        /// <summary>
        /// The ID of the broadcaster that owns the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// The broadcaster's login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserLogin { get; set; } = default!;

        /// <summary>
        /// The broadcaster's display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserName { get; set; } = default!;

        /// <summary>
        /// The video's title.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// The video's description.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// The date and time, in UTC, of when the video was created. The timestamp is in RFC3339 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The date and time, in UTC, of when the video was published. The timestamp is in RFC3339 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("published_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime PublishedAt { get; set; } = default!;

        /// <summary>
        /// The video's URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// A URL to a thumbnail image of the video. Before using the URL, you must replace the `%{width}` and `%{height}` placeholders with the width and height of the thumbnail you want returned. Due to current limitations, `${width}` must be 320 and `${height}` must be 180.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ThumbnailUrl { get; set; } = default!;

        /// <summary>
        /// The video's viewable state. Always set to **public**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("viewable", Required = global::Newtonsoft.Json.Required.Always)]
        public string Viewable { get; set; } = default!;

        /// <summary>
        /// The number of times that users have watched the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("view_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ViewCount { get; set; } = default!;

        /// <summary>
        /// The ISO 639-1 two-letter language code that the video was broadcast in. For example, the language code is DE if the video was broadcast in German. For a list of supported languages, see [Supported Stream Language](https://help.twitch.tv/s/article/languages-on-twitch#streamlang). The language value is "other" if the video was broadcast in a language not in the list of supported languages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// The video's type. Possible values are:  <br/>
        ///   <br/>
        /// * archive — An on-demand video (VOD) of one of the broadcaster's past streams.<br/>
        /// * highlight — A highlight reel of one of the broadcaster's past streams. See [Creating Highlights](https://help.twitch.tv/s/article/creating-highlights-and-stream-markers).<br/>
        /// * upload — A video that the broadcaster uploaded to their video library. See Upload under [Video Producer](https://help.twitch.tv/s/article/video-on-demand?language=en%5FUS#videoproducer).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VideoType Type { get; set; } = default!;

        /// <summary>
        /// The video's length in ISO 8601 duration format. For example, 3m21s represents 3 minutes, 21 seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration", Required = global::Newtonsoft.Json.Required.Always)]
        public string Duration { get; set; } = default!;

        /// <summary>
        /// The segments that Twitch Audio Recognition muted; otherwise, **null**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("muted_segments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.VideoMutedSegment>? MutedSegments { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Video" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID that identifies the video.
        /// </param>
        /// <param name="streamId">
        /// The ID of the stream that the video originated from if the video's type is "archive;" otherwise, **null**.
        /// </param>
        /// <param name="userId">
        /// The ID of the broadcaster that owns the video.
        /// </param>
        /// <param name="userLogin">
        /// The broadcaster's login name.
        /// </param>
        /// <param name="userName">
        /// The broadcaster's display name.
        /// </param>
        /// <param name="title">
        /// The video's title.
        /// </param>
        /// <param name="description">
        /// The video's description.
        /// </param>
        /// <param name="createdAt">
        /// The date and time, in UTC, of when the video was created. The timestamp is in RFC3339 format.
        /// </param>
        /// <param name="publishedAt">
        /// The date and time, in UTC, of when the video was published. The timestamp is in RFC3339 format.
        /// </param>
        /// <param name="url">
        /// The video's URL.
        /// </param>
        /// <param name="thumbnailUrl">
        /// A URL to a thumbnail image of the video. Before using the URL, you must replace the `%{width}` and `%{height}` placeholders with the width and height of the thumbnail you want returned. Due to current limitations, `${width}` must be 320 and `${height}` must be 180.
        /// </param>
        /// <param name="viewable">
        /// The video's viewable state. Always set to **public**.
        /// </param>
        /// <param name="viewCount">
        /// The number of times that users have watched the video.
        /// </param>
        /// <param name="language">
        /// The ISO 639-1 two-letter language code that the video was broadcast in. For example, the language code is DE if the video was broadcast in German. For a list of supported languages, see [Supported Stream Language](https://help.twitch.tv/s/article/languages-on-twitch#streamlang). The language value is "other" if the video was broadcast in a language not in the list of supported languages.
        /// </param>
        /// <param name="type">
        /// The video's type. Possible values are:  <br/>
        ///   <br/>
        /// * archive — An on-demand video (VOD) of one of the broadcaster's past streams.<br/>
        /// * highlight — A highlight reel of one of the broadcaster's past streams. See [Creating Highlights](https://help.twitch.tv/s/article/creating-highlights-and-stream-markers).<br/>
        /// * upload — A video that the broadcaster uploaded to their video library. See Upload under [Video Producer](https://help.twitch.tv/s/article/video-on-demand?language=en%5FUS#videoproducer).
        /// </param>
        /// <param name="duration">
        /// The video's length in ISO 8601 duration format. For example, 3m21s represents 3 minutes, 21 seconds.
        /// </param>
        /// <param name="mutedSegments">
        /// The segments that Twitch Audio Recognition muted; otherwise, **null**.
        /// </param>
        public Video(
            string id,
            string? streamId,
            string userId,
            string userLogin,
            string userName,
            string title,
            string description,
            global::System.DateTime createdAt,
            global::System.DateTime publishedAt,
            string url,
            string thumbnailUrl,
            string viewable,
            int viewCount,
            string language,
            global::G.VideoType type,
            string duration,
            global::System.Collections.Generic.IList<global::G.VideoMutedSegment>? mutedSegments)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.StreamId = streamId ?? throw new global::System.ArgumentNullException(nameof(streamId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.UserLogin = userLogin ?? throw new global::System.ArgumentNullException(nameof(userLogin));
            this.UserName = userName ?? throw new global::System.ArgumentNullException(nameof(userName));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.CreatedAt = createdAt;
            this.PublishedAt = publishedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ThumbnailUrl = thumbnailUrl ?? throw new global::System.ArgumentNullException(nameof(thumbnailUrl));
            this.Viewable = viewable ?? throw new global::System.ArgumentNullException(nameof(viewable));
            this.ViewCount = viewCount;
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Type = type;
            this.Duration = duration ?? throw new global::System.ArgumentNullException(nameof(duration));
            this.MutedSegments = mutedSegments ?? throw new global::System.ArgumentNullException(nameof(mutedSegments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Video" /> class.
        /// </summary>
        public Video()
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
        public static global::G.Video? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Video>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.Video?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.Video?>(serializer.Deserialize<global::G.Video>(jsonReader));
        }

    }
}