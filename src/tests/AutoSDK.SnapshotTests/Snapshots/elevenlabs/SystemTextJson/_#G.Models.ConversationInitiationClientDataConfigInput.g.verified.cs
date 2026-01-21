//HintName: G.Models.ConversationInitiationClientDataConfigInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"custom_llm_extra_body":true,"enable_conversation_initiation_client_data_from_webhook":true}
    /// </summary>
    public sealed partial class ConversationInitiationClientDataConfigInput
    {
        /// <summary>
        /// Overrides for the conversation configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_config_override")]
        public global::G.ConversationConfigClientOverrideConfigInput? ConversationConfigOverride { get; set; }

        /// <summary>
        /// Whether to include custom LLM extra body<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_llm_extra_body")]
        public bool? CustomLlmExtraBody { get; set; }

        /// <summary>
        /// Whether to enable conversation initiation client data from webhooks<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_conversation_initiation_client_data_from_webhook")]
        public bool? EnableConversationInitiationClientDataFromWebhook { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationInitiationClientDataConfigInput" /> class.
        /// </summary>
        /// <param name="conversationConfigOverride">
        /// Overrides for the conversation configuration
        /// </param>
        /// <param name="customLlmExtraBody">
        /// Whether to include custom LLM extra body<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableConversationInitiationClientDataFromWebhook">
        /// Whether to enable conversation initiation client data from webhooks<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationInitiationClientDataConfigInput(
            global::G.ConversationConfigClientOverrideConfigInput? conversationConfigOverride,
            bool? customLlmExtraBody,
            bool? enableConversationInitiationClientDataFromWebhook)
        {
            this.ConversationConfigOverride = conversationConfigOverride;
            this.CustomLlmExtraBody = customLlmExtraBody;
            this.EnableConversationInitiationClientDataFromWebhook = enableConversationInitiationClientDataFromWebhook;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationInitiationClientDataConfigInput" /> class.
        /// </summary>
        public ConversationInitiationClientDataConfigInput()
        {
        }
    }
}