//HintName: G.Models.NodeTransitionAnalysis.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeTransitionAnalysis
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.NodeTransitionAnalysisDetail> Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accuracy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Accuracy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("correct_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CorrectCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeTransitionAnalysis" /> class.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="accuracy"></param>
        /// <param name="correctCount"></param>
        /// <param name="totalCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeTransitionAnalysis(
            global::System.Collections.Generic.IList<global::G.NodeTransitionAnalysisDetail> details,
            double accuracy,
            double correctCount,
            double totalCount)
        {
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
            this.Accuracy = accuracy;
            this.CorrectCount = correctCount;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeTransitionAnalysis" /> class.
        /// </summary>
        public NodeTransitionAnalysis()
        {
        }
    }
}