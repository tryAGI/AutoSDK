//HintName: G.Models.PromptVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModelProvider ModelProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TemplateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Template Template { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PromptTemplateTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PromptTemplateType TemplateType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PromptTemplateFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PromptTemplateFormat TemplateFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocation_parameters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InvocationParametersJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.InvocationParameters InvocationParameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::G.PromptTools? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::G.ResponseFormatVariant1? ResponseFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersion" /> class.
        /// </summary>
        /// <param name="modelProvider"></param>
        /// <param name="modelName"></param>
        /// <param name="template"></param>
        /// <param name="templateType"></param>
        /// <param name="templateFormat"></param>
        /// <param name="invocationParameters"></param>
        /// <param name="id"></param>
        /// <param name="description"></param>
        /// <param name="tools"></param>
        /// <param name="responseFormat"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVersion(
            global::G.ModelProvider modelProvider,
            string modelName,
            global::G.Template template,
            global::G.PromptTemplateType templateType,
            global::G.PromptTemplateFormat templateFormat,
            global::G.InvocationParameters invocationParameters,
            string id,
            string? description,
            global::G.PromptTools? tools,
            global::G.ResponseFormatVariant1? responseFormat)
        {
            this.Description = description;
            this.ModelProvider = modelProvider;
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Template = template;
            this.TemplateType = templateType;
            this.TemplateFormat = templateFormat;
            this.InvocationParameters = invocationParameters;
            this.Tools = tools;
            this.ResponseFormat = responseFormat;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersion" /> class.
        /// </summary>
        public PromptVersion()
        {
        }
    }
}