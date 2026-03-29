//HintName: G.Models.RerankingRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankingRequest
    {
        /// <summary>
        /// ID of the reranking model to use.<br/>
        /// Example: qwen3-reranker-4b
        /// </summary>
        /// <example>qwen3-reranker-4b</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The search query to rank documents against.<br/>
        /// Example: artificial intelligence research
        /// </summary>
        /// <example>artificial intelligence research</example>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// An array of documents to rank. Each document is a string containing the text content.<br/>
        /// Maximum of 100 documents per request.<br/>
        /// Example: [Machine learning is a subset of artificial intelligence, The weather forecast predicts rain tomorrow, Deep learning uses neural networks with multiple layers]
        /// </summary>
        /// <example>[Machine learning is a subset of artificial intelligence, The weather forecast predicts rain tomorrow, Deep learning uses neural networks with multiple layers]</example>
        [global::Newtonsoft.Json.JsonProperty("docs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Docs { get; set; } = default!;

        /// <summary>
        /// Optional instruction to guide the reranking process. If not provided, <br/>
        /// a default instruction will be used.<br/>
        /// Example: Find the most relevant document about AI research
        /// </summary>
        /// <example>Find the most relevant document about AI research</example>
        [global::Newtonsoft.Json.JsonProperty("instruction")]
        public string? Instruction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankingRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// ID of the reranking model to use.<br/>
        /// Example: qwen3-reranker-4b
        /// </param>
        /// <param name="query">
        /// The search query to rank documents against.<br/>
        /// Example: artificial intelligence research
        /// </param>
        /// <param name="docs">
        /// An array of documents to rank. Each document is a string containing the text content.<br/>
        /// Maximum of 100 documents per request.<br/>
        /// Example: [Machine learning is a subset of artificial intelligence, The weather forecast predicts rain tomorrow, Deep learning uses neural networks with multiple layers]
        /// </param>
        /// <param name="instruction">
        /// Optional instruction to guide the reranking process. If not provided, <br/>
        /// a default instruction will be used.<br/>
        /// Example: Find the most relevant document about AI research
        /// </param>
        public RerankingRequest(
            string model,
            string query,
            global::System.Collections.Generic.IList<string> docs,
            string? instruction)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Docs = docs ?? throw new global::System.ArgumentNullException(nameof(docs));
            this.Instruction = instruction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankingRequest" /> class.
        /// </summary>
        public RerankingRequest()
        {
        }
    }
}