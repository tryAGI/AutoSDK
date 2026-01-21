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
        /// Example: {"action_text":"Call","bg_color":"#ffffff","border_color":"#e1e1e1","border_radius":10,"btn_color":"#000000","btn_radius":10,"btn_text_color":"#ffffff","disable_banner":false,"end_call_text":"End Call","expand_text":"Expand","expandable":"never","feedback_mode":"none","focus_color":"#000000","listening_text":"Listening...","mic_muting_enabled":false,"shareable_page_show_terms":true,"shareable_page_text":"Share","speaking_text":"Speaking...","start_call_text":"Start Call","terms_html":"\u003Cp\u003ETerms and Conditions\u003C/p\u003E","terms_key":"terms","terms_text":"Terms and Conditions","text_color":"#000000","variant":"full"}
        /// </summary>
        /// <example>{"action_text":"Call","bg_color":"#ffffff","border_color":"#e1e1e1","border_radius":10,"btn_color":"#000000","btn_radius":10,"btn_text_color":"#ffffff","disable_banner":false,"end_call_text":"End Call","expand_text":"Expand","expandable":"never","feedback_mode":"none","focus_color":"#000000","listening_text":"Listening...","mic_muting_enabled":false,"shareable_page_show_terms":true,"shareable_page_text":"Share","speaking_text":"Speaking...","start_call_text":"Start Call","terms_html":"\u003Cp\u003ETerms and Conditions\u003C/p\u003E","terms_key":"terms","terms_text":"Terms and Conditions","text_color":"#000000","variant":"full"}</example>
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
        /// Example: {"action_text":"Call","bg_color":"#ffffff","border_color":"#e1e1e1","border_radius":10,"btn_color":"#000000","btn_radius":10,"btn_text_color":"#ffffff","disable_banner":false,"end_call_text":"End Call","expand_text":"Expand","expandable":"never","feedback_mode":"none","focus_color":"#000000","listening_text":"Listening...","mic_muting_enabled":false,"shareable_page_show_terms":true,"shareable_page_text":"Share","speaking_text":"Speaking...","start_call_text":"Start Call","terms_html":"\u003Cp\u003ETerms and Conditions\u003C/p\u003E","terms_key":"terms","terms_text":"Terms and Conditions","text_color":"#000000","variant":"full"}
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