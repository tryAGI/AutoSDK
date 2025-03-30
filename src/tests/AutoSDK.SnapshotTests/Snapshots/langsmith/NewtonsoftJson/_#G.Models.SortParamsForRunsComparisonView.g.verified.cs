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
        [global::Newtonsoft.Json.JsonProperty("sort_by", Required = global::Newtonsoft.Json.Required.Always)]
        public string SortBy { get; set; } = default!;

        /// <summary>
        /// Default Value: DESC
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sort_order")]
        public global::G.SortParamsForRunsComparisonViewSortOrder? SortOrder { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SortParamsForRunsComparisonView" /> class.
        /// </summary>
        /// <param name="sortBy"></param>
        /// <param name="sortOrder">
        /// Default Value: DESC
        /// </param>
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