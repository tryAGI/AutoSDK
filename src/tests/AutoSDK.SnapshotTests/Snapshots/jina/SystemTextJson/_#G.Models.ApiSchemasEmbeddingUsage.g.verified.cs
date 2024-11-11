//HintName: G.Models.ApiSchemasEmbeddingUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiSchemasEmbeddingUsage
    {
        /// <summary>
        /// The number of tokens used by all the texts in the input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Same as total_tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiSchemasEmbeddingUsage" /> class.
        /// </summary>
        /// <param name="totalTokens">
        /// The number of tokens used by all the texts in the input
        /// </param>
        /// <param name="promptTokens">
        /// Same as total_tokens
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ApiSchemasEmbeddingUsage(
            int totalTokens,
            int promptTokens)
        {
            this.TotalTokens = totalTokens;
            this.PromptTokens = promptTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiSchemasEmbeddingUsage" /> class.
        /// </summary>
        public ApiSchemasEmbeddingUsage()
        {
        }
    }
}