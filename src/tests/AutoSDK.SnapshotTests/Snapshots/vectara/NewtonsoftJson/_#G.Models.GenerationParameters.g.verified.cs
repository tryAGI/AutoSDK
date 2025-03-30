//HintName: G.Models.GenerationParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The parameters to control generation.
    /// </summary>
    public sealed partial class GenerationParameters
    {
        /// <summary>
        /// The preset values to use to feed the query results and other context to the model.<br/>
        /// A `generation_preset` is an object with a bundle of properties that specifies:<br/>
        ///   * The `prompt_template` that is rendered and then sent to the LLM.<br/>
        ///   * The LLM used.<br/>
        ///   * `model_parameter`s such as temperature.<br/>
        ///  <br/>
        /// All of these properties except the model can be overridden by setting them in this<br/>
        /// object. Even when a `prompt_template` is set, the `generation_preset_name` is used to set <br/>
        /// the model used. See `model_parameters.model` if you want to set the model explicitly.<br/>
        /// If `generation_preset_name` is not set, the Vectara platform will use the default model and<br/>
        /// prompt.<br/>
        /// Example: vectara-summary-ext-v1.2.0
        /// </summary>
        /// <example>vectara-summary-ext-v1.2.0</example>
        [global::Newtonsoft.Json.JsonProperty("generation_preset_name")]
        public string? GenerationPresetName { get; set; }

        /// <summary>
        /// Use `generation_preset_name` instead of `prompt_name`.<br/>
        /// Example: vectara-summary-ext-v1.2.0
        /// </summary>
        /// <example>vectara-summary-ext-v1.2.0</example>
        [global::Newtonsoft.Json.JsonProperty("prompt_name")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? PromptName { get; set; }

        /// <summary>
        /// The maximum number of search results to be available to the prompt.<br/>
        /// Default Value: 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_used_search_results")]
        public int? MaxUsedSearchResults { get; set; }

        /// <summary>
        /// Vectara manages both system and user roles and prompts for the generative<br/>
        /// LLM out of the box by default. However, users can override the<br/>
        /// `prompt_template` via this variable. The `prompt_template` is in the form of an<br/>
        /// Apache Velocity template. For more details on how to configure the<br/>
        /// `prompt_template`, see the [long-form documentation](https://docs.vectara.com/docs/prompts/vectara-prompt-engine).<br/>
        /// Example: [<br/>
        ///   {"role": "system", "content": "You are a helpful search assistant."},<br/>
        ///   #foreach ($qResult in $vectaraQueryResults)<br/>
        ///      {"role": "user", "content": "Given the $vectaraIdxWord[$foreach.index] search result."},<br/>
        ///      {"role": "assistant", "content": "${qResult.getText()}" },<br/>
        ///   #end<br/>
        ///   {"role": "user", "content": "Generate a summary for the query '${vectaraQuery}' based on the above results."}<br/>
        /// ]
        /// </summary>
        /// <example>
        /// [<br/>
        ///   {"role": "system", "content": "You are a helpful search assistant."},<br/>
        ///   #foreach ($qResult in $vectaraQueryResults)<br/>
        ///      {"role": "user", "content": "Given the $vectaraIdxWord[$foreach.index] search result."},<br/>
        ///      {"role": "assistant", "content": "${qResult.getText()}" },<br/>
        ///   #end<br/>
        ///   {"role": "user", "content": "Generate a summary for the query '${vectaraQuery}' based on the above results."}<br/>
        /// ]
        /// </example>
        [global::Newtonsoft.Json.JsonProperty("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// This property is deprecated in favor of clearer naming. Use `prompt_template`. This property will be<br/>
        /// ignored if `prompt_template` is set.<br/>
        /// Example: [<br/>
        ///   {"role": "system", "content": "You are a helpful search assistant."},<br/>
        ///   #foreach ($qResult in $vectaraQueryResults)<br/>
        ///      {"role": "user", "content": "Given the $vectaraIdxWord[$foreach.index] search result."},<br/>
        ///      {"role": "assistant", "content": "${qResult.getText()}" },<br/>
        ///   #end<br/>
        ///   {"role": "user", "content": "Generate a summary for the query '${vectaraQuery}' based on the above results."}<br/>
        /// ]
        /// </summary>
        /// <example>
        /// [<br/>
        ///   {"role": "system", "content": "You are a helpful search assistant."},<br/>
        ///   #foreach ($qResult in $vectaraQueryResults)<br/>
        ///      {"role": "user", "content": "Given the $vectaraIdxWord[$foreach.index] search result."},<br/>
        ///      {"role": "assistant", "content": "${qResult.getText()}" },<br/>
        ///   #end<br/>
        ///   {"role": "user", "content": "Generate a summary for the query '${vectaraQuery}' based on the above results."}<br/>
        /// ]
        /// </example>
        [global::Newtonsoft.Json.JsonProperty("prompt_text")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? PromptText { get; set; }

        /// <summary>
        /// Controls the length of the generated output.<br/>
        /// This is a rough estimate and not a hard limit: the end output can be longer or shorter<br/>
        /// than this value. This is generally implemented by including the `max_response_characters` in the<br/>
        /// prompt, and the LLM's instruction following capability dictates how closely the generated output<br/>
        /// is limited.<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::Newtonsoft.Json.JsonProperty("max_response_characters")]
        public int? MaxResponseCharacters { get; set; }

        /// <summary>
        /// Languages that the Vectara platform supports.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_language")]
        public global::G.Language? ResponseLanguage { get; set; }

        /// <summary>
        /// The parameters for the model.<br/>
        /// WARNING: This is an experimental feature, and breakable at any point with virtually no<br/>
        /// notice. It is meant for experimentation to converge on optimal parameters that can then<br/>
        /// be set in the prompt definitions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_parameters")]
        public global::G.GenerationParametersModelParameters? ModelParameters { get; set; }

        /// <summary>
        /// Style the generator should use when making citations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("citations")]
        public global::G.CitationParameters? Citations { get; set; }

        /// <summary>
        /// Enable returning the factual consistency score with query results.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_factual_consistency_score")]
        public bool? EnableFactualConsistencyScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationParameters" /> class.
        /// </summary>
        /// <param name="generationPresetName">
        /// The preset values to use to feed the query results and other context to the model.<br/>
        /// A `generation_preset` is an object with a bundle of properties that specifies:<br/>
        ///   * The `prompt_template` that is rendered and then sent to the LLM.<br/>
        ///   * The LLM used.<br/>
        ///   * `model_parameter`s such as temperature.<br/>
        ///  <br/>
        /// All of these properties except the model can be overridden by setting them in this<br/>
        /// object. Even when a `prompt_template` is set, the `generation_preset_name` is used to set <br/>
        /// the model used. See `model_parameters.model` if you want to set the model explicitly.<br/>
        /// If `generation_preset_name` is not set, the Vectara platform will use the default model and<br/>
        /// prompt.<br/>
        /// Example: vectara-summary-ext-v1.2.0
        /// </param>
        /// <param name="maxUsedSearchResults">
        /// The maximum number of search results to be available to the prompt.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="promptTemplate">
        /// Vectara manages both system and user roles and prompts for the generative<br/>
        /// LLM out of the box by default. However, users can override the<br/>
        /// `prompt_template` via this variable. The `prompt_template` is in the form of an<br/>
        /// Apache Velocity template. For more details on how to configure the<br/>
        /// `prompt_template`, see the [long-form documentation](https://docs.vectara.com/docs/prompts/vectara-prompt-engine).<br/>
        /// Example: [<br/>
        ///   {"role": "system", "content": "You are a helpful search assistant."},<br/>
        ///   #foreach ($qResult in $vectaraQueryResults)<br/>
        ///      {"role": "user", "content": "Given the $vectaraIdxWord[$foreach.index] search result."},<br/>
        ///      {"role": "assistant", "content": "${qResult.getText()}" },<br/>
        ///   #end<br/>
        ///   {"role": "user", "content": "Generate a summary for the query '${vectaraQuery}' based on the above results."}<br/>
        /// ]
        /// </param>
        /// <param name="maxResponseCharacters">
        /// Controls the length of the generated output.<br/>
        /// This is a rough estimate and not a hard limit: the end output can be longer or shorter<br/>
        /// than this value. This is generally implemented by including the `max_response_characters` in the<br/>
        /// prompt, and the LLM's instruction following capability dictates how closely the generated output<br/>
        /// is limited.<br/>
        /// Example: 300
        /// </param>
        /// <param name="responseLanguage">
        /// Languages that the Vectara platform supports.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="modelParameters">
        /// The parameters for the model.<br/>
        /// WARNING: This is an experimental feature, and breakable at any point with virtually no<br/>
        /// notice. It is meant for experimentation to converge on optimal parameters that can then<br/>
        /// be set in the prompt definitions.
        /// </param>
        /// <param name="citations">
        /// Style the generator should use when making citations.
        /// </param>
        /// <param name="enableFactualConsistencyScore">
        /// Enable returning the factual consistency score with query results.<br/>
        /// Default Value: true
        /// </param>
        public GenerationParameters(
            string? generationPresetName,
            int? maxUsedSearchResults,
            string? promptTemplate,
            int? maxResponseCharacters,
            global::G.Language? responseLanguage,
            global::G.GenerationParametersModelParameters? modelParameters,
            global::G.CitationParameters? citations,
            bool? enableFactualConsistencyScore)
        {
            this.GenerationPresetName = generationPresetName;
            this.MaxUsedSearchResults = maxUsedSearchResults;
            this.PromptTemplate = promptTemplate;
            this.MaxResponseCharacters = maxResponseCharacters;
            this.ResponseLanguage = responseLanguage;
            this.ModelParameters = modelParameters;
            this.Citations = citations;
            this.EnableFactualConsistencyScore = enableFactualConsistencyScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationParameters" /> class.
        /// </summary>
        public GenerationParameters()
        {
        }
    }
}