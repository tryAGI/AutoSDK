//HintName: G.Models.Channel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Channel
    {
        /// <summary>
        /// The ISO 639-1 two-letter language code of the language used by the broadcaster. For example, _en_ for English. If the broadcaster uses a language not in the list of [supported stream languages](https://help.twitch.tv/s/article/languages-on-twitch#streamlang), the value is _other_.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterLanguage { get; set; }

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterLogin { get; set; }

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// The ID of the game that the broadcaster is playing or last played.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("game_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GameId { get; set; }

        /// <summary>
        /// The name of the game that the broadcaster is playing or last played.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("game_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GameName { get; set; }

        /// <summary>
        /// An ID that uniquely identifies the channel (this is the broadcaster’s ID).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the broadcaster is streaming live. Is **true** if the broadcaster is streaming live; otherwise, **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_live")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsLive { get; set; }

        /// <summary>
        /// **IMPORTANT** As of February 28, 2023, this field is deprecated and returns only an empty array. If you use this field, please update your code to use the `tags` field.  <br/>
        ///   <br/>
        /// The list of tags that apply to the stream. The list contains IDs only when the channel is steaming live. For a list of possible tags, see [List of All Tags](https://www.twitch.tv/directory/all/tags). The list doesn’t include Category Tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TagIds { get; set; }

        /// <summary>
        /// The tags applied to the channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// A URL to a thumbnail of the broadcaster’s profile image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ThumbnailUrl { get; set; }

        /// <summary>
        /// The stream’s title. Is an empty string if the broadcaster didn’t set it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the broadcaster started streaming. The string is empty if the broadcaster is not streaming live.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Channel" /> class.
        /// </summary>
        /// <param name="broadcasterLanguage">
        /// The ISO 639-1 two-letter language code of the language used by the broadcaster. For example, _en_ for English. If the broadcaster uses a language not in the list of [supported stream languages](https://help.twitch.tv/s/article/languages-on-twitch#streamlang), the value is _other_.
        /// </param>
        /// <param name="broadcasterLogin">
        /// The broadcaster’s login name.
        /// </param>
        /// <param name="displayName">
        /// The broadcaster’s display name.
        /// </param>
        /// <param name="gameId">
        /// The ID of the game that the broadcaster is playing or last played.
        /// </param>
        /// <param name="gameName">
        /// The name of the game that the broadcaster is playing or last played.
        /// </param>
        /// <param name="id">
        /// An ID that uniquely identifies the channel (this is the broadcaster’s ID).
        /// </param>
        /// <param name="isLive">
        /// A Boolean value that determines whether the broadcaster is streaming live. Is **true** if the broadcaster is streaming live; otherwise, **false**.
        /// </param>
        /// <param name="tagIds">
        /// **IMPORTANT** As of February 28, 2023, this field is deprecated and returns only an empty array. If you use this field, please update your code to use the `tags` field.  <br/>
        ///   <br/>
        /// The list of tags that apply to the stream. The list contains IDs only when the channel is steaming live. For a list of possible tags, see [List of All Tags](https://www.twitch.tv/directory/all/tags). The list doesn’t include Category Tags.
        /// </param>
        /// <param name="tags">
        /// The tags applied to the channel.
        /// </param>
        /// <param name="thumbnailUrl">
        /// A URL to a thumbnail of the broadcaster’s profile image.
        /// </param>
        /// <param name="title">
        /// The stream’s title. Is an empty string if the broadcaster didn’t set it.
        /// </param>
        /// <param name="startedAt">
        /// The UTC date and time (in RFC3339 format) of when the broadcaster started streaming. The string is empty if the broadcaster is not streaming live.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Channel(
            string broadcasterLanguage,
            string broadcasterLogin,
            string displayName,
            string gameId,
            string gameName,
            string id,
            bool isLive,
            global::System.Collections.Generic.IList<string> tagIds,
            global::System.Collections.Generic.IList<string> tags,
            string thumbnailUrl,
            string title,
            global::System.DateTime startedAt)
        {
            this.BroadcasterLanguage = broadcasterLanguage ?? throw new global::System.ArgumentNullException(nameof(broadcasterLanguage));
            this.BroadcasterLogin = broadcasterLogin ?? throw new global::System.ArgumentNullException(nameof(broadcasterLogin));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.GameId = gameId ?? throw new global::System.ArgumentNullException(nameof(gameId));
            this.GameName = gameName ?? throw new global::System.ArgumentNullException(nameof(gameName));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IsLive = isLive;
            this.TagIds = tagIds ?? throw new global::System.ArgumentNullException(nameof(tagIds));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.ThumbnailUrl = thumbnailUrl ?? throw new global::System.ArgumentNullException(nameof(thumbnailUrl));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.StartedAt = startedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Channel" /> class.
        /// </summary>
        public Channel()
        {
        }
    }
}