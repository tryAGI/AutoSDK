//HintName: G.Models.GoogleSearch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GoogleSearch tool type. Tool to support Google Search in Model. Powered by Google.
    /// </summary>
    public sealed partial class GoogleSearch
    {
        /// <summary>
        /// Represents a time interval, encoded as a Timestamp start (inclusive) and a Timestamp end (exclusive). The start must be less than or equal to the end. When the start equals the end, the interval is empty (matches no time). When both start and end are unspecified, the interval matches any time.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeRangeFilter")]
        public global::G.Interval? TimeRangeFilter { get; set; }

        /// <summary>
        /// Different types of search that can be enabled on the GoogleSearch tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("searchTypes")]
        public global::G.SearchTypes? SearchTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleSearch" /> class.
        /// </summary>
        /// <param name="timeRangeFilter">
        /// Represents a time interval, encoded as a Timestamp start (inclusive) and a Timestamp end (exclusive). The start must be less than or equal to the end. When the start equals the end, the interval is empty (matches no time). When both start and end are unspecified, the interval matches any time.
        /// </param>
        /// <param name="searchTypes">
        /// Different types of search that can be enabled on the GoogleSearch tool.
        /// </param>
        public GoogleSearch(
            global::G.Interval? timeRangeFilter,
            global::G.SearchTypes? searchTypes)
        {
            this.TimeRangeFilter = timeRangeFilter;
            this.SearchTypes = searchTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleSearch" /> class.
        /// </summary>
        public GoogleSearch()
        {
        }
    }
}