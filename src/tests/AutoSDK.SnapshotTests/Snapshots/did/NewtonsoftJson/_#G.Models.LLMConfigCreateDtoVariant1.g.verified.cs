//HintName: G.Models.LLMConfigCreateDtoVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create-request shapes: `provider` is required. Plain interfaces (no Omit/Pick) so TSOA can generate routes.
    /// </summary>
    public sealed partial class LLMConfigCreateDtoVariant1
    {
        /// <summary>
        /// Large Language Model provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LLMConfigCreateDtoVariant1ProviderJsonConverter))]
        public global::G.LLMConfigCreateDtoVariant1Provider Provider { get; set; }

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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LLMConfigCreateDtoVariant1TemplateJsonConverter))]
        public global::G.LLMConfigCreateDtoVariant1Template? Template { get; set; }

        /// <summary>
        /// Advanced configuration for the language model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_customization")]
        public global::G.LLMConfigCreateDtoVariant1PromptCustomization? PromptCustomization { get; set; }

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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LLMConfigCreateDtoVariant1ModelJsonConverter))]
        public global::G.LLMConfigCreateDtoVariant1Model? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMConfigCreateDtoVariant1" /> class.
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
        public LLMConfigCreateDtoVariant1(
            global::G.LLMConfigCreateDtoVariant1Provider provider,
            string? instructions,
            global::G.LLMConfigCreateDtoVariant1Template? template,
            global::G.LLMConfigCreateDtoVariant1PromptCustomization? promptCustomization,
            double? temperature,
            global::G.LLMConfigCreateDtoVariant1Model? model)
        {
            this.Provider = provider;
            this.Instructions = instructions;
            this.Template = template;
            this.PromptCustomization = promptCustomization;
            this.Temperature = temperature;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMConfigCreateDtoVariant1" /> class.
        /// </summary>
        public LLMConfigCreateDtoVariant1()
        {
        }
    }
}