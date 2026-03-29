//HintName: G.Models.RAGAnalysis.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RAGAnalysis
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RAGAccuracy> Details { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rag_accurate_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double RagAccurateCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rag_total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double RagTotalCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGAnalysis" /> class.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="ragAccurateCount"></param>
        /// <param name="ragTotalCount"></param>
        public RAGAnalysis(
            global::System.Collections.Generic.IList<global::G.RAGAccuracy> details,
            double ragAccurateCount,
            double ragTotalCount)
        {
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
            this.RagAccurateCount = ragAccurateCount;
            this.RagTotalCount = ragTotalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGAnalysis" /> class.
        /// </summary>
        public RAGAnalysis()
        {
        }
    }
}