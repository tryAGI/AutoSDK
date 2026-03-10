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
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Example: {"first_message":"Hello! How can I help you today?","language":"en","language_presets":{},"supported_language_overrides":["es","fr"],"supports_text_only":true,"text_only":false,"use_rtc":false}
        /// </summary>
        /// <example>{"first_message":"Hello! How can I help you today?","language":"en","language_presets":{},"supported_language_overrides":["es","fr"],"supports_text_only":true,"text_only":false,"use_rtc":false}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("widget_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WidgetConfigResponseModel WidgetConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentEmbedResponseModel" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="widgetConfig">
        /// Example: {"first_message":"Hello! How can I help you today?","language":"en","language_presets":{},"supported_language_overrides":["es","fr"],"supports_text_only":true,"text_only":false,"use_rtc":false}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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