//HintName: G.Models.LLMUsageCalculatorPublicRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMUsageCalculatorPublicRequestModel
    {
        /// <summary>
        /// Length of the prompt in characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptLength { get; set; }

        /// <summary>
        /// Pages of content in PDF documents or URLs in the agent's knowledge base.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_of_pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumberOfPages { get; set; }

        /// <summary>
        /// Whether RAG is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RagEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMUsageCalculatorPublicRequestModel" /> class.
        /// </summary>
        /// <param name="promptLength">
        /// Length of the prompt in characters.
        /// </param>
        /// <param name="numberOfPages">
        /// Pages of content in PDF documents or URLs in the agent's knowledge base.
        /// </param>
        /// <param name="ragEnabled">
        /// Whether RAG is enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMUsageCalculatorPublicRequestModel(
            int promptLength,
            int numberOfPages,
            bool ragEnabled)
        {
            this.PromptLength = promptLength;
            this.NumberOfPages = numberOfPages;
            this.RagEnabled = ragEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMUsageCalculatorPublicRequestModel" /> class.
        /// </summary>
        public LLMUsageCalculatorPublicRequestModel()
        {
        }
    }
}