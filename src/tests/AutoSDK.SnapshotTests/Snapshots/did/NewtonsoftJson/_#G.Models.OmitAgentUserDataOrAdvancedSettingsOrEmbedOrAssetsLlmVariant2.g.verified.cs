//HintName: G.Models.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OpenAI External LLM
    /// </summary>
    public sealed partial class OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2
    {
        /// <summary>
        /// Defines what the Agent does and how it should behave.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// How the Agent uses knowledge when generating responses.<br/>
        /// - RAG-Grounded: Uses only provided knowledge<br/>
        /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
        /// - Assistant: Uses general model knowledge only
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template")]
        public global::G.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2Template? Template { get; set; }

        /// <summary>
        /// Advanced configuration for the language model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_customization")]
        public global::G.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2PromptCustomization? PromptCustomization { get; set; }

        /// <summary>
        /// Controls how predictable or creative the Agent’s responses are.<br/>
        /// Default values by template:<br/>
        /// RAG-Grounded: 0.1<br/>
        /// RAG-Ungrounded: 0.5<br/>
        /// Assistant: 0.5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// ID of the stored secret containing the external OpenAI API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secretId")]
        public string? SecretId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2" /> class.
        /// </summary>
        /// <param name="instructions">
        /// Defines what the Agent does and how it should behave.
        /// </param>
        /// <param name="template">
        /// How the Agent uses knowledge when generating responses.<br/>
        /// - RAG-Grounded: Uses only provided knowledge<br/>
        /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
        /// - Assistant: Uses general model knowledge only
        /// </param>
        /// <param name="promptCustomization">
        /// Advanced configuration for the language model.
        /// </param>
        /// <param name="temperature">
        /// Controls how predictable or creative the Agent’s responses are.<br/>
        /// Default values by template:<br/>
        /// RAG-Grounded: 0.1<br/>
        /// RAG-Ungrounded: 0.5<br/>
        /// Assistant: 0.5
        /// </param>
        /// <param name="secretId">
        /// ID of the stored secret containing the external OpenAI API key
        /// </param>
        public OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2(
            string? instructions,
            global::G.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2Template? template,
            global::G.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2PromptCustomization? promptCustomization,
            double? temperature,
            string? secretId)
        {
            this.Instructions = instructions;
            this.Template = template;
            this.PromptCustomization = promptCustomization;
            this.Temperature = temperature;
            this.SecretId = secretId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2" /> class.
        /// </summary>
        public OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2()
        {
        }
    }
}