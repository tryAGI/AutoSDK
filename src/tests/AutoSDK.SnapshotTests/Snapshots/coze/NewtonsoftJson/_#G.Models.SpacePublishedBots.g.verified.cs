//HintName: G.Models.SpacePublishedBots.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpacePublishedBots
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bot_id")]
        public string? BotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bot_name")]
        public string? BotName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("icon_url")]
        public string? IconUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publish_time")]
        public string? PublishTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpacePublishedBots" /> class.
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="botName"></param>
        /// <param name="description"></param>
        /// <param name="iconUrl"></param>
        /// <param name="publishTime"></param>
        public SpacePublishedBots(
            string? botId,
            string? botName,
            string? description,
            string? iconUrl,
            string? publishTime)
        {
            this.BotId = botId;
            this.BotName = botName;
            this.Description = description;
            this.IconUrl = iconUrl;
            this.PublishTime = publishTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpacePublishedBots" /> class.
        /// </summary>
        public SpacePublishedBots()
        {
        }
    }
}