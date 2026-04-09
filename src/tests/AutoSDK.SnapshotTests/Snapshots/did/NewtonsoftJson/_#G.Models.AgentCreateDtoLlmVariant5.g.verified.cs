//HintName: G.Models.AgentCreateDtoLlmVariant5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentCreateDtoLlmVariant5
    {
        /// <summary>
        /// Large Language Model provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AgentCreateDtoLlmVariant5ProviderJsonConverter))]
        public global::G.AgentCreateDtoLlmVariant5Provider Provider { get; set; }

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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AgentCreateDtoLlmVariant5TemplateJsonConverter))]
        public global::G.AgentCreateDtoLlmVariant5Template? Template { get; set; }

        /// <summary>
        /// Advanced configuration for the language model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_customization")]
        public global::G.AgentCreateDtoLlmVariant5PromptCustomization? PromptCustomization { get; set; }

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
        /// The model to use
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AgentCreateDtoLlmVariant5ModelJsonConverter))]
        public global::G.AgentCreateDtoLlmVariant5Model? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCreateDtoLlmVariant5" /> class.
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
        /// <param name="model">
        /// The model to use
        /// </param>
        public AgentCreateDtoLlmVariant5(
            global::G.AgentCreateDtoLlmVariant5Provider provider,
            string? instructions,
            global::G.AgentCreateDtoLlmVariant5Template? template,
            global::G.AgentCreateDtoLlmVariant5PromptCustomization? promptCustomization,
            double? temperature,
            global::G.AgentCreateDtoLlmVariant5Model? model)
        {
            this.Provider = provider;
            this.Instructions = instructions;
            this.Template = template;
            this.PromptCustomization = promptCustomization;
            this.Temperature = temperature;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCreateDtoLlmVariant5" /> class.
        /// </summary>
        public AgentCreateDtoLlmVariant5()
        {
        }
    }
}