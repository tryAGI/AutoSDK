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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

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