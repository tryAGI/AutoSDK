//HintName: G.Models.BatchedFacetDataFacet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchedFacetDataFacet
    {
        /// <summary>
        /// The name of the facet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        /// Initializes a new instance of the <see cref="BatchedFacetDataFacet" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the facet
        /// </param>
        /// <param name="prompt">
        /// The prompt to use for LLM extraction. The preprocessed text will be provided as context.
        /// </param>
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
        public BatchedFacetDataFacet(
            string name,
            string prompt,
            string? model,
            string? embeddingModel,
            string? noMatchPattern)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Model = model;
            this.EmbeddingModel = embeddingModel;
            this.NoMatchPattern = noMatchPattern;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchedFacetDataFacet" /> class.
        /// </summary>
        public BatchedFacetDataFacet()
        {
        }
    }
}