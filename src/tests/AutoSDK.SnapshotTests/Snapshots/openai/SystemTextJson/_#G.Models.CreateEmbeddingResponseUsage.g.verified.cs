//HintName: G.Models.CreateEmbeddingResponseUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The usage information for the request.
    /// </summary>
    public sealed partial class CreateEmbeddingResponseUsage
    {
        /// <summary>
        /// The number of tokens used by the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        /// The total number of tokens used by the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingResponseUsage" /> class.
        /// </summary>
        /// <param name="promptTokens">
        /// The number of tokens used by the prompt.
        /// </param>
        /// <param name="totalTokens">
        /// The total number of tokens used by the request.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateEmbeddingResponseUsage(
            int promptTokens,
            int totalTokens)
        {
            this.PromptTokens = promptTokens;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingResponseUsage" /> class.
        /// </summary>
        public CreateEmbeddingResponseUsage()
        {
        }
    }
}