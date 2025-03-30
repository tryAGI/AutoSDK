//HintName: G.Models.ListQueryHistoriesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An array of query histories.
    /// </summary>
    public sealed partial class ListQueryHistoriesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queries")]
        public global::System.Collections.Generic.IList<global::G.QueryHistorySummary>? Queries { get; set; }

        /// <summary>
        /// The metadata for the list of query histories.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.ListQueryHistoriesResponseMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListQueryHistoriesResponse" /> class.
        /// </summary>
        /// <param name="queries"></param>
        /// <param name="metadata">
        /// The metadata for the list of query histories.
        /// </param>
        public ListQueryHistoriesResponse(
            global::System.Collections.Generic.IList<global::G.QueryHistorySummary>? queries,
            global::G.ListQueryHistoriesResponseMetadata? metadata)
        {
            this.Queries = queries;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListQueryHistoriesResponse" /> class.
        /// </summary>
        public ListQueryHistoriesResponse()
        {
        }
    }
}