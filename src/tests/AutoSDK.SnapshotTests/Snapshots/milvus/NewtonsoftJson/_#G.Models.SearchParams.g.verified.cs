//HintName: G.Models.SearchParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchParams
    {
        /// <summary>
        ///       Determines the threshold of least similarity. When setting metric_type to L2, ensure that this value is greater than that of range_filter. Otherwise, this value should be lower than that of range_filter. 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("radius")]
        public int? Radius { get; set; }

        /// <summary>
        ///       Refines the search to vectors within a specific similarity range. When setting metric_type to IP or COSINE, ensure that this value is greater than that of radius. Otherwise, this value should be lower than that of radius. 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("range_filter")]
        public int? RangeFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchParams" /> class.
        /// </summary>
        /// <param name="radius">
        ///       Determines the threshold of least similarity. When setting metric_type to L2, ensure that this value is greater than that of range_filter. Otherwise, this value should be lower than that of range_filter. 
        /// </param>
        /// <param name="rangeFilter">
        ///       Refines the search to vectors within a specific similarity range. When setting metric_type to IP or COSINE, ensure that this value is greater than that of radius. Otherwise, this value should be lower than that of radius. 
        /// </param>
        public SearchParams(
            int? radius,
            int? rangeFilter)
        {
            this.Radius = radius;
            this.RangeFilter = rangeFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchParams" /> class.
        /// </summary>
        public SearchParams()
        {
        }
    }
}