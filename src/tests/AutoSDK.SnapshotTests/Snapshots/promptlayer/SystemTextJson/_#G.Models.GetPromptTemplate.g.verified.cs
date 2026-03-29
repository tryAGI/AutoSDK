//HintName: G.Models.GetPromptTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPromptTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public int? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public global::G.GetPromptTemplateProvider2? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? InputVariables { get; set; }

        /// <summary>
        /// Optional dictionary of key values used for A/B release labels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_filters")]
        public global::System.Collections.Generic.Dictionary<string, string>? MetadataFilters { get; set; }

        /// <summary>
        /// Optional model name used for returning default parameters with llm_kwargs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Optional dictionary of model parameter overrides to use with the prompt template. This will override the parameters at runtime for the specified model and will try to make sure the model supports these parameters. For example, if you supply `maxOutputTokens` for OpenAI, it will be converted to `max_completion_tokens`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_parameter_overrides")]
        public object? ModelParameterOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPromptTemplate" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="workspaceId"></param>
        /// <param name="label"></param>
        /// <param name="provider"></param>
        /// <param name="inputVariables"></param>
        /// <param name="metadataFilters">
        /// Optional dictionary of key values used for A/B release labels.
        /// </param>
        /// <param name="model">
        /// Optional model name used for returning default parameters with llm_kwargs.
        /// </param>
        /// <param name="modelParameterOverrides">
        /// Optional dictionary of model parameter overrides to use with the prompt template. This will override the parameters at runtime for the specified model and will try to make sure the model supports these parameters. For example, if you supply `maxOutputTokens` for OpenAI, it will be converted to `max_completion_tokens`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPromptTemplate(
            int? version,
            int? workspaceId,
            string? label,
            global::G.GetPromptTemplateProvider2? provider,
            global::System.Collections.Generic.Dictionary<string, string>? inputVariables,
            global::System.Collections.Generic.Dictionary<string, string>? metadataFilters,
            string? model,
            object? modelParameterOverrides)
        {
            this.Version = version;
            this.WorkspaceId = workspaceId;
            this.Label = label;
            this.Provider = provider;
            this.InputVariables = inputVariables;
            this.MetadataFilters = metadataFilters;
            this.Model = model;
            this.ModelParameterOverrides = modelParameterOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPromptTemplate" /> class.
        /// </summary>
        public GetPromptTemplate()
        {
        }
    }
}