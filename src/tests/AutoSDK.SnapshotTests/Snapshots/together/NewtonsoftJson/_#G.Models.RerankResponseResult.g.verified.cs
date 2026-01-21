//HintName: G.Models.RerankResponseResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankResponseResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("relevance_score", Required = global::Newtonsoft.Json.Required.Always)]
        public double RelevanceScore { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RerankResponseResultDocument Document { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResponseResult" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="relevanceScore"></param>
        /// <param name="document"></param>
        public RerankResponseResult(
            int index,
            double relevanceScore,
            global::G.RerankResponseResultDocument document)
        {
            this.Index = index;
            this.RelevanceScore = relevanceScore;
            this.Document = document ?? throw new global::System.ArgumentNullException(nameof(document));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResponseResult" /> class.
        /// </summary>
        public RerankResponseResult()
        {
        }
    }
}