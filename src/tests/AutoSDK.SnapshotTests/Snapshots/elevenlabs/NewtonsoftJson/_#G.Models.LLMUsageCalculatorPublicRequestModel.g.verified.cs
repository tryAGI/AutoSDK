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
        [global::Newtonsoft.Json.JsonProperty("prompt_length", Required = global::Newtonsoft.Json.Required.Always)]
        public int PromptLength { get; set; } = default!;

        /// <summary>
        /// Pages of content in PDF documents or URLs in the agent's knowledge base.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number_of_pages", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumberOfPages { get; set; } = default!;

        /// <summary>
        /// Whether RAG is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rag_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool RagEnabled { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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