//HintName: G.Models.PublishDraftBotData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublishDraftBotData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bot_id")]
        public string? BotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishDraftBotData" /> class.
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="version"></param>
        public PublishDraftBotData(
            string? botId,
            string? version)
        {
            this.BotId = botId;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishDraftBotData" /> class.
        /// </summary>
        public PublishDraftBotData()
        {
        }
    }
}