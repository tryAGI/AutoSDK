//HintName: G.Models.SearchPayloadFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchPayloadFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_ids")]
        public global::System.Collections.Generic.IList<string>? QueryIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("where_clause")]
        public object? WhereClause { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPayloadFilter" /> class.
        /// </summary>
        /// <param name="queryIds"></param>
        /// <param name="whereClause"></param>
        public SearchPayloadFilter(
            global::System.Collections.Generic.IList<string>? queryIds,
            object? whereClause)
        {
            this.QueryIds = queryIds;
            this.WhereClause = whereClause;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPayloadFilter" /> class.
        /// </summary>
        public SearchPayloadFilter()
        {
        }
    }
}