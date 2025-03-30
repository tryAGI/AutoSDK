//HintName: G.Models.GenerationPreset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Bundle of default values used when calling generation. All values except<br/>
    /// model name can be overridden at generation time.
    /// </summary>
    public sealed partial class GenerationPreset
    {
        /// <summary>
        /// Name of the generation preset to be used with configuring generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the generation preset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Name of the model that these presets are used with. The list of available names can be<br/>
        /// fetched by the `GET /v2/llms` endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm_name")]
        public string? LlmName { get; set; }

        /// <summary>
        /// Preset template used to render the prompt sent to generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// Preset maximum number of search results that will be available to the prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_used_search_results")]
        public int? MaxUsedSearchResults { get; set; }

        /// <summary>
        /// Preset maximum number of tokens to be returned by the generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// The sampling temperature to use. Higher values make the output more random, while lower<br/>
        /// values make it more focused and deterministic.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Higher values penalize new tokens based on their existing frequency in the generation so far,<br/>
        /// decreasing the model's likelihood to repeat the same line verbatim.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequency_penalty")]
        public float? FrequencyPenalty { get; set; }

        /// <summary>
        /// Higher values penalize new tokens based on whether they appear in the generation so far,<br/>
        /// increasing the model's likelihood to talk about new topics.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presence_penalty")]
        public float? PresencePenalty { get; set; }

        /// <summary>
        /// Indicates whether the prompt is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Indicates if this prompt is the default prompt used with the LLM.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default")]
        public bool? Default { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationPreset" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the generation preset to be used with configuring generation.
        /// </param>
        /// <param name="description">
        /// Description of the generation preset.
        /// </param>
        /// <param name="llmName">
        /// Name of the model that these presets are used with. The list of available names can be<br/>
        /// fetched by the `GET /v2/llms` endpoint.
        /// </param>
        /// <param name="promptTemplate">
        /// Preset template used to render the prompt sent to generation.
        /// </param>
        /// <param name="maxUsedSearchResults">
        /// Preset maximum number of search results that will be available to the prompt.
        /// </param>
        /// <param name="maxTokens">
        /// Preset maximum number of tokens to be returned by the generation.
        /// </param>
        /// <param name="temperature">
        /// The sampling temperature to use. Higher values make the output more random, while lower<br/>
        /// values make it more focused and deterministic.
        /// </param>
        /// <param name="frequencyPenalty">
        /// Higher values penalize new tokens based on their existing frequency in the generation so far,<br/>
        /// decreasing the model's likelihood to repeat the same line verbatim.
        /// </param>
        /// <param name="presencePenalty">
        /// Higher values penalize new tokens based on whether they appear in the generation so far,<br/>
        /// increasing the model's likelihood to talk about new topics.
        /// </param>
        /// <param name="enabled">
        /// Indicates whether the prompt is enabled.
        /// </param>
        /// <param name="default">
        /// Indicates if this prompt is the default prompt used with the LLM.
        /// </param>
        public GenerationPreset(
            string? name,
            string? description,
            string? llmName,
            string? promptTemplate,
            int? maxUsedSearchResults,
            int? maxTokens,
            float? temperature,
            float? frequencyPenalty,
            float? presencePenalty,
            bool? enabled,
            bool? @default)
        {
            this.Name = name;
            this.Description = description;
            this.LlmName = llmName;
            this.PromptTemplate = promptTemplate;
            this.MaxUsedSearchResults = maxUsedSearchResults;
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
            this.FrequencyPenalty = frequencyPenalty;
            this.PresencePenalty = presencePenalty;
            this.Enabled = enabled;
            this.Default = @default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationPreset" /> class.
        /// </summary>
        public GenerationPreset()
        {
        }
    }
}