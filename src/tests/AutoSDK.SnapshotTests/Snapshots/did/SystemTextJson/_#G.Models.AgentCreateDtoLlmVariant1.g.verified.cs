//HintName: G.Models.AgentCreateDtoLlmVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create-request shapes: `provider` is required. Plain interfaces (no Omit/Pick) so TSOA can generate routes.
    /// </summary>
    public sealed partial class AgentCreateDtoLlmVariant1
    {
        /// <summary>
        /// Large Language Model provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentCreateDtoLlmVariant1ProviderJsonConverter))]
        public global::G.AgentCreateDtoLlmVariant1Provider Provider { get; set; }

        /// <summary>
        /// Defines what the Agent does and how it should behave.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// How the Agent uses knowledge when generating responses.<br/>
        /// - RAG-Grounded: Uses only provided knowledge<br/>
        /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
        /// - Assistant: Uses general model knowledge only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentCreateDtoLlmVariant1TemplateJsonConverter))]
        public global::G.AgentCreateDtoLlmVariant1Template? Template { get; set; }

        /// <summary>
        /// Advanced configuration for the language model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_customization")]
        public global::G.AgentCreateDtoLlmVariant1PromptCustomization? PromptCustomization { get; set; }

        /// <summary>
        /// Controls how predictable or creative the Agent’s responses are.<br/>
        /// Default values by template:<br/>
        /// RAG-Grounded: 0.1<br/>
        /// RAG-Ungrounded: 0.5<br/>
        /// Assistant: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The model to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentCreateDtoLlmVariant1ModelJsonConverter))]
        public global::G.AgentCreateDtoLlmVariant1Model? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCreateDtoLlmVariant1" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentCreateDtoLlmVariant1(
            global::G.AgentCreateDtoLlmVariant1Provider provider,
            string? instructions,
            global::G.AgentCreateDtoLlmVariant1Template? template,
            global::G.AgentCreateDtoLlmVariant1PromptCustomization? promptCustomization,
            double? temperature,
            global::G.AgentCreateDtoLlmVariant1Model? model)
        {
            this.Provider = provider;
            this.Instructions = instructions;
            this.Template = template;
            this.PromptCustomization = promptCustomization;
            this.Temperature = temperature;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCreateDtoLlmVariant1" /> class.
        /// </summary>
        public AgentCreateDtoLlmVariant1()
        {
        }
    }
}