//HintName: G.Models.RerankingResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankingResult
    {
        /// <summary>
        /// The original document text.<br/>
        /// Example: Machine learning is a subset of artificial intelligence
        /// </summary>
        /// <example>Machine learning is a subset of artificial intelligence</example>
        [global::Newtonsoft.Json.JsonProperty("doc", Required = global::Newtonsoft.Json.Required.Always)]
        public string Doc { get; set; } = default!;

        /// <summary>
        /// Relevance score between 0.0 and 1.0, where higher scores indicate <br/>
        /// greater relevance to the query.<br/>
        /// Example: 0.92
        /// </summary>
        /// <example>0.92</example>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public float Score { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankingResult" /> class.
        /// </summary>
        /// <param name="doc">
        /// The original document text.<br/>
        /// Example: Machine learning is a subset of artificial intelligence
        /// </param>
        /// <param name="score">
        /// Relevance score between 0.0 and 1.0, where higher scores indicate <br/>
        /// greater relevance to the query.<br/>
        /// Example: 0.92
        /// </param>
        public RerankingResult(
            string doc,
            float score)
        {
            this.Doc = doc ?? throw new global::System.ArgumentNullException(nameof(doc));
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankingResult" /> class.
        /// </summary>
        public RerankingResult()
        {
        }
    }
}