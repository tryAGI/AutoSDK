//HintName: G.Models.UltravoxV1QueryCorpusRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A request to query a corpus.
    /// </summary>
    public sealed partial class UltravoxV1QueryCorpusRequest
    {
        /// <summary>
        /// The query to run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query")]
        public string? Query { get; set; }

        /// <summary>
        /// The maximum number of results to return.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxResults")]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1QueryCorpusRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// The query to run.
        /// </param>
        /// <param name="maxResults">
        /// The maximum number of results to return.
        /// </param>
        public UltravoxV1QueryCorpusRequest(
            string? query,
            int? maxResults)
        {
            this.Query = query;
            this.MaxResults = maxResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1QueryCorpusRequest" /> class.
        /// </summary>
        public UltravoxV1QueryCorpusRequest()
        {
        }
    }
}