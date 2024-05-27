//HintName: G.Models.ChannelInformation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChannelInformation
    {
        /// <summary>
        /// An ID that uniquely identifies the broadcaster.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterId { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterLogin { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterName { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s preferred language. The value is an ISO 639-1 two-letter language code (for example, _en_ for English). The value is set to “other” if the language is not a Twitch supported language.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_language", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterLanguage { get; set; } = default!;

        /// <summary>
        /// The name of the game that the broadcaster is playing or last played. The value is an empty string if the broadcaster has never played a game.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("game_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string GameName { get; set; } = default!;

        /// <summary>
        /// An ID that uniquely identifies the game that the broadcaster is playing or last played. The value is an empty string if the broadcaster has never played a game.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("game_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string GameId { get; set; } = default!;

        /// <summary>
        /// The title of the stream that the broadcaster is currently streaming or last streamed. The value is an empty string if the broadcaster has never streamed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// The value of the broadcaster’s stream delay setting, in seconds. This field’s value defaults to zero unless 1) the request specifies a user access token, 2) the ID in the _broadcaster\_id_ query parameter matches the user ID in the access token, and 3) the broadcaster has partner status and they set a non-zero stream delay value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delay", Required = global::Newtonsoft.Json.Required.Always)]
        public int Delay { get; set; } = default!;

        /// <summary>
        /// The tags applied to the channel.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Tags { get; set; } = default!;

        /// <summary>
        /// The CCLs applied to the channel.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_classification_labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> ContentClassificationLabels { get; set; } = default!;

        /// <summary>
        /// Boolean flag indicating if the channel has branded content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_branded_content", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsBrandedContent { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}