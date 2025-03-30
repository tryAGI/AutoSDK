//HintName: G.Models.SortParamsForRunsComparisonView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SortParamsForRunsComparisonView
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SortBy { get; set; }

        /// <summary>
        /// Default Value: DESC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_order")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SortParamsForRunsComparisonViewSortOrderJsonConverter))]
        public global::G.SortParamsForRunsComparisonViewSortOrder? SortOrder { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SortParamsForRunsComparisonView" /> class.
        /// </summary>
        /// <param name="sortBy"></param>
        /// <param name="sortOrder">
        /// Default Value: DESC
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SortParamsForRunsComparisonView(
            string sortBy,
            global::G.SortParamsForRunsComparisonViewSortOrder? sortOrder)
        {
            this.SortBy = sortBy ?? throw new global::System.ArgumentNullException(nameof(sortBy));
            this.SortOrder = sortOrder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SortParamsForRunsComparisonView" /> class.
        /// </summary>
        public SortParamsForRunsComparisonView()
        {
        }
    }
}