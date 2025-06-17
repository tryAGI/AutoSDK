//HintName: G.Models.LLMUsageCalculatorRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMUsageCalculatorRequestModel
    {
        /// <summary>
        /// Length of the prompt in characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_length")]
        public int? PromptLength { get; set; }

        /// <summary>
        /// Pages of content in pdf documents OR urls in agent's Knowledge Base.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_of_pages")]
        public int? NumberOfPages { get; set; }

        /// <summary>
        /// Whether RAG is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_enabled")]
        public bool? RagEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMUsageCalculatorRequestModel" /> class.
        /// </summary>
        /// <param name="promptLength">
        /// Length of the prompt in characters.
        /// </param>
        /// <param name="numberOfPages">
        /// Pages of content in pdf documents OR urls in agent's Knowledge Base.
        /// </param>
        /// <param name="ragEnabled">
        /// Whether RAG is enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMUsageCalculatorRequestModel(
            int? promptLength,
            int? numberOfPages,
            bool? ragEnabled)
        {
            this.PromptLength = promptLength;
            this.NumberOfPages = numberOfPages;
            this.RagEnabled = ragEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMUsageCalculatorRequestModel" /> class.
        /// </summary>
        public LLMUsageCalculatorRequestModel()
        {
        }
    }
}