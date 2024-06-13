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
        [global::Newtonsoft.Json.JsonProperty("broadcaster_language", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterLanguage { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterLogin { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// The ID of the game that the broadcaster is playing or last played.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("game_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string GameId { get; set; } = default!;

        /// <summary>
        /// The name of the game that the broadcaster is playing or last played.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("game_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string GameName { get; set; } = default!;

        /// <summary>
        /// An ID that uniquely identifies the channel (this is the broadcaster’s ID).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether the broadcaster is streaming live. Is **true** if the broadcaster is streaming live; otherwise, **false**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_live", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsLive { get; set; } = default!;

        /// <summary>
        /// **IMPORTANT** As of February 28, 2023, this field is deprecated and returns only an empty array. If you use this field, please update your code to use the `tags` field.  <br/>
        ///   <br/>
        /// The list of tags that apply to the stream. The list contains IDs only when the channel is steaming live. For a list of possible tags, see [List of All Tags](https://www.twitch.tv/directory/all/tags). The list doesn’t include Category Tags.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> TagIds { get; set; } = default!;

        /// <summary>
        /// The tags applied to the channel.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Tags { get; set; } = default!;

        /// <summary>
        /// A URL to a thumbnail of the broadcaster’s profile image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ThumbnailUrl { get; set; } = default!;

        /// <summary>
        /// The stream’s title. Is an empty string if the broadcaster didn’t set it.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the broadcaster started streaming. The string is empty if the broadcaster is not streaming live.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}