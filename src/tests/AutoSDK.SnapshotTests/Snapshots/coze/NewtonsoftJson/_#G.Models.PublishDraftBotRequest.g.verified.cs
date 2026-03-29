//HintName: G.Models.PublishDraftBotRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublishDraftBotRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bot_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BotId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connector_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> ConnectorIds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connectors")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>>? Connectors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishDraftBotRequest" /> class.
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="connectorIds"></param>
        /// <param name="connectors"></param>
        public PublishDraftBotRequest(
            string botId,
            global::System.Collections.Generic.IList<string> connectorIds,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>>? connectors)
        {
            this.BotId = botId ?? throw new global::System.ArgumentNullException(nameof(botId));
            this.ConnectorIds = connectorIds ?? throw new global::System.ArgumentNullException(nameof(connectorIds));
            this.Connectors = connectors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishDraftBotRequest" /> class.
        /// </summary>
        public PublishDraftBotRequest()
        {
        }
    }
}