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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the stream that the video originated from if the video's type is "archive;" otherwise, **null**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? StreamId { get; set; }

        /// <summary>
        /// The ID of the broadcaster that owns the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The broadcaster's login name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserLogin { get; set; }

        /// <summary>
        /// The broadcaster's display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserName { get; set; }

        /// <summary>
        /// The video's title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The video's description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The date and time, in UTC, of when the video was created. The timestamp is in RFC3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time, in UTC, of when the video was published. The timestamp is in RFC3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PublishedAt { get; set; }

        /// <summary>
        /// The video's URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// A URL to a thumbnail image of the video. Before using the URL, you must replace the `%{width}` and `%{height}` placeholders with the width and height of the thumbnail you want returned. Due to current limitations, `${width}` must be 320 and `${height}` must be 180.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ThumbnailUrl { get; set; }

        /// <summary>
        /// The video's viewable state. Always set to **public**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viewable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Viewable { get; set; }

        /// <summary>
        /// The number of times that users have watched the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("view_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ViewCount { get; set; }

        /// <summary>
        /// The ISO 639-1 two-letter language code that the video was broadcast in. For example, the language code is DE if the video was broadcast in German. For a list of supported languages, see [Supported Stream Language](https://help.twitch.tv/s/article/languages-on-twitch#streamlang). The language value is "other" if the video was broadcast in a language not in the list of supported languages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// The video's type. Possible values are:  <br/>
        ///   <br/>
        /// * archive — An on-demand video (VOD) of one of the broadcaster's past streams.<br/>
        /// * highlight — A highlight reel of one of the broadcaster's past streams. See [Creating Highlights](https://help.twitch.tv/s/article/creating-highlights-and-stream-markers).<br/>
        /// * upload — A video that the broadcaster uploaded to their video library. See Upload under [Video Producer](https://help.twitch.tv/s/article/video-on-demand?language=en%5FUS#videoproducer).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VideoTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VideoType Type { get; set; }

        /// <summary>
        /// The video's length in ISO 8601 duration format. For example, 3m21s represents 3 minutes, 21 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Duration { get; set; }

        /// <summary>
        /// The segments that Twitch Audio Recognition muted; otherwise, **null**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("muted_segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.VideoMutedSegment>? MutedSegments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.Video? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.Video),
                jsonSerializerContext) as global::G.Video;
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
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.Video>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.Video?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.Video),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.Video;
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
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.Video?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}