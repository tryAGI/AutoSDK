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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FacetDataTypeJsonConverter))]
        public global::G.FacetDataType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preprocessor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverter<global::G.NullableSavedFunctionId?, object>))]
        public global::G.AllOf<global::G.NullableSavedFunctionId?, object>? Preprocessor { get; set; }

        /// <summary>
        /// The prompt to use for LLM extraction. The preprocessed text will be provided as context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The model to use for facet extraction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The embedding model to use for vectorizing facet results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_model")]
        public string? EmbeddingModel { get; set; }

        /// <summary>
        /// Regex pattern to identify outputs that do not match the facet. If the output matches, the facet will be saved as 'no_match'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_match_pattern")]
        public string? NoMatchPattern { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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