//HintName: G.Models.ListCallsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListCallsResponse
    {
        /// <summary>
        /// Total calls matching filters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Number of calls returned in this response
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("calls")]
        public global::System.Collections.Generic.IList<global::G.CallSummary>? Calls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCallsResponse" /> class.
        /// </summary>
        /// <param name="totalCount">
        /// Total calls matching filters
        /// </param>
        /// <param name="count">
        /// Number of calls returned in this response
        /// </param>
        /// <param name="calls"></param>
        public ListCallsResponse(
            int? totalCount,
            int? count,
            global::System.Collections.Generic.IList<global::G.CallSummary>? calls)
        {
            this.TotalCount = totalCount;
            this.Count = count;
            this.Calls = calls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCallsResponse" /> class.
        /// </summary>
        public ListCallsResponse()
        {
        }
    }
}