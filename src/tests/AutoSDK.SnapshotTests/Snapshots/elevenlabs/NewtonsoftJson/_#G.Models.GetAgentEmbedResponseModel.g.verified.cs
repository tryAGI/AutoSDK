//HintName: G.Models.GetAgentEmbedResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgentEmbedResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("widget_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WidgetConfigResponseModel WidgetConfig { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentEmbedResponseModel" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="widgetConfig"></param>
        public GetAgentEmbedResponseModel(
            string agentId,
            global::G.WidgetConfigResponseModel widgetConfig)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.WidgetConfig = widgetConfig ?? throw new global::System.ArgumentNullException(nameof(widgetConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentEmbedResponseModel" /> class.
        /// </summary>
        public GetAgentEmbedResponseModel()
        {
        }
    }
}