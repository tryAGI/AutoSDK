//HintName: G.Models.Stream.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Stream
    {
        /// <summary>
        /// An ID that identifies the stream. You can use this ID later to look up the video on demand (VOD).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the user that’s broadcasting the stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The user’s login name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserLogin { get; set; }

        /// <summary>
        /// The user’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserName { get; set; }

        /// <summary>
        /// The ID of the category or game being played.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("game_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GameId { get; set; }

        /// <summary>
        /// The ID of the category or game being played.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("game_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GameName { get; set; }

        /// <summary>
        /// The type of stream. Possible values are:  <br/>
        ///   <br/>
        /// * live<br/>
        ///   <br/>
        /// If an error occurs, this field is set to an empty string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StreamTypeJsonConverter))]
        public global::G.StreamType Type { get; set; }

        /// <summary>
        /// The stream’s title. Is an empty string if not set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The number of users watching the stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viewer_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ViewerCount { get; set; }

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the broadcast began.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// The language that the stream uses. This is an ISO 639-1 two-letter language code or _other_ if the stream uses a language not in the list of [supported stream languages](https://help.twitch.tv/s/article/languages-on-twitch#streamlang).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// A URL to an image of a frame from the last 5 minutes of the stream. Replace the width and height placeholders in the URL (`{width}x{height}`) with the size of the image you want, in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ThumbnailUrl { get; set; }

        /// <summary>
        /// **IMPORTANT** As of February 28, 2023, this field is deprecated and returns only an empty array. If you use this field, please update your code to use the `tags` field.  <br/>
        ///   <br/>
        /// The list of tags that apply to the stream. The list contains IDs only when the channel is steaming live. For a list of possible tags, see [List of All Tags](https://www.twitch.tv/directory/all/tags). The list doesn’t include Category Tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TagIds { get; set; }

        /// <summary>
        /// The tags applied to the stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// A Boolean value that indicates whether the stream is meant for mature audiences.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_mature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsMature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Stream" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID that identifies the stream. You can use this ID later to look up the video on demand (VOD).
        /// </param>
        /// <param name="userId">
        /// The ID of the user that’s broadcasting the stream.
        /// </param>
        /// <param name="userLogin">
        /// The user’s login name.
        /// </param>
        /// <param name="userName">
        /// The user’s display name.
        /// </param>
        /// <param name="gameId">
        /// The ID of the category or game being played.
        /// </param>
        /// <param name="gameName">
        /// The ID of the category or game being played.
        /// </param>
        /// <param name="type">
        /// The type of stream. Possible values are:  <br/>
        ///   <br/>
        /// * live<br/>
        ///   <br/>
        /// If an error occurs, this field is set to an empty string.
        /// </param>
        /// <param name="title">
        /// The stream’s title. Is an empty string if not set.
        /// </param>
        /// <param name="viewerCount">
        /// The number of users watching the stream.
        /// </param>
        /// <param name="startedAt">
        /// The UTC date and time (in RFC3339 format) of when the broadcast began.
        /// </param>
        /// <param name="language">
        /// The language that the stream uses. This is an ISO 639-1 two-letter language code or _other_ if the stream uses a language not in the list of [supported stream languages](https://help.twitch.tv/s/article/languages-on-twitch#streamlang).
        /// </param>
        /// <param name="thumbnailUrl">
        /// A URL to an image of a frame from the last 5 minutes of the stream. Replace the width and height placeholders in the URL (`{width}x{height}`) with the size of the image you want, in pixels.
        /// </param>
        /// <param name="tagIds">
        /// **IMPORTANT** As of February 28, 2023, this field is deprecated and returns only an empty array. If you use this field, please update your code to use the `tags` field.  <br/>
        ///   <br/>
        /// The list of tags that apply to the stream. The list contains IDs only when the channel is steaming live. For a list of possible tags, see [List of All Tags](https://www.twitch.tv/directory/all/tags). The list doesn’t include Category Tags.
        /// </param>
        /// <param name="tags">
        /// The tags applied to the stream.
        /// </param>
        /// <param name="isMature">
        /// A Boolean value that indicates whether the stream is meant for mature audiences.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Stream(
            string id,
            string userId,
            string userLogin,
            string userName,
            string gameId,
            string gameName,
            string title,
            int viewerCount,
            global::System.DateTime startedAt,
            string language,
            string thumbnailUrl,
            global::System.Collections.Generic.IList<string> tagIds,
            global::System.Collections.Generic.IList<string> tags,
            bool isMature,
            global::G.StreamType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.UserLogin = userLogin ?? throw new global::System.ArgumentNullException(nameof(userLogin));
            this.UserName = userName ?? throw new global::System.ArgumentNullException(nameof(userName));
            this.GameId = gameId ?? throw new global::System.ArgumentNullException(nameof(gameId));
            this.GameName = gameName ?? throw new global::System.ArgumentNullException(nameof(gameName));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.ViewerCount = viewerCount;
            this.StartedAt = startedAt;
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.ThumbnailUrl = thumbnailUrl ?? throw new global::System.ArgumentNullException(nameof(thumbnailUrl));
            this.TagIds = tagIds ?? throw new global::System.ArgumentNullException(nameof(tagIds));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.IsMature = isMature;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Stream" /> class.
        /// </summary>
        public Stream()
        {
        }
    }
}