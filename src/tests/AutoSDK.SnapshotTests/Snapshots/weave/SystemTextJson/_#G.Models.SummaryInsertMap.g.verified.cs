//HintName: G.Models.SummaryInsertMap.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SummaryInsertMap
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::System.Collections.Generic.Dictionary<string, global::G.LLMUsageSchema>? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_counts")]
        public global::System.Collections.Generic.Dictionary<string, int>? StatusCounts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryInsertMap" /> class.
        /// </summary>
        /// <param name="usage"></param>
        /// <param name="statusCounts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummaryInsertMap(
            global::System.Collections.Generic.Dictionary<string, global::G.LLMUsageSchema>? usage,
            global::System.Collections.Generic.Dictionary<string, int>? statusCounts)
        {
            this.Usage = usage;
            this.StatusCounts = statusCounts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryInsertMap" /> class.
        /// </summary>
        public SummaryInsertMap()
        {
        }
    }
}