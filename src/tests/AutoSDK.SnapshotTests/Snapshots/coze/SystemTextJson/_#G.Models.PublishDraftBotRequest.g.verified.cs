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
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ConnectorIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectors")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>>? Connectors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishDraftBotRequest" /> class.
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="connectorIds"></param>
        /// <param name="connectors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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