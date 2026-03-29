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
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.RAGAccuracy> Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_accurate_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RagAccurateCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RagTotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGAnalysis" /> class.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="ragAccurateCount"></param>
        /// <param name="ragTotalCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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