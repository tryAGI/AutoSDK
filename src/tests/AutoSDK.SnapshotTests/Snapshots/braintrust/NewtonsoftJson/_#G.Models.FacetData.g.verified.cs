//HintName: G.Models.FacetData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FacetData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FacetDataTypeJsonConverter))]
        public global::G.FacetDataType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preprocessor")]
        public global::G.AllOf<global::G.NullableSavedFunctionId?, object>? Preprocessor { get; set; }

        /// <summary>
        /// The prompt to use for LLM extraction. The preprocessed text will be provided as context.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// The model to use for facet extraction
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The embedding model to use for vectorizing facet results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_model")]
        public string? EmbeddingModel { get; set; }

        /// <summary>
        /// Regex pattern to identify outputs that do not match the facet. If the output matches, the facet will be saved as 'no_match'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("no_match_pattern")]
        public string? NoMatchPattern { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FacetData" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to use for LLM extraction. The preprocessed text will be provided as context.
        /// </param>
        /// <param name="type"></param>
        /// <param name="preprocessor"></param>
        /// <param name="model">
        /// The model to use for facet extraction
        /// </param>
        /// <param name="embeddingModel">
        /// The embedding model to use for vectorizing facet results.
        /// </param>
        /// <param name="noMatchPattern">
        /// Regex pattern to identify outputs that do not match the facet. If the output matches, the facet will be saved as 'no_match'
        /// </param>
        public FacetData(
            string prompt,
            global::G.FacetDataType type,
            global::G.AllOf<global::G.NullableSavedFunctionId?, object>? preprocessor,
            string? model,
            string? embeddingModel,
            string? noMatchPattern)
        {
            this.Type = type;
            this.Preprocessor = preprocessor;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Model = model;
            this.EmbeddingModel = embeddingModel;
            this.NoMatchPattern = noMatchPattern;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacetData" /> class.
        /// </summary>
        public FacetData()
        {
        }
    }
}