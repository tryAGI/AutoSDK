//HintName: G.Models.ModifyChannelInformationBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModifyChannelInformationBody
    {
        /// <summary>
        /// The ID of the game that the user plays. The game is not updated if the ID isn’t a game ID that Twitch recognizes. To unset this field, use “0” or “” (an empty string).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("game_id")]
        public string? GameId { get; set; }

        /// <summary>
        /// The user’s preferred language. Set the value to an ISO 639-1 two-letter language code (for example, _en_ for English). Set to “other” if the user’s preferred language is not a Twitch supported language. The language isn’t updated if the language code isn’t a Twitch supported language.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_language")]
        public string? BroadcasterLanguage { get; set; }

        /// <summary>
        /// The title of the user’s stream. You may not set this field to an empty string.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The number of seconds you want your broadcast buffered before streaming it live. The delay helps ensure fairness during competitive play. Only users with Partner status may set this field. The maximum delay is 900 seconds (15 minutes).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delay")]
        public int Delay { get; set; }

        /// <summary>
        /// A list of channel-defined tags to apply to the channel. To remove all tags from the channel, set tags to an empty array. Tags help identify the content that the channel streams. [Learn More](https://help.twitch.tv/s/article/guide-to-tags)  <br/>
        ///   <br/>
        /// A channel may specify a maximum of 10 tags. Each tag is limited to a maximum of 25 characters and may not be an empty string or contain spaces or special characters. Tags are case insensitive. For readability, consider using camelCasing or PascalCasing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string?>? Tags { get; set; }

        /// <summary>
        /// List of labels that should be set as the Channel’s CCLs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_classification_labels")]
        public global::System.Collections.Generic.IList<global::G.ModifyChannelInformationBodyContentClassificationLabels?>? ContentClassificationLabels { get; set; }

        /// <summary>
        /// Boolean flag indicating if the channel has branded content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_branded_content")]
        public bool IsBrandedContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}