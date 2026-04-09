//HintName: G.Models.CreateRequestLlmVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRequestLlmVariant2
    {
        /// <summary>
        /// Large Language Model provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateRequestLlmVariant2ProviderJsonConverter))]
        public global::G.CreateRequestLlmVariant2Provider Provider { get; set; }

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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateRequestLlmVariant2TemplateJsonConverter))]
        public global::G.CreateRequestLlmVariant2Template? Template { get; set; }

        /// <summary>
        /// Advanced configuration for the language model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_customization")]
        public global::G.CreateRequestLlmVariant2PromptCustomization? PromptCustomization { get; set; }

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
        /// Custom/External LLM authentication configurations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom")]
        public global::G.AnyOf<global::G.CreateRequestLlmVariant2CustomBasic, global::G.CreateRequestLlmVariant2CustomOAuth2>? Custom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequestLlmVariant2" /> class.
        /// </summary>
        /// <param name="provider">
        /// Large Language Model provider.
        /// </param>
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
        /// <param name="custom">
        /// Custom/External LLM authentication configurations
        /// </param>
        public CreateRequestLlmVariant2(
            global::G.CreateRequestLlmVariant2Provider provider,
            string? instructions,
            global::G.CreateRequestLlmVariant2Template? template,
            global::G.CreateRequestLlmVariant2PromptCustomization? promptCustomization,
            double? temperature,
            global::G.AnyOf<global::G.CreateRequestLlmVariant2CustomBasic, global::G.CreateRequestLlmVariant2CustomOAuth2>? custom)
        {
            this.Provider = provider;
            this.Instructions = instructions;
            this.Template = template;
            this.PromptCustomization = promptCustomization;
            this.Temperature = temperature;
            this.Custom = custom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequestLlmVariant2" /> class.
        /// </summary>
        public CreateRequestLlmVariant2()
        {
        }
    }
}