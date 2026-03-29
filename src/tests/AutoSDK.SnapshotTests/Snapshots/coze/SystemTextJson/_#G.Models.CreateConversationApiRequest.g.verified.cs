//HintName: G.Models.CreateConversationApiRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConversationApiRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_id")]
        public string? BotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector_id")]
        public string? ConnectorId { get; set; }

        /// <summary>
        /// 校验最多16个
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::G.EnterMessage1>? Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta_data")]
        public global::System.Collections.Generic.Dictionary<string, string>? MetaData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationApiRequest" /> class.
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="connectorId"></param>
        /// <param name="messages">
        /// 校验最多16个
        /// </param>
        /// <param name="metaData"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConversationApiRequest(
            string? botId,
            string? connectorId,
            global::System.Collections.Generic.IList<global::G.EnterMessage1>? messages,
            global::System.Collections.Generic.Dictionary<string, string>? metaData,
            string? name)
        {
            this.BotId = botId;
            this.ConnectorId = connectorId;
            this.Messages = messages;
            this.MetaData = metaData;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationApiRequest" /> class.
        /// </summary>
        public CreateConversationApiRequest()
        {
        }
    }
}