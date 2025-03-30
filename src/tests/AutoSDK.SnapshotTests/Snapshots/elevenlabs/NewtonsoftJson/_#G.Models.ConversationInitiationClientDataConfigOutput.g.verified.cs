//HintName: G.Models.ConversationInitiationClientDataConfigOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationInitiationClientDataConfigOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_config_override")]
        public global::G.ConversationConfigClientOverrideConfigOutput? ConversationConfigOverride { get; set; }

        /// <summary>
        /// Whether to include custom LLM extra body<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_llm_extra_body")]
        public bool? CustomLlmExtraBody { get; set; }

        /// <summary>
        /// Whether to enable conversation initiation client data from webhooks<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_conversation_initiation_client_data_from_webhook")]
        public bool? EnableConversationInitiationClientDataFromWebhook { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationInitiationClientDataConfigOutput" /> class.
        /// </summary>
        /// <param name="conversationConfigOverride"></param>
        /// <param name="customLlmExtraBody">
        /// Whether to include custom LLM extra body<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableConversationInitiationClientDataFromWebhook">
        /// Whether to enable conversation initiation client data from webhooks<br/>
        /// Default Value: false
        /// </param>
        public ConversationInitiationClientDataConfigOutput(
            global::G.ConversationConfigClientOverrideConfigOutput? conversationConfigOverride,
            bool? customLlmExtraBody,
            bool? enableConversationInitiationClientDataFromWebhook)
        {
            this.ConversationConfigOverride = conversationConfigOverride;
            this.CustomLlmExtraBody = customLlmExtraBody;
            this.EnableConversationInitiationClientDataFromWebhook = enableConversationInitiationClientDataFromWebhook;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationInitiationClientDataConfigOutput" /> class.
        /// </summary>
        public ConversationInitiationClientDataConfigOutput()
        {
        }
    }
}